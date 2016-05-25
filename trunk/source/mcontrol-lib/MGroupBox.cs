using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcontrol
{

    public sealed partial class MGroupBox : GroupBox
    {
        public MGroupBox()
        {
            InitializeComponent();
            FlatStyle = FlatStyle.System;
            Font = new Font(MComponentConst.GroupdFontName, MComponentConst.GroupFontSize, FontStyle.Bold);
        }

        public MGroupBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Font = new Font(MComponentConst.GroupdFontName, MComponentConst.GroupFontSize, FontStyle.Bold);
        }
    }
}
