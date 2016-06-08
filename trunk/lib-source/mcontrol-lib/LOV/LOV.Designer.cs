namespace mcontrol.LOV
{
    partial class LOV
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
            this.mTextBox1 = new mcontrol.MTextBox(this.components);
            this.mListBox1 = new mcontrol.MListBox(this.components);
            this.SuspendLayout();
            // 
            // mTextBox1
            // 
            this.mTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mTextBox1.Location = new System.Drawing.Point(5, 7);
            this.mTextBox1.Name = "mTextBox1";
            this.mTextBox1.Size = new System.Drawing.Size(391, 23);
            this.mTextBox1.TabIndex = 0;
            this.mTextBox1.TextChanged += new System.EventHandler(this.mTextBox1_TextChanged);
            this.mTextBox1.Enter += new System.EventHandler(this.mTextBox1_Enter);
            this.mTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTextBox1_KeyDown);
            // 
            // mListBox1
            // 
            this.mListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mListBox1.FormattingEnabled = true;
            this.mListBox1.Location = new System.Drawing.Point(5, 33);
            this.mListBox1.Name = "mListBox1";
            this.mListBox1.Size = new System.Drawing.Size(391, 147);
            this.mListBox1.TabIndex = 1;
            this.mListBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mListBox1_MouseClick);
            this.mListBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mListBox1_KeyDown);
            this.mListBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mListBox1_KeyUp);
            // 
            // LOV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 187);
            this.Controls.Add(this.mTextBox1);
            this.Controls.Add(this.mListBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LOV";
            this.Text = "Nhập từ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LOV_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mcontrol.MListBox mListBox1;
        private mcontrol.MTextBox mTextBox1;

    }
}