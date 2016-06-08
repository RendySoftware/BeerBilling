using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MTextBox : TextBox
    {
        public MTextBox()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
            Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize);
        }

        public MTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
            Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize);
        }

        protected override void OnEnter(EventArgs e)
        {
            SelectAll();
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            if (ReadOnly)
                return;
            if (!String.IsNullOrEmpty(Text) && !String.IsNullOrEmpty(Text.Substring(0, 1)))
                this.Text = this.Text.Substring(0, 1).ToUpper() + Text.Substring(1, Text.Length - 1);
            base.OnLeave(e);
        }
    }
}
