using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MComboBox2 : ComboBox
    {
        public MComboBox2()
        {
            InitializeComponent();
            Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize);
            this.FlatStyle = FlatStyle.System;
            AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        public MComboBox2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.FlatStyle = FlatStyle.System;
            Font = new Font(MComponentConst.TextBoxFontName, MComponentConst.TextBoxFontSize);
            //AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //AutoCompleteSource = AutoCompleteSource.ListItems;
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

        protected void OnNotInList (CancelEventArgs e)
        {
            if (NotInList != null)
            {
                NotInList(this, e);
            }
        }

//        protected override void OnLeave(EventArgs eventArgs)
//        {
//            if (String.IsNullOrEmpty(Text))
//            {   
//                return;
//            }
//
//            if (SelectedValue == null)
//            {
//                Focus();
//                return;
//            }
//           
//            if (String.IsNullOrEmpty(SelectedValue.ToString()))
//            {   
//                Focus();
//                
//            }
//            base.OnLeave(eventArgs);    
//        }
        
        protected override void OnKeyDown(KeyEventArgs e)
        {
            _inEditMode = 
                (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete);
            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            //_inEditMode = (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete && e.KeyCode != Keys.Tab 
            //    && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left 
            //    && e.KeyCode != Keys.Right);

            //if (_inEditMode)
            //{
            //    string input = Text;

            //    int index = FindString(input);

            //    if (index >= 0)
            //    {
            //        SelectedIndex = index;

            //        if (SelectedText.Length > 0)
            //            Select(Text.Length - SelectedText.Length, Text.Length);
            //        else
            //            Select(input.Length, Text.Length);
            //    }
            //}
            base.OnKeyUp(e);
        }
    }
}
