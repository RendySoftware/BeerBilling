using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain_lib.dto
{
    public class MaterialDto
    {
        #region Declarations

        // Property variables
        private long _id = -1;

        // Member variables
        private long _unit_Id = -1;

        private string _code = String.Empty;

        private string _name = String.Empty;

        private string _unitCode = String.Empty;

        private string _unitName = String.Empty;

        #endregion

    	#region Constructor

        public MaterialDto()
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
        /// UnitId.
        /// </summary>
        public virtual long UnitId
        {
            get { return _unit_Id; }
            set { _unit_Id = value; }
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

        /// <summary>
        /// UnitCode.
        /// </summary>
        public virtual string UnitCode
        {
            get { return _unitCode; }
            set { _unitCode = value; }
        }

        /// <summary>
        /// UnitName.
        /// </summary>
        public virtual string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
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
