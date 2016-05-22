using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace core_lib.common
{
    public class ParameterUtil
    {
        private static bool _useWord = "1".Equals(ConfigurationSettings.AppSettings["use_word"]);

        public static string GetParameter(string paraName)
        {
            return ConfigurationSettings.AppSettings != null
                       ? ConfigurationSettings.AppSettings[paraName]
                       : null;
        }

        public static bool UseWord
        {
            get { return _useWord; }
            set { _useWord = value; }
        }

    }
}
