namespace BeerBilling.presenter.statistic
{
    partial class ThongKeTonKho
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
            this.inventoryStatisticGroupBox = new mcontrol.MGroupBox(this.components);
            this.lblFromDate = new mcontrol.MLabel(this.components);
            this.txtFromDate = new mcontrol.MDateTextBox(this.components);
            this.lblToDate = new mcontrol.MLabel(this.components);
            this.txtToDate = new mcontrol.MDateTextBox(this.components);
            this.btnThucHien = new mcontrol.MButton(this.components);
            this.inventoryListGroupBox = new mcontrol.MGroupBox(this.components);
            this.inventoryDataGridView = new mcontrol.MDataGridView(this.components);
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryStatisticGroupBox.SuspendLayout();
            this.inventoryListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryStatisticGroupBox
            // 
            this.inventoryStatisticGroupBox.Controls.Add(this.btnThucHien);
            this.inventoryStatisticGroupBox.Controls.Add(this.txtToDate);
            this.inventoryStatisticGroupBox.Controls.Add(this.lblToDate);
            this.inventoryStatisticGroupBox.Controls.Add(this.txtFromDate);
            this.inventoryStatisticGroupBox.Controls.Add(this.lblFromDate);
            this.inventoryStatisticGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inventoryStatisticGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.inventoryStatisticGroupBox.Location = new System.Drawing.Point(13, 13);
            this.inventoryStatisticGroupBox.Name = "inventoryStatisticGroupBox";
            this.inventoryStatisticGroupBox.Size = new System.Drawing.Size(759, 68);
            this.inventoryStatisticGroupBox.TabIndex = 0;
            this.inventoryStatisticGroupBox.TabStop = false;
            this.inventoryStatisticGroupBox.Text = "Tra cứu tồn kho";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFromDate.Location = new System.Drawing.Point(7, 27);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(53, 14);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "Từ ngày";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFromDate.Location = new System.Drawing.Point(63, 23);
            this.txtFromDate.MaxLength = 10;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(195, 23);
            this.txtFromDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblToDate.Location = new System.Drawing.Point(296, 27);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(59, 14);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "Đến ngày";
            // 
            // txtToDate
            // 
            this.txtToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtToDate.Location = new System.Drawing.Point(360, 23);
            this.txtToDate.MaxLength = 10;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(171, 23);
            this.txtToDate.TabIndex = 3;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThucHien.Location = new System.Drawing.Point(585, 23);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(85, 23);
            this.btnThucHien.TabIndex = 4;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            // 
            // inventoryListGroupBox
            // 
            this.inventoryListGroupBox.Controls.Add(this.inventoryDataGridView);
            this.inventoryListGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inventoryListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.inventoryListGroupBox.Location = new System.Drawing.Point(13, 99);
            this.inventoryListGroupBox.Name = "inventoryListGroupBox";
            this.inventoryListGroupBox.Size = new System.Drawing.Size(759, 451);
            this.inventoryListGroupBox.TabIndex = 1;
            this.inventoryListGroupBox.TabStop = false;
            this.inventoryListGroupBox.Text = "Danh sách tồn kho";
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AllowUserToAddRows = false;
            this.inventoryDataGridView.AllowUserToDeleteRows = false;
            this.inventoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.material,
            this.unit,
            this.previousInventory,
            this.impAmount,
            this.expAmount,
            this.inventory});
            this.inventoryDataGridView.Location = new System.Drawing.Point(10, 29);
            this.inventoryDataGridView.MultiSelect = false;
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.RowHeadersVisible = false;
            this.inventoryDataGridView.Size = new System.Drawing.Size(743, 416);
            this.inventoryDataGridView.TabIndex = 0;
            // 
            // material
            // 
            this.material.FillWeight = 200F;
            this.material.HeaderText = "Nguyên liệu";
            this.material.Name = "material";
            this.material.Width = 200;
            // 
            // unit
            // 
            this.unit.FillWeight = 80F;
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            this.unit.Width = 80;
            // 
            // previousInventory
            // 
            this.previousInventory.FillWeight = 130F;
            this.previousInventory.HeaderText = "Tồn kho kỳ trước";
            this.previousInventory.Name = "previousInventory";
            this.previousInventory.Width = 130;
            // 
            // impAmount
            // 
            this.impAmount.FillWeight = 115F;
            this.impAmount.HeaderText = "Số lượng nhập";
            this.impAmount.Name = "impAmount";
            this.impAmount.Width = 115;
            // 
            // expAmount
            // 
            this.expAmount.FillWeight = 115F;
            this.expAmount.HeaderText = "Số lượng xuất";
            this.expAmount.Name = "expAmount";
            this.expAmount.Width = 115;
            // 
            // inventory
            // 
            this.inventory.HeaderText = "Tồn kho";
            this.inventory.Name = "inventory";
            // 
            // ThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.inventoryListGroupBox);
            this.Controls.Add(this.inventoryStatisticGroupBox);
            this.Name = "ThongKeTonKho";
            this.Text = "Tồn kho";
            this.inventoryStatisticGroupBox.ResumeLayout(false);
            this.inventoryStatisticGroupBox.PerformLayout();
            this.inventoryListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox inventoryStatisticGroupBox;
        private mcontrol.MButton btnThucHien;
        private mcontrol.MDateTextBox txtToDate;
        private mcontrol.MLabel lblToDate;
        private mcontrol.MDateTextBox txtFromDate;
        private mcontrol.MLabel lblFromDate;
        private mcontrol.MGroupBox inventoryListGroupBox;
        private mcontrol.MDataGridView inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn impAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn expAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
    }
}