namespace BeerBilling.presenter.user
{
    partial class FrmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMatKhau));
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.btnHuy = new mcontrol.MButton(this.components);
            this.mLabel4 = new mcontrol.MLabel(this.components);
            this.btnDongY = new mcontrol.MButton(this.components);
            this.txtMkMoi2 = new mcontrol.MTextBox(this.components);
            this.mLabel3 = new mcontrol.MLabel(this.components);
            this.txtMkMoi = new mcontrol.MTextBox(this.components);
            this.mLabel2 = new mcontrol.MLabel(this.components);
            this.mLabel1 = new mcontrol.MLabel(this.components);
            this.txtMkCu = new mcontrol.MTextBox(this.components);
            this.dspTen = new mcontrol.MDisplayTextBox(this.components);
            this.mGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mGroupBox1
            // 
            this.mGroupBox1.Controls.Add(this.btnHuy);
            this.mGroupBox1.Controls.Add(this.mLabel4);
            this.mGroupBox1.Controls.Add(this.btnDongY);
            this.mGroupBox1.Controls.Add(this.txtMkMoi2);
            this.mGroupBox1.Controls.Add(this.mLabel3);
            this.mGroupBox1.Controls.Add(this.txtMkMoi);
            this.mGroupBox1.Controls.Add(this.mLabel2);
            this.mGroupBox1.Controls.Add(this.mLabel1);
            this.mGroupBox1.Controls.Add(this.txtMkCu);
            this.mGroupBox1.Controls.Add(this.dspTen);
            this.mGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox1.Location = new System.Drawing.Point(10, 8);
            this.mGroupBox1.Name = "mGroupBox1";
            this.mGroupBox1.Size = new System.Drawing.Size(428, 209);
            this.mGroupBox1.TabIndex = 10;
            this.mGroupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(298, 162);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 25);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "   &2. Hủy bỏ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.mButton2_Click);
            // 
            // mLabel4
            // 
            this.mLabel4.AutoSize = true;
            this.mLabel4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel4.Location = new System.Drawing.Point(33, 121);
            this.mLabel4.Name = "mLabel4";
            this.mLabel4.Size = new System.Drawing.Size(126, 14);
            this.mLabel4.TabIndex = 7;
            this.mLabel4.Text = "Nhập lại Mật khẩu mới";
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongY.Location = new System.Drawing.Point(199, 162);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(93, 25);
            this.btnDongY.TabIndex = 8;
            this.btnDongY.Text = "   &1. Đồng ý";
            this.btnDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.mButton1_Click);
            // 
            // txtMkMoi2
            // 
            this.txtMkMoi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMkMoi2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMkMoi2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMkMoi2.Location = new System.Drawing.Point(162, 118);
            this.txtMkMoi2.Name = "txtMkMoi2";
            this.txtMkMoi2.PasswordChar = '*';
            this.txtMkMoi2.Size = new System.Drawing.Size(229, 22);
            this.txtMkMoi2.TabIndex = 6;
            // 
            // mLabel3
            // 
            this.mLabel3.AutoSize = true;
            this.mLabel3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel3.Location = new System.Drawing.Point(79, 90);
            this.mLabel3.Name = "mLabel3";
            this.mLabel3.Size = new System.Drawing.Size(80, 14);
            this.mLabel3.TabIndex = 5;
            this.mLabel3.Text = "Mật khẩu mới";
            // 
            // txtMkMoi
            // 
            this.txtMkMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMkMoi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMkMoi.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMkMoi.Location = new System.Drawing.Point(162, 87);
            this.txtMkMoi.Name = "txtMkMoi";
            this.txtMkMoi.PasswordChar = '*';
            this.txtMkMoi.Size = new System.Drawing.Size(229, 22);
            this.txtMkMoi.TabIndex = 4;
            // 
            // mLabel2
            // 
            this.mLabel2.AutoSize = true;
            this.mLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel2.Location = new System.Drawing.Point(85, 60);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(74, 14);
            this.mLabel2.TabIndex = 3;
            this.mLabel2.Text = "Mật khẩu cũ";
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel1.Location = new System.Drawing.Point(81, 30);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(78, 14);
            this.mLabel1.TabIndex = 2;
            this.mLabel1.Text = "Tên truy cập";
            this.mLabel1.Click += new System.EventHandler(this.mLabel1_Click);
            // 
            // txtMkCu
            // 
            this.txtMkCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMkCu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMkCu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMkCu.Location = new System.Drawing.Point(162, 57);
            this.txtMkCu.Name = "txtMkCu";
            this.txtMkCu.PasswordChar = '*';
            this.txtMkCu.Size = new System.Drawing.Size(229, 22);
            this.txtMkCu.TabIndex = 1;
            // 
            // dspTen
            // 
            this.dspTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dspTen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dspTen.Enabled = false;
            this.dspTen.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dspTen.Location = new System.Drawing.Point(162, 27);
            this.dspTen.Name = "dspTen";
            this.dspTen.Size = new System.Drawing.Size(229, 22);
            this.dspTen.TabIndex = 0;
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 238);
            this.Controls.Add(this.mGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoiMatKhau";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.FrmDoiMatKhau_Load);
            this.mGroupBox1.ResumeLayout(false);
            this.mGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MDisplayTextBox dspTen;
        private mcontrol.MTextBox txtMkCu;
        private mcontrol.MLabel mLabel1;
        private mcontrol.MLabel mLabel2;
        private mcontrol.MLabel mLabel3;
        private mcontrol.MTextBox txtMkMoi;
        private mcontrol.MLabel mLabel4;
        private mcontrol.MTextBox txtMkMoi2;
        private mcontrol.MButton btnDongY;
        private mcontrol.MButton btnHuy;
        private mcontrol.MGroupBox mGroupBox1;
    }
}