namespace B4_2
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSV = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.lblDanToc = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.chkAnh = new System.Windows.Forms.CheckBox();
            this.chkPhap = new System.Windows.Forms.CheckBox();
            this.chkHoa = new System.Windows.Forms.CheckBox();
            this.cboDanToc = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(60, 25);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(57, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và Tên";
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Location = new System.Drawing.Point(60, 60);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(67, 13);
            this.lblMSV.TabIndex = 1;
            this.lblMSV.Text = "Mã sinh viên";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(60, 95);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgoaiNgu
            // 
            this.lblNgoaiNgu.AutoSize = true;
            this.lblNgoaiNgu.Location = new System.Drawing.Point(60, 130);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new System.Drawing.Size(56, 13);
            this.lblNgoaiNgu.TabIndex = 3;
            this.lblNgoaiNgu.Text = "Ngoại ngữ";
            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = true;
            this.lblDanToc.Location = new System.Drawing.Point(60, 165);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(45, 13);
            this.lblDanToc.TabIndex = 4;
            this.lblDanToc.Text = "Dân tộc";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(160, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(260, 20);
            this.txtHoTen.TabIndex = 5;
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(160, 57);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(260, 20);
            this.txtMSV.TabIndex = 6;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(160, 93);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 7;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(240, 93);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 8;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // chkAnh
            // 
            this.chkAnh.AutoSize = true;
            this.chkAnh.Checked = true;
            this.chkAnh.Location = new System.Drawing.Point(160, 129);
            this.chkAnh.Name = "chkAnh";
            this.chkAnh.Size = new System.Drawing.Size(45, 17);
            this.chkAnh.TabIndex = 9;
            this.chkAnh.Text = "Anh";
            this.chkAnh.UseVisualStyleBackColor = true;
            // 
            // chkPhap
            // 
            this.chkPhap.AutoSize = true;
            this.chkPhap.Location = new System.Drawing.Point(240, 129);
            this.chkPhap.Name = "chkPhap";
            this.chkPhap.Size = new System.Drawing.Size(51, 17);
            this.chkPhap.TabIndex = 10;
            this.chkPhap.Text = "Pháp";
            this.chkPhap.UseVisualStyleBackColor = true;
            // 
            // chkHoa
            // 
            this.chkHoa.AutoSize = true;
            this.chkHoa.Location = new System.Drawing.Point(320, 129);
            this.chkHoa.Name = "chkHoa";
            this.chkHoa.Size = new System.Drawing.Size(46, 17);
            this.chkHoa.TabIndex = 11;
            this.chkHoa.Text = "Hoa";
            this.chkHoa.UseVisualStyleBackColor = true;
            // 
            // cboDanToc
            // 
            this.cboDanToc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanToc.FormattingEnabled = true;    
            this.cboDanToc.Location = new System.Drawing.Point(160, 162);
            this.cboDanToc.Name = "cboDanToc";
            this.cboDanToc.Size = new System.Drawing.Size(260, 21);
            this.cboDanToc.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(440, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 25);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(20, 200);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.Size = new System.Drawing.Size(520, 180);
            this.dgvSinhVien.TabIndex = 14;
            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 400);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboDanToc);
            this.Controls.Add(this.chkHoa);
            this.Controls.Add(this.chkPhap);
            this.Controls.Add(this.chkAnh);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblDanToc);
            this.Controls.Add(this.lblNgoaiNgu);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblMSV);
            this.Controls.Add(this.lblHoTen);
            this.Name = "frmQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaitap1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMSV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.Label lblDanToc;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.CheckBox chkAnh;
        private System.Windows.Forms.CheckBox chkPhap;
        private System.Windows.Forms.CheckBox chkHoa;
        private System.Windows.Forms.ComboBox cboDanToc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvSinhVien;
    }
}