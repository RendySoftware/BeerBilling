using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcontrol
{
    public sealed partial class MCheckBox : CheckBox
    {
        public MCheckBox()
        {
            InitializeComponent();

            Font = new Font(MComponentConst.CheckBoxFontName, MComponentConst.CheckBoxFontSize);
        }

        public MCheckBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Font = new Font(MComponentConst.CheckBoxFontName, MComponentConst.CheckBoxFontSize);
        }
    }
}
