using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using mcontrol;
using mcontrol.NotificationForm;
using Word;
using DataTable = System.Data.DataTable;
using System.Collections.Generic;

namespace export2word.util
{
    public class WordAppUtil
    {
        // create MS-Word application 

        static Word.Application _msWord = new Word.Application();
        // create Word document reference
        static Document _doc;

        static object _objMiss = System.Reflection.Missing.Value;

        // Create end of document object

        object _endofdoc = "\\endofdoc";

        public static object Template
        {
            get { return _template; }

            set { _template = value; }
        }

        private static object _template = null;

        /// <summary>

        ///This method creates ms-word.

        /// </summary>
        public static void CreateMsWord()
        {
            try
            {
                // add blank documnet in word application

                _doc = _msWord.Documents.Add(ref _objMiss, ref _objMiss, ref _objMiss, ref _objMiss);

                _doc.Activate();
            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }
        /// <summary>

        ///This method creates ms-word from template.

        /// </summary>
        public static void CreateMsWordFromTemplate()
        {
            try
            {
                if (_msWord == null)
                    _msWord = new Word.Application();
                // add blank documnet in word application

                if (_template == null) return;

                _doc = _msWord.Documents.Open(ref _template, ref _objMiss, ref _objMiss, ref _objMiss, ref _objMiss);

                _doc.Activate();
            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }
        /// <summary>
        /// Thiet lap DataSource cho cac Table trong WordDoc
        /// </summary>
        public static DataTable SourceTable { get; set; }

        /// <summary>
        /// Ham nay dung de fill du lieu den Table trong WordDoc        
        /// </summary>
        /// <param name="index">chi so cua Table, duoc danh theo so thu tu, bat dau tu 1 </param>
        public static void FillDataToWordDocTable(int index)
        {
            if (_doc == null) return;
            if (_doc.Tables.Count == 0) return;

            if (index < 1) throw new ArgumentException("Index phai >=1");

            try
            {
                Table tbl1 = _doc.Content.Tables.Item(index);
                int rowIndex = 1;
                foreach (DataRow sRow in SourceTable.Rows)
                {
                    Row row = tbl1.Rows.Add(ref _objMiss);
                    row.Cells.Item(1).Range.Text = rowIndex.ToString();
                    rowIndex++;
                    row.Cells.Item(1).WordWrap = false;
                    row.Cells.Item(1).Range.Bold = 0;
                    for (int i = 0; i < SourceTable.Columns.Count; i++)
                    {
                        row.Cells.Item(i + 2).Range.Text = Convert.ToString(sRow[i]);
                        row.Cells.Item(i + 2).WordWrap = false;
                        row.Cells.Item(i + 2).Range.Bold = 0;
                    }
                }
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        public static void FillDataToWordDocTableWithoutStt(int index, bool isBold, bool isItalic, bool isUnderline, bool includeSumRow, bool isFirstTime)
        {
            FillDataToWordDocTableWithoutStt2(index, isBold, isItalic, isUnderline, false, includeSumRow, isFirstTime);
        }

        public static void FillDataToWordDocTableWithoutStt2(int index, bool isBold, bool isItalic, bool isUnderline, bool includeHeader, bool includeSumRow, bool isFirstTime)
        {
            if (_doc == null) return;
            if (_doc.Tables.Count == 0) return;

            if (index < 1) throw new ArgumentException("Index phai >=1");

            try
            {
                Table tbl1 = _doc.Content.Tables.Item(index);
                var lastRowIndex = includeSumRow ? tbl1.Rows.Count-1 : tbl1.Rows.Count;
                if (lastRowIndex == 0)
                    lastRowIndex = 1;
                int prev = lastRowIndex;
                if (isFirstTime)
                {
                    if (SourceTable.Rows.Count > 1)
                        AddRowsBelow(index, prev, SourceTable.Rows.Count -1);
                }
                else
                {
                    AddRowsBelow(index, prev, SourceTable.Rows.Count);
                    prev++;
                }
                foreach (DataRow sRow in SourceTable.Rows)
                {
                    Row row = tbl1.Rows.Item(prev);
                    SetAllValueForTableRowWithStyle(row, AllValues2(sRow, ColumnNames), isBold, isItalic, isUnderline);
                    prev++;
                }
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        private static int Compare2Cell(Point one, Point other)
        {
            if (one.X > other.X || (one.X == other.X && one.Y > other.Y))
                return -1;
            if (one.X < other.X || (one.X == other.X && one.Y < other.Y))
                return 1;
            return 0;
        }

        public static void DoMergeCell(int index, Hashtable mapMergeCell)
        {
            if (_doc == null) return;
            if (_doc.Tables.Count == 0) return;

            if (index < 1) throw new ArgumentException("Index phai >=1");

            try
            {
                Table tbl1 = _doc.Content.Tables.Item(index);
                List<Point> keys = new List<Point>();
                foreach (Point key in mapMergeCell.Keys)
                {
                    keys.Add(key);
                }
                keys.Sort(Compare2Cell);
                foreach (Point one in keys)
                {
                    List<Point> listPoint = new List<Point>((List<Point>)mapMergeCell[one]);
                    listPoint.Add(one);
                    listPoint.Sort(Compare2Cell);
                    for (int i = 0; i < listPoint.Count; i++)
                    {
                        if (i < listPoint.Count-1)
                        {
                            var startPoint = listPoint[i];
                            var nextPoint = listPoint[i + 1];
                            Cell startCell = tbl1.Cell(startPoint.X, startPoint.Y);
                            Cell nextCell = tbl1.Cell(nextPoint.X, nextPoint.Y);
                            Merge2Cell(startCell, nextCell);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        public static List<string> ColumnNames { set; get; }

        private static void SetSoThuTu(Table tbl1, int startIndex, int rowIndex)
        {
            var cell = tbl1.Cell(rowIndex, 1);
            cell.Range.Text = (rowIndex - (startIndex-1)).ToString();
            SetStyleForCell(cell);
        }

        public static void FillDataToWordDocTable2(int index, bool includeSumRow, bool isFirstTime)
        {
            if (_doc == null) return;
            if (_doc.Tables.Count == 0) return;

            if (index < 1) throw new ArgumentException("Index phai >=1");

            try
            {
                Table tbl1 = _doc.Content.Tables.Item(index);
                var lastRowIndex = includeSumRow ? tbl1.Rows.Count - 1 : tbl1.Rows.Count;
                if (lastRowIndex == 0)
                    lastRowIndex = 1;
                int prev = lastRowIndex;
                if (isFirstTime)
                {
                    if (SourceTable.Rows.Count > 1)
                        AddRowsBelow(index, prev, SourceTable.Rows.Count - 1);
                }
                else
                {
                    AddRowsBelow(index, prev, SourceTable.Rows.Count);
                    prev++;
                }
                int startIndex = prev;
                foreach (DataRow sRow in SourceTable.Rows)
                {
//                    Row row = tbl1.Rows.Item(prev);
                    SetAllValueForTableRow(tbl1, prev, AllValues(sRow, ColumnNames));
                    SetSoThuTu(tbl1, startIndex, prev);
                    prev++;
                }
            }
            catch (Exception exception)
            {
                //MMessageBox.Show(null, exception.Message);
                ShowMessage.Show(MessageIcon.Error, "Lỗi: " + exception.Message);
            }
        }

        public static void SetStyleForCell(Cell cell, bool isBold, bool isItalic, bool isUnderline)
        {
            try
            {
                //row.Range.set_Style(ref style);
                cell.Range.Font.Bold = isBold ? 1 : 0;
                cell.Range.Font.Underline = isUnderline ? WdUnderline.wdUnderlineSingle : WdUnderline.wdUnderlineNone;
                cell.WordWrap = false;
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        public static void SetStyleForCell(Cell cell)
        {
            try
            {
//                cell.Range.Font.Bold = 0;
                cell.WordWrap = false;
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        public static void SetStyleForCell(Cell cell, object style)
        {
            try
            {
                cell.Range.set_Style(style);
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        public static void Merge2Cell(Cell MergeFrom, Cell MergeTo)
        {
            try
            {
                MergeFrom.Merge(MergeTo);

            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        public static void AddRowBefore(ref Table tbl, int rowIndex)
        {
            try
            {
                if (rowIndex < 1) return;
                if (rowIndex > tbl.Rows.Count) throw new ArgumentException("Index is out of RowCount");
                object beforeRow = tbl.Rows.Item(rowIndex);
                tbl.Rows.Add(ref beforeRow);
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }
        /// <summary>
        /// Hàm này dùng để thêm một(hoặc nhiều) row mới vào truoc một row cho trước trong table
        /// </summary>
        /// <param name="tbl">Table tương ứng</param>
        /// <param name="rowIndex">index của row cho trước</param>
        /// <param name="numRow">số row cần bổ sung</param>
        public static void AddRowsAbove(ref Table tbl, int rowIndex, int numRow)
        {
            try
            {
                if (rowIndex < 1) return;
                if (rowIndex > tbl.Rows.Count) throw new ArgumentException("Index is out of RowCount");
                tbl.Rows.Item(rowIndex).Select();
                _msWord.Selection.InsertRowsAbove(numRow);
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }
        /// <summary>
        /// Hàm này dùng để thêm một(hoặc nhiều) row mới vào sau một row cho trước trong table
        /// </summary>
        /// <param name="rowIndex">index của row cho trước</param>
        /// <param name="numRow">số row cần bổ sung</param>
        public static void AddRowsBelow(int index, int rowIndex, int numRow)
        {
            try
            {
                Table tbl = _doc.Content.Tables.Item(index);
                tbl.Rows.Item(rowIndex).Select();
                _msWord.Selection.InsertRowsBelow(numRow);
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        /// <summary>
        /// Hàm này dùng để thêm một(hoặc nhiều) row mới vào trước một row cho trước trong table
        /// </summary>
        /// <param name="tbl">Table tương ứng</param>
        /// <param name="rowIndex">index của row cho trước</param>
        /// <param name="numRow">số row cần bổ sung</param>
        public static void AddRowsBelow(ref Table tbl, int rowIndex, int numRow)
        {
            try
            {
                if (rowIndex < 1) return;
                if (rowIndex > tbl.Rows.Count) throw new ArgumentException("Index is out of RowCount");
                tbl.Rows.Item(rowIndex).Select();
                _msWord.Selection.InsertRowsBelow(numRow);
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }
        /// <summary>
        /// Hàm này dùng để thêm một(hoặc nhiều) row mới vào trước một row cho trước trong table
        /// </summary>
        /// <param name="rowIndex">index của row cho trước</param>
        /// <param name="numRow">số row cần bổ sung</param>
        public static void AddRowsAbove(int index, int rowIndex, int numRow)
        {
            try
            {
                Table tbl = _doc.Content.Tables.Item(index);
                tbl.Rows.Item(rowIndex).Select();
                _msWord.Selection.InsertRowsAbove(numRow);
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        /// <summary>
        /// Ham nay thiet lap gia tri cho Cell trong Table
        /// 
        /// </summary>
        /// <param name="colIndex">Chi so cua column chua Cell, bat dau tu 1</param>
        /// <param name="row">row trong Table</param>
        /// <param name="value">Gia tri cho Cell</param>

        public static void SetValueForTableCell(Row row, int colIndex, string value)
        {
            try
            {
                row.Cells.Item(colIndex).Range.Text = value;
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        public static Hashtable AllValues2(DataRow dataRow, List<string> colNames)
        {
            int length = colNames.Count;
            Hashtable hashtable = new Hashtable();
            try
            {
                for (int key = 1; key <= length; key++)
                {
                    hashtable.Add(key, dataRow[colNames[key - 1]]);
                }
                return hashtable;
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
                return new Hashtable();
            }
        }

        public static Hashtable AllValues(DataRow dataRow, List<string> colNames)
        {
            int length = colNames.Count + 1;
            Hashtable hashtable = new Hashtable();
            try
            {
                for (int key = 2; key <= length; key++)
                {
                    hashtable.Add(key, dataRow[colNames[key - 2]]);
                }
                return hashtable;
            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
                return new Hashtable();
            }
        }

        public static void SetAllValueForTableRow(Table tbl1, int rowIndex, Hashtable rowHashTable)
        {
            try
            {
                foreach (var key in rowHashTable.Keys)
                {
                    int colIndex = (int)key;
                    var cell = tbl1.Cell(rowIndex, colIndex);
                    cell.Range.Text = Convert.ToString(rowHashTable[key]);
                    SetStyleForCell(cell);
                }

            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        public static void SetAllValueForTableRowWithStyle(Row row, Hashtable rowHashTable, bool isBold, bool isItalic, bool isUnderline)
        {
            try
            {
                foreach (var key in rowHashTable.Keys)
                {
                    int colIndex = (int)key;
                    row.Cells.Item(colIndex).Range.Text = Convert.ToString(rowHashTable[key]);
                    SetStyleForCell(row.Cells.Item(colIndex), isBold, isItalic, isUnderline);
                }

            }
            catch (Exception exception)
            {
                MMessageBox.Show(null, exception.Message);
            }
        }

        public static void UpdateFields(int time)
        {
            if (_doc == null) return;
            Thread.Sleep(time);
            _doc.Fields.Update();
        }


        public static void SetParameterUsingBookmark(string bookmarkName, object bookmarkValue)
        {
            if (_doc == null) return;

            object oBookmark = bookmarkName;

            if (!_doc.Bookmarks.Exists(bookmarkName))
            {
//                throw new Exception("Bookmark khong ton tai trong WordDoc");
                return;
            }

            Range bookmarkRange = _doc.Bookmarks.Item(ref oBookmark).Range;

            bookmarkRange.Text = bookmarkValue as string;

        }
        /// <summary>
        /// Ham co nhiem vu cap nhat lai tong so trang cho NumPages Field cua WordDoc
        /// </summary>
        /// <param name="time">Thoi gian cap nhat numPages tinh theo milisecond</param>
        public static void UpdateNumPagesField(int time)
        {
            if (_doc == null) return;

            foreach (Field myNumpagesField in _doc.Fields)
            {
                if (myNumpagesField.Type == WdFieldType.wdFieldNumPages)
                {
                    Thread.Sleep(time);
                    myNumpagesField.Update();
                    //break;
                }

            }
        }
        public static void SetParameterUsingMergeField(string mergFieldName, object mergFieldValue)
        {
            if (_doc == null) return;

            foreach (Field myMergeField in _doc.Fields)
            {

                Range rngFieldCode = myMergeField.Code;

                String fieldText = rngFieldCode.Text;

                // ONLY GETTING THE MAILMERGE FIELDS

                if (fieldText.StartsWith(" MERGEFIELD"))
                {

                    // THE TEXT COMES IN THE FORMAT OF

                    // MERGEFIELD  MyFieldName  \\* MERGEFORMAT

                    // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"

                    Int32 endMerge = fieldText.IndexOf("\\");

                    Int32 fieldNameLength = fieldText.Length - endMerge;

                    String fieldName = fieldText.Substring(11, endMerge - 11);



                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                    fieldName = fieldName.Trim();



                    // **** FIELD REPLACEMENT IMPLEMENTATION GOES HERE ****//

                    // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                    if (fieldName.ToUpper().Equals(mergFieldName.ToUpper()))
                    {

                        myMergeField.Select();
                        myMergeField.Result.Text = Convert.ToString(mergFieldValue);
                        //                        break;
                    }

                }

            }
        }

        /// <summary>
        /// Chen pic vao WordDoc
        /// </summary>
        /// <param name="imagePath">Duong dan cua anh </param>
        public static void AddPicture(string bookmarkName, string imagePath)
        {

            // Declaration of the variables

            Object myFalse = false;
            Object myTrue = true;
            Object endOfDoc = "\\endofdoc";
            Object oPic = bookmarkName;

            if (!_doc.Bookmarks.Exists(bookmarkName))
                throw new Exception("Bookmark cho pic khong ton tai trong WordDoc");

            // Set the position where the image will be placed

            Object myImageRange = _doc.Bookmarks.Item(ref oPic).Range;

            Range myRange = _doc.Bookmarks.Item(ref endOfDoc).Range;

            // Add the picture to the document

            myRange.InlineShapes.AddPicture(imagePath, ref myFalse, ref myTrue, ref myImageRange);

        }

        /// <summary>
        /// Chen pic vao WordDoc voi kich thuoc xac dinh
        /// </summary>
        /// <param name="imagePath">Duong dan cua pic tren o dia</param>
        /// <param name="imageH">Chieu cao pic, don vi la inches</param>
        /// <param name="imageW">Chieu rong pic, don vi la inches</param>
        public static void AddPicture(string bookmarkName, string imagePath, float imageH, float imageW)
        {
            // Declaration of the variables

            Object myFalse = false;
            Object myTrue = true;
            Object endOfDoc = "\\endofdoc";
            Object oPic = bookmarkName;

            if (!_doc.Bookmarks.Exists(bookmarkName))
                throw new Exception("Bookmark cho pic khong ton tai trong WordDoc");

            // Set the position where the image will be placed

            Object myImageRange = _doc.Bookmarks.Item(ref oPic).Range;

            Range myRange = _doc.Bookmarks.Item(ref endOfDoc).Range;

            // Add the picture to the document

            InlineShape docPic = myRange.InlineShapes.AddPicture(imagePath, ref myFalse, ref myTrue, ref myImageRange);

            // chuyen sang don vi inches
            docPic.Height = _msWord.InchesToPoints(imageH);
            docPic.Width = _msWord.InchesToPoints(imageW);
        }
        public static void AddPicture(string bookmarkName, Image image)
        {
            // Declaration of the variables

            Object oPic = bookmarkName;

            if (image == null) return;

            if (!_doc.Bookmarks.Exists(bookmarkName))
                throw new Exception("Bookmark cho pic khong ton tai trong WordDoc");

            // Set the position where the image will be placed

            Clipboard.SetImage(image);

            Range myImageRange = _doc.Bookmarks.Item(ref oPic).Range;

            // Add the picture to the document

            myImageRange.Paste();
        }

        public static void AddPicture(string bookmarkName, byte[] byteArr)
        {

            if (byteArr == null) return;

            if (!_doc.Bookmarks.Exists(bookmarkName))
                throw new Exception("Bookmark cho pic khong ton tai trong WordDoc");

            Image image = ByteArrayToImage(byteArr);
            AddPicture(bookmarkName, image);
        }

        public static void Save()
        {
            if (_doc == null) return;
            _doc.Save();
        }

        public static void SaveAs(string fileName)
        {
            if (_doc == null) return;
            object oFileName = fileName;
            _doc.SaveAs(ref oFileName);
        }

        public static void OpenWordDocument(string fileName)
        {
            try
            {
                if (!Path.GetExtension(fileName).ToLower().Equals(".doc")
                    && !Path.GetExtension(fileName).ToLower().Equals(".docx")) return;
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MMessageBox.Show(null,"Khong mo dc File");
            }
        }

        public static void QuitMsWordApp(bool isSaveDocument)
        {
            try
            {
                object saveOptionsObject = isSaveDocument ? WdSaveOptions.wdSaveChanges : WdSaveOptions.wdDoNotSaveChanges;
                if (_doc != null)
                {
                    _doc.Close(ref saveOptionsObject, ref _objMiss, ref _objMiss);
                    _doc.Application.Quit(ref _objMiss, ref _objMiss, ref _objMiss);
                }
            }
            catch { }
            finally
            {
                //--Closing the Word Application
                if (_msWord != null)
                    _msWord.Quit(ref _objMiss, ref _objMiss, ref _objMiss);
                _doc = null;
                _msWord = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public static void Show()
        {
            if (_msWord != null)
                _msWord.Visible = true;
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn == null)
                return null;
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null)
                return null;
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static Table GetTableFromBookmark(Object bookmarkName)
        {
            if (!_doc.Bookmarks.Exists(bookmarkName as string))
                throw new ArgumentException("Bookmark :" + bookmarkName + "khong ton tai ");

            Bookmark bookmark = _doc.Bookmarks.Item(ref bookmarkName);

            foreach (Table aTable in _doc.Tables)
            {
                if (aTable.Range.Start == bookmark.Range.Start && aTable.Range.End == bookmark.Range.End)
                    return aTable;
            }
            return null;
        }

        public static Table GetTableFromBookmark2(Object bookmarkName)
        {
            if (!_doc.Bookmarks.Exists(bookmarkName as string))
                throw new ArgumentException("Bookmark :" + bookmarkName + "khong ton tai ");

            Bookmark bookmark = _doc.Bookmarks.Item(ref bookmarkName);

            foreach (Table aTable in _doc.Tables)
            {
                if (aTable.Range.BookmarkID == bookmark.Range.BookmarkID)
                    return aTable;
            }
            return null;
        }

        public static void FillDataToWordDocTable(String bookmarkName)
        {
            if (_doc == null) return;
            if (_doc.Tables.Count == 0) return;

            Table tbl1 = GetTableFromBookmark(bookmarkName);

            if (tbl1 == null) return;

            int rowIndex = 1;
            foreach (DataRow sRow in SourceTable.Rows)
            {
                Row row = tbl1.Rows.Add(ref _objMiss);
                row.Cells.Item(1).Range.Text = rowIndex.ToString();
                rowIndex++;
                row.Cells.Item(1).WordWrap = false;
                row.Cells.Item(1).Range.Bold = 0;
                for (int i = 0; i < SourceTable.Columns.Count; i++)
                {
                    row.Cells.Item(i + 2).Range.Text = Convert.ToString(sRow[i]);
                    row.Cells.Item(i + 2).WordWrap = false;
                    row.Cells.Item(i + 2).Range.Bold = 0;
                }
            }
        }

        //        public static void ThreadForWaitingExport(IWin32Window iWin32Window)
        //        {
        //            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ShowWaitForWordApp);
        //            Thread thread = new Thread(threadStart);
        //            thread.Start(iWin32Window);
        //        }

        public static void ThreadForWaitingExport()
        {
            ThreadStart threadStart = new ThreadStart(ShowWaitingForWordApp);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }

        public static void ThreadForClosingExport()
        {
            ThreadStart threadStart = new ThreadStart(CloseWaitingForWordApp);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }
        private static FrmWaitDialog _frmWaitDialog = new FrmWaitDialog();

        //private static void ShowWaitForWordApp(object iWin32Window)
        //{
        //    IWin32Window owneriWin32Window = (IWin32Window)iWin32Window;
        //    _frmWaitDialog.ShowDialog(owneriWin32Window);
        //}

        private static void ShowWaitingForWordApp()
        {
            _frmWaitDialog.ShowDialog();
        }

        private static void CloseWaitingForWordApp()
        {
            _frmWaitDialog.BeginInvoke((MethodInvoker)delegate { _frmWaitDialog.Close(); });
        }

        public static void UpdateField(int p)
        {
            throw new NotImplementedException();
        }
    }
}
