using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using domain_lib.dto;
using core_lib.common;
using mcontrol.util;

namespace mcontrol.LOV
{
    public partial class MFullLov : Form
    {
        private const string MA_KEY = "MA";
        private const string TEN_KEY = "TEN";
        private const string ID_KEY = "ID";
        private List<DanhMucDto> _allDto;
        private DanhMucDto _selectedDto;
        public MFullLov()
        {
            InitializeComponent();
            _allDto = new List<DanhMucDto>();
        }
        public MFullLov(List<DanhMucDto> allDto)
        {
            InitializeComponent();
            _allDto = allDto;
        }

        public void SetTen(string ten)
        {
            txtTen.Text = ten;
            DoSearchInLov();
        }

        public void SetMa(string ma)
        {
            txtMa.Text = ma;
            DoSearchInLov();
        }

        private void InitDataGridView(List<DanhMucDto> allDto)
        {
            int selectedIndex = dgvLov.CurrentRow == null ? 0 : dgvLov.CurrentRow.Index;
            dgvLov.Rows.Clear();
            foreach (var dto in allDto)
            {
                OnAddOneRow(dgvLov.Rows, dto);
            }
            if (selectedIndex >= allDto.Count)
                selectedIndex = allDto.Count - 1;
            if (selectedIndex >= 0)
                MControlUtil.SetSelectedIndex(dgvLov, selectedIndex, "MA");
        }

        private void OnAddOneRow(DataGridViewRowCollection rows, DanhMucDto dto)
        {
            int index = rows.Add();
            rows[index].Cells[MA_KEY].Value = dto.Ma;
            rows[index].Cells[TEN_KEY].Value = dto.Ten;
            rows[index].Cells[ID_KEY].Value = dto.Id;
        }

        public DanhMucDto SelectedDto
        {
            get { return _selectedDto; }
        }

        private void txtMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoSearchInLov();
            }
        }

        private void txtMa_Leave(object sender, EventArgs e)
        {
            DoSearchInLov();
        }

        private void txtTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoSearchInLov();
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            DoSearchInLov();
        }

        private void DoSearchInLov()
        {
            string ma = txtMa.Text.Trim();
            string ten = txtTen.Text.Trim();
            if (!String.IsNullOrEmpty(ma) || !String.IsNullOrEmpty(ten))
            {
                List<DanhMucDto> allDtoByMa = new List<DanhMucDto>();
                List<DanhMucDto> allDtoByTen = new List<DanhMucDto>();
                if (!String.IsNullOrEmpty(ma))
                    allDtoByMa = OnSearch(ma, MA_KEY);
                if (!String.IsNullOrEmpty(ten))
                    allDtoByTen = OnSearch(ten, TEN_KEY);
                List<DanhMucDto> allDto = MergeDanhMucDto(allDtoByMa, allDtoByTen);
                InitDataGridView(allDto);
            }
            else
            {
                if (dgvLov.Rows.Count != _allDto.Count)
                    InitDataGridView(_allDto);
            }
        }

        private List<DanhMucDto> MergeDanhMucDto(List<DanhMucDto> oneList, List<DanhMucDto> otherList)
        {
            if (oneList.Count == 0)
                return otherList;
            if (otherList.Count == 0)
                return oneList;
            List<DanhMucDto> result = new List<DanhMucDto>();
            Hashtable mapOne = new Hashtable();
            foreach (var dto in oneList)
            {
                mapOne.Add(dto.Id, dto);
            }
            foreach (var dto in otherList)
            {
                if (!mapOne.ContainsKey(dto.Id))
                    result.Add(dto);
            }
            return result;
        }

        private List<DanhMucDto> OnSearch(string searchKey, string keyType)
        {
            var itemsForTable = new List<DanhMucDto>();
            _allDto.FindAll(
                delegate(DanhMucDto dto)
                {
                    bool found = false;
                    int indexOf;
                    switch (keyType)
                    {
                        case MA_KEY:
                            indexOf = dto.Ma.IndexOf(searchKey, StringComparison.InvariantCultureIgnoreCase);
                            if (indexOf >= 0)
                            {
                                found = true;
                                itemsForTable.Add(dto);
                            }
                            break;
                        case TEN_KEY:

                            indexOf = VnStringHelper.toEnglish(dto.Ten).IndexOf(VnStringHelper.toEnglish(searchKey), StringComparison.InvariantCultureIgnoreCase);
                            if (indexOf >= 0)
                            {
                                found = true;
                                itemsForTable.Add(dto);
                            }
                            break;
                        default:
                            break;
                    }
                    return found;
                });
            return itemsForTable;
        }

        private void dgvLov_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OnSelectRow();
        }

        private void OnSelectRow()
        {
            if (dgvLov.CurrentRow != null)
            {
                _selectedDto = new DanhMucDto();
                _selectedDto.Id = (string) dgvLov.CurrentRow.Cells[ID_KEY].Value;
                _selectedDto.Ma = (string) dgvLov.CurrentRow.Cells[MA_KEY].Value;
                _selectedDto.Ten = (string) dgvLov.CurrentRow.Cells[TEN_KEY].Value;
                DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void dgvLov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OnSelectRow();
            }
        }

        private void MFullLov_Load(object sender, EventArgs e)
        {
            InitDataGridView(_allDto);
        }
    }
}
