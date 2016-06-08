using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// User entity
/// </summary>
namespace domain_lib.model
{
    public class Users
    {
        #region Declarations

        // Property variables
        private long user_ID = -1;

        // Member variables
        private string user_Name = String.Empty;

        private string _fullName = String.Empty;

        private string password = String.Empty;

        #endregion

    	#region Constructor

        public Users()
        {
        }

    	#endregion

        #region Properties

        /// <summary>
        /// User ID
        /// </summary>
        public virtual long UserID
        {
            get { return user_ID; }
            set { user_ID = value; }
        }

        /// <summary>
        /// User name.
        /// </summary>
        public virtual string UserName
        {
            get { return user_Name; }
            set { user_Name = value; }
        }

        /// <summary>
        /// Full name.
        /// </summary>
        public virtual string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        /// <summary>
        /// Password
        /// </summary>
        public virtual string Password
        {
            get { return password; }
            set { password = value; }
        }

        #endregion

        #region Method Overrides

        public override string ToString()
        {
            return user_Name;
        }

        #endregion
    }
}