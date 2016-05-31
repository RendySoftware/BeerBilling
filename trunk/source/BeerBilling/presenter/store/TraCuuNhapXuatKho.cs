using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeerBilling.view;
using mcontrol;
using core_lib.common;
using domain_lib.dto;
using BeerBilling.util;

namespace BeerBilling.presenter.kho
{
    public partial class TraCuuNhapXuatKho : Form
    {
        private IStoreDAO _storeDao;

        public TraCuuNhapXuatKho()
        {
            InitializeComponent();

            _storeDao = new StoreDAOImpl();
        }

        private void AddOneRow(StoreDto dto)
        {
            int index = impexpDataGridView.Rows.Add();
            var r = impexpDataGridView.Rows[index];
            r.Cells["materialName"].Value = dto.MaterialName;
            r.Cells["amount"].Value = dto.Amount;
            r.Cells["unitName"].Value = dto.UnitName;
            r.Cells["storeBy"].Value = dto.StoredBy;
            r.Cells["storeStatus"].Value = dto.StoredStatus.Equals(ImportExportType.IMPORT.code) ? ImportExportType.IMPORT.name : ImportExportType.EXPORT.name;
            r.Cells["storeDate"].Value = DateUtil.GetDateTimeAsDdmmyyyy(dto.StoredDate);
            r.Cells["reason"].Value = dto.Reason;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFromDate.Text))
            {
                MMessageBox.Show(this, "Bạn chưa nhập Từ ngày", "Thông báo"
                   , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtFromDate.Focus();
                return;
            }

            var isImport = impCheckBox.Checked;
            var isExport = expCheckBox.Checked;

            if (!isImport && !isExport)
            {
                MMessageBox.Show(this, "Bạn phải chọn loại Xuất/Nhập kho", "Thông báo"
                   , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                impCheckBox.Focus();
                return;
            }

            var fromDate = DateUtil.GetDateTime(txtFromDate.Text);

            var toDate = String.IsNullOrEmpty(txtToDate.Text) ?
                DateUtil.GetCurrentDateTime() : DateUtil.GetDateTime(txtToDate.Text);



            List<StoreDto> listDto = _storeDao.GetStores(fromDate, toDate, isImport, isExport);

            impexpDataGridView.Rows.Clear();

            foreach (StoreDto dto in listDto)
            {
                AddOneRow(dto);
            }

        }
    }
}
