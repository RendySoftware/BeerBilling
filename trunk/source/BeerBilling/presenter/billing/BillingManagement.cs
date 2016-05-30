using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using core_lib.common;
using domain_lib.dto;

namespace BeerBilling.presenter.billing
{
    public partial class BillingManagement : Form
    {
        private BillingDAOImpl _billingDao = new BillingDAOImpl();

        public BillingManagement()
        {
            InitializeComponent();

            var allBillDto = _billingDao.GetAllBill();
            FillBill2Grid(allBillDto);
        }

        private void FillBill2Grid(List<BillDto> allBillDto)
        {
            dgvBilling.Rows.Clear();
            foreach (var billDto in allBillDto)
            {
                AddOneBillRow(billDto);
            }
        }

        private void AddOneBillRow(BillDto dto)
        {
            int index = dgvBilling.Rows.Add();
            var r = dgvBilling.Rows[index];
            r.Cells["billNumber"].Value = dto.BillingNumber;
            r.Cells["billDate"].Value = dto.BillingDate;
            r.Cells["tableNumber"].Value = dto.TableNumber;
            r.Cells["totalBill"].Value = dto.Payment;
            r.Cells["billStatus"].Value = dto.IsPrinted;
            r.Cells["createdBy"].Value = dto.CreatedBy;
            r.Cells["createdDate"].Value = dto.CreatedDate;
            r.Cells["detail"].Value = dto.CancelReason;
            r.Cells["billId"].Value = dto.Id;
        }
    }
}
