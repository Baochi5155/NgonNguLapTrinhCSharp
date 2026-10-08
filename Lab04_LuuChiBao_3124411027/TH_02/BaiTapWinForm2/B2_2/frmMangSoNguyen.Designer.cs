namespace B2_2
{
    partial class frmMangSoNguyen
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
            this.lbl_NhapMang = new System.Windows.Forms.Label();
            this.txt_NhapMang = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_KqMang = new System.Windows.Forms.Label();
            this.txt_KqMang = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grp_SapXep = new System.Windows.Forms.GroupBox();
            this.btn_ThucHienSapXep = new System.Windows.Forms.Button();
            this.rdo_SapXepGiam = new System.Windows.Forms.RadioButton();
            this.rdo_SapXepTang = new System.Windows.Forms.RadioButton();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_ThucHienTimKiem = new System.Windows.Forms.Button();
            this.txt_KqTimKiem = new System.Windows.Forms.TextBox();
            this.lbl_SoTimDuocLa = new System.Windows.Forms.Label();
            this.txt_ViTriCanTim = new System.Windows.Forms.TextBox();
            this.txt_GiaTriCanTim = new System.Windows.Forms.TextBox();
            this.rdo_TimViTri = new System.Windows.Forms.RadioButton();
            this.rdo_TimGiaTri = new System.Windows.Forms.RadioButton();
            this.grp_Xoa = new System.Windows.Forms.GroupBox();
            this.btn_ThucHienXoa = new System.Windows.Forms.Button();
            this.txt_ViTriCanXoa = new System.Windows.Forms.TextBox();
            this.txt_GiaTriCanXoa = new System.Windows.Forms.TextBox();
            this.rdo_XoaTheoViTri = new System.Windows.Forms.RadioButton();
            this.rdo_XoaTheoGiaTri = new System.Windows.Forms.RadioButton();
            this.grp_Them = new System.Windows.Forms.GroupBox();
            this.btn_ThucHienThem = new System.Windows.Forms.Button();
            this.txt_ViTriCanThem = new System.Windows.Forms.TextBox();
            this.txt_GiaTriCanThem = new System.Windows.Forms.TextBox();
            this.lbl_TaiViTriThem = new System.Windows.Forms.Label();
            this.lbl_GiaTriCanThem = new System.Windows.Forms.Label();
            this.grp_Tong = new System.Windows.Forms.GroupBox();
            this.btn_Tong = new System.Windows.Forms.Button();
            this.txt_TongLe = new System.Windows.Forms.TextBox();
            this.txt_TongChan = new System.Windows.Forms.TextBox();
            this.txt_TongMang = new System.Windows.Forms.TextBox();
            this.lbl_TongLe = new System.Windows.Forms.Label();
            this.lbl_TongChan = new System.Windows.Forms.Label();
            this.lbl_TongMang = new System.Windows.Forms.Label();
            this.grp_MaxMin = new System.Windows.Forms.GroupBox();
            this.btn_TimMaxMin = new System.Windows.Forms.Button();
            this.txt_Min = new System.Windows.Forms.TextBox();
            this.txt_Max = new System.Windows.Forms.TextBox();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.grp_ThayThe = new System.Windows.Forms.GroupBox();
            this.btn_ThucHienThayThe = new System.Windows.Forms.Button();
            this.txt_SoThayTheMoi = new System.Windows.Forms.TextBox();
            this.lbl_SoThayTheLa = new System.Windows.Forms.Label();
            this.txt_ViTriCanThayThe = new System.Windows.Forms.TextBox();
            this.txt_GiaTriCanThayThe = new System.Windows.Forms.TextBox();
            this.rdo_ThayTheTheoViTri = new System.Windows.Forms.RadioButton();
            this.rdo_ThayTheTheoGiaTri = new System.Windows.Forms.RadioButton();
            this.grp_SapXep.SuspendLayout();
            this.grp_TimKiem.SuspendLayout();
            this.grp_Xoa.SuspendLayout();
            this.grp_Them.SuspendLayout();
            this.grp_Tong.SuspendLayout();
            this.grp_MaxMin.SuspendLayout();
            this.grp_ThayThe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(436, 32);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Mảng Số Nguyên";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NhapMang
            // 
            this.lbl_NhapMang.AutoSize = true;
            this.lbl_NhapMang.Location = new System.Drawing.Point(18, 52);
            this.lbl_NhapMang.Name = "lbl_NhapMang";
            this.lbl_NhapMang.Size = new System.Drawing.Size(73, 15);
            this.lbl_NhapMang.TabIndex = 1;
            this.lbl_NhapMang.Text = "Nhập mảng :";
            // 
            // txt_NhapMang
            // 
            this.txt_NhapMang.Location = new System.Drawing.Point(97, 49);
            this.txt_NhapMang.Name = "txt_NhapMang";
            this.txt_NhapMang.Size = new System.Drawing.Size(265, 23);
            this.txt_NhapMang.TabIndex = 2;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(373, 48);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 25);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_KqMang
            // 
            this.lbl_KqMang.AutoSize = true;
            this.lbl_KqMang.Location = new System.Drawing.Point(18, 86);
            this.lbl_KqMang.Name = "lbl_KqMang";
            this.lbl_KqMang.Size = new System.Drawing.Size(83, 15);
            this.lbl_KqMang.TabIndex = 4;
            this.lbl_KqMang.Text = "Kết quả mảng :";
            // 
            // txt_KqMang
            // 
            this.txt_KqMang.BackColor = System.Drawing.Color.White;
            this.txt_KqMang.Location = new System.Drawing.Point(107, 83);
            this.txt_KqMang.Name = "txt_KqMang";
            this.txt_KqMang.ReadOnly = true;
            this.txt_KqMang.Size = new System.Drawing.Size(255, 23);
            this.txt_KqMang.TabIndex = 5;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(373, 82);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 25);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grp_SapXep
            // 
            this.grp_SapXep.Controls.Add(this.btn_ThucHienSapXep);
            this.grp_SapXep.Controls.Add(this.rdo_SapXepGiam);
            this.grp_SapXep.Controls.Add(this.rdo_SapXepTang);
            this.grp_SapXep.Location = new System.Drawing.Point(21, 118);
            this.grp_SapXep.Name = "grp_SapXep";
            this.grp_SapXep.Size = new System.Drawing.Size(427, 60);
            this.grp_SapXep.TabIndex = 7;
            this.grp_SapXep.TabStop = false;
            this.grp_SapXep.Text = "Sắp Xếp";
            // 
            // btn_ThucHienSapXep
            // 
            this.btn_ThucHienSapXep.Location = new System.Drawing.Point(15, 20);
            this.btn_ThucHienSapXep.Name = "btn_ThucHienSapXep";
            this.btn_ThucHienSapXep.Size = new System.Drawing.Size(95, 30);
            this.btn_ThucHienSapXep.TabIndex = 2;
            this.btn_ThucHienSapXep.Text = "Thực Hiện";
            this.btn_ThucHienSapXep.UseVisualStyleBackColor = true;
            this.btn_ThucHienSapXep.Click += new System.EventHandler(this.btn_ThucHienSapXep_Click);
            // 
            // rdo_SapXepGiam
            // 
            this.rdo_SapXepGiam.AutoSize = true;
            this.rdo_SapXepGiam.Location = new System.Drawing.Point(285, 26);
            this.rdo_SapXepGiam.Name = "rdo_SapXepGiam";
            this.rdo_SapXepGiam.Size = new System.Drawing.Size(99, 19);
            this.rdo_SapXepGiam.TabIndex = 1;
            this.rdo_SapXepGiam.Text = "Sắp xếp Giảm";
            this.rdo_SapXepGiam.UseVisualStyleBackColor = true;
            // 
            // rdo_SapXepTang
            // 
            this.rdo_SapXepTang.AutoSize = true;
            this.rdo_SapXepTang.Checked = true;
            this.rdo_SapXepTang.Location = new System.Drawing.Point(145, 26);
            this.rdo_SapXepTang.Name = "rdo_SapXepTang";
            this.rdo_SapXepTang.Size = new System.Drawing.Size(98, 19);
            this.rdo_SapXepTang.TabIndex = 0;
            this.rdo_SapXepTang.TabStop = true;
            this.rdo_SapXepTang.Text = "Sắp xếp Tăng";
            this.rdo_SapXepTang.UseVisualStyleBackColor = true;
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.btn_ThucHienTimKiem);
            this.grp_TimKiem.Controls.Add(this.txt_KqTimKiem);
            this.grp_TimKiem.Controls.Add(this.lbl_SoTimDuocLa);
            this.grp_TimKiem.Controls.Add(this.txt_ViTriCanTim);
            this.grp_TimKiem.Controls.Add(this.txt_GiaTriCanTim);
            this.grp_TimKiem.Controls.Add(this.rdo_TimViTri);
            this.grp_TimKiem.Controls.Add(this.rdo_TimGiaTri);
            this.grp_TimKiem.Location = new System.Drawing.Point(21, 185);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Size = new System.Drawing.Size(205, 142);
            this.grp_TimKiem.TabIndex = 8;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
            // 
            // btn_ThucHienTimKiem
            // 
            this.btn_ThucHienTimKiem.Location = new System.Drawing.Point(10, 108);
            this.btn_ThucHienTimKiem.Name = "btn_ThucHienTimKiem";
            this.btn_ThucHienTimKiem.Size = new System.Drawing.Size(75, 25);
            this.btn_ThucHienTimKiem.TabIndex = 6;
            this.btn_ThucHienTimKiem.Text = "Tìm";
            this.btn_ThucHienTimKiem.UseVisualStyleBackColor = true;
            this.btn_ThucHienTimKiem.Click += new System.EventHandler(this.btn_ThucHienTimKiem_Click);
            // 
            // txt_KqTimKiem
            // 
            this.txt_KqTimKiem.BackColor = System.Drawing.Color.White;
            this.txt_KqTimKiem.Location = new System.Drawing.Point(145, 80);
            this.txt_KqTimKiem.Name = "txt_KqTimKiem";
            this.txt_KqTimKiem.ReadOnly = true;
            this.txt_KqTimKiem.Size = new System.Drawing.Size(50, 23);
            this.txt_KqTimKiem.TabIndex = 5;
            // 
            // lbl_SoTimDuocLa
            // 
            this.lbl_SoTimDuocLa.AutoSize = true;
            this.lbl_SoTimDuocLa.Location = new System.Drawing.Point(10, 83);
            this.lbl_SoTimDuocLa.Name = "lbl_SoTimDuocLa";
            this.lbl_SoTimDuocLa.Size = new System.Drawing.Size(91, 15);
            this.lbl_SoTimDuocLa.TabIndex = 4;
            this.lbl_SoTimDuocLa.Text = "Số tìm được là :";
            // 
            // txt_ViTriCanTim
            // 
            this.txt_ViTriCanTim.Location = new System.Drawing.Point(145, 51);
            this.txt_ViTriCanTim.Name = "txt_ViTriCanTim";
            this.txt_ViTriCanTim.Size = new System.Drawing.Size(50, 23);
            this.txt_ViTriCanTim.TabIndex = 3;
            // 
            // txt_GiaTriCanTim
            // 
            this.txt_GiaTriCanTim.Location = new System.Drawing.Point(145, 22);
            this.txt_GiaTriCanTim.Name = "txt_GiaTriCanTim";
            this.txt_GiaTriCanTim.Size = new System.Drawing.Size(50, 23);
            this.txt_GiaTriCanTim.TabIndex = 2;
            // 
            // rdo_TimViTri
            // 
            this.rdo_TimViTri.AutoSize = true;
            this.rdo_TimViTri.Checked = true;
            this.rdo_TimViTri.Location = new System.Drawing.Point(10, 52);
            this.rdo_TimViTri.Name = "rdo_TimViTri";
            this.rdo_TimViTri.Size = new System.Drawing.Size(107, 19);
            this.rdo_TimViTri.TabIndex = 1;
            this.rdo_TimViTri.TabStop = true;
            this.rdo_TimViTri.Text = "Tìm vị trí cần tìm";
            this.rdo_TimViTri.UseVisualStyleBackColor = true;
            // 
            // rdo_TimGiaTri
            // 
            this.rdo_TimGiaTri.AutoSize = true;
            this.rdo_TimGiaTri.Location = new System.Drawing.Point(10, 23);
            this.rdo_TimGiaTri.Name = "rdo_TimGiaTri";
            this.rdo_TimGiaTri.Size = new System.Drawing.Size(115, 19);
            this.rdo_TimGiaTri.TabIndex = 0;
            this.rdo_TimGiaTri.Text = "Tìm giá trị cần tìm";
            this.rdo_TimGiaTri.UseVisualStyleBackColor = true;
            // 
            // grp_Xoa
            // 
            this.grp_Xoa.Controls.Add(this.btn_ThucHienXoa);
            this.grp_Xoa.Controls.Add(this.txt_ViTriCanXoa);
            this.grp_Xoa.Controls.Add(this.txt_GiaTriCanXoa);
            this.grp_Xoa.Controls.Add(this.rdo_XoaTheoViTri);
            this.grp_Xoa.Controls.Add(this.rdo_XoaTheoGiaTri);
            this.grp_Xoa.Location = new System.Drawing.Point(238, 185);
            this.grp_Xoa.Name = "grp_Xoa";
            this.grp_Xoa.Size = new System.Drawing.Size(210, 142);
            this.grp_Xoa.TabIndex = 9;
            this.grp_Xoa.TabStop = false;
            this.grp_Xoa.Text = "Xóa";
            // 
            // btn_ThucHienXoa
            // 
            this.btn_ThucHienXoa.Location = new System.Drawing.Point(10, 88);
            this.btn_ThucHienXoa.Name = "btn_ThucHienXoa";
            this.btn_ThucHienXoa.Size = new System.Drawing.Size(75, 25);
            this.btn_ThucHienXoa.TabIndex = 4;
            this.btn_ThucHienXoa.Text = "Xóa";
            this.btn_ThucHienXoa.UseVisualStyleBackColor = true;
            this.btn_ThucHienXoa.Click += new System.EventHandler(this.btn_ThucHienXoa_Click);
            // 
            // txt_ViTriCanXoa
            // 
            this.txt_ViTriCanXoa.Location = new System.Drawing.Point(150, 51);
            this.txt_ViTriCanXoa.Name = "txt_ViTriCanXoa";
            this.txt_ViTriCanXoa.Size = new System.Drawing.Size(50, 23);
            this.txt_ViTriCanXoa.TabIndex = 3;
            // 
            // txt_GiaTriCanXoa
            // 
            this.txt_GiaTriCanXoa.Location = new System.Drawing.Point(150, 22);
            this.txt_GiaTriCanXoa.Name = "txt_GiaTriCanXoa";
            this.txt_GiaTriCanXoa.Size = new System.Drawing.Size(50, 23);
            this.txt_GiaTriCanXoa.TabIndex = 2;
            // 
            // rdo_XoaTheoViTri
            // 
            this.rdo_XoaTheoViTri.AutoSize = true;
            this.rdo_XoaTheoViTri.Location = new System.Drawing.Point(10, 52);
            this.rdo_XoaTheoViTri.Name = "rdo_XoaTheoViTri";
            this.rdo_XoaTheoViTri.Size = new System.Drawing.Size(108, 19);
            this.rdo_XoaTheoViTri.TabIndex = 1;
            this.rdo_XoaTheoViTri.Text = "Tìm vị trí cần xóa";
            this.rdo_XoaTheoViTri.UseVisualStyleBackColor = true;
            // 
            // rdo_XoaTheoGiaTri
            // 
            this.rdo_XoaTheoGiaTri.AutoSize = true;
            this.rdo_XoaTheoGiaTri.Checked = true;
            this.rdo_XoaTheoGiaTri.Location = new System.Drawing.Point(10, 23);
            this.rdo_XoaTheoGiaTri.Name = "rdo_XoaTheoGiaTri";
            this.rdo_XoaTheoGiaTri.Size = new System.Drawing.Size(116, 19);
            this.rdo_XoaTheoGiaTri.TabIndex = 0;
            this.rdo_XoaTheoGiaTri.TabStop = true;
            this.rdo_XoaTheoGiaTri.Text = "Tìm giá trị cần xóa";
            this.rdo_XoaTheoGiaTri.UseVisualStyleBackColor = true;
            // 
            // grp_Them
            // 
            this.grp_Them.Controls.Add(this.btn_ThucHienThem);
            this.grp_Them.Controls.Add(this.txt_ViTriCanThem);
            this.grp_Them.Controls.Add(this.txt_GiaTriCanThem);
            this.grp_Them.Controls.Add(this.lbl_TaiViTriThem);
            this.grp_Them.Controls.Add(this.lbl_GiaTriCanThem);
            this.grp_Them.Location = new System.Drawing.Point(21, 335);
            this.grp_Them.Name = "grp_Them";
            this.grp_Them.Size = new System.Drawing.Size(205, 120);
            this.grp_Them.TabIndex = 10;
            this.grp_Them.TabStop = false;
            this.grp_Them.Text = "Thêm";
            // 
            // btn_ThucHienThem
            // 
            this.btn_ThucHienThem.Location = new System.Drawing.Point(10, 85);
            this.btn_ThucHienThem.Name = "btn_ThucHienThem";
            this.btn_ThucHienThem.Size = new System.Drawing.Size(75, 25);
            this.btn_ThucHienThem.TabIndex = 4;
            this.btn_ThucHienThem.Text = "Thêm";
            this.btn_ThucHienThem.UseVisualStyleBackColor = true;
            this.btn_ThucHienThem.Click += new System.EventHandler(this.btn_ThucHienThem_Click);
            // 
            // txt_ViTriCanThem
            // 
            this.txt_ViTriCanThem.Location = new System.Drawing.Point(145, 51);
            this.txt_ViTriCanThem.Name = "txt_ViTriCanThem";
            this.txt_ViTriCanThem.Size = new System.Drawing.Size(50, 23);
            this.txt_ViTriCanThem.TabIndex = 3;
            // 
            // txt_GiaTriCanThem
            // 
            this.txt_GiaTriCanThem.Location = new System.Drawing.Point(145, 22);
            this.txt_GiaTriCanThem.Name = "txt_GiaTriCanThem";
            this.txt_GiaTriCanThem.Size = new System.Drawing.Size(50, 23);
            this.txt_GiaTriCanThem.TabIndex = 2;
            // 
            // lbl_TaiViTriThem
            // 
            this.lbl_TaiViTriThem.AutoSize = true;
            this.lbl_TaiViTriThem.Location = new System.Drawing.Point(10, 54);
            this.lbl_TaiViTriThem.Name = "lbl_TaiViTriThem";
            this.lbl_TaiViTriThem.Size = new System.Drawing.Size(91, 15);
            this.lbl_TaiViTriThem.TabIndex = 1;
            this.lbl_TaiViTriThem.Text = "Tại vị trí cần thêm :";
            // 
            // lbl_GiaTriCanThem
            // 
            this.lbl_GiaTriCanThem.AutoSize = true;
            this.lbl_GiaTriCanThem.Location = new System.Drawing.Point(10, 25);
            this.lbl_GiaTriCanThem.Name = "lbl_GiaTriCanThem";
            this.lbl_GiaTriCanThem.Size = new System.Drawing.Size(126, 15);
            this.lbl_GiaTriCanThem.TabIndex = 0;
            this.lbl_GiaTriCanThem.Text = "Tìm giá trị cần thêm";
            // 
            // grp_Tong
            // 
            this.grp_Tong.Controls.Add(this.btn_Tong);
            this.grp_Tong.Controls.Add(this.txt_TongLe);
            this.grp_Tong.Controls.Add(this.txt_TongChan);
            this.grp_Tong.Controls.Add(this.txt_TongMang);
            this.grp_Tong.Controls.Add(this.lbl_TongLe);
            this.grp_Tong.Controls.Add(this.lbl_TongChan);
            this.grp_Tong.Controls.Add(this.lbl_TongMang);
            this.grp_Tong.Location = new System.Drawing.Point(238, 335);
            this.grp_Tong.Name = "grp_Tong";
            this.grp_Tong.Size = new System.Drawing.Size(210, 120);
            this.grp_Tong.TabIndex = 11;
            this.grp_Tong.TabStop = false;
            this.grp_Tong.Text = "Tổng";
            // 
            // btn_Tong
            // 
            this.btn_Tong.Location = new System.Drawing.Point(145, 23);
            this.btn_Tong.Name = "btn_Tong";
            this.btn_Tong.Size = new System.Drawing.Size(55, 80);
            this.btn_Tong.TabIndex = 6;
            this.btn_Tong.Text = "Tổng";
            this.btn_Tong.UseVisualStyleBackColor = true;
            this.btn_Tong.Click += new System.EventHandler(this.btn_Tong_Click);
            // 
            // txt_TongLe
            // 
            this.txt_TongLe.BackColor = System.Drawing.Color.White;
            this.txt_TongLe.Location = new System.Drawing.Point(85, 80);
            this.txt_TongLe.Name = "txt_TongLe";
            this.txt_TongLe.ReadOnly = true;
            this.txt_TongLe.Size = new System.Drawing.Size(50, 23);
            this.txt_TongLe.TabIndex = 5;
            // 
            // txt_TongChan
            // 
            this.txt_TongChan.BackColor = System.Drawing.Color.White;
            this.txt_TongChan.Location = new System.Drawing.Point(85, 51);
            this.txt_TongChan.Name = "txt_TongChan";
            this.txt_TongChan.ReadOnly = true;
            this.txt_TongChan.Size = new System.Drawing.Size(50, 23);
            this.txt_TongChan.TabIndex = 4;
            // 
            // txt_TongMang
            // 
            this.txt_TongMang.BackColor = System.Drawing.Color.White;
            this.txt_TongMang.Location = new System.Drawing.Point(85, 22);
            this.txt_TongMang.Name = "txt_TongMang";
            this.txt_TongMang.ReadOnly = true;
            this.txt_TongMang.Size = new System.Drawing.Size(50, 23);
            this.txt_TongMang.TabIndex = 3;
            // 
            // lbl_TongLe
            // 
            this.lbl_TongLe.AutoSize = true;
            this.lbl_TongLe.Location = new System.Drawing.Point(10, 83);
            this.lbl_TongLe.Name = "lbl_TongLe";
            this.lbl_TongLe.Size = new System.Drawing.Size(52, 15);
            this.lbl_TongLe.TabIndex = 2;
            this.lbl_TongLe.Text = "Tổng lẻ";
            // 
            // lbl_TongChan
            // 
            this.lbl_TongChan.AutoSize = true;
            this.lbl_TongChan.Location = new System.Drawing.Point(10, 54);
            this.lbl_TongChan.Name = "lbl_TongChan";
            this.lbl_TongChan.Size = new System.Drawing.Size(68, 15);
            this.lbl_TongChan.TabIndex = 1;
            this.lbl_TongChan.Text = "Tổng chẵn";
            // 
            // lbl_TongMang
            // 
            this.lbl_TongMang.AutoSize = true;
            this.lbl_TongMang.Location = new System.Drawing.Point(10, 25);
            this.lbl_TongMang.Name = "lbl_TongMang";
            this.lbl_TongMang.Size = new System.Drawing.Size(73, 15);
            this.lbl_TongMang.TabIndex = 0;
            this.lbl_TongMang.Text = "Tổng mảng";
            // 
            // grp_MaxMin
            // 
            this.grp_MaxMin.Controls.Add(this.btn_TimMaxMin);
            this.grp_MaxMin.Controls.Add(this.txt_Min);
            this.grp_MaxMin.Controls.Add(this.txt_Max);
            this.grp_MaxMin.Controls.Add(this.lbl_Min);
            this.grp_MaxMin.Controls.Add(this.lbl_Max);
            this.grp_MaxMin.Location = new System.Drawing.Point(21, 465);
            this.grp_MaxMin.Name = "grp_MaxMin";
            this.grp_MaxMin.Size = new System.Drawing.Size(205, 125);
            this.grp_MaxMin.TabIndex = 12;
            this.grp_MaxMin.TabStop = false;
            this.grp_MaxMin.Text = "Max - Min";
            // 
            // btn_TimMaxMin
            // 
            this.btn_TimMaxMin.Location = new System.Drawing.Point(145, 23);
            this.btn_TimMaxMin.Name = "btn_TimMaxMin";
            this.btn_TimMaxMin.Size = new System.Drawing.Size(50, 80);
            this.btn_TimMaxMin.TabIndex = 4;
            this.btn_TimMaxMin.Text = "Tìm";
            this.btn_TimMaxMin.UseVisualStyleBackColor = true;
            this.btn_TimMaxMin.Click += new System.EventHandler(this.btn_TimMaxMin_Click);
            // 
            // txt_Min
            // 
            this.txt_Min.BackColor = System.Drawing.Color.White;
            this.txt_Min.Location = new System.Drawing.Point(90, 68);
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.ReadOnly = true;
            this.txt_Min.Size = new System.Drawing.Size(45, 23);
            this.txt_Min.TabIndex = 3;
            // 
            // txt_Max
            // 
            this.txt_Max.BackColor = System.Drawing.Color.White;
            this.txt_Max.Location = new System.Drawing.Point(90, 28);
            this.txt_Max.Name = "txt_Max";
            this.txt_Max.ReadOnly = true;
            this.txt_Max.Size = new System.Drawing.Size(45, 23);
            this.txt_Max.TabIndex = 2;
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Location = new System.Drawing.Point(8, 71);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(81, 15);
            this.lbl_Min.TabIndex = 1;
            this.lbl_Min.Text = "Giá trị nhỏ nhất";
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Location = new System.Drawing.Point(8, 31);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(83, 15);
            this.lbl_Max.TabIndex = 0;
            this.lbl_Max.Text = "Giá trị lớn nhất";
            // 
            // grp_ThayThe
            // 
            this.grp_ThayThe.Controls.Add(this.btn_ThucHienThayThe);
            this.grp_ThayThe.Controls.Add(this.txt_SoThayTheMoi);
            this.grp_ThayThe.Controls.Add(this.lbl_SoThayTheLa);
            this.grp_ThayThe.Controls.Add(this.txt_ViTriCanThayThe);
            this.grp_ThayThe.Controls.Add(this.txt_GiaTriCanThayThe);
            this.grp_ThayThe.Controls.Add(this.rdo_ThayTheTheoViTri);
            this.grp_ThayThe.Controls.Add(this.rdo_ThayTheTheoGiaTri);
            this.grp_ThayThe.Location = new System.Drawing.Point(238, 465);
            this.grp_ThayThe.Name = "grp_ThayThe";
            this.grp_ThayThe.Size = new System.Drawing.Size(210, 150);
            this.grp_ThayThe.TabIndex = 13;
            this.grp_ThayThe.TabStop = false;
            this.grp_ThayThe.Text = "Thay Thế";
            // 
            // btn_ThucHienThayThe
            // 
            this.btn_ThucHienThayThe.Location = new System.Drawing.Point(10, 115);
            this.btn_ThucHienThayThe.Name = "btn_ThucHienThayThe";
            this.btn_ThucHienThayThe.Size = new System.Drawing.Size(75, 25);
            this.btn_ThucHienThayThe.TabIndex = 6;
            this.btn_ThucHienThayThe.Text = "Thay";
            this.btn_ThucHienThayThe.UseVisualStyleBackColor = true;
            this.btn_ThucHienThayThe.Click += new System.EventHandler(this.btn_ThucHienThayThe_Click);
            // 
            // txt_SoThayTheMoi
            // 
            this.txt_SoThayTheMoi.Location = new System.Drawing.Point(145, 80);
            this.txt_SoThayTheMoi.Name = "txt_SoThayTheMoi";
            this.txt_SoThayTheMoi.Size = new System.Drawing.Size(50, 23);
            this.txt_SoThayTheMoi.TabIndex = 5;
            // 
            // lbl_SoThayTheLa
            // 
            this.lbl_SoThayTheLa.AutoSize = true;
            this.lbl_SoThayTheLa.Location = new System.Drawing.Point(10, 83);
            this.lbl_SoThayTheLa.Name = "lbl_SoThayTheLa";
            this.lbl_SoThayTheLa.Size = new System.Drawing.Size(89, 15);
            this.lbl_SoThayTheLa.TabIndex = 4;
            this.lbl_SoThayTheLa.Text = "Số thay thế là :";
            // 
            // txt_ViTriCanThayThe
            // 
            this.txt_ViTriCanThayThe.Location = new System.Drawing.Point(145, 51);
            this.txt_ViTriCanThayThe.Name = "txt_ViTriCanThayThe";
            this.txt_ViTriCanThayThe.Size = new System.Drawing.Size(50, 23);
            this.txt_ViTriCanThayThe.TabIndex = 3;
            // 
            // txt_GiaTriCanThayThe
            // 
            this.txt_GiaTriCanThayThe.Location = new System.Drawing.Point(145, 22);
            this.txt_GiaTriCanThayThe.Name = "txt_GiaTriCanThayThe";
            this.txt_GiaTriCanThayThe.Size = new System.Drawing.Size(50, 23);
            this.txt_GiaTriCanThayThe.TabIndex = 2;
            // 
            // rdo_ThayTheTheoViTri
            // 
            this.rdo_ThayTheTheoViTri.AutoSize = true;
            this.rdo_ThayTheTheoViTri.Location = new System.Drawing.Point(10, 52);
            this.rdo_ThayTheTheoViTri.Name = "rdo_ThayTheTheoViTri";
            this.rdo_ThayTheTheoViTri.Size = new System.Drawing.Size(125, 19);
            this.rdo_ThayTheTheoViTri.TabIndex = 1;
            this.rdo_ThayTheTheoViTri.Text = "Vị trí cần thay thế";
            this.rdo_ThayTheTheoViTri.UseVisualStyleBackColor = true;
            // 
            // rdo_ThayTheTheoGiaTri
            // 
            this.rdo_ThayTheTheoGiaTri.AutoSize = true;
            this.rdo_ThayTheTheoGiaTri.Checked = true;
            this.rdo_ThayTheTheoGiaTri.Location = new System.Drawing.Point(10, 23);
            this.rdo_ThayTheTheoGiaTri.Name = "rdo_ThayTheTheoGiaTri";
            this.rdo_ThayTheTheoGiaTri.Size = new System.Drawing.Size(133, 19);
            this.rdo_ThayTheTheoGiaTri.TabIndex = 0;
            this.rdo_ThayTheTheoGiaTri.TabStop = true;
            this.rdo_ThayTheTheoGiaTri.Text = "Giá trị cần thay thế";
            this.rdo_ThayTheTheoGiaTri.UseVisualStyleBackColor = true;
            // 
            // frmMangSoNguyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 630);
            this.Controls.Add(this.grp_ThayThe);
            this.Controls.Add(this.grp_MaxMin);
            this.Controls.Add(this.grp_Tong);
            this.Controls.Add(this.grp_Them);
            this.Controls.Add(this.grp_Xoa);
            this.Controls.Add(this.grp_TimKiem);
            this.Controls.Add(this.grp_SapXep);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.txt_KqMang);
            this.Controls.Add(this.lbl_KqMang);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.txt_NhapMang);
            this.Controls.Add(this.lbl_NhapMang);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMangSoNguyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mảng Số Nguyên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMangSoNguyen_FormClosing);
            this.grp_SapXep.ResumeLayout(false);
            this.grp_SapXep.PerformLayout();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            this.grp_Xoa.ResumeLayout(false);
            this.grp_Xoa.PerformLayout();
            this.grp_Them.ResumeLayout(false);
            this.grp_Them.PerformLayout();
            this.grp_Tong.ResumeLayout(false);
            this.grp_Tong.PerformLayout();
            this.grp_MaxMin.ResumeLayout(false);
            this.grp_MaxMin.PerformLayout();
            this.grp_ThayThe.ResumeLayout(false);
            this.grp_ThayThe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_NhapMang;
        private System.Windows.Forms.TextBox txt_NhapMang;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_KqMang;
        private System.Windows.Forms.TextBox txt_KqMang;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grp_SapXep;
        private System.Windows.Forms.Button btn_ThucHienSapXep;
        private System.Windows.Forms.RadioButton rdo_SapXepGiam;
        private System.Windows.Forms.RadioButton rdo_SapXepTang;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.Button btn_ThucHienTimKiem;
        private System.Windows.Forms.TextBox txt_KqTimKiem;
        private System.Windows.Forms.Label lbl_SoTimDuocLa;
        private System.Windows.Forms.TextBox txt_ViTriCanTim;
        private System.Windows.Forms.TextBox txt_GiaTriCanTim;
        private System.Windows.Forms.RadioButton rdo_TimViTri;
        private System.Windows.Forms.RadioButton rdo_TimGiaTri;
        private System.Windows.Forms.GroupBox grp_Xoa;
        private System.Windows.Forms.Button btn_ThucHienXoa;
        private System.Windows.Forms.TextBox txt_ViTriCanXoa;
        private System.Windows.Forms.TextBox txt_GiaTriCanXoa;
        private System.Windows.Forms.RadioButton rdo_XoaTheoViTri;
        private System.Windows.Forms.RadioButton rdo_XoaTheoGiaTri;
        private System.Windows.Forms.GroupBox grp_Them;
        private System.Windows.Forms.Button btn_ThucHienThem;
        private System.Windows.Forms.TextBox txt_ViTriCanThem;
        private System.Windows.Forms.TextBox txt_GiaTriCanThem;
        private System.Windows.Forms.Label lbl_TaiViTriThem;
        private System.Windows.Forms.Label lbl_GiaTriCanThem;
        private System.Windows.Forms.GroupBox grp_Tong;
        private System.Windows.Forms.Button btn_Tong;
        private System.Windows.Forms.TextBox txt_TongLe;
        private System.Windows.Forms.TextBox txt_TongChan;
        private System.Windows.Forms.TextBox txt_TongMang;
        private System.Windows.Forms.Label lbl_TongLe;
        private System.Windows.Forms.Label lbl_TongChan;
        private System.Windows.Forms.Label lbl_TongMang;
        private System.Windows.Forms.GroupBox grp_MaxMin;
        private System.Windows.Forms.Button btn_TimMaxMin;
        private System.Windows.Forms.TextBox txt_Min;
        private System.Windows.Forms.TextBox txt_Max;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Label lbl_Max;
        private System.Windows.Forms.GroupBox grp_ThayThe;
        private System.Windows.Forms.Button btn_ThucHienThayThe;
        private System.Windows.Forms.TextBox txt_SoThayTheMoi;
        private System.Windows.Forms.Label lbl_SoThayTheLa;
        private System.Windows.Forms.TextBox txt_ViTriCanThayThe;
        private System.Windows.Forms.TextBox txt_GiaTriCanThayThe;
        private System.Windows.Forms.RadioButton rdo_ThayTheTheoViTri;
        private System.Windows.Forms.RadioButton rdo_ThayTheTheoGiaTri;
    }
}