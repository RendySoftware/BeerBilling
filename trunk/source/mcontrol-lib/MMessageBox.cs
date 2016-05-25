using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MMessageBox : Form
    {
        public MMessageBox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// setMessage method is used to display message
        /// on form and it's height adjust automatically.
        /// I am displaying message in a Label control.
        /// </summary>
        /// <param name="messageText">Message which needs to be displayed to user.</param>
        private void setMessage(string messageText)
        {
            int number = Math.Abs(messageText.Length / 30);
            if (number != 0)
                this.lblMessageText.Height = number * 25;        

            var temp = "";
            if (messageText.Length > 60)
            {
                if (messageText.Length % 60 == 0)
                {
                    int dong = messageText.Length /60;

                    for (int i = 1; i <= dong; i++)
                    {
                        String subString = messageText.Substring(60 * (i - 1), 60);
                        int position = subString.LastIndexOf(" ");
                        subString = subString.Insert(position + 1, Environment.NewLine);
                        temp += subString;
                    }
                }
                else
                {
                    int dong = messageText.Length / 60;
                    for (int i = 1; i <= dong; i++)
                    {
                        String subString = messageText.Substring(60 * (i - 1), 60);
                        int position = subString.LastIndexOf(" ");
                        subString = subString.Insert(position + 1, Environment.NewLine);
                        temp += subString;
                    }
                    temp += messageText.Substring(60 * dong, messageText.Length % 60);
                }


            }
            else
            {
                temp = messageText;
            }

            this.lblMessageText.Text = temp;
        }
        #region constant defiend in form of enumration which is used in showMessage class.
        /// <summary>
        /// This method is used to add button on message box.
        /// </summary>
        /// <param name="MessageButton">MessageButton is type of enumMessageButton
        /// through which I get type of button which needs to be displayed.</param>
        private void addButton(MMessageBoxButtons MessageButton)
        {
            switch (MessageButton)
            {
                case MMessageBoxButtons.OK:
                    {
                        //If type of enumButton is OK then we add OK button only.
                        Button btnOk = new Button();  //Create object of Button.
                        btnOk.Text = MMessageBoxButtonText.OK;  //Here we set text of Button.
                        btnOk.DialogResult = DialogResult.OK;  //Set DialogResult property of button.
                        btnOk.FlatStyle = FlatStyle.Standard;  //Set flat appearence of button.
                        btnOk.FlatAppearance.BorderSize = 0;
                        btnOk.SetBounds(pnlShowMessage.ClientSize.Width - 80, 5, 75, 25);  // Set bounds of button.
                        pnlShowMessage.Controls.Add(btnOk);  //Finally Add button control on panel.
                    }
                    break;
                case MMessageBoxButtons.OKCancel:
                    {
                        Button btnOk = new Button();
                        btnOk.Text = MMessageBoxButtonText.OK;
                        btnOk.DialogResult = DialogResult.OK;
                        btnOk.FlatStyle = FlatStyle.Standard;
                        btnOk.FlatAppearance.BorderSize = 0;
                        btnOk.SetBounds((pnlShowMessage.ClientSize.Width - 70), 5, 65, 25);
                        pnlShowMessage.Controls.Add(btnOk);

                        Button btnCancel = new Button();
                        btnCancel.Text = MMessageBoxButtonText.Cancel;
                        btnCancel.DialogResult = DialogResult.Cancel;
                        btnCancel.FlatStyle = FlatStyle.Standard;
                        btnCancel.FlatAppearance.BorderSize = 0;
                        btnCancel.SetBounds((pnlShowMessage.ClientSize.Width - (btnOk.ClientSize.Width + 5 + 80)), 5, 75, 25);
                        pnlShowMessage.Controls.Add(btnCancel);

                    }
                    break;
                case MMessageBoxButtons.YesNo:
                    {
                        Button btnNo = new Button();
                        btnNo.Text = MMessageBoxButtonText.No;
                        btnNo.DialogResult = DialogResult.No;
                        btnNo.FlatStyle = FlatStyle.Standard;
                        btnNo.FlatAppearance.BorderSize = 0;
                        btnNo.SetBounds((pnlShowMessage.ClientSize.Width - 70), 5, 65, 25);
                        pnlShowMessage.Controls.Add(btnNo);

                        Button btnYes = new Button();
                        btnYes.Text = MMessageBoxButtonText.Yes;
                        btnYes.DialogResult = DialogResult.Yes;
                        btnYes.FlatStyle = FlatStyle.Standard;
                        btnYes.FlatAppearance.BorderSize = 0;
                        btnYes.SetBounds((pnlShowMessage.ClientSize.Width - (btnNo.ClientSize.Width + 5 + 80)), 5, 75, 25);
                        pnlShowMessage.Controls.Add(btnYes);
                    }
                    break;
                case MMessageBoxButtons.YesNoCancel:
                    {
                        Button btnCancel = new Button();
                        btnCancel.Text = MMessageBoxButtonText.Cancel;
                        btnCancel.DialogResult = DialogResult.Cancel;
                        btnCancel.FlatStyle = FlatStyle.Standard;
                        btnCancel.FlatAppearance.BorderSize = 0;
                        btnCancel.SetBounds((pnlShowMessage.ClientSize.Width - 70), 5, 65, 25);
                        pnlShowMessage.Controls.Add(btnCancel);

                        Button btnNo = new Button();
                        btnNo.Text = MMessageBoxButtonText.No;
                        btnNo.DialogResult = DialogResult.No;
                        btnNo.FlatStyle = FlatStyle.Standard;
                        btnNo.FlatAppearance.BorderSize = 0;
                        btnNo.SetBounds((pnlShowMessage.ClientSize.Width - (btnCancel.ClientSize.Width + 5 + 80)), 5, 75, 25);
                        pnlShowMessage.Controls.Add(btnNo);

                        Button btnYes = new Button();
                        btnYes.Text = MMessageBoxButtonText.Yes;
                        btnYes.DialogResult = DialogResult.No;
                        btnYes.FlatStyle = FlatStyle.Standard;
                        btnYes.FlatAppearance.BorderSize = 0;
                        btnYes.SetBounds((pnlShowMessage.ClientSize.Width - (btnCancel.ClientSize.Width + btnNo.ClientSize.Width + 10 + 80)), 5, 75, 25);
                        pnlShowMessage.Controls.Add(btnYes);
                    }
                    break;
            }
        }

        public static DialogResult Show(IWin32Window parentForm, string messageText)
        {
            MessageBoxButtons buttons;
            UpdateButtonText(MMessageBoxButtons.OK, out buttons);
            MessageBoxManager.Register();
            var messageBoxIcon = GetMessageBoxIcon(MMessageBoxIcon.Information);
            var result = MessageBox.Show(parentForm, messageText, "", buttons, messageBoxIcon);
            MessageBoxManager.Unregister();
            return result;

//            MMessageBox mMessage = new MMessageBox();
//            mMessage.setMessage(messageText);
//            mMessage.addIconImage(MMessageBoxIcon.Information);
//            mMessage.addButton(MMessageBoxButtons.OK);
//            return mMessage.ShowDialog(parentForm);
        }

        public static DialogResult Show(IWin32Window parentForm, string messageText, string messageTitle)
        {
            MessageBoxButtons buttons;
            UpdateButtonText(MMessageBoxButtons.OK, out buttons);
            MessageBoxManager.Register();
            var messageBoxIcon = GetMessageBoxIcon(MMessageBoxIcon.Information);
            var result = MessageBox.Show(parentForm, messageText, messageTitle, buttons, messageBoxIcon);
            MessageBoxManager.Unregister();
            return result;

//            MMessageBox mMessage = new MMessageBox();
//            mMessage.Text = messageTitle;
//            mMessage.setMessage(messageText);
//            mMessage.addIconImage(MMessageBoxIcon.Information);
//            mMessage.addButton(MMessageBoxButtons.OK);
//            return mMessage.ShowDialog(parentForm);
        }

        public static DialogResult Show(IWin32Window parentForm, string messageText, string messageTitle, MMessageBoxButtons messageButton, MMessageBoxIcon messageIcon)
        {
            MessageBoxButtons buttons;
            UpdateButtonText(messageButton, out buttons);
            MessageBoxManager.Register();
            var messageBoxIcon = GetMessageBoxIcon(messageIcon);
            var result = MessageBox.Show(parentForm, messageText, messageTitle, buttons, messageBoxIcon);
            MessageBoxManager.Unregister();
            return result;

//            MMessageBox mMessage = new MMessageBox();
//            mMessage.setMessage(messageText);
//            mMessage.Text = messageTitle;
//            mMessage.addButton(messageButton);
//            mMessage.addIconImage(messageIcon);
//            return mMessage.ShowDialog(parentForm);
        }

        private static MessageBoxIcon GetMessageBoxIcon(MMessageBoxIcon messageIcon)
        {
            MessageBoxIcon icon;
            switch (messageIcon)
            {
                case MMessageBoxIcon.Information:
                    icon = MessageBoxIcon.Information;
                    break;
                case MMessageBoxIcon.Warning:
                    icon = MessageBoxIcon.Warning;
                    break;
                case MMessageBoxIcon.Error:
                    icon = MessageBoxIcon.Error;
                    break;
                case MMessageBoxIcon.Question:
                    icon = MessageBoxIcon.Question;
                    break;
                default:
                    icon = MessageBoxIcon.Information;
                    break;
            }
            return icon;
        }

        private static void UpdateButtonText(MMessageBoxButtons messageButton, out MessageBoxButtons buttons)
        {
            switch (messageButton)
            {
                case MMessageBoxButtons.OK:
                    MessageBoxManager.OK = MMessageBoxButtonText.OK;
                    buttons = MessageBoxButtons.OK;
                    break;
                case MMessageBoxButtons.OKCancel:
                    MessageBoxManager.OK = MMessageBoxButtonText.OK;
                    MessageBoxManager.Cancel = MMessageBoxButtonText.Cancel;
                    buttons = MessageBoxButtons.OKCancel;
                    break;
                case MMessageBoxButtons.YesNo:
                    MessageBoxManager.Yes = MMessageBoxButtonText.Yes;
                    MessageBoxManager.No = MMessageBoxButtonText.No;
                    buttons = MessageBoxButtons.YesNo;
                    break;
                case MMessageBoxButtons.YesNoCancel:
                    MessageBoxManager.Yes = MMessageBoxButtonText.Yes;
                    MessageBoxManager.No = MMessageBoxButtonText.No;
                    MessageBoxManager.Cancel = MMessageBoxButtonText.Cancel;
                    buttons = MessageBoxButtons.YesNoCancel;
                    break;
                default:
                    buttons = MessageBoxButtons.OK;
                    break;
            }
        }

        /// <summary>
        /// We can use this method to add image on message box.
        /// I had taken all images in ImageList control so that
        /// I can eaily add images. Image is displayed in 
        /// PictureBox control.
        /// </summary>
        /// <param name="MessageIcon">Type of image to be displayed.</param>
        private void addIconImage(MMessageBoxIcon MessageIcon)
        {
            switch (MessageIcon)
            {
                case MMessageBoxIcon.Error:
                    pictureBox1.Image = imageList1.Images["Error"];  //Error is key name in imagelist control which uniqly identified images in ImageList control.
                    break;
                case MMessageBoxIcon.Information:
                    pictureBox1.Image = imageList1.Images["Information"];
                    break;
                case MMessageBoxIcon.Question:
                    pictureBox1.Image = imageList1.Images["Question"];
                    break;
                case MMessageBoxIcon.Warning:
                    pictureBox1.Image = imageList1.Images["Warning"];
                    break;
            }
        }
        #endregion
    }
    #region "defines some enums for MMessageBox"
    public enum MMessageBoxIcon
    {
        Error,
        Warning,
        Information,
        Question,
    }
    public enum MMessageBoxButtons
    {
        OK,
        YesNo,
        YesNoCancel,
        OKCancel
    }

    public class MMessageBoxButtonText
    {
        public const String Yes = "Có";
        public const String No = "Không";
        public const String Cancel = "Hủy bỏ";
        public const String OK = "Đồng ý";
    }
    #endregion
}
