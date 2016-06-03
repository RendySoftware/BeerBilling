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

namespace BeerBilling.presenter.user
{
    public partial class QuanLyNguoiDung : Form
    {
        private IDanhSachUser _danhSachUser = new DanhSachUserImpl();

        public QuanLyNguoiDung()
        {
            InitializeComponent();

            var allUserDto = _danhSachUser.getAllUser();
            FillData2Grid(allUserDto);
        }

        private void FillData2Grid(List<UserDto> allUserDto)
        {
            dgvUser.Rows.Clear();
            foreach (var dto in allUserDto)
            {
                AddOneUserRow(dto);
            }
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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
