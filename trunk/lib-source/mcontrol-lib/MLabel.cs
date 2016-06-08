using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcontrol
{
    public sealed partial class MLabel : Label
    {
        public MLabel()
        {
            InitializeComponent();
            Font = new Font(MComponentConst.LabelFontName, MComponentConst.LabelFontSize);
        }

        public MLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Font = new Font(MComponentConst.LabelFontName, MComponentConst.LabelFontSize);
        }
    }
}
