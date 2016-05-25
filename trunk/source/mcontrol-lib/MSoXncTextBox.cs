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
    public sealed partial class MSoXncTextBox : MTextBoxNormal
    {
        public MSoXncTextBox()
        {
            InitializeComponent();
            this.CharacterCasing = CharacterCasing.Upper;
        }

        delegate void SetTextCallback(string text);

        public override sealed string Text
        {
            get { return base.Text.Trim(); }
            set {base.Text = value;}
        }

        public void SetText(string text)
        {
            if (this.InvokeRequired)
            {
                var d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
                this.Text = text;
        }

        public MSoXncTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize);
        }

        protected override void OnEnter(EventArgs e)
        {
            SelectAll();
        }
    }
}
