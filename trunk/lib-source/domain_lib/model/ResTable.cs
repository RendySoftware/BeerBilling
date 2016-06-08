using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ResTable entity
/// </summary>
namespace domain_lib.model
{
    public class ResTable
    {
        #region Declarations

        // Property variables
        private long _id = -1;

        // Member variables
        private string _code = String.Empty;

        private string _position = String.Empty;

        #endregion

    	#region Constructor

        public ResTable()
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
        /// Position.
        /// </summary>
        public virtual string Position
        {
            get { return _position; }
            set { _position = value; }
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