using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace domain_lib.model
{
    public class UserRole
    {
        #region Declarations

        // Property variables
        private long role_ID = -1;
        private long user_ID = -1;

        // Member variables
        private bool is_Active = true;

        #endregion

    	#region Constructor

        public UserRole()
        {
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
        /// User ID
        /// </summary>
        public virtual long UserID
        {
            get { return user_ID; }
            set { user_ID = value; }
        }

        /// <summary>
        /// Is Active.
        /// </summary>
        public virtual bool IsActive
        {
            get { return is_Active; }
            set { is_Active = value; }
        }

        #endregion

        #region Method Overrides

        public override string ToString()
        {
            return role_ID + "|" + user_ID;
        }

        public override bool Equals(object obj)
        {
            var other = obj as UserRole;
            if (other == null)
            {
                return false;
            }
            return RoleID.Equals(other.RoleID) && UserID.Equals(other.UserID);
        }

        public override int GetHashCode()
        {
            int hashCode = 13;
            hashCode = (hashCode*7) + UserID.GetHashCode();
            hashCode = (hashCode*7) + RoleID.GetHashCode();
            return hashCode;
        }

        #endregion
    }
}