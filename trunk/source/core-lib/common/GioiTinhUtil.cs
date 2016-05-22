using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core_lib.common
{
    public class GioiTinhUtil
    {
        public static string DecodeGioitinh(string ma)
        {
            if (String.IsNullOrEmpty(ma))
            {
                return string.Empty;
            }
            if (string.Compare(ma, ConstUtil.MA_GT_NAM) == 0)
            {
                return ConstUtil.TEN_GT_NAM;
            }
            if (string.Compare(ma, ConstUtil.MA_GT_NU) == 0)
            {
                return ConstUtil.TEN_GT_NU;
            }
            return string.Empty;
        }

        public static string EncodeGioiTinh(string ten)
        {
            if (String.IsNullOrEmpty(ten))
            {
                return string.Empty;
            }
            if (string.Compare(ten, ConstUtil.TEN_GT_NAM) == 0)
            {
                return ConstUtil.MA_GT_NAM;
            }
            if (string.Compare(ten, ConstUtil.TEN_GT_NU) == 0)
            {
                return ConstUtil.MA_GT_NU;
            }
            return string.Empty;
        }

        public static string GetDefaultPhotoUrlBy(string maGioiTinh)
        {
            return string.Compare(maGioiTinh, ConstUtil.MA_GT_NU, true) == 0
                       ? "~/dist/img/avatar2.png"
                       : "~/dist/img/avatar5.png";
        }
    }
}
