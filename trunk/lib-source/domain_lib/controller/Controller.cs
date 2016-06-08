using System;
using System.Collections;
using System.Collections.Generic;
using core_lib.common;
using domain_lib.dto;
using domain_lib.model;
using domain_lib.persistence;

namespace domain_lib.controller
{
    public class Controller
    {
        #region Declarations

        // Member variables
        private PersistenceManager m_PersistenceManager = new PersistenceManager();
        
        // Property variables

        #endregion

        #region Constructor

        public Controller()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Public Methods

        public IList<T> RetrieveAll<T>()
        {
            return m_PersistenceManager.RetrieveAll<T>(SessionAction.BeginAndEnd);
        }

        public void Save<T>(T item)
        {
            m_PersistenceManager.Save(item);
        }
        
        public CurrentIdentity GetCurrentIdentity(string tableName)
        {
            return m_PersistenceManager.GetCurrentIdentity(tableName);
        }

        public UserDto login(string userName, string password)
        {
            return m_PersistenceManager.checkUser(userName, password);
        }

        public string changePassword(string userId, string oldPassword, string newPassword)
        {
            return m_PersistenceManager.changePassword(userId, oldPassword, newPassword);
        }

        public string GetTenNsd(string userId)
        {
            return m_PersistenceManager.GetTenNsd(userId);
        }

        public string GetUserName(string userId)
        {
            return m_PersistenceManager.GetUserName(userId);
        }

        public List<BillDto> GetAllBill()
        {
            return m_PersistenceManager.GetAllBill();
        }

        public List<BillDto> GetAllNotCompletedBill()
        {
            return m_PersistenceManager.GetAllNotCompletedBill();
        }

        #endregion

        public List<MaterialDto> GetAllMaterial()
        {
            return m_PersistenceManager.GetAllMaterial();
        }

        public bool AddNewStore(StoreDto storeDto)
        {
            try
            {
                Store store = new Store() { 
                    MaterialId = storeDto.MaterialId,
                    Amount = storeDto.Amount,
                    StoredStatus = storeDto.StoredStatus,
                    StoredDate = storeDto.StoredDate,
                    StoredBy = storeDto.StoredBy,
                    Reason = storeDto.Reason,
                    CreatedBy = storeDto.StoredBy,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = storeDto.StoredBy,
                    UpdatedDate = DateTime.Now
                };
                m_PersistenceManager.SaveNew<Store>(store);
                return true;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public long GetTableIdByNumber(string tableNumber)
        {
            return m_PersistenceManager.GetTableIdByNumber(tableNumber);
        }

        public bool SaveBill(BillDto billDto)
        {
            try
            {
                var bills = m_PersistenceManager.RetrieveEquals<Bill>("Id", billDto.Id);
                var bill = bills.Count == 0 ? new Bill() : bills[0];
                bill.TableId = billDto.TableId;
                bill.BillingNumber = billDto.BillingNumber;
                bill.Payment = ConstUtil.NO;
                bill.IsPrinted = ConstUtil.NO;
                bill.EmployeeId = billDto.EmployeeId;
                bill.EmployeeName = billDto.EmployeeName;
                bill.BillingDate = DateTime.Now;
                bill.CreatedBy = billDto.CreatedBy;
                bill.CreatedDate = DateTime.Now;
                bill.UpdatedBy = billDto.UpdatedBy;
                bill.UpdatedDate = DateTime.Now;
                m_PersistenceManager.Save<Bill>(bill);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool SaveCategory(DanhMucDto dto)
        {
            try
            {
                var categories = m_PersistenceManager.RetrieveEquals<Category>("Id", long.Parse(dto.Id));
                var category = categories.Count == 0 ? new Category() : categories[0];
                category.Code = dto.Ma;
                category.Name = dto.Ten;
                m_PersistenceManager.Save<Category>(category);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool SaveMenu(MenuDto dto)
        {
            try
            {
                var menus = m_PersistenceManager.RetrieveEquals<Menu>("Id", dto.Id);
                var menu = menus.Count == 0 ? new Menu() : menus[0];
                menu.Code = dto.Code;
                menu.Name = dto.Name;
                menu.CategoryId = dto.CategoryId;
                menu.UnitId = dto.UnitId;
                menu.Price = dto.Price;
                menu.Description = dto.Description;
                menu.IsActive = ConstUtil.YES;
                menu.CreatedBy = dto.CreatedBy;
                menu.CreatedDate = DateTime.Now;
                menu.UpdatedBy = dto.UpdatedBy;
                menu.UpdatedDate = DateTime.Now;
                m_PersistenceManager.Save<Menu>(menu);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool SaveResOrder(ResOrderDto resOrderDto)
        {
            try
            {
                ResOrder resOrder = new ResOrder()
                {
                    Id = resOrderDto.Id,
                    MenuId = resOrderDto.MenuId,
                    BillId = resOrderDto.BillId,
                    Amount = resOrderDto.Amount,
                    Discount = resOrderDto.Discount,
                    CreatedBy = resOrderDto.CreatedBy,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = resOrderDto.UpdatedBy,
                    UpdatedDate = DateTime.Now
                };
                m_PersistenceManager.Save<ResOrder>(resOrder);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool SaveUser(UserDto userDto)
        {
            try
            {
                var users = m_PersistenceManager.RetrieveEquals<Users>("UserID", userDto.UserID);
                Users user;
                if (users.Count == 0)
                {
                    user = new Users()
                    {
                        UserID = userDto.UserID,
                        UserName = userDto.UserName,
                        FullName = userDto.FullName,
                        Password = MD5Util.EncodeMD5(userDto.Password),
                    }; 
                } else
                {
                    user = users[0];
                    user.FullName = userDto.FullName;
                }
                m_PersistenceManager.Save<Users>(user);
                var allUserRoles = m_PersistenceManager.RetrieveEquals<UserRole>("UserID", user.UserID);
                var allOldRoleId = new HashSet<long>();
                foreach (var userRole in allUserRoles)
                {
                    allOldRoleId.Add(userRole.RoleID);
                    userRole.IsActive = false;
                    m_PersistenceManager.Save(userRole);
                }
                foreach (var roleDto in userDto.AllRoles)
                {
                    var role = m_PersistenceManager.RetrieveEquals<Roles>("RoleCode", roleDto.RoleCode)[0];
                    if (allOldRoleId.Contains(role.RoleID))
                    {
                        m_PersistenceManager.Save(new UserRole()
                        {
                            UserID = user.UserID,
                            RoleID = role.RoleID,
                            IsActive = true
                        });
                    } else
                    {
                        m_PersistenceManager.SaveNew(new UserRole()
                        {
                            UserID = user.UserID,
                            RoleID = role.RoleID,
                            IsActive = true
                        }); 
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public string ResetPassword(long userId)
        {
            try
            {
                var users = m_PersistenceManager.RetrieveEquals<Users>("UserID", userId);
                Users user;
                if (users.Count == 0)
                {
                    return String.Empty;
                }
                user = users[0];
                user.Password = MD5Util.EncodeMD5(ConstUtil.DEFAULT_PASSWORD);
                m_PersistenceManager.Save<Users>(user);
                return ConstUtil.DEFAULT_PASSWORD;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return String.Empty;
            }
        }

        public List<ResTableDto> GetAllResTableDto()
        {
            return m_PersistenceManager.GetAllResTableDto();
        }

        public List<ResOrderDto> GetAllResOrderBy(long billId)
        {
            return m_PersistenceManager.GetAllResOrderBy(billId);
        }

        public List<MenuDto> GetAllMenuDto()
        {
            return m_PersistenceManager.GetAllMenuDto();
        }

        public BillDto getBillDto(long billId)
        {
            if (billId == -1)
            {
                return new BillDto();
            }
            var bill = m_PersistenceManager.RetrieveEquals<Bill>("Id", billId)[0];
            return new BillDto()
                       {
                           Id = bill.Id,
                           BillingDate = DateUtil.GetDateTimeAsDdmmyyyy(bill.BillingDate),
                           BillingNumber = bill.BillingNumber,
                           CancelReason = bill.CancelReason,
                           Payment = bill.Payment,
                           IsPrinted = bill.IsPrinted,
                           EmployeeId = bill.EmployeeId,
                           EmployeeName = bill.EmployeeName,
                           TableId = bill.TableId
                       };
        }

        public ResOrderDto getResOrderDto(long id)
        {
            if (id == -1)
            {
                return new ResOrderDto();
            }
            var resOrder = m_PersistenceManager.RetrieveEquals<ResOrder>("Id", id)[0];
            return new ResOrderDto()
            {
                Id = resOrder.Id,
                BillId = resOrder.BillId,
                MenuId = resOrder.MenuId,
                Amount = resOrder.Amount,
                Discount = resOrder.Discount
            };
        }

        public bool DeleteResOrder(long id)
        {
            if (id == -1)
            {
                return true;
            }
            var resOrder = m_PersistenceManager.RetrieveEquals<ResOrder>("Id", id)[0];
            m_PersistenceManager.Delete<ResOrder>(resOrder);
            return true;
        }

        public bool DeleteUser(long userId)
        {
            if (userId == -1)
            {
                return true;
            }
            var user = m_PersistenceManager.RetrieveEquals<Users>("UserID", userId)[0];
            var allUserRoles = m_PersistenceManager.RetrieveEquals<UserRole>("UserID", user.UserID);
            foreach (var userRole in allUserRoles)
            {
                m_PersistenceManager.Delete<UserRole>(userRole);
            }
            m_PersistenceManager.Delete<Users>(user);
            return true;
        }

        public bool ThanhToan(BillDto billDto)
        {
            var bill = m_PersistenceManager.RetrieveEquals<Bill>("Id", billDto.Id)[0];
            bill.Payment = billDto.Payment;
            bill.IsPrinted = billDto.IsPrinted;
            bill.CancelReason = billDto.CancelReason;
            m_PersistenceManager.Save(bill);
            return true;
        }

        public List<EmployeeDto> GetAllEmployee()
        {
            return m_PersistenceManager.GetAllEmployee();
        }

        public List<BillDto> GetAllBillBy(string tuNgay, string denNgay, string billingNumber, string tableId, string billStatusCode)
        {
            return m_PersistenceManager.GetAllBillBy(tuNgay, denNgay, billingNumber, tableId, billStatusCode);
        }

        public List<DanhMucDto> GetAllCategory()
        {
            return m_PersistenceManager.GetAllCategory();
        }

        public List<DanhMucDto> GetAllUnit()
        {
            return m_PersistenceManager.GetAllUnit();
        }

        public List<MenuDto> GetAllMenuBy(long categoryId)
        {
            return m_PersistenceManager.GetAllMenuBy(categoryId);
        }

        public List<ResOrderDto> GetAllResOrderDto(StatisticMenuSearchDto dto)
        {
            return m_PersistenceManager.GetAllResOrderDto(dto);
        }

        public List<StoreDto> getStores(DateTime? fromDate, DateTime? toDate, bool isImport, bool isExport)
        {
            return m_PersistenceManager.getStores(fromDate, toDate, isImport, isExport);
        }

        public List<StatisticStoreDto> GetStatisticStores(string fromDate, string toDate)
        {
            var allStatisticDto = m_PersistenceManager.GetStatisticStores(fromDate, toDate);
            if (!String.IsNullOrEmpty(fromDate))
            {
                var preFromDate = DateUtil.GetDateTimeAsDdmmyyyy(((DateTime) DateUtil.GetDateTime(fromDate)).AddDays(-1));
                var allPreStatisticDto = m_PersistenceManager.GetStatisticStores(String.Empty, preFromDate);
                var mapPreStatisticStore = new Hashtable();
                foreach (var dto in allPreStatisticDto)
                {
                    string key = dto.MaterialName + "|" + dto.UnitName;
                    mapPreStatisticStore.Add(key, dto);
                }
                foreach (var statisticDto in allStatisticDto)
                {
                    string key = statisticDto.MaterialName + "|" + statisticDto.UnitName;
                    if (mapPreStatisticStore.ContainsKey(key))
                    {
                        StatisticStoreDto preStatisticDto = (StatisticStoreDto) mapPreStatisticStore[key];
                        statisticDto.PreviousInventory = preStatisticDto.Inventory;
                        statisticDto.Inventory += preStatisticDto.Inventory;
                    }
                }
            }
            return allStatisticDto;
        }

        public List<UserDto> getAllUser()
        {
            return m_PersistenceManager.getAllUser();
        }

        public List<UserDto> QueryUser(string userName, string fullName)
        {
            return m_PersistenceManager.QueryUser(userName, fullName);
        }

        public UserDto GetUser(long userId)
        {
            return m_PersistenceManager.GetUser(userId);
        }

        public DanhMucDto getCategoryDto(long categoryId)
        {
            var categorys = m_PersistenceManager.RetrieveEquals<Category>("Id", categoryId);
            var dto = new DanhMucDto();
            if (categorys.Count == 0)
            {
                return dto;
            }
            var category = categorys[0];
            dto.Id = Convert.ToString(category.Id);
            dto.Ma = category.Code;
            dto.Ten = category.Name;
            return dto;
        }

        public bool IsExistCategoryCode(string categoryCode, long oldCategoryId)
        {
            if (String.IsNullOrEmpty(categoryCode))
            {
                return false;
            }
            var categories = m_PersistenceManager.RetrieveEquals<Category>("Code", categoryCode.ToUpper());
            if (categories.Count == 0)
            {
                return false;
            }
            var category = categories[0];
            return oldCategoryId != category.Id;
        }

        public bool IsExistMenuCode(string menuCode, long oldMenuId)
        {
            if (String.IsNullOrEmpty(menuCode))
            {
                return false;
            }
            var menus = m_PersistenceManager.RetrieveEquals<Menu>("Code", menuCode.ToUpper());
            if (menus.Count == 0)
            {
                return false;
            }
            var menu = menus[0];
            return oldMenuId != menu.Id;
        }

        public bool ExistsUser(long oldUserId, string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                return false;
            }
            var users = m_PersistenceManager.RetrieveEquals<Users>("UserName", username.ToUpper());
            if (users.Count == 0)
            {
                return false;
            }
            var user = users[0];
            return oldUserId != user.UserID;
        }

        public MenuDto GetMenuDto(long menuId)
        {
            return m_PersistenceManager.getMenuDto(menuId);
        }
    }
}