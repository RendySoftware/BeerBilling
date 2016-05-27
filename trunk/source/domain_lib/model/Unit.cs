using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Unit entity
/// </summary>
namespace domain_lib.model
{
    public class Unit
    {
        #region Declarations

        // Property variables
        private long _id = -1;

        // Member variables
        private string _code = String.Empty;

        private string _name = String.Empty;

        #endregion

    	#region Constructor

        public Unit()
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
        /// Code.
        /// </summary>
        public virtual string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// Name.
        /// </summary>
        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region Method Overrides

        public override string ToString()
        {
            return _name;
        }

        #endregion
    }
}