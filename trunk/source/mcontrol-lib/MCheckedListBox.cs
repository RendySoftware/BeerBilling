using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MCheckedListBox : CheckedListBox
    {
        public MCheckedListBox()
        {
            InitializeComponent();
        }

        public MCheckedListBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
