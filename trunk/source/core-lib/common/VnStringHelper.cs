using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace core_lib.common
{
    public class VnStringHelper
    {
        private static readonly VnStringHelper soleInstance = new VnStringHelper();

        private readonly Hashtable converterHash = new Hashtable();
        private readonly Hashtable visciiHash = new Hashtable();

        private readonly char[] englishChars = {
                                                   'A', 'E', 'I', 'Y', 'U', 'O', 'D', 'a', 'e', 'i', 'y', 'u', 'o', 'd'
                                               };

        private readonly char[][] vietNameseChars = {
                                                        new[]
                                                            {
                                                                'À', 'Á', 'Ả', 'Ã', 'Ạ', 'Ă', 'Ằ', 'Ắ', 'Ẳ', 'Ẵ',
                                                                'Ặ', 'Â', 'Ầ', 'Ấ',
                                                                'Ẩ', 'Ẫ', 'Ậ'
                                                            }
                                                        ,
                                                        new[]
                                                            {'È', 'É', 'Ẻ', 'Ẽ', 'Ẹ', 'Ê', 'Ề', 'Ế', 'Ể', 'Ễ', 'Ệ'}
                                                        , new[] {'Ì', 'Í', 'Ỉ', 'Ĩ', 'Ị'}
                                                        , new[] {'Ỳ', 'Ý', 'Ỷ', 'Ỹ', 'Ỵ'}
                                                        ,
                                                        new[]
                                                            {'Ù', 'Ú', 'Ủ', 'Ũ', 'Ụ', 'Ư', 'Ừ', 'Ứ', 'Ử', 'Ữ', 'Ự'}
                                                        ,
                                                        new[]
                                                            {
                                                                'Ò', 'Ó', 'Ỏ', 'Õ', 'Ọ', 'Ô', 'Ồ', 'Ố', 'Ổ', 'Ỗ',
                                                                'Ộ', 'Ơ', 'Ờ', 'Ớ',
                                                                'Ở', 'Ỡ', 'Ợ'
                                                            }
                                                        , new[] {'Đ'}
                                                        ,
                                                        new[]
                                                            {
                                                                'à', 'á', 'ả', 'ã', 'ạ', 'ă', 'ằ', 'ắ', 'ẳ', 'ẵ',
                                                                'ặ', 'â', 'ầ', 'ấ',
                                                                'ẩ', 'ẫ', 'ậ'
                                                            }
                                                        ,
                                                        new[]
                                                            {'è', 'é', 'ẻ', 'ẽ', 'ẹ', 'ê', 'ề', 'ế', 'ể', 'ễ', 'ệ'}
                                                        , new[] {'ì', 'í', 'ỉ', 'ĩ', 'ị'}
                                                        , new[] {'ỳ', 'ý', 'ỷ', 'ỹ', 'ỵ'}
                                                        ,
                                                        new[]
                                                            {'ù', 'ú', 'ủ', 'ũ', 'ụ', 'ư', 'ừ', 'ứ', 'ử', 'ữ', 'ự'}
                                                        ,
                                                        new[]
                                                            {
                                                                'ò', 'ó', 'ỏ', 'õ', 'ọ', 'ô', 'ồ', 'ố', 'ổ', 'ỗ',
                                                                'ộ', 'ơ', 'ờ', 'ớ',
                                                                'ở', 'ỡ', 'ợ'
                                                            }
                                                        , new[] {'đ'}
                                                    };

        private readonly char[][] visciiChars = {
                                                        new[]
                                                            {
                                                                'À', 'Á', 'Ä', 'Ã', '€', 'Å', '‚', '', 'Æ', 'Ç',
                                                                'ƒ', 'Â', '…', '„',
                                                                '†', 'ç', '‡'
                                                            }
                                                        ,
                                                        new[]
                                                            {'È', 'É', 'Ë', 'ˆ', '‰', 'Ê', '‹', 'Š', 'Œ', '', 'Ž'}
                                                        , new[] {'Ì', 'Í', '›', 'Î', '˜'}
                                                        , new[] {'Ÿ', 'Ý', 'Ö', 'Û', 'Ü'}
                                                        ,
                                                        new[]
                                                            {'Ù', 'Ú', 'œ', '', 'ž', '¿', '»', 'º', '¼', 'ÿ', '¹'}
                                                        ,
                                                        new[]
                                                            {
                                                                'Ò', 'Ó', '™', 'õ', 'š', 'Ô', '', '', '‘', '’',
                                                                '“', '´', '–', '•',
                                                                '—', '³', '”'
                                                            }
                                                        , new[] {'Ð'}
                                                        ,
                                                        new[]
                                                            {
                                                                'à', 'á', 'ä', 'ã', 'Õ', 'å', '¢', '¡', 'Æ', 'Ç',
                                                                '£', 'â', '¥', '¤',
                                                                '¦', 'ç', '§'
                                                            }
                                                        ,
                                                        new[]
                                                            {'è', 'é', 'ë', '¨', '©', 'ê', '«', 'ª', '¬', '­', '®'}
                                                        , new[] {'ì', 'í', 'ï', 'î', '¸'}
                                                        , new[] {'Ï', 'ý', 'Ö', 'Û', 'Ü'}
                                                        ,
                                                        new[]
                                                            {'ù', 'ú', 'ü', 'û', 'ø', 'ß', '×', 'Ñ', 'Ø', 'æ', 'ñ'}
                                                        ,
                                                        new[]
                                                            {
                                                                'ò', 'ó', 'ö', 'õ', '÷', 'ô', '°', '¯', '±', '²',
                                                                'µ', '½', '¶', '¾',
                                                                '·', 'Þ', 'þ'
                                                            }
                                                        , new[] {'ð'}
                                                    };

        public VnStringHelper()
        {
            for (int i = 0; i < vietNameseChars.Length; i++)
                for (int j = 0; j < vietNameseChars[i].Length; j++)
                    if (!converterHash.ContainsKey(vietNameseChars[i][j]))
                        converterHash.Add(vietNameseChars[i][j]
                                          , englishChars[i]);

            for (int i = 0; i < visciiChars.Length; i++)
                for (int j = 0; j < visciiChars[i].Length; j++)
                    if (!visciiHash.ContainsKey(visciiChars[i][j]))
                        visciiHash.Add(visciiChars[i][j]
                                          , englishChars[i]);
        }

        private static VnStringHelper getInstance()
        {
            return soleInstance;
        }

        private Boolean isVietNamChar(char vietNamChar)
        {
            for (int i = 0; i < vietNameseChars.Length; i++)
            {
                for (int j = 0; j < vietNameseChars[i].Length; j++)
                {
                    if (Equals(vietNameseChars[i][j], vietNamChar))
                        return true;
                }
            }
            for (int i = 0; i < visciiChars.Length; i++)
            {
                for (int j = 0; j < visciiChars[i].Length; j++)
                {
                    if (Equals(visciiChars[i][j], vietNamChar))
                        return true;
                }
            }
            return false;
        }

        private char getEnglishChar(char vietNameseChar)
        {
            if (!isVietNamChar(vietNameseChar))
                return vietNameseChar;
            if (converterHash.ContainsKey(vietNameseChar))
                return (char)converterHash[vietNameseChar];
            if (visciiHash.ContainsKey(vietNameseChar))
                return (char)visciiHash[vietNameseChar];
            return vietNameseChar;
        }

        public string vn2en(string vietNamStr)
        {
            string result = "";

            if (String.IsNullOrEmpty(vietNamStr)) return "";
            for (int i = 0; i < vietNamStr.Length; i++)
            {
                result += getEnglishChar(vietNamStr[i]);
            }
            return result;
        }

        public static String toEnglish(String str)
        {
            return str == null ? "" : getInstance().vn2en(str).ToUpper();
        }

        public static string normalizeTen(string inputName, bool toEnglish)
        {
            if (String.IsNullOrEmpty(inputName))
                return "";

            inputName = inputName.Trim();

            while (inputName.IndexOf("  ") > 0)
                inputName = inputName.Replace("  ", " ");

            string[] tmp = inputName.Split(new[] { ' ' });

            if (tmp.Length == 1)
                return TurnFirstToUpper(tmp[0]);

            inputName = "";

            for (int i = 0; i < tmp.Length; i++)
            {
                inputName += TurnFirstToUpper(tmp[i].ToLower()) + " ";
            }

            string nomalized = inputName.Substring(0, inputName.Length - 1);

            return !toEnglish ? nomalized : VnStringHelper.toEnglish(nomalized);
        }

        public static string TurnFirstToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                return "";

            input = input.ToLower();

            string temp = input.Substring(0, 1);

            return temp.ToUpper() + input.Remove(0, 1);
        }

        public static string TurnFirstToUpperOnly(string input)
        {
            if (String.IsNullOrEmpty(input))
                return "";

            string temp = input.Substring(0, 1);

            return temp.ToUpper() + input.Remove(0, 1);
        }

        public static string capitalize(string input)
        {
            if (String.IsNullOrEmpty(input))
                return "";

            TextInfo textInfo = new CultureInfo("vi-VN", false).TextInfo;

            return textInfo.ToTitleCase(input.ToLower());
        }

        public static string fillFull(String input, String pattern, int length)
        {
            //            return input + pattern;

            if (length <= 0)
                return input ?? "";

            String result = "";
            if (String.IsNullOrEmpty(input))
            {
                while (result.Length < length)
                    result += pattern;

                return result;
            }

            if (input.Length >= length)
                return input.Substring(0, length);

            result = input;
            while (result.Length < length)
                result += pattern;

            return result;
        }

        public static byte[] fillFull(byte[] input, int length)
        {
            if (length <= 0)
                return null;

            if (input == null || input.Length == 0)
                return new byte[length];

            //            if (length < input.Length)
            //                throw new Exception("Ngắn hơn!");

            Array.Resize(ref input, length);

            return input;
        }

        public static byte[] fillBytes(String input, int length)
        {
            if (input == null)
                return new byte[length];

            return fillFull(Encoding.Default.GetBytes(input), length);
        }


        public static string padZero(int i)
        {
            if (i.ToString().Length == 1)
                return "0" + i;

            return i.ToString();
        }

        public static string padZero(int i, int length)
        {
            String result = i.ToString();

            while (result.Length < length)
            {
                result = "0" + result;
            }

            return result;
        }

        public static string ToRoman(int number)
        {
            if (-9999 >= number || number >= 9999)
            {
                throw new ArgumentOutOfRangeException("number");
            }

            if (number == 0)
            {
                return "NULL";
            }

            var sb = new StringBuilder(10);

            if (number < 0)
            {
                sb.Append('-'); number *= -1;
            }
            var table =
                new string[,] {
                { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" }, 
                { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" }, 
                { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" }, 
                { "", "M", "MM", "MMM", "M(V)", "(V)", "(V)M", "(V)MM", "(V)MMM", "M(X)" }
                                                                                    };
            for (int i = 1000, j = 3; i > 0; i /= 10, j--)
            {
                int digit = number / i;
                sb.Append(table[j, digit]);
                number -= digit * i;
            }

            return sb.ToString();
        }

        public static string ToAlphabet(int number)
        {
            if (0 >= number || number >= 9999)
            {
                throw new ArgumentOutOfRangeException("number");
            }
            char[] chars = new char[1];
            chars[0] = (char)('A' + (char)(number - 1));
            return new string(chars);
        }

        public static bool isFloat(string value)
        {
            float f;
            return float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out f);
        }
    }
}
