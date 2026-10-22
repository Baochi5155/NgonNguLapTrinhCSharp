namespace B1_3
{
    partial class frmSaveFileDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNhapText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLuuFile = new System.Windows.Forms.Button();
            this.btnMoFile = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblNhapText
            // 
            this.lblNhapText.AutoSize = true;
            this.lblNhapText.Location = new System.Drawing.Point(20, 18);
            this.lblNhapText.Name = "lblNhapText";
            this.lblNhapText.Size = new System.Drawing.Size(103, 17);
            this.lblNhapText.TabIndex = 0;
            this.lblNhapText.Text = "Nhập đoạn text:";

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(290, 24);
            this.textBox1.TabIndex = 1;

            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 200);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";

            // 
            // btnMoFile
            // 
            this.btnMoFile.Location = new System.Drawing.Point(210, 260);
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.Size = new System.Drawing.Size(100, 32);
            this.btnMoFile.TabIndex = 4;
            this.btnMoFile.Text = "Mở file";
            this.btnMoFile.UseVisualStyleBackColor = true;
            this.btnMoFile.Click += new System.EventHandler(this.btnMoFile_Click);

            // 
            // btnLuuFile
            // 
            this.btnLuuFile.Location = new System.Drawing.Point(320, 260);
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new System.Drawing.Size(100, 32);
            this.btnLuuFile.TabIndex = 3;
            this.btnLuuFile.Text = "Lưu file";
            this.btnLuuFile.UseVisualStyleBackColor = true;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);

            // 
            // frmSaveFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 310);
            this.Controls.Add(this.btnMoFile);
            this.Controls.Add(this.btnLuuFile);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNhapText);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSaveFileDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save File Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNhapText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLuuFile;
        private System.Windows.Forms.Button btnMoFile;
    }
}