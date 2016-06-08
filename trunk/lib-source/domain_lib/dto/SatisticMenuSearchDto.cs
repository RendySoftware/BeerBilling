using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain_lib.dto
{
    public class StatisticMenuSearchDto
    {
        #region Declarations

        private string _fromDate = String.Empty;

        private string _toDate = String.Empty;

        private string _thang = String.Empty;

        private string _quy = String.Empty;

        private string _nam = String.Empty;

        #endregion

    	#region Constructor

        public StatisticMenuSearchDto()
        {
        }

    	#endregion

        #region Properties

        public virtual string FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }

        public virtual string ToDate
        {
            get { return _toDate; }
            set { _toDate = value; }
        }

        public virtual string Thang
        {
            get { return _thang; }
            set { _thang = value; }
        }

        public virtual string Quy
        {
            get { return _quy; }
            set { _quy = value; }
        }

        public virtual string Nam
        {
            get { return _nam; }
            set { _nam = value; }
        }

        #endregion

    }
}
