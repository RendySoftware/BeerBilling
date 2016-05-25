namespace mcontrol
{
    partial class MTextDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MTextDanhMuc));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnShowDanhMuc = new mcontrol.MButton(this.components);
            this.txtDanhMuc = new mcontrol.MTextBox(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1366115205_agt_update_misc.png");
            this.imageList1.Images.SetKeyName(1, "1367735486_triangle.png");
            this.imageList1.Images.SetKeyName(2, "1367735531_93530.ico");
            this.imageList1.Images.SetKeyName(3, "1367735616_arrow_sans_down.png");
            this.imageList1.Images.SetKeyName(4, "1367735626_old-go-bottom.png");
            this.imageList1.Images.SetKeyName(5, "1367735633_go-bottom.png");
            this.imageList1.Images.SetKeyName(6, "New Image.BMP");
            // 
            // btnShowDanhMuc
            // 
            this.btnShowDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDanhMuc.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnShowDanhMuc.ImageIndex = 3;
            this.btnShowDanhMuc.ImageList = this.imageList1;
            this.btnShowDanhMuc.Location = new System.Drawing.Point(311, 0);
            this.btnShowDanhMuc.Name = "btnShowDanhMuc";
            this.btnShowDanhMuc.Size = new System.Drawing.Size(23, 23);
            this.btnShowDanhMuc.TabIndex = 1;
            this.btnShowDanhMuc.UseVisualStyleBackColor = true;
            this.btnShowDanhMuc.Click += new System.EventHandler(this.btnShowDanhMuc_Click);
            this.btnShowDanhMuc.BringToFront();
            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(311, 23);
            this.txtDanhMuc.TabIndex = 0;
            this.txtDanhMuc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDanhMuc_MouseClick);
            this.txtDanhMuc.TextChanged += new System.EventHandler(this.txtDanhMuc_TextChanged);
            this.txtDanhMuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDanhMuc_KeyDown);
            this.txtDanhMuc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDanhMuc_KeyUp);
            this.txtDanhMuc.Leave += new System.EventHandler(this.txtDanhMuc_Leave);
            // 
            // MTextDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowDanhMuc);
            this.Controls.Add(this.txtDanhMuc);
            this.Name = "MTextDanhMuc";
            this.Size = new System.Drawing.Size(334, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MTextBox txtDanhMuc;
        private MButton btnShowDanhMuc;
        private System.Windows.Forms.ImageList imageList1;
    }
}
