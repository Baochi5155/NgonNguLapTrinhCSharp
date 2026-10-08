namespace B2_3
{
    partial class frmUocSoBoiSo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhapA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblNhapB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblUCLN = new System.Windows.Forms.Label();
            this.txtUCLN = new System.Windows.Forms.TextBox();
            this.lblBCNN = new System.Windows.Forms.Label();
            this.txtBCNN = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(356, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ước Số Chung - Bội Số Chung";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhapA
            // 
            this.lblNhapA.AutoSize = true;
            this.lblNhapA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNhapA.Location = new System.Drawing.Point(50, 60);
            this.lblNhapA.Name = "lblNhapA";
            this.lblNhapA.Size = new System.Drawing.Size(71, 17);
            this.lblNhapA.TabIndex = 1;
            this.lblNhapA.Text = "Nhập số a :";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtA.Location = new System.Drawing.Point(195, 57);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(130, 25);
            this.txtA.TabIndex = 2;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblNhapB
            // 
            this.lblNhapB.AutoSize = true;
            this.lblNhapB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNhapB.Location = new System.Drawing.Point(50, 95);
            this.lblNhapB.Name = "lblNhapB";
            this.lblNhapB.Size = new System.Drawing.Size(72, 17);
            this.lblNhapB.TabIndex = 3;
            this.lblNhapB.Text = "Nhập số b :";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtB.Location = new System.Drawing.Point(195, 92);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(130, 25);
            this.txtB.TabIndex = 4;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblUCLN
            // 
            this.lblUCLN.AutoSize = true;
            this.lblUCLN.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblUCLN.Location = new System.Drawing.Point(50, 130);
            this.lblUCLN.Name = "lblUCLN";
            this.lblUCLN.Size = new System.Drawing.Size(138, 17);
            this.lblUCLN.TabIndex = 5;
            this.lblUCLN.Text = "Ước số chung lớn nhất :";
            // 
            // txtUCLN
            // 
            this.txtUCLN.BackColor = System.Drawing.Color.White;
            this.txtUCLN.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUCLN.Location = new System.Drawing.Point(195, 127);
            this.txtUCLN.Name = "txtUCLN";
            this.txtUCLN.ReadOnly = true;
            this.txtUCLN.Size = new System.Drawing.Size(130, 25);
            this.txtUCLN.TabIndex = 6;
            // 
            // lblBCNN
            // 
            this.lblBCNN.AutoSize = true;
            this.lblBCNN.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBCNN.Location = new System.Drawing.Point(50, 165);
            this.lblBCNN.Name = "lblBCNN";
            this.lblBCNN.Size = new System.Drawing.Size(142, 17);
            this.lblBCNN.TabIndex = 7;
            this.lblBCNN.Text = "Bội số chung nhỏ nhất :";
            // 
            // txtBCNN
            // 
            this.txtBCNN.BackColor = System.Drawing.Color.White;
            this.txtBCNN.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBCNN.Location = new System.Drawing.Point(195, 162);
            this.txtBCNN.Name = "txtBCNN";
            this.txtBCNN.ReadOnly = true;
            this.txtBCNN.Size = new System.Drawing.Size(130, 25);
            this.txtBCNN.TabIndex = 8;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnThucHien.Location = new System.Drawing.Point(40, 205);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(90, 32);
            this.btnThucHien.TabIndex = 9;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnTiepTuc.Location = new System.Drawing.Point(145, 205);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(90, 32);
            this.btnTiepTuc.TabIndex = 10;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnThoat.Location = new System.Drawing.Point(250, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 32);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUocSoBoiSo
            // 
            this.AcceptButton = this.btnThucHien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 255);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.txtBCNN);
            this.Controls.Add(this.lblBCNN);
            this.Controls.Add(this.txtUCLN);
            this.Controls.Add(this.lblUCLN);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblNhapB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblNhapA);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUocSoBoiSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ước Số - Bội Số";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUocSoBoiSo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhapA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblNhapB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblUCLN;
        private System.Windows.Forms.TextBox txtUCLN;
        private System.Windows.Forms.Label lblBCNN;
        private System.Windows.Forms.TextBox txtBCNN;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}