using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BeerBilling.util;
using BeerBilling.view;
using core_lib.common;
using domain_lib.dto;
using mcontrol;
using mcontrol.util;

namespace BeerBilling.presenter.user
{
    
    public partial class FrmThemNsd : Form
    {
        private IDanhSachUser _danhSachUser;
        private long _userID = -1;
        private bool _isChange = false;

        public FrmThemNsd(long userID)
        {
            InitializeComponent();
            _danhSachUser = new DanhSachUserImpl();
            _userID = userID;
            if (!IsNewUser())
            {
                Text = "Sửa thông tin người sử dụng";
                var userDto = _danhSachUser.GetUser(userID);
                txtUsername.Text = userDto.UserName;
                txtFullName.Text = userDto.FullName;
                DisableItemsU();
                LoadUserRoles(userDto);
            }
            chkQtht_CheckedChanged(null, null);
        }

        private void LoadUserRoles(UserDto userDto)
        {
            chkQtht.Checked = UserUtil.HasQthtRole(userDto);
            chkQlKho.Checked = UserUtil.HasQlkhRole(userDto);
            chkQlHd.Checked = UserUtil.HasQlhdRole(userDto);
        }

        private void DisableItemsU()
        {
            txtUsername.Enabled = false;
            txtMkMoi.Enabled = false;
            txtMkMoi2.Enabled = false;
        }

        public virtual bool IsChange
        {
            get { return _isChange; }
            set { _isChange = value; }
        }

        private bool IsNewUser()
        {
            return _userID == -1;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (!IsValidInputData()) return;
            var dr = MMessageBox.Show(this, "Lưu người dùng?", "Thông báo"
                                      , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
            if (DialogResult.No == dr)
            {
                Dispose();
                return;
            }
            _danhSachUser.SaveUser(CreateUserDto());
            _isChange = true;
            DialogResult = DialogResult.OK;
        }
        private UserDto CreateUserDto()
        {
            var result = new UserDto();

            result.UserID = _userID;
            result.UserName = txtUsername.Text.Trim();
            result.FullName = txtFullName.Text.Trim();
            result.Password = txtMkMoi.Text.Trim();
            UpdateUserRole(result);
            return result;
        }

        private void UpdateUserRole(UserDto userDto)
        {
            List<RoleDto> allRoleDto = new List<RoleDto>();
            if (chkQtht.Checked)
            {
                allRoleDto.Add(new RoleDto()
                {
                    RoleCode = ConstUtil.ADMIN
                });
            }
            if (chkQlKho.Checked)
            {
                allRoleDto.Add(new RoleDto()
                {
                    RoleCode = ConstUtil.QLKH
                });
            }
            if (chkQlHd.Checked)
            {
                allRoleDto.Add(new RoleDto()
                {
                    RoleCode = ConstUtil.QLHD
                });
            }
            userDto.AllRoles = allRoleDto.ToArray();
        }

        public bool IsValidInputData()
        {
            if (String.IsNullOrEmpty(txtFullName.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn phải nhập tên người dùng", "Thông báo", MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            var username = txtUsername.Text.Trim();

            if (String.IsNullOrEmpty(username))
            {
                MMessageBox.Show(this, "Bạn phải nhập thông tin Mã đăng nhập", "Thông báo", MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (_danhSachUser.ExistsUser(_userID, username))
            {
                MMessageBox.Show(this, "Đã tồn tại người dùng trong hệ thống", "Thông báo", MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (IsNewUser() && String.IsNullOrEmpty(txtMkMoi.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn phải nhập thông tin Mật khẩu", "Thông báo", MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMkMoi.Focus();
                return false;
            }

            if (IsNewUser() && String.IsNullOrEmpty(txtMkMoi2.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn phải nhập thông tin Mật khẩu xác nhận", "Thông báo", MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMkMoi2.Focus();
                return false;
            }

            if (IsNewUser() && !txtMkMoi.Text.Equals(txtMkMoi2.Text.Trim()))
            {
                MMessageBox.Show(this, "Mật khẩu xác nhận không khớp", "Thông báo", MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMkMoi.Text = "";
                txtMkMoi2.Text = "";
                txtMkMoi.Focus();
                return false;
            }

            return true;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            txtUsername.Text = ChangeAv(txtUsername.Text.Trim()).Trim();
        }

        public string ChangeAv(string ipStrChange)
        {
            Regex vRegRegex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string vStrFormD = ipStrChange.Normalize(NormalizationForm.FormD);
            return vRegRegex.Replace(vStrFormD, String.Empty)
                .Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        private void chkQtht_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQtht.Checked)
            {
                chkQlKho.Checked = true;
                chkQlHd.Checked = true;

                chkQlKho.Enabled = false;
                chkQlHd.Enabled = false;
            }
            else
            {
                chkQlKho.Enabled = true;
                chkQlHd.Enabled = true;
            }
        }

    }
}
