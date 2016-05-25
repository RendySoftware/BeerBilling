namespace mcontrol.LOV
{
    partial class MLovTextField
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
            this.txtSearchKey = new mcontrol.MTextBox(this.components);
            this.btnHelp = new mcontrol.MButton(this.components);
            this.SuspendLayout();
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchKey.Location = new System.Drawing.Point(0, 0);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(171, 23);
            this.txtSearchKey.TabIndex = 0;
            this.txtSearchKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchKey_KeyDown);
            this.txtSearchKey.Leave += new System.EventHandler(this.txtSearchKey_Leave);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHelp.Location = new System.Drawing.Point(171, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(28, 23);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "...";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MLovTextField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.txtSearchKey);
            this.Name = "MLovTextField";
            this.Size = new System.Drawing.Size(199, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MTextBox txtSearchKey;
        private MButton btnHelp;
    }
}
