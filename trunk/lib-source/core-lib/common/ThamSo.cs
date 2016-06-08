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
        private static string _tenCongTy = ConfigurationSettings.AppSettings["ten_cong_ty"];
        private static string _diaChi = ConfigurationSettings.AppSettings["dia_chi"];
        private static string _printerName = ConfigurationSettings.AppSettings["printer"];

        public static string TenCongTy
        {
            get { return _tenCongTy; }
            set { _tenCongTy = value; }
        }

        public static string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public static string PrinterName
        {
            get { return _printerName; }
            set { _printerName = value; }
        }

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
