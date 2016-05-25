using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MForm : Form
    {
        public MForm()
        {
            InitializeComponent();
        }

        public MForm(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public virtual void DoF1KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        public virtual void DoF2KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        public virtual void DoF3KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        public virtual void DoF4KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        public virtual void DoF5KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        public virtual void DoF6KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        public virtual void DoF7KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        public virtual void DoF8KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        public virtual void DoF9KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        public virtual void DoF10KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        public virtual void DoF11KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        public virtual void DoF12KeyPress()
        {
            MMessageBox.Show(this, "Phím tắt chưa được cài đặt!", "Thông báo"
                            , MMessageBoxButtons.OK, MMessageBoxIcon.Warning);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.F1)
                DoF1KeyPress();
            if (e.KeyCode == Keys.F2)
                DoF2KeyPress();
            if (e.KeyCode == Keys.F3)
                DoF3KeyPress();
            if (e.KeyCode == Keys.F4)
                DoF4KeyPress();
            if (e.KeyCode == Keys.F5)
                DoF5KeyPress();
            if (e.KeyCode == Keys.F6)
                DoF6KeyPress();
            if (e.KeyCode == Keys.F7)
                DoF7KeyPress();
            if (e.KeyCode == Keys.F8)
                DoF8KeyPress();
            if (e.KeyCode == Keys.F9)
                DoF9KeyPress();
            if (e.KeyCode == Keys.F10)
                DoF10KeyPress();
            if (e.KeyCode == Keys.F11)
                DoF11KeyPress();
            if (e.KeyCode == Keys.F12)
                DoF12KeyPress();
        }
    }
}
