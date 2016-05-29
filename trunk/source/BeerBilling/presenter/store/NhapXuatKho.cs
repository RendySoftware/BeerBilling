using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeerBilling.util;
using BeerBilling.view;
using domain_lib.dto;
using mcontrol;
using core_lib.common;

namespace BeerBilling.presenter.kho
{
    public partial class NhapXuatKho : Form
    {
        private ImportExportType importExportType;
        private IStoreDAO _storeDao;
        private List<StoreDto> listStoreDto;

        public NhapXuatKho(ImportExportType type)
        {
            this.importExportType = type;
            InitializeComponent();
            
            _storeDao = new StoreDAOImpl();

            var allMaterialDtos = _storeDao.GetAllMaterial();
            foreach (var materialDto in allMaterialDtos) {
                materialComboBox.Items.Add(materialDto);
            }

            txtStoreDate.Text = DateUtil.GetDateTimeAsDdmmyyyy(DateTime.Now);
            listStoreDto = new List<StoreDto>();

            storeDataGridView.DataSource = listStoreDto; 

        }

        private void materialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnit.Text = ((MaterialDto)materialComboBox.SelectedItem).UnitName;
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            var materialDto = (MaterialDto)materialComboBox.SelectedItem;
            if (materialComboBox == null){
                MMessageBox.Show(this, "Bạn chưa chọn loại nguyên liệu", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                materialComboBox.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtAmount.Text))
            {
                MMessageBox.Show(this, "Bạn chưa nhập số lượng", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }

            StoreDto newStore = new StoreDto()
            {
                MaterialId = materialDto.Id,
                Amount = float.Parse(txtAmount.Text),
                StoredDate = DateUtil.GetDateTime(txtStoreDate.Text),
                StoredStatus = "NO",
                Reason = txtReason.Text,
                StoredBy = "SYSTEM",
 
            };
            listStoreDto.Add(newStore);
            
            storeDataGridView.AutoGenerateColumns = false;
            storeDataGridView.DataSource = listStoreDto; 
        }

      
    }
}
