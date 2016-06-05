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

namespace BeerBilling.presenter.statistic
{
    public partial class ThongKeDoanhSoBanHang : Form
    {
        private IBillingDAO _billingDao = new BillingDAOImpl();
        public ThongKeDoanhSoBanHang()
        {
            InitializeComponent();
            InitThangComboBox();
            InitQuyComboBox();
            InitNamComboBox();
            var currentDate = DateUtil.GetCurrentDateTime();
            var currentMonth = DateUtil.GetDateTimeAsDdmmyyyy(currentDate).Substring(3);
            txtFromDate.Text = "01/" + currentMonth;
            txtToDate.Text = DateUtil.GetDateTimeAsDdmmyyyy(currentDate);
            btnThucHien_Click(null, null);
        }

        private void InitNamComboBox()
        {
            var currentYear = DateUtil.GetNamHienTai();
            var allDto = new List<DanhMucDto>();
            for (int i = 0; i <= 10; i++)
            {
                var value = int.Parse(currentYear) - i;
                allDto.Add(new DanhMucDto()
                               {
                                   Id = Convert.ToString(value),
                                   Ten = Convert.ToString(value)
                               });
            }
            MControlUtil.FillToComboBox(namComboBox, allDto);
            namComboBox.Text = currentYear;
        }

        private void InitQuyComboBox()
        {
            var currentYear = DateUtil.GetNamHienTai();
            var currentQuater = DateUtil.GetQuyHienTai();
            var allDto = new List<DanhMucDto>();
            for (int i = currentQuater; i > 0; i--)
            {
                var value = i + "/" + currentYear;
                allDto.Add(new DanhMucDto()
                {
                    Id = Convert.ToString(value),
                    Ten = Convert.ToString(value)
                });
            }
            var previousYear = int.Parse(currentYear) - 1;
            for (int i = 4; i > 0; i--)
            {
                var value = i + "/" + previousYear;
                allDto.Add(new DanhMucDto()
                {
                    Id = Convert.ToString(value),
                    Ten = Convert.ToString(value)
                });
            }
            MControlUtil.FillToComboBox(quyComboBox, allDto);
            quyComboBox.Text = currentQuater+"/"+currentYear;
        }

        private void InitThangComboBox()
        {
            var currentDate = DateUtil.GetCurrentDateTime();
            var allDto = new List<DanhMucDto>();
            for (int i = 0; i <= 12; i++)
            {
                var value = DateUtil.GetDateTimeAsDdmmyyyy(currentDate.AddMonths(-i)).Substring(3);
                allDto.Add(new DanhMucDto()
                {
                    Id = value,
                    Ten = value
                });
            }
            MControlUtil.FillToComboBox(thangComboBox, allDto);
            var currentMonth = DateUtil.GetDateTimeAsDdmmyyyy(currentDate).Substring(3);
            thangComboBox.Text = currentMonth;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!IsValidInputData())
            {
                return;
            }
            var searchDto = CreateSearchDto();
            var allResOrderDto = _billingDao.GetAllResOrderDto(searchDto);

            var selectedIndex = GetSelectedSellIndex();
            if (selectedIndex > allResOrderDto.Count - 1)
            {
                selectedIndex = allResOrderDto.Count - 1;
            }
            sellDataGridView.Rows.Clear();
            float tongSo = 0;
            foreach (var dto in allResOrderDto)
            {
                AddOneSellRow(dto);
                tongSo += dto.Total;
            }
            txtTongSo.Text = tongSo.ToString("#,###,###") + " VNĐ";
            MControlUtil.SetSelectedIndex(sellDataGridView, selectedIndex, "menu");
        }

        private bool IsValidInputData()
        {
            if (String.IsNullOrEmpty(txtFromDate.Text))
            {
                MMessageBox.Show(this, "Bạn chưa nhập Từ ngày", "Thông báo"
                   , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtFromDate.Focus();
                return false;
            }
            return true;
        }

        private int GetSelectedSellIndex()
        {
            int selectedIndex = sellDataGridView.CurrentRow == null ? 0 : sellDataGridView.CurrentRow.Index;
            if (selectedIndex > sellDataGridView.RowCount - 1)
                selectedIndex = sellDataGridView.RowCount - 1;
            return selectedIndex;
        }

        private void AddOneSellRow(ResOrderDto dto)
        {
            int index = sellDataGridView.Rows.Add();
            var r = sellDataGridView.Rows[index];
            r.Cells["menu"].Value = dto.MenuName;
            r.Cells["unit"].Value = dto.UnitName;
            r.Cells["amount"].Value = dto.Amount;
            r.Cells["total"].Value = dto.Total.ToString("#,###,###");
        }

        private StatisticMenuSearchDto CreateSearchDto()
        {
            var dto = new StatisticMenuSearchDto();
            if (ngayRadioButton.Checked)
            {
                dto.FromDate = txtFromDate.Text.Trim();
                dto.ToDate = txtToDate.Text.Trim();
            }
            if (thangRadioButton.Checked)
            {
                dto.Thang = thangComboBox.Text.Trim();
            }
            if (quyRadioButton.Checked)
            {
                dto.Quy = quyComboBox.Text.Trim();
            }
            if (namRadioButton.Checked)
            {
                dto.Nam = namComboBox.Text.Trim();
            }
            return dto;
        }

        private void ngayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ngayRadioButton.Checked)
            {
                txtFromDate.Enabled = true;
                txtToDate.Enabled = true;
                thangComboBox.Enabled = false;
                quyComboBox.Enabled = false;
                namComboBox.Enabled = false;
                btnThucHien_Click(null, null);
            }
        }

        private void thangRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (thangRadioButton.Checked)
            {
                txtFromDate.Enabled = false;
                txtToDate.Enabled = false;
                thangComboBox.Enabled = true;
                quyComboBox.Enabled = false;
                namComboBox.Enabled = false;
                btnThucHien_Click(null, null);
            }
        }

        private void quyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (quyRadioButton.Checked)
            {
                txtFromDate.Enabled = false;
                txtToDate.Enabled = false;
                thangComboBox.Enabled = false;
                quyComboBox.Enabled = true;
                namComboBox.Enabled = false;
                btnThucHien_Click(null, null);
            }
        }

        private void namRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (namRadioButton.Checked)
            {
                txtFromDate.Enabled = false;
                txtToDate.Enabled = false;
                thangComboBox.Enabled = false;
                quyComboBox.Enabled = false;
                namComboBox.Enabled = true;
                btnThucHien_Click(null, null);
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
