namespace B3
{
    partial class B3_2
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
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.btnLocDuLieu = new System.Windows.Forms.Button();
            this.lvwDanhSachDiem = new System.Windows.Forms.ListView();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colTenSV = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colTenMH = new System.Windows.Forms.ColumnHeader();
            this.colDiem = new System.Windows.Forms.ColumnHeader();
            this.lblTongDiem = new System.Windows.Forms.Label();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(30, 20);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(55, 15);
            this.lblMonHoc.TabIndex = 0;
            this.lblMonHoc.Text = "Môn học";

            // 
            // cboMonHoc
            // 
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(100, 17);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(260, 23);
            this.cboMonHoc.TabIndex = 1;

            // 
            // btnLocDuLieu
            // 
            this.btnLocDuLieu.Location = new System.Drawing.Point(380, 15);
            this.btnLocDuLieu.Name = "btnLocDuLieu";
            this.btnLocDuLieu.Size = new System.Drawing.Size(90, 27);
            this.btnLocDuLieu.TabIndex = 2;
            this.btnLocDuLieu.Text = "Lọc dữ liệu";
            this.btnLocDuLieu.UseVisualStyleBackColor = true;
            this.btnLocDuLieu.Click += new System.EventHandler(this.btnLocDuLieu_Click);

            // 
            // lvwDanhSachDiem
            // 
            this.lvwDanhSachDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenSV,
            this.colNgaySinh,
            this.colTenMH,
            this.colDiem});
            this.lvwDanhSachDiem.FullRowSelect = true;
            this.lvwDanhSachDiem.GridLines = true;
            this.lvwDanhSachDiem.HideSelection = false;
            this.lvwDanhSachDiem.Location = new System.Drawing.Point(30, 55);
            this.lvwDanhSachDiem.Name = "lvwDanhSachDiem";
            this.lvwDanhSachDiem.Size = new System.Drawing.Size(520, 240);
            this.lvwDanhSachDiem.TabIndex = 3;
            this.lvwDanhSachDiem.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachDiem.View = System.Windows.Forms.View.Details;

            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 45;

            // 
            // colTenSV
            // 
            this.colTenSV.Text = "Tên SV";
            this.colTenSV.Width = 135;

            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 145;

            // 
            // colTenMH
            // 
            this.colTenMH.Text = "Tên môn học";
            this.colTenMH.Width = 135;

            // 
            // colDiem
            // 
            this.colDiem.Text = "Điểm";
            this.colDiem.Width = 50;

            // 
            // lblTongDiem
            // 
            this.lblTongDiem.AutoSize = true;
            this.lblTongDiem.Location = new System.Drawing.Point(280, 313);
            this.lblTongDiem.Name = "lblTongDiem";
            this.lblTongDiem.Size = new System.Drawing.Size(63, 15);
            this.lblTongDiem.TabIndex = 4;
            this.lblTongDiem.Text = "Tổng điểm";

            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(355, 310);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.ReadOnly = true;
            this.txtTongDiem.Size = new System.Drawing.Size(90, 23);
            this.txtTongDiem.TabIndex = 5;

            // 
            // B3_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 350);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.lblTongDiem);
            this.Controls.Add(this.lvwDanhSachDiem);
            this.Controls.Add(this.btnLocDuLieu);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.lblMonHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "B3_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.B3_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Button btnLocDuLieu;
        private System.Windows.Forms.ListView lvwDanhSachDiem;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colTenMH;
        private System.Windows.Forms.ColumnHeader colDiem;
        private System.Windows.Forms.Label lblTongDiem;
        private System.Windows.Forms.TextBox txtTongDiem;
    }
}