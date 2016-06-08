using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MTextBoxNormal : TextBox
    {
        public MTextBoxNormal()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
            Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize);
        }

        public MTextBoxNormal(IContainer container)
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
    }
}
