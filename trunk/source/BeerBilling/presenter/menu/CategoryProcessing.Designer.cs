namespace BeerBilling.presenter.menu
{
    partial class CategoryProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryProcessing));
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.mLabel1 = new mcontrol.MLabel(this.components);
            this.mTextBox1 = new mcontrol.MTextBox(this.components);
            this.mTextBox2 = new mcontrol.MTextBox(this.components);
            this.mLabel2 = new mcontrol.MLabel(this.components);
            this.mButton1 = new mcontrol.MButton(this.components);
            this.mButton2 = new mcontrol.MButton(this.components);
            this.mGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mGroupBox1
            // 
            this.mGroupBox1.Controls.Add(this.mButton2);
            this.mGroupBox1.Controls.Add(this.mButton1);
            this.mGroupBox1.Controls.Add(this.mTextBox2);
            this.mGroupBox1.Controls.Add(this.mLabel2);
            this.mGroupBox1.Controls.Add(this.mTextBox1);
            this.mGroupBox1.Controls.Add(this.mLabel1);
            this.mGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.mGroupBox1.Name = "mGroupBox1";
            this.mGroupBox1.Size = new System.Drawing.Size(333, 179);
            this.mGroupBox1.TabIndex = 0;
            this.mGroupBox1.TabStop = false;
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel1.Location = new System.Drawing.Point(15, 25);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(57, 14);
            this.mLabel1.TabIndex = 0;
            this.mLabel1.Text = "Mã nhóm";
            // 
            // mTextBox1
            // 
            this.mTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mTextBox1.Location = new System.Drawing.Point(85, 22);
            this.mTextBox1.Name = "mTextBox1";
            this.mTextBox1.Size = new System.Drawing.Size(212, 23);
            this.mTextBox1.TabIndex = 1;
            // 
            // mTextBox2
            // 
            this.mTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mTextBox2.Location = new System.Drawing.Point(85, 61);
            this.mTextBox2.Name = "mTextBox2";
            this.mTextBox2.Size = new System.Drawing.Size(212, 23);
            this.mTextBox2.TabIndex = 3;
            // 
            // mLabel2
            // 
            this.mLabel2.AutoSize = true;
            this.mLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel2.Location = new System.Drawing.Point(15, 64);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(64, 14);
            this.mLabel2.TabIndex = 2;
            this.mLabel2.Text = "Tên nhóm";
            // 
            // mButton1
            // 
            this.mButton1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mButton1.Image = global::BeerBilling.Properties.Resources.Save;
            this.mButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mButton1.Location = new System.Drawing.Point(35, 115);
            this.mButton1.Name = "mButton1";
            this.mButton1.Size = new System.Drawing.Size(114, 25);
            this.mButton1.TabIndex = 4;
            this.mButton1.Text = "Cập nhật";
            this.mButton1.UseVisualStyleBackColor = true;
            // 
            // mButton2
            // 
            this.mButton2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mButton2.Image = global::BeerBilling.Properties.Resources.Exit;
            this.mButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mButton2.Location = new System.Drawing.Point(170, 115);
            this.mButton2.Name = "mButton2";
            this.mButton2.Size = new System.Drawing.Size(114, 25);
            this.mButton2.TabIndex = 5;
            this.mButton2.Text = "Thoát";
            this.mButton2.UseVisualStyleBackColor = true;
            // 
            // CategoryProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 207);
            this.Controls.Add(this.mGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryProcessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật nhóm";
            this.mGroupBox1.ResumeLayout(false);
            this.mGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox mGroupBox1;
        private mcontrol.MButton mButton1;
        private mcontrol.MTextBox mTextBox2;
        private mcontrol.MLabel mLabel2;
        private mcontrol.MTextBox mTextBox1;
        private mcontrol.MLabel mLabel1;
        private mcontrol.MButton mButton2;
    }
}