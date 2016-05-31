using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeerBilling.view;
using core_lib.common;
using domain_lib.dto;

namespace BeerBilling.presenter.billing
{
    public partial class BillingDetail : Form
    {
        private IBillingDAO _billingDao = new BillingDAOImpl();

        public BillingDetail(long billId)
        {
            InitializeComponent();
            FillData2Grid(billId);
        }

        private void FillData2Grid(long billId)
        {
            var billDto = _billingDao.getBillDto(billId);
            txtInHoaDon.Text = ConstUtil.YES.Equals(billDto.IsPrinted) ? "Đã in" : "Chưa in";
            string thanhToan = GetThanhToan(billDto.Payment);
            txtThanhToan.Text = thanhToan;
            var allResOrderDtos = _billingDao.GetAllResOrderBy(billId);
            dgvThucDon.Rows.Clear();
            float tongTien = 0;
            float oneTotal;
            foreach (var dto in allResOrderDtos)
            {
                AddOneResOrderRow(dto, out oneTotal);
                tongTien += oneTotal;
            }
            string tongVal = tongTien.ToString("#,###,###");
            txtTongTien.Text = string.IsNullOrEmpty(tongVal) ? string.Empty : tongVal + " VNĐ";
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

        private void AddOneResOrderRow(ResOrderDto dto, out float oneTotal)
        {
            oneTotal = dto.Amount * dto.MenuPrice * (1 - dto.Discount);
            int index = dgvThucDon.Rows.Add();
            var r = dgvThucDon.Rows[index];
            r.Cells["MON_AN"].Value = dto.MenuName;
            r.Cells["SO_LUONG"].Value = dto.Amount;
            r.Cells["DON_VI"].Value = dto.UnitName;
            r.Cells["DON_GIA"].Value = dto.MenuPrice.ToString("#,###,###") + " VNĐ";
            r.Cells["CHIET_KHAU"].Value = (dto.Discount * 100) + "%";
            r.Cells["THANH_TIEN"].Value = oneTotal.ToString("#,###,###") + " VNĐ";
            r.Cells["ResOrderId"].Value = dto.Id;
        }
    }
}
