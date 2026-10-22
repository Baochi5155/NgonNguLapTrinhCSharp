namespace B3_1
{
    partial class frmQuanLyHocVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNhapHocVienMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChuyenSangLopB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChuyenSangLopA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoaHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLopA = new System.Windows.Forms.Label();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.lblLopB = new System.Windows.Forms.Label();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCapNhat,
            this.tsmiKetThuc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // 
            // tsmiCapNhat
            // 
            this.tsmiCapNhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNhapHocVienMoi,
            this.tsmiChuyenSangLopB,
            this.tsmiChuyenSangLopA,
            this.tsmiXoaHocVien});
            this.tsmiCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmiCapNhat.Name = "tsmiCapNhat";
            this.tsmiCapNhat.Size = new System.Drawing.Size(81, 23);
            this.tsmiCapNhat.Text = "Cập nhật";

            // 
            // tsmiNhapHocVienMoi
            // 
            this.tsmiNhapHocVienMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiNhapHocVienMoi.Name = "tsmiNhapHocVienMoi";
            this.tsmiNhapHocVienMoi.Size = new System.Drawing.Size(193, 24);
            this.tsmiNhapHocVienMoi.Text = "Nhập học viên mới";
            this.tsmiNhapHocVienMoi.Click += new System.EventHandler(this.tsmiNhapHocVienMoi_Click);

            // 
            // tsmiChuyenSangLopB
            // 
            this.tsmiChuyenSangLopB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiChuyenSangLopB.Name = "tsmiChuyenSangLopB";
            this.tsmiChuyenSangLopB.Size = new System.Drawing.Size(193, 24);
            this.tsmiChuyenSangLopB.Text = "Chuyển sang lớp B";
            this.tsmiChuyenSangLopB.Click += new System.EventHandler(this.tsmiChuyenSangLopB_Click);

            // 
            // tsmiChuyenSangLopA
            // 
            this.tsmiChuyenSangLopA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiChuyenSangLopA.Name = "tsmiChuyenSangLopA";
            this.tsmiChuyenSangLopA.Size = new System.Drawing.Size(193, 24);
            this.tsmiChuyenSangLopA.Text = "Chuyển sang lớp A";
            this.tsmiChuyenSangLopA.Click += new System.EventHandler(this.tsmiChuyenSangLopA_Click);

            // 
            // tsmiXoaHocVien
            // 
            this.tsmiXoaHocVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiXoaHocVien.Name = "tsmiXoaHocVien";
            this.tsmiXoaHocVien.Size = new System.Drawing.Size(193, 24);
            this.tsmiXoaHocVien.Text = "Xóa học viên";
            this.tsmiXoaHocVien.Click += new System.EventHandler(this.tsmiXoaHocVien_Click);

            // 
            // tsmiKetThuc
            // 
            this.tsmiKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmiKetThuc.Name = "tsmiKetThuc";
            this.tsmiKetThuc.Size = new System.Drawing.Size(76, 23);
            this.tsmiKetThuc.Text = "Kết thúc";
            this.tsmiKetThuc.Click += new System.EventHandler(this.tsmiKetThuc_Click);

            // 
            // lblLopA
            // 
            this.lblLopA.AutoSize = true;
            this.lblLopA.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLopA.Location = new System.Drawing.Point(50, 50);
            this.lblLopA.Name = "lblLopA";
            this.lblLopA.Size = new System.Drawing.Size(48, 17);
            this.lblLopA.TabIndex = 1;
            this.lblLopA.Text = "Lớp A";

            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 16;
            this.lstLopA.Location = new System.Drawing.Point(50, 75);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopA.Size = new System.Drawing.Size(160, 212);
            this.lstLopA.TabIndex = 2;

            // 
            // lblLopB
            // 
            this.lblLopB.AutoSize = true;
            this.lblLopB.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLopB.Location = new System.Drawing.Point(250, 50);
            this.lblLopB.Name = "lblLopB";
            this.lblLopB.Size = new System.Drawing.Size(48, 17);
            this.lblLopB.TabIndex = 3;
            this.lblLopB.Text = "Lớp B";

            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 16;
            this.lstLopB.Location = new System.Drawing.Point(250, 75);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopB.Size = new System.Drawing.Size(160, 212);
            this.lstLopB.TabIndex = 4;

            // 
            // frmQuanLyHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 320);
            this.Controls.Add(this.lstLopB);
            this.Controls.Add(this.lblLopB);
            this.Controls.Add(this.lstLopA);
            this.Controls.Add(this.lblLopA);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQuanLyHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyHocVien_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyHocVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCapNhat;
        private System.Windows.Forms.ToolStripMenuItem tsmiNhapHocVienMoi;
        private System.Windows.Forms.ToolStripMenuItem tsmiChuyenSangLopB;
        private System.Windows.Forms.ToolStripMenuItem tsmiChuyenSangLopA;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoaHocVien;
        private System.Windows.Forms.ToolStripMenuItem tsmiKetThuc;
        private System.Windows.Forms.Label lblLopA;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.Label lblLopB;
        private System.Windows.Forms.ListBox lstLopB;
    }
}