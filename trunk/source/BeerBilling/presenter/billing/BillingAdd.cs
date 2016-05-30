﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeerBilling.presenter.user;
using BeerBilling.view;
using domain_lib.dto;
using mcontrol;

namespace BeerBilling.presenter.billing
{
    public partial class BillingAdd : Form
    {
        private IDanhSachUser _danhSachUser = new DanhSachUserImpl();
        private BillingDAOImpl _billingDao = new BillingDAOImpl();

        private string _billNumber = String.Empty;

        public virtual string BillNumber
        {
            get { return _billNumber; }
            set { _billNumber = value; }
        }

        public BillingAdd()
        {
            InitializeComponent();

            var allResTableDtos = _billingDao.GetAllResTableDto();
            foreach (var dto in allResTableDtos)
            {
                cboBanSo.Items.Add(dto.Position);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!IsValidInputData())
            {
                return;
            }
            var dr = MMessageBox.Show(this, "Lưu hóa đơn?", "Thông báo"
                                      , MMessageBoxButtons.YesNo, MMessageBoxIcon.Warning);
            if (DialogResult.No == dr)
            {
                Dispose();
            }
            string tableNumber = cboBanSo.Text;
            string billingNumber = txtHoaDonSo.Text;
            _billNumber = tableNumber + "_" + billingNumber;
            var billDto = new BillDto();
            billDto.TableNumber = tableNumber;
            billDto.BillingNumber = int.Parse(billingNumber);
            billDto.CreatedBy = _danhSachUser.GetCurrentUserName();
            billDto.UpdatedBy = _danhSachUser.GetCurrentUserName();
            _billingDao.AddNewBill(billDto);
            Dispose();
        }

        private bool IsValidInputData()
        {
            if ("".Equals(txtHoaDonSo.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa nhập số hóa đơn", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                txtHoaDonSo.Focus();
                return false;
            }
            if ("".Equals(cboBanSo.Text.Trim()))
            {
                MMessageBox.Show(this, "Bạn chưa chọn số bàn", "Thông báo"
                    , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
                cboBanSo.Focus();
                return false;
            }
            return true;
        }
    }
}
