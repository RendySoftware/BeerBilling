namespace BeerBilling.presenter.kho
{
    partial class NhapXuatKho
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
            var storeType = importExportType.name;

            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.impexpGroupBox = new mcontrol.MGroupBox(this.components);
            this.txtAmount = new mcontrol.MNumberTextBox(this.components);
            this.txtUnit = new mcontrol.MTextBox(this.components);
            this.lblUnit = new mcontrol.MLabel(this.components);
            this.txtStoreDate = new mcontrol.MDateTextBox(this.components);
            this.lblStoreDate = new mcontrol.MLabel(this.components);
            this.btnAddStore = new mcontrol.MButton(this.components);
            this.lblReason = new mcontrol.MLabel(this.components);
            this.txtReason = new mcontrol.MTextBox(this.components);
            this.lblAmount = new mcontrol.MLabel(this.components);
            this.materialComboBox = new mcontrol.MComboBox(this.components);
            this.lblMaterial = new mcontrol.MLabel(this.components);
            this.storeGroupBox = new mcontrol.MGroupBox(this.components);
            this.btnImpexpProcess = new mcontrol.MButton(this.components);
            this.dgvStores = new mcontrol.MDataGridView(this.components);
            this.materialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impexpGroupBox.SuspendLayout();
            this.storeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            this.SuspendLayout();
            // 
            // impexpGroupBox
            // 
            this.impexpGroupBox.Controls.Add(this.txtAmount);
            this.impexpGroupBox.Controls.Add(this.txtUnit);
            this.impexpGroupBox.Controls.Add(this.lblUnit);
            this.impexpGroupBox.Controls.Add(this.txtStoreDate);
            this.impexpGroupBox.Controls.Add(this.lblStoreDate);
            this.impexpGroupBox.Controls.Add(this.btnAddStore);
            this.impexpGroupBox.Controls.Add(this.lblReason);
            this.impexpGroupBox.Controls.Add(this.txtReason);
            this.impexpGroupBox.Controls.Add(this.lblAmount);
            this.impexpGroupBox.Controls.Add(this.materialComboBox);
            this.impexpGroupBox.Controls.Add(this.lblMaterial);
            this.impexpGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.impexpGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.impexpGroupBox.Location = new System.Drawing.Point(14, 15);
            this.impexpGroupBox.Name = "impexpGroupBox";
            this.impexpGroupBox.Size = new System.Drawing.Size(681, 133);
            this.impexpGroupBox.TabIndex = 0;
            this.impexpGroupBox.TabStop = false;
            this.impexpGroupBox.Text = storeType;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAmount.Location = new System.Drawing.Point(411, 21);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(158, 23);
            this.txtAmount.TabIndex = 2;
            // 
            // txtUnit
            // 
            this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnit.Enabled = false;
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUnit.Location = new System.Drawing.Point(411, 59);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(158, 23);
            this.txtUnit.TabIndex = 10;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblUnit.Location = new System.Drawing.Point(365, 63);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(41, 14);
            this.lblUnit.TabIndex = 9;
            this.lblUnit.Text = "Đơn vị";
            // 
            // txtStoreDate
            // 
            this.txtStoreDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStoreDate.Location = new System.Drawing.Point(100, 59);
            this.txtStoreDate.MaxLength = 10;
            this.txtStoreDate.Name = "txtStoreDate";
            this.txtStoreDate.Size = new System.Drawing.Size(225, 23);
            this.txtStoreDate.TabIndex = 3;
            // 
            // lblStoreDate
            // 
            this.lblStoreDate.AutoSize = true;
            this.lblStoreDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblStoreDate.Location = new System.Drawing.Point(4, 63);
            this.lblStoreDate.Name = "lblStoreDate";
            this.lblStoreDate.Size = new System.Drawing.Size(89, 14);
            this.lblStoreDate.TabIndex = 7;
            this.lblStoreDate.Text = "Ngày " + storeType.ToLower();
            // 
            // btnAddStore
            // 
            this.btnAddStore.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAddStore.Location = new System.Drawing.Point(576, 21);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(94, 23);
            this.btnAddStore.TabIndex = 6;
            this.btnAddStore.Text = "Thêm mới";
            this.btnAddStore.UseVisualStyleBackColor = true;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblReason.Location = new System.Drawing.Point(56, 99);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(37, 14);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "Lý do";
            // 
            // txtReason
            // 
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtReason.Location = new System.Drawing.Point(100, 95);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(469, 23);
            this.txtReason.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblAmount.Location = new System.Drawing.Point(350, 25);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 14);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Số lượng";
            // 
            // materialComboBox
            // 
            this.materialComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.materialComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.materialComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.LimitToList = true;
            this.materialComboBox.Location = new System.Drawing.Point(100, 20);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(225, 24);
            this.materialComboBox.TabIndex = 1;
            this.materialComboBox.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_SelectedIndexChanged);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblMaterial.Location = new System.Drawing.Point(22, 25);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(71, 14);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Nguyên liệu";
            // 
            // storeGroupBox
            // 
            this.storeGroupBox.Controls.Add(this.btnImpexpProcess);
            this.storeGroupBox.Controls.Add(this.dgvStores);
            this.storeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.storeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.storeGroupBox.Location = new System.Drawing.Point(14, 158);
            this.storeGroupBox.Name = "storeGroupBox";
            this.storeGroupBox.Size = new System.Drawing.Size(681, 371);
            this.storeGroupBox.TabIndex = 1;
            this.storeGroupBox.TabStop = false;
            this.storeGroupBox.Text = "Danh sách " + storeType.ToLower();
            // 
            // btnImpexpProcess
            // 
            this.btnImpexpProcess.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnImpexpProcess.Location = new System.Drawing.Point(576, 19);
            this.btnImpexpProcess.Name = "btnImpexpProcess";
            this.btnImpexpProcess.Size = new System.Drawing.Size(94, 23);
            this.btnImpexpProcess.TabIndex = 1;
            this.btnImpexpProcess.Text = storeType;
            this.btnImpexpProcess.UseVisualStyleBackColor = true;
            this.btnImpexpProcess.Click += new System.EventHandler(this.btnImpexpProcess_Click);
            // 
            // dgvStores
            // 
            this.dgvStores.AllowUserToAddRows = false;
            this.dgvStores.AllowUserToDeleteRows = false;
            this.dgvStores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialName,
            this.materialId,
            this.amount,
            this.unit,
            this.storeDate,
            this.reason});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStores.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStores.Location = new System.Drawing.Point(9, 53);
            this.dgvStores.MultiSelect = false;
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.RowHeadersVisible = false;
            this.dgvStores.Size = new System.Drawing.Size(661, 312);
            this.dgvStores.TabIndex = 0;
            // 
            // materialName
            // 
            this.materialName.FillWeight = 250F;
            this.materialName.HeaderText = "Nguyên liệu";
            this.materialName.Name = "materialName";
            this.materialName.Width = 250;
            // 
            // materialId
            // 
            this.materialId.HeaderText = "materialId";
            this.materialId.Name = "materialId";
            this.materialId.Visible = false;
            // 
            // amount
            // 
            this.amount.FillWeight = 110F;
            this.amount.HeaderText = "Số lượng";
            this.amount.Name = "amount";
            this.amount.Width = 110;
            // 
            // unit
            // 
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            // 
            // storeDate
            // 
            this.storeDate.HeaderText = "Ngày " + storeType.ToLower();
            this.storeDate.Name = "storeDate";
            // 
            // reason
            // 
            this.reason.FillWeight = 200F;
            this.reason.HeaderText = "Lý do";
            this.reason.Name = "reason";
            this.reason.Width = 200;
            // 
            // NhapXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 541);
            this.Controls.Add(this.storeGroupBox);
            this.Controls.Add(this.impexpGroupBox);
            this.Name = "NhapXuatKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = storeType;
            this.impexpGroupBox.ResumeLayout(false);
            this.impexpGroupBox.PerformLayout();
            this.storeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox impexpGroupBox;
        private mcontrol.MLabel lblReason;
        private mcontrol.MTextBox txtReason;
        private mcontrol.MLabel lblAmount;
        private mcontrol.MComboBox materialComboBox;
        private mcontrol.MLabel lblMaterial;
        private mcontrol.MButton btnAddStore;
        private mcontrol.MGroupBox storeGroupBox;
        private mcontrol.MButton btnImpexpProcess;
        private mcontrol.MDataGridView dgvStores;
        private mcontrol.MDateTextBox txtStoreDate;
        private mcontrol.MLabel lblStoreDate;
        private mcontrol.MTextBox txtUnit;
        private mcontrol.MLabel lblUnit;
        private mcontrol.MNumberTextBox txtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;

    }
}