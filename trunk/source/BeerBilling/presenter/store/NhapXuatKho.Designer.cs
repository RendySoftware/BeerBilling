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
            this.components = new System.ComponentModel.Container();
            this.impexpGroupBox = new mcontrol.MGroupBox(this.components);
            this.lblReason = new mcontrol.MLabel(this.components);
            this.mTextBox2 = new mcontrol.MTextBox(this.components);
            this.mTextBox1 = new mcontrol.MTextBox(this.components);
            this.lblAmount = new mcontrol.MLabel(this.components);
            this.mComboBox1 = new mcontrol.MComboBox(this.components);
            this.lblMaterial = new mcontrol.MLabel(this.components);
            this.lblAddImpexp = new mcontrol.MButton(this.components);
            this.impexpListGroupBox = new mcontrol.MGroupBox(this.components);
            this.impexpDataGridView = new mcontrol.MDataGridView(this.components);
            this.btnImpexpProcess = new mcontrol.MButton(this.components);
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impexpGroupBox.SuspendLayout();
            this.impexpListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impexpDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // impexpGroupBox
            // 
            this.impexpGroupBox.Controls.Add(this.lblAddImpexp);
            this.impexpGroupBox.Controls.Add(this.lblReason);
            this.impexpGroupBox.Controls.Add(this.mTextBox2);
            this.impexpGroupBox.Controls.Add(this.mTextBox1);
            this.impexpGroupBox.Controls.Add(this.lblAmount);
            this.impexpGroupBox.Controls.Add(this.mComboBox1);
            this.impexpGroupBox.Controls.Add(this.lblMaterial);
            this.impexpGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.impexpGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.impexpGroupBox.Location = new System.Drawing.Point(14, 15);
            this.impexpGroupBox.Name = "impexpGroupBox";
            this.impexpGroupBox.Size = new System.Drawing.Size(681, 97);
            this.impexpGroupBox.TabIndex = 0;
            this.impexpGroupBox.TabStop = false;
            this.impexpGroupBox.Text = "Nhập Kho";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblReason.Location = new System.Drawing.Point(9, 58);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(37, 14);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "Lý do";
            // 
            // mTextBox2
            // 
            this.mTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mTextBox2.Location = new System.Drawing.Point(96, 58);
            this.mTextBox2.Name = "mTextBox2";
            this.mTextBox2.Size = new System.Drawing.Size(468, 23);
            this.mTextBox2.TabIndex = 4;
            // 
            // mTextBox1
            // 
            this.mTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mTextBox1.Location = new System.Drawing.Point(406, 21);
            this.mTextBox1.Name = "mTextBox1";
            this.mTextBox1.Size = new System.Drawing.Size(158, 23);
            this.mTextBox1.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblAmount.Location = new System.Drawing.Point(345, 25);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 14);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Số lượng";
            // 
            // mComboBox1
            // 
            this.mComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mComboBox1.FormattingEnabled = true;
            this.mComboBox1.LimitToList = true;
            this.mComboBox1.Location = new System.Drawing.Point(96, 20);
            this.mComboBox1.Name = "mComboBox1";
            this.mComboBox1.Size = new System.Drawing.Size(243, 24);
            this.mComboBox1.TabIndex = 1;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblMaterial.Location = new System.Drawing.Point(6, 25);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(71, 14);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Nguyên liệu";
            // 
            // lblAddImpexp
            // 
            this.lblAddImpexp.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblAddImpexp.Location = new System.Drawing.Point(576, 20);
            this.lblAddImpexp.Name = "lblAddImpexp";
            this.lblAddImpexp.Size = new System.Drawing.Size(94, 23);
            this.lblAddImpexp.TabIndex = 6;
            this.lblAddImpexp.Text = "Thêm mới";
            this.lblAddImpexp.UseVisualStyleBackColor = true;
            // 
            // impexpListGroupBox
            // 
            this.impexpListGroupBox.Controls.Add(this.btnImpexpProcess);
            this.impexpListGroupBox.Controls.Add(this.impexpDataGridView);
            this.impexpListGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.impexpListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.impexpListGroupBox.Location = new System.Drawing.Point(14, 128);
            this.impexpListGroupBox.Name = "impexpListGroupBox";
            this.impexpListGroupBox.Size = new System.Drawing.Size(681, 306);
            this.impexpListGroupBox.TabIndex = 1;
            this.impexpListGroupBox.TabStop = false;
            this.impexpListGroupBox.Text = "Danh sách nhập kho";
            // 
            // impexpDataGridView
            // 
            this.impexpDataGridView.AllowUserToAddRows = false;
            this.impexpDataGridView.AllowUserToDeleteRows = false;
            this.impexpDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.impexpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.impexpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.material,
            this.colMaterialId,
            this.amount,
            this.unit,
            this.reason});
            this.impexpDataGridView.Location = new System.Drawing.Point(9, 53);
            this.impexpDataGridView.MultiSelect = false;
            this.impexpDataGridView.Name = "impexpDataGridView";
            this.impexpDataGridView.RowHeadersVisible = false;
            this.impexpDataGridView.Size = new System.Drawing.Size(661, 247);
            this.impexpDataGridView.TabIndex = 0;
            // 
            // btnImpexpProcess
            // 
            this.btnImpexpProcess.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnImpexpProcess.Location = new System.Drawing.Point(576, 19);
            this.btnImpexpProcess.Name = "btnImpexpProcess";
            this.btnImpexpProcess.Size = new System.Drawing.Size(94, 23);
            this.btnImpexpProcess.TabIndex = 1;
            this.btnImpexpProcess.Text = "Nhập kho";
            this.btnImpexpProcess.UseVisualStyleBackColor = true;
            // 
            // material
            // 
            this.material.FillWeight = 250F;
            this.material.HeaderText = "Nguyên liệu";
            this.material.Name = "material";
            this.material.Width = 250;
            // 
            // colMaterialId
            // 
            this.colMaterialId.HeaderText = "materialId";
            this.colMaterialId.Name = "colMaterialId";
            this.colMaterialId.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(710, 446);
            this.Controls.Add(this.impexpListGroupBox);
            this.Controls.Add(this.impexpGroupBox);
            this.Name = "NhapXuatKho";
            this.Text = "Nhập kho";
            this.impexpGroupBox.ResumeLayout(false);
            this.impexpGroupBox.PerformLayout();
            this.impexpListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.impexpDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox impexpGroupBox;
        private mcontrol.MLabel lblReason;
        private mcontrol.MTextBox mTextBox2;
        private mcontrol.MTextBox mTextBox1;
        private mcontrol.MLabel lblAmount;
        private mcontrol.MComboBox mComboBox1;
        private mcontrol.MLabel lblMaterial;
        private mcontrol.MButton lblAddImpexp;
        private mcontrol.MGroupBox impexpListGroupBox;
        private mcontrol.MButton btnImpexpProcess;
        private mcontrol.MDataGridView impexpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;

    }
}