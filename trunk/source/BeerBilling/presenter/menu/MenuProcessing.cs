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
using mcontrol;
using mcontrol.util;

namespace BeerBilling.presenter.menu
{
    public partial class MenuProcessing : Form
    {
        private IBillingDAO _billingDao = new BillingDAOImpl();

        private long _categoryId = -1;
        private long _menuId = -1;
        private bool _isChange = false;

        public MenuProcessing(long categoryId, long menuId)
        {
            InitializeComponent();
            var allUnitDto = _billingDao.GetAllUnit();
            MControlUtil.FillToComboBox(cboUnit, allUnitDto);

            _categoryId = categoryId;
            _menuId = menuId;
            if (categoryId != -1)
            {
                var categoryDto = _billingDao.getCategoryDto(categoryId);
                txtCategory.Text = categoryDto.Ten;
                txtMenuCode.Text = categoryDto.Id;
            }
            if (menuId != -1)
            {
                var menuDto = _billingDao.getMenuDto(menuId);
                txtMenuCode.Text = menuDto.Code;
                txtMenuName.Text = menuDto.Name;
                cboUnit.Text = menuDto.UnitName;
                txtPrice.Text = Convert.ToString(menuDto.Price);
                txtDescription.Text = menuDto.Description;
            }
        }

        public virtual bool IsChange
        {
            get { return _isChange; }
            set { _isChange = value; }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!IsValidInputData())
            {
                return;
            }
            var dr = MMessageBox.Show(this, "Lưu thực đơn?", "Thông báo"
                                      , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
            if (DialogResult.No == dr)
            {
                Dispose();
                return;
            }
            var menuCode = txtMenuCode.Text.Trim();
            var menuName = txtMenuName.Text.Trim();
            var unitId = MControlUtil.GetValueFromCombobox(cboUnit);
            var price = txtPrice.Text.Trim();
            var description = txtDescription.Text.Trim();
            var dto = new MenuDto()
                          {
                              Id = _menuId,
                              Code = menuCode,
                              Name = menuName,
                              CategoryId = _categoryId,
                              UnitId = long.Parse(unitId),
                              Price = float.Parse(price),
                              Description = description
                          };
            _billingDao.SaveMenu(dto);
            _isChange = true;
            Dispose();
        }

        private bool IsValidInputData()
        {
            if ("".Equals(txtCategory.Text.Trim()))
            {
                MMessageBox.Show(this, "Nhóm thực đơn không tồn tại", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtCategory.Focus();
                return false;
            }
            string menuCode = txtMenuCode.Text.Trim();
            if ("".Equals(menuCode))
            {
                MMessageBox.Show(this, "Bạn chưa nhập mã thực đơn", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMenuCode.Focus();
                return false;
            }
            if ("".Equals(txtMenuName.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa nhập tên thực đơn", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMenuName.Focus();
                return false;
            }
            var unitId = MControlUtil.GetValueFromCombobox(cboUnit);
            if ("".Equals(unitId))
            {
                MMessageBox.Show(this, "Bạn chưa chọn đơn vị", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                cboUnit.Focus();
                return false;
            }
            if ("".Equals(txtPrice.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa nhập giá", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }
            return true;
        }
    }
}
