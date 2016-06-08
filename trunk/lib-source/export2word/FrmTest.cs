using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using export2word.util;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;

namespace export2word
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }
        #region "Khong su dung"
        ///// <summary>

        ///// This Method create first paragraph 

        ///// </summary>

        //public void FirstPara()
        //{

        //    // create first paragraph with reference name

        //    Microsoft.Office.Interop.Word.Paragraph para1;

        //    // add paragraph with document

        //    para1 = doc.Content.Paragraphs.Add(ref objMiss);

        //    // create object of heading style

        //    object styleHeading1 = "Heading 1";

        //    //add heading style with paragraph

        //    para1.Range.set_Style(ref styleHeading1);

        //    // Write text of paragraph

        //    para1.Range.Text = "Hello Arun, How are You?";

        //    //set font style of paragraph

        //    para1.Range.Font.Bold = 1;

        //    // set space after write format of paragraph

        //    para1.Format.SpaceAfter = 24;

        //    // selection range of after insert paragraph

        //    para1.Range.InsertParagraphAfter();

        //}

        ///// <summary>

        ///// This Method Create Second Paragraph

        ///// </summary>

        //public void SecondPara()
        //{

        //    // create second paragaraph  with paragraph reference name para2

        //    Microsoft.Office.Interop.Word.Paragraph para2;



        //    // add second paragraph with documnet

        //    para2 = doc.Content.Paragraphs.Add(ref objMiss);

        //    // set paragraph heading style

        //    object styleHeading2 = "Heading 2";

        //    // add heading style with paragraph

        //    para2.Range.set_Style(ref styleHeading2);

        //    // second paragraph text 

        //    para2.Range.Text = "Hii This is Arun I am fine and you?";

        //    // set second paragraph font style

        //    para2.Range.Font.Bold = 1;

        //    // space or font size style like 24pt, 25pt etc.

        //    para2.Format.SpaceAfter = 24;

        //    // set selection range of paragraph

        //    para2.Range.InsertParagraphAfter();

        //}

        ///// <summary>

        ///// This Method create table in ms-word document

        ///// </summary>

        //public void CreateTable(int Row, int column)
        //{



        //    // create table in word documnet in word application with table reference name tbl1

        //    Table tbl1;

        //    // calculate the range of endofdocu

        //    Range wordRange = doc.Bookmarks.get_Item(ref endofdoc).Range;

        //    // add table with document with number of row and column

        //    tbl1 = doc.Content.Tables.Add(wordRange, 3, 3, ref objMiss, ref objMiss);

        //    // set border visibility true by input 1 and false by input 0

        //    tbl1.Borders.Enable = 1;

        //    // set text in each cell of table

        //    for (int r = 1; r <= 3; r++)
        //    {

        //        for (int c = 1; c <= 3; c++)
        //        {

        //            tbl1.Cell(r, c).Range.Text = "r" + r + "c" + c;

        //        }

        //    }

        //}

        #endregion

        DataTable _dataTable = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            // var DataAdapter = new SqlDataAdapter("select * from can_bo ",
            //                                     MySqlConnection.GetConnection());

            // DataAdapter.Fill(1, 100, _dataTable);
            mDataGridView1.DataSource = _dataTable;
            int index = 1;

            foreach (DataGridViewColumn col in mDataGridView1.Columns)
            {
                if (col.DisplayIndex >= 5) col.Visible = false;
            }
            foreach (DataGridViewRow row in mDataGridView1.Rows)
            {
                row.Cells["STT"].Value = index;
                index++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // path of template *.dot
            WordAppUtil.Template = Application.StartupPath + "/" + "test.dot";

            WordAppUtil.ThreadForWaitingExport();

            // tao wordApp tu template
            WordAppUtil.CreateMsWordFromTemplate();

            // thiet lap du lieu table nguon cho WordDoc Table
            WordAppUtil.SourceTable = _dataTable;

            WordAppUtil.ColumnNames = new List<string>() { "id", "ten", "chuc_vu", "phong_ban_id" };

            // fill du lieu vao WordDoc Table
            WordAppUtil.FillDataToWordDocTable2(1, false, true);

            // thiet lap cac parameter cho WordDoc
            WordAppUtil.SetParameterUsingBookmark("hinh_thuc_cung_cap", " Truc tiep");

            WordAppUtil.SetParameterUsingBookmark("hinh_thuc_cung_cap1", " Truc tiep1");

            WordAppUtil.SetParameterUsingBookmark("tu_ngay", "Từ ngày 12/06/2013 - đến ngày 12/07/2013");

            WordAppUtil.SetParameterUsingBookmark("ngay_in", "Hà nội, ngày 12 tháng 07 năm 2013");

            WordAppUtil.SetParameterUsingBookmark("nguoi_lap", "Chung Duy Nguyễn");

            string tempFile = Application.StartupPath+ "/test_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".doc";
            WordAppUtil.SaveAs(tempFile);

            WordAppUtil.QuitMsWordApp(false);

            WordAppUtil.OpenWordDocument(tempFile);

            WordAppUtil.ThreadForClosingExport();

        }       
    }
}
