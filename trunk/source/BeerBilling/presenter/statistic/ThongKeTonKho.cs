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
            txtToDate.Text =
                DateUtil.GetDateTimeAsDdmmyyyy(
                    ((DateTime)DateUtil.GetDateTime(txtFromDate.Text)).AddMonths(1).AddDays(-1));
            btnThucHien_Click(null, null);
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
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
    }
}
