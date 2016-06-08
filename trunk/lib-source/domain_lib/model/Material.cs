using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Material entity
/// </summary>
namespace domain_lib.model
{
    public class Material
    {
        #region Declarations

        // Property variables
        private long _id = -1;

        // Member variables
        private long _unit_Id = -1;

        private string _code = String.Empty;

        private string _name = String.Empty;

        

        #endregion

    	#region Constructor

        public Material()
        {
        }

        public Material(long id, long unit_id, string code, string name)
        {
            _id = id;
            _unit_Id = unit_id;
            _code = code;
            _name = name;

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

        

        #endregion

        #region Method Overrides

        public override string ToString()
        {
            return _name;
        }

        #endregion
    }
}