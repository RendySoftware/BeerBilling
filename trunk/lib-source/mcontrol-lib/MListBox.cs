using System.ComponentModel;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MListBox : ListBox
    {
        public MListBox()
        {
            InitializeComponent();
        }

        public MListBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
