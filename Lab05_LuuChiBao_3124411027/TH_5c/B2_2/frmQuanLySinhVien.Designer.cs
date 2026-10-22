namespace B1_1
{
    partial class frmQuanLySinhVien
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
            this.trv_DanhSach = new System.Windows.Forms.TreeView();
            this.lbl_ChonLop = new System.Windows.Forms.Label();
            this.cbo_ChonLop = new System.Windows.Forms.ComboBox();
            this.grp_ThongTinSV = new System.Windows.Forms.GroupBox();
            this.lbl_MaSV = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.chk_ThemLop = new System.Windows.Forms.CheckBox();
            this.grp_ThongTinLop = new System.Windows.Forms.GroupBox();
            this.lbl_TenLop = new System.Windows.Forms.Label();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.btn_ThemLop = new System.Windows.Forms.Button();

            this.grp_ThongTinSV.SuspendLayout();
            this.grp_ThongTinLop.SuspendLayout();
            this.SuspendLayout();

            // 
            // trv_DanhSach 
            // 
            this.trv_DanhSach.Location = new System.Drawing.Point(15, 15);
            this.trv_DanhSach.Name = "trv_DanhSach";
            this.trv_DanhSach.Size = new System.Drawing.Size(220, 390);
            this.trv_DanhSach.TabIndex = 0;
            this.trv_DanhSach.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_DanhSach_AfterSelect);

            // 
            // lbl_ChonLop
            // 
            this.lbl_ChonLop.AutoSize = true;
            this.lbl_ChonLop.Location = new System.Drawing.Point(260, 20);
            this.lbl_ChonLop.Name = "lbl_ChonLop";
            this.lbl_ChonLop.Size = new System.Drawing.Size(65, 17);
            this.lbl_ChonLop.Text = "Chọn Lớp"; 

            // 
            // cbo_ChonLop
            // 
            this.cbo_ChonLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ChonLop.FormattingEnabled = true;
            this.cbo_ChonLop.Location = new System.Drawing.Point(340, 17);
            this.cbo_ChonLop.Name = "cbo_ChonLop";
            this.cbo_ChonLop.Size = new System.Drawing.Size(220, 25);
            this.cbo_ChonLop.TabIndex = 1;

            // 
            // grp_ThongTinSV   
            // 
            this.grp_ThongTinSV.Controls.Add(this.btn_Xoa);
            this.grp_ThongTinSV.Controls.Add(this.btn_CapNhat);
            this.grp_ThongTinSV.Controls.Add(this.txt_DiaChi);
            this.grp_ThongTinSV.Controls.Add(this.lbl_DiaChi);
            this.grp_ThongTinSV.Controls.Add(this.txt_HoTen);
            this.grp_ThongTinSV.Controls.Add(this.lbl_HoTen);
            this.grp_ThongTinSV.Controls.Add(this.txt_MaSV);
            this.grp_ThongTinSV.Controls.Add(this.lbl_MaSV);
            this.grp_ThongTinSV.Location = new System.Drawing.Point(255, 55);
            this.grp_ThongTinSV.Name = "grp_ThongTinSV";
            this.grp_ThongTinSV.Size = new System.Drawing.Size(320, 220);
            this.grp_ThongTinSV.TabIndex = 2;
            this.grp_ThongTinSV.TabStop = false;
            this.grp_ThongTinSV.Text = "Thông tin sinh viên";   

            // 
            // lbl_MaSV
            // 
            this.lbl_MaSV.AutoSize = true;
            this.lbl_MaSV.Location = new System.Drawing.Point(15, 35);
            this.lbl_MaSV.Name = "lbl_MaSV";
            this.lbl_MaSV.Size = new System.Drawing.Size(51, 17);
            this.lbl_MaSV.Text = "Mã SV:";  

            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(80, 32);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(220, 24);
            this.txt_MaSV.TabIndex = 0;

            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Location = new System.Drawing.Point(15, 75);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(58, 17);
            this.lbl_HoTen.Text = "Họ Tên:"; 

            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(80, 72);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(220, 24);
            this.txt_HoTen.TabIndex = 1;

            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(15, 115);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(56, 17);
            this.lbl_DiaChi.Text = "Địa Chỉ:"; 

            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(80, 112);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(220, 24);
            this.txt_DiaChi.TabIndex = 2;

            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(80, 160);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(100, 30);
            this.btn_CapNhat.TabIndex = 3;
            this.btn_CapNhat.Text = "Cập Nhật"; 
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click); 

            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(200, 160);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 30);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";  
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);  

            // 
            // chk_ThemLop
            // 
            this.chk_ThemLop.AutoSize = true;
            this.chk_ThemLop.Location = new System.Drawing.Point(255, 290);
            this.chk_ThemLop.Name = "chk_ThemLop";
            this.chk_ThemLop.Size = new System.Drawing.Size(84, 21);
            this.chk_ThemLop.TabIndex = 3;
            this.chk_ThemLop.Text = "Thêm lớp";     
            this.chk_ThemLop.UseVisualStyleBackColor = true;
            this.chk_ThemLop.CheckedChanged += new System.EventHandler(this.chk_ThemLop_CheckedChanged); 

            // 
            // grp_ThongTinLop
            // 
            this.grp_ThongTinLop.Controls.Add(this.btn_ThemLop);
            this.grp_ThongTinLop.Controls.Add(this.txt_TenLop);
            this.grp_ThongTinLop.Controls.Add(this.lbl_TenLop);
            this.grp_ThongTinLop.Location = new System.Drawing.Point(255, 320);
            this.grp_ThongTinLop.Name = "grp_ThongTinLop";
            this.grp_ThongTinLop.Size = new System.Drawing.Size(320, 85);
            this.grp_ThongTinLop.TabIndex = 4;
            this.grp_ThongTinLop.TabStop = false;
            this.grp_ThongTinLop.Text = "Thông tin lớp"; 

            // 
            // lbl_TenLop
            // 
            this.lbl_TenLop.AutoSize = true;
            this.lbl_TenLop.Location = new System.Drawing.Point(15, 35);
            this.lbl_TenLop.Name = "lbl_TenLop";
            this.lbl_TenLop.Size = new System.Drawing.Size(60, 17);
            this.lbl_TenLop.Text = "Tên lớp:"; 

            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(80, 32);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(120, 24);
            this.txt_TenLop.TabIndex = 0;

            // 
            // btn_ThemLop
            // 
            this.btn_ThemLop.Location = new System.Drawing.Point(210, 30);
            this.btn_ThemLop.Name = "btn_ThemLop";
            this.btn_ThemLop.Size = new System.Drawing.Size(90, 28);
            this.btn_ThemLop.TabIndex = 1;
            this.btn_ThemLop.Text = "Thêm lớp"; 
            this.btn_ThemLop.UseVisualStyleBackColor = true;
            this.btn_ThemLop.Click += new System.EventHandler(this.btn_ThemLop_Click); 

            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 420);
            this.Controls.Add(this.grp_ThongTinLop);
            this.Controls.Add(this.chk_ThemLop);
            this.Controls.Add(this.grp_ThongTinSV);
            this.Controls.Add(this.cbo_ChonLop);
            this.Controls.Add(this.lbl_ChonLop);
            this.Controls.Add(this.trv_DanhSach);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên"; 
            this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load); 
            this.grp_ThongTinSV.ResumeLayout(false);
            this.grp_ThongTinSV.PerformLayout();
            this.grp_ThongTinLop.ResumeLayout(false);
            this.grp_ThongTinLop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TreeView trv_DanhSach;
        private System.Windows.Forms.Label lbl_ChonLop;
        private System.Windows.Forms.ComboBox cbo_ChonLop;
        private System.Windows.Forms.GroupBox grp_ThongTinSV;
        private System.Windows.Forms.Label lbl_MaSV;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.CheckBox chk_ThemLop;
        private System.Windows.Forms.GroupBox grp_ThongTinLop;
        private System.Windows.Forms.Label lbl_TenLop;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.Button btn_ThemLop;
    }
}