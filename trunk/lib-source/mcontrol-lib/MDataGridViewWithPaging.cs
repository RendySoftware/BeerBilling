using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MDataGridViewWithPaging : UserControl
    {
        private List<object> list;

        public MDataGridViewWithPaging()
        {
            InitializeComponent();
        }

        public MDataGridViewWithPaging(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            _pageCount = 15;
        }

        public MDataGridViewWithRecordNumber DataGridViewWithRecordNumber { get; set; }

        public object DataSource
        {
            get { return list; }
            set { list = (List<object>)value; }
        }

        private int _pageCount;

        public int PageCount
        {
            get { return _pageCount; }
            set { _pageCount = value; }
        }

        public int ListCount
        {
            get
            {
                if (list != null)
                    return list.Count;
                else
                {
                    return 0;
                }
            }
        }


        public String MGroupBoxText
        {
            get
            {
                return mGroupBox1.Text.Trim();

            }
            set { mGroupBox1.Text = value; }
        }

        public int TotalPage
        {
            get
            {
                if (PageCount > 0)
                    return ListCount % PageCount == 0 ? ListCount / PageCount : ListCount / PageCount + 1;
                else
                    return ListCount;
            }
        }


        //public void AddColumns(String[] columns)
        //{
        //    foreach (string column in columns)
        //    {
        //        int indexColumn = mDataGridViewWithRecordNumber1.Columns.Add(column, column);
        //        mDataGridViewWithRecordNumber1.Columns[indexColumn].DataPropertyName = column;
        //    }
        //}

        public void InitPaging()
        {
            txtSoBanGhi.Text = ListCount.ToString();

            cbPhanTrang.Items.Clear();

            for (int i = 1; i <= TotalPage; i++)
            {
                cbPhanTrang.Items.Add(i);
            }
            if (list != null && list.Count > 0)
            {
                if (list.Count > PageCount)
                {
                    subList = list.GetRange(0, PageCount);
                    btnNext.Enabled = true;
                }
                else
                {
                    subList = list.GetRange(0, list.Count);
                }

                var source = new BindingSource();
                source.DataSource = subList;
                DataGridViewWithRecordNumber.DataSource = source;
                DataGridViewWithRecordNumber.Refresh();
                cbPhanTrang.Text = "1";
                cbPhanTrang.Invalidate();
            }
        }

        private List<object> subList;

        private int currentPage;

        private void cbPhanTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhanTrang.SelectedIndex != -1)
            {
                currentPage = Int32.Parse(cbPhanTrang.Text.Trim());
                DisplayData();
                SetEnableButton();
            }
        }

        private void SetEnableButton()
        {
            if (TotalPage == 1 || TotalPage == 0)
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnFirst.Enabled = false;
            }
            else
            {
                if (currentPage == 1)
                {
                    btnPrevious.Enabled = false;
                    btnFirst.Enabled = false;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
                else if (currentPage == TotalPage)
                {
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
                else
                {
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnFirst.Enabled = true;
                }
            }

        }

        private void DisplayData()
        {
            int startIndex = (currentPage - 1) * PageCount;

            if (TotalPage > currentPage)
                subList = list.GetRange(startIndex, PageCount);
            else
            {
                if (ListCount % PageCount == 0)
                    subList = list.GetRange(startIndex, PageCount);
                else
                    subList = list.GetRange(startIndex, ListCount % PageCount);
            }

            var source = new BindingSource();
            source.DataSource = subList;
            DataGridViewWithRecordNumber.DataSource = subList;
            DataGridViewWithRecordNumber.Refresh();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayData();
                SetEnableButton();
                cbPhanTrang.Text = currentPage.ToString();
                cbPhanTrang.Invalidate();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < TotalPage)
            {
                currentPage++;
                DisplayData();
                SetEnableButton();
                cbPhanTrang.Text = currentPage.ToString();
                cbPhanTrang.Invalidate();
            }            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            DisplayData();
            SetEnableButton();
            cbPhanTrang.Text = currentPage.ToString();
            cbPhanTrang.Invalidate();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = TotalPage;
            DisplayData();
            SetEnableButton();
            cbPhanTrang.Text = currentPage.ToString();
            cbPhanTrang.Invalidate();
        }

        private void cbPhanTrang_DrawItem(object sender, DrawItemEventArgs e)
        {
            MComboBox comboBox = (MComboBox) sender;
            // Draw background
            e.DrawBackground();

            // Get text
            string text = string.Empty;
            if (e.Index >= 0)
                text = comboBox.Items[e.Index].ToString();       

            // Draw text
            TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds, e.ForeColor, TextFormatFlags.HorizontalCenter);

            // Draw focus rectangle
            e.DrawFocusRectangle();
        }
    }
}
