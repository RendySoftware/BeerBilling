using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain_lib.dto
{
    public class RoleDto
    {
        #region Declarations

        // Property variables
        private long _roleId = -1;

        // Member variables
        private string _roleCode = String.Empty;

        private string _description = String.Empty;

        private int _status = 1;

        #endregion

    	#region Constructor

        public RoleDto()
        {
        }

    	#endregion

        #region Properties

        /// <summary>
        /// Role ID
        /// </summary>
        public virtual long RoleID
        {
            get { return _roleId; }
            set { _roleId = value; }
        }

        /// <summary>
        /// Role Code.
        /// </summary>
        public virtual string RoleCode
        {
            get { return _roleCode; }
            set { _roleCode = value; }
        }

        /// <summary>
        /// Description
        /// </summary>
        public virtual string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        /// Status
        /// </summary>
        public virtual int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        #endregion

        #region Method Overrides

        public override string ToString()
        {
            return _description;
        }

        #endregion
    }
}
