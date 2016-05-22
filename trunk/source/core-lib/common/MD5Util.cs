using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace core_lib.common
{
    public class MD5Util
    {
        private static string ToHexString(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return "";
            }
            var sb = new StringBuilder();
            foreach (byte b in bytes)
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        private static byte[] String2ByteArray(string val)
        {
            if (String.IsNullOrEmpty(val))
            {
                return new byte[0];
            }
            char[] chars = val.ToCharArray();
            byte[] bytes = new byte[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                bytes[i] = (byte)chars[i];
            }
            return bytes;
        }

        public static string EncodeMD5(string val)
        {
            return ToHexString(MD5.Create().ComputeHash(String2ByteArray(val)));
        }
    }
}
