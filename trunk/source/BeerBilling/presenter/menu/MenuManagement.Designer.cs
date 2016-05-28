namespace BeerBilling.presenter.menu
{
    partial class MenuManagement
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
            this.categoryGroupBox = new mcontrol.MGroupBox(this.components);
            this.btnAddCategory = new mcontrol.MButton(this.components);
            this.mDataGridView1 = new mcontrol.MDataGridView(this.components);
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuListGroupBox = new mcontrol.MGroupBox(this.components);
            this.btnAddMenu = new mcontrol.MButton(this.components);
            this.mDataGridView2 = new mcontrol.MDataGridView(this.components);
            this.menuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editMenu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridView1)).BeginInit();
            this.menuListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.mDataGridView1);
            this.categoryGroupBox.Controls.Add(this.btnAddCategory);
            this.categoryGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.categoryGroupBox.Location = new System.Drawing.Point(13, 13);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(759, 177);
            this.categoryGroupBox.TabIndex = 0;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Text = "Nhóm thực đơn";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAddCategory.Location = new System.Drawing.Point(7, 20);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // mDataGridView1
            // 
            this.mDataGridView1.AllowUserToAddRows = false;
            this.mDataGridView1.AllowUserToDeleteRows = false;
            this.mDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.edit});
            this.mDataGridView1.Location = new System.Drawing.Point(7, 50);
            this.mDataGridView1.MultiSelect = false;
            this.mDataGridView1.Name = "mDataGridView1";
            this.mDataGridView1.RowHeadersVisible = false;
            this.mDataGridView1.Size = new System.Drawing.Size(746, 121);
            this.mDataGridView1.TabIndex = 1;
            // 
            // code
            // 
            this.code.HeaderText = "Mã nhóm";
            this.code.Name = "code";
            // 
            // name
            // 
            this.name.FillWeight = 300F;
            this.name.HeaderText = "Tên nhóm";
            this.name.Name = "name";
            this.name.Width = 300;
            // 
            // edit
            // 
            this.edit.HeaderText = "Sửa";
            this.edit.Name = "edit";
            // 
            // menuListGroupBox
            // 
            this.menuListGroupBox.Controls.Add(this.mDataGridView2);
            this.menuListGroupBox.Controls.Add(this.btnAddMenu);
            this.menuListGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.menuListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.menuListGroupBox.Location = new System.Drawing.Point(13, 197);
            this.menuListGroupBox.Name = "menuListGroupBox";
            this.menuListGroupBox.Size = new System.Drawing.Size(759, 353);
            this.menuListGroupBox.TabIndex = 1;
            this.menuListGroupBox.TabStop = false;
            this.menuListGroupBox.Text = "Danh sách thực đơn";
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAddMenu.Location = new System.Drawing.Point(7, 20);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(75, 23);
            this.btnAddMenu.TabIndex = 0;
            this.btnAddMenu.Text = "Thêm";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            // 
            // mDataGridView2
            // 
            this.mDataGridView2.AllowUserToAddRows = false;
            this.mDataGridView2.AllowUserToDeleteRows = false;
            this.mDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuCode,
            this.menuName,
            this.unit,
            this.price,
            this.description,
            this.editMenu,
            this.menuId});
            this.mDataGridView2.Location = new System.Drawing.Point(7, 50);
            this.mDataGridView2.MultiSelect = false;
            this.mDataGridView2.Name = "mDataGridView2";
            this.mDataGridView2.RowHeadersVisible = false;
            this.mDataGridView2.Size = new System.Drawing.Size(746, 297);
            this.mDataGridView2.TabIndex = 1;
            // 
            // menuCode
            // 
            this.menuCode.HeaderText = "Mã";
            this.menuCode.Name = "menuCode";
            // 
            // menuName
            // 
            this.menuName.FillWeight = 250F;
            this.menuName.HeaderText = "Tên";
            this.menuName.Name = "menuName";
            this.menuName.Width = 250;
            // 
            // unit
            // 
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            // 
            // description
            // 
            this.description.HeaderText = "Chi tiết";
            this.description.Name = "description";
            // 
            // editMenu
            // 
            this.editMenu.HeaderText = "Sửa";
            this.editMenu.Name = "editMenu";
            this.editMenu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editMenu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // menuId
            // 
            this.menuId.HeaderText = "menuId";
            this.menuId.Name = "menuId";
            this.menuId.Visible = false;
            // 
            // MenuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuListGroupBox);
            this.Controls.Add(this.categoryGroupBox);
            this.Name = "MenuManagement";
            this.Text = "Quản lý thực đơn";
            this.categoryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridView1)).EndInit();
            this.menuListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox categoryGroupBox;
        private mcontrol.MDataGridView mDataGridView1;
        private mcontrol.MButton btnAddCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private mcontrol.MGroupBox menuListGroupBox;
        private mcontrol.MDataGridView mDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewButtonColumn editMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuId;
        private mcontrol.MButton btnAddMenu;
    }
}