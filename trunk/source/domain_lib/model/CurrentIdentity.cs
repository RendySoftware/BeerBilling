using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain_lib.model
{
    public class CurrentIdentity
    {
        #region Declarations

        // Property variables
        private long _value = -1;

        // Member variables
        #endregion

    	#region Constructor

        public CurrentIdentity()
        {
        }

    	#endregion

        #region Properties

        /// <summary>
        /// Value
        /// </summary>
        public virtual long Value
        {
            get { return _value; }
            set { _value = value; }
        }

        #endregion

        #region Method Overrides

        public override string ToString()
        {
            return _value.ToString();
        }

        #endregion
    }
}
