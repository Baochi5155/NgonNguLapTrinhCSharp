namespace B2_1
{
    partial class frmGiaiPT
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grp_Option = new System.Windows.Forms.GroupBox();
            this.rdo_BacHai = new System.Windows.Forms.RadioButton();
            this.rdo_BacNhat = new System.Windows.Forms.RadioButton();
            this.lbl_a = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.lbl_b = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.lbl_c = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.lbl_kq = new System.Windows.Forms.Label();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_Giai = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(12, 10);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(350, 35);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "GIẢI PHƯƠNG TRÌNH";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_Option
            // 
            this.grp_Option.Controls.Add(this.rdo_BacHai);
            this.grp_Option.Controls.Add(this.rdo_BacNhat);
            this.grp_Option.Location = new System.Drawing.Point(30, 50);
            this.grp_Option.Name = "grp_Option";
            this.grp_Option.Size = new System.Drawing.Size(315, 85);
            this.grp_Option.TabIndex = 1;
            this.grp_Option.TabStop = false;
            this.grp_Option.Text = "Bạn vui lòng chọn";
            // 
            // rdo_BacHai
            // 
            this.rdo_BacHai.AutoSize = true;
            this.rdo_BacHai.Location = new System.Drawing.Point(35, 52);
            this.rdo_BacHai.Name = "rdo_BacHai";
            this.rdo_BacHai.Size = new System.Drawing.Size(135, 19);
            this.rdo_BacHai.TabIndex = 1;
            this.rdo_BacHai.Text = "Phương trình bậc hai";
            this.rdo_BacHai.UseVisualStyleBackColor = true;
            this.rdo_BacHai.CheckedChanged += new System.EventHandler(this.rdo_Option_CheckedChanged);
            // 
            // rdo_BacNhat
            // 
            this.rdo_BacNhat.AutoSize = true;
            this.rdo_BacNhat.Checked = true;
            this.rdo_BacNhat.Location = new System.Drawing.Point(35, 24);
            this.rdo_BacNhat.Name = "rdo_BacNhat";
            this.rdo_BacNhat.Size = new System.Drawing.Size(142, 19);
            this.rdo_BacNhat.TabIndex = 0;
            this.rdo_BacNhat.TabStop = true;
            this.rdo_BacNhat.Text = "Phương trình bậc nhất";
            this.rdo_BacNhat.UseVisualStyleBackColor = true;
            this.rdo_BacNhat.CheckedChanged += new System.EventHandler(this.rdo_Option_CheckedChanged);
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(30, 150);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(46, 15);
            this.lbl_a.TabIndex = 2;
            this.lbl_a.Text = "Nhập a";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(90, 147);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(125, 23);
            this.txt_a.TabIndex = 3;
            this.txt_a.TextChanged += new System.EventHandler(this.txt_Inputs_TextChanged);
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(30, 185);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(47, 15);
            this.lbl_b.TabIndex = 4;
            this.lbl_b.Text = "Nhập b";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(90, 182);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(125, 23);
            this.txt_b.TabIndex = 5;
            this.txt_b.TextChanged += new System.EventHandler(this.txt_Inputs_TextChanged);
            this.txt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_c.Location = new System.Drawing.Point(30, 220);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(46, 15);
            this.lbl_c.TabIndex = 6;
            this.lbl_c.Text = "Nhập c";
            // 
            // txt_c
            // 
            this.txt_c.Enabled = false;
            this.txt_c.Location = new System.Drawing.Point(90, 217);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(125, 23);
            this.txt_c.TabIndex = 7;
            this.txt_c.TextChanged += new System.EventHandler(this.txt_Inputs_TextChanged);
            this.txt_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl_kq
            // 
            this.lbl_kq.AutoSize = true;
            this.lbl_kq.Location = new System.Drawing.Point(30, 255);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new System.Drawing.Size(47, 15);
            this.lbl_kq.TabIndex = 8;
            this.lbl_kq.Text = "Kết quả";
            // 
            // txt_kq
            // 
            this.txt_kq.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_kq.Location = new System.Drawing.Point(90, 252);
            this.txt_kq.Multiline = true;
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.ReadOnly = true;
            this.txt_kq.Size = new System.Drawing.Size(255, 60);
            this.txt_kq.TabIndex = 9;
            // 
            // btn_Giai
            // 
            this.btn_Giai.Enabled = false;
            this.btn_Giai.Location = new System.Drawing.Point(245, 147);
            this.btn_Giai.Name = "btn_Giai";
            this.btn_Giai.Size = new System.Drawing.Size(85, 38);
            this.btn_Giai.TabIndex = 10;
            this.btn_Giai.Text = "Giải";
            this.btn_Giai.UseVisualStyleBackColor = true;
            this.btn_Giai.Click += new System.EventHandler(this.btn_Giai_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(245, 198);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(85, 38);
            this.btn_Thoat.TabIndex = 11;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmGiaiPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 330);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Giai);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.lbl_kq);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.grp_Option);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGiaiPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải phương trình bậc 1-2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaiPT_FormClosing);
            this.Load += new System.EventHandler(this.frmGiaiPT_Load);
            this.grp_Option.ResumeLayout(false);
            this.grp_Option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grp_Option;
        private System.Windows.Forms.RadioButton rdo_BacHai;
        private System.Windows.Forms.RadioButton rdo_BacNhat;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label lbl_kq;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_Giai;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}