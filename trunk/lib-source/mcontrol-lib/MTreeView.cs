using System.ComponentModel;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MTreeView : TreeView
    {
        public MTreeView()
        {
            InitializeComponent();
        }

        public MTreeView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
