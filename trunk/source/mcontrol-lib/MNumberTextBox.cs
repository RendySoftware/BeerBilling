using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MNumberTextBox : MTextBox
    {
        public MNumberTextBox()
        {
            InitializeComponent();
            }

        public MNumberTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
         }
    }
}
