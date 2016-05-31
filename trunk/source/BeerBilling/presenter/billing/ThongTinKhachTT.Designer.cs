namespace BeerBilling.presenter.billing
{
    partial class ThongTinKhachTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinKhachTT));
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.cboEmployee = new mcontrol.MComboBox2(this.components);
            this.mLabel3 = new mcontrol.MLabel(this.components);
            this.btnDongY = new mcontrol.MButton(this.components);
            this.btnHuy = new mcontrol.MButton(this.components);
            this.mLabel2 = new mcontrol.MLabel(this.components);
            this.txtKhachTt = new mcontrol.MNumberTextBox3(this.components);
            this.mLabel1 = new mcontrol.MLabel(this.components);
            this.mGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mGroupBox1
            // 
            this.mGroupBox1.Controls.Add(this.cboEmployee);
            this.mGroupBox1.Controls.Add(this.mLabel3);
            this.mGroupBox1.Controls.Add(this.btnDongY);
            this.mGroupBox1.Controls.Add(this.btnHuy);
            this.mGroupBox1.Controls.Add(this.mLabel2);
            this.mGroupBox1.Controls.Add(this.txtKhachTt);
            this.mGroupBox1.Controls.Add(this.mLabel1);
            this.mGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.mGroupBox1.Name = "mGroupBox1";
            this.mGroupBox1.Size = new System.Drawing.Size(348, 173);
            this.mGroupBox1.TabIndex = 0;
            this.mGroupBox1.TabStop = false;
            // 
            // cboEmployee
            // 
            this.cboEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEmployee.Enabled = false;
            this.cboEmployee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.LimitToList = true;
            this.cboEmployee.Location = new System.Drawing.Point(92, 30);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(193, 24);
            this.cboEmployee.TabIndex = 6;
            // 
            // mLabel3
            // 
            this.mLabel3.AutoSize = true;
            this.mLabel3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel3.Location = new System.Drawing.Point(25, 34);
            this.mLabel3.Name = "mLabel3";
            this.mLabel3.Size = new System.Drawing.Size(61, 14);
            this.mLabel3.TabIndex = 5;
            this.mLabel3.Text = "Nhân viên";
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDongY.Image = global::BeerBilling.Properties.Resources.Apply;
            this.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongY.Location = new System.Drawing.Point(60, 122);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(100, 25);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHuy.Image = global::BeerBilling.Properties.Resources.Cance_Delete;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(185, 122);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 25);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // mLabel2
            // 
            this.mLabel2.AutoSize = true;
            this.mLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel2.Location = new System.Drawing.Point(291, 80);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(31, 14);
            this.mLabel2.TabIndex = 2;
            this.mLabel2.Text = "VNĐ";
            // 
            // txtKhachTt
            // 
            this.txtKhachTt.AllowAlphaOnly = false;
            this.txtKhachTt.AllowNumericOnly = false;
            this.txtKhachTt.AllowSpecialCharecterOnly = false;
            this.txtKhachTt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhachTt.ErrorMessage = "";
            this.txtKhachTt.ErrorMessageTitle = "";
            this.txtKhachTt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtKhachTt.Location = new System.Drawing.Point(92, 77);
            this.txtKhachTt.Mandatory = false;
            this.txtKhachTt.Name = "txtKhachTt";
            this.txtKhachTt.Size = new System.Drawing.Size(193, 23);
            this.txtKhachTt.TabIndex = 1;
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel1.Location = new System.Drawing.Point(22, 80);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(46, 14);
            this.mLabel1.TabIndex = 0;
            this.mLabel1.Text = "Số tiền";
            // 
            // ThongTinKhachTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 198);
            this.Controls.Add(this.mGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThongTinKhachTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách thanh toán";
            this.mGroupBox1.ResumeLayout(false);
            this.mGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox mGroupBox1;
        private mcontrol.MButton btnDongY;
        private mcontrol.MButton btnHuy;
        private mcontrol.MNumberTextBox3 txtKhachTt;
        private mcontrol.MLabel mLabel1;
        private mcontrol.MLabel mLabel2;
        private mcontrol.MComboBox2 cboEmployee;
        private mcontrol.MLabel mLabel3;
    }
}