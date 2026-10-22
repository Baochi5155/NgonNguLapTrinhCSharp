namespace B4_1
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTaoTonKho = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrangChu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";

            // 
            // mnuTrangChu
            // 
            this.mnuTrangChu.Name = "mnuTrangChu";
            this.mnuTrangChu.Size = new System.Drawing.Size(87, 20);
            this.mnuTrangChu.Text = "🏠 Trang chủ";
            this.mnuTrangChu.Click += new System.EventHandler(this.mnuTrangChu_Click);

            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCenter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCenter.Controls.Add(this.lblTitle);
            this.pnlCenter.Controls.Add(this.btnTaoTonKho);
            this.pnlCenter.Controls.Add(this.btnThemSP);
            this.pnlCenter.Controls.Add(this.btnBanHang);
            this.pnlCenter.Location = new System.Drawing.Point(250, 80);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(300, 320);
            this.pnlCenter.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ CỬA HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnTaoTonKho
            // 
            this.btnTaoTonKho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTaoTonKho.Location = new System.Drawing.Point(30, 70);
            this.btnTaoTonKho.Name = "btnTaoTonKho";
            this.btnTaoTonKho.Size = new System.Drawing.Size(240, 60);
            this.btnTaoTonKho.TabIndex = 1;
            this.btnTaoTonKho.Text = "📦 Tạo Tồn Kho";
            this.btnTaoTonKho.UseVisualStyleBackColor = true;
            this.btnTaoTonKho.Click += new System.EventHandler(this.btnTaoTonKho_Click);

            // 
            // btnThemSP
            // 
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemSP.Location = new System.Drawing.Point(30, 150);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(240, 60);
            this.btnThemSP.TabIndex = 2;
            this.btnThemSP.Text = "➕ Thêm Sản Phẩm Mới";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);

            // 
            // btnBanHang
            // 
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBanHang.Location = new System.Drawing.Point(30, 230);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(240, 60);
            this.btnBanHang.TabIndex = 3;
            this.btnBanHang.Text = "🛒 Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);

            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Cửa Hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTrangChu;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTaoTonKho;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnBanHang;
    }
}