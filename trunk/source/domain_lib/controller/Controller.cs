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
            return m_PersistenceManager.getTenNsd(userId);
        }

        public List<BillDto> GetAllBill()
        {
            return m_PersistenceManager.GetAllBill();
        }

        #endregion

        public List<MaterialDto> GetAllMaterial()
        {
            return m_PersistenceManager.GetAllMaterial();
        }
    }
}