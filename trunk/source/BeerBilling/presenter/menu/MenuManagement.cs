using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeerBilling.presenter.billing;
using BeerBilling.view;
using domain_lib.dto;
using mcontrol.util;

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
            var selectedIndex = GetSelectedCategoryIndex();
            if (selectedIndex > allCategoryDto.Count - 1)
            {
                selectedIndex = allCategoryDto.Count - 1;
            }
            dgvCategory.Rows.Clear();
            foreach (var dto in allCategoryDto)
            {
                AddOneCategoryRow(dto);
            }
            MControlUtil.SetSelectedIndex(dgvCategory, selectedIndex, "code");
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
            var frm = new CategoryProcessing(-1);
            frm.ShowDialog(this);
            if (frm.IsChange)
            {
                FillData2CategoryGrid();
            }
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            var categoryId = GetSelectedCategoryId();
            var frm = new MenuProcessing(categoryId, -1);
            frm.ShowDialog(this);
            if (frm.IsChange)
            {
                dgvCategory_SelectionChanged(null, null);
            }
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            var categoryId = GetSelectedCategoryId();
            if (categoryId == -1)
            {
                return;
            }
            var allMenuDto = _billingDao.GetAllMenuBy(categoryId);
            var selectedIndex = GetSelectedMenuIndex();
            if (selectedIndex > allMenuDto.Count - 1)
            {
                selectedIndex = allMenuDto.Count - 1;
            }
            dgvMenu.Rows.Clear();
            foreach (var dto in allMenuDto)
            {
                AddOneMenuRow(dto);
            }
            MControlUtil.SetSelectedIndex(dgvMenu, selectedIndex, "menuCode");
        }

        private void AddOneMenuRow(MenuDto dto)
        {
            int index = dgvMenu.Rows.Add();
            var r = dgvMenu.Rows[index];
            r.Cells["menuCode"].Value = dto.Code;
            r.Cells["menuName"].Value = dto.Name;
            r.Cells["unit"].Value = dto.UnitName;
            r.Cells["price"].Value = dto.Price.ToString("#,###,###") + " VNĐ";
            r.Cells["description"].Value = dto.Description;
            r.Cells["editMenu"].Value = "Sửa";
            r.Cells["menuId"].Value = dto.Id;
        }

        private long GetSelectedCategoryId()
        {
            int selectedIndex = GetSelectedCategoryIndex();
            if (selectedIndex == -1)
            {
                return -1;
            }
            var selectedCategory = dgvCategory.Rows[selectedIndex];
            var categoryId = selectedCategory.Cells["categoryId"].Value;
            return categoryId == null ? -1 : Convert.ToInt64(categoryId);
        }

        private int GetSelectedCategoryIndex()
        {
            int selectedIndex = dgvCategory.CurrentRow == null ? 0 : dgvCategory.CurrentRow.Index;
            if (selectedIndex > dgvCategory.RowCount - 1)
                selectedIndex = dgvCategory.RowCount - 1;
            return selectedIndex;
        }

        private long GetSelectedMenuId()
        {
            int selectedIndex = GetSelectedMenuIndex();
            if (selectedIndex == -1)
            {
                return -1;
            }
            var selectedMenu = dgvMenu.Rows[selectedIndex];
            var menuId = selectedMenu.Cells["menuId"].Value;
            return menuId == null ? -1 : Convert.ToInt64(menuId);
        }

        private int GetSelectedMenuIndex()
        {
            int selectedIndex = dgvMenu.CurrentRow == null ? 0 : dgvMenu.CurrentRow.Index;
            if (selectedIndex > dgvMenu.RowCount - 1)
                selectedIndex = dgvMenu.RowCount - 1;
            return selectedIndex;
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategory.Columns[e.ColumnIndex].Name == "edit")
            {
                var categoryId = GetSelectedCategoryId();
                var form = new CategoryProcessing(categoryId);
                form.ShowDialog(this);
                if (form.IsChange)
                {
                    FillData2CategoryGrid();
                }
            }
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMenu.Columns[e.ColumnIndex].Name == "editMenu")
            {
                var categoryId = GetSelectedCategoryId();
                var menuId = GetSelectedMenuId();
                var form = new MenuProcessing(categoryId, menuId);
                form.ShowDialog(this);
                if (form.IsChange)
                {
                    dgvCategory_SelectionChanged(null, null);
                }
            }
        }
    }
}
