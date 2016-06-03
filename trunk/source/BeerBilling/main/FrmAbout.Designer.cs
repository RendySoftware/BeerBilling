namespace BeerBilling.main
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.mLabel1 = new mcontrol.MLabel(this.components);
            this.mLabel2 = new mcontrol.MLabel(this.components);
            this.mTextBox1 = new mcontrol.MTextBox(this.components);
            this.mGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mGroupBox1
            // 
            this.mGroupBox1.Controls.Add(this.mTextBox1);
            this.mGroupBox1.Controls.Add(this.mLabel2);
            this.mGroupBox1.Controls.Add(this.mLabel1);
            this.mGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.mGroupBox1.Name = "mGroupBox1";
            this.mGroupBox1.Size = new System.Drawing.Size(476, 267);
            this.mGroupBox1.TabIndex = 0;
            this.mGroupBox1.TabStop = false;
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel1.ForeColor = System.Drawing.Color.Blue;
            this.mLabel1.Location = new System.Drawing.Point(77, 33);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(314, 23);
            this.mLabel1.TabIndex = 0;
            this.mLabel1.Text = "PHẦN MỀM QUẢN LÝ QUÁN BIA";
            // 
            // mLabel2
            // 
            this.mLabel2.AutoSize = true;
            this.mLabel2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel2.ForeColor = System.Drawing.Color.Purple;
            this.mLabel2.Location = new System.Drawing.Point(166, 76);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(123, 18);
            this.mLabel2.TabIndex = 1;
            this.mLabel2.Text = "Phiên bản 1.0.0.1";
            // 
            // mTextBox1
            // 
            this.mTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.mTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTextBox1.Enabled = false;
            this.mTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTextBox1.Location = new System.Drawing.Point(41, 124);
            this.mTextBox1.Multiline = true;
            this.mTextBox1.Name = "mTextBox1";
            this.mTextBox1.ReadOnly = true;
            this.mTextBox1.Size = new System.Drawing.Size(395, 99);
            this.mTextBox1.TabIndex = 2;
            this.mTextBox1.Text = resources.GetString("mTextBox1.Text");
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 291);
            this.Controls.Add(this.mGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phần mềm";
            this.mGroupBox1.ResumeLayout(false);
            this.mGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox mGroupBox1;
        private mcontrol.MLabel mLabel2;
        private mcontrol.MLabel mLabel1;
        private mcontrol.MTextBox mTextBox1;
    }
}