using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Menu entity
/// </summary>
namespace domain_lib.model
{
    public class Menu
    {
        #region Declarations

        // Property variables
        private long _id = -1;

        // Member variables
        private long _category_Id = -1;

        private string _code = String.Empty;

        private string _name = String.Empty;

        private long _unit_Id = -1;

        private float _price = 0;

        private string _description = String.Empty;

        private string _is_Active = String.Empty;

        private string _created_By = String.Empty;

        private DateTime _created_Date = default(DateTime);

        private string _updated_By = String.Empty;

        private DateTime _updated_Date = default(DateTime);

        private string _unitName = String.Empty;

        #endregion

    	#region Constructor

        public Menu()
        {
        }

        public Menu(long id, long category_Id, string code, string name, long unit_Id, string unitName, float price, string description,
            string is_Active, string created_By, DateTime created_Date, string updated_By, DateTime updated_Date)
        {
            _id = id;
            _category_Id = category_Id;
            _code = code;
            _name = name;
            _unit_Id = unit_Id;
            _unitName = unitName;
            _price = price;
            _description = description;
            _is_Active = is_Active;
            _created_By = created_By;
            _created_Date = created_Date;
            _updated_By = updated_By;
            _updated_Date = updated_Date;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Id.
        /// </summary>
        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Category Id.
        /// </summary>
        public virtual long CategoryId
        {
            get { return _category_Id; }
            set { _category_Id = value; }
        }

        /// <summary>
        /// UnitId.
        /// </summary>
        public virtual long UnitId
        {
            get { return _unit_Id; }
            set { _unit_Id = value; }
        }

        /// <summary>
        /// Code.
        /// </summary>
        public virtual string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// Name.
        /// </summary>
        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Price.
        /// </summary>
        public virtual float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        /// Description.
        /// </summary>
        public virtual string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        /// Is Active.
        /// </summary>
        public virtual string IsActive
        {
            get { return _is_Active; }
            set { _is_Active = value; }
        }

        /// <summary>
        /// Created By.
        /// </summary>
        public virtual string CreatedBy
        {
            get { return _created_By; }
            set { _created_By = value; }
        }

        /// <summary>
        /// Created Date.
        /// </summary>
        public virtual DateTime CreatedDate
        {
            get { return _created_Date; }
            set { _created_Date = value; }
        }

        /// <summary>
        /// Updated By.
        /// </summary>
        public virtual string UpdatedBy
        {
            get { return _updated_By; }
            set { _updated_By = value; }
        }

        /// <summary>
        /// Updated Date.
        /// </summary>
        public virtual DateTime UpdatedDate
        {
            get { return _updated_Date; }
            set { _updated_Date = value; }
        }

        public virtual string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }

        #endregion

        #region Method Overrides

        public override string ToString()
        {
            return _id.ToString();
        }

        #endregion
    }
}