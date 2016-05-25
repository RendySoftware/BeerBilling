using System.ComponentModel;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MPictureBox : PictureBox
    {
        public MPictureBox()
        {
            InitializeComponent();
        }

        public MPictureBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
