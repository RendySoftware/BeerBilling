namespace BeerBilling.presenter.user
{
    partial class QuanLyNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNguoiDung));
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.mLabel1 = new mcontrol.MLabel(this.components);
            this.txtUserName = new mcontrol.MTextBox(this.components);
            this.mLabel2 = new mcontrol.MLabel(this.components);
            this.txtFullName = new mcontrol.MTextBox(this.components);
            this.btnSearch = new mcontrol.MButton(this.components);
            this.mDataGridView1 = new mcontrol.MDataGridView(this.components);
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new mcontrol.MButton(this.components);
            this.mGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mGroupBox1
            // 
            this.mGroupBox1.Controls.Add(this.btnAdd);
            this.mGroupBox1.Controls.Add(this.mDataGridView1);
            this.mGroupBox1.Controls.Add(this.btnSearch);
            this.mGroupBox1.Controls.Add(this.txtFullName);
            this.mGroupBox1.Controls.Add(this.mLabel2);
            this.mGroupBox1.Controls.Add(this.txtUserName);
            this.mGroupBox1.Controls.Add(this.mLabel1);
            this.mGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.mGroupBox1.Name = "mGroupBox1";
            this.mGroupBox1.Size = new System.Drawing.Size(726, 395);
            this.mGroupBox1.TabIndex = 0;
            this.mGroupBox1.TabStop = false;
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel1.Location = new System.Drawing.Point(17, 29);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(91, 14);
            this.mLabel1.TabIndex = 0;
            this.mLabel1.Text = "Tên đăng nhập";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserName.Location = new System.Drawing.Point(114, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(156, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // mLabel2
            // 
            this.mLabel2.AutoSize = true;
            this.mLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel2.Location = new System.Drawing.Point(289, 29);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(70, 14);
            this.mLabel2.TabIndex = 2;
            this.mLabel2.Text = "Tên đầy đủ";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFullName.Location = new System.Drawing.Point(365, 26);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(214, 23);
            this.txtFullName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSearch.Image = global::BeerBilling.Properties.Resources.Search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(594, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Thực hiện";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // mDataGridView1
            // 
            this.mDataGridView1.AllowUserToAddRows = false;
            this.mDataGridView1.AllowUserToDeleteRows = false;
            this.mDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.FullName,
            this.RoleName,
            this.Edit,
            this.Delete});
            this.mDataGridView1.Location = new System.Drawing.Point(20, 94);
            this.mDataGridView1.MultiSelect = false;
            this.mDataGridView1.Name = "mDataGridView1";
            this.mDataGridView1.RowHeadersVisible = false;
            this.mDataGridView1.Size = new System.Drawing.Size(688, 283);
            this.mDataGridView1.TabIndex = 5;
            // 
            // UserName
            // 
            this.UserName.FillWeight = 150F;
            this.UserName.HeaderText = "Tên đăng nhập";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 150;
            // 
            // FullName
            // 
            this.FullName.FillWeight = 250F;
            this.FullName.HeaderText = "Tên đầy đủ";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 250;
            // 
            // RoleName
            // 
            this.RoleName.FillWeight = 150F;
            this.RoleName.HeaderText = "Quyền người dùng";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Width = 150;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 60F;
            this.Edit.HeaderText = "Sửa";
            this.Edit.Name = "Edit";
            this.Edit.Width = 60;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 60F;
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 60;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAdd.Image = global::BeerBilling.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(20, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 419);
            this.Controls.Add(this.mGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLyNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.mGroupBox1.ResumeLayout(false);
            this.mGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox mGroupBox1;
        private mcontrol.MButton btnSearch;
        private mcontrol.MTextBox txtFullName;
        private mcontrol.MLabel mLabel2;
        private mcontrol.MTextBox txtUserName;
        private mcontrol.MLabel mLabel1;
        private mcontrol.MButton btnAdd;
        private mcontrol.MDataGridView mDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}