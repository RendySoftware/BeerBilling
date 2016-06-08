using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace domain_lib.model
{
    public class Roles
    {
        #region Declarations

        // Property variables
        private long role_ID = -1;

        // Member variables
        private string role_Code = String.Empty;

        private string description = String.Empty;

        private int status = 1;

        #endregion

    	#region Constructor

        public Roles()
        {
        }

        public Roles(long roleId, string roleCode, string description)
        {
            this.role_ID = roleId;
            this.role_Code = roleCode;
            this.description = description;
        }

    	#endregion

        #region Properties

        /// <summary>
        /// Role ID
        /// </summary>
        public virtual long RoleID
        {
            get { return role_ID; }
            set { role_ID = value; }
        }

        /// <summary>
        /// Role Code.
        /// </summary>
        public virtual string RoleCode
        {
            get { return role_Code; }
            set { role_Code = value; }
        }

        /// <summary>
        /// Description
        /// </summary>
        public virtual string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Status
        /// </summary>
        public virtual int Status
        {
            get { return status; }
            set { status = value; }
        }

        #endregion

        #region Method Overrides

        public override string ToString()
        {
            return description;
        }

        #endregion
    }
}