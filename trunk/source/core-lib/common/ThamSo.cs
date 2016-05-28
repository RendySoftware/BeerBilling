using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace core_lib.common
{
    public class ThamSo
    {
        private static string _userId;
        public static string _username = "UNKNOWN";
        private static List<string> _userRoleList;
        private static string _nhomQuyenId;
        private static bool _useWord = "1".Equals(ConfigurationSettings.AppSettings["use_word"]);

        public static bool UseWord
        {
            get { return _useWord; }
            set { _useWord = value; }
        }

        public static List<string> UserRoleList
        {
            get { return _userRoleList; }
            set { _userRoleList = value; }
        }

        public static string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public static string NhomQuyenId
        {
            get { return _nhomQuyenId; }
            set { _nhomQuyenId = value; }
        }
    }
}
