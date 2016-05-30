using System;

namespace domain_lib.dto
{
    public class ResOrderDto
    {
        #region Declarations

        // Property variables
        private long _id = -1;

        // Member variables
        private long _bill_Id = -1;

        private long _menu_Id = -1;

        private float _amount = 0;

        private string _created_By = String.Empty;

        private DateTime _created_Date = default(DateTime);

        private string _updated_By = String.Empty;

        private DateTime _updated_Date = default(DateTime);

        private string _menuName = String.Empty;

        private string _unitName = String.Empty;

        private float _menuPrice = 0;

        private float _discount = 0;

        #endregion

    	#region Constructor

        public ResOrderDto()
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
        /// Bill Id.
        /// </summary>
        public virtual long BillId
        {
            get { return _bill_Id; }
            set { _bill_Id = value; }
        }

        /// <summary>
        /// Menu Id.
        /// </summary>
        public virtual long MenuId
        {
            get { return _menu_Id; }
            set { _menu_Id = value; }
        }

        /// <summary>
        /// Amount.
        /// </summary>
        public virtual float Amount
        {
            get { return _amount; }
            set { _amount = value; }
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

        public virtual string MenuName
        {
            get { return _menuName; }
            set { _menuName = value; }
        }

        public virtual string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }

        public virtual float MenuPrice
        {
            get { return _menuPrice; }
            set { _menuPrice = value; }
        }

        public virtual float Discount
        {
            get { return _discount; }
            set { _discount = value; }
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