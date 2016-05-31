using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeerBilling.view;
using domain_lib.dto;
using mcontrol;
using mcontrol.util;

namespace BeerBilling.presenter.billing
{
    public partial class ThongTinKhachTT : Form
    {
        private float _tongTien;
        private float _khachTt = 0;
        private string _tenNhanVien;
        private IBillingDAO _billingDao = new BillingDAOImpl();

        public virtual float KhachTt
        {
            get { return _khachTt; }
            set { _khachTt = value; }
        }

        public virtual string TenNhanVien
        {
            get { return _tenNhanVien; }
            set { _tenNhanVien = value; }
        }

        public ThongTinKhachTT(float tongTien)
        {
            InitializeComponent();
            _tongTien = tongTien;
            var allEmployeeDto = _billingDao.GetAllEmployee();
            var allDanhMucDto = new List<DanhMucDto>();
            foreach (EmployeeDto dto in allEmployeeDto)
            {
                allDanhMucDto.Add(new DanhMucDto()
                {
                    Id = Convert.ToString(dto.Id),
                    Ma = dto.EmployeeId,
                    Ten = dto.FullName
                });
            }
            MControlUtil.FillToComboBox(cboEmployee, allDanhMucDto);
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
            _tenNhanVien = cboEmployee.Text.Trim();
            Dispose();
        }

        private bool IsValidInputData()
        {
            if ("".Equals(cboEmployee.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa chọn nhân viên", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                cboEmployee.Focus();
                return false;
            }
            float khachTt = float.Parse(txtKhachTt.Text.Trim());
            if ("".Equals(txtKhachTt.Text.Trim()) || khachTt == 0f)
            {
                MMessageBox.Show(this, "Bạn chưa nhập tiền khách thanh toán", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtKhachTt.Focus();
                return false;
            }
            if (khachTt < _tongTien)
            {
                MMessageBox.Show(this, "Tiền của khách ít hơn tổng thanh toán: " + (_tongTien - khachTt).ToString("#,###,###") + " VNĐ", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtKhachTt.Focus();
                return false;
            }
            return true;
        }
    }
}
