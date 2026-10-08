namespace B2_1
{
    partial class frmCongTruNhanChia
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_a = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.lbl_b = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.lbl_kq = new System.Windows.Forms.Label();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_Cong = new System.Windows.Forms.Button();
            this.btn_Tru = new System.Windows.Forms.Button();
            this.btn_Nhan = new System.Windows.Forms.Button();
            this.btn_Chia = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_a.Location = new System.Drawing.Point(40, 25);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(26, 17);
            this.lbl_a.TabIndex = 0;
            this.lbl_a.Text = "a=";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(75, 23);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(120, 23);
            this.txt_a.TabIndex = 1;
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_b.Location = new System.Drawing.Point(220, 25);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(27, 17);
            this.lbl_b.TabIndex = 2;
            this.lbl_b.Text = "b=";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(255, 23);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(120, 23);
            this.txt_b.TabIndex = 3;
            this.txt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_kq
            // 
            this.lbl_kq.AutoSize = true;
            this.lbl_kq.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_kq.Location = new System.Drawing.Point(15, 68);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new System.Drawing.Size(56, 17);
            this.lbl_kq.TabIndex = 4;
            this.lbl_kq.Text = "Kết quả";
            // 
            // txt_kq
            // 
            this.txt_kq.BackColor = System.Drawing.Color.White;
            this.txt_kq.Location = new System.Drawing.Point(75, 65);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.ReadOnly = true;
            this.txt_kq.Size = new System.Drawing.Size(300, 23);
            this.txt_kq.TabIndex = 5;
            // 
            // btn_Cong
            // 
            this.btn_Cong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Cong.Location = new System.Drawing.Point(30, 110);
            this.btn_Cong.Name = "btn_Cong";
            this.btn_Cong.Size = new System.Drawing.Size(75, 40);
            this.btn_Cong.TabIndex = 6;
            this.btn_Cong.Text = "+";
            this.btn_Cong.UseVisualStyleBackColor = true;
            this.btn_Cong.Click += new System.EventHandler(this.btn_PhepToan_Click);
            // 
            // btn_Tru
            // 
            this.btn_Tru.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Tru.Location = new System.Drawing.Point(125, 110);
            this.btn_Tru.Name = "btn_Tru";
            this.btn_Tru.Size = new System.Drawing.Size(75, 40);
            this.btn_Tru.TabIndex = 7;
            this.btn_Tru.Text = "-";
            this.btn_Tru.UseVisualStyleBackColor = true;
            this.btn_Tru.Click += new System.EventHandler(this.btn_PhepToan_Click);
            // 
            // btn_Nhan
            // 
            this.btn_Nhan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Nhan.Location = new System.Drawing.Point(220, 110);
            this.btn_Nhan.Name = "btn_Nhan";
            this.btn_Nhan.Size = new System.Drawing.Size(75, 40);
            this.btn_Nhan.TabIndex = 8;
            this.btn_Nhan.Text = "x";
            this.btn_Nhan.UseVisualStyleBackColor = true;
            this.btn_Nhan.Click += new System.EventHandler(this.btn_PhepToan_Click);
            // 
            // btn_Chia
            // 
            this.btn_Chia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Chia.Location = new System.Drawing.Point(315, 110);
            this.btn_Chia.Name = "btn_Chia";
            this.btn_Chia.Size = new System.Drawing.Size(75, 40);
            this.btn_Chia.TabIndex = 9;
            this.btn_Chia.Text = "/";
            this.btn_Chia.UseVisualStyleBackColor = true;
            this.btn_Chia.Click += new System.EventHandler(this.btn_PhepToan_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCongTruNhanChia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 175);
            this.Controls.Add(this.btn_Chia);
            this.Controls.Add(this.btn_Nhan);
            this.Controls.Add(this.btn_Tru);
            this.Controls.Add(this.btn_Cong);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.lbl_kq);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.lbl_a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCongTruNhanChia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cộng trừ nhân chia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCongTruNhanChia_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label lbl_kq;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_Cong;
        private System.Windows.Forms.Button btn_Tru;
        private System.Windows.Forms.Button btn_Nhan;
        private System.Windows.Forms.Button btn_Chia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}