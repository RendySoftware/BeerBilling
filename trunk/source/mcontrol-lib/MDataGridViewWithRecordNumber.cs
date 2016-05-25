using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MDataGridViewWithRecordNumber : MDataGridView
    {
        public MDataGridViewWithRecordNumber()
        {
            InitializeComponent();

            SetDataGridViewDefaultStyle();
        }

        public MDataGridViewWithRecordNumber(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            SetDataGridViewDefaultStyle();
           
        }

        private void SetDataGridViewDefaultStyle()
        {
            this.TopLeftHeaderCell.Value = "Stt";
            this.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.RowHeadersDefaultCellStyle.Padding = new Padding(3);
            this.RowHeadersVisible = true;

            ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9);
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.BorderStyle = BorderStyle.None;
            this.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            this.MultiSelect = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
        }

        protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < RowCount; i++)
            {
                this.Rows[i].HeaderCell.Value = (i + 1).ToString();
                this.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;   
            }           

            base.OnRowsAdded(e);
        }
      
    }
}
