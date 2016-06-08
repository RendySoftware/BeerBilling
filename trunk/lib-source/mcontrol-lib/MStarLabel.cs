using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MStarLabel : Label
    {
        public MStarLabel()
        {
            InitializeComponent();
            Text = "(*)";
            ForeColor = System.Drawing.Color.Red;
        }

        public MStarLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Text = "(*)";
            ForeColor = System.Drawing.Color.Red;
        }
    }
}
