using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace mcontrol.NotificationForm
{
    public partial class FrmNotification : Form
    {
        public FrmNotification()
        {
            InitializeComponent();
        }

        public void ShowMessage(Icon tipIcon, ToolTipIcon toolTipIcon, string tipTitle, string textMessage, int timeInterVal)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.Icon = tipIcon;
            notifyIcon1.BalloonTipTitle = tipTitle;
            notifyIcon1.BalloonTipText = textMessage;
            notifyIcon1.BalloonTipIcon = toolTipIcon;
            notifyIcon1.ShowBalloonTip(timeInterVal);
            Thread.Sleep(timeInterVal);
            notifyIcon1.Visible = false;
            notifyIcon1.Icon = null;
            notifyIcon1.Dispose();
            notifyIcon1 = null;
            Dispose();
        }
    }
}
