using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcontrol
{
    public sealed partial class MRadioButton : RadioButton
    {
        public MRadioButton()
        {
            InitializeComponent();
            Font = new Font(MComponentConst.RadioFontName, MComponentConst.RadioFontSize);
        }

        public MRadioButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Font = new Font(MComponentConst.RadioFontName, MComponentConst.RadioFontSize);
        }
    }
}
