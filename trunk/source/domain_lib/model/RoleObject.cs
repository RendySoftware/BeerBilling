using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace domain_lib.model
{
    public class RoleObject
    {
        #region Declarations

        // Property variables
        private long role_ID = -1;
        private long object_ID = -1;

        // Member variables
        private bool is_Active = true;

        #endregion

    	#region Constructor

        public RoleObject()
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
        /// Object ID
        /// </summary>
        public virtual long ObjectID
        {
            get { return object_ID; }
            set { object_ID = value; }
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
            return role_ID + "|" + object_ID;
        }

        public override bool Equals(object obj)
        {
            var other = obj as RoleObject;
            if (other == null)
            {
                return false;
            }
            return RoleID.Equals(other.RoleID) && ObjectID.Equals(other.ObjectID);
        }

        public override int GetHashCode()
        {
            int hashCode = 13;
            hashCode = (hashCode * 7) + ObjectID.GetHashCode();
            hashCode = (hashCode * 7) + RoleID.GetHashCode();
            return hashCode;
        }

        #endregion
    }
}