using System;
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

        public bool AddNewBill(BillDto billDto)
        {
            try
            {
                Bill bill = new Bill()
                {
                    TableId = billDto.TableId,
                    BillingNumber = billDto.BillingNumber,
                    BillingDate = DateTime.Now,
                    CreatedBy = billDto.CreatedBy,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = billDto.UpdatedBy,
                    UpdatedDate = DateTime.Now
                };
                m_PersistenceManager.SaveNew<Bill>(bill);
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
    }
}