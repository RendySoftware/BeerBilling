namespace BeerBilling.presenter.billing
{
    partial class BillingAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingAdd));
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.cboEmployee = new mcontrol.MComboBox2(this.components);
            this.mLabel3 = new mcontrol.MLabel(this.components);
            this.cboBanSo = new mcontrol.MComboBox2(this.components);
            this.btnThem = new mcontrol.MButton(this.components);
            this.mLabel2 = new mcontrol.MLabel(this.components);
            this.txtHoaDonSo = new mcontrol.MNumberTextBox2(this.components);
            this.mLabel1 = new mcontrol.MLabel(this.components);
            this.mGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mGroupBox1
            // 
            this.mGroupBox1.Controls.Add(this.cboEmployee);
            this.mGroupBox1.Controls.Add(this.mLabel3);
            this.mGroupBox1.Controls.Add(this.cboBanSo);
            this.mGroupBox1.Controls.Add(this.btnThem);
            this.mGroupBox1.Controls.Add(this.mLabel2);
            this.mGroupBox1.Controls.Add(this.txtHoaDonSo);
            this.mGroupBox1.Controls.Add(this.mLabel1);
            this.mGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.mGroupBox1.Name = "mGroupBox1";
            this.mGroupBox1.Size = new System.Drawing.Size(357, 221);
            this.mGroupBox1.TabIndex = 0;
            this.mGroupBox1.TabStop = false;
            // 
            // cboEmployee
            // 
            this.cboEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEmployee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.LimitToList = true;
            this.cboEmployee.Location = new System.Drawing.Point(116, 36);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(193, 24);
            this.cboEmployee.TabIndex = 1;
            // 
            // mLabel3
            // 
            this.mLabel3.AutoSize = true;
            this.mLabel3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel3.Location = new System.Drawing.Point(40, 40);
            this.mLabel3.Name = "mLabel3";
            this.mLabel3.Size = new System.Drawing.Size(61, 14);
            this.mLabel3.TabIndex = 7;
            this.mLabel3.Text = "Nhân viên";
            // 
            // cboBanSo
            // 
            this.cboBanSo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBanSo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBanSo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboBanSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboBanSo.FormattingEnabled = true;
            this.cboBanSo.LimitToList = true;
            this.cboBanSo.Location = new System.Drawing.Point(116, 121);
            this.cboBanSo.Name = "cboBanSo";
            this.cboBanSo.Size = new System.Drawing.Size(193, 24);
            this.cboBanSo.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThem.Image = global::BeerBilling.Properties.Resources.Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(128, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 25);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // mLabel2
            // 
            this.mLabel2.AutoSize = true;
            this.mLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel2.Location = new System.Drawing.Point(40, 125);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(43, 14);
            this.mLabel2.TabIndex = 2;
            this.mLabel2.Text = "Bàn số";
            // 
            // txtHoaDonSo
            // 
            this.txtHoaDonSo.AllowAlphaOnly = false;
            this.txtHoaDonSo.AllowNumericOnly = false;
            this.txtHoaDonSo.AllowSpecialCharecterOnly = false;
            this.txtHoaDonSo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoaDonSo.ErrorMessage = "";
            this.txtHoaDonSo.ErrorMessageTitle = "";
            this.txtHoaDonSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHoaDonSo.Location = new System.Drawing.Point(116, 79);
            this.txtHoaDonSo.Mandatory = false;
            this.txtHoaDonSo.Name = "txtHoaDonSo";
            this.txtHoaDonSo.Size = new System.Drawing.Size(193, 23);
            this.txtHoaDonSo.TabIndex = 2;
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel1.Location = new System.Drawing.Point(40, 82);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(69, 14);
            this.mLabel1.TabIndex = 0;
            this.mLabel1.Text = "Hóa đơn số";
            // 
            // BillingAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 246);
            this.Controls.Add(this.mGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillingAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới";
            this.mGroupBox1.ResumeLayout(false);
            this.mGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox mGroupBox1;
        private mcontrol.MButton btnThem;
        private mcontrol.MLabel mLabel2;
        private mcontrol.MNumberTextBox2 txtHoaDonSo;
        private mcontrol.MLabel mLabel1;
        private mcontrol.MComboBox2 cboBanSo;
        private mcontrol.MComboBox2 cboEmployee;
        private mcontrol.MLabel mLabel3;
    }
}