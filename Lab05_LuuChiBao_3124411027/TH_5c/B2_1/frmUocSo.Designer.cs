namespace B1_1
{
    partial class frmUocSo
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
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.lblDanhSachUocSo = new System.Windows.Forms.Label();
            this.lstUocSo = new System.Windows.Forms.ListBox();
            this.btnTongUocSo = new System.Windows.Forms.Button();
            this.btnSoLuongUocSoChan = new System.Windows.Forms.Button();
            this.btnSoLuongUocSoNguyenTo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Location = new System.Drawing.Point(30, 25);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(56, 17);
            this.lblNhapSo.Text = "Nhập Số";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(30, 50);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(110, 24);
            this.txtSo.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(150, 48);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 28);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập &nhật"; // HotKey: Alt + N
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cboSo
            // 
            this.cboSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(30, 90);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(200, 25);
            this.cboSo.TabIndex = 2;
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.cboSo_SelectedIndexChanged);
            // 
            // lblDanhSachUocSo
            // 
            this.lblDanhSachUocSo.AutoSize = true;
            this.lblDanhSachUocSo.Location = new System.Drawing.Point(260, 25);
            this.lblDanhSachUocSo.Name = "lblDanhSachUocSo";
            this.lblDanhSachUocSo.Size = new System.Drawing.Size(135, 17);
            this.lblDanhSachUocSo.Text = "Danh sách các ước số";
            // 
            // lstUocSo
            // 
            this.lstUocSo.FormattingEnabled = true;
            this.lstUocSo.ItemHeight = 17;
            this.lstUocSo.Location = new System.Drawing.Point(260, 50);
            this.lstUocSo.Name = "lstUocSo";
            this.lstUocSo.Size = new System.Drawing.Size(200, 106);
            this.lstUocSo.TabIndex = 3;
            // 
            // btnTongUocSo
            // 
            this.btnTongUocSo.Location = new System.Drawing.Point(260, 170);
            this.btnTongUocSo.Name = "btnTongUocSo";
            this.btnTongUocSo.Size = new System.Drawing.Size(200, 30);
            this.btnTongUocSo.TabIndex = 4;
            this.btnTongUocSo.Text = "&Tổng các ước số"; // HotKey: Alt + T
            this.btnTongUocSo.UseVisualStyleBackColor = true;
            this.btnTongUocSo.Click += new System.EventHandler(this.btnTongUocSo_Click);
            // 
            // btnSoLuongUocSoChan
            // 
            this.btnSoLuongUocSoChan.Location = new System.Drawing.Point(260, 210);
            this.btnSoLuongUocSoChan.Name = "btnSoLuongUocSoChan";
            this.btnSoLuongUocSoChan.Size = new System.Drawing.Size(200, 30);
            this.btnSoLuongUocSoChan.TabIndex = 5;
            this.btnSoLuongUocSoChan.Text = "&Số lượng các ước số chẵn"; // HotKey: Alt + S
            this.btnSoLuongUocSoChan.UseVisualStyleBackColor = true;
            this.btnSoLuongUocSoChan.Click += new System.EventHandler(this.btnSoLuongUocSoChan_Click);
            // 
            // btnSoLuongUocSoNguyenTo
            // 
            this.btnSoLuongUocSoNguyenTo.Location = new System.Drawing.Point(260, 250);
            this.btnSoLuongUocSoNguyenTo.Name = "btnSoLuongUocSoNguyenTo";
            this.btnSoLuongUocSoNguyenTo.Size = new System.Drawing.Size(200, 30);
            this.btnSoLuongUocSoNguyenTo.TabIndex = 6;
            this.btnSoLuongUocSoNguyenTo.Text = "Số lượng các ước số &nguyên tố"; // HotKey: Alt + N
            this.btnSoLuongUocSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoLuongUocSoNguyenTo.Click += new System.EventHandler(this.btnSoLuongUocSoNguyenTo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(150, 250);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Th&oát"; // HotKey: Alt + O
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmUocSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 300);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSoLuongUocSoNguyenTo);
            this.Controls.Add(this.btnSoLuongUocSoChan);
            this.Controls.Add(this.btnTongUocSo);
            this.Controls.Add(this.lstUocSo);
            this.Controls.Add(this.lblDanhSachUocSo);
            this.Controls.Add(this.cboSo);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblNhapSo);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUocSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combobox"; // Tiêu đề Form đúng theo giao diện mẫu
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUocSo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.Label lblDanhSachUocSo;
        private System.Windows.Forms.ListBox lstUocSo;
        private System.Windows.Forms.Button btnTongUocSo;
        private System.Windows.Forms.Button btnSoLuongUocSoChan;
        private System.Windows.Forms.Button btnSoLuongUocSoNguyenTo;
        private System.Windows.Forms.Button btnThoat;
    }
}