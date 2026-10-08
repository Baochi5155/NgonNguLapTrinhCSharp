namespace B3
{
    partial class frmCafeSinhVien
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_TenKH = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.lbl_SoKH = new System.Windows.Forms.Label();
            this.txt_SoKH = new System.Windows.Forms.TextBox();
            this.chk_SinhVien = new System.Windows.Forms.CheckBox();
            this.grp_NuocUong = new System.Windows.Forms.GroupBox();
            this.rdo_CafeSuaDa = new System.Windows.Forms.RadioButton();
            this.rdo_CafeKem = new System.Windows.Forms.RadioButton();
            this.rdo_CafeDa = new System.Windows.Forms.RadioButton();
            this.rdo_CafeSua = new System.Windows.Forms.RadioButton();
            this.rdo_CafeDen = new System.Windows.Forms.RadioButton();
            this.grp_ThucAn = new System.Windows.Forms.GroupBox();
            this.chk_MyCay = new System.Windows.Forms.CheckBox();
            this.chk_MyXaoBo = new System.Windows.Forms.CheckBox();
            this.chk_MyTomTrung = new System.Windows.Forms.CheckBox();
            this.chk_BanhMyCa = new System.Windows.Forms.CheckBox();
            this.chk_BanhMyTrung = new System.Windows.Forms.CheckBox();
            this.btn_TinhTien = new System.Windows.Forms.Button();
            this.btn_NhapLai = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_TongKH = new System.Windows.Forms.Label();
            this.txt_TongKH = new System.Windows.Forms.TextBox();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.grp_NuocUong.SuspendLayout();
            this.grp_ThucAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(460, 35);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "CAFE SINH VIÊN";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TenKH
            // 
            this.lbl_TenKH.AutoSize = true;
            this.lbl_TenKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_TenKH.Location = new System.Drawing.Point(30, 55);
            this.lbl_TenKH.Name = "lbl_TenKH";
            this.lbl_TenKH.Size = new System.Drawing.Size(96, 15);
            this.lbl_TenKH.TabIndex = 1;
            this.lbl_TenKH.Text = "Tên khách hàng";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(145, 52);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(305, 23);
            this.txt_TenKH.TabIndex = 2;
            this.txt_TenKH.TextChanged += new System.EventHandler(this.ThongTin_Changed);
            // 
            // lbl_SoKH
            // 
            this.lbl_SoKH.AutoSize = true;
            this.lbl_SoKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_SoKH.Location = new System.Drawing.Point(30, 90);
            this.lbl_SoKH.Name = "lbl_SoKH";
            this.lbl_SoKH.Size = new System.Drawing.Size(86, 15);
            this.lbl_SoKH.TabIndex = 3;
            this.lbl_SoKH.Text = "Số khách hàng";
            // 
            // txt_SoKH
            // 
            this.txt_SoKH.Location = new System.Drawing.Point(145, 87);
            this.txt_SoKH.Name = "txt_SoKH";
            this.txt_SoKH.Size = new System.Drawing.Size(305, 23);
            this.txt_SoKH.TabIndex = 4;
            this.txt_SoKH.TextChanged += new System.EventHandler(this.ThongTin_Changed);
            this.txt_SoKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoKH_KeyPress);
            // 
            // chk_SinhVien
            // 
            this.chk_SinhVien.AutoSize = true;
            this.chk_SinhVien.Location = new System.Drawing.Point(145, 120);
            this.chk_SinhVien.Name = "chk_SinhVien";
            this.chk_SinhVien.Size = new System.Drawing.Size(83, 19);
            this.chk_SinhVien.TabIndex = 5;
            this.chk_SinhVien.Text = "Sinh viên ?";
            this.chk_SinhVien.UseVisualStyleBackColor = true;
            // 
            // grp_NuocUong
            // 
            this.grp_NuocUong.Controls.Add(this.rdo_CafeSuaDa);
            this.grp_NuocUong.Controls.Add(this.rdo_CafeKem);
            this.grp_NuocUong.Controls.Add(this.rdo_CafeDa);
            this.grp_NuocUong.Controls.Add(this.rdo_CafeSua);
            this.grp_NuocUong.Controls.Add(this.rdo_CafeDen);
            this.grp_NuocUong.Location = new System.Drawing.Point(30, 150);
            this.grp_NuocUong.Name = "grp_NuocUong";
            this.grp_NuocUong.Size = new System.Drawing.Size(200, 125);
            this.grp_NuocUong.TabIndex = 6;
            this.grp_NuocUong.TabStop = false;
            this.grp_NuocUong.Text = "Nước uống";
            // 
            // rdo_CafeSuaDa
            // 
            this.rdo_CafeSuaDa.AutoSize = true;
            this.rdo_CafeSuaDa.Location = new System.Drawing.Point(15, 90);
            this.rdo_CafeSuaDa.Name = "rdo_CafeSuaDa";
            this.rdo_CafeSuaDa.Size = new System.Drawing.Size(86, 19);
            this.rdo_CafeSuaDa.TabIndex = 4;
            this.rdo_CafeSuaDa.Text = "Cafe sữa đá";
            this.rdo_CafeSuaDa.UseVisualStyleBackColor = true;
            this.rdo_CafeSuaDa.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);
            // 
            // rdo_CafeKem
            // 
            this.rdo_CafeKem.AutoSize = true;
            this.rdo_CafeKem.Location = new System.Drawing.Point(105, 55);
            this.rdo_CafeKem.Name = "rdo_CafeKem";
            this.rdo_CafeKem.Size = new System.Drawing.Size(75, 19);
            this.rdo_CafeKem.TabIndex = 3;
            this.rdo_CafeKem.Text = "Cafe kem";
            this.rdo_CafeKem.UseVisualStyleBackColor = true;
            this.rdo_CafeKem.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);
            // 
            // rdo_CafeDa
            // 
            this.rdo_CafeDa.AutoSize = true;
            this.rdo_CafeDa.Location = new System.Drawing.Point(105, 23);
            this.rdo_CafeDa.Name = "rdo_CafeDa";
            this.rdo_CafeDa.Size = new System.Drawing.Size(65, 19);
            this.rdo_CafeDa.TabIndex = 2;
            this.rdo_CafeDa.Text = "Cafe đá";
            this.rdo_CafeDa.UseVisualStyleBackColor = true;
            this.rdo_CafeDa.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);
            // 
            // rdo_CafeSua
            // 
            this.rdo_CafeSua.AutoSize = true;
            this.rdo_CafeSua.Location = new System.Drawing.Point(15, 55);
            this.rdo_CafeSua.Name = "rdo_CafeSua";
            this.rdo_CafeSua.Size = new System.Drawing.Size(70, 19);
            this.rdo_CafeSua.TabIndex = 1;
            this.rdo_CafeSua.Text = "Cafe sữa";
            this.rdo_CafeSua.UseVisualStyleBackColor = true;
            this.rdo_CafeSua.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);
            // 
            // rdo_CafeDen
            // 
            this.rdo_CafeDen.AutoSize = true;
            this.rdo_CafeDen.Location = new System.Drawing.Point(15, 23);
            this.rdo_CafeDen.Name = "rdo_CafeDen";
            this.rdo_CafeDen.Size = new System.Drawing.Size(72, 19);
            this.rdo_CafeDen.TabIndex = 0;
            this.rdo_CafeDen.Text = "Cafe đen";
            this.rdo_CafeDen.UseVisualStyleBackColor = true;
            this.rdo_CafeDen.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);
            // 
            // grp_ThucAn
            // 
            this.grp_ThucAn.Controls.Add(this.chk_MyCay);
            this.grp_ThucAn.Controls.Add(this.chk_MyXaoBo);
            this.grp_ThucAn.Controls.Add(this.chk_MyTomTrung);
            this.grp_ThucAn.Controls.Add(this.chk_BanhMyCa);
            this.grp_ThucAn.Controls.Add(this.chk_BanhMyTrung);
            this.grp_ThucAn.Location = new System.Drawing.Point(245, 150);
            this.grp_ThucAn.Name = "grp_ThucAn";
            this.grp_ThucAn.Size = new System.Drawing.Size(205, 125);
            this.grp_ThucAn.TabIndex = 7;
            this.grp_ThucAn.TabStop = false;
            this.grp_ThucAn.Text = "Thức ăn";
            // 
            // chk_MyCay
            // 
            this.chk_MyCay.AutoSize = true;
            this.chk_MyCay.Location = new System.Drawing.Point(115, 55);
            this.chk_MyCay.Name = "chk_MyCay";
            this.chk_MyCay.Size = new System.Drawing.Size(65, 19);
            this.chk_MyCay.TabIndex = 4;
            this.chk_MyCay.Text = "Mỳ cay";
            this.chk_MyCay.UseVisualStyleBackColor = true;
            // 
            // chk_MyXaoBo
            // 
            this.chk_MyXaoBo.AutoSize = true;
            this.chk_MyXaoBo.Location = new System.Drawing.Point(115, 23);
            this.chk_MyXaoBo.Name = "chk_MyXaoBo";
            this.chk_MyXaoBo.Size = new System.Drawing.Size(80, 19);
            this.chk_MyXaoBo.TabIndex = 3;
            this.chk_MyXaoBo.Text = "Mỳ xào bò";
            this.chk_MyXaoBo.UseVisualStyleBackColor = true;
            // 
            // chk_MyTomTrung
            // 
            this.chk_MyTomTrung.AutoSize = true;
            this.chk_MyTomTrung.Location = new System.Drawing.Point(10, 90);
            this.chk_MyTomTrung.Name = "chk_MyTomTrung";
            this.chk_MyTomTrung.Size = new System.Drawing.Size(99, 19);
            this.chk_MyTomTrung.TabIndex = 2;
            this.chk_MyTomTrung.Text = "Mỳ tôm trứng";
            this.chk_MyTomTrung.UseVisualStyleBackColor = true;
            // 
            // chk_BanhMyCa
            // 
            this.chk_BanhMyCa.AutoSize = true;
            this.chk_BanhMyCa.Location = new System.Drawing.Point(10, 55);
            this.chk_BanhMyCa.Name = "chk_BanhMyCa";
            this.chk_BanhMyCa.Size = new System.Drawing.Size(86, 19);
            this.chk_BanhMyCa.TabIndex = 1;
            this.chk_BanhMyCa.Text = "Bánh mỳ cá";
            this.chk_BanhMyCa.UseVisualStyleBackColor = true;
            // 
            // chk_BanhMyTrung
            // 
            this.chk_BanhMyTrung.AutoSize = true;
            this.chk_BanhMyTrung.Location = new System.Drawing.Point(10, 23);
            this.chk_BanhMyTrung.Name = "chk_BanhMyTrung";
            this.chk_BanhMyTrung.Size = new System.Drawing.Size(102, 19);
            this.chk_BanhMyTrung.TabIndex = 0;
            this.chk_BanhMyTrung.Text = "Bánh mỳ trứng";
            this.chk_BanhMyTrung.UseVisualStyleBackColor = true;
            // 
            // btn_TinhTien
            // 
            this.btn_TinhTien.Location = new System.Drawing.Point(30, 290);
            this.btn_TinhTien.Name = "btn_TinhTien";
            this.btn_TinhTien.Size = new System.Drawing.Size(90, 30);
            this.btn_TinhTien.TabIndex = 8;
            this.btn_TinhTien.Text = "Tính tiền";
            this.btn_TinhTien.UseVisualStyleBackColor = true;
            this.btn_TinhTien.Click += new System.EventHandler(this.btn_TinhTien_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.Location = new System.Drawing.Point(138, 290);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(90, 30);
            this.btn_NhapLai.TabIndex = 9;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.UseVisualStyleBackColor = true;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(246, 290);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(90, 30);
            this.btn_ThanhToan.TabIndex = 10;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(360, 290);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(90, 30);
            this.btn_Thoat.TabIndex = 11;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lbl_TongKH
            // 
            this.lbl_TongKH.AutoSize = true;
            this.lbl_TongKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_TongKH.Location = new System.Drawing.Point(30, 345);
            this.lbl_TongKH.Name = "lbl_TongKH";
            this.lbl_TongKH.Size = new System.Drawing.Size(100, 15);
            this.lbl_TongKH.TabIndex = 12;
            this.lbl_TongKH.Text = "Tổng khách hàng";
            // 
            // txt_TongKH
            // 
            this.txt_TongKH.BackColor = System.Drawing.Color.White;
            this.txt_TongKH.Location = new System.Drawing.Point(165, 342);
            this.txt_TongKH.Name = "txt_TongKH";
            this.txt_TongKH.ReadOnly = true;
            this.txt_TongKH.Size = new System.Drawing.Size(285, 23);
            this.txt_TongKH.TabIndex = 13;
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_TongTien.Location = new System.Drawing.Point(30, 380);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(126, 15);
            this.lbl_TongTien.TabIndex = 14;
            this.lbl_TongTien.Text = "Tổng tiền thanh toán";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BackColor = System.Drawing.Color.White;
            this.txt_TongTien.Location = new System.Drawing.Point(165, 377);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(285, 23);
            this.txt_TongTien.TabIndex = 15;
            // 
            // frmCafeSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 425);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.txt_TongKH);
            this.Controls.Add(this.lbl_TongKH);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_NhapLai);
            this.Controls.Add(this.btn_TinhTien);
            this.Controls.Add(this.grp_ThucAn);
            this.Controls.Add(this.grp_NuocUong);
            this.Controls.Add(this.chk_SinhVien);
            this.Controls.Add(this.txt_SoKH);
            this.Controls.Add(this.lbl_SoKH);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.lbl_TenKH);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCafeSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán tiền";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCafeSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.frmCafeSinhVien_Load);
            this.grp_NuocUong.ResumeLayout(false);
            this.grp_NuocUong.PerformLayout();
            this.grp_ThucAn.ResumeLayout(false);
            this.grp_ThucAn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_TenKH;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label lbl_SoKH;
        private System.Windows.Forms.TextBox txt_SoKH;
        private System.Windows.Forms.CheckBox chk_SinhVien;
        private System.Windows.Forms.GroupBox grp_NuocUong;
        private System.Windows.Forms.RadioButton rdo_CafeSuaDa;
        private System.Windows.Forms.RadioButton rdo_CafeKem;
        private System.Windows.Forms.RadioButton rdo_CafeDa;
        private System.Windows.Forms.RadioButton rdo_CafeSua;
        private System.Windows.Forms.RadioButton rdo_CafeDen;
        private System.Windows.Forms.GroupBox grp_ThucAn;
        private System.Windows.Forms.CheckBox chk_MyCay;
        private System.Windows.Forms.CheckBox chk_MyXaoBo;
        private System.Windows.Forms.CheckBox chk_MyTomTrung;
        private System.Windows.Forms.CheckBox chk_BanhMyCa;
        private System.Windows.Forms.CheckBox chk_BanhMyTrung;
        private System.Windows.Forms.Button btn_TinhTien;
        private System.Windows.Forms.Button btn_NhapLai;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_TongKH;
        private System.Windows.Forms.TextBox txt_TongKH;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.TextBox txt_TongTien;
    }
}