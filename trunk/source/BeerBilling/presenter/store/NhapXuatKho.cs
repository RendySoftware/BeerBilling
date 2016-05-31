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
            this.storeType = type.name;
            InitializeComponent();
            
            _storeDao = new StoreDAOImpl();

            var allMaterialDtos = _storeDao.GetAllMaterial();
            foreach (var materialDto in allMaterialDtos) {
                materialComboBox.Items.Add(materialDto);
            }

            txtStoreDate.Text = DateUtil.GetDateTimeAsDdmmyyyy(DateTime.Now);
            listStoreDto = new List<StoreDto>();
        }

        private void materialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = materialComboBox.SelectedItem; 
            txtUnit.Text = item ==null ? "" : ((MaterialDto)item).UnitName;
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
                StoredStatus = importExportType.code,
                Reason = txtReason.Text,
                StoredBy = "SYSTEM",
                MaterialName = materialDto.Name,
                UnitName = txtUnit.Text
            };
            listStoreDto.Add(newStore);

            dgvStores.Rows.Clear();

            foreach (StoreDto material in listStoreDto)
            {
                AddOneRow(material);
            }

            txtAmount.Text = "";
            materialComboBox.Focus();
        }

        private void AddOneRow(StoreDto dto)
        {
            int index = dgvStores.Rows.Add();
            var r = dgvStores.Rows[index];
            r.Cells["materialId"].Value = dto.MaterialId;
            r.Cells["materialName"].Value = dto.MaterialName;
            r.Cells["unit"].Value = dto.UnitName;
            r.Cells["amount"].Value = dto.Amount;
            r.Cells["storeDate"].Value = DateUtil.GetDateTimeAsDdmmyyyy(dto.StoredDate);
            r.Cells["reason"].Value = dto.Reason;            
        }

        private void btnImpexpProcess_Click(object sender, EventArgs e)
        {
            _storeDao.AddList(listStoreDto);

            MMessageBox.Show(this, "Bạn đã " + importExportType.name.ToLower() +" thành công", "Thông báo"
                   , MMessageBoxButtons.OK, MMessageBoxIcon.Information);

            ResetForm();

            return;
        }

        private void ResetForm()
        {
            listStoreDto = new List<StoreDto>();
            dgvStores.Rows.Clear();
            txtAmount.Text = "";
            txtReason.Text = "";
            materialComboBox.SelectedItem = null;
            materialComboBox.Focus();
        }
      
    }
}
