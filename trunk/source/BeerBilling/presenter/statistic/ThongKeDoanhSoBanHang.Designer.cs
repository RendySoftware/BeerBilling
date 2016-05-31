namespace BeerBilling.presenter.statistic
{
    partial class ThongKeDoanhSoBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDoanhSoBanHang));
            this.tracuuGroupBox = new mcontrol.MGroupBox(this.components);
            this.namComboBox = new mcontrol.MComboBox(this.components);
            this.lblNam = new mcontrol.MLabel(this.components);
            this.quyComboBox = new mcontrol.MComboBox(this.components);
            this.lblQuy = new mcontrol.MLabel(this.components);
            this.thangComboBox = new mcontrol.MComboBox(this.components);
            this.lblThang = new mcontrol.MLabel(this.components);
            this.namRadioButton = new mcontrol.MRadioButton(this.components);
            this.quyRadioButton = new mcontrol.MRadioButton(this.components);
            this.thangRadioButton = new mcontrol.MRadioButton(this.components);
            this.ngayRadioButton = new mcontrol.MRadioButton(this.components);
            this.btnThucHien = new mcontrol.MButton(this.components);
            this.txtToDate = new mcontrol.MDateTextBox(this.components);
            this.lblToDate = new mcontrol.MLabel(this.components);
            this.txtFromDate = new mcontrol.MDateTextBox(this.components);
            this.lblFromDate = new mcontrol.MLabel(this.components);
            this.banhangGroupBox = new mcontrol.MGroupBox(this.components);
            this.mTextBox1 = new mcontrol.MTextBox(this.components);
            this.lblTotal = new mcontrol.MLabel(this.components);
            this.sellDataGridView = new mcontrol.MDataGridView(this.components);
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tracuuGroupBox.SuspendLayout();
            this.banhangGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tracuuGroupBox
            // 
            this.tracuuGroupBox.Controls.Add(this.namComboBox);
            this.tracuuGroupBox.Controls.Add(this.lblNam);
            this.tracuuGroupBox.Controls.Add(this.quyComboBox);
            this.tracuuGroupBox.Controls.Add(this.lblQuy);
            this.tracuuGroupBox.Controls.Add(this.thangComboBox);
            this.tracuuGroupBox.Controls.Add(this.lblThang);
            this.tracuuGroupBox.Controls.Add(this.namRadioButton);
            this.tracuuGroupBox.Controls.Add(this.quyRadioButton);
            this.tracuuGroupBox.Controls.Add(this.thangRadioButton);
            this.tracuuGroupBox.Controls.Add(this.ngayRadioButton);
            this.tracuuGroupBox.Controls.Add(this.btnThucHien);
            this.tracuuGroupBox.Controls.Add(this.txtToDate);
            this.tracuuGroupBox.Controls.Add(this.lblToDate);
            this.tracuuGroupBox.Controls.Add(this.txtFromDate);
            this.tracuuGroupBox.Controls.Add(this.lblFromDate);
            this.tracuuGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tracuuGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.tracuuGroupBox.Location = new System.Drawing.Point(13, 13);
            this.tracuuGroupBox.Name = "tracuuGroupBox";
            this.tracuuGroupBox.Size = new System.Drawing.Size(759, 173);
            this.tracuuGroupBox.TabIndex = 0;
            this.tracuuGroupBox.TabStop = false;
            // 
            // namComboBox
            // 
            this.namComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.namComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.namComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.namComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.namComboBox.FormattingEnabled = true;
            this.namComboBox.LimitToList = true;
            this.namComboBox.Location = new System.Drawing.Point(99, 135);
            this.namComboBox.Name = "namComboBox";
            this.namComboBox.Size = new System.Drawing.Size(195, 24);
            this.namComboBox.TabIndex = 19;
            this.namComboBox.Visible = false;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNam.Location = new System.Drawing.Point(43, 140);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(31, 14);
            this.lblNam.TabIndex = 18;
            this.lblNam.Text = "Năm";
            // 
            // quyComboBox
            // 
            this.quyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.quyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.quyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.quyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quyComboBox.FormattingEnabled = true;
            this.quyComboBox.LimitToList = true;
            this.quyComboBox.Location = new System.Drawing.Point(99, 97);
            this.quyComboBox.Name = "quyComboBox";
            this.quyComboBox.Size = new System.Drawing.Size(195, 24);
            this.quyComboBox.TabIndex = 17;
            this.quyComboBox.Visible = false;
            // 
            // lblQuy
            // 
            this.lblQuy.AutoSize = true;
            this.lblQuy.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblQuy.Location = new System.Drawing.Point(43, 102);
            this.lblQuy.Name = "lblQuy";
            this.lblQuy.Size = new System.Drawing.Size(29, 14);
            this.lblQuy.TabIndex = 16;
            this.lblQuy.Text = "Quý";
            // 
            // thangComboBox
            // 
            this.thangComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.thangComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.thangComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.thangComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.thangComboBox.FormattingEnabled = true;
            this.thangComboBox.LimitToList = true;
            this.thangComboBox.Location = new System.Drawing.Point(99, 60);
            this.thangComboBox.Name = "thangComboBox";
            this.thangComboBox.Size = new System.Drawing.Size(195, 24);
            this.thangComboBox.TabIndex = 15;
            this.thangComboBox.Visible = false;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblThang.Location = new System.Drawing.Point(43, 65);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(42, 14);
            this.lblThang.TabIndex = 14;
            this.lblThang.Text = "Tháng";
            // 
            // namRadioButton
            // 
            this.namRadioButton.AutoSize = true;
            this.namRadioButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.namRadioButton.Location = new System.Drawing.Point(20, 141);
            this.namRadioButton.Name = "namRadioButton";
            this.namRadioButton.Size = new System.Drawing.Size(14, 13);
            this.namRadioButton.TabIndex = 13;
            this.namRadioButton.UseVisualStyleBackColor = true;
            // 
            // quyRadioButton
            // 
            this.quyRadioButton.AutoSize = true;
            this.quyRadioButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.quyRadioButton.Location = new System.Drawing.Point(20, 103);
            this.quyRadioButton.Name = "quyRadioButton";
            this.quyRadioButton.Size = new System.Drawing.Size(14, 13);
            this.quyRadioButton.TabIndex = 12;
            this.quyRadioButton.UseVisualStyleBackColor = true;
            // 
            // thangRadioButton
            // 
            this.thangRadioButton.AutoSize = true;
            this.thangRadioButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.thangRadioButton.Location = new System.Drawing.Point(20, 66);
            this.thangRadioButton.Name = "thangRadioButton";
            this.thangRadioButton.Size = new System.Drawing.Size(14, 13);
            this.thangRadioButton.TabIndex = 11;
            this.thangRadioButton.UseVisualStyleBackColor = true;
            // 
            // ngayRadioButton
            // 
            this.ngayRadioButton.AutoSize = true;
            this.ngayRadioButton.Checked = true;
            this.ngayRadioButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ngayRadioButton.Location = new System.Drawing.Point(20, 30);
            this.ngayRadioButton.Name = "ngayRadioButton";
            this.ngayRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ngayRadioButton.TabIndex = 10;
            this.ngayRadioButton.TabStop = true;
            this.ngayRadioButton.UseVisualStyleBackColor = true;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThucHien.Image = global::BeerBilling.Properties.Resources.Search;
            this.btnThucHien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucHien.Location = new System.Drawing.Point(593, 24);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(114, 25);
            this.btnThucHien.TabIndex = 9;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            // 
            // txtToDate
            // 
            this.txtToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtToDate.Location = new System.Drawing.Point(396, 24);
            this.txtToDate.MaxLength = 10;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(171, 23);
            this.txtToDate.TabIndex = 8;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblToDate.Location = new System.Drawing.Point(332, 28);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(59, 14);
            this.lblToDate.TabIndex = 7;
            this.lblToDate.Text = "Đến ngày";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFromDate.Location = new System.Drawing.Point(99, 24);
            this.txtFromDate.MaxLength = 10;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(195, 23);
            this.txtFromDate.TabIndex = 6;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFromDate.Location = new System.Drawing.Point(43, 28);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(53, 14);
            this.lblFromDate.TabIndex = 5;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // banhangGroupBox
            // 
            this.banhangGroupBox.Controls.Add(this.mTextBox1);
            this.banhangGroupBox.Controls.Add(this.lblTotal);
            this.banhangGroupBox.Controls.Add(this.sellDataGridView);
            this.banhangGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.banhangGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.banhangGroupBox.Location = new System.Drawing.Point(13, 193);
            this.banhangGroupBox.Name = "banhangGroupBox";
            this.banhangGroupBox.Size = new System.Drawing.Size(759, 357);
            this.banhangGroupBox.TabIndex = 1;
            this.banhangGroupBox.TabStop = false;
            this.banhangGroupBox.Text = "Doanh số bán hàng";
            // 
            // mTextBox1
            // 
            this.mTextBox1.BackColor = System.Drawing.Color.White;
            this.mTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mTextBox1.Location = new System.Drawing.Point(607, 14);
            this.mTextBox1.Name = "mTextBox1";
            this.mTextBox1.ReadOnly = true;
            this.mTextBox1.Size = new System.Drawing.Size(146, 23);
            this.mTextBox1.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(550, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 14);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Tổng số";
            // 
            // sellDataGridView
            // 
            this.sellDataGridView.AllowUserToAddRows = false;
            this.sellDataGridView.AllowUserToDeleteRows = false;
            this.sellDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu,
            this.unit,
            this.amount,
            this.total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sellDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.sellDataGridView.Location = new System.Drawing.Point(7, 42);
            this.sellDataGridView.MultiSelect = false;
            this.sellDataGridView.Name = "sellDataGridView";
            this.sellDataGridView.RowHeadersVisible = false;
            this.sellDataGridView.Size = new System.Drawing.Size(746, 309);
            this.sellDataGridView.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.FillWeight = 350F;
            this.menu.HeaderText = "Thực đơn";
            this.menu.Name = "menu";
            this.menu.Width = 350;
            // 
            // unit
            // 
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            // 
            // amount
            // 
            this.amount.FillWeight = 150F;
            this.amount.HeaderText = "Số lượng";
            this.amount.Name = "amount";
            this.amount.Width = 150;
            // 
            // total
            // 
            this.total.FillWeight = 200F;
            this.total.HeaderText = "Thành tiền";
            this.total.Name = "total";
            this.total.Width = 200;
            // 
            // ThongKeDoanhSoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.banhangGroupBox);
            this.Controls.Add(this.tracuuGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongKeDoanhSoBanHang";
            this.Text = "Doanh số bán hàng";
            this.tracuuGroupBox.ResumeLayout(false);
            this.tracuuGroupBox.PerformLayout();
            this.banhangGroupBox.ResumeLayout(false);
            this.banhangGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox tracuuGroupBox;
        private mcontrol.MComboBox namComboBox;
        private mcontrol.MLabel lblNam;
        private mcontrol.MComboBox quyComboBox;
        private mcontrol.MLabel lblQuy;
        private mcontrol.MComboBox thangComboBox;
        private mcontrol.MLabel lblThang;
        private mcontrol.MRadioButton namRadioButton;
        private mcontrol.MRadioButton quyRadioButton;
        private mcontrol.MRadioButton thangRadioButton;
        private mcontrol.MRadioButton ngayRadioButton;
        private mcontrol.MButton btnThucHien;
        private mcontrol.MDateTextBox txtToDate;
        private mcontrol.MLabel lblToDate;
        private mcontrol.MDateTextBox txtFromDate;
        private mcontrol.MLabel lblFromDate;
        private mcontrol.MGroupBox banhangGroupBox;
        private mcontrol.MTextBox mTextBox1;
        private mcontrol.MLabel lblTotal;
        private mcontrol.MDataGridView sellDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}