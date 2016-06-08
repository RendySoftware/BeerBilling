using System;

namespace domain_lib.dto
{
    public class BookedTableDto
    {
        #region Declarations

        // Property variables
        private long _id = -1;

        // Member variables
        private long _customer_Id = -1;

        private long _table_Id = -1;

        private string _status = String.Empty;

        private string _process = String.Empty;

        private DateTime _from_Date = default(DateTime);

        private DateTime _to_Date = default(DateTime);

        private string _created_By = String.Empty;

        private DateTime _created_Date = default(DateTime);

        private string _updated_By = String.Empty;

        private DateTime _updated_Date = default(DateTime);

        #endregion

    	#region Constructor

        public BookedTableDto()
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
        /// Customer Id.
        /// </summary>
        public virtual long CustomerId
        {
            get { return _customer_Id; }
            set { _customer_Id = value; }
        }

        /// <summary>
        /// Table Id.
        /// </summary>
        public virtual long TableId
        {
            get { return _table_Id; }
            set { _table_Id = value; }
        }

        /// <summary>
        /// Status.
        /// </summary>
        public virtual string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Process.
        /// </summary>
        public virtual string Process
        {
            get { return _process; }
            set { _process = value; }
        }

        /// <summary>
        /// From Date.
        /// </summary>
        public virtual DateTime FromDate
        {
            get { return _from_Date; }
            set { _from_Date = value; }
        }

        /// <summary>
        /// To Date.
        /// </summary>
        public virtual DateTime ToDate
        {
            get { return _to_Date; }
            set { _to_Date = value; }
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