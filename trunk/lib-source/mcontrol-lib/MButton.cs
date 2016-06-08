using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcontrol
{
    public sealed partial class MButton : Button
    {
        public MButton()
        {
            InitializeComponent();
            Font = new Font(MComponentConst.ButtonFontName, MComponentConst.ButtonFontSize);
        }

        public MButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Font = new Font(MComponentConst.ButtonFontName, MComponentConst.ButtonFontSize);
        }
    }
}
