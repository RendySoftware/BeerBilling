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

namespace BeerBilling.presenter.billing
{
    public partial class BillingProcessing : Form
    {
        private BillingDAOImpl _billingDao = new BillingDAOImpl();
        private IStoreDAO _storeDao = new StoreDAOImpl();

        public BillingProcessing()
        {
            InitializeComponent();

            var allMaterialDtos = _storeDao.GetAllMaterial();
            foreach (var materialDto in allMaterialDtos)
            {
                cboMonAn.Items.Add(materialDto);
            }
            txtChietKhau.Text = "0";

            FillBill2Grid();
            dgvThucDon.SelectionChanged += new EventHandler(OnFillThucDon2Grid);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            var form = new BillingAdd();
            form.ShowDialog(this);
            if (!"".Equals(form.BillNumber))
            {
                FillBill2Grid();
            }
        }

        private void OnFillThucDon2Grid(object sender, EventArgs e)
        {
            var billId = GetSelectedBillId();
            var allResOrderDtos = _billingDao.GetAllResOrderBy(billId);
            foreach (var dto in allResOrderDtos)
            {
                AddOneResOrderRow(dto);
            }
        }

        private void AddOneResOrderRow(ResOrderDto dto)
        {
            var total = dto.Amount*dto.MenuPrice*(1 - dto.Discount);
            int index = dgvHoaDon.Rows.Add();
            var r = dgvHoaDon.Rows[index];
            r.Cells["MON_AN"].Value = dto.MenuName;
            r.Cells["SO_LUONG"].Value = dto.Amount;
            r.Cells["DON_VI"].Value = dto.UnitName;
            r.Cells["DON_GIA"].Value = dto.MenuPrice;
            r.Cells["CHIET_KHAU"].Value = dto.Discount;
            r.Cells["THANH_TIEN"].Value = total;
            r.Cells["ResOrderId"].Value = dto.Id;
        }

        private long GetSelectedBillId()
        {
            var selectedBills = dgvHoaDon.SelectedRows;
            if (selectedBills.Count == 0)
            {
                return -1;
            }
            return (long) selectedBills[0].Cells["billId"].Value;
        }

        private void FillBill2Grid()
        {
            var allBillDto = _billingDao.GetAllNotCompletedBill();
            dgvHoaDon.Rows.Clear();
            foreach (var billDto in allBillDto)
            {
                AddOneBillRow(billDto);
            }
        }

        private void AddOneBillRow(BillDto billDto)
        {
            string billNumber = billDto.TableNumber + "_" + billDto.BillingNumber;
            int index = dgvHoaDon.Rows.Add();
            var r = dgvHoaDon.Rows[index];
            r.Cells["billNumber"].Value = "Hóa đơn " + billNumber;
            r.Cells["billId"].Value = billDto.Id;
        }
    }
}
