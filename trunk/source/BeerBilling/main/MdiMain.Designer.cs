namespace BeerBilling.main
{
    partial class MdiMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuQuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanTriNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXuatKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuuXuatNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNhapHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuanLyThucDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanTri,
            this.mnuChucNang,
            this.mnuThongKe,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuQuanTri
            // 
            this.mnuQuanTri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDoiMatKhau,
            this.mnuQuanTriNguoiDung,
            this.thoátToolStripMenuItem,
            this.mnuThoat});
            this.mnuQuanTri.Name = "mnuQuanTri";
            this.mnuQuanTri.Size = new System.Drawing.Size(62, 20);
            this.mnuQuanTri.Text = "Quản trị";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(194, 22);
            this.mnuDangNhap.Text = "&1. Đăng xuất";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(194, 22);
            this.mnuDoiMatKhau.Text = "&2. Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuQuanTriNguoiDung
            // 
            this.mnuQuanTriNguoiDung.Name = "mnuQuanTriNguoiDung";
            this.mnuQuanTriNguoiDung.Size = new System.Drawing.Size(194, 22);
            this.mnuQuanTriNguoiDung.Text = "&3. Quản trị người dùng";
            this.mnuQuanTriNguoiDung.Click += new System.EventHandler(this.mnuQuanTriNguoiDung_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(191, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(194, 22);
            this.mnuThoat.Text = "&4. Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapKho,
            this.mnuXuatKho,
            this.mnuTraCuuXuatNhap,
            this.toolStripSeparator1,
            this.mnuNhapHoaDon,
            this.mnuQuanLyHoaDon,
            this.toolStripSeparator2,
            this.mnuQuanLyThucDon});
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(77, 20);
            this.mnuChucNang.Text = "Chức năng";
            // 
            // mnuNhapKho
            // 
            this.mnuNhapKho.Name = "mnuNhapKho";
            this.mnuNhapKho.Size = new System.Drawing.Size(209, 22);
            this.mnuNhapKho.Text = "&1. Nhập kho";
            this.mnuNhapKho.Click += new System.EventHandler(this.mnuNhapKho_Click);
            // 
            // mnuXuatKho
            // 
            this.mnuXuatKho.Name = "mnuXuatKho";
            this.mnuXuatKho.Size = new System.Drawing.Size(209, 22);
            this.mnuXuatKho.Text = "&2. Xuất kho";
            this.mnuXuatKho.Click += new System.EventHandler(this.mnuXuatHoaDon_Click);
            // 
            // mnuTraCuuXuatNhap
            // 
            this.mnuTraCuuXuatNhap.Name = "mnuTraCuuXuatNhap";
            this.mnuTraCuuXuatNhap.Size = new System.Drawing.Size(209, 22);
            this.mnuTraCuuXuatNhap.Text = "&3. Tra cứu Xuất/Nhập kho";
            this.mnuTraCuuXuatNhap.Click += new System.EventHandler(this.mnuTraCuuXuatNhap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuNhapHoaDon
            // 
            this.mnuNhapHoaDon.Name = "mnuNhapHoaDon";
            this.mnuNhapHoaDon.Size = new System.Drawing.Size(209, 22);
            this.mnuNhapHoaDon.Text = "&4. Nhập hóa đơn";
            this.mnuNhapHoaDon.Click += new System.EventHandler(this.mnuNhapHoaDon_Click);
            // 
            // mnuQuanLyHoaDon
            // 
            this.mnuQuanLyHoaDon.Name = "mnuQuanLyHoaDon";
            this.mnuQuanLyHoaDon.Size = new System.Drawing.Size(209, 22);
            this.mnuQuanLyHoaDon.Text = "&5. Quản lý hóa đơn";
            this.mnuQuanLyHoaDon.Click += new System.EventHandler(this.mnuQuanLyHoaDon_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuQuanLyThucDon
            // 
            this.mnuQuanLyThucDon.Name = "mnuQuanLyThucDon";
            this.mnuQuanLyThucDon.Size = new System.Drawing.Size(209, 22);
            this.mnuQuanLyThucDon.Text = "&6. Quản lý thực đơn";
            this.mnuQuanLyThucDon.Click += new System.EventHandler(this.mnuQuanLyThucDon_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKeTonKho,
            this.mnuThongKeBanHang});
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(69, 20);
            this.mnuThongKe.Text = "Thống kê";
            // 
            // mnuThongKeTonKho
            // 
            this.mnuThongKeTonKho.Name = "mnuThongKeTonKho";
            this.mnuThongKeTonKho.Size = new System.Drawing.Size(189, 22);
            this.mnuThongKeTonKho.Text = "&1. Thống kê tồn kho";
            this.mnuThongKeTonKho.Click += new System.EventHandler(this.mnuThongKeTonKho_Click);
            // 
            // mnuThongKeBanHang
            // 
            this.mnuThongKeBanHang.Name = "mnuThongKeBanHang";
            this.mnuThongKeBanHang.Size = new System.Drawing.Size(189, 22);
            this.mnuThongKeBanHang.Text = "&2. Thống kê bán hàng";
            this.mnuThongKeBanHang.Click += new System.EventHandler(this.mnuThongKeBanHang_Click);
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(63, 20);
            this.mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(199, 22);
            this.mnuAbout.Text = "&1. Thông tin phần mềm";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelTimer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 701);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelTimer
            // 
            this.toolStripStatusLabelTimer.Name = "toolStripStatusLabelTimer";
            this.toolStripStatusLabelTimer.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 723);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán bia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MdiMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanTri;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanTriNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripSeparator thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapKho;
        private System.Windows.Forms.ToolStripMenuItem mnuXuatKho;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyHoaDon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyThucDon;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeTonKho;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimer;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuuXuatNhap;
    }
}

