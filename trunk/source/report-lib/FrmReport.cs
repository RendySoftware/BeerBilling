using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace reportutil
{
    public partial class FrmReport : Form
    {
        private bool _showExportButton;
        public FrmReport()
        {
            InitializeComponent();
            _showExportButton = false;
        }
        public FrmReport(ReportDocument report, bool showExportButton)
        {
            InitializeComponent();
            reportView.ReportSource = report;
            _showExportButton = showExportButton;
        }
        private void FrmReport_Load(object sender, EventArgs e)
        {
            if (!_showExportButton)
            {
                reportView.ShowExportButton = false;
                reportView.ToolPanelView = ToolPanelViewType.None;
                reportView.ShowGroupTreeButton = false;
                reportView.ShowParameterPanelButton = false;
                reportView.EnableRefresh = false;
                reportView.ShowCopyButton = false;
            }
            //this.reportView.RefreshReport();
        }
    }
}
