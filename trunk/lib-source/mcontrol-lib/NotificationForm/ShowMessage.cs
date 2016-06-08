using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace mcontrol.NotificationForm
{
    public class ShowMessage
    {
        private static String _textMessage = "";
//        private static MessageIcon _icon = MessageIcon.Information;
        private static Icon _tipIcon = SystemIcons.Information;
        private static ToolTipIcon _toolTipIcon = ToolTipIcon.Info;
        private static string _tipTitle = "Thông báo";
        private static int _timeInterVal = 2000;

        public static void Show(MessageIcon icon ,String textMessage)
        {
            _textMessage = textMessage;
//            _icon = icon;
            UpdateToolTipIcon(icon);
            _timeInterVal = 2000;

            CreateMyThread();
        }

        private static void UpdateToolTipIcon(MessageIcon icon)
        {
            switch (icon)
            {
                case MessageIcon.Error:
                    _tipIcon = SystemIcons.Error;
                    _toolTipIcon = ToolTipIcon.Error;
                    break;
                case MessageIcon.Information:
                    _tipIcon = SystemIcons.Information;
                    _toolTipIcon = ToolTipIcon.Info;
                    break;
                case MessageIcon.Question:
                    _tipIcon = SystemIcons.Question;
                    _toolTipIcon = ToolTipIcon.Info;
                    break;
                case MessageIcon.Warning:
                    _tipIcon = SystemIcons.Warning;
                    _toolTipIcon = ToolTipIcon.Warning;
                    break;
            }
        }

        public static void Show(String textMessage)
        {
            _textMessage = textMessage;
//            _icon = MessageIcon.Information;
            UpdateToolTipIcon(MessageIcon.Information);
            _timeInterVal = 2000;

            CreateMyThread();
        }
        public static void Show(MessageIcon icon, String textMessage, int timeInterVal)
        {
            _textMessage = textMessage;
//            _icon = icon;
            UpdateToolTipIcon(icon);
            _timeInterVal = timeInterVal;

            CreateMyThread();
        }
        
        public static void Show(String textMessage, int timeInterVal)
        {
            _textMessage = textMessage;
            _timeInterVal = timeInterVal;
//            _icon = MessageIcon.Information;
            UpdateToolTipIcon(MessageIcon.Information);

            CreateMyThread();
        }

        private static void CreateMyThread()
        {
            ThreadStart job = new ThreadStart(ThreadJob); 
            Thread thread = new Thread(job);
            thread.Start();
        }

        private static void ThreadJob()
        {            
//            Notification notification = new Notification(_icon, _textMessage, _timeInterVal);
//            notification.ShowDialog(); 
            new FrmNotification().ShowMessage(_tipIcon, _toolTipIcon, _tipTitle, _textMessage, _timeInterVal);
        }
    }
}
