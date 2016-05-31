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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuManagement));
            this.categoryGroupBox = new mcontrol.MGroupBox(this.components);
            this.dgvCategory = new mcontrol.MDataGridView(this.components);
            this.btnAddCategory = new mcontrol.MButton(this.components);
            this.menuListGroupBox = new mcontrol.MGroupBox(this.components);
            this.dgvMenu = new mcontrol.MDataGridView(this.components);
            this.btnAddMenu = new mcontrol.MButton(this.components);
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editMenu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.menuListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.dgvCategory);
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
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.edit,
            this.categoryId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategory.Location = new System.Drawing.Point(7, 50);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(746, 121);
            this.dgvCategory.TabIndex = 1;
            this.dgvCategory.SelectionChanged += new System.EventHandler(this.dgvCategory_SelectionChanged);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAddCategory.Image = global::BeerBilling.Properties.Resources.Add;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(7, 20);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(114, 25);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "&1. Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // menuListGroupBox
            // 
            this.menuListGroupBox.Controls.Add(this.dgvMenu);
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
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuCode,
            this.menuName,
            this.unit,
            this.price,
            this.description,
            this.editMenu,
            this.menuId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMenu.Location = new System.Drawing.Point(7, 50);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(746, 297);
            this.dgvMenu.TabIndex = 1;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAddMenu.Image = global::BeerBilling.Properties.Resources.Add;
            this.btnAddMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMenu.Location = new System.Drawing.Point(7, 20);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(114, 25);
            this.btnAddMenu.TabIndex = 0;
            this.btnAddMenu.Text = "&2. Thêm";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // code
            // 
            this.code.HeaderText = "Mã nhóm";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.FillWeight = 300F;
            this.name.HeaderText = "Tên nhóm";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // edit
            // 
            this.edit.HeaderText = "Sửa";
            this.edit.Name = "edit";
            // 
            // categoryId
            // 
            this.categoryId.HeaderText = "categoryId";
            this.categoryId.Name = "categoryId";
            this.categoryId.ReadOnly = true;
            this.categoryId.Visible = false;
            // 
            // menuCode
            // 
            this.menuCode.HeaderText = "Mã";
            this.menuCode.Name = "menuCode";
            this.menuCode.ReadOnly = true;
            // 
            // menuName
            // 
            this.menuName.FillWeight = 250F;
            this.menuName.HeaderText = "Tên";
            this.menuName.Name = "menuName";
            this.menuName.ReadOnly = true;
            this.menuName.Width = 250;
            // 
            // unit
            // 
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Chi tiết";
            this.description.Name = "description";
            this.description.ReadOnly = true;
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
            this.menuId.ReadOnly = true;
            this.menuId.Visible = false;
            // 
            // MenuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuListGroupBox);
            this.Controls.Add(this.categoryGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thực đơn";
            this.categoryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.menuListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mcontrol.MGroupBox categoryGroupBox;
        private mcontrol.MDataGridView dgvCategory;
        private mcontrol.MButton btnAddCategory;
        private mcontrol.MGroupBox menuListGroupBox;
        private mcontrol.MDataGridView dgvMenu;
        private mcontrol.MButton btnAddMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewButtonColumn editMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuId;
    }
}