namespace BeerBilling.presenter.billing
{
    partial class BillingDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingDetail));
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.txtTongTien = new mcontrol.MTextBox(this.components);
            this.mLabel5 = new mcontrol.MLabel(this.components);
            this.mLabel7 = new mcontrol.MLabel(this.components);
            this.mLabel4 = new mcontrol.MLabel(this.components);
            this.dgvThucDon = new mcontrol.MDataGridView(this.components);
            this.MON_AN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DON_VI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DON_GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHIET_KHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANH_TIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInHoaDon = new mcontrol.MTextBox(this.components);
            this.txtThanhToan = new mcontrol.MTextBox(this.components);
            this.mLabel6 = new mcontrol.MLabel(this.components);
            this.mGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // mGroupBox1
            // 
            this.mGroupBox1.Controls.Add(this.txtTongTien);
            this.mGroupBox1.Controls.Add(this.mLabel5);
            this.mGroupBox1.Controls.Add(this.mLabel7);
            this.mGroupBox1.Controls.Add(this.mLabel4);
            this.mGroupBox1.Controls.Add(this.dgvThucDon);
            this.mGroupBox1.Controls.Add(this.txtInHoaDon);
            this.mGroupBox1.Controls.Add(this.txtThanhToan);
            this.mGroupBox1.Controls.Add(this.mLabel6);
            this.mGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox1.Location = new System.Drawing.Point(13, 5);
            this.mGroupBox1.Name = "mGroupBox1";
            this.mGroupBox1.Size = new System.Drawing.Size(839, 403);
            this.mGroupBox1.TabIndex = 0;
            this.mGroupBox1.TabStop = false;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.Location = new System.Drawing.Point(675, 354);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(142, 23);
            this.txtTongTien.TabIndex = 22;
            // 
            // mLabel5
            // 
            this.mLabel5.AutoSize = true;
            this.mLabel5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel5.Location = new System.Drawing.Point(66, 50);
            this.mLabel5.Name = "mLabel5";
            this.mLabel5.Size = new System.Drawing.Size(67, 14);
            this.mLabel5.TabIndex = 16;
            this.mLabel5.Text = "In hóa đơn";
            // 
            // mLabel7
            // 
            this.mLabel7.AutoSize = true;
            this.mLabel7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mLabel7.Location = new System.Drawing.Point(603, 357);
            this.mLabel7.Name = "mLabel7";
            this.mLabel7.Size = new System.Drawing.Size(66, 14);
            this.mLabel7.TabIndex = 21;
            this.mLabel7.Text = "Tổng tiền";
            // 
            // mLabel4
            // 
            this.mLabel4.AutoSize = true;
            this.mLabel4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel4.Location = new System.Drawing.Point(16, 21);
            this.mLabel4.Name = "mLabel4";
            this.mLabel4.Size = new System.Drawing.Size(61, 14);
            this.mLabel4.TabIndex = 15;
            this.mLabel4.Text = "Thực đơn";
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToAddRows = false;
            this.dgvThucDon.AllowUserToDeleteRows = false;
            this.dgvThucDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MON_AN,
            this.SO_LUONG,
            this.DON_VI,
            this.DON_GIA,
            this.CHIET_KHAU,
            this.THANH_TIEN,
            this.ResOrderId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThucDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThucDon.Location = new System.Drawing.Point(19, 83);
            this.dgvThucDon.MultiSelect = false;
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.RowHeadersVisible = false;
            this.dgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucDon.Size = new System.Drawing.Size(795, 260);
            this.dgvThucDon.TabIndex = 20;
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
            // ResOrderId
            // 
            this.ResOrderId.HeaderText = "ResOrderId";
            this.ResOrderId.Name = "ResOrderId";
            this.ResOrderId.ReadOnly = true;
            this.ResOrderId.Visible = false;
            // 
            // txtInHoaDon
            // 
            this.txtInHoaDon.BackColor = System.Drawing.Color.White;
            this.txtInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInHoaDon.Location = new System.Drawing.Point(139, 47);
            this.txtInHoaDon.Name = "txtInHoaDon";
            this.txtInHoaDon.ReadOnly = true;
            this.txtInHoaDon.Size = new System.Drawing.Size(100, 23);
            this.txtInHoaDon.TabIndex = 17;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.BackColor = System.Drawing.Color.White;
            this.txtThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtThanhToan.Location = new System.Drawing.Point(332, 47);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.ReadOnly = true;
            this.txtThanhToan.Size = new System.Drawing.Size(136, 23);
            this.txtThanhToan.TabIndex = 19;
            // 
            // mLabel6
            // 
            this.mLabel6.AutoSize = true;
            this.mLabel6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel6.Location = new System.Drawing.Point(255, 50);
            this.mLabel6.Name = "mLabel6";
            this.mLabel6.Size = new System.Drawing.Size(71, 14);
            this.mLabel6.TabIndex = 18;
            this.mLabel6.Text = "Thanh toán";
            // 
            // BillingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 423);
            this.Controls.Add(this.mGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillingDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn";
            this.mGroupBox1.ResumeLayout(false);
            this.mGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox mGroupBox1;
        private mcontrol.MTextBox txtTongTien;
        private mcontrol.MLabel mLabel5;
        private mcontrol.MLabel mLabel7;
        private mcontrol.MLabel mLabel4;
        private mcontrol.MDataGridView dgvThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MON_AN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DON_VI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DON_GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHIET_KHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANH_TIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResOrderId;
        private mcontrol.MTextBox txtInHoaDon;
        private mcontrol.MTextBox txtThanhToan;
        private mcontrol.MLabel mLabel6;
    }
}