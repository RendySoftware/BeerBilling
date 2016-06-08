using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcontrol
{
    public sealed partial class MDateTextBox : MTextBox
    {
        private int _minYear = 1900;
        private int _maxYear = 2050;
        private int _currentYear = DateTime.Now.Year;

        public MDateTextBox()
        {
            InitializeComponent();
            _minYear = _currentYear - 200;
            _maxYear = _currentYear + 50;
        }

        public MDateTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            _minYear = _currentYear - 200;
            _maxYear = _currentYear + 50;
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            SelectAll();
        }
        private static int Get2SoCuoiCuaNam(DateTime ngay)
        {
            return Convert.ToInt32(ngay.Year.ToString().Substring(2, 2));
        }
        //Check mandatory textbox or not
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

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
                }
                catch (Exception)
                {
                    MMessageBox.Show(this, "Giá trị ngày tháng không hợp lệ!", "Thông báo"
                        , MMessageBoxButtons.OK, MMessageBoxIcon.Error);
                    Focus();
                    return;
                }
                int year = Convert.ToInt32(Text.Substring(4, 4));
                if (year < _minYear || year > _maxYear)
                {
                    MMessageBox.Show(this, "Giá trị ngày tháng không hợp lệ!", "Thông báo"
                        , MMessageBoxButtons.OK, MMessageBoxIcon.Error);
                    Focus();
                    return;
                }
                tmp = tmp.Insert(2, "/");
                tmp = tmp.Insert(5, "/");
                Text = tmp;

            }
            else if (Text.Length == 6)
            {
                int month = Convert.ToInt32(Text.Substring(2, 2));
                if ((month > 12 && month < 19) || month > 20)
                {
                    MMessageBox.Show(this, "Giá trị ngày tháng không hợp lệ!", "Thông báo"
                        , MMessageBoxButtons.OK, MMessageBoxIcon.Error);

                    Focus();
                    return;
                }
                string strYear;
                int year = Convert.ToInt32(Text.Substring(4, 2));
                if (month <= 12)
                {
                    if (year < Get2SoCuoiCuaNam(DateTime.Now)+50)
                        strYear = "20" + year;
                    else
                        strYear = "19" + year;
                    
                    if (Convert.ToInt32(strYear) < _minYear || Convert.ToInt32(strYear) > _maxYear)
                    {
                        MMessageBox.Show(this, "Giá trị ngày tháng không hợp lệ!", "Thông báo"
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
                        MMessageBox.Show(this, "Giá trị ngày tháng không hợp lệ!", "Thông báo"
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
                MMessageBox.Show(this, "Giá trị ngày tháng không hợp lệ!", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Error);
                Focus();
                return;
            }
        }
    }
}
