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
using core_lib.common;
using domain_lib.dto;
using mcontrol;
using mcontrol.util;

namespace BeerBilling.presenter.billing
{
    public partial class BillingProcessing : Form
    {
        private IDanhSachUser _danhSachUser = new DanhSachUserImpl();
        private BillingDAOImpl _billingDao = new BillingDAOImpl();
        private IStoreDAO _storeDao = new StoreDAOImpl();

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
            dgvHoaDon.SelectionChanged += new EventHandler(OnFillThucDon2Grid);
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
            var billDto = _billingDao.getBillDto(billId);
            txtInHoaDon.Text = "YES".Equals(billDto.IsPrinted) ? "Đã in" : "Chưa in";
            string thanhToan;
            if ("YES".Equals(billDto.Payment))
            {
                thanhToan = "Đã thanh toán";
            } else if ("CANCEL".Equals(billDto.Payment))
            {
                thanhToan = "Hủy";
            } else
            {
                thanhToan = "Chưa thanh toán";
            }
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
            txtTongTien.Text = tongTien.ToString();
        }

        private void AddOneResOrderRow(ResOrderDto dto, out float oneTotal)
        {
            oneTotal = dto.Amount * dto.MenuPrice * (1 - dto.Discount);
            int index = dgvThucDon.Rows.Add();
            var r = dgvThucDon.Rows[index];
            r.Cells["MON_AN"].Value = dto.MenuName;
            r.Cells["SO_LUONG"].Value = dto.Amount;
            r.Cells["DON_VI"].Value = dto.UnitName;
            r.Cells["DON_GIA"].Value = dto.MenuPrice;
            r.Cells["CHIET_KHAU"].Value = dto.Discount;
            r.Cells["THANH_TIEN"].Value = oneTotal;
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
            return (long) selectedBill.Cells["billId"].Value;
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
            OnFillThucDon2Grid(null, null);
        }

        private bool IsValidInputData()
        {
            var billId = GetSelectedBillId();
            if (billId == -1)
            {
                MMessageBox.Show(this, "Bạn chưa thêm hóa đơn", "Thông báo"
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
            var dr = MMessageBox.Show(this, "Bạn có muốn in hóa đơn?", "Thông báo"
                                      , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
            if (DialogResult.No == dr)
            {
                return;
            }
            var billId = GetSelectedBillId();
            var billDto = _billingDao.getBillDto(billId);
            billDto.IsPrinted = "YES";
            _billingDao.ThanhToan(billDto);
            OnFillThucDon2Grid(null, null);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var dr = MMessageBox.Show(this, "Bạn có muốn thanh toán?", "Thông báo"
                                      , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
            if (DialogResult.No == dr)
            {
                return;
            }
            var billId = GetSelectedBillId();
            var billDto = _billingDao.getBillDto(billId);
            billDto.Payment = "YES";
            _billingDao.ThanhToan(billDto);
            OnFillThucDon2Grid(null, null);
        }
    }
}
