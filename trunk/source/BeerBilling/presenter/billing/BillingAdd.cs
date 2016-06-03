using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeerBilling.presenter.user;
using BeerBilling.view;
using domain_lib.dto;
using mcontrol;
using mcontrol.util;

namespace BeerBilling.presenter.billing
{
    public partial class BillingAdd : Form
    {
        private IDanhSachUser _danhSachUser = new DanhSachUserImpl();
        private BillingDAOImpl _billingDao = new BillingDAOImpl();

        private string _billNumber = String.Empty;
        private long _billId = -1;
        private bool _isChange = false;

        public virtual string BillNumber
        {
            get { return _billNumber; }
            set { _billNumber = value; }
        }

        public virtual bool IsChange
        {
            get { return _isChange; }
            set { _isChange = value; }
        }

        public BillingAdd(long billId)
        {
            InitializeComponent();
            _billId = billId;

            var allResTableDtos = _billingDao.GetAllResTableDto();
            var allDanhMucDto = new List<DanhMucDto>();
            foreach (ResTableDto dto in allResTableDtos)
            {
                allDanhMucDto.Add(new DanhMucDto()
                                      {
                                          Id = Convert.ToString(dto.Id),
                                          Ma = dto.Code,
                                          Ten = dto.Position
                                      });
            }
            MControlUtil.FillToComboBox(cboBanSo, allDanhMucDto);

            var allEmployeeDto = _billingDao.GetAllEmployee();
            allDanhMucDto = new List<DanhMucDto>();
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

            if (billId != -1)
            {
                var billDto = _billingDao.getBillDto(billId);
                cboBanSo.SelectedValue = Convert.ToString(billDto.TableId);
                cboEmployee.Text = billDto.EmployeeName;
                txtHoaDonSo.Text = Convert.ToString(billDto.BillingNumber);
                string tableNumber = cboBanSo.Text;
                string billingNumber = txtHoaDonSo.Text;
                _billNumber = tableNumber + "_" + billingNumber;
                this.Text = "Cập nhật";
                btnThem.Text = "Cập nhật";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!IsValidInputData())
            {
                return;
            }
            var dr = MMessageBox.Show(this, "Lưu hóa đơn?", "Thông báo"
                                      , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
            if (DialogResult.No == dr)
            {
                Dispose();
                return;
            }
            string tableNumber = cboBanSo.Text;
            string billingNumber = txtHoaDonSo.Text;
            _billNumber = tableNumber + "_" + billingNumber;
            var billDto = new BillDto();
            billDto.Id = _billId;
            var tableId = MControlUtil.GetValueFromCombobox(cboBanSo);
            billDto.TableId = long.Parse(tableId);
            billDto.BillingNumber = int.Parse(billingNumber);
            billDto.EmployeeId = MControlUtil.GetValueFromCombobox(cboEmployee);
            billDto.EmployeeName = cboEmployee.Text.Trim();
            string currentUserName = _danhSachUser.GetCurrentUserName();
            billDto.CreatedBy = currentUserName;
            billDto.UpdatedBy = currentUserName;
            _billingDao.SaveBill(billDto);
            _isChange = true;
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
            if ("".Equals(txtHoaDonSo.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa nhập số hóa đơn", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtHoaDonSo.Focus();
                return false;
            }
            if ("".Equals(cboBanSo.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa chọn số bàn", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                cboBanSo.Focus();
                return false;
            }
            return true;
        }
    }
}
