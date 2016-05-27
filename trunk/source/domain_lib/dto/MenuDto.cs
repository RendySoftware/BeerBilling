using System;

namespace domain_lib.dto
{
    public class MenuDto
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

        #endregion

    	#region Constructor

        public MenuDto()
        {
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

        #endregion

        #region Method Overrides

        public override string ToString()
        {
            return _id.ToString();
        }

        #endregion
    }
}