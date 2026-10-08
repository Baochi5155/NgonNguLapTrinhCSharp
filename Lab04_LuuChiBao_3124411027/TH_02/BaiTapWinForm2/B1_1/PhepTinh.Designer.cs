namespace B1_1
{
    partial class PhepTinh
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
            this.rdo_cong = new System.Windows.Forms.RadioButton();
            this.rdo_tru = new System.Windows.Forms.RadioButton();
            this.rdo_nhan = new System.Windows.Forms.RadioButton();
            this.rdo_chia = new System.Windows.Forms.RadioButton();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_a.Location = new System.Drawing.Point(35, 30);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(30, 17);
            this.lbl_a.TabIndex = 0;
            this.lbl_a.Text = "a =";
            // 
            // txt_a
            // 
            this.txt_a.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_a.Location = new System.Drawing.Point(75, 27);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(120, 25);
            this.txt_a.TabIndex = 1;
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_b.Location = new System.Drawing.Point(235, 30);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(31, 17);
            this.lbl_b.TabIndex = 2;
            this.lbl_b.Text = "b =";
            // 
            // txt_b
            // 
            this.txt_b.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_b.Location = new System.Drawing.Point(275, 27);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(120, 25);
            this.txt_b.TabIndex = 3;
            this.txt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_kq
            // 
            this.lbl_kq.AutoSize = true;
            this.lbl_kq.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_kq.Location = new System.Drawing.Point(35, 75);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new System.Drawing.Size(56, 17);
            this.lbl_kq.TabIndex = 4;
            this.lbl_kq.Text = "Kết quả";
            // 
            // txt_kq
            // 
            this.txt_kq.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_kq.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_kq.Location = new System.Drawing.Point(100, 72);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.ReadOnly = true;
            this.txt_kq.Size = new System.Drawing.Size(295, 25);
            this.txt_kq.TabIndex = 5;
            // 
            // rdo_cong
            // 
            this.rdo_cong.AutoSize = true;
            this.rdo_cong.Checked = true;
            this.rdo_cong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_cong.Location = new System.Drawing.Point(110, 115);
            this.rdo_cong.Name = "rdo_cong";
            this.rdo_cong.Size = new System.Drawing.Size(37, 23);
            this.rdo_cong.TabIndex = 6;
            this.rdo_cong.TabStop = true;
            this.rdo_cong.Text = "+";
            this.rdo_cong.UseVisualStyleBackColor = true;
            this.rdo_cong.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdo_tru
            // 
            this.rdo_tru.AutoSize = true;
            this.rdo_tru.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_tru.Location = new System.Drawing.Point(175, 115);
            this.rdo_tru.Name = "rdo_tru";
            this.rdo_tru.Size = new System.Drawing.Size(33, 23);
            this.rdo_tru.TabIndex = 7;
            this.rdo_tru.Text = "-";
            this.rdo_tru.UseVisualStyleBackColor = true;
            this.rdo_tru.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdo_nhan
            // 
            this.rdo_nhan.AutoSize = true;
            this.rdo_nhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_nhan.Location = new System.Drawing.Point(235, 115);
            this.rdo_nhan.Name = "rdo_nhan";
            this.rdo_nhan.Size = new System.Drawing.Size(34, 23);
            this.rdo_nhan.TabIndex = 8;
            this.rdo_nhan.Text = "x";
            this.rdo_nhan.UseVisualStyleBackColor = true;
            this.rdo_nhan.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdo_chia
            // 
            this.rdo_chia.AutoSize = true;
            this.rdo_chia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_chia.Location = new System.Drawing.Point(295, 115);
            this.rdo_chia.Name = "rdo_chia";
            this.rdo_chia.Size = new System.Drawing.Size(33, 23);
            this.rdo_chia.TabIndex = 9;
            this.rdo_chia.Text = "/";
            this.rdo_chia.UseVisualStyleBackColor = true;
            this.rdo_chia.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Tinh.Location = new System.Drawing.Point(180, 155);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(90, 32);
            this.btn_Tinh.TabIndex = 10;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.UseVisualStyleBackColor = true;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PhepTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 210);
            this.Controls.Add(this.btn_Tinh);
            this.Controls.Add(this.rdo_chia);
            this.Controls.Add(this.rdo_nhan);
            this.Controls.Add(this.rdo_tru);
            this.Controls.Add(this.rdo_cong);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.lbl_kq);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.lbl_a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhepTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cộng trừ nhân chia Radio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhepTinh_FormClosing);
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
        private System.Windows.Forms.RadioButton rdo_cong;
        private System.Windows.Forms.RadioButton rdo_tru;
        private System.Windows.Forms.RadioButton rdo_nhan;
        private System.Windows.Forms.RadioButton rdo_chia;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}