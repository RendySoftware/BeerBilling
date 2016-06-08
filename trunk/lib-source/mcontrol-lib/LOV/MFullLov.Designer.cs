namespace mcontrol.LOV
{
    partial class MFullLov
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
            this.txtTen = new mcontrol.MTextBox(this.components);
            this.lblTen = new mcontrol.MLabel(this.components);
            this.dgvLov = new mcontrol.MDataGridView(this.components);
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMa = new mcontrol.MLabel(this.components);
            this.txtMa = new mcontrol.MTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLov)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTen.Location = new System.Drawing.Point(142, 3);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(375, 23);
            this.txtTen.TabIndex = 4;
            this.txtTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTen_KeyDown);
            this.txtTen.Leave += new System.EventHandler(this.txtTen_Leave);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTen.Location = new System.Drawing.Point(111, 6);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(27, 14);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên";
            // 
            // dgvLov
            // 
            this.dgvLov.AllowUserToAddRows = false;
            this.dgvLov.AllowUserToDeleteRows = false;
            this.dgvLov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLov.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA,
            this.ID,
            this.TEN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLov.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLov.Location = new System.Drawing.Point(4, 32);
            this.dgvLov.MultiSelect = false;
            this.dgvLov.Name = "dgvLov";
            this.dgvLov.RowHeadersVisible = false;
            this.dgvLov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLov.Size = new System.Drawing.Size(513, 353);
            this.dgvLov.TabIndex = 2;
            this.dgvLov.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvLov_KeyDown);
            this.dgvLov.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvLov_MouseDoubleClick);
            // 
            // MA
            // 
            this.MA.HeaderText = "Mã";
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            this.MA.Width = 120;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // TEN
            // 
            this.TEN.HeaderText = "Tên";
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            this.TEN.Width = 389;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblMa.Location = new System.Drawing.Point(1, 6);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(22, 14);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã";
            // 
            // txtMa
            // 
            this.txtMa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMa.Location = new System.Drawing.Point(29, 3);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(79, 23);
            this.txtMa.TabIndex = 0;
            this.txtMa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMa_KeyDown);
            this.txtMa.Leave += new System.EventHandler(this.txtMa_Leave);
            // 
            // MFullLov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 388);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.dgvLov);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.txtMa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MFullLov";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MFullLov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MTextBox txtMa;
        private MLabel lblMa;
        private MDataGridView dgvLov;
        private MLabel lblTen;
        private MTextBox txtTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
    }
}