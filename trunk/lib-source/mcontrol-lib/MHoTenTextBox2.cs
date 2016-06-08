using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace mcontrol
{
    public sealed partial class MHoTenTextBox2 : MTextBox
    {
        public MHoTenTextBox2()
        {
            InitializeComponent();
            Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize,FontStyle.Bold);
            
        }

        public MHoTenTextBox2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize, FontStyle.Bold);
        }
        protected override void OnEnter(EventArgs e)
        {
            SelectAll();
        }
        protected override void OnLeave(EventArgs e)
        {
            if (this.Text == null || ReadOnly)
                return;

            var tmp = GetStringArray(Text.ToUpper(), ' ');
            Text = GetCaptilizeString(tmp);

        }

        private static String GetCaptilizeString(string[] str)
        {
            if (str == null) return null;
            var tmp = new string[str.Length];
            var index = 0;
            foreach (var s in str)
            {
                tmp[index++] = UppercaseAfterDot(UppercaseFirst(s));
            }
            return String.Join(" ", tmp);
        }

        private static string UppercaseAfterDot(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            var tmp = GetStringArray(s, '.');
            var result = new List<string>();
            foreach (string s1 in tmp)
            {
                var a = s1.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                result.Add(new string(a));
            }
            return String.Join(".", result.ToArray());
        }

        private static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            var a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
        private static string[] GetStringArray(string str, char separator)
        {
            string[] tmp = null;
            if (string.IsNullOrEmpty(str)) return tmp;
            char[] sp = { separator };
            tmp = str.Split(sp, StringSplitOptions.RemoveEmptyEntries);
            return tmp;
        }
    }
}
