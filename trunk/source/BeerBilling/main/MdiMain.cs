using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using BeerBilling.presenter.kho;
using BeerBilling.presenter.billing;
using BeerBilling.presenter.menu;
using BeerBilling.presenter.statistic;
using BeerBilling.presenter.user;
using BeerBilling.util;
using BeerBilling.view;
using core_lib.common;
using mcontrol;

namespace BeerBilling.main
{
    public partial class MdiMain : Form
    {
        private bool _isFirstRun;
        private IDanhSachUser _danhSachUser = new DanhSachUserImpl();
        private bool _hideMessage;
        private bool _loginSuccess;

        public MdiMain()
        {
            InitializeComponent();
        }

        public bool LoginSuccess
        {
            get { return _loginSuccess; }
            set { _loginSuccess = value; }
        }

        private void mnuThoat_Click(object sender, System.EventArgs e)
        {
            var dr = MMessageBox.Show(this, "Bạn có muốn thoát khỏi chương trình?", "Cảnh báo"
                                          , MMessageBoxButtons.YesNo, MMessageBoxIcon.Question);
            if (DialogResult.Yes == dr)
            {
                OnCancelLogin(null, null);
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            toolStripStatusLabelTimer.Text = " |<Thời gian: "
                                        + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ">|";
        }

        private void MdiMain_Load(object sender, EventArgs e)
        {
            RefreshLoginInfomation();

            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void mnuNhapKho_Click(object sender, EventArgs e)
        {
            NhapXuatKho nhapKhoFrm = new NhapXuatKho();
            nhapKhoFrm.MdiParent = this;
            nhapKhoFrm.Show();
        }

        private void mnuNhapHoaDon_Click(object sender, EventArgs e)
        {
            BillingProcessing billingProcessingFrm = new BillingProcessing();
            billingProcessingFrm.MdiParent = this;
            billingProcessingFrm.Show();
        }

        private void mnuXuatHoaDon_Click(object sender, EventArgs e)
        {
            NhapXuatKho nhapKhoFrm = new NhapXuatKho();
            nhapKhoFrm.MdiParent = this;
            nhapKhoFrm.Show();
        }

        private void mnuQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            BillingManagement billingManagementFrm = new BillingManagement();
            billingManagementFrm.MdiParent = this;
            billingManagementFrm.Show();
        }

        private void mnuQuanLyThucDon_Click(object sender, EventArgs e)
        {
            MenuManagement menuManagementFrm = new MenuManagement();
            menuManagementFrm.MdiParent = this;
            menuManagementFrm.Show();
        }

        private void mnuThongKeTonKho_Click(object sender, EventArgs e)
        {
            ThongKeTonKho thongKeTonKhoFrm = new ThongKeTonKho();
            thongKeTonKhoFrm.MdiParent = this;
            thongKeTonKhoFrm.Show();
        }

        private void mnuThongKeBanHang_Click(object sender, EventArgs e)
        {
            ThongKeDoanhSoBanHang thongKeDoanhSoBanHangFrm = new ThongKeDoanhSoBanHang();
            thongKeDoanhSoBanHangFrm.MdiParent = this;
            thongKeDoanhSoBanHangFrm.Show();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            ShowFormDangNhap();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            var frm = new FrmDoiMatKhau();
            frm.ShowDialog(this);
        }

        public void ShowFormDangNhap()
        {
            ResetMenuItemStatus();
            var frm = new FrmDangNhap();
            frm.AddCancelHander(new EventHandler(OnCancelLogin));
            frm.AddSuccessHander(new EventHandler(OnSuccessLogin));
            if (_isFirstRun)
            {
                frm.ShowInTaskbar = true;
                _isFirstRun = false;
            }
            frm.ShowDialog(this);
        }

        private void OnCancelLogin(object sender, EventArgs e)
        {
            try
            {
                _hideMessage = true;
                _loginSuccess = false;
                if (sender == null)
                    Close();
                else
                {
                    if (!_isFirstRun)
                    {
                        Application.Exit();
                    }
                }
            }
            catch { }
        }

        private void OnSuccessLogin(object sender, EventArgs e)
        {
            mnuDangNhap.Text = "&1. Đăng xuất";
            mnuDoiMatKhau.Available = true;
            UpdateMenuItemsStatus(ThamSo.UserRoleList);
            RefreshLoginInfomation();
            Show();
            BringToFront();
            _loginSuccess = true;
        }

        private void RefreshLoginInfomation()
        {
            toolStripStatusLabel1.Text = "Người sử dụng: " + _danhSachUser.GetCurrentTenNsd();
        }

        private void ResetMenuItemStatus()
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
            int i = 1;
            mnuDangNhap.Text = "&" + (i++) + ". Đăng nhập";
            mnuThoat.Text = "&" + i + ". Thoát";
            mnuDoiMatKhau.Available = false;
            UpdateMenuItemsStatus(new List<string>());
        }

