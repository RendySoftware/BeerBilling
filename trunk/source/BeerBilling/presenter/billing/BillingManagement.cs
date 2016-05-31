using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using core_lib.common;
using domain_lib.dto;
using mcontrol.util;

namespace BeerBilling.presenter.billing
{
    public partial class BillingManagement : Form
    {
        private BillingDAOImpl _billingDao = new BillingDAOImpl();

        public BillingManagement()
        {
            InitializeComponent();

            var allBillDto = _billingDao.GetAllBill();
            FillBill2Grid(allBillDto);
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
            MControlUtil.FillToComboBox(tableComboBox, allDanhMucDto);
        }

        private void FillBill2Grid(List<BillDto> allBillDto)
        {
            dgvBilling.Rows.Clear();
            foreach (var billDto in allBillDto)
            {
                AddOneBillRow(billDto);
            }
        }

        private string GetThanhToan(string payment)
        {
            string thanhToan;
            if (ConstUtil.YES.Equals(payment))
            {
                thanhToan = "Đã thanh toán";
            }
            else if (ConstUtil.CANCEL.Equals(payment))
            {
                thanhToan = "Hủy";
            }
            else
            {
                thanhToan = "Chưa thanh toán";
            }
            return thanhToan;
        }

        private void AddOneBillRow(BillDto dto)
        {
            int index = dgvBilling.Rows.Add();
            var r = dgvBilling.Rows[index];
            r.Cells["billNumber"].Value = dto.BillingNumber;
            r.Cells["billDate"].Value = dto.BillingDate;
            r.Cells["tableNumber"].Value = dto.TableNumber;
            r.Cells["totalBill"].Value = GetTotalBill(dto.Id).ToString("#,###,###");
            r.Cells["billStatus"].Value = GetThanhToan(dto.Payment);
            r.Cells["createdBy"].Value = dto.CreatedBy;
            r.Cells["createdDate"].Value = dto.CreatedDate;
            r.Cells["detail"].Value = dto.CancelReason;
            r.Cells["billId"].Value = dto.Id;
        }

        private float GetTotalBill(long billId)
        {
            var allResOrderDtos = _billingDao.GetAllResOrderBy(billId);
            float tongTien = 0;
            float oneTotal;
            foreach (var dto in allResOrderDtos)
            {
                oneTotal = dto.Amount * dto.MenuPrice * (1 - dto.Discount);
                tongTien += oneTotal;
            }
            return tongTien;
        }

        private void dgvBilling_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {

        }
    }
}
