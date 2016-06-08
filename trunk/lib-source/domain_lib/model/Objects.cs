using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace domain_lib.model
{
    public class Objects
    {
        #region Declarations

        // Property variables
        private long object_ID = -1;

        // Member variables
        private long parent_ID = -1;

        private string object_Code = String.Empty;

        private string description = String.Empty;

        private string object_Url = String.Empty;

        private int order = 0;

        private int status = 1;

        #endregion

    	#region Constructor

        public Objects()
        {
        }

    	#endregion

        #region Properties

        /// <summary>
        /// Object ID
        /// </summary>
        public virtual long ObjectID
        {
            get { return object_ID; }
            set { object_ID = value; }
        }

        /// <summary>
        /// Parent ID
        /// </summary>
        public virtual long ParentID
        {
            get { return parent_ID; }
            set { parent_ID = value; }
        }

        /// <summary>
        /// Object Code.
        /// </summary>
        public virtual string ObjectCode
        {
            get { return object_Code; }
            set { object_Code = value; }
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
        /// Object Url
        /// </summary>
        public virtual string ObjectUrl
        {
            get { return object_Url; }
            set { object_Url = value; }
        }

        /// <summary>
        /// Order
        /// </summary>
        public virtual int Order
        {
            get { return order; }
            set { order = value; }
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