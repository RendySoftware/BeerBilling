using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Bill entity
/// </summary>
namespace domain_lib.model
{
    public class Bill
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

        private string _employee_Id = String.Empty;

        private string _employee_Name = String.Empty;

        private string _customerName = String.Empty;

        private string _tableNumber = String.Empty;

        #endregion

    	#region Constructor

        public Bill()
        {
        }

        public Bill(long id, int billingNumber, DateTime billingDate, long tableId, string tableNumber, string payment, 
                string createdBy, DateTime createdDate, string isPrinted, string cancelReason)
        {
            _id = id;
            _billing_Number = billingNumber;
            _billing_Date = billingDate;
            _table_Id = tableId;
            _tableNumber = tableNumber;
            _payment = payment;
            _created_By = createdBy;
            _created_Date = createdDate;
            _is_Printed = isPrinted;
            _cancel_Reason = cancelReason;
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

        /// <summary>
        /// Customer Name.
        /// </summary>
        public virtual string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        /// <summary>
        /// Table Number.
        /// </summary>
        public virtual string TableNumber
        {
            get { return _tableNumber; }
            set { _tableNumber = value; }
        }

        public virtual string EmployeeId
        {
            get { return _employee_Id; }
            set { _employee_Id = value; }
        }

        public virtual string EmployeeName
        {
            get { return _employee_Name; }
            set { _employee_Name = value; }
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