using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Customer entity
/// </summary>
namespace domain_lib.model
{
    public class Customer
    {
        #region Declarations

        // Property variables
        private long _id = -1;

        // Member variables
        private string _name = String.Empty;

        private DateTime _birthday = default(DateTime);

        private string _email = String.Empty;

        private string _phone = String.Empty;

        private string _created_By = String.Empty;

        private DateTime _created_Date = default(DateTime);

        private string _updated_By = String.Empty;

        private DateTime _updated_Date = default(DateTime);

        #endregion

    	#region Constructor

        public Customer()
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
        /// Name.
        /// </summary>
        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Birthday.
        /// </summary>
        public virtual DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        /// <summary>
        /// Email.
        /// </summary>
        public virtual string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// Phone.
        /// </summary>
        public virtual string Phone
        {
            get { return _phone; }
            set { _phone = value; }
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