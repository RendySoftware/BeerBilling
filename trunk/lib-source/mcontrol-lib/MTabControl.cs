using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcontrol
{
    public sealed partial class MTabControl : TabControl
    {
        public MTabControl()
        {
            InitializeComponent();
            Font = new Font(MComponentConst.TabFontName, MComponentConst.TabFontSize);
        }

        public MTabControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Font = new Font(MComponentConst.TabFontName, MComponentConst.TabFontSize);
        }
    }
}
