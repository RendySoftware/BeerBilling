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

        public virtual string BillNumber
        {
            get { return _billNumber; }
            set { _billNumber = value; }
        }

        public BillingAdd()
        {
            InitializeComponent();

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
            }
            string tableNumber = cboBanSo.Text;
            string billingNumber = txtHoaDonSo.Text;
            _billNumber = tableNumber + "_" + billingNumber;
            var billDto = new BillDto();
            var tableId = MControlUtil.GetValueFromCombobox(cboBanSo);
            billDto.TableId = long.Parse(tableId);
            billDto.BillingNumber = int.Parse(billingNumber);
            string currentUserName = _danhSachUser.GetCurrentUserName();
            billDto.CreatedBy = currentUserName;
            billDto.UpdatedBy = currentUserName;
            _billingDao.AddNewBill(billDto);
            Dispose();
        }

        private bool IsValidInputData()
        {
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
