using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using domain_lib.dto;
using core_lib.common;

namespace mcontrol.LOV
{
    public partial class MLovTextField : UserControl
    {
        private List<DanhMucDto> _allDto;
        private DanhMucDto _selectedDto;
        private EventHandler _validateEvent;
        public MLovTextField()
        {
            InitializeComponent();
            _allDto = new List<DanhMucDto>();
        }

        public EventHandler ValidateEvent
        {
            get { return _validateEvent; }
            set { _validateEvent = value; }
        }

        public void SetAllDto(List<DanhMucDto> allDto)
        {
            _allDto = allDto;
        }

        public new Size Size 
        { 
            get { return new Size(Width, Height); }
            set
            {
                Width = value.Width;
                Height = value.Height;
                txtSearchKey.Size = new Size(Width - Height - 5, Height);
                btnHelp.Size = new Size(Height + 5, Height);
                btnHelp.Location = new Point(Width - Height - 5, 0);
            }
        }

        public bool ReadOnly
        {
            get { return txtSearchKey.ReadOnly; }
            set 
            { 
                txtSearchKey.ReadOnly = value;
                btnHelp.Enabled = !value;
            }
        }

        private void txtSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoSearchKey();
                if (!ReadOnly && _validateEvent != null)
                    _validateEvent(sender, e);
            }
        }

        private void DoSearchKey()
        {
            var searchKey = txtSearchKey.Text.Trim();
            if (!String.IsNullOrEmpty(searchKey))
                OnSearch(searchKey);
        }

        private void OnSearch(string searchKey)
        {
            if (_allDto.Count == 0) return;

            List<DanhMucDto> itemsForListBox = new List<DanhMucDto>();
            bool isTimTheoTen = false;

            _allDto.FindAll(
                delegate(DanhMucDto dto)
                {
                    bool found = false;
                    if (dto.Ma.ToUpper().Equals(searchKey.ToUpper()))
                    {
                        found = true;
                        itemsForListBox.Add(dto);
                    }
                    return found;
                });

            if (itemsForListBox.Count == 0)
            {
                _allDto.FindAll(
                    delegate(DanhMucDto dto)
                    {
                        bool found = false;
                        if (VnStringHelper.toEnglish(dto.Ten.ToUpper()).Equals(VnStringHelper.toEnglish(searchKey).ToUpper()))
                        {
                            found = true;
                            itemsForListBox.Add(dto);
                        }
                        return found;
                    });
                isTimTheoTen = true;
            }

            if (itemsForListBox.Count == 1)
            {
                _selectedDto = itemsForListBox[0];
                txtSearchKey.Text = _selectedDto.Ten;
            } else if (itemsForListBox.Count > 1)
            {
                OnShowLov(txtSearchKey.Text.Trim(), isTimTheoTen);
            }
            else
            {
                _selectedDto = null;
            }
        }

        private void OnShowLov(string searchKey, bool isTimTheoTen)
        {
            if (ReadOnly)
                return;
            var lov = new MFullLov(_allDto);
            if (isTimTheoTen)
                lov.SetTen(searchKey);
            else
                lov.SetMa(searchKey);
            if (lov.ShowDialog(this) == DialogResult.OK && 
                lov.SelectedDto != null)
            {
                _selectedDto = lov.SelectedDto;
                txtSearchKey.Text = _selectedDto.Ten;
                if (_validateEvent != null)
                    _validateEvent(null, null);
            }
            else
            {
                _selectedDto = null;
            }
        }

        public DanhMucDto SelectedDto
        {
            get { return _selectedDto; }
        }

        private void txtSearchKey_Leave(object sender, EventArgs e)
        {
            DoSearchKey();
            if (!ReadOnly && _validateEvent != null)
                _validateEvent(sender, e);
        }

        public override string Text
        {
            get { return txtSearchKey.Text.Trim(); }
            set
            {
                txtSearchKey.Text = value;
                DoSearchKey();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            OnShowLov("", true);
        }
    }
}
