namespace B1_1
{
    partial class frmTreeView
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
            this.trv_DS = new System.Windows.Forms.TreeView();
            this.lbl_PhongBanHeader = new System.Windows.Forms.Label();
            this.lbl_PhongBanInput = new System.Windows.Forms.Label();
            this.txt_phongban = new System.Windows.Forms.TextBox();
            this.btn_ThemPB = new System.Windows.Forms.Button();
            this.btn_XoaPB = new System.Windows.Forms.Button();

            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_MaSo = new System.Windows.Forms.Label();
            this.txt_maso = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.lbl_CboPhongBan = new System.Windows.Forms.Label();
            this.cbo_phongban = new System.Windows.Forms.ComboBox();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // trv_DS   
            // 
            this.trv_DS.Location = new System.Drawing.Point(20, 40);
            this.trv_DS.Name = "trv_DS";
            this.trv_DS.Size = new System.Drawing.Size(220, 230);
            this.trv_DS.TabIndex = 0;

            // 
            // lbl_PhongBanHeader
            // 
            this.lbl_PhongBanHeader.AutoSize = true;
            this.lbl_PhongBanHeader.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhongBanHeader.Location = new System.Drawing.Point(20, 15);
            this.lbl_PhongBanHeader.Name = "lbl_PhongBanHeader";
            this.lbl_PhongBanHeader.Size = new System.Drawing.Size(76, 17);
            this.lbl_PhongBanHeader.Text = "Phòng ban"; 

            // 
            // lbl_PhongBanInput
            // 
            this.lbl_PhongBanInput.AutoSize = true;
            this.lbl_PhongBanInput.Location = new System.Drawing.Point(20, 285);
            this.lbl_PhongBanInput.Name = "lbl_PhongBanInput";
            this.lbl_PhongBanInput.Size = new System.Drawing.Size(72, 17);
            this.lbl_PhongBanInput.Text = "Phòng ban"; 

            // 
            // txt_phongban
            // 
            this.txt_phongban.Location = new System.Drawing.Point(100, 282);
            this.txt_phongban.Name = "txt_phongban";
            this.txt_phongban.Size = new System.Drawing.Size(140, 24);
            this.txt_phongban.TabIndex = 1;

            // 
            // btn_ThemPB   
            // 
            this.btn_ThemPB.Location = new System.Drawing.Point(100, 315);
            this.btn_ThemPB.Name = "btn_ThemPB";
            this.btn_ThemPB.Size = new System.Drawing.Size(140, 30);
            this.btn_ThemPB.TabIndex = 2;
            this.btn_ThemPB.Text = "Thêm phòng ban"; 
            this.btn_ThemPB.UseVisualStyleBackColor = true;
            this.btn_ThemPB.Click += new System.EventHandler(this.btn_ThemPB_Click); 

            // 
            // btn_XoaPB
            // 
            this.btn_XoaPB.Location = new System.Drawing.Point(100, 355);
            this.btn_XoaPB.Name = "btn_XoaPB";
            this.btn_XoaPB.Size = new System.Drawing.Size(140, 30);
            this.btn_XoaPB.TabIndex = 3;
            this.btn_XoaPB.Text = "Xóa phòng ban"; 
            this.btn_XoaPB.UseVisualStyleBackColor = true;
            this.btn_XoaPB.Click += new System.EventHandler(this.btn_XoaPB_Click); 

            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Title.Location = new System.Drawing.Point(320, 15);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(235, 25);
            this.lbl_Title.Text = "HỒ SƠ NHÂN VIÊN";    

            // 
            // lbl_MaSo
            // 
            this.lbl_MaSo.AutoSize = true;
            this.lbl_MaSo.Location = new System.Drawing.Point(270, 60);
            this.lbl_MaSo.Name = "lbl_MaSo";
            this.lbl_MaSo.Size = new System.Drawing.Size(46, 17);
            this.lbl_MaSo.Text = "Mã số"; 

            // 
            // txt_maso 
            // 
            this.txt_maso.Location = new System.Drawing.Point(340, 57);
            this.txt_maso.Name = "txt_maso";
            this.txt_maso.Size = new System.Drawing.Size(90, 24);
            this.txt_maso.TabIndex = 4;

            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Location = new System.Drawing.Point(445, 60);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(48, 17);
            this.lbl_HoTen.Text = "Họ tên"; 

            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(500, 57);
            this.txt_hoten.Name = "txt_hoten musical";
            this.txt_hoten.Size = new System.Drawing.Size(150, 24);
            this.txt_hoten.TabIndex = 5;

            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(270, 100);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(50, 17);
            this.lbl_DiaChi.Text = "Địa chỉ"; 

            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(340, 97);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(310, 24);
            this.txt_diachi.TabIndex = 6;

            // 
            // lbl_CboPhongBan
            // 
            this.lbl_CboPhongBan.AutoSize = true;
            this.lbl_CboPhongBan.Location = new System.Drawing.Point(270, 140);
            this.lbl_CboPhongBan.Name = "lbl_CboPhongBan";
            this.lbl_CboPhongBan.Size = new System.Drawing.Size(72, 17);
            this.lbl_CboPhongBan.Text = "Phòng ban"; 

            // 
            // cbo_phongban
            // 
            this.cbo_phongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_phongban.FormattingEnabled = true;
            this.cbo_phongban.Location = new System.Drawing.Point(340, 137);
            this.cbo_phongban.Name = "cbo_phongban";
            this.cbo_phongban.Size = new System.Drawing.Size(310, 25);
            this.cbo_phongban.TabIndex = 7;

            // 
            // btn_ThemNV   
            // 
            this.btn_ThemNV.Location = new System.Drawing.Point(380, 180);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(80, 30);
            this.btn_ThemNV.TabIndex = 8;
            this.btn_ThemNV.Text = "Thêm"; 
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click); 

            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(480, 180);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(80, 30);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát"; 
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click); 

            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ThemNV);
            this.Controls.Add(this.cbo_phongban);
            this.Controls.Add(this.lbl_CboPhongBan);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.txt_maso);
            this.Controls.Add(this.lbl_MaSo);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_XoaPB);
            this.Controls.Add(this.btn_ThemPB);
            this.Controls.Add(this.txt_phongban);
            this.Controls.Add(this.lbl_PhongBanInput);
            this.Controls.Add(this.lbl_PhongBanHeader);
            this.Controls.Add(this.trv_DS);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Font Times New Roman 11pt
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng ban –Nhân viên"; // Tiêu đề Form
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTreeView_FormClosing); // Sự kiện FormClosing
            this.Load += new System.EventHandler(this.frmTreeView_Load); //
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TreeView trv_DS;
        private System.Windows.Forms.Label lbl_PhongBanHeader;
        private System.Windows.Forms.Label lbl_PhongBanInput;
        private System.Windows.Forms.TextBox txt_phongban;
        private System.Windows.Forms.Button btn_ThemPB;
        private System.Windows.Forms.Button btn_XoaPB;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_MaSo;
        private System.Windows.Forms.TextBox txt_maso;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lbl_CboPhongBan;
        private System.Windows.Forms.ComboBox cbo_phongban;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.Button btn_Thoat;
    }
}