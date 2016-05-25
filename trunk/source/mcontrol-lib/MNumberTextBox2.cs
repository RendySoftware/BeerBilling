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
    public partial class MNumberTextBox2 : TextBox
    {
        public MNumberTextBox2()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize);
        }

        public MNumberTextBox2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.BorderStyle = BorderStyle.FixedSingle;
            this.Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize);
        }

        //Default
        //Allow number in text box
        public Boolean num = false;
        //Allow Charecter in text box
        public Boolean c = false;
        public Boolean sp = false;
        public Boolean mtry = false;
        public string errmsg = "";
        public string msgboxtitle = "";
         
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public Boolean AllowNumericOnly
        {
            get { return num; }
            set { num = value; Invalidate(); }
        }
        public Boolean AllowAlphaOnly
        {
            get { return c; }
            set { c = value; Invalidate(); }
        }

        public Boolean AllowSpecialCharecterOnly
        {
            get { return sp; }
            set { sp = value; Invalidate(); }
        }

        public Boolean Mandatory
        {
            get { return mtry; }
            set { mtry = value; Invalidate(); }
        }

        public string ErrorMessage
        {
            get { return errmsg; }
            set { errmsg = value; Invalidate(); }
        }

        public string ErrorMessageTitle
        {
            get { return msgboxtitle; }
            set { msgboxtitle = value; Invalidate(); }
        }
        bool blHasDot = false;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !blHasDot)
            {
                //Allows only one Dot Char
                blHasDot = true;
            }
            else if (e.KeyChar == '-' && Text.Length == 0)
            {

                //Allows only one '-' Char
            }
            else
            {
                e.Handled = true;
            }
            
        }
        //Check mandatory textbox or not
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (mtry == true)
            {
                if (this.Text.Length == 0)
                {
                    if (errmsg != "")
                    {                                 
                            MessageBox.Show(errmsg, msgboxtitle);
                            this.Focus();                
                    }
                    else
                    {
                        MMessageBox.Show(this, "Bạn phải nhập giá trị!", "Thông báo");                      
                    }
                }
            }
            
        }
    }
}
