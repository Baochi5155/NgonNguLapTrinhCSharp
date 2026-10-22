namespace B3_1 // Thay tên namespace trùng với tên Project của bạn
{
    partial class frmChuoi
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
            this.btnNgauNhien = new System.Windows.Forms.Button();
            this.lstChuoi = new System.Windows.Forms.ListBox();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaTenSon = new System.Windows.Forms.Button();
            this.btnXoaHoLe = new System.Windows.Forms.Button();
            this.btnHoa = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.btnHoaDau = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnNgauNhien
            // 
            this.btnNgauNhien.Location = new System.Drawing.Point(30, 20);
            this.btnNgauNhien.Name = "btnNgauNhien";
            this.btnNgauNhien.Size = new System.Drawing.Size(200, 32);
            this.btnNgauNhien.TabIndex = 0;
            this.btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
            this.btnNgauNhien.UseVisualStyleBackColor = true;
            this.btnNgauNhien.Click += new System.EventHandler(this.btnNgauNhien_Click);

            // 
            // lstChuoi
            // 
            this.lstChuoi.FormattingEnabled = true;
            this.lstChuoi.ItemHeight = 16;
            this.lstChuoi.Location = new System.Drawing.Point(30, 65);
            this.lstChuoi.Name = "lstChuoi";
            this.lstChuoi.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstChuoi.Size = new System.Drawing.Size(220, 308);
            this.lstChuoi.TabIndex = 1;
            this.lstChuoi.DoubleClick += new System.EventHandler(this.lstChuoi_DoubleClick);

            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(270, 65);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(260, 32);
            this.btnXoaChon.TabIndex = 2;
            this.btnXoaChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);

            // 
            // btnXoaTenSon
            // 
            this.btnXoaTenSon.Location = new System.Drawing.Point(270, 110);
            this.btnXoaTenSon.Name = "btnXoaTenSon";
            this.btnXoaTenSon.Size = new System.Drawing.Size(260, 32);
            this.btnXoaTenSon.TabIndex = 3;
            this.btnXoaTenSon.Text = "Xóa phần tử có tên là Sơn";
            this.btnXoaTenSon.UseVisualStyleBackColor = true;
            this.btnXoaTenSon.Click += new System.EventHandler(this.btnXoaTenSon_Click);

            // 
            // btnXoaHoLe
            // 
            this.btnXoaHoLe.Location = new System.Drawing.Point(270, 155);
            this.btnXoaHoLe.Name = "btnXoaHoLe";
            this.btnXoaHoLe.Size = new System.Drawing.Size(260, 32);
            this.btnXoaHoLe.TabIndex = 4;
            this.btnXoaHoLe.Text = "Xóa Phần tử có họ là Lê";
            this.btnXoaHoLe.UseVisualStyleBackColor = true;
            this.btnXoaHoLe.Click += new System.EventHandler(this.btnXoaHoLe_Click);

            // 
            // btnHoa
            // 
            this.btnHoa.Location = new System.Drawing.Point(270, 200);
            this.btnHoa.Name = "btnHoa";
            this.btnHoa.Size = new System.Drawing.Size(260, 32);
            this.btnHoa.TabIndex = 5;
            this.btnHoa.Text = "Chuyển PT đang chọn thành chữ HOA";
            this.btnHoa.UseVisualStyleBackColor = true;
            this.btnHoa.Click += new System.EventHandler(this.btnHoa_Click);

            // 
            // btnThuong
            // 
            this.btnThuong.Location = new System.Drawing.Point(270, 245);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(260, 32);
            this.btnThuong.TabIndex = 6;
            this.btnThuong.Text = "Chuyển PT đang chọn thành chữ thường";
            this.btnThuong.UseVisualStyleBackColor = true;
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);

            // 
            // btnHoaDau
            // 
            this.btnHoaDau.Location = new System.Drawing.Point(270, 290);
            this.btnHoaDau.Name = "btnHoaDau";
            this.btnHoaDau.Size = new System.Drawing.Size(260, 32);
            this.btnHoaDau.TabIndex = 7;
            this.btnHoaDau.Text = "Chuyển PT đang chọn thành viết Hoa đầu mỗi từ";
            this.btnHoaDau.UseVisualStyleBackColor = true;
            this.btnHoaDau.Click += new System.EventHandler(this.btnHoaDau_Click);

            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(270, 335);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(260, 32);
            this.btnXoaTatCa.TabIndex = 8;
            this.btnXoaTatCa.Text = "Xóa tất cả các Phần tử";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);

            // 
            // frmChuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 395);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnHoaDau);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.btnHoa);
            this.Controls.Add(this.btnXoaHoLe);
            this.Controls.Add(this.btnXoaTenSon);
            this.Controls.Add(this.btnXoaChon);
            this.Controls.Add(this.lstChuoi);
            this.Controls.Add(this.btnNgauNhien);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChuoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuoi";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnNgauNhien;
        private System.Windows.Forms.ListBox lstChuoi;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnXoaTenSon;
        private System.Windows.Forms.Button btnXoaHoLe;
        private System.Windows.Forms.Button btnHoa;
        private System.Windows.Forms.Button btnThuong;
        private System.Windows.Forms.Button btnHoaDau;
        private System.Windows.Forms.Button btnXoaTatCa;
    }
}