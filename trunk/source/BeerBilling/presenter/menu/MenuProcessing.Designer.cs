namespace BeerBilling.presenter.menu
{
    partial class MenuProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProcessing));
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.btnThoat = new mcontrol.MButton(this.components);
            this.btnCapNhat = new mcontrol.MButton(this.components);
            this.txtDescription = new mcontrol.MTextBox(this.components);
            this.mLabel6 = new mcontrol.MLabel(this.components);
            this.txtPrice = new mcontrol.MNumberTextBox3(this.components);
            this.mLabel5 = new mcontrol.MLabel(this.components);
            this.cboUnit = new mcontrol.MComboBox(this.components);
            this.mLabel4 = new mcontrol.MLabel(this.components);
            this.txtCategory = new mcontrol.MTextBox(this.components);
            this.mLabel3 = new mcontrol.MLabel(this.components);
            this.txtMenuName = new mcontrol.MTextBox(this.components);
            this.mLabel2 = new mcontrol.MLabel(this.components);
            this.txtMenuCode = new mcontrol.MTextBox(this.components);
            this.mLabel1 = new mcontrol.MLabel(this.components);
            this.mGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mGroupBox1
            // 
            this.mGroupBox1.Controls.Add(this.btnThoat);
            this.mGroupBox1.Controls.Add(this.btnCapNhat);
            this.mGroupBox1.Controls.Add(this.txtDescription);
            this.mGroupBox1.Controls.Add(this.mLabel6);
            this.mGroupBox1.Controls.Add(this.txtPrice);
            this.mGroupBox1.Controls.Add(this.mLabel5);
            this.mGroupBox1.Controls.Add(this.cboUnit);
            this.mGroupBox1.Controls.Add(this.mLabel4);
            this.mGroupBox1.Controls.Add(this.txtCategory);
            this.mGroupBox1.Controls.Add(this.mLabel3);
            this.mGroupBox1.Controls.Add(this.txtMenuName);
            this.mGroupBox1.Controls.Add(this.mLabel2);
            this.mGroupBox1.Controls.Add(this.txtMenuCode);
            this.mGroupBox1.Controls.Add(this.mLabel1);
            this.mGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.mGroupBox1.Name = "mGroupBox1";
            this.mGroupBox1.Size = new System.Drawing.Size(349, 336);
            this.mGroupBox1.TabIndex = 0;
            this.mGroupBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThoat.Image = global::BeerBilling.Properties.Resources.Exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(169, 270);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 25);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnCapNhat.Image = global::BeerBilling.Properties.Resources.Save;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(34, 270);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(114, 25);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescription.Location = new System.Drawing.Point(84, 223);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(215, 23);
            this.txtDescription.TabIndex = 4;
            // 
            // mLabel6
            // 
            this.mLabel6.AutoSize = true;
            this.mLabel6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel6.Location = new System.Drawing.Point(23, 226);
            this.mLabel6.Name = "mLabel6";
            this.mLabel6.Size = new System.Drawing.Size(46, 14);
            this.mLabel6.TabIndex = 10;
            this.mLabel6.Text = "Chi tiết";
            // 
            // txtPrice
            // 
            this.txtPrice.AllowAlphaOnly = false;
            this.txtPrice.AllowNumericOnly = false;
            this.txtPrice.AllowSpecialCharecterOnly = false;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.ErrorMessage = "";
            this.txtPrice.ErrorMessageTitle = "";
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.Location = new System.Drawing.Point(84, 184);
            this.txtPrice.Mandatory = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(215, 23);
            this.txtPrice.TabIndex = 3;
            // 
            // mLabel5
            // 
            this.mLabel5.AutoSize = true;
            this.mLabel5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel5.Location = new System.Drawing.Point(23, 187);
            this.mLabel5.Name = "mLabel5";
            this.mLabel5.Size = new System.Drawing.Size(23, 14);
            this.mLabel5.TabIndex = 8;
            this.mLabel5.Text = "Giá";
            // 
            // cboUnit
            // 
            this.cboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUnit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.LimitToList = true;
            this.cboUnit.Location = new System.Drawing.Point(84, 145);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(215, 24);
            this.cboUnit.TabIndex = 2;
            // 
            // mLabel4
            // 
            this.mLabel4.AutoSize = true;
            this.mLabel4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel4.Location = new System.Drawing.Point(23, 148);
            this.mLabel4.Name = "mLabel4";
            this.mLabel4.Size = new System.Drawing.Size(41, 14);
            this.mLabel4.TabIndex = 6;
            this.mLabel4.Text = "Đơn vị";
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCategory.Location = new System.Drawing.Point(84, 105);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(215, 23);
            this.txtCategory.TabIndex = 8;
            // 
            // mLabel3
            // 
            this.mLabel3.AutoSize = true;
            this.mLabel3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel3.Location = new System.Drawing.Point(23, 108);
            this.mLabel3.Name = "mLabel3";
            this.mLabel3.Size = new System.Drawing.Size(39, 14);
            this.mLabel3.TabIndex = 4;
            this.mLabel3.Text = "Nhóm";
            // 
            // txtMenuName
            // 
            this.txtMenuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMenuName.Location = new System.Drawing.Point(84, 64);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(215, 23);
            this.txtMenuName.TabIndex = 1;
            // 
            // mLabel2
            // 
            this.mLabel2.AutoSize = true;
            this.mLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel2.Location = new System.Drawing.Point(23, 67);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(29, 14);
            this.mLabel2.TabIndex = 2;
            this.mLabel2.Text = "Tên";
            // 
            // txtMenuCode
            // 
            this.txtMenuCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMenuCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMenuCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMenuCode.Location = new System.Drawing.Point(84, 24);
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.ReadOnly = true;
            this.txtMenuCode.Size = new System.Drawing.Size(215, 23);
            this.txtMenuCode.TabIndex = 7;
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel1.Location = new System.Drawing.Point(23, 27);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(22, 14);
            this.mLabel1.TabIndex = 0;
            this.mLabel1.Text = "Mã";
            // 
            // MenuProcessing
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(374, 360);
            this.Controls.Add(this.mGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuProcessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thực đơn";
            this.mGroupBox1.ResumeLayout(false);
            this.mGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox mGroupBox1;
        private mcontrol.MTextBox txtDescription;
        private mcontrol.MLabel mLabel6;
        private mcontrol.MNumberTextBox3 txtPrice;
        private mcontrol.MLabel mLabel5;
        private mcontrol.MComboBox cboUnit;
        private mcontrol.MLabel mLabel4;
        private mcontrol.MTextBox txtCategory;
        private mcontrol.MLabel mLabel3;
        private mcontrol.MTextBox txtMenuName;
        private mcontrol.MLabel mLabel2;
        private mcontrol.MTextBox txtMenuCode;
        private mcontrol.MLabel mLabel1;
        private mcontrol.MButton btnThoat;
        private mcontrol.MButton btnCapNhat;
    }
}