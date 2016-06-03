using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeerBilling.util;
using BeerBilling.view;
using domain_lib.dto;
using mcontrol;
using mcontrol.util;

namespace BeerBilling.presenter.user
{
    public partial class QuanLyNguoiDung : Form
    {
        private IDanhSachUser _danhSachUser = new DanhSachUserImpl();

        public QuanLyNguoiDung()
        {
            InitializeComponent();

            btnSearch_Click(null, null);
        }

        private void FillData2Grid(List<UserDto> allUserDto)
        {
            var selectedIndex = GetSelectedUserIndex();
            if (selectedIndex > allUserDto.Count - 1)
            {
                selectedIndex = allUserDto.Count - 1;
            }
            dgvUser.Rows.Clear();
            foreach (var dto in allUserDto)
            {
                AddOneUserRow(dto);
            }
            MControlUtil.SetSelectedIndex(dgvUser, selectedIndex, "UserName");
        }

        private int GetSelectedUserIndex()
        {
            int selectedIndex = dgvUser.CurrentRow == null ? 0 : dgvUser.CurrentRow.Index;
            if (selectedIndex > dgvUser.RowCount - 1)
                selectedIndex = dgvUser.RowCount - 1;
            return selectedIndex;
        }

        private long GetSelectedUserId()
        {
            int selectedIndex = GetSelectedUserIndex();
            if (selectedIndex == -1)
            {
                return -1;
            }
            var selectedUser = dgvUser.Rows[selectedIndex];
            var userId = selectedUser.Cells["UserId"].Value;
            return userId == null ? -1 : Convert.ToInt64(userId);
        }

        private void AddOneUserRow(UserDto dto)
        {
            int index = dgvUser.Rows.Add();
            var r = dgvUser.Rows[index];
            r.Cells["UserName"].Value = dto.UserName;
            r.Cells["FullName"].Value = dto.FullName;
            r.Cells["RoleName"].Value = UserUtil.GetRoleName(dto);
            r.Cells["Edit"].Value = "Sửa";
            r.Cells["Delete"].Value = "Xóa";
            r.Cells["UserId"].Value = dto.UserID;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text.Trim();
            var fullName = txtFullName.Text.Trim();
            var allUserDto = _danhSachUser.QueryUser(userName, fullName);
            FillData2Grid(allUserDto);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmThemNsd(-1);
            frm.ShowDialog(this);
            if (frm.IsChange)
            {
                btnSearch_Click(null, null);
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name == "Edit")
            {
                var userId = GetSelectedUserId();
                var frm = new FrmThemNsd(userId);
                frm.ShowDialog(this);
                if (frm.IsChange)
                {
                    btnSearch_Click(null, null);
                }
            }
            if (dgvUser.Columns[e.ColumnIndex].Name == "Delete")
            {
                var userId = GetSelectedUserId();
                var dr = MMessageBox.Show(this, "Bạn có muốn xóa người dùng?", "Thông báo"
                                          , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
                if (DialogResult.No == dr)
                {
                    return;
                }
                _danhSachUser.DeleteUser(userId);
                btnSearch_Click(null, null);
            }
        }
    }
}
