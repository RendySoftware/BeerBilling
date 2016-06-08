using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mcontrol;
namespace mcontrol.LOV
{
    public partial class LOV : Form
    {
        List<MComboboxItem> items = new List<MComboboxItem>();
        public LOV()
        {
            InitializeComponent();
        }
        public LOV(int nWidth, int height)
        {
            InitializeComponent();
            Width = nWidth;
            MinimumSize = new Size(Width,Height);
        }
        #region "REM"
        private void mComboBox21_TextChanged(object sender, EventArgs e)
        {
            //var items = mComboBox21.GetListItems();
            //if (items.Count == 0) return;
            //mListBox1.Items.Clear();
            //mListBox1.Show();
            //foreach (string item in items)
            //    mListBox1.Items.Add(item);
            //mListBox1.SelectedIndex = 0;
        }

        private void mComboBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                mListBox1.Focus();
                //if (mListBox1.SelectedIndex >0)
                //{
                //    mListBox1.SelectedIndex--;
                //    mComboBox21.Text = mListBox1.Text.Trim();    
                //}

            }
            if (e.KeyCode == Keys.Down)
            {
                //mListBox1.();
                //if (mListBox1.SelectedIndex < mListBox1.Items.Count)
                //{
                //    mListBox1.SelectedIndex++;
                //    mComboBox21.Text = mListBox1.Text.Trim();
                //}
            }

        }

        private void mComboBox21_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                mListBox1.Hide();
            }

        }
        #endregion "REM"
        #region "KHAI BAO CÁC SỰ KIỆN XỬ LÝ"
        private void Form1_Load(object sender, EventArgs e)
        {           
        }
        private void mListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (mListBox1.SelectedItem != null)
            {
                MComboboxItem mComboboxItem = mListBox1.SelectedItem as MComboboxItem;
//                     MMessageBox.Show(this, "Bạn chọn item: " + mComboboxItem.MDisplay +" với value: " + mComboboxItem.MValue, 
//                         "Thông báo", MMessageBoxButtons.OK, MMessageBoxIcon.Information);              
                mTextBox1.Text = mComboboxItem.MDisplay;
                mListBox1.Hide();
                DialogResult = DialogResult.OK;
            }
        }

        private void mTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!TimKiem) return;
            if (items.Count == 0) return;
            bool isFounded = false;

            List<int> lstIndexOfItem = new List<int>();
            List<MComboboxItem> itemsForListBox = new List<MComboboxItem>();

            String tmpTextForSearch = mTextBox1.Text.Trim();

            items.FindAll(
                delegate(MComboboxItem mComboboxItem)
                {
                    int indexOf = -1;
                    //startswith = str.StartsWith(intellisenseBuffer, false, null);
                    indexOf = mComboboxItem.MDisplay.IndexOf(tmpTextForSearch, StringComparison.InvariantCultureIgnoreCase);
                    bool found = false;
                    if (indexOf >= 0)
                    {
                        found = true;
                        lstIndexOfItem.Add(indexOf);
                        itemsForListBox.Add(mComboboxItem);
                    }
                    return found;
                });


            if (itemsForListBox.Count > 0)
            {
                isFounded = true;
                mListBox1.DataSource = itemsForListBox;
                mListBox1.DisplayMember = "MDisplay";
                mListBox1.ValueMember = "MValue";
                mListBox1.Show();
            }
            if (isFounded == false)
            {
                tmpTextForSearch = "";
            }
        }
        private void mTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                TimKiem = false;
                mListBox1.Focus();
                mListBox1.SelectedIndex = mListBox1.Items.Count - 1;

            }
            if (e.KeyCode == Keys.Down)
            {
                TimKiem = false;
                mListBox1.Focus();
                mListBox1.SelectedIndex = 0;

            }
            if (e.KeyCode == Keys.Enter)
            {
                MComboboxItem mComboboxItem = mListBox1.SelectedItem as MComboboxItem;
                mTextBox1.Text = mComboboxItem.MDisplay;
                mListBox1.Hide();
                DialogResult = DialogResult.OK;
            }
        }

        private void mListBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MComboboxItem mComboboxItem = mListBox1.SelectedItem as MComboboxItem;
                mTextBox1.Text = mComboboxItem.MDisplay;
                mListBox1.Hide();
                DialogResult = DialogResult.OK;
            }
        }

        private void mTextBox1_Enter(object sender, EventArgs e)
        {
            TimKiem = true;
        }

        private int dem0 = 0;
        private int dem1 = 0;
        private void mListBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                TimKiem = false;
                if (dem0 == 1)
                {
                    mListBox1.SelectedIndex = mListBox1.Items.Count - 1;
                    dem0 = 0;
                }
                if (mListBox1.SelectedIndex == 0) dem0 = 1;
                MComboboxItem mComboboxItem = mListBox1.SelectedItem as MComboboxItem;
                mTextBox1.Text = mComboboxItem.MDisplay;
            }
            if (e.KeyCode == Keys.Down)
            {
                TimKiem = false;
                if (dem1 == 1)
                {
                    mListBox1.SelectedIndex = 0;
                    dem1 = 0;
                }
                if (mListBox1.SelectedIndex == mListBox1.Items.Count - 1) dem1 = 1;

                MComboboxItem mComboboxItem = mListBox1.SelectedItem as MComboboxItem;
                mTextBox1.Text = mComboboxItem.MDisplay;
            }

        }
       
        #endregion

        #region "CÁC HÀM XỬ LÝ BỔ SUNG CHO LOV"

        public void SetDataSource(object dataSource, String displayMember, String valueMember)
        {
            mListBox1.DataSource = dataSource;
            mListBox1.DisplayMember = displayMember;
            mListBox1.ValueMember = valueMember;
        }
        public String GetMDisPlay()
        {
            return mTextBox1.Text.Trim();
        }

        private bool TimKiem = false;
       
        public void ShowLov(int X, int Y, ref MComboBox comboBox)
        {
            int lovLeft = X + comboBox.Left + 5;
            int lovTop = 5 + Y + comboBox.Top + comboBox.Height * 2;
            MoveWinDowHelper.MoveWindow2(this.Handle, lovLeft, lovTop, true);

            if (ShowDialog() == DialogResult.OK)
            {
                comboBox.Text = GetMDisPlay();
            }
        }

        #endregion

        private void LOV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
