using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ExcelLibrary.SpreadSheet;
using System.Data;

namespace core_lib.common
{
    public class ExcelUtil
    {
        public static void CreateExcel(List<object[]>[] ds, List<string[]> listFields, string[] sheetNames, string filename)
        {
            GC.Collect();

            Workbook workbook = new Workbook();
            for (int i = 0; i < sheetNames.Length; i++)
            {
                string sheetName = sheetNames[i];
                List<object[]> dt = ds[i];
                Worksheet worksheet = new Worksheet(sheetName);
                fillSheetContent(worksheet, dt, listFields[i]);
                workbook.Worksheets.Add(worksheet);
            }
            workbook.Save(filename);

            GC.Collect();

            //            FileInfo file = new FileInfo(filename);
            //            Response.Clear();
            //            Response.Charset = "UTF-8";
            //            Response.ContentEncoding = System.Text.Encoding.UTF8;
            //Add header, give a default file name for "File Download/Store as"
            //            Response.AddHeader("Content-Disposition", "attachment; filename="
            //          + Server.UrlEncode(file.Name));
            //Add header, set file size to enable browser display download progress
            //            Response.AddHeader("Content-Length", file.Length.ToString());
            //Set the return string is unavailable reading for client, and must be downloaded
            //            Response.ContentType = "application/ms-excel";
            //Send file string to client 
            //            Response.WriteFile(file.FullName);
            //Stop execute  
            //            Response.End();
        }

        private static void fillSheetContent(Worksheet worksheet, List<object[]> dt, string[] fields)
        {
            for (int i = 0; i < fields.Length; i++)
            {
                worksheet.Cells[0, i] = new Cell(fields[i]);
            }
            for (int r = 0; r < dt.Count; r++)
            {
                for (int i = 0; i < dt[r].Length; i++)
                {
                    object o = dt[r][i];
                    if (o == null)
                        continue;
                    if (o is DateTime)
                    {
                        worksheet.Cells[r + 1, i] = new Cell(String.Format("{0:yyyyMMdd}", (DateTime)o));
                    }
                    else
                    {
                        worksheet.Cells[r + 1, i] = new Cell(o.ToString());
                    }
                }
            }
        }

        public static int dateCompare(DateTime d1, DateTime d2)
        {
            string v1 = String.Format("{0:yyyyMMdd}", d1);
            string v2 = String.Format("{0:yyyyMMdd}", d2);
            return v1.CompareTo(v2);
        }

        public static void CreateExcel(DataSet ds, string[] sheetNames, string filename)
        {
            GC.Collect();

            Workbook workbook = new Workbook();
            for (int i = 0; i < sheetNames.Length; i++)
            {
                string sheetName = sheetNames[i];
                DataTable dt = ds.Tables[sheetName];
                Worksheet worksheet = new Worksheet(dt.TableName);
                fillSheetContent(worksheet, dt);
                workbook.Worksheets.Add(worksheet);
            }
            workbook.Save(filename);

            GC.Collect();

            //            FileInfo file = new FileInfo(filename);
            //            Response.Clear();
            //            Response.Charset = "UTF-8";
            //            Response.ContentEncoding = System.Text.Encoding.UTF8;
            //Add header, give a default file name for "File Download/Store as"
            //            Response.AddHeader("Content-Disposition", "attachment; filename="
            //          + Server.UrlEncode(file.Name));
            //Add header, set file size to enable browser display download progress
            //            Response.AddHeader("Content-Length", file.Length.ToString());
            //Set the return string is unavailable reading for client, and must be downloaded
            //            Response.ContentType = "application/ms-excel";
            //Send file string to client 
            //            Response.WriteFile(file.FullName);
            //Stop execute  
            //            Response.End();
        }
/*
        public static void ExportToExcel(DataTable dt, string filePath)
        {
            Microsoft.Office.Interop.Excel.ApplicationClass excel = null;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Application.Workbooks.Add(true);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        // Add column headings...
                        worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                    }
                    var colStart = "A1";
                    var colEndChar = Char.ToString((char)('A' + dt.Columns.Count - 1));
                    var colEnd = colEndChar + "1";
                    Microsoft.Office.Interop.Excel.Range headerColumnRange = worksheet.get_Range(colStart, colEnd);
                    headerColumnRange.Font.Bold = true;
                    headerColumnRange.Font.Color = 0xFF0000;
                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        // add each row's cell data...
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            object o = dt.Rows[r][i];
                            if (o is DateTime)
                            {
                                worksheet.Cells[r + 2, i + 1] = String.Format("{0:dd/MM/yyyy}", (DateTime)o);
                            }
                            else if (o is string)
                            {
                                var s = o as string;
                                if (!string.IsNullOrEmpty(s) && !char.IsLetter(s[0]))
                                {
                                    worksheet.Cells[r + 2, i + 1] = "'" + o;
                                }
                                else
                                {
                                    worksheet.Cells[r + 2, i + 1] = o;
                                }
                            }
                            else
                            {
                                worksheet.Cells[r + 2, i + 1] = o;
                            }
                        }

                    }
                    Microsoft.Office.Interop.Excel.Range fullTextRange = worksheet.get_Range("A1", colEndChar + (dt.Rows.Count + 1));
//                    fullTextRange.WrapText = true;
                    fullTextRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    fullTextRange.Borders.Color = 0x000000;
                    fullTextRange.EntireColumn.AutoFit();
                    // Global missing reference for objects we are not defining...
                    object missing = System.Reflection.Missing.Value;
                    // If wanting to Save the workbook...  
                    workbook.SaveAs(filePath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, missing, missing, false, false,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, missing, missing, missing, missing, missing);
                    workbook.Saved = true;
                    workbook.Close();
                }
            }
            finally
            {
                if (excel != null)
                {
                    excel.Quit();
                }
            }
        }
*/
        private static void fillSheetContent(Worksheet worksheet, DataTable dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                worksheet.Cells[0, i] = new Cell(dt.Columns[i].ColumnName);
            }
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    object o = dt.Rows[r][i];
                    if (o is DateTime)
                    {
                        worksheet.Cells[r + 1, i] = new Cell(String.Format("{0:dd/MM/yyyy}", (DateTime)o));
                    }
                    else
                    {
                        worksheet.Cells[r + 1, i] = new Cell(o.ToString());
                    }
                }
            }
        }
    }
}
