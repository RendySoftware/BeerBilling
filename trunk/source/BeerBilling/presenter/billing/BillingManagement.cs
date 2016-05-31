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
using mcontrol;
using mcontrol.util;

namespace BeerBilling.presenter.billing
{
    public partial class BillingManagement : Form
    {
        private IBillingDAO _billingDao = new BillingDAOImpl();

        public BillingManagement()
        {
            InitializeComponent();

            InitComboTable();
            InitComboStatus();
            txtFromDate.Text = DateUtil.GetCurrentDateTimeAsDdmmyyString();
            txtToDate.Text = DateUtil.GetCurrentDateTimeAsDdmmyyString();
            btnThucHien_Click(null, null);
        }

        private void InitComboStatus()
        {
            var allDanhMucDto = new List<DanhMucDto>();
            allDanhMucDto.Add(new DanhMucDto()
            {
                Id = ConstUtil.CANCEL,
                Ma = ConstUtil.CANCEL,
                Ten = "Hủy"
            });
            allDanhMucDto.Add(new DanhMucDto()
            {
                Id = ConstUtil.NO,
                Ma = ConstUtil.NO,
                Ten = "Chưa thanh toán"
            });
            allDanhMucDto.Add(new DanhMucDto()
            {
                Id = ConstUtil.YES,
                Ma = ConstUtil.YES,
                Ten = "Đã thanh toán"
            });
            MControlUtil.FillToComboBox(billStatusComboBox, allDanhMucDto);
        }

        private void InitComboTable()
        {
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
            string totalBill = GetTotalBill(dto.Id).ToString("#,###,###");
            r.Cells["totalBill"].Value = String.IsNullOrEmpty(totalBill) ? String.Empty : totalBill + " VNĐ";
            r.Cells["billStatus"].Value = GetThanhToan(dto.Payment);
            r.Cells["createdBy"].Value = dto.CreatedBy;
            r.Cells["createdDate"].Value = dto.CreatedDate;
            r.Cells["detail"].Value = ConstUtil.XEM;
            r.Cells["billId"].Value = dto.Id;
        }

        private long GetSelectedBillId()
        {
            int selectedIndex = dgvBilling.CurrentRow == null ? 0 : dgvBilling.CurrentRow.Index;
            if (selectedIndex > dgvBilling.RowCount - 1)
                selectedIndex = dgvBilling.RowCount - 1;
            if (selectedIndex == -1)
            {
                return -1;
            }
            var selectedBill = dgvBilling.Rows[selectedIndex];
            var billId = selectedBill.Cells["billId"].Value;
            return billId == null ? -1 : Convert.ToInt64(billId);
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

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            var tuNgay = txtFromDate.Text.Trim();
            var denNgay = txtToDate.Text.Trim();
            var billingNumber = txtBillingNumber.Text.Trim();
            var tableId = MControlUtil.GetValueFromCombobox(tableComboBox);
            var billStatus = MControlUtil.GetValueFromCombobox(billStatusComboBox);
            var allBillDto = _billingDao.GetAllBillBy(tuNgay, denNgay, billingNumber, tableId, billStatus);
            FillBill2Grid(allBillDto);
        }

        private void dgvBilling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBilling.Columns[e.ColumnIndex].Name == "detail")
            {
                var billId = GetSelectedBillId();
                var frmBillDetail = new BillingDetail(billId);
                frmBillDetail.ShowDialog(this);
            }
        }

        private void txtFromDate_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFromDate.Text.Trim()))
            {
                if (DateUtil.CompareWithCurrentDate(txtFromDate.Text.Trim()) == 1)
                {
                    MMessageBox.Show(this, "Giá trị từ ngày không được sau ngày hiện tại!", "Thông báo"
                                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                    txtFromDate.Focus();
                    return;
                }
            }
            if (!String.IsNullOrEmpty(txtFromDate.Text.Trim())
                && !String.IsNullOrEmpty(txtToDate.Text.Trim()))
            {
                if (DateUtil.CompareDate(txtFromDate.Text.Trim(), txtToDate.Text.Trim()) == 1)
                {
                    MMessageBox.Show(this, "Giá trị từ ngày không được sau giá trị đến ngày", "Thông báo"
                                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                    txtFromDate.Focus();
                    return;
                }
            }
        }

        private void txtToDate_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtToDate.Text.Trim()))
            {
                if (DateUtil.CompareWithCurrentDate(txtToDate.Text.Trim()) == 1)
                {
                    MMessageBox.Show(this, "Giá trị đến ngày không được sau ngày hiện tại!", "Thông báo"
                                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                    txtToDate.Focus();
                    return;
                }
            }
            if (!String.IsNullOrEmpty(txtFromDate.Text.Trim())
                && !String.IsNullOrEmpty(txtToDate.Text.Trim()))
            {
                if (DateUtil.CompareDate(txtFromDate.Text.Trim(), txtToDate.Text.Trim()) == 1)
                {
                    MMessageBox.Show(this, "Giá trị từ ngày không được sau giá trị đến ngày", "Thông báo"
                                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                    txtToDate.Focus();
                    return;
                }
            }
        }
    }
}
