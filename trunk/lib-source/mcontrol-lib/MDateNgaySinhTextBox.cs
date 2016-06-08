using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace mcontrol
{
    public sealed partial class MDateNgaySinhTextBox : MTextBox
    {
        private int _minYear = 1900;
        private int _maxYear = 2050;
        private int _currentYear = DateTime.Now.Year;
        public MDateNgaySinhTextBox()
        {
            InitializeComponent();
            _minYear = _currentYear - 200;
            _maxYear = _currentYear;

        }

        public MDateNgaySinhTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            _minYear = _currentYear - 200;
            _maxYear = _currentYear;

            Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize);
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            SelectAll();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == (Char)Keys.Delete)
            {
                // Allow Digits and BackSpace, Delete char
            }

            else
            {
                e.Handled = true;
            }
        }

        private static int Get2SoCuoiCuaNam(DateTime ngay)
        {
            return Convert.ToInt32(ngay.Year.ToString().Substring(2, 2));
        }
        //Check mandatory textbox or not
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            Validate();
        }
        
        public void Validate()
        {
            if (Text.IndexOf("/") > -1)
            {
                Text = Text.Replace("/", "");
            }

            String tmp = Text;
            if (Text.Length == 8)
            {
                try
                {
                    new DateTime(Int32.Parse(Text.Substring(4, 4))
                                 , Int32.Parse(Text.Substring(2, 2))
                                 , Int32.Parse(Text.Substring(0, 2)));

                    int year = Convert.ToInt32(Text.Substring(4, 4));
                    int month = Convert.ToInt32(Text.Substring(2, 2));
                    int day = Convert.ToInt32(Text.Substring(0, 2));

                    if (year < _minYear || year > _maxYear
                        || (year == _maxYear && month > DateTime.Now.Month)
                        || (year == _maxYear && month == DateTime.Now.Month && day > DateTime.Now.Day))
                    {
                        MMessageBox.Show(this, "Giá trị ngày sinh không hợp lệ!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Error);
                        Focus();
                        return;
                    }
                    tmp = tmp.Insert(2, "/");
                    tmp = tmp.Insert(5, "/");
                    Text = tmp;
                }
                catch (Exception)
                {
                    MMessageBox.Show(this, "Giá trị ngày sinh không hợp lệ!", "Thông báo"
                        , MMessageBoxButtons.OK, MMessageBoxIcon.Error);
                    Focus();
                    return;
                }

            }
            else if (Text.Length == 6)
            {
                int month = Convert.ToInt32(Text.Substring(2, 2));
                if ((month > 12 && month < 19) || month > 20)
                {
                    MMessageBox.Show(this, "Giá trị ngày sinh không hợp lệ!", "Thông báo"
                        , MMessageBoxButtons.OK, MMessageBoxIcon.Error);

                    Focus();
                    return;
                }
                string strYear;
                int year = Convert.ToInt32(Text.Substring(4, 2));
                if (month <= 12)
                {
                    if (year <= Get2SoCuoiCuaNam(DateTime.Now))
                        strYear = "20" + year;
                    else
                        strYear = "19" + year;

                    if (Convert.ToInt32(strYear) < _minYear || Convert.ToInt32(strYear) > _maxYear)
                    {
                        MMessageBox.Show(this, "Giá trị ngày sinh không hợp lệ!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Error);

                        Focus();
                        return;
                    }

                    tmp = Text.Substring(0, 4) + strYear;
                    tmp = tmp.Insert(2, "/");
                    tmp = tmp.Insert(5, "/");
                    Text = tmp;
                    return;
                }
                if (month == 19 || month == 20)
                {
                    strYear = month + "" + year;
                    if (Convert.ToInt32(strYear) < _minYear || Convert.ToInt32(strYear) > _maxYear)
                    {
                        MMessageBox.Show(this, "Giá trị ngày sinh không hợp lệ!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Error);

                        Focus();
                        return;
                    }
                    tmp = Text.Substring(0, 2) + strYear;
                    tmp = tmp.Insert(2, "/");
                    Text = tmp;
                    return;
                }

            }
            else if (Text.Length == 4)
            {
                int year = Convert.ToInt32(Text.Substring(0, 4));
                if (year > _minYear && year < _maxYear)
                    return;

                int month = Convert.ToInt32(Text.Substring(0, 2));
                if ((month > 12 && month < 19) || month > 20)
                {
                    MMessageBox.Show(this, "Giá trị ngày sinh không hợp lệ!", "Thông báo"
                        , MMessageBoxButtons.OK, MMessageBoxIcon.Error);

                    Focus();
                    return;
                }

                string strYear;
                year = Convert.ToInt32(Text.Substring(2, 2));
                if (month <= 12)
                {
                    if (year < Get2SoCuoiCuaNam(DateTime.Now))
                        strYear = "20" + year;
                    else
                        strYear = "19" + year;

                    if (Convert.ToInt32(strYear) < _minYear || Convert.ToInt32(strYear) > _maxYear)
                    {
                        MMessageBox.Show(this, "Giá trị ngày sinh không hợp lệ!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Error);

                        Focus();
                        return;
                    }

                    tmp = Text.Substring(0, 2) + strYear;
                    tmp = tmp.Insert(2, "/");
                    Text = tmp;
                    return;
                }
            }
            else if (Text.Length > 0)
            {
                MMessageBox.Show(this, "Giá trị ngày sinh không hợp lệ!", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Error);
                Focus();
                return;
            }
        }
    }
}
