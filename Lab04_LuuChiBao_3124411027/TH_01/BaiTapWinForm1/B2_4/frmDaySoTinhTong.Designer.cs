namespace B2_4
{
    partial class frmDaySoTinhTong
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
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lblDayVuaNhap = new System.Windows.Forms.Label();
            this.txtDayVuaNhap = new System.Windows.Forms.TextBox();
            this.lblTongDay = new System.Windows.Forms.Label();
            this.txtTongDay = new System.Windows.Forms.TextBox();
            this.lblTongChan = new System.Windows.Forms.Label();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.lblTongLe = new System.Windows.Forms.Label();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnTongChan = new System.Windows.Forms.Button();
            this.btnTongLe = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(396, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nhập Dãy Số và Tính Tổng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNhapSo.Location = new System.Drawing.Point(25, 55);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(65, 17);
            this.lblNhapSo.TabIndex = 1;
            this.lblNhapSo.Text = "Nhập số :";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNhapSo.Location = new System.Drawing.Point(180, 52);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(95, 25);
            this.txtNhapSo.TabIndex = 2;
            this.txtNhapSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapSo_KeyPress);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNhap.Location = new System.Drawing.Point(290, 50);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(95, 28);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lblDayVuaNhap
            // 
            this.lblDayVuaNhap.AutoSize = true;
            this.lblDayVuaNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDayVuaNhap.Location = new System.Drawing.Point(25, 93);
            this.lblDayVuaNhap.Name = "lblDayVuaNhap";
            this.lblDayVuaNhap.Size = new System.Drawing.Size(95, 17);
            this.lblDayVuaNhap.TabIndex = 4;
            this.lblDayVuaNhap.Text = "Dãy vừa nhập :";
            // 
            // txtDayVuaNhap
            // 
            this.txtDayVuaNhap.BackColor = System.Drawing.Color.White;
            this.txtDayVuaNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDayVuaNhap.Location = new System.Drawing.Point(180, 90);
            this.txtDayVuaNhap.Name = "txtDayVuaNhap";
            this.txtDayVuaNhap.ReadOnly = true;
            this.txtDayVuaNhap.Size = new System.Drawing.Size(205, 25);
            this.txtDayVuaNhap.TabIndex = 5;
            // 
            // lblTongDay
            // 
            this.lblTongDay.AutoSize = true;
            this.lblTongDay.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTongDay.Location = new System.Drawing.Point(25, 131);
            this.lblTongDay.Name = "lblTongDay";
            this.lblTongDay.Size = new System.Drawing.Size(147, 17);
            this.lblTongDay.TabIndex = 6;
            this.lblTongDay.Text = "Tổng các phần tử trong dãy :";
            // 
            // txtTongDay
            // 
            this.txtTongDay.BackColor = System.Drawing.Color.White;
            this.txtTongDay.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTongDay.Location = new System.Drawing.Point(300, 128);
            this.txtTongDay.Name = "txtTongDay";
            this.txtTongDay.ReadOnly = true;
            this.txtTongDay.Size = new System.Drawing.Size(85, 25);
            this.txtTongDay.TabIndex = 7;
            // 
            // lblTongChan
            // 
            this.lblTongChan.AutoSize = true;
            this.lblTongChan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTongChan.Location = new System.Drawing.Point(25, 169);
            this.lblTongChan.Name = "lblTongChan";
            this.lblTongChan.Size = new System.Drawing.Size(77, 17);
            this.lblTongChan.TabIndex = 8;
            this.lblTongChan.Text = "Tổng Chẵn :";
            // 
            // txtTongChan
            // 
            this.txtTongChan.BackColor = System.Drawing.Color.White;
            this.txtTongChan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTongChan.Location = new System.Drawing.Point(105, 166);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.ReadOnly = true;
            this.txtTongChan.Size = new System.Drawing.Size(75, 25);
            this.txtTongChan.TabIndex = 9;
            // 
            // lblTongLe
            // 
            this.lblTongLe.AutoSize = true;
            this.lblTongLe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTongLe.Location = new System.Drawing.Point(215, 169);
            this.lblTongLe.Name = "lblTongLe";
            this.lblTongLe.Size = new System.Drawing.Size(60, 17);
            this.lblTongLe.TabIndex = 10;
            this.lblTongLe.Text = "Tổng Lẻ :";
            // 
            // txtTongLe
            // 
            this.txtTongLe.BackColor = System.Drawing.Color.White;
            this.txtTongLe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTongLe.Location = new System.Drawing.Point(300, 166);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.ReadOnly = true;
            this.txtTongLe.Size = new System.Drawing.Size(85, 25);
            this.txtTongLe.TabIndex = 11;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTinhTong.Location = new System.Drawing.Point(25, 210);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(110, 30);
            this.btnTinhTong.TabIndex = 12;
            this.btnTinhTong.Text = "Tính Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // btnTongChan
            // 
            this.btnTongChan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTongChan.Location = new System.Drawing.Point(155, 210);
            this.btnTongChan.Name = "btnTongChan";
            this.btnTongChan.Size = new System.Drawing.Size(110, 30);
            this.btnTongChan.TabIndex = 13;
            this.btnTongChan.Text = "Tổng Chẵn";
            this.btnTongChan.UseVisualStyleBackColor = true;
            this.btnTongChan.Click += new System.EventHandler(this.btnTongChan_Click);
            // 
            // btnTongLe
            // 
            this.btnTongLe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTongLe.Location = new System.Drawing.Point(285, 210);
            this.btnTongLe.Name = "btnTongLe";
            this.btnTongLe.Size = new System.Drawing.Size(100, 30);
            this.btnTongLe.TabIndex = 14;
            this.btnTongLe.Text = "Tổng Lẻ";
            this.btnTongLe.UseVisualStyleBackColor = true;
            this.btnTongLe.Click += new System.EventHandler(this.btnTongLe_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnTiepTuc.Location = new System.Drawing.Point(85, 255);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(100, 32);
            this.btnTiepTuc.TabIndex = 15;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnThoat.Location = new System.Drawing.Point(235, 255);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 32);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDaySoTinhTong
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 305);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnTongLe);
            this.Controls.Add(this.btnTongChan);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.txtTongLe);
            this.Controls.Add(this.lblTongLe);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.lblTongChan);
            this.Controls.Add(this.txtTongDay);
            this.Controls.Add(this.lblTongDay);
            this.Controls.Add(this.txtDayVuaNhap);
            this.Controls.Add(this.lblDayVuaNhap);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDaySoTinhTong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dãy số và Tính Tổng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDaySoTinhTong_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lblDayVuaNhap;
        private System.Windows.Forms.TextBox txtDayVuaNhap;
        private System.Windows.Forms.Label lblTongDay;
        private System.Windows.Forms.TextBox txtTongDay;
        private System.Windows.Forms.Label lblTongChan;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.Label lblTongLe;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnTongChan;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}