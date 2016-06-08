using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using core_lib.common;
using domain_lib.dto;
using domain_lib.model;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Expression;
using NHibernate.Transform;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace domain_lib.persistence
{
    /// <summary>
    /// Specifies whether to begin a new session, continue an existing session, or end an existing session.
    /// </summary>
    public enum SessionAction { Begin, Continue, End, BeginAndEnd }

    public class PersistenceManager : IDisposable
    {
        #region Declarations

        // Member variables
        private ISessionFactory m_SessionFactory = null;
        private ISession m_Session = null;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PersistenceManager()
        {
            this.ConfigureLog4Net();
            this.ConfigureNHibernate();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            m_SessionFactory.Dispose();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Close this Persistence Manager and release all resources (connection pools, etc). It is the responsibility of the application to ensure that there are no open Sessions before calling Close().
        /// </summary>
        public void Close()
        {
            m_SessionFactory.Close();
        }

        /// <summary>
        /// Deletes an object of a specified type.
        /// </summary>
        /// <param name="item">The item to delete.</param>
        /// <typeparam name="T">The type of object to delete.</typeparam>
        public void Delete<T>(T item)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    session.Delete(item);
                    session.Transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Deletes objects of a specified type.
        /// </summary>
        /// <param name="itemsToDelete">The items to delete.</param>
        /// <typeparam name="T">The type of objects to delete.</typeparam>
        public void Delete<T>(IList<T> itemsToDelete)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                foreach (T item in itemsToDelete)
                {
                    using (session.BeginTransaction())
                    {
                        session.Delete(item);
                        session.Transaction.Commit();
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves all objects of a given type.
        /// </summary>
        /// <typeparam name="T">The type of the objects to be retrieved.</typeparam>
        /// <returns>A list of all objects of the specified type.</returns>
        public IList<T> RetrieveAll<T>(SessionAction sessionAction)
        {
            /* Note that NHibernate guarantees that two object references will point to the
             * same object only if the references are set in the same session. For example,
             * Order #123 under the Customer object Able Inc and Order #123 in the Orders
             * list will point to the same object only if we load Customers and Orders in 
             * the same session. If we load them in different sessions, then changes that
             * we make to Able Inc's Order #123 will not be reflected in Order #123 in the
             * Orders list, since the references point to different objects. That's why we
             * maintain a session as a member variable, instead of as a local variable. */

            // Open a new session if specified
            if ((sessionAction == SessionAction.Begin) || (sessionAction == SessionAction.BeginAndEnd))
            {
                m_Session = m_SessionFactory.OpenSession();
            }

            // Retrieve all objects of the type passed in
            ICriteria targetObjects = m_Session.CreateCriteria(typeof(T));
            IList<T> itemList = targetObjects.List<T>();

            // Close the session if specified
            if ((sessionAction == SessionAction.End) || (sessionAction == SessionAction.BeginAndEnd))
            {
                m_Session.Close();
                m_Session.Dispose();
            }

            // Set return value
            return itemList;
        }

        /// <summary>
        /// Retrieves objects of a specified type where a specified property equals a specified value.
        /// </summary>
        /// <typeparam name="T">The type of the objects to be retrieved.</typeparam>
        /// <param name="mapParams">The map of the property to be tested.</param>
        /// <returns>A list of all objects meeting the specified criteria.</returns>
        public IList<T> RetrieveEquals<T>(Hashtable mapParams)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                // Create a criteria object with the specified criteria
                ICriteria criteria = session.CreateCriteria(typeof(T));
                foreach (DictionaryEntry entry in mapParams)
                {
                    criteria.Add(Expression.Eq(entry.Key.ToString(), entry.Value));
                }

                // Get the matching objects
                IList<T> matchingObjects = criteria.List<T>();

                // Set return value
                return matchingObjects;
            }
        }

        /// <summary>
        /// Retrieves objects of a specified type where a specified property equals a specified value.
        /// </summary>
        /// <typeparam name="T">The type of the objects to be retrieved.</typeparam>
        /// <param name="propertyName">The name of the property to be tested.</param>
        /// <param name="propertyValue">The value that the named property must hold.</param>
        /// <returns>A list of all objects meeting the specified criteria.</returns>
        public IList<T> RetrieveEquals<T>(string propertyName, object propertyValue)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                // Create a criteria object with the specified criteria
                ICriteria criteria = session.CreateCriteria(typeof(T));
                criteria.Add(Expression.Eq(propertyName, propertyValue));

                // Get the matching objects
                IList<T> matchingObjects = criteria.List<T>();

                // Set return value
                return matchingObjects;
            }
        }

        /// <summary>
        /// Retrieves objects of a specified type where a specified property equals a specified value.
        /// </summary>
        /// <typeparam name="T">The type of the objects to be retrieved.</typeparam>
        /// <param name="propertyName">The name of the property to be tested.</param>
        /// <param name="propertyValue">The value that the named property must hold.</param>
        /// <returns>A list of all objects meeting the specified criteria.</returns>
        public IList<T> RetrieveEqualsWithOrder<T>(string propertyName, object propertyValue, string orderField, string orderType)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                // Create a criteria object with the specified criteria
                ICriteria criteria = session.CreateCriteria(typeof(T));
                criteria.Add(Expression.Eq(propertyName, propertyValue));
                if (string.Compare(orderType, "ASC", true) == 0)
                {
                    criteria.AddOrder(Order.Asc(orderField));
                }
                else
                {
                    criteria.AddOrder(Order.Desc(orderField));
                }

                // Get the matching objects
                IList<T> matchingObjects = criteria.List<T>();

                // Set return value
                return matchingObjects;
            }
        }

        /// <summary>
        /// Saves an object and its persistent children.
        /// </summary>
        public void Save<T>(T item)
        {
            using (var session = m_SessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    session.SaveOrUpdate(item);
                    session.Transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Saves an new object and its persistent children.
        /// </summary>
        public void SaveNew<T>(T item)
        {
            using (var session = m_SessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    session.Save(item);
                    session.Transaction.Commit();
                }
            }
        }

        public CurrentIdentity GetCurrentIdentity(string tableName)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                // Create a criteria object with the specified criteria
                string sqlStr = "SELECT IDENT_CURRENT(:tableName) as Value";
                ISQLQuery sqlQuery = session.CreateSQLQuery(sqlStr);
                sqlQuery.AddScalar("Value", NHibernateUtil.Int64);
                sqlQuery.SetString("tableName", tableName);
                sqlQuery.SetResultTransformer(Transformers.AliasToBean(typeof(CurrentIdentity)));

                // Set return value
                return sqlQuery.UniqueResult<CurrentIdentity>();
            }
        }

        public UserDto checkUser(string userName, string password)
        {
            var userDto = new UserDto();
            if (String.IsNullOrEmpty(userName))
            {
                userDto.Message = "Chưa nhập tên đăng nhập. Vui lòng thử lại.";
                return userDto;
            }
            if (String.IsNullOrEmpty(password))
            {
                userDto.Message = "Chưa nhập mật khẩu. Vui lòng thử lại.";
                return userDto;
            }
            var users = RetrieveEquals<Users>("UserName", userName.ToUpper());
            if (users.Count == 0)
            {
                userDto.Message = "Người dùng chưa đăng ký. Vui lòng thử lại.";
                return userDto;
            }
            var user = users[0];
            if (string.Compare(MD5Util.EncodeMD5(password), user.Password, true) != 0)
            {
                userDto.Message = "Mật khẩu không khớp. Vui lòng thử lại.";
                return userDto;
            }
            userDto.UserID = user.UserID;
            userDto.UserName = user.UserName;
            userDto.FullName = user.FullName;
            userDto.AllRoles = GetAllUserRole(user.UserID).ToArray();
            return userDto;
        }

        public List<RoleDto> GetAllUserRole(long userId)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("select new Roles(r.RoleID, r.RoleCode, r.Description) from Roles r, UserRole ur "
                    + " where r.RoleID = ur.RoleID and r.Status = 1 and ur.IsActive = :status and ur.UserID = :userId");
                query.SetParameter("status", true);
                query.SetParameter("userId", userId);

                // Get the matching objects
                var allRoleInfos = query.List();

                // Update Role info
                var listRoleDtos = new List<RoleDto>();
                foreach (Roles roleInfo in allRoleInfos)
                {

                    var roleDto = new RoleDto
                    {
                        RoleID = roleInfo.RoleID,
                        RoleCode = roleInfo.RoleCode,
                        Description = roleInfo.Description
                    };
                    listRoleDtos.Add(roleDto);
                }
                return listRoleDtos;
            }
        }

        public string changePassword(string userId, string oldPassword, string newPassword)
        {
            if (String.IsNullOrEmpty(userId))
            {
                return "-1";
            }
            if (String.IsNullOrEmpty(oldPassword))
            {
                return "-2";
            }
            var users = RetrieveEquals<Users>("UserID", long.Parse(userId));
            if (users.Count == 0)
            {
                return "-3";
            }
            var user = users[0];
            oldPassword = MD5Util.EncodeMD5(oldPassword);
            newPassword = MD5Util.EncodeMD5(newPassword);
            if (string.Compare(oldPassword, user.Password, true) != 0)
            {
                return "-4";
            }
            if (String.IsNullOrEmpty(newPassword))
            {
                return "-5";
            }
            if (string.Compare(oldPassword, newPassword, true) == 0)
            {
                return "-6";
            }

            // Update new password
            user.Password = newPassword;

            // Save user
            Save(user);
            return "0";
        }

        public string GetTenNsd(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return String.Empty;
            }
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("select u.FullName from Users u "
                    + " where u.UserID = :userId");
                query.SetParameter("userId", long.Parse(userId));

                // Get the matching objects
                var fullName = query.UniqueResult<string>();

                // Set return value
                if (fullName == null)
                {
                    return String.Empty;
                }
                return fullName;
            }
        }

        public string GetUserName(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return String.Empty;
            }
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("select u.UserName from Users u "
                    + " where u.UserID = :userId");
                query.SetParameter("userId", long.Parse(userId));

                // Get the matching objects
                var userName = query.UniqueResult<string>();

                // Set return value
                if (userName == null)
                {
                    return String.Empty;
                }
                return userName;
            }
        }

        public List<BillDto> GetAllBill()
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("select new Bill(b.Id, b.BillingNumber, b.BillingDate, "
                    + "b.TableId, t.Position, b.Payment, b.CreatedBy, b.CreatedDate, b.IsPrinted, b.CancelReason) "
                    + "from Bill b, ResTable t "
                    + " where b.TableId = t.Id");

                // Get the matching objects
                var allBills = query.List();

                var listBillDtos = new List<BillDto>();
                foreach (Bill bill in allBills)
                {
                    var billDto = new BillDto()
                    {
                        Id = bill.Id,
                        BillingNumber = bill.BillingNumber,
                        BillingDate = DateUtil.GetDateTimeAsDdmmyyyy(bill.BillingDate),
                        TableId = bill.TableId,
                        TableNumber = bill.TableNumber,
                        Payment = bill.Payment,
                        EmployeeId = bill.EmployeeId,
                        EmployeeName = bill.EmployeeName,
                        CreatedBy = bill.CreatedBy,
                        CreatedDate = DateUtil.GetDateTimeAsDdmmyyyy(bill.CreatedDate),
                        IsPrinted = bill.IsPrinted,
                        CancelReason = bill.CancelReason
                    };
                    listBillDtos.Add(billDto);
                }
                return listBillDtos;
            }
        }

        public List<MaterialDto> GetAllMaterial()
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("select new Material(b.Id, b.UnitId, b.Code, b.Name) "
                        + "from Material b"); 

                // Get the matching objects
                var allMaterials = query.List();

                // Update Role info
                var listMaterialDtos = new List<MaterialDto>();
                foreach (Material material in allMaterials)
                {
                    var units = RetrieveEquals<Unit>("Id", material.UnitId);

                    var materialDto = new MaterialDto()
                    {
                        Id = material.Id,
                        UnitId = material.UnitId,
                        Code = material.Code,
                        Name = material.Name,
                        UnitCode = units[0].Code,
                        UnitName = units[0].Name
                    };
                    listMaterialDtos.Add(materialDto);
                }
                return listMaterialDtos;
            }
        }

        public List<BillDto> GetAllNotCompletedBill()
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("select new Bill(b.Id, b.BillingNumber, b.BillingDate, "
                    + "b.TableId, t.Position, b.Payment, b.CreatedBy, b.CreatedDate, b.IsPrinted, b.CancelReason) "
                    + "from Bill b, ResTable t "
                    + " where b.TableId = t.Id and b.Payment <> :payment1 and b.Payment <> :payment2");
                query.SetParameter("payment1", ConstUtil.YES);
                query.SetParameter("payment2", ConstUtil.CANCEL);

                // Get the matching objects
                var allBills = query.List();

                // Update Role info
                var listBillDtos = new List<BillDto>();
                foreach (Bill bill in allBills)
                {


                    var billDto = new BillDto()
                    {
                        Id = bill.Id,
                        BillingNumber = bill.BillingNumber,
                        BillingDate = DateUtil.GetDateTimeAsDdmmyyyy(bill.BillingDate),
                        TableId = bill.TableId,
                        TableNumber = bill.TableNumber,
                        Payment = bill.Payment,
                        CreatedBy = bill.CreatedBy,
                        CreatedDate = DateUtil.GetDateTimeAsDdmmyyyy(bill.CreatedDate),
                        IsPrinted = bill.IsPrinted,
                        CancelReason = bill.CancelReason
                    };
                    listBillDtos.Add(billDto);
                }
                return listBillDtos;
            }
        }

        public long GetTableIdByNumber(string tableNumber)
        {
            if (string.IsNullOrEmpty(tableNumber))
            {
                return -1;
            }
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("select t.Id from ResTable t "
                    + " where t.Position = :tableNumber");
                query.SetParameter("tableNumber", tableNumber);

                // Get the matching objects
                return query.UniqueResult<long>();
            }
        }

        public MenuDto getMenuDto(long menuId)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("select new Menu(m.Id, m.CategoryId, m.Code, m.Name, m.UnitId, u.Name, m.Price, m.Description, "
                    + "m.IsActive, m.CreatedBy, m.CreatedDate, m.UpdatedBy, m.UpdatedDate) "
                    + "from Menu m, Unit u where m.UnitId = u.Id and m.IsActive = :isActive and m.Id = :menuId");
                query.SetParameter("isActive", ConstUtil.YES);
                query.SetParameter("menuId", menuId);

                // Get the matching objects
                var menu = query.UniqueResult<Menu>();
                if (menu == null)
                {
                    return new MenuDto();
                }
                return new MenuDto()
                           {
                               Id = menu.Id,
                               Code = menu.Code,
                               Name = menu.Name,
                               CategoryId = menu.CategoryId,
                               UnitId = menu.UnitId,
                               UnitName = menu.UnitName,
                               Price = menu.Price,
                               Description = menu.Description,
                               IsActive = menu.IsActive,
                               CreatedBy = menu.CreatedBy,
                               CreatedDate = menu.CreatedDate,
                               UpdatedBy = menu.UpdatedBy,
                               UpdatedDate = menu.UpdatedDate
                           };
            }
        }

        public List<ResTableDto> GetAllResTableDto()
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("from ResTable b order by b.Code asc");

                // Get the matching objects
                var allResTables = query.List();

                // Update Role info
                var listResTableDtos = new List<ResTableDto>();
                foreach (ResTable resTable in allResTables)
                {
                    var resTableDto = new ResTableDto()
                    {
                        Id = resTable.Id,
                        Code = resTable.Code,
                        Position = resTable.Position
                    };
                    listResTableDtos.Add(resTableDto);
                }
                return listResTableDtos;
            }
        }

        public List<MenuDto> GetAllMenuDto()
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("from Menu m where m.IsActive = :isActive order by m.Code asc");
                query.SetParameter("isActive", "YES");

                // Get the matching objects
                var allMenus = query.List();

                // Update Role info
                var listMenuDtos = new List<MenuDto>();
                foreach (Menu menu in allMenus)
                {
                    var resTableDto = new MenuDto()
                    {
                        Id = menu.Id,
                        CategoryId = menu.CategoryId,
                        Code = menu.Code,
                        Name = menu.Name,
                        UnitId = menu.UnitId,
                        Price = menu.Price,
                        Description = menu.Description,
                        IsActive = menu.IsActive,
                        CreatedBy = menu.CreatedBy,
                        CreatedDate = menu.CreatedDate,
                        UpdatedBy = menu.UpdatedBy,
                        UpdatedDate = menu.UpdatedDate
                    };
                    listMenuDtos.Add(resTableDto);
                }
                return listMenuDtos;
            }
        }

        public List<DanhMucDto> GetAllCategory()
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("from Category c order by c.Code asc");

                // Get the matching objects
                var allCategories = query.List();

                var listCategoryDtos = new List<DanhMucDto>();
                foreach (Category category in allCategories)
                {
                    var dto = new DanhMucDto()
                    {
                        Id = Convert.ToString(category.Id),
                        Ma = category.Code,
                        Ten = category.Name
                    };
                    listCategoryDtos.Add(dto);
                }
                return listCategoryDtos;
            }
        }

        public List<DanhMucDto> GetAllUnit()
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("from Unit c order by c.Code asc");

                // Get the matching objects
                var allUnits = query.List();

                var listUnitDtos = new List<DanhMucDto>();
                foreach (Unit unit in allUnits)
                {
                    var dto = new DanhMucDto()
                    {
                        Id = Convert.ToString(unit.Id),
                        Ma = unit.Code,
                        Ten = unit.Name
                    };
                    listUnitDtos.Add(dto);
                }
                return listUnitDtos;
            }
        }

        public List<MenuDto> GetAllMenuBy(long categoryId)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("select new Menu(m.Id, m.CategoryId, m.Code, m.Name, m.UnitId, u.Name, m.Price, m.Description, "
                    +"m.IsActive, m.CreatedBy, m.CreatedDate, m.UpdatedBy, m.UpdatedDate) "
                    +"from Menu m, Unit u where m.UnitId = u.Id and m.IsActive = :isActive and m.CategoryId = :categoryId order by m.Code asc");
                query.SetParameter("isActive", ConstUtil.YES);
                query.SetParameter("categoryId", categoryId);

                // Get the matching objects
                var allMenus = query.List();

                var listMenuDtos = new List<MenuDto>();
                foreach (Menu menu in allMenus)
                {
                    var resTableDto = new MenuDto()
                    {
                        Id = menu.Id,
                        CategoryId = menu.CategoryId,
                        Code = menu.Code,
                        Name = menu.Name,
                        UnitId = menu.UnitId,
                        UnitName = menu.UnitName,
                        Price = menu.Price,
                        Description = menu.Description,
                        IsActive = menu.IsActive,
                        CreatedBy = menu.CreatedBy,
                        CreatedDate = menu.CreatedDate,
                        UpdatedBy = menu.UpdatedBy,
                        UpdatedDate = menu.UpdatedDate
                    };
                    listMenuDtos.Add(resTableDto);
                }
                return listMenuDtos;
            }
        }

        public List<ResOrderDto> GetAllResOrderDto(StatisticMenuSearchDto dto)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                string sqlQuery = "select new ResOrder(o.Id, m.Name, o.Amount, o.Discount, u.Name, m.Price)"
                                     + " from ResOrder o, Menu m, Unit u where o.MenuId = m.Id and m.UnitId = u.Id";
                var mapParams = new Hashtable();
                if (!String.IsNullOrEmpty(dto.FromDate))
                {
                    sqlQuery += " and o.CreatedDate >= :fromDate";
                    mapParams.Add("fromDate", DateUtil.GetDateTime(dto.FromDate));
                }
                if (!String.IsNullOrEmpty(dto.ToDate))
                {
                    sqlQuery += " and o.CreatedDate < :toDate";
                    mapParams.Add("toDate", ((DateTime)DateUtil.GetDateTime(dto.ToDate)).AddDays(1));
                }
                if (!String.IsNullOrEmpty(dto.Thang))
                {
                    DateTime fromDate = (DateTime) DateUtil.GetDateTime("01/" + dto.Thang);
                    sqlQuery += " and o.CreatedDate >= :fromDate";
                    mapParams.Add("fromDate", fromDate);
                    DateTime toDate = fromDate.AddMonths(1);
                    sqlQuery += " and o.CreatedDate < :toDate";
                    mapParams.Add("toDate", toDate);
                }
                if (!String.IsNullOrEmpty(dto.Nam))
                {
                    DateTime fromDate = (DateTime)DateUtil.GetDateTime("01/01/" + dto.Nam);
                    sqlQuery += " and o.CreatedDate >= :fromDate";
                    mapParams.Add("fromDate", fromDate);
                    DateTime toDate = fromDate.AddYears(1);
                    sqlQuery += " and o.CreatedDate < :toDate";
                    mapParams.Add("toDate", toDate);
                }
                if (!String.IsNullOrEmpty(dto.Quy))
                {
                    var quater = int.Parse(dto.Quy.Substring(0, 1));
                    var year = dto.Quy.Substring(2);
                    DateTime fromDate;
                    switch (quater)
                    {
                        case 1:
                            fromDate = (DateTime)DateUtil.GetDateTime("01/01/" + year);
                            break;
                        case 2:
                            fromDate = (DateTime)DateUtil.GetDateTime("01/04/" + year);
                            break;
                        case 3:
                            fromDate = (DateTime)DateUtil.GetDateTime("01/07/" + year);
                            break;
                        default:
                            fromDate = (DateTime)DateUtil.GetDateTime("01/10/" + year);
                            break;
                    }
                    sqlQuery += " and o.CreatedDate >= :fromDate";
                    mapParams.Add("fromDate", fromDate);
                    DateTime toDate = fromDate.AddMonths(3);
                    sqlQuery += " and o.CreatedDate < :toDate";
                    mapParams.Add("toDate", toDate);
                }
                var query = session.CreateQuery(sqlQuery);
                foreach (DictionaryEntry param in mapParams)
                {
                    query.SetParameter(param.Key.ToString(), param.Value);
                }

                // Get the matching objects
                var allResOrders = query.List();

                // Update Role info
                var listResOrderDtos = new List<ResOrderDto>();
                var mapResOrder = new Hashtable();
                foreach (ResOrder resOrder in allResOrders)
                {
                    var total = resOrder.Amount*resOrder.MenuPrice*(1 - resOrder.Discount);
                    string key = resOrder.MenuName+"|"+resOrder.UnitName;
                    if (mapResOrder.ContainsKey(key))
                    {
                        var resOrderdto = (ResOrderDto) mapResOrder[key];
                        resOrderdto.Amount += resOrder.Amount;
                        resOrderdto.Total += total;
                    }
                    else
                    {
                        var resOrderdto = new ResOrderDto()
                        {
                            MenuName = resOrder.MenuName,
                            UnitName = resOrder.UnitName,
                            Amount = resOrder.Amount,
                            Total = total
                        };
                        listResOrderDtos.Add(resOrderdto);
                        mapResOrder.Add(key, resOrderdto);
                    }
                }
                return listResOrderDtos;
            }
        }

        public List<EmployeeDto> GetAllEmployee()
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("from Employee e order by e.FullName asc");

                // Get the matching objects
                var allEmployees = query.List();

                var listEmployeeDtos = new List<EmployeeDto>();
                foreach (Employee employee in allEmployees)
                {
                    var employeeDto = new EmployeeDto()
                    {
                        Id = employee.Id,
                        EmployeeId = employee.EmployeeId,
                        FullName = employee.FullName,
                        Birthday = employee.Birthday,
                        Email = employee.Email,
                        Phone = employee.Phone,
                        CreatedBy = employee.CreatedBy,
                        CreatedDate = employee.CreatedDate,
                        UpdatedBy = employee.UpdatedBy,
                        UpdatedDate = employee.UpdatedDate
                    };
                    listEmployeeDtos.Add(employeeDto);
                }
                return listEmployeeDtos;
            }
        }

        public List<UserDto> getAllUser()
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("from Users e order by e.FullName asc");

                // Get the matching objects
                var allUsers = query.List();

                var listUserDtos = new List<UserDto>();
                foreach (Users user in allUsers)
                {
                    var userDto = new UserDto()
                    {
                        UserID = user.UserID,
                        UserName = user.UserName,
                        FullName = user.FullName
                    };
                    userDto.AllRoles = GetAllUserRole(user.UserID).ToArray();
                    listUserDtos.Add(userDto);
                }
                return listUserDtos;
            }
        }
        
        public List<UserDto> QueryUser(string userName, string fullName)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                string sqlQuery = "from Users e where 1=1 ";
                var mapParams = new Hashtable();
                if (!String.IsNullOrEmpty(userName))
                {
                    sqlQuery += "and e.UserName like :userName ";
                    mapParams.Add("userName", "%" + userName.ToUpper() + "%");
                }
                if (!String.IsNullOrEmpty(fullName))
                {
                    sqlQuery += "and e.FullName like :fullName ";
                    mapParams.Add("fullName", "%" + fullName + "%");
                }
                sqlQuery  += "order by e.FullName asc";
                var query = session.CreateQuery(sqlQuery);
                foreach (DictionaryEntry param in mapParams)
                {
                    query.SetParameter(param.Key.ToString(), param.Value);
                }

                // Get the matching objects
                var allUsers = query.List();

                var listUserDtos = new List<UserDto>();
                foreach (Users user in allUsers)
                {
                    var userDto = new UserDto()
                    {
                        UserID = user.UserID,
                        UserName = user.UserName,
                        FullName = user.FullName
                    };
                    userDto.AllRoles = GetAllUserRole(user.UserID).ToArray();
                    listUserDtos.Add(userDto);
                }
                return listUserDtos;
            }
        }

        public UserDto GetUser(long userId)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("from Users e where e.UserID = :userId");
                query.SetParameter("userId", userId);

                // Get the matching objects
                var user = query.UniqueResult<Users>();

                var userDto = new UserDto()
                {
                    UserID = user.UserID,
                    UserName = user.UserName,
                    FullName = user.FullName
                };
                userDto.AllRoles = GetAllUserRole(user.UserID).ToArray();

                return userDto;
            }
        }

        public List<ResOrderDto> GetAllResOrderBy(long billId)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("select new ResOrder(o.Id, m.Name, o.Amount, o.Discount, u.Name, m.Price)"
                        + " from ResOrder o, Menu m, Unit u where o.MenuId = m.Id and m.UnitId = u.Id and o.BillId = :billId");
                query.SetParameter("billId", billId);

                // Get the matching objects
                var allResOrders = query.List();

                // Update Role info
                var listResOrderDtos = new List<ResOrderDto>();
                foreach (ResOrder resOrder in allResOrders)
                {
                    var resOrderDto = new ResOrderDto()
                                          {
                                              Id = resOrder.Id,
                                              MenuName = resOrder.MenuName,
                                              Amount = resOrder.Amount,
                                              Discount = resOrder.Discount,
                                              UnitName = resOrder.UnitName,
                                              MenuPrice = resOrder.MenuPrice
                                          };
                    listResOrderDtos.Add(resOrderDto);
                }
                return listResOrderDtos;
            }
        }

        public List<BillDto> GetAllBillBy(string tuNgay, string denNgay, string billingNumber, string tableId, string billStatusCode)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                string sqlQuery = "select new Bill(b.Id, b.BillingNumber, b.BillingDate, "
                                     + "b.TableId, t.Position, b.Payment, b.CreatedBy, b.CreatedDate, b.IsPrinted, b.CancelReason) "
                                     + "from Bill b, ResTable t "
                                     + " where b.TableId = t.Id";
                var mapParams = new Hashtable();

                if (!String.IsNullOrEmpty(tuNgay))
                {
                    sqlQuery += " and b.CreatedDate >= :tuNgay";
                    mapParams.Add("tuNgay", DateUtil.GetDateTime(tuNgay));
                }
                if (!String.IsNullOrEmpty(denNgay))
                {
                    sqlQuery += " and b.CreatedDate < :denNgay";
                    mapParams.Add("denNgay", ((DateTime)DateUtil.GetDateTime(denNgay)).AddDays(1));
                }
                if (!String.IsNullOrEmpty(billingNumber))
                {
                    sqlQuery += " and b.BillingNumber = :billingNumber";
                    mapParams.Add("billingNumber", Convert.ToInt32(billingNumber));
                }
                if (!String.IsNullOrEmpty(tableId) && ! "-1".Equals(tableId))
                {
                    sqlQuery += " and b.TableId = :tableId";
                    mapParams.Add("tableId", Convert.ToInt64(tableId));
                }
                if (!String.IsNullOrEmpty(billStatusCode))
                {
                    sqlQuery += " and b.Payment = :payment";
                    mapParams.Add("payment", billStatusCode);
                }
                var query = session.CreateQuery(sqlQuery);
                foreach (DictionaryEntry param in mapParams)
                {
                    query.SetParameter(param.Key.ToString(), param.Value);
                }

                // Get the matching objects
                var allBills = query.List();

                var listBillDtos = new List<BillDto>();
                foreach (Bill bill in allBills)
                {
                    var billDto = new BillDto()
                    {
                        Id = bill.Id,
                        BillingNumber = bill.BillingNumber,
                        BillingDate = DateUtil.GetDateTimeAsDdmmyyyy(bill.BillingDate),
                        TableId = bill.TableId,
                        TableNumber = bill.TableNumber,
                        Payment = bill.Payment,
                        EmployeeId = bill.EmployeeId,
                        EmployeeName = bill.EmployeeName,
                        CreatedBy = bill.CreatedBy,
                        CreatedDate = DateUtil.GetDateTimeAsDdmmyyyy(bill.CreatedDate),
                        IsPrinted = bill.IsPrinted,
                        CancelReason = bill.CancelReason
                    };
                    listBillDtos.Add(billDto);
                }
                return listBillDtos;
            }
        }

        public List<StoreDto> getStores(DateTime? fromDate, DateTime? toDate, bool isImport, bool isExport)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                String storeStatus = "";

                if (isImport)
                {
                    storeStatus = " and s.StoredStatus = 'IMPORT'";
                }

                if (isExport)
                {
                    if (storeStatus.Length > 0)
                        storeStatus = " and s.StoredStatus in ('IMPORT','EXPORT')";
                    else
                        storeStatus = " and s.StoredStatus = 'EXPORT'";
                }

                var query = session.CreateQuery("select new Store(s.Id, m.Name, s.Amount, u.Name, s.StoredStatus, s.StoredDate, s.StoredBy, s.Reason)"
                                                + " from Store s, Material m, Unit u"
                                                + " where m.Id = s.MaterialId"
                                                + " and u.Id = m.UnitId"
                                                + " and s.StoredDate between :fromDate and :toDate"
                                                + storeStatus);
                query.SetParameter("fromDate", fromDate);
                query.SetParameter("toDate", toDate);

                // Get the matching objects
                var allStores = query.List();

                // Update Role info
                var listStoreDtos = new List<StoreDto>();
                foreach (Store store in allStores)
                {
                    var storeDto = new StoreDto()
                    {
                        Id = store.Id,
                        Amount = store.Amount,
                        MaterialName = store.MaterialName,
                        UnitName = store.UnitName,
                        StoredStatus = store.StoredStatus,
                        StoredBy = store.StoredBy,
                        StoredDate = store.StoredDate,
                        Reason = store.Reason
                    };
                    listStoreDtos.Add(storeDto);
                }
                return listStoreDtos;
            }
        }

        public List<StatisticStoreDto> GetStatisticStores(string fromDate, string toDate)
        {
            using (ISession session = m_SessionFactory.OpenSession())
            {
                string sqlQuery = "select new Store(s.Id, m.Name, s.Amount, u.Name, s.StoredStatus, s.StoredDate, s.StoredBy, s.Reason)"
                                     + " from Store s, Material m, Unit u"
                                     + " where m.Id = s.MaterialId"
                                     + " and u.Id = m.UnitId";
                var mapParams = new Hashtable();
                if (!String.IsNullOrEmpty(fromDate))
                {
                    sqlQuery += " and s.StoredDate >= :fromDate";
                    mapParams.Add("fromDate", DateUtil.GetDateTime(fromDate));
                }
                if (!String.IsNullOrEmpty(toDate))
                {
                    sqlQuery += " and s.StoredDate < :toDate";
                    mapParams.Add("toDate", ((DateTime)DateUtil.GetDateTime(toDate)).AddDays(1));
                }
                var query = session.CreateQuery(sqlQuery);
                foreach (DictionaryEntry param in mapParams)
                {
                    query.SetParameter(param.Key.ToString(), param.Value);
                }

                // Get the matching objects
                var allStatisticStores = query.List();

                // Update Role info
                var listStatisticStoreDtos = new List<StatisticStoreDto>();
                var mapStore = new Hashtable();
                foreach (Store store in allStatisticStores)
                {
                    string key = store.MaterialName + "|" + store.UnitName;
                    float impAmount = 0;
                    float expAmount = 0;
                    if (store.StoredStatus.Equals("IMPORT"))
                    {
                        impAmount = store.Amount;
                    }
                    else
                    {
                        expAmount = store.Amount;
                    }
                    float inventory = impAmount-expAmount;
                    if (mapStore.ContainsKey(key))
                    {
                        StatisticStoreDto storeDto = (StatisticStoreDto) mapStore[key];
                        storeDto.ImpAmount += impAmount;
                        storeDto.ExpAmount += expAmount;
                        storeDto.Inventory += inventory;
                    }
                    else
                    {
                        var storeDto = new StatisticStoreDto()
                        {
                            MaterialName = store.MaterialName,
                            UnitName = store.UnitName,
                            ImpAmount = impAmount,
                            ExpAmount = expAmount,
                            Inventory = inventory
                        };
                        listStatisticStoreDtos.Add(storeDto);
                        mapStore.Add(key, storeDto);
                    }
                }
                return listStatisticStoreDtos;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Configures Log4Net to work with NHibernate.
        /// </summary>
        private void ConfigureLog4Net()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        /// <summary>
        /// Configures NHibernate and creates a member-level session factory.
        /// </summary>
        private void ConfigureNHibernate()
        {
            // Initialize
            var cfg = new Configuration();
            cfg.Configure();

            /* Note: The AddAssembly() method requires that mappings be 
             * contained in hbm.xml files whose BuildAction properties 
             * are set to ‘Embedded Resource’. */

            // Create session factory from configuration object
            m_SessionFactory = cfg.BuildSessionFactory();
        }

        #endregion
    }
}