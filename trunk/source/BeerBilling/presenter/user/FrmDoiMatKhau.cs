using System;
using System.Windows.Forms;
using BeerBilling.view;
using core_lib.common;
using mcontrol;

namespace BeerBilling.presenter.user
{
    public partial class FrmDoiMatKhau : Form
    {
        private string _userId;
        private IDanhSachUser _danhSachUser;

        public FrmDoiMatKhau()
        {
            InitializeComponent();
            _userId = ThamSo.UserId;
            _danhSachUser = new DanhSachUserImpl();
        }

        private void mLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mButton1_Click(object sender, EventArgs e)
        {
            if (!IsValidInputData())
            {
                return;
            }
            MMessageBox.Show(this, "Đổi mật khẩu thành công", "Thông báo"
                , MMessageBoxButtons.OK, MMessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private Boolean IsValidInputData()
        {
            if ("".Equals(txtMkCu.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa nhập mật khẩu cũ", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMkCu.Focus();
                return false;
            }

            if (!_danhSachUser.changePassword(_userId, txtMkMoi.Text.Trim(), txtMkCu.Text.Trim()))
            {
                MMessageBox.Show(this, "Mật khẩu cũ không đúng", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMkCu.Text = "";
                txtMkCu.Focus();
                return false;
            }

            if ("".Equals(txtMkMoi.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa nhập mật khẩu mới", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMkMoi.Focus();
                return false;
            }

            if ("".Equals(txtMkMoi2.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa nhập mật khẩu xác nhận", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMkMoi2.Focus();
                return false;
            }

            if (!txtMkMoi.Text.Equals(txtMkMoi2.Text.Trim()))
            {
                MMessageBox.Show(this, "Mật khẩu xác nhận không khớp", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMkMoi.Text = "";
                txtMkMoi2.Text = "";
                txtMkMoi.Focus();
                return false;
            }

            return true;
        }

        private void mButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            dspTen.Text = ThamSo.Username;
        }
    }
}