        private void InitMenuItemStatus(ICollection items)
        {
            foreach (ToolStripItem item in items)
            {
                item.Available = false;
            }
        }

        private void UpdateMenuItemsStatus(List<string> userRoleList)
        {
            var mapRoles = new Hashtable();
            var mapItems = new List<ToolStripItem>();
            mapItems.Add(mnuQuanTriNguoiDung);
            mapItems.Add(mnuNhapKho);
            mapItems.Add(mnuXuatKho);
            mapItems.Add(mnuNhapHoaDon);
            mapItems.Add(mnuQuanLyHoaDon);
            mapItems.Add(mnuQuanLyThucDon);
            mapItems.Add(mnuThongKeTonKho);
            mapItems.Add(mnuThongKeBanHang);
            mapRoles.Add(ConstUtil.ADMIN, mapItems);

            mapItems = new List<ToolStripItem>();
            mapItems.Add(mnuNhapKho);
            mapItems.Add(mnuXuatKho);
            mapRoles.Add(ConstUtil.QLKH, mapItems);

            mapItems = new List<ToolStripItem>();
            mapItems.Add(mnuNhapHoaDon);
            mapItems.Add(mnuQuanLyHoaDon);
            mapItems.Add(mnuQuanLyThucDon);
            mapRoles.Add(ConstUtil.QLHD, mapItems);

            InitMenuItemStatus(mapItems);
            foreach (string userRole in userRoleList)
            {
                List<ToolStripItem> allItems = (List<ToolStripItem>) mapRoles[userRole.ToUpper()];
                if (allItems != null)
                {
                    foreach (var item in allItems)
                    {
                        ((ToolStripItem)item).Available = true;
                    }
                }
            }
            RefreshMenuGroupStatus();
        }

        private bool UpdateItemIndex(ToolStripMenuItem item, int index)
        {
            if (item.Available)
            {
                var text = item.Text.Trim();
                int found = text.IndexOf(". ");
                if (found != -1)
                {
                    text = text.Substring(found);
                }
                item.Text = GetShortcutString(index) + text;
                return true;
            }
            item.ShortcutKeys = Keys.None;
            return false;
        }

        private string GetShortcutString(int index)
        {
            var result = "";
            do
            {
                if (String.IsNullOrEmpty(result))
                    result = "&" + index % 10 + result;
                else
                    result = index % 10 + result;
                index = index / 10;
            } while (index >= 10);
            return result;
        }

        private void RefreshTextMenuItems(ToolStripMenuItem parentMenuItem)
        {
            int i = 1;
            foreach (var item in parentMenuItem.DropDownItems)
            {
                if (item.GetType().Equals(typeof(ToolStripMenuItem)) &&
                    UpdateItemIndex(item as ToolStripMenuItem, i))
                    i++;
            }
        }

        private void UpdateOneMenuGroupStatus(ToolStripMenuItem parentMenuItem)
        {
            foreach (var item in parentMenuItem.DropDownItems)
            {
                if (item.GetType().Equals(typeof(ToolStripMenuItem)))
                {
                    if (((ToolStripMenuItem)item).Available)
                    {
                        parentMenuItem.Available = true;
                        return;
                    }
                }
            }
            parentMenuItem.Available = false;
        }

        private void UpdateToolStripSeparatorStatus(ToolStripMenuItem parentMenuItem)
        {
            Type sepType = typeof(ToolStripSeparator);
            Type previousType = null;
            ToolStripItem lastItem = null;
            foreach (var item in parentMenuItem.DropDownItems)
            {
                if (item.GetType().Equals(sepType))
                {
                    var sepItem = (ToolStripSeparator)item;
                    sepItem.Available = (previousType != null && !previousType.Equals(sepType));
                }
                if (((ToolStripItem)item).Available)
                {
                    previousType = item.GetType();
                    lastItem = (ToolStripItem)item;
                }
            }
            if (sepType.Equals(previousType) && lastItem != null)
            {
                lastItem.Available = false;
            }
        }

        private void RefreshMenuGroupStatus()
        {
            RefreshTextMenuItems(mnuQuanTri);
            UpdateOneMenuGroupStatus(mnuQuanTri);
            UpdateToolStripSeparatorStatus(mnuQuanTri);
            RefreshTextMenuItems(mnuChucNang);
            UpdateOneMenuGroupStatus(mnuChucNang);
            UpdateToolStripSeparatorStatus(mnuChucNang);
            RefreshTextMenuItems(mnuThongKe);
            UpdateOneMenuGroupStatus(mnuThongKe);
            UpdateToolStripSeparatorStatus(mnuThongKe);
            RefreshTextMenuItems(mnuTroGiup);
            UpdateOneMenuGroupStatus(mnuTroGiup);
            UpdateToolStripSeparatorStatus(mnuTroGiup);
        }

    }
}
