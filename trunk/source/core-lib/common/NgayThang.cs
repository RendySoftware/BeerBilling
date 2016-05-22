using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace core_lib.common
{
    public class NgayThang
    {
        private readonly string dateAsString;

        public NgayThang(string dateAsString)
        {
            if (dateAsString == null)
                return;

            dateAsString = dateAsString.Replace("-", "/");
            dateAsString = dateAsString.Replace(".", "/");
            dateAsString = dateAsString.Replace(" ", "/");

            string[] tmp = dateAsString.Split(new[] { '/' });

            if (tmp.Length == 1)
            {
                this.dateAsString = dateAsString;
                return;
            }

            this.dateAsString = "";
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = padding(tmp[i], 2);
                this.dateAsString += tmp[i];
            }
        }

        public bool IsValid
        {
            get
            {
                DateTime dt;

                return DateTime.TryParseExact(
                    dateAsString,
                    new[] { "ddMMyyyy", "MMyyyy", "yyyy" },
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out dt);
            }
        }

        public String Message
        {
            get { return IsValid ? "" : "Ngày nhập sai quy cách!"; }
        }

        public string Def
        {
            get
            {
                if (!IsValid)
                    return null;

                if (dateAsString.Length == 4)
                    return "Y";

                if (dateAsString.Length == 6)
                    return "M";

                return "D";
            }
        }

        public DateTime? GetDateTime
        {
            get
            {
                if (!IsValid)
                    return null;

                DateTime dt;

                DateTime.TryParseExact(
                    dateAsString,
                    new[] { "ddMMyyyy", "MMyyyy", "yyyy" },
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out dt);

                return ( !DateTime.MinValue.Equals(dt) 
                    && !DateTime.MaxValue.Equals(dt) 
                    && !default(DateTime).Equals(dt) ) ? (DateTime?)dt : null;
            }
        }

        public new string ToString
        {
            get
            {
                try
                {
                    return String.Format("{0:dd/MM/yyyy}", GetDateTime);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        private static string padding(string s, int i)
        {
            if (s == null)
                return null;

            while (s.Length < i)
            {
                s = "0" + s;
            }
            return s;
        }
    }
}
