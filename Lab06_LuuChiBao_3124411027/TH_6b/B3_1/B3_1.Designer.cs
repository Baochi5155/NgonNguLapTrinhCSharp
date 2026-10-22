namespace B3
{
    partial class B3_1
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
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lvwDanhSachLop = new System.Windows.Forms.ListView();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colMaLop = new System.Windows.Forms.ColumnHeader();
            this.colTenLop = new System.Windows.Forms.ColumnHeader();
            this.colMaKhoa = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();

            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(20, 15);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(120, 30);
            this.btnHienThi.TabIndex = 0;
            this.btnHienThi.Text = "Hiển thị dữ liệu";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);

            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(390, 275);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 
            // lvwDanhSachLop
            // 
            this.lvwDanhSachLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colMaLop,
            this.colTenLop,
            this.colMaKhoa});
            this.lvwDanhSachLop.FullRowSelect = true;
            this.lvwDanhSachLop.GridLines = true;
            this.lvwDanhSachLop.HideSelection = false;
            this.lvwDanhSachLop.Location = new System.Drawing.Point(20, 55);
            this.lvwDanhSachLop.Name = "lvwDanhSachLop";
            this.lvwDanhSachLop.Size = new System.Drawing.Size(460, 210);
            this.lvwDanhSachLop.TabIndex = 1;
            this.lvwDanhSachLop.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachLop.View = System.Windows.Forms.View.Details;

            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 50;

            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã lớp";
            this.colMaLop.Width = 90;

            // 
            // colTenLop
            // 
            this.colTenLop.Text = "Tên lớp";
            this.colTenLop.Width = 220;

            // 
            // colMaKhoa
            // 
            this.colMaKhoa.Text = "Mã khoa";
            this.colMaKhoa.Width = 80;

            // 
            // B3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.lvwDanhSachLop);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHienThi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "B3_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Lớp";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvwDanhSachLop;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colMaLop;
        private System.Windows.Forms.ColumnHeader colTenLop;
        private System.Windows.Forms.ColumnHeader colMaKhoa;
    }
}