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
    public partial class ThongKeTonKho : Form
    {
        private IStoreDAO _storeDao;

        public ThongKeTonKho()
        {
            InitializeComponent();
            _storeDao = new StoreDAOImpl();
            var currentDate = DateUtil.GetCurrentDateTime();
            var currentMonth = DateUtil.GetDateTimeAsDdmmyyyy(currentDate).Substring(3);
            txtFromDate.Text = "01/" + currentMonth;
            txtToDate.Text = DateUtil.GetDateTimeAsDdmmyyyy(currentDate);
            btnThucHien_Click(null, null);
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!IsValidInputData())
            {
                return;
            }
            var fromDate = txtFromDate.Text.Trim();
            var toDate = txtToDate.Text.Trim();

            List<StatisticStoreDto> listDto = _storeDao.GetStatisticStores(fromDate, toDate);
            var selectedIndex = GetSelectedStoreIndex();
            if (selectedIndex > listDto.Count - 1)
            {
                selectedIndex = listDto.Count - 1;
            }

            inventoryDataGridView.Rows.Clear();

            foreach (StatisticStoreDto dto in listDto)
            {
                AddOneRow(dto);
            }
            MControlUtil.SetSelectedIndex(inventoryDataGridView, selectedIndex, "material");
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

        private int GetSelectedStoreIndex()
        {
            int selectedIndex = inventoryDataGridView.CurrentRow == null ? 0 : inventoryDataGridView.CurrentRow.Index;
            if (selectedIndex > inventoryDataGridView.RowCount - 1)
                selectedIndex = inventoryDataGridView.RowCount - 1;
            return selectedIndex;
        }

        private void AddOneRow(StatisticStoreDto dto)
        {
            int index = inventoryDataGridView.Rows.Add();
            var r = inventoryDataGridView.Rows[index];
            r.Cells["material"].Value = dto.MaterialName;
            r.Cells["unit"].Value = dto.UnitName;
            r.Cells["previousInventory"].Value = dto.PreviousInventory;
            r.Cells["impAmount"].Value = dto.ImpAmount;
            r.Cells["expAmount"].Value = dto.ExpAmount;
            r.Cells["inventory"].Value = dto.Inventory;
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
