namespace BeerBilling.presenter.billing
{
    partial class BillingProcessing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingProcessing));
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.dgvHoaDon = new mcontrol.MDataGridView(this.components);
            this.billNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.billId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemHoaDon = new mcontrol.MButton(this.components);
            this.mGroupBox2 = new mcontrol.MGroupBox(this.components);
            this.mLabel8 = new mcontrol.MLabel(this.components);
            this.txtChietKhau = new mcontrol.MNumberTextBox3(this.components);
            this.txtSoLuong = new mcontrol.MNumberTextBox3(this.components);
            this.cboMonAn = new mcontrol.MComboBox2(this.components);
            this.btnThanhToan = new mcontrol.MButton(this.components);
            this.btnInHoaDon = new mcontrol.MButton(this.components);
            this.btnHuy = new mcontrol.MButton(this.components);
            this.txtTongTien = new mcontrol.MTextBox(this.components);
            this.mLabel7 = new mcontrol.MLabel(this.components);
            this.dgvThucDon = new mcontrol.MDataGridView(this.components);
            this.MON_AN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DON_VI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DON_GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHIET_KHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANH_TIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ResOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThanhToan = new mcontrol.MTextBox(this.components);
            this.mLabel6 = new mcontrol.MLabel(this.components);
            this.txtInHoaDon = new mcontrol.MTextBox(this.components);
            this.mLabel5 = new mcontrol.MLabel(this.components);
            this.mLabel4 = new mcontrol.MLabel(this.components);
            this.btnThemMonAn = new mcontrol.MButton(this.components);
            this.mLabel3 = new mcontrol.MLabel(this.components);
            this.mLabel2 = new mcontrol.MLabel(this.components);
            this.mLabel1 = new mcontrol.MLabel(this.components);
            this.mGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.mGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // mGroupBox1
            // 
            this.mGroupBox1.Controls.Add(this.dgvHoaDon);
            this.mGroupBox1.Controls.Add(this.btnThemHoaDon);
            this.mGroupBox1.Controls.Add(this.mGroupBox2);
            this.mGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.mGroupBox1.Name = "mGroupBox1";
            this.mGroupBox1.Size = new System.Drawing.Size(984, 529);
            this.mGroupBox1.TabIndex = 0;
            this.mGroupBox1.TabStop = false;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billNumber,
            this.Edit,
            this.billId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.Location = new System.Drawing.Point(16, 46);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(172, 474);
            this.dgvHoaDon.TabIndex = 2;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            this.dgvHoaDon.SelectionChanged += new System.EventHandler(this.dgvHoaDon_SelectionChanged);
            // 
            // billNumber
            // 
            this.billNumber.FillWeight = 110F;
            this.billNumber.HeaderText = "Hóa đơn";
            this.billNumber.Name = "billNumber";
            this.billNumber.ReadOnly = true;
            this.billNumber.Width = 110;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 60F;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 60;
            // 
            // billId
            // 
            this.billId.HeaderText = "billId";
            this.billId.Name = "billId";
            this.billId.ReadOnly = true;
            this.billId.Visible = false;
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThemHoaDon.Image = global::BeerBilling.Properties.Resources.Add;
            this.btnThemHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHoaDon.Location = new System.Drawing.Point(16, 16);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(119, 23);
            this.btnThemHoaDon.TabIndex = 1;
            this.btnThemHoaDon.Text = "Thêm &mới";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // mGroupBox2
            // 
            this.mGroupBox2.Controls.Add(this.mLabel8);
            this.mGroupBox2.Controls.Add(this.txtChietKhau);
            this.mGroupBox2.Controls.Add(this.txtSoLuong);
            this.mGroupBox2.Controls.Add(this.cboMonAn);
            this.mGroupBox2.Controls.Add(this.btnThanhToan);
            this.mGroupBox2.Controls.Add(this.btnInHoaDon);
            this.mGroupBox2.Controls.Add(this.btnHuy);
            this.mGroupBox2.Controls.Add(this.txtTongTien);
            this.mGroupBox2.Controls.Add(this.mLabel7);
            this.mGroupBox2.Controls.Add(this.dgvThucDon);
            this.mGroupBox2.Controls.Add(this.txtThanhToan);
            this.mGroupBox2.Controls.Add(this.mLabel6);
            this.mGroupBox2.Controls.Add(this.txtInHoaDon);
            this.mGroupBox2.Controls.Add(this.mLabel5);
            this.mGroupBox2.Controls.Add(this.mLabel4);
            this.mGroupBox2.Controls.Add(this.btnThemMonAn);
            this.mGroupBox2.Controls.Add(this.mLabel3);
            this.mGroupBox2.Controls.Add(this.mLabel2);
            this.mGroupBox2.Controls.Add(this.mLabel1);
            this.mGroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox2.Location = new System.Drawing.Point(194, 39);
            this.mGroupBox2.Name = "mGroupBox2";
            this.mGroupBox2.Size = new System.Drawing.Size(784, 481);
            this.mGroupBox2.TabIndex = 1;
            this.mGroupBox2.TabStop = false;
            // 
            // mLabel8
            // 
            this.mLabel8.AutoSize = true;
            this.mLabel8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel8.Location = new System.Drawing.Point(624, 31);
            this.mLabel8.Name = "mLabel8";
            this.mLabel8.Size = new System.Drawing.Size(19, 14);
            this.mLabel8.TabIndex = 21;
            this.mLabel8.Text = "%";
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.AllowAlphaOnly = false;
            this.txtChietKhau.AllowNumericOnly = false;
            this.txtChietKhau.AllowSpecialCharecterOnly = false;
            this.txtChietKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChietKhau.ErrorMessage = "";
            this.txtChietKhau.ErrorMessageTitle = "";
            this.txtChietKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtChietKhau.Location = new System.Drawing.Point(526, 26);
            this.txtChietKhau.Mandatory = false;
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(92, 23);
            this.txtChietKhau.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.AllowAlphaOnly = false;
            this.txtSoLuong.AllowNumericOnly = false;
            this.txtSoLuong.AllowSpecialCharecterOnly = false;
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.ErrorMessage = "";
            this.txtSoLuong.ErrorMessageTitle = "";
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSoLuong.Location = new System.Drawing.Point(347, 26);
            this.txtSoLuong.Mandatory = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(92, 23);
            this.txtSoLuong.TabIndex = 4;
            // 
            // cboMonAn
            // 
            this.cboMonAn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMonAn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMonAn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboMonAn.FormattingEnabled = true;
            this.cboMonAn.LimitToList = true;
            this.cboMonAn.Location = new System.Drawing.Point(63, 26);
            this.cboMonAn.Name = "cboMonAn";
            this.cboMonAn.Size = new System.Drawing.Size(209, 24);
            this.cboMonAn.TabIndex = 3;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThanhToan.Image = global::BeerBilling.Properties.Resources.Apply;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(630, 436);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(134, 25);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "&3. Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnInHoaDon.Image = global::BeerBilling.Properties.Resources.print3;
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(484, 436);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(134, 25);
            this.btnInHoaDon.TabIndex = 12;
            this.btnInHoaDon.Text = "&2. In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHuy.Image = global::BeerBilling.Properties.Resources.Cance_Delete;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(372, 436);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 25);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "&1. Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.Location = new System.Drawing.Point(621, 400);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(142, 23);
            this.txtTongTien.TabIndex = 10;
            // 
            // mLabel7
            // 
            this.mLabel7.AutoSize = true;
            this.mLabel7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mLabel7.Location = new System.Drawing.Point(549, 403);
            this.mLabel7.Name = "mLabel7";
            this.mLabel7.Size = new System.Drawing.Size(66, 14);
            this.mLabel7.TabIndex = 13;
            this.mLabel7.Text = "Tổng tiền";
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToAddRows = false;
            this.dgvThucDon.AllowUserToDeleteRows = false;
            this.dgvThucDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MON_AN,
            this.SO_LUONG,
            this.DON_VI,
            this.DON_GIA,
            this.CHIET_KHAU,
            this.THANH_TIEN,
            this.Delete,
            this.ResOrderId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThucDon.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThucDon.Location = new System.Drawing.Point(15, 129);
            this.dgvThucDon.MultiSelect = false;
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.RowHeadersVisible = false;
            this.dgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucDon.Size = new System.Drawing.Size(749, 260);
            this.dgvThucDon.TabIndex = 9;
            this.dgvThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucDon_CellClick);
            this.dgvThucDon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvThucDon_KeyPress);
            // 
            // MON_AN
            // 
            this.MON_AN.FillWeight = 250F;
            this.MON_AN.HeaderText = "Món ăn";
            this.MON_AN.Name = "MON_AN";
            this.MON_AN.ReadOnly = true;
            this.MON_AN.Width = 250;
            // 
            // SO_LUONG
            // 
            this.SO_LUONG.HeaderText = "Số lượng";
            this.SO_LUONG.Name = "SO_LUONG";
            this.SO_LUONG.ReadOnly = true;
            // 
            // DON_VI
            // 
            this.DON_VI.FillWeight = 120F;
            this.DON_VI.HeaderText = "Đơn vị";
            this.DON_VI.Name = "DON_VI";
            this.DON_VI.ReadOnly = true;
            this.DON_VI.Width = 120;
            // 
            // DON_GIA
            // 
            this.DON_GIA.FillWeight = 130F;
            this.DON_GIA.HeaderText = "Đơn giá";
            this.DON_GIA.Name = "DON_GIA";
            this.DON_GIA.ReadOnly = true;
            this.DON_GIA.Width = 130;
            // 
            // CHIET_KHAU
            // 
            this.CHIET_KHAU.HeaderText = "Chiết khấu";
            this.CHIET_KHAU.Name = "CHIET_KHAU";
            this.CHIET_KHAU.ReadOnly = true;
            // 
            // THANH_TIEN
            // 
            this.THANH_TIEN.FillWeight = 130F;
            this.THANH_TIEN.HeaderText = "Thành tiền";
            this.THANH_TIEN.Name = "THANH_TIEN";
            this.THANH_TIEN.ReadOnly = true;
            this.THANH_TIEN.Width = 130;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 60F;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 60;
            // 
            // ResOrderId
            // 
            this.ResOrderId.HeaderText = "ResOrderId";
            this.ResOrderId.Name = "ResOrderId";
            this.ResOrderId.ReadOnly = true;
            this.ResOrderId.Visible = false;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.BackColor = System.Drawing.Color.White;
            this.txtThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtThanhToan.Location = new System.Drawing.Point(328, 94);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.ReadOnly = true;
            this.txtThanhToan.Size = new System.Drawing.Size(136, 23);
            this.txtThanhToan.TabIndex = 8;
            // 
            // mLabel6
            // 
            this.mLabel6.AutoSize = true;
            this.mLabel6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel6.Location = new System.Drawing.Point(251, 97);
            this.mLabel6.Name = "mLabel6";
            this.mLabel6.Size = new System.Drawing.Size(71, 14);
            this.mLabel6.TabIndex = 10;
            this.mLabel6.Text = "Thanh toán";
            // 
            // txtInHoaDon
            // 
            this.txtInHoaDon.BackColor = System.Drawing.Color.White;
            this.txtInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInHoaDon.Location = new System.Drawing.Point(135, 94);
            this.txtInHoaDon.Name = "txtInHoaDon";
            this.txtInHoaDon.ReadOnly = true;
            this.txtInHoaDon.Size = new System.Drawing.Size(100, 23);
            this.txtInHoaDon.TabIndex = 7;
            // 
            // mLabel5
            // 
            this.mLabel5.AutoSize = true;
            this.mLabel5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel5.Location = new System.Drawing.Point(62, 97);
            this.mLabel5.Name = "mLabel5";
            this.mLabel5.Size = new System.Drawing.Size(67, 14);
            this.mLabel5.TabIndex = 8;
            this.mLabel5.Text = "In hóa đơn";
            // 
            // mLabel4
            // 
            this.mLabel4.AutoSize = true;
            this.mLabel4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel4.Location = new System.Drawing.Point(12, 68);
            this.mLabel4.Name = "mLabel4";
            this.mLabel4.Size = new System.Drawing.Size(61, 14);
            this.mLabel4.TabIndex = 7;
            this.mLabel4.Text = "Thực đơn";
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThemMonAn.Image = global::BeerBilling.Properties.Resources.Add;
            this.btnThemMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMonAn.Location = new System.Drawing.Point(651, 27);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(100, 23);
            this.btnThemMonAn.TabIndex = 6;
            this.btnThemMonAn.Text = "&Thêm";
            this.btnThemMonAn.UseVisualStyleBackColor = true;
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            // 
            // mLabel3
            // 
            this.mLabel3.AutoSize = true;
            this.mLabel3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel3.Location = new System.Drawing.Point(455, 31);
            this.mLabel3.Name = "mLabel3";
            this.mLabel3.Size = new System.Drawing.Size(65, 14);
            this.mLabel3.TabIndex = 4;
            this.mLabel3.Text = "Chiết khấu";
            // 
            // mLabel2
            // 
            this.mLabel2.AutoSize = true;
            this.mLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel2.Location = new System.Drawing.Point(285, 29);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(56, 14);
            this.mLabel2.TabIndex = 2;
            this.mLabel2.Text = "Số lượng";
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel1.Location = new System.Drawing.Point(12, 31);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(47, 14);
            this.mLabel1.TabIndex = 0;
            this.mLabel1.Text = "Món ăn";
            // 
            // BillingProcessing
            // 
            this.AcceptButton = this.btnThemHoaDon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.mGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BillingProcessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hóa đơn";
            this.mGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.mGroupBox2.ResumeLayout(false);
            this.mGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox mGroupBox1;
        private mcontrol.MGroupBox mGroupBox2;
        private mcontrol.MLabel mLabel1;
        private mcontrol.MTextBox txtThanhToan;
        private mcontrol.MLabel mLabel6;
        private mcontrol.MTextBox txtInHoaDon;
        private mcontrol.MLabel mLabel5;
        private mcontrol.MLabel mLabel4;
        private mcontrol.MButton btnThemMonAn;
        private mcontrol.MLabel mLabel3;
        private mcontrol.MLabel mLabel2;
        private mcontrol.MTextBox txtTongTien;
        private mcontrol.MLabel mLabel7;
        private mcontrol.MDataGridView dgvThucDon;
        private mcontrol.MButton btnInHoaDon;
        private mcontrol.MButton btnHuy;
        private mcontrol.MButton btnThanhToan;
        private mcontrol.MButton btnThemHoaDon;
        private mcontrol.MComboBox2 cboMonAn;
        private mcontrol.MDataGridView dgvHoaDon;
        private mcontrol.MNumberTextBox3 txtChietKhau;
        private mcontrol.MNumberTextBox3 txtSoLuong;
        private mcontrol.MLabel mLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNumber;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn billId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MON_AN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DON_VI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DON_GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHIET_KHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANH_TIEN;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResOrderId;

    }
}