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
    public partial class BillingCancel : Form
    {
        private string _reason = String.Empty;

        public BillingCancel()
        {
            InitializeComponent();
        }

        public virtual string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!IsValidInputData())
            {
                return;
            }
            _reason = txtReason.Text;
            Dispose();
        }

        private bool IsValidInputData()
        {
            if ("".Equals(txtReason.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa nhập lý do", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtReason.Focus();
                return false;
            }
            return true;
        }
    }
}
