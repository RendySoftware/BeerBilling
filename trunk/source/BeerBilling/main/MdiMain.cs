using System;
using System.Windows.Forms;
using BeerBilling.presenter.kho;
using BeerBilling.presenter.billing;
using BeerBilling.presenter.menu;
using BeerBilling.presenter.statistic;
using BeerBilling.presenter.user;

namespace BeerBilling.main
{
    public partial class MdiMain : Form
    {
        public MdiMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            toolStripStatusLabel1.Text = " |<Thời gian: "
                                        + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ">|";
        }

        private void MdiMain_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void nhapKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapXuatKho nhapKhoFrm = new NhapXuatKho();
            nhapKhoFrm.MdiParent = this;
            nhapKhoFrm.Show();
        }

        private void nhậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillingProcessing billingProcessingFrm = new BillingProcessing();
            billingProcessingFrm.MdiParent = this;
            billingProcessingFrm.Show();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapXuatKho nhapKhoFrm = new NhapXuatKho();
            nhapKhoFrm.MdiParent = this;
            nhapKhoFrm.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillingManagement billingManagementFrm = new BillingManagement();
            billingManagementFrm.MdiParent = this;
            billingManagementFrm.Show();
        }

        private void quảnLýThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuManagement menuManagementFrm = new MenuManagement();
            menuManagementFrm.MdiParent = this;
            menuManagementFrm.Show();
        }

        private void thốngKêTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeTonKho thongKeTonKhoFrm = new ThongKeTonKho();
            thongKeTonKhoFrm.MdiParent = this;
            thongKeTonKhoFrm.Show();
        }

        private void thốngKêBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDoanhSoBanHang thongKeDoanhSoBanHangFrm = new ThongKeDoanhSoBanHang();
            thongKeDoanhSoBanHangFrm.MdiParent = this;
            thongKeDoanhSoBanHangFrm.Show();
        }
    }
}
