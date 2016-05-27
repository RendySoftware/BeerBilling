using System;
using System.Windows.Forms;

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
    }
}
