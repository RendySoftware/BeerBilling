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
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.mLabel1 = new mcontrol.MLabel(this.components);
            this.txtKhachTt = new mcontrol.MNumberTextBox2(this.components);
            this.mLabel2 = new mcontrol.MLabel(this.components);
            this.btnHuy = new mcontrol.MButton(this.components);
            this.btnDongY = new mcontrol.MButton(this.components);
            this.mGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mGroupBox1
            // 
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
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel1.Location = new System.Drawing.Point(18, 44);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(46, 14);
            this.mLabel1.TabIndex = 0;
            this.mLabel1.Text = "Số tiền";
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
            this.txtKhachTt.Location = new System.Drawing.Point(70, 41);
            this.txtKhachTt.Mandatory = false;
            this.txtKhachTt.Name = "txtKhachTt";
            this.txtKhachTt.Size = new System.Drawing.Size(178, 23);
            this.txtKhachTt.TabIndex = 1;
            // 
            // mLabel2
            // 
            this.mLabel2.AutoSize = true;
            this.mLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel2.Location = new System.Drawing.Point(254, 44);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(73, 14);
            this.mLabel2.TabIndex = 2;
            this.mLabel2.Text = "(1000 VNĐ)";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHuy.Location = new System.Drawing.Point(187, 103);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDongY.Location = new System.Drawing.Point(62, 103);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(100, 23);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // ThongTinKhachTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 198);
            this.Controls.Add(this.mGroupBox1);
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
        private mcontrol.MLabel mLabel2;
        private mcontrol.MNumberTextBox2 txtKhachTt;
        private mcontrol.MLabel mLabel1;
    }
}