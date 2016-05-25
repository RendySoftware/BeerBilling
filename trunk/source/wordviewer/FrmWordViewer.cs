using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using mcontrol;

namespace wordviewer
{
    public partial class FrmWordViewer : Form
    {
        private string _filePath;
        public FrmWordViewer(string filePath)
        {
            InitializeComponent();
            _filePath = filePath;
        }

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public void LoadDocument()
        {
            if (!String.IsNullOrEmpty(_filePath) && File.Exists(_filePath))
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    winWordControl1.LoadDocument(_filePath);
                    winWordControl1.RestoreWord();
                }
                catch { }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
                MMessageBox.Show(this, "File không tồn tại!", "Thông báo", MMessageBoxButtons.OK,
                                 MMessageBoxIcon.Warning);
        }

        private void FrmWordViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                winWordControl1.CloseControl();
            }
            catch { }
        }

        private void FrmWordViewer_Load(object sender, EventArgs e)
        {
            ForceControlCreation(winWordControl1);
            LoadDocument();
        }

        private void ForceControlCreation(IWin32Window control)
        {
            // Ensures that the subject control is created in the same thread as the parent 
            // form's without making it actually visible if not required. This will prevent 
            // any possible InvalidAsynchronousStateException, if the control is later 
            // invoked first from a background thread.
            var handle = control.Handle;
        }
    }
}
