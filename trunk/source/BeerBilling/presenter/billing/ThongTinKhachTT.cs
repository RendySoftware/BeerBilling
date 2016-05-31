using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mcontrol;

namespace BeerBilling.presenter.billing
{
    public partial class ThongTinKhachTT : Form
    {
        private float _tongTien;
        private float _khachTt = 0;

        public virtual float KhachTt
        {
            get { return _khachTt; }
            set { _khachTt = value; }
        }

        public ThongTinKhachTT(float tongTien)
        {
            InitializeComponent();
            _tongTien = tongTien;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (!IsValidInputData())
            {
                return;
            }
            _khachTt = float.Parse(txtKhachTt.Text);
            Dispose();
        }

        private bool IsValidInputData()
        {
            if ("".Equals(txtKhachTt.Text.Trim()) || float.Parse(txtKhachTt.Text.Trim()) == 0f)
            {
                MMessageBox.Show(this, "Bạn chưa nhập tiền khách thanh toán", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtKhachTt.Focus();
                return false;
            }
            if (float.Parse(txtKhachTt.Text.Trim())*1000 < _tongTien)
            {
                MMessageBox.Show(this, "Tiền của khách ít hơn tổng thanh toán", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtKhachTt.Focus();
                return false;
            }
            return true;
        }
    }
}
