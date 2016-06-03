using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace core_lib.common
{
    public class DateUtil
    {
        public static string SeparateDate = "/";
        private static int _minYear = DateTime.Now.Year - 200;
        private static int _maxYear = DateTime.Now.Year + 50;

        public static string GetDateTimeAsStringWithProvider(DateTime? dateTime, string dateFormat, string strProvider)
        {
            if (dateTime == null)
            {
                return string.Empty;
            }
            DateTime aDate = (DateTime) dateTime;
            var provider = new CultureInfo(strProvider);
            try
            {
                return aDate.ToString(dateFormat, provider);
            }
            catch (FormatException)
            {
                return "";
            }
        }

        public static string GetDateTimeAsStringWithEnProvider(DateTime? dateTime, string dateFormat)
        {
            return GetDateTimeAsStringWithProvider(dateTime, dateFormat, "en-US");
        }

        public static DateTime? GetDateTime(string date)
        {
            date = date.Replace("/", "");
            return new NgayThang(GetDateStringFromShortedFormat(date)).GetDateTime;
        }

        public static DateTime? TruncateDateTime(DateTime date)
        {
            var dateVal = GetDateTimeAsDdmmyyyy(date);
            return GetDateTime(dateVal);
        }

        public static string GetDateTimeAsDdmmyyyy(DateTime? date)
        {
            if (date == null || DateTime.MinValue.Equals(date) ||
                DateTime.MaxValue.Equals(date))
                return "";
            DateTime aDate = (DateTime) date;
            string day = PadValue(aDate.Day);

            string month = PadValue(aDate.Month);

            return day + SeparateDate + month + SeparateDate + aDate.Year;
        }

        public static string GetDateTimeAsMmDdyyyy(DateTime date)
        {
            string day = PadValue(date.Day);

            string month = PadValue(date.Month);

            return month + SeparateDate + day + SeparateDate + date.Year;
        }

        public static string GetDateAsAnyFormat(DateTime ngay, String defNgay)
        {
            if (DateTime.MinValue.Equals(ngay) ||
                DateTime.MaxValue.Equals(ngay))
                return "";
            string temp = "dd/MM/yyyy";
            if (!String.IsNullOrEmpty(defNgay))
            {
                if (defNgay.Equals("Y"))
                {
                    temp = "yyyy";
                }
                else
                {
                    if (defNgay.Equals("M"))
                    {
                        temp = "MM/yyyy";
                    }
                    else
                    {
                        temp = "dd/MM/yyyy";
                    }
                }
            }
            return GetDateTimeAsStringWithEnProvider(ngay, temp);
        }

        public static string GetDateAsAnyFormat(string yyyymmdd, String defNgay)
        {
            if (yyyymmdd != null && defNgay != null)
            {
                if (defNgay.Equals("Y"))
                {
                    return yyyymmdd;
                }
                if (defNgay.Equals("M"))
                {
                    return yyyymmdd.Substring(4, 2) + "/" + yyyymmdd.Substring(0, 4);
                }
                return yyyymmdd.Substring(6, 2) + "/" + yyyymmdd.Substring(4, 2)
                       + "/" + yyyymmdd.Substring(0, 4);
            }
            return "";
        }

        public static string PadValue(int d)
        {
            return d < 10 ? "0" + d : d.ToString();
        }

        public static string GetCurrentDateTimeAsPrintDate()
        {
            var now = DateTime.Now;
            var printDate = "ngày " + PadValue(now.Day) + " tháng "
                + PadValue(now.Month) + " năm " + now.Year;
            return printDate;
        }

        public static DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        public static string GetCurrentDateTimeAsEnString()
        {
            return GetDateTimeAsStringWithEnProvider(GetCurrentDateTime(), "MMMM dd, yyyy");
        }

        public static string GetCurrentDateTimeAsMmddyyyyString()
        {
            return DateUtil.GetDateTimeAsMmDdyyyy(DateTime.Now);
        }

        public static string GetCurrentDateTimeAsDdmmyyString()
        {
            return DateUtil.GetDateTimeAsDdmmyyyy(DateTime.Now);
        }

        public static string GetNamHienTai()
        {
            return DateTime.Now.Year.ToString();
        }

        public static int GetQuyHienTai()
        {
            var month = DateTime.Now.Month;
            int quater;
            if (1 <= month && month <= 3)
            {
                quater = 1;
            }
            else if (4 <= month && month <= 6)
            {
                quater = 2;
            }
            else if (7 <= month && month <= 9)
            {
                quater = 3;
            }
            else
            {
                quater = 4;
            }
            return quater;
        }

        public static int CompareWithCurrentDate(string strDate)
        {
            return CompareDate(strDate, GetCurrentDateTimeAsDdmmyyString());
        }

        public static int CompareDate(string strDate1, string strDate2)
        {
            if (!String.IsNullOrEmpty(strDate1) && !String.IsNullOrEmpty(strDate2))
            {
                var date1 = GetDateTime(strDate1);
                var date2 = GetDateTime(strDate2);
                if (default(DateTime).Equals(date1) || default(DateTime).Equals(date2))
                    return -2;
                if (date1 < date2)
                    return -1;
                if (date1 == date2)
                    return 0;
                if (date1 > date2)
                    return 1;
            }

            return -2;
        }

        public static string GetDateStringFromShortedFormat(string shortedFormat)
        {
            if (shortedFormat == null)
                return "";
            shortedFormat = shortedFormat.Trim();
            if (shortedFormat.IndexOf("/") > -1)
            {
                shortedFormat = shortedFormat.Replace("/", "");
            }

            String tmp = shortedFormat;
            if (shortedFormat.Length == 8)
            {
                try
                {
                    new DateTime(Int32.Parse(shortedFormat.Substring(4, 4))
                                 , Int32.Parse(shortedFormat.Substring(2, 2))
                                 , Int32.Parse(shortedFormat.Substring(0, 2)));
                }
                catch (Exception)
                {
                    return shortedFormat;
                }
                int year = Convert.ToInt32(shortedFormat.Substring(4, 4));
                if (year <= _minYear || year >= _maxYear)
                {
                    return "";
                }
                tmp = tmp.Insert(2, "/");
                tmp = tmp.Insert(5, "/");
                return tmp;
            }
            if (shortedFormat.Length == 6)
            {
                int month = Convert.ToInt32(shortedFormat.Substring(2, 2));
                if ((month > 12 && month < 19) || month > 20)
                {
                    return shortedFormat;
                }
                string strYear;
                int year = Convert.ToInt32(shortedFormat.Substring(4, 2));
                if (month <= 12)
                {
                    if (year < Get2SoCuoiCuaNam(DateTime.Now) + 50)
                        strYear = "20" + year;
                    else
                        strYear = "19" + year;

                    if (Convert.ToInt32(strYear) <= _minYear || Convert.ToInt32(strYear) >= _maxYear)
                    {
                        return "";
                    }

                    tmp = shortedFormat.Substring(0, 4) + strYear;
                    tmp = tmp.Insert(2, "/");
                    tmp = tmp.Insert(5, "/");
                    return tmp;
                }
                if (month == 19 || month == 20)
                {
                    strYear = month + "" + year;
                    if (Convert.ToInt32(strYear) <= _minYear || Convert.ToInt32(strYear) >= _maxYear)
                    {
                        return "";
                    }
                    tmp = shortedFormat.Substring(0, 2) + strYear;
                    tmp = tmp.Insert(2, "/");
                    return tmp;
                }

            }
            else if (shortedFormat.Length > 0)
            {
                return shortedFormat;
            }
            return shortedFormat;
        }

        public static bool IsValidDate(string shortedFormat)
        {
            if (shortedFormat.IndexOf("/") > -1)
            {
                shortedFormat = shortedFormat.Replace("/", "");
            }

            String tmp = shortedFormat;
            if (shortedFormat.Length == 8)
            {
                try
                {
                    new DateTime(Int32.Parse(shortedFormat.Substring(4, 4))
                                 , Int32.Parse(shortedFormat.Substring(2, 2))
                                 , Int32.Parse(shortedFormat.Substring(0, 2)));
                }
                catch (Exception)
                {
                    return false;
                }
                int year = Convert.ToInt32(shortedFormat.Substring(4, 4));
                if (year < _minYear || year > _maxYear)
                {
                    return false;
                }
                return true;
            }
            if (shortedFormat.Length == 6)
            {
                int month = Convert.ToInt32(shortedFormat.Substring(2, 2));
                if ((month > 12 && month < 19) || month > 20)
                {
                    return false;
                }
                string strYear;
                int year = Convert.ToInt32(shortedFormat.Substring(4, 2));
                if (month <= 12)
                {
                    if (year < Get2SoCuoiCuaNam(DateTime.Now) + 50)
                        strYear = "20" + year;
                    else
                        strYear = "19" + year;

                    if (Convert.ToInt32(strYear) <= _minYear || Convert.ToInt32(strYear) >= _maxYear)
                    {
                        return false;
                    }

                    return true;
                }
                if (month == 19 || month == 20)
                {
                    strYear = month + "" + year;
                    if (Convert.ToInt32(strYear) <= _minYear || Convert.ToInt32(strYear) >= _maxYear)
                    {
                        return false;
                    }
                    return true;
                }

            }
            else if (shortedFormat.Length > 0)
            {
                return false;
            }
            return false;
        }

        public static int Get2SoCuoiCuaNam(DateTime ngay)
        {
            return Convert.ToInt32(ngay.Year.ToString().Substring(2, 2));
        }

        public struct DateTimeSpan
        {
            private readonly int years;
            private readonly int months;
            private readonly int days;
            private readonly int hours;
            private readonly int minutes;
            private readonly int seconds;
            private readonly int milliseconds;

            public DateTimeSpan(int years, int months, int days, int hours, int minutes, int seconds, int milliseconds)
            {
                this.years = years;
                this.months = months;
                this.days = days;
                this.hours = hours;
                this.minutes = minutes;
                this.seconds = seconds;
                this.milliseconds = milliseconds;
            }

            public int Years { get { return years; } }
            public int Months { get { return months; } }
            public int Days { get { return days; } }
            public int Hours { get { return hours; } }
            public int Minutes { get { return minutes; } }
            public int Seconds { get { return seconds; } }
            public int Milliseconds { get { return milliseconds; } }

            enum Phase { Years, Months, Days, Done }

            public static DateTimeSpan CompareDates(DateTime date1, DateTime date2)
            {
                if (date2 < date1)
                {
                    var sub = date1;
                    date1 = date2;
                    date2 = sub;
                }

                DateTime current = date1;
                int years = 0;
                int months = 0;
                int days = 0;

                Phase phase = Phase.Years;
                DateTimeSpan span = new DateTimeSpan();

                while (phase != Phase.Done)
                {
                    switch (phase)
                    {
                        case Phase.Years:
                            if (current.AddYears(years + 1) > date2)
                            {
                                phase = Phase.Months;
                                current = current.AddYears(years);
                            }
                            else
                            {
                                years++;
                            }
                            break;
                        case Phase.Months:
                            if (current.AddMonths(months + 1) > date2)
                            {
                                phase = Phase.Days;
                                current = current.AddMonths(months);
                            }
                            else
                            {
                                months++;
                            }
                            break;
                        case Phase.Days:
                            if (current.AddDays(days + 1) > date2)
                            {
                                current = current.AddDays(days);
                                var timespan = date2 - current;
                                span = new DateTimeSpan(years, months, days, timespan.Hours, timespan.Minutes, timespan.Seconds, timespan.Milliseconds);
                                phase = Phase.Done;
                            }
                            else
                            {
                                days++;
                            }
                            break;
                    }
                }

                return span;
            }
        }
    }
}
