using System;
using System.Windows.Forms;

namespace mcontrol.NotificationForm
{
    //  @author chungnd
    //  referenced at http://www.codeproject.com

    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();          
        }


        public Notification(MessageIcon icon, String textMessage):this()
        {              
            Init(textMessage, icon);
        }
        public Notification(MessageIcon icon, String textMessage, int timeInterval):this(icon, textMessage)
        {
            timer1.Interval = timeInterval;
        }

        private void Init(string textMessage, MessageIcon icon)
        {
            var temp = "";
            if (textMessage.Length > 32)
            {
                if (textMessage.Length % 32 == 0)
                {
                    int dong = textMessage.Length / 32;

                    for (int i = 1; i <= dong; i++)
                    {
                        String subString = textMessage.Substring(32*(i - 1), 32);
                        int position = subString.LastIndexOf(" ");
                        subString = subString.Insert(position + 1, Environment.NewLine);
                        temp += subString ;
                    }
                }
                else
                {
                    int dong = textMessage.Length / 32;
                    for (int i = 1; i <= dong; i++)
                    {
                        String subString = textMessage.Substring(32 * (i - 1), 32);
                        int position = subString.LastIndexOf(" ");
                        subString = subString.Insert(position + 1, Environment.NewLine);
                        temp += subString;
                    }
                    temp += textMessage.Substring(32 * dong, textMessage.Length % 32);
                }


            }
            else
            {
                temp = textMessage;
            }
            lblTextMessage.Text = temp;
            addIconImage(icon);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            this.Left = screenWidth - this.Width;
            this.Top = screenHeight - this.Height;            
          
            this.Opacity = 0.0;
            m_bShowing = true;
            timer2.Start();
        }
      
        private	 bool m_bShowing = true;
        private bool m_bForceClose = false;
        private void Notification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!m_bForceClose)
            {
                e.Cancel = true;
                m_bShowing = false;
                timer2.Start();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
         
        }

        private void addIconImage(MessageIcon MessageIcon)
        {
            switch (MessageIcon)
            {
                case MessageIcon.Error:
                    pictureBox1.Image = imageList1.Images["Error"];  //Error is key name in imagelist control which uniqly identified images in ImageList control.
                    break;
                case MessageIcon.Information:
                    pictureBox1.Image = imageList1.Images["Information"];
                    break;
                case MessageIcon.Question:
                    pictureBox1.Image = imageList1.Images["Question"];
                    break;
                case MessageIcon.Warning:
                    pictureBox1.Image = imageList1.Images["Warning"];
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (m_bShowing)
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.1;
                }
                else
                {
                    timer2.Stop();
                }
            }
            else
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.1;
                }
                else
                {
                    timer2.Stop();
                    m_bForceClose = true;
                    this.Close();
                }
            }
        }      
    }

    public enum MessageIcon
    {
        Error,
        Warning,
        Information,
        Question,
    }
}
