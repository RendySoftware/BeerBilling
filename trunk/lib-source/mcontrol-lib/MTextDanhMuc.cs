using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mcontrol
{

    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))] 
    public partial class MTextDanhMuc : UserControl
    {
        MyListBox myListBox;
        Hashtable hashtable = new Hashtable();
        public MTextDanhMuc()
        {
            InitializeComponent();

            Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize);
        }

        public MTextDanhMuc(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize);

        }
        public void CreateListBox(IContainer container, Form parent)
        {
            myListBox = new MyListBox(this, container,parent);
        }
        public void SetDataSource(List<MComboboxItem> items)
        {
            if (items == null) return;

            foreach (MComboboxItem mComboboxItem in items)
            {
                hashtable.Add(mComboboxItem.MValue, mComboboxItem.MDisplay);
            }

        }

        public event System.ComponentModel.CancelEventHandler NotInList;

        private bool _limitToList = true;
        private bool _inEditMode = false;

        [Category("Behavior")]
        public bool LimitToList
        {
            get { return _limitToList; }
            set { _limitToList = value; }
        }

        public new String Text
        {
            get { return txtDanhMuc.Text.Trim(); }
            set { txtDanhMuc.Text = value; }
        }

        private String selectedValue;
        public String SelectedValue
        {
            get
            {
                if (selectedValue != null) return selectedValue;

                IEnumerable<object> keys =
                    hashtable.Cast<DictionaryEntry>().Where(p => p.Value.ToString().Equals(Text)).Select(p => p.Key);
                if (keys.Count() == 0)
                    return null;
                return (String)keys.First();
            }
            set
            {
                selectedValue = value;
            }
        }
        protected void OnNotInList(CancelEventArgs e)
        {
            if (NotInList != null)
            {
                NotInList(this, e);
            }
        }

        private void txtDanhMuc_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Text))
            {
                return;
            }

            if (String.IsNullOrEmpty(SelectedValue))
            {
                myListBox.Show();
                return;
            }

            myListBox.Hide();
            base.OnLeave(e);
        }

        private void txtDanhMuc_KeyDown(object sender, KeyEventArgs e)
        {
            _inEditMode =
               (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete);

            if (e.KeyCode == Keys.Enter)
            {
                this.Text = myListBox.SelectedItem.ToString();
                myListBox.Hide();
            }
            if (e.KeyCode == Keys.Down)
            {
                TimKiem = false;
                myListBox.Focus();
                myListBox.SelectedIndex = 0;

            }
            if (e.KeyCode == Keys.Up)
            {
                TimKiem = false;
                myListBox.Focus();
                myListBox.SelectedIndex = myListBox.Items.Count - 1;
            }
        }

        private void txtDanhMuc_MouseClick(object sender, MouseEventArgs e)
        {         
                myListBox.Hide();
        }

        private void txtDanhMuc_TextChanged(object sender, EventArgs e)
        {
            if (!TimKiem)
            {
                TimKiem = true;
                return;
            }

            String tmpTextForSearch = this.Text.Trim();

            if (tmpTextForSearch.Equals(""))
            {
                myListBox.Hide();
                return;
            }

            if (hashtable.Count == 0) return;

            IEnumerable<object> values = hashtable.Cast<DictionaryEntry>().Where(p => ((String)p.Value).IndexOf(tmpTextForSearch, StringComparison.InvariantCultureIgnoreCase) >= 0).Select(p => p.Value);

            if (values.Count() > 0)
            {
                AddItemsToList(values);
            }
            else
            {
                // khong co item nao duoc tim thay
                HideListBox();
            }
        }

        private void HideListBox()
        {
            myListBox.Items.Clear();
            myListBox.Hide();
        }
        private void AddItemsToList(IEnumerable<object> values)
        {
            myListBox.Items.Clear();
            myListBox.AddRangeItems(values.ToArray());
            myListBox.SelectedIndex = 0;
            myListBox.Show();
        }

        private void AddAllItemsToList()
        {
            myListBox.Items.Clear();
            Object[] arrObj = new object[hashtable.Count];
            hashtable.Values.CopyTo(arrObj, 0);
            myListBox.AddRangeItems(arrObj);
            myListBox.SelectedIndex = 0;
            myListBox.Sorted = true;
            myListBox.Show();
        }

        private void txtDanhMuc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Text = myListBox.SelectedItem.ToString();
                myListBox.Hide();
            }
        }

        private void btnShowDanhMuc_Click(object sender, EventArgs e)
        {
            AddAllItemsToList();
        }
        private static bool TimKiem = true;
        private static int dem0 = 0;
        private static int dem1 = 0;

        private class MyListBox : MListBox
        {

            private MTextDanhMuc _mTextDanhMucRelationListBox;
            public MyListBox(MTextDanhMuc mTextDanhMucRelationListBox, IContainer container, Form parent)
            {
                this._mTextDanhMucRelationListBox = mTextDanhMucRelationListBox;
                Location = new Point(_mTextDanhMucRelationListBox.Parent.Left + this._mTextDanhMucRelationListBox.Left, _mTextDanhMucRelationListBox.Parent.Top + this._mTextDanhMucRelationListBox.Top + 3 + this._mTextDanhMucRelationListBox.Height);
                Size = new Size(this._mTextDanhMucRelationListBox.Width, 150);
                SelectionMode = SelectionMode.One;
                ScrollAlwaysVisible = true;
                Visible = false;
                // add listbox to form that is displayed below the textbox
                container.Add(this);
                parent.Controls.Add(this);
                this.BringToFront();
            }
            protected override void OnKeyDown(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    _mTextDanhMucRelationListBox.Text = SelectedItem.ToString();
                    Hide();
                }

                base.OnKeyDown(e);
            }
            protected override void OnEnter(EventArgs e)
            {
                base.OnEnter(e);
            }
            protected override void OnKeyUp(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Up)
                {
                    TimKiem = false;
                    if (dem0 == 1)
                    {
                        SelectedIndex = Items.Count - 1;
                        dem0 = 0;
                    }
                    if (SelectedIndex == 0) dem0 = 1;

                    this._mTextDanhMucRelationListBox.Text = SelectedItem.ToString();
                }
                if (e.KeyCode == Keys.Down)
                {
                    TimKiem = false;
                    if (dem1 == 1)
                    {
                        SelectedIndex = 0;
                        dem1 = 0;
                    }
                    if (SelectedIndex == Items.Count - 1) dem1 = 1;

                    this._mTextDanhMucRelationListBox.Text = SelectedItem.ToString();
                }
            }

            protected override void OnMouseUp(MouseEventArgs e)
            {
                this._mTextDanhMucRelationListBox.Text = SelectedItem.ToString();
                Hide();
            }
            public void AddRangeItems(object[] items)
            {
                Items.AddRange(items);
            }
        }
    }
}
