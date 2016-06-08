using System;

namespace domain_lib.dto
{
    public class StatisticStoreDto
    {
        #region Declarations

        private string _materialName = String.Empty;
        private string _unitName = String.Empty;

        private float _previousInventory = 0;
        private float _impAmount = 0;
        private float _expAmount = 0;
        private float inventory = 0;

        #endregion

    	#region Constructor

        public StatisticStoreDto()
        {
        }

    	#endregion

        #region Properties

        public virtual float PreviousInventory
        {
            get { return _previousInventory; }
            set { _previousInventory = value; }
        }

        public virtual float ImpAmount
        {
            get { return _impAmount; }
            set { _impAmount = value; }
        }

        public virtual float ExpAmount
        {
            get { return _expAmount; }
            set { _expAmount = value; }
        }

        public virtual float Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }

        /// <summary>
        /// MaterialName.
        /// </summary>
        public virtual string MaterialName
        {
            get { return _materialName; }
            set { _materialName = value; }
        }

        /// <summary>
        /// UnitName
        /// </summary>
        public virtual string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }

        #endregion

    }
}