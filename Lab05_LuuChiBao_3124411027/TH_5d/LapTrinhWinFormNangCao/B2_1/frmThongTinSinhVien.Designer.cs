namespace B2_1
{
    partial class frmThongTinSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.chkAnh = new System.Windows.Forms.CheckBox();
            this.chkPhap = new System.Windows.Forms.CheckBox();
            this.chkHoa = new System.Windows.Forms.CheckBox();
            this.lblDanToc = new System.Windows.Forms.Label();
            this.cboDanToc = new System.Windows.Forms.ComboBox();
            this.lsvSinhVien = new System.Windows.Forms.ListView();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colMaSV = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinh = new System.Windows.Forms.ColumnHeader();
            this.colNgoaiNgu = new System.Windows.Forms.ColumnHeader();
            this.colDanToc = new System.Windows.Forms.ColumnHeader();
            this.cmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cmsListView.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(80, 25);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(68, 17);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và Tên";

            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(180, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(260, 24);
            this.txtHoTen.TabIndex = 1;

            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(80, 65);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(84, 17);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sinh viên";

            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(180, 62);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(260, 24);
            this.txtMaSV.TabIndex = 3;

            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(80, 105);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(56, 17);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính";

            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(180, 103);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(54, 21);
            this.rdoNam.TabIndex = 5;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;

            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(260, 103);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(44, 21);
            this.rdoNu.TabIndex = 6;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;

            // 
            // lblNgoaiNgu
            // 
            this.lblNgoaiNgu.AutoSize = true;
            this.lblNgoaiNgu.Location = new System.Drawing.Point(80, 145);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new System.Drawing.Size(70, 17);
            this.lblNgoaiNgu.TabIndex = 7;
            this.lblNgoaiNgu.Text = "Ngoại ngữ";

            // 
            // chkAnh
            // 
            this.chkAnh.AutoSize = true;
            this.chkAnh.Location = new System.Drawing.Point(180, 144);
            this.chkAnh.Name = "chkAnh";
            this.chkAnh.Size = new System.Drawing.Size(51, 21);
            this.chkAnh.TabIndex = 8;
            this.chkAnh.Text = "Anh";
            this.chkAnh.UseVisualStyleBackColor = true;

            // 
            // chkPhap
            // 
            this.chkPhap.AutoSize = true;
            this.chkPhap.Location = new System.Drawing.Point(260, 144);
            this.chkPhap.Name = "chkPhap";
            this.chkPhap.Size = new System.Drawing.Size(58, 21);
            this.chkPhap.TabIndex = 9;
            this.chkPhap.Text = "Pháp";
            this.chkPhap.UseVisualStyleBackColor = true;

            // 
            // chkHoa
            // 
            this.chkHoa.AutoSize = true;
            this.chkHoa.Location = new System.Drawing.Point(340, 144);
            this.chkHoa.Name = "chkHoa";
            this.chkHoa.Size = new System.Drawing.Size(52, 21);
            this.chkHoa.TabIndex = 10;
            this.chkHoa.Text = "Hoa";
            this.chkHoa.UseVisualStyleBackColor = true;

            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = true;
            this.lblDanToc.Location = new System.Drawing.Point(80, 185);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(56, 17);
            this.lblDanToc.TabIndex = 11;
            this.lblDanToc.Text = "Dân tộc";

            // 
            // cboDanToc
            // 
            this.cboDanToc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanToc.FormattingEnabled = true;
            this.cboDanToc.Location = new System.Drawing.Point(180, 182);
            this.cboDanToc.Name = "cboDanToc";
            this.cboDanToc.Size = new System.Drawing.Size(260, 25);
            this.cboDanToc.TabIndex = 12;

            // 
            // lsvSinhVien
            // 
            this.lsvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHoTen,
            this.colMaSV,
            this.colGioiTinh,
            this.colNgoaiNgu,
            this.colDanToc});
            this.lsvSinhVien.ContextMenuStrip = this.cmsListView;
            this.lsvSinhVien.FullRowSelect = true;
            this.lsvSinhVien.GridLines = true;
            this.lsvSinhVien.HideSelection = false;
            this.lsvSinhVien.Location = new System.Drawing.Point(30, 225);
            this.lsvSinhVien.Name = "lsvSinhVien";
            this.lsvSinhVien.Size = new System.Drawing.Size(520, 180);
            this.lsvSinhVien.TabIndex = 13;
            this.lsvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lsvSinhVien.View = System.Windows.Forms.View.Details;
            this.lsvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lsvSinhVien_SelectedIndexChanged);

            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 130;

            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã sinh viên";
            this.colMaSV.Width = 100;

            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 80;

            // 
            // colNgoaiNgu
            // 
            this.colNgoaiNgu.Text = "Ngoại ngữ";
            this.colNgoaiNgu.Width = 110;

            // 
            // colDanToc
            // 
            this.colDanToc.Text = "Dân tộc";
            this.colDanToc.Width = 90;

            // 
            // cmsListView
            // 
            this.cmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmXoa});
            this.cmsListView.Name = "cmsListView";
            this.cmsListView.Size = new System.Drawing.Size(95, 26);

            // 
            // tsmXoa
            // 
            this.tsmXoa.Name = "tsmXoa";
            this.tsmXoa.Size = new System.Drawing.Size(94, 22);
            this.tsmXoa.Text = "Xóa";
            this.tsmXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(120, 420);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(240, 420);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(360, 420);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // 
            // frmThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 475);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lsvSinhVien);
            this.Controls.Add(this.cboDanToc);
            this.Controls.Add(this.lblDanToc);
            this.Controls.Add(this.chkHoa);
            this.Controls.Add(this.chkPhap);
            this.Controls.Add(this.chkAnh);
            this.Controls.Add(this.lblNgoaiNgu);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongTinSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongTinSinhVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongTinSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.frmThongTinSinhVien_Load);
            this.cmsListView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.CheckBox chkAnh;
        private System.Windows.Forms.CheckBox chkPhap;
        private System.Windows.Forms.CheckBox chkHoa;
        private System.Windows.Forms.Label lblDanToc;
        private System.Windows.Forms.ComboBox cboDanToc;
        private System.Windows.Forms.ListView lsvSinhVien;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgoaiNgu;
        private System.Windows.Forms.ColumnHeader colDanToc;
        private System.Windows.Forms.ContextMenuStrip cmsListView;
        private System.Windows.Forms.ToolStripMenuItem tsmXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}