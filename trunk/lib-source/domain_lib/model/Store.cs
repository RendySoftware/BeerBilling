﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Store entity
/// </summary>
namespace domain_lib.model
{
    public class Store
    {
        #region Declarations

        // Property variables
        private long _id = -1;

        // Member variables
        private long _material_Id = -1;

        private float _amount = 0;

        private string _stored_Status = String.Empty;

        private DateTime? _stored_Date = default(DateTime);

        private string _stored_By = String.Empty;

        private string _material_name = String.Empty;

        private string _unit_name = String.Empty;

        private string _reason = String.Empty;

        private string _created_By = String.Empty;

        private DateTime? _created_Date = default(DateTime);

        private string _updated_By = String.Empty;

        private DateTime? _updated_Date = default(DateTime);

        #endregion

    	#region Constructor

        public Store()
        {
        }

        public Store(long id, String materialName, float amount, String unitName, String storedStatus, DateTime storedDate, String storedBy, String reason)
        {
            this.Id = id;
            this.MaterialName = materialName;
            this.Amount = amount;
            this.UnitName = unitName;
            this.StoredStatus = storedStatus;
            this.StoredDate = storedDate;
            this.StoredBy = storedBy;
            this.Reason = reason;
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
        /// Material Id.
        /// </summary>
        public virtual long MaterialId
        {
            get { return _material_Id; }
            set { _material_Id = value; }
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
        /// Stored Status.
        /// </summary>
        public virtual string StoredStatus
        {
            get { return _stored_Status; }
            set { _stored_Status = value; }
        }

        /// <summary>
        /// Stored Date.
        /// </summary>
        public virtual DateTime? StoredDate
        {
            get { return _stored_Date; }
            set { _stored_Date = value; }
        }

        /// <summary>
        /// Stored By.
        /// </summary>
        public virtual string StoredBy
        {
            get { return _stored_By; }
            set { _stored_By = value; }
        }

        /// <summary>
        /// Reason.
        /// </summary>
        public virtual string Reason
        {
            get { return _reason; }
            set { _reason = value; }
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
        public virtual DateTime? CreatedDate
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
        public virtual DateTime? UpdatedDate
        {
            get { return _updated_Date; }
            set { _updated_Date = value; }
        }

        /// <summary>
        /// MaterialName.
        /// </summary>
        public virtual string MaterialName
        {
            get { return _material_name; }
            set { _material_name = value; }
        }

        /// <summary>
        /// UnitName By.
        /// </summary>
        public virtual string UnitName
        {
            get { return _unit_name; }
            set { _unit_name = value; }
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