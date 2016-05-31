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

namespace BeerBilling.presenter.menu
{
    public partial class MenuManagement : Form
    {
        private IBillingDAO _billingDao = new BillingDAOImpl();

        public MenuManagement()
        {
            InitializeComponent();
            FillData2CategoryGrid();
        }

        private void FillData2CategoryGrid()
        {
            var allCategoryDto = _billingDao.GetAllCategory();
            dgvCategory.Rows.Clear();
            foreach (var dto in allCategoryDto)
            {
                AddOneCategoryRow(dto);
            }
            dgvCategory_SelectionChanged(null, null);
        }

        private void AddOneCategoryRow(DanhMucDto dto)
        {
            int index = dgvCategory.Rows.Add();
            var r = dgvCategory.Rows[index];
            r.Cells["code"].Value = dto.Ma;
            r.Cells["name"].Value = dto.Ten;
            r.Cells["edit"].Value = "Sửa";
            r.Cells["categoryId"].Value = dto.Id;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            var categoryId = GetSelectedCategoryId();
            if (categoryId == -1)
            {
                return;
            }
            var allMenuDto = _billingDao.GetAllMenuBy(categoryId);
            dgvMenu.Rows.Clear();
            foreach (var dto in allMenuDto)
            {
                AddOneMenuRow(dto);
            }
        }

        private void AddOneMenuRow(MenuDto dto)
        {
            int index = dgvMenu.Rows.Add();
            var r = dgvMenu.Rows[index];
            r.Cells["menuCode"].Value = dto.Code;
            r.Cells["menuName"].Value = dto.Name;
            r.Cells["unit"].Value = dto.UnitId;
            r.Cells["price"].Value = dto.Price;
            r.Cells["description"].Value = dto.Description;
            r.Cells["editMenu"].Value = "Sửa";
            r.Cells["menuId"].Value = dto.Id;
        }

        private long GetSelectedCategoryId()
        {
            int selectedIndex = dgvCategory.CurrentRow == null ? 0 : dgvCategory.CurrentRow.Index;
            if (selectedIndex > dgvCategory.RowCount - 1)
                selectedIndex = dgvCategory.RowCount - 1;
            if (selectedIndex == -1)
            {
                return -1;
            }
            var selectedBill = dgvCategory.Rows[selectedIndex];
            var categoryId = selectedBill.Cells["categoryId"].Value;
            return categoryId == null ? -1 : Convert.ToInt64(categoryId);
        }
    }
}
