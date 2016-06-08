using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wordviewer
{
    public class WordViewerUtil
    {
        public static void LoadDocument(IWin32Window owner, string title, string filePath, bool cleanWhenDone)
        {
            try
            {
                var frm = new FrmWordViewer(filePath);
                frm.Text = title;
                frm.Activate();
                frm.ShowDialog(owner);
                if (cleanWhenDone)
                    DeleteFile(filePath);
            }
            catch { }
        }

        public static void DeleteFile(string filePath)
        {
            try
            {
                if (!String.IsNullOrEmpty(filePath) && File.Exists(filePath))
                    File.Delete(filePath);
            }
            catch { }
        }
    }
}
