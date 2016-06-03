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

namespace BeerBilling.presenter.menu
{
    public partial class CategoryProcessing : Form
    {
        private IBillingDAO _billingDao = new BillingDAOImpl();

        private long _categoryId = -1;
        private bool _isChange = false;

        public CategoryProcessing(long categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
            if (categoryId != -1)
            {
                var categoryDto = _billingDao.getCategoryDto(categoryId);
                txtMaNhom.Text = categoryDto.Ma;
                txtTenNhom.Text = categoryDto.Ten;
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
            var dr = MMessageBox.Show(this, "Lưu nhóm thực đơn?", "Thông báo"
                                      , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
            if (DialogResult.No == dr)
            {
                Dispose();
                return;
            }
            var maNhom = txtMaNhom.Text.Trim();
            var tenNhom = txtTenNhom.Text.Trim();
            var dto = new DanhMucDto()
                          {
                              Id = Convert.ToString(_categoryId),
                              Ma = maNhom,
                              Ten = tenNhom
                          };
            _billingDao.SaveCategory(dto);
            _isChange = true;
            Dispose();
        }

        private bool IsValidInputData()
        {
            string maNhom = txtMaNhom.Text.Trim();
            if ("".Equals(maNhom))
            {
                MMessageBox.Show(this, "Bạn chưa nhập mã nhóm", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMaNhom.Focus();
                return false;
            }
            if (_billingDao.IsExistCategoryCode(maNhom, _categoryId))
            {
                MMessageBox.Show(this, "Mã nhóm đã tồn tại, vui lòng nhập lại", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtMaNhom.Focus();
                return false;
            }
            if ("".Equals(txtTenNhom.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa nhập tên nhóm", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtTenNhom.Focus();
                return false;
            }
            return true;
        }
    }
}
