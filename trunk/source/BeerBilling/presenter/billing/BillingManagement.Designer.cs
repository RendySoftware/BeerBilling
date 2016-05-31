namespace BeerBilling.presenter.billing
{
    partial class BillingManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingManagement));
            this.billListGroupBox = new mcontrol.MGroupBox(this.components);
            this.dgvBilling = new mcontrol.MDataGridView(this.components);
            this.tracuuGroupBox = new mcontrol.MGroupBox(this.components);
            this.billStatusComboBox = new mcontrol.MComboBox(this.components);
            this.lblBillStatus = new mcontrol.MLabel(this.components);
            this.tableComboBox = new mcontrol.MComboBox2(this.components);
            this.lblTableNumber = new mcontrol.MLabel(this.components);
            this.txtBillingNumber = new mcontrol.MNumberTextBox2(this.components);
            this.lblBillingNumber = new mcontrol.MLabel(this.components);
            this.btnThucHien = new mcontrol.MButton(this.components);
            this.txtToDate = new mcontrol.MDateTextBox(this.components);
            this.lblToDate = new mcontrol.MLabel(this.components);
            this.txtFromDate = new mcontrol.MDateTextBox(this.components);
            this.lblFromDate = new mcontrol.MLabel(this.components);
            this.billNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.billId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.tracuuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // billListGroupBox
            // 
            this.billListGroupBox.Controls.Add(this.dgvBilling);
            this.billListGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.billListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.billListGroupBox.Location = new System.Drawing.Point(13, 146);
            this.billListGroupBox.Name = "billListGroupBox";
            this.billListGroupBox.Size = new System.Drawing.Size(898, 475);
            this.billListGroupBox.TabIndex = 1;
            this.billListGroupBox.TabStop = false;
            this.billListGroupBox.Text = "Danh sách hóa đơn";
            // 
            // dgvBilling
            // 
            this.dgvBilling.AllowUserToAddRows = false;
            this.dgvBilling.AllowUserToDeleteRows = false;
            this.dgvBilling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billNumber,
            this.billDate,
            this.tableNumber,
            this.totalBill,
            this.billStatus,
            this.createdBy,
            this.createdDate,
            this.detail,
            this.billId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBilling.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBilling.Location = new System.Drawing.Point(7, 20);
            this.dgvBilling.MultiSelect = false;
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.RowHeadersVisible = false;
            this.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBilling.Size = new System.Drawing.Size(885, 449);
            this.dgvBilling.TabIndex = 0;
            this.dgvBilling.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBilling_CellClick);
            // 
            // tracuuGroupBox
            // 
            this.tracuuGroupBox.Controls.Add(this.billStatusComboBox);
            this.tracuuGroupBox.Controls.Add(this.lblBillStatus);
            this.tracuuGroupBox.Controls.Add(this.tableComboBox);
            this.tracuuGroupBox.Controls.Add(this.lblTableNumber);
            this.tracuuGroupBox.Controls.Add(this.txtBillingNumber);
            this.tracuuGroupBox.Controls.Add(this.lblBillingNumber);
            this.tracuuGroupBox.Controls.Add(this.btnThucHien);
            this.tracuuGroupBox.Controls.Add(this.txtToDate);
            this.tracuuGroupBox.Controls.Add(this.lblToDate);
            this.tracuuGroupBox.Controls.Add(this.txtFromDate);
            this.tracuuGroupBox.Controls.Add(this.lblFromDate);
            this.tracuuGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tracuuGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.tracuuGroupBox.Location = new System.Drawing.Point(13, 13);
            this.tracuuGroupBox.Name = "tracuuGroupBox";
            this.tracuuGroupBox.Size = new System.Drawing.Size(898, 126);
            this.tracuuGroupBox.TabIndex = 0;
            this.tracuuGroupBox.TabStop = false;
            // 
            // billStatusComboBox
            // 
            this.billStatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.billStatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.billStatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.billStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.billStatusComboBox.FormattingEnabled = true;
            this.billStatusComboBox.LimitToList = true;
            this.billStatusComboBox.Location = new System.Drawing.Point(190, 93);
            this.billStatusComboBox.Name = "billStatusComboBox";
            this.billStatusComboBox.Size = new System.Drawing.Size(142, 24);
            this.billStatusComboBox.TabIndex = 14;
            // 
            // lblBillStatus
            // 
            this.lblBillStatus.AutoSize = true;
            this.lblBillStatus.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblBillStatus.Location = new System.Drawing.Point(106, 98);
            this.lblBillStatus.Name = "lblBillStatus";
            this.lblBillStatus.Size = new System.Drawing.Size(64, 14);
            this.lblBillStatus.TabIndex = 13;
            this.lblBillStatus.Text = "Tình trạng";
            // 
            // tableComboBox
            // 
            this.tableComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tableComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tableComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.LimitToList = true;
            this.tableComboBox.Location = new System.Drawing.Point(417, 55);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(164, 24);
            this.tableComboBox.TabIndex = 12;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTableNumber.Location = new System.Drawing.Point(352, 60);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(43, 14);
            this.lblTableNumber.TabIndex = 11;
            this.lblTableNumber.Text = "Bàn số";
            // 
            // txtBillingNumber
            // 
            this.txtBillingNumber.AllowAlphaOnly = false;
            this.txtBillingNumber.AllowNumericOnly = false;
            this.txtBillingNumber.AllowSpecialCharecterOnly = false;
            this.txtBillingNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillingNumber.ErrorMessage = "";
            this.txtBillingNumber.ErrorMessageTitle = "";
            this.txtBillingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBillingNumber.Location = new System.Drawing.Point(190, 56);
            this.txtBillingNumber.Mandatory = false;
            this.txtBillingNumber.Name = "txtBillingNumber";
            this.txtBillingNumber.Size = new System.Drawing.Size(142, 23);
            this.txtBillingNumber.TabIndex = 10;
            // 
            // lblBillingNumber
            // 
            this.lblBillingNumber.AutoSize = true;
            this.lblBillingNumber.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblBillingNumber.Location = new System.Drawing.Point(106, 60);
            this.lblBillingNumber.Name = "lblBillingNumber";
            this.lblBillingNumber.Size = new System.Drawing.Size(69, 14);
            this.lblBillingNumber.TabIndex = 9;
            this.lblBillingNumber.Text = "Hóa đơn số";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThucHien.Image = global::BeerBilling.Properties.Resources.Search;
            this.btnThucHien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucHien.Location = new System.Drawing.Point(693, 55);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(114, 25);
            this.btnThucHien.TabIndex = 8;
            this.btnThucHien.Text = "&Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // txtToDate
            // 
            this.txtToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtToDate.Location = new System.Drawing.Point(417, 21);
            this.txtToDate.MaxLength = 10;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(164, 23);
            this.txtToDate.TabIndex = 7;
            this.txtToDate.Validated += new System.EventHandler(this.txtToDate_Validated);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblToDate.Location = new System.Drawing.Point(352, 25);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(59, 14);
            this.lblToDate.TabIndex = 6;
            this.lblToDate.Text = "Đến ngày";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFromDate.Location = new System.Drawing.Point(190, 19);
            this.txtFromDate.MaxLength = 10;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(142, 23);
            this.txtFromDate.TabIndex = 5;
            this.txtFromDate.Validated += new System.EventHandler(this.txtFromDate_Validated);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFromDate.Location = new System.Drawing.Point(106, 25);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(53, 14);
            this.lblFromDate.TabIndex = 4;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // billNumber
            // 
            this.billNumber.FillWeight = 80F;
            this.billNumber.HeaderText = "Hóa đơn số";
            this.billNumber.Name = "billNumber";
            this.billNumber.ReadOnly = true;
            this.billNumber.Width = 80;
            // 
            // billDate
            // 
            this.billDate.FillWeight = 110F;
            this.billDate.HeaderText = "Ngày hóa đơn";
            this.billDate.Name = "billDate";
            this.billDate.ReadOnly = true;
            this.billDate.Width = 110;
            // 
            // tableNumber
            // 
            this.tableNumber.HeaderText = "Bàn số";
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.ReadOnly = true;
            // 
            // totalBill
            // 
            this.totalBill.FillWeight = 120F;
            this.totalBill.HeaderText = "Thành tiền";
            this.totalBill.Name = "totalBill";
            this.totalBill.ReadOnly = true;
            this.totalBill.Width = 120;
            // 
            // billStatus
            // 
            this.billStatus.FillWeight = 150F;
            this.billStatus.HeaderText = "Tình trạng";
            this.billStatus.Name = "billStatus";
            this.billStatus.ReadOnly = true;
            this.billStatus.Width = 150;
            // 
            // createdBy
            // 
            this.createdBy.FillWeight = 120F;
            this.createdBy.HeaderText = "Người nhập";
            this.createdBy.Name = "createdBy";
            this.createdBy.ReadOnly = true;
            this.createdBy.Width = 120;
            // 
            // createdDate
            // 
            this.createdDate.FillWeight = 110F;
            this.createdDate.HeaderText = "Ngày nhập";
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            this.createdDate.Width = 110;
            // 
            // detail
            // 
            this.detail.HeaderText = "Chi tiết";
            this.detail.Name = "detail";
            this.detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // billId
            // 
            this.billId.HeaderText = "billId";
            this.billId.Name = "billId";
            this.billId.ReadOnly = true;
            this.billId.Visible = false;
            // 
            // BillingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 633);
            this.Controls.Add(this.billListGroupBox);
            this.Controls.Add(this.tracuuGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BillingManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu hóa đơn";
            this.billListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.tracuuGroupBox.ResumeLayout(false);
            this.tracuuGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox tracuuGroupBox;
        private mcontrol.MDateTextBox txtToDate;
        private mcontrol.MLabel lblToDate;
        private mcontrol.MDateTextBox txtFromDate;
        private mcontrol.MLabel lblFromDate;
        private mcontrol.MComboBox billStatusComboBox;
        private mcontrol.MLabel lblBillStatus;
        private mcontrol.MComboBox2 tableComboBox;
        private mcontrol.MLabel lblTableNumber;
        private mcontrol.MNumberTextBox2 txtBillingNumber;
        private mcontrol.MLabel lblBillingNumber;
        private mcontrol.MButton btnThucHien;
        private mcontrol.MGroupBox billListGroupBox;
        private mcontrol.MDataGridView dgvBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn billStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn billId;
    }
}