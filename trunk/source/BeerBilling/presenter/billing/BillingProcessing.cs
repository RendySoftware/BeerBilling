using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeerBilling.presenter.user;
using BeerBilling.report;
using BeerBilling.view;
using core_lib.common;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using domain_lib.dto;
using mcontrol;
using mcontrol.util;
using reportutil;

namespace BeerBilling.presenter.billing
{
    public partial class BillingProcessing : Form
    {
        private IDanhSachUser _danhSachUser = new DanhSachUserImpl();
        private IBillingDAO _billingDao = new BillingDAOImpl();
        private BillingReportDAOImpl _billingReportDao = new BillingReportDAOImpl(new BillingDataSet());

        public BillingProcessing()
        {
            InitializeComponent();

            var allMenuDtos = _billingDao.GetAllMenuDto();
            var allDanhMucDto = new List<DanhMucDto>();
            foreach (MenuDto dto in allMenuDtos)
            {
                allDanhMucDto.Add(new DanhMucDto()
                {
                    Id = Convert.ToString(dto.Id),
                    Ma = dto.Code,
                    Ten = dto.Name
                });
            }
            MControlUtil.FillToComboBox(cboMonAn, allDanhMucDto);
            txtChietKhau.Text = "0";

            FillBill2Grid();
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

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            var billId = GetSelectedBillId();
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
            txtTongTien.Text = tongTien.ToString("#,###,###");
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
            } else
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
            r.Cells["DON_GIA"].Value = dto.MenuPrice.ToString("#,###,###");
            r.Cells["CHIET_KHAU"].Value = (dto.Discount * 100) + "%";
            r.Cells["THANH_TIEN"].Value = oneTotal.ToString("#,###,###");
            r.Cells["ResOrderId"].Value = dto.Id;
        }

        private long GetSelectedBillId()
        {
            int selectedIndex = dgvHoaDon.CurrentRow == null ? 0 : dgvHoaDon.CurrentRow.Index;
            if (selectedIndex > dgvHoaDon.RowCount - 1)
                selectedIndex = dgvHoaDon.RowCount - 1;
            if (selectedIndex == -1)
            {
                return -1;
            }
            var selectedBill = dgvHoaDon.Rows[selectedIndex];
            var billId = selectedBill.Cells["billId"].Value;
            return billId == null ? -1 : Convert.ToInt64(billId);
        }

        private long GetSelectedResOrderId()
        {
            int selectedIndex = dgvThucDon.CurrentRow == null ? 0 : dgvThucDon.CurrentRow.Index;
            if (selectedIndex > dgvThucDon.RowCount - 1)
                selectedIndex = dgvThucDon.RowCount - 1;
            if (selectedIndex == -1)
            {
                return -1;
            }
            var selectedBill = dgvThucDon.Rows[selectedIndex];
            var resOrderId = selectedBill.Cells["ResOrderId"].Value;
            return resOrderId == null ? -1 : Convert.ToInt64(resOrderId);
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

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            if (!IsValidInputData())
            {
                return;
            }
            var dr = MMessageBox.Show(this, "Thêm thực đơn?", "Thông báo"
                                      , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
            if (DialogResult.No == dr)
            {
                return;
            }
            var resOrderDto = new ResOrderDto();
            resOrderDto.MenuId = long.Parse(MControlUtil.GetValueFromCombobox(cboMonAn));
            resOrderDto.BillId = GetSelectedBillId();
            resOrderDto.Amount = long.Parse(txtSoLuong.Text);
            var disCount = 0.0f;
            if (!"".Equals(txtChietKhau.Text))
            {
                disCount = long.Parse(txtChietKhau.Text)/100.0f;
            }
            resOrderDto.Discount = disCount;
            string currentUserName = _danhSachUser.GetCurrentUserName();
            resOrderDto.CreatedBy = currentUserName;
            resOrderDto.UpdatedBy = currentUserName;
            _billingDao.AddNewResOrder(resOrderDto);
            dgvHoaDon_SelectionChanged(null, null);
        }

        private bool IsValidInputData()
        {
            var billId = GetSelectedBillId();
            if (billId == -1)
            {
                MMessageBox.Show(this, "Bạn chưa chọn hóa đơn", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                btnThemHoaDon.Focus();
                return false;
            }

            if ("".Equals(cboMonAn.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa chọn món ăn", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                cboMonAn.Focus();
                return false;
            }
            if ("".Equals(txtSoLuong.Text.Trim()) || long.Parse(txtSoLuong.Text.Trim()) == 0)
            {
                MMessageBox.Show(this, "Bạn chưa nhập số lượng", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return false;
            }
            return true;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            var billId = GetSelectedBillId();
            var billDto = _billingDao.getBillDto(billId);
            if (ConstUtil.YES.Equals(billDto.IsPrinted))
            {
                MMessageBox.Show(this, "Hóa đơn đã được in!", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                //return;
            }
            var dr = MMessageBox.Show(this, "Bạn có muốn in hóa đơn?", "Thông báo"
                                      , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
            if (DialogResult.No == dr)
            {
                return;
            }
            var tongTien = float.Parse(txtTongTien.Text.Replace(",", ""));
            var frmThongTinKhachTt = new ThongTinKhachTT(tongTien);
            frmThongTinKhachTt.ShowDialog(this);
            var khachTt = frmThongTinKhachTt.KhachTt*1000f;
            if (khachTt == 0f)
            {
                return;
            }
            CreateReport(billDto, tongTien, khachTt);
            billDto.IsPrinted = ConstUtil.YES;
            _billingDao.ThanhToan(billDto);
            dgvHoaDon_SelectionChanged(null, null);
        }

        private void CreateReport(BillDto billDto, float tongTien, float khachTt)
        {
            var columnNames = new List<string> { "MonAn", "SoLuong", "DonGia", "Tong" };

            var dataTable = new DataTable();
            dataTable.Columns.Add(columnNames[0], Type.GetType("System.String"));
            dataTable.Columns.Add(columnNames[1], Type.GetType("System.String"));
            dataTable.Columns.Add(columnNames[2], Type.GetType("System.String"));
            dataTable.Columns.Add(columnNames[3], Type.GetType("System.String"));

            var allResOrderDtos = _billingDao.GetAllResOrderBy(billDto.Id);
            foreach(var dto in allResOrderDtos)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[columnNames[0]] = dto.MenuName;
                dataRow[columnNames[1]] = dto.Amount;
                dataRow[columnNames[2]] = dto.MenuPrice.ToString("#,###,###");
                float total = dto.Amount * dto.MenuPrice * (1 - dto.Discount);
                dataRow[columnNames[3]] = total.ToString("#,###,###");
                dataTable.Rows.Add(dataRow);
            }

            ReportClass report = new BillingReport();
            report.Database.Tables["BillDto"].SetDataSource(dataTable);
            report.SetParameterValue("TenCongTy", ThamSo.TenCongTy);
            report.SetParameterValue("DiaChi", ThamSo.DiaChi);
            report.SetParameterValue("BillNumber", billDto.BillingNumber.ToString());
            report.SetParameterValue("TenKhach", String.Empty);
            report.SetParameterValue("NhanVien", _danhSachUser.GetCurrentUserName());
            report.SetParameterValue("TongTien", tongTien.ToString("#,###,###"));
            report.SetParameterValue("KhachTT", khachTt.ToString("#,###,###"));
            report.SetParameterValue("KhachThua", (khachTt - tongTien).ToString("#,###,###"));

            report.PrintOptions.PrinterName = ThamSo.PrinterName;
            report.PrintOptions.PaperOrientation = PaperOrientation.Portrait;
            report.PrintToPrinter(1, false, 0, 0);

            //var frm = new FrmReport(report, false);
            //frm.Text = "In hóa đơn";
            //frm.ShowDialog(this);
            //frm.BringToFront();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var billId = GetSelectedBillId();
            var billDto = _billingDao.getBillDto(billId);
            if (ConstUtil.YES.Equals(billDto.Payment))
            {
                MMessageBox.Show(this, "Hóa đơn đã được thanh toán!", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                return;
            }
            var dr = MMessageBox.Show(this, "Bạn có muốn thanh toán?", "Thông báo"
                                      , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
            if (DialogResult.No == dr)
            {
                return;
            }
            billDto.Payment = ConstUtil.YES;
            _billingDao.ThanhToan(billDto);
            dgvHoaDon_SelectionChanged(null, null);
        }
        
        private void dgvHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'd' || e.KeyChar == 'D')
            {
                var billId = GetSelectedBillId();
                if (billId == -1)
                {
                    MMessageBox.Show(this, "Bạn chưa chọn hóa đơn", "Thông báo"
                        , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                    btnThemHoaDon.Focus();
                    return;
                }
                var dr = MMessageBox.Show(this, "Bạn có muốn xóa hóa đơn?", "Thông báo"
                                          , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
                if (DialogResult.No == dr)
                {
                    return;
                }
                var billingCancel = new BillingCancel();
                billingCancel.ShowDialog(this);
                var reason = billingCancel.Reason;
                if (String.IsNullOrEmpty(reason))
                {
                    return;
                }
                var billDto = _billingDao.getBillDto(billId);
                billDto.Payment = ConstUtil.CANCEL;
                billDto.CancelReason = reason;
                _billingDao.ThanhToan(billDto);
                dgvHoaDon_SelectionChanged(null, null);
            }
        }

        private void dgvThucDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'd' || e.KeyChar == 'D')
            {
                var resOrderId = GetSelectedResOrderId();
                if (resOrderId == -1)
                {
                    MMessageBox.Show(this, "Bạn chưa chọn thực đơn", "Thông báo"
                        , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                    btnThemHoaDon.Focus();
                    return;
                }
                var dr = MMessageBox.Show(this, "Bạn có muốn xóa thực đơn?", "Thông báo"
                                          , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
                if (DialogResult.No == dr)
                {
                    return;
                }
                _billingDao.DeleteResOrder(resOrderId);
                dgvHoaDon_SelectionChanged(null, null);
            }
        }
    }
}
