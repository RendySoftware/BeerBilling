using System;

namespace domain_lib.dto
{
    public class BillDto
    {
        #region Declarations

        // Property variables
        private long _id = -1;

        // Member variables
        private long _customer_Id = -1;

        private long _table_Id = -1;

        private string _is_Printed = String.Empty;

        private string _payment = String.Empty;

        private DateTime _billing_Date = default(DateTime);

        private int _billing_Number = 0;

        private String _cancel_Reason = String.Empty;

        private string _created_By = String.Empty;

        private DateTime _created_Date = default(DateTime);

        private string _updated_By = String.Empty;

        private DateTime _updated_Date = default(DateTime);

        #endregion

    	#region Constructor

        public BillDto()
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
        /// Is Printed.
        /// </summary>
        public virtual string IsPrinted
        {
            get { return _is_Printed; }
            set { _is_Printed = value; }
        }

        /// <summary>
        /// Payment.
        /// </summary>
        public virtual string Payment
        {
            get { return _payment; }
            set { _payment = value; }
        }

        /// <summary>
        /// Billing Date.
        /// </summary>
        public virtual DateTime BillingDate
        {
            get { return _billing_Date; }
            set { _billing_Date = value; }
        }

        /// <summary>
        /// Billing Number.
        /// </summary>
        public virtual int BillingNumber
        {
            get { return _billing_Number; }
            set { _billing_Number = value; }
        }

        /// <summary>
        /// Cancel Reason.
        /// </summary>
        public virtual string CancelReason
        {
            get { return _cancel_Reason; }
            set { _cancel_Reason = value; }
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