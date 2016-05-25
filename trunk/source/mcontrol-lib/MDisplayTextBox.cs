using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcontrol
{
    public sealed partial class MDisplayTextBox : MTextBox
    {
        public MDisplayTextBox()
        {
            InitializeComponent();
            Enabled = false;
        }

        public MDisplayTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
