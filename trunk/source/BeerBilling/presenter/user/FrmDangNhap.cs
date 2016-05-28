using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using BeerBilling.util;
using BeerBilling.view;
using core_lib.common;
using mcontrol;

namespace BeerBilling.presenter.user
{
    public partial class FrmDangNhap : Form
    {
        private IDanhSachUser _danhSachUser;
        private int failLoginTime;
        private EventHandler _successHandler;
        private EventHandler _cancelHandler;

        public FrmDangNhap()
        {
            InitializeComponent();
            BringToFront();
            _danhSachUser = new DanhSachUserImpl();
            failLoginTime = 0;
        }

        public void AddSuccessHander(EventHandler handler)
        {
            _successHandler += handler;
        }

        public void AddCancelHander(EventHandler handler)
        {
            _cancelHandler += handler;
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            ThamSo.UserId = null;
            ThamSo.UserRoleList = new List<string>();
            lblOTP.Visible = false;
            txtOTP.Visible = false;
            btnDongY.Location = new Point(116, 135);
            btnHuy.Location = new Point(225, 135);
        }

        public List<string> GetUserRoleList()
        {
            return ThamSo.UserRoleList;
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (String.IsNullOrEmpty(ThamSo.UserId) && _cancelHandler != null)
            {
                _cancelHandler(this, null);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ThamSo.UserId = null;
            ThamSo.UserRoleList = new List<string>();
            Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var userDto = _danhSachUser.CheckUser(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            var messageText = userDto.Message;
            if (String.IsNullOrEmpty(messageText))
            {
                ThamSo.Username = txtUserName.Text.Trim();
                ThamSo.UserId = userDto.UserID.ToString();
                ThamSo.UserRoleList = UserUtil.getAllRoleCode(userDto);
                Close();
                if (_successHandler != null)
                {
                    _successHandler(this, e);
                }
            }
            else
            {
                MMessageBox.Show(this, messageText, "Lỗi"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Error);
                failLoginTime++;
                if (failLoginTime >= 3) Application.Exit();
            }
        }

//        private void ShowNewChild()
//        {
//            Form form = new FrmChonNhomQuyen();
//            form.ShowDialog(this);
//        }

     }
}
