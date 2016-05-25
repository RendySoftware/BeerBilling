namespace mcontrol
{
    public partial class MDataGridViewWithPaging
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDataGridViewWithPaging));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnFirst = new mcontrol.MButton(this.components);
            this.btnLast = new mcontrol.MButton(this.components);
            this.btnNext = new mcontrol.MButton(this.components);
            this.btnPrevious = new mcontrol.MButton(this.components);
            this.mGroupBox1 = new mcontrol.MGroupBox(this.components);
            this.cbPhanTrang = new mcontrol.MComboBox(this.components);
            this.mLabel1 = new mcontrol.MLabel(this.components);
            this.txtSoBanGhi = new mcontrol.MTextBox(this.components);
            this.mGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1369117837_media-next.PNG");
            this.imageList1.Images.SetKeyName(1, "1369117837_media-previous.png");
            this.imageList1.Images.SetKeyName(2, "1369138698_controls_play_forward.PNG");
            this.imageList1.Images.SetKeyName(3, "1369138698_controls_play_back.png");
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.Enabled = false;
            this.btnFirst.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnFirst.ImageIndex = 1;
            this.btnFirst.ImageList = this.imageList1;
            this.btnFirst.Location = new System.Drawing.Point(214, 19);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(24, 24);
            this.btnFirst.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnFirst, "Trang đầu tiên");
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Enabled = false;
            this.btnLast.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnLast.ImageIndex = 0;
            this.btnLast.ImageList = this.imageList1;
            this.btnLast.Location = new System.Drawing.Point(346, 19);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(24, 24);
            this.btnLast.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnLast, "Trang cuối");
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnNext.ImageIndex = 2;
            this.btnNext.ImageList = this.imageList1;
            this.btnNext.Location = new System.Drawing.Point(320, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 24);
            this.btnNext.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnNext, "Trang kế tiếp");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FlatAppearance.BorderSize = 2;
            this.btnPrevious.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnPrevious.ImageIndex = 3;
            this.btnPrevious.ImageList = this.imageList1;
            this.btnPrevious.Location = new System.Drawing.Point(240, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(24, 24);
            this.btnPrevious.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnPrevious, "Trang trước");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // mGroupBox1
            // 
            this.mGroupBox1.Controls.Add(this.btnFirst);
            this.mGroupBox1.Controls.Add(this.btnLast);
            this.mGroupBox1.Controls.Add(this.btnNext);
            this.mGroupBox1.Controls.Add(this.btnPrevious);
            this.mGroupBox1.Controls.Add(this.cbPhanTrang);
            this.mGroupBox1.Controls.Add(this.mLabel1);
            this.mGroupBox1.Controls.Add(this.txtSoBanGhi);
            this.mGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.mGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.mGroupBox1.Name = "mGroupBox1";
            this.mGroupBox1.Size = new System.Drawing.Size(503, 393);
            this.mGroupBox1.TabIndex = 0;
            this.mGroupBox1.TabStop = false;
            this.mGroupBox1.Text = "mGroupBox1";
            // 
            // cbPhanTrang
            // 
            this.cbPhanTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPhanTrang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPhanTrang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPhanTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPhanTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhanTrang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPhanTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhanTrang.FormattingEnabled = true;
            this.cbPhanTrang.LimitToList = true;
            this.cbPhanTrang.Location = new System.Drawing.Point(267, 20);
            this.cbPhanTrang.Name = "cbPhanTrang";
            this.cbPhanTrang.Size = new System.Drawing.Size(50, 21);
            this.cbPhanTrang.TabIndex = 3;
            this.cbPhanTrang.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbPhanTrang_DrawItem);
            this.cbPhanTrang.SelectedIndexChanged += new System.EventHandler(this.cbPhanTrang_SelectedIndexChanged);
            // 
            // mLabel1
            // 
            this.mLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabel1.AutoSize = true;
            this.mLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mLabel1.Location = new System.Drawing.Point(374, 24);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(65, 14);
            this.mLabel1.TabIndex = 2;
            this.mLabel1.Text = "Số bản ghi";
            // 
            // txtSoBanGhi
            // 
            this.txtSoBanGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoBanGhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoBanGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSoBanGhi.Location = new System.Drawing.Point(443, 21);
            this.txtSoBanGhi.Name = "txtSoBanGhi";
            this.txtSoBanGhi.ReadOnly = true;
            this.txtSoBanGhi.Size = new System.Drawing.Size(53, 23);
            this.txtSoBanGhi.TabIndex = 1;
            this.txtSoBanGhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MDataGridViewWithPaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mGroupBox1);
            this.Name = "MDataGridViewWithPaging";
            this.Size = new System.Drawing.Size(503, 393);
            this.mGroupBox1.ResumeLayout(false);
            this.mGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MGroupBox mGroupBox1;
        private MButton btnNext;
        private MButton btnPrevious;
        private MComboBox cbPhanTrang;
        private MLabel mLabel1;
        private MTextBox txtSoBanGhi;
        private System.Windows.Forms.ImageList imageList1;
        private MButton btnFirst;
        private MButton btnLast;
        private System.Windows.Forms.ToolTip toolTip1;



    }
}
