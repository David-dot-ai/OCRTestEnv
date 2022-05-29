namespace ironocrTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnOcr = new System.Windows.Forms.Button();
            this.rtocrOut = new System.Windows.Forms.RichTextBox();
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(156, 47);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select Picture";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnOcr
            // 
            this.btnOcr.Location = new System.Drawing.Point(890, 12);
            this.btnOcr.Name = "btnOcr";
            this.btnOcr.Size = new System.Drawing.Size(156, 47);
            this.btnOcr.TabIndex = 1;
            this.btnOcr.Text = "OCR";
            this.btnOcr.UseVisualStyleBackColor = true;
            this.btnOcr.Click += new System.EventHandler(this.btnOcr_Click);
            // 
            // rtocrOut
            // 
            this.rtocrOut.Location = new System.Drawing.Point(1061, 12);
            this.rtocrOut.Name = "rtocrOut";
            this.rtocrOut.Size = new System.Drawing.Size(265, 320);
            this.rtocrOut.TabIndex = 2;
            this.rtocrOut.Text = "";
            // 
            // pbPic
            // 
            this.pbPic.Location = new System.Drawing.Point(12, 70);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(1034, 742);
            this.pbPic.TabIndex = 3;
            this.pbPic.TabStop = false;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(185, 22);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(399, 27);
            this.tbPath.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 953);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.pbPic);
            this.Controls.Add(this.rtocrOut);
            this.Controls.Add(this.btnOcr);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSelect;
        private Button btnOcr;
        private RichTextBox rtocrOut;
        private PictureBox pbPic;
        private TextBox tbPath;
    }
}