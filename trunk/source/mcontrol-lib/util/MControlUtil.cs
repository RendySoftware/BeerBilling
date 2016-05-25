using System.Collections.Generic;
using System.Windows.Forms;
using domain_lib.dto;

namespace mcontrol.util
{
    public class MControlUtil
    {
        public static void SetSelectedIndex(DataGridView grid, int selectedIndex, string selectedCellName)
        {
            grid.CurrentCell = grid.Rows[selectedIndex].Cells[selectedCellName];
            grid.Rows[selectedIndex].Selected = true;
        }

        public static string GetValueFromCombobox(MComboBox mComboBox)
        {
            return mComboBox.SelectedValue != null ? mComboBox.SelectedValue.ToString() : string.Empty;
        }

        public static string GetValueFromCombobox(MComboBox2 mComboBox)
        {
            return mComboBox.SelectedValue != null ? mComboBox.SelectedValue.ToString() : string.Empty;
        }

        public static string GetValueFromCombobox(ComboBox mComboBox)
        {
            return mComboBox.SelectedValue != null ? mComboBox.SelectedValue.ToString() : string.Empty;
        }

        public static void FillToComboBox(ComboBox cboControl, List<DanhMucDto> allDanhMucDto)
        {
            FillToComboBox(cboControl, allDanhMucDto, true, string.Empty, false);
        }

        public static void FillToComboBox(ComboBox cboControl, List<DanhMucDto> allDanhMucDto, bool includeEmpty)
        {
            FillToComboBox(cboControl, allDanhMucDto, includeEmpty, string.Empty, false);
        }

        public static void FillToComboBox(ComboBox cboControl, List<DanhMucDto> allDanhMucDto, bool includeEmpty, bool useMa)
        {
            FillToComboBox(cboControl, allDanhMucDto, includeEmpty, string.Empty, useMa);
        }

        public static void FillToComboBox(ComboBox cboControl, List<DanhMucDto> allDanhMucDto, string textDisplayDefault)
        {
            FillToComboBox(cboControl, allDanhMucDto, true, textDisplayDefault, false);
        }

        public static void FillToComboBox(ComboBox cboControl, List<DanhMucDto> allDanhMucDto, bool includeEmpty, string textDisplayDefault, bool useMa)
        {
            if (allDanhMucDto == null)
                return;

            List<MComboboxItem> item = new List<MComboboxItem>();
            if (includeEmpty)
                item.Add(new MComboboxItem(textDisplayDefault, string.Empty));
            foreach (DanhMucDto dto in allDanhMucDto)
            {
                if (useMa)
                    item.Add(new MComboboxItem(dto.Ten, dto.Ma));
                else
                    item.Add(new MComboboxItem(dto.Ten, dto.Id));
            }
            cboControl.DataSource = item;
            cboControl.DisplayMember = "MDisplay";
            cboControl.ValueMember = "MValue";
        }
    }
}
