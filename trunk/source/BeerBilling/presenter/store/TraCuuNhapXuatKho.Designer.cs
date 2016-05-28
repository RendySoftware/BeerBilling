namespace BeerBilling.presenter.kho
{
    partial class TraCuuNhapXuatKho
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
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.btnThucHien = new mcontrol.MButton(this.components);
            this.expCheckBox = new mcontrol.MCheckBox(this.components);
            this.impCheckBox = new mcontrol.MCheckBox(this.components);
            this.txtToDate = new mcontrol.MDateTextBox(this.components);
            this.lblToDate = new mcontrol.MLabel(this.components);
            this.txtFromDate = new mcontrol.MDateTextBox(this.components);
            this.lblFromDate = new mcontrol.MLabel(this.components);
            this.impexpListGroupBox = new mcontrol.MGroupBox(this.components);
            this.impexpDataGridView = new mcontrol.MDataGridView(this.components);
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impexpType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGroupBox1.SuspendLayout();
            this.impexpListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impexpDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mGroupBox1
            // 
            this.mGroupBox1.Controls.Add(this.btnThucHien);
            this.mGroupBox1.Controls.Add(this.expCheckBox);
            this.mGroupBox1.Controls.Add(this.impCheckBox);
            this.mGroupBox1.Controls.Add(this.txtToDate);
            this.mGroupBox1.Controls.Add(this.lblToDate);
            this.mGroupBox1.Controls.Add(this.txtFromDate);
            this.mGroupBox1.Controls.Add(this.lblFromDate);
            this.mGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox1.Location = new System.Drawing.Point(13, 12);
            this.mGroupBox1.Name = "mGroupBox1";
            this.mGroupBox1.Size = new System.Drawing.Size(753, 70);
            this.mGroupBox1.TabIndex = 0;
            this.mGroupBox1.TabStop = false;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThucHien.Location = new System.Drawing.Point(660, 24);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(87, 23);
            this.btnThucHien.TabIndex = 6;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            // 
            // expCheckBox
            // 
            this.expCheckBox.AutoSize = true;
            this.expCheckBox.Checked = true;
            this.expCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.expCheckBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.expCheckBox.Location = new System.Drawing.Point(579, 26);
            this.expCheckBox.Name = "expCheckBox";
            this.expCheckBox.Size = new System.Drawing.Size(75, 18);
            this.expCheckBox.TabIndex = 5;
            this.expCheckBox.Text = "Xuất kho";
            this.expCheckBox.UseVisualStyleBackColor = true;
            // 
            // impCheckBox
            // 
            this.impCheckBox.AllowDrop = true;
            this.impCheckBox.AutoSize = true;
            this.impCheckBox.Checked = true;
            this.impCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.impCheckBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.impCheckBox.Location = new System.Drawing.Point(483, 26);
            this.impCheckBox.Name = "impCheckBox";
            this.impCheckBox.Size = new System.Drawing.Size(78, 18);
            this.impCheckBox.TabIndex = 4;
            this.impCheckBox.Text = "Nhập kho";
            this.impCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtToDate
            // 
            this.txtToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtToDate.Location = new System.Drawing.Point(297, 24);
            this.txtToDate.MaxLength = 10;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(164, 23);
            this.txtToDate.TabIndex = 3;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblToDate.Location = new System.Drawing.Point(232, 28);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(59, 14);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "Đến ngày";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFromDate.Location = new System.Drawing.Point(70, 24);
            this.txtFromDate.MaxLength = 10;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(142, 23);
            this.txtFromDate.TabIndex = 1;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFromDate.Location = new System.Drawing.Point(10, 28);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(53, 14);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // impexpListGroupBox
            // 
            this.impexpListGroupBox.Controls.Add(this.impexpDataGridView);
            this.impexpListGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.impexpListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.impexpListGroupBox.Location = new System.Drawing.Point(13, 98);
            this.impexpListGroupBox.Name = "impexpListGroupBox";
            this.impexpListGroupBox.Size = new System.Drawing.Size(759, 452);
            this.impexpListGroupBox.TabIndex = 1;
            this.impexpListGroupBox.TabStop = false;
            this.impexpListGroupBox.Text = "Danh sách Nhập/Xuất kho";
            // 
            // impexpDataGridView
            // 
            this.impexpDataGridView.AllowUserToAddRows = false;
            this.impexpDataGridView.AllowUserToDeleteRows = false;
            this.impexpDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.impexpDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.impexpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.impexpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.material,
            this.amount,
            this.unit,
            this.impexpType,
            this.createBy,
            this.createdDate,
            this.reason,
            this.updatedBy,
            this.updatedDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.impexpDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.impexpDataGridView.Location = new System.Drawing.Point(7, 36);
            this.impexpDataGridView.MultiSelect = false;
            this.impexpDataGridView.Name = "impexpDataGridView";
            this.impexpDataGridView.RowHeadersVisible = false;
            this.impexpDataGridView.Size = new System.Drawing.Size(746, 362);
            this.impexpDataGridView.TabIndex = 0;
            // 
            // material
            // 
            this.material.FillWeight = 200F;
            this.material.HeaderText = "Nguyên liệu";
            this.material.Name = "material";
            this.material.Width = 200;
            // 
            // amount
            // 
            this.amount.FillWeight = 90F;
            this.amount.HeaderText = "Số lượng";
            this.amount.Name = "amount";
            this.amount.Width = 90;
            // 
            // unit
            // 
            this.unit.FillWeight = 80F;
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            this.unit.Width = 80;
            // 
            // impexpType
            // 
            this.impexpType.HeaderText = "Nhập/Xuất";
            this.impexpType.Name = "impexpType";
            // 
            // createBy
            // 
            this.createBy.FillWeight = 130F;
            this.createBy.HeaderText = "Người thực hiện";
            this.createBy.Name = "createBy";
            this.createBy.Width = 130;
            // 
            // createdDate
            // 
            this.createdDate.FillWeight = 130F;
            this.createdDate.HeaderText = "Ngày thực hiện";
            this.createdDate.Name = "createdDate";
            this.createdDate.Width = 130;
            // 
            // reason
            // 
            this.reason.FillWeight = 150F;
            this.reason.HeaderText = "Lý do";
            this.reason.Name = "reason";
            this.reason.Width = 150;
            // 
            // updatedBy
            // 
            this.updatedBy.HeaderText = "Người sửa";
            this.updatedBy.Name = "updatedBy";
            // 
            // updatedDate
            // 
            this.updatedDate.HeaderText = "Ngày sửa";
            this.updatedDate.Name = "updatedDate";
            // 
            // TraCuuNhapXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.impexpListGroupBox);
            this.Controls.Add(this.mGroupBox1);
            this.Name = "TraCuuNhapXuatKho";
            this.Text = "Tra cứu";
            this.mGroupBox1.ResumeLayout(false);
            this.mGroupBox1.PerformLayout();
            this.impexpListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.impexpDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox mGroupBox1;
        private mcontrol.MDateTextBox txtFromDate;
        private mcontrol.MLabel lblFromDate;
        private mcontrol.MGroupBox impexpListGroupBox;
        private mcontrol.MButton btnThucHien;
        private mcontrol.MCheckBox expCheckBox;
        private mcontrol.MCheckBox impCheckBox;
        private mcontrol.MDateTextBox txtToDate;
        private mcontrol.MLabel lblToDate;
        private mcontrol.MDataGridView impexpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn impexpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn createBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDate;
    }
}