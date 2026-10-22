namespace B4_1
{
    partial class frmTuDien
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
            this.tabTuDien = new System.Windows.Forms.TabControl();
            this.tabAnhViet = new System.Windows.Forms.TabPage();
            this.txtNghiaViet = new System.Windows.Forms.TextBox();
            this.lblTiengViet = new System.Windows.Forms.Label();
            this.lstAnh = new System.Windows.Forms.ListBox();
            this.cboAnh = new System.Windows.Forms.ComboBox();
            this.lblTiengAnh = new System.Windows.Forms.Label();
            this.tabVietAnh = new System.Windows.Forms.TabPage();
            this.txtNghiaAnh = new System.Windows.Forms.TextBox();
            this.lblTiengAnh2 = new System.Windows.Forms.Label();
            this.lstViet = new System.Windows.Forms.ListBox();
            this.cboViet = new System.Windows.Forms.ComboBox();
            this.lblTiengViet2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabTuDien.SuspendLayout();
            this.tabAnhViet.SuspendLayout();
            this.tabVietAnh.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabTuDien
            // 
            this.tabTuDien.Controls.Add(this.tabAnhViet);
            this.tabTuDien.Controls.Add(this.tabVietAnh);
            this.tabTuDien.Location = new System.Drawing.Point(20, 20);
            this.tabTuDien.Name = "tabTuDien";
            this.tabTuDien.SelectedIndex = 0;
            this.tabTuDien.Size = new System.Drawing.Size(540, 380);
            this.tabTuDien.TabIndex = 0;

            // 
            // tabAnhViet
            // 
            this.tabAnhViet.Controls.Add(this.txtNghiaViet);
            this.tabAnhViet.Controls.Add(this.lblTiengViet);
            this.tabAnhViet.Controls.Add(this.lstAnh);
            this.tabAnhViet.Controls.Add(this.cboAnh);
            this.tabAnhViet.Controls.Add(this.lblTiengAnh);
            this.tabAnhViet.Location = new System.Drawing.Point(4, 25);
            this.tabAnhViet.Name = "tabAnhViet";
            this.tabAnhViet.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnhViet.Size = new System.Drawing.Size(532, 351);
            this.tabAnhViet.TabIndex = 0;
            this.tabAnhViet.Text = "ANH - VIỆT";

            // 
            // lblTiengAnh
            // 
            this.lblTiengAnh.AutoSize = true;
            this.lblTiengAnh.Location = new System.Drawing.Point(20, 20);
            this.lblTiengAnh.Name = "lblTiengAnh";
            this.lblTiengAnh.Size = new System.Drawing.Size(68, 17);
            this.lblTiengAnh.Text = "Tiếng Anh";

            // 
            // cboAnh
            // 
            this.cboAnh.FormattingEnabled = true;
            this.cboAnh.Location = new System.Drawing.Point(20, 45);
            this.cboAnh.Name = "cboAnh";
            this.cboAnh.Size = new System.Drawing.Size(200, 25);
            this.cboAnh.TabIndex = 0;
            this.cboAnh.TextChanged += new System.EventHandler(this.cboAnh_TextChanged);
            this.cboAnh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboAnh_KeyDown);

            // 
            // lstAnh
            // 
            this.lstAnh.FormattingEnabled = true;
            this.lstAnh.ItemHeight = 17;
            this.lstAnh.Location = new System.Drawing.Point(20, 80);
            this.lstAnh.Name = "lstAnh";
            this.lstAnh.Size = new System.Drawing.Size(200, 242);
            this.lstAnh.TabIndex = 1;
            this.lstAnh.DoubleClick += new System.EventHandler(this.lstAnh_DoubleClick);

            // 
            // lblTiengViet
            // 
            this.lblTiengViet.AutoSize = true;
            this.lblTiengViet.Location = new System.Drawing.Point(250, 20);
            this.lblTiengViet.Name = "lblTiengViet";
            this.lblTiengViet.Size = new System.Drawing.Size(69, 17);
            this.lblTiengViet.Text = "Tiếng Việt";

            // 
            // txtNghiaViet
            // 
            this.txtNghiaViet.Location = new System.Drawing.Point(250, 45);
            this.txtNghiaViet.Multiline = true;
            this.txtNghiaViet.Name = "txtNghiaViet";
            this.txtNghiaViet.ReadOnly = true;
            this.txtNghiaViet.Size = new System.Drawing.Size(255, 277);
            this.txtNghiaViet.TabIndex = 2;

            // 
            // tabVietAnh
            // 
            this.tabVietAnh.Controls.Add(this.txtNghiaAnh);
            this.tabVietAnh.Controls.Add(this.lblTiengAnh2);
            this.tabVietAnh.Controls.Add(this.lstViet);
            this.tabVietAnh.Controls.Add(this.cboViet);
            this.tabVietAnh.Controls.Add(this.lblTiengViet2);
            this.tabVietAnh.Location = new System.Drawing.Point(4, 25);
            this.tabVietAnh.Name = "tabVietAnh";
            this.tabVietAnh.Padding = new System.Windows.Forms.Padding(3);
            this.tabVietAnh.Size = new System.Drawing.Size(532, 351);
            this.tabVietAnh.TabIndex = 1;
            this.tabVietAnh.Text = "VIỆT - ANH";

            // 
            // lblTiengViet2
            // 
            this.lblTiengViet2.AutoSize = true;
            this.lblTiengViet2.Location = new System.Drawing.Point(20, 20);
            this.lblTiengViet2.Name = "lblTiengViet2";
            this.lblTiengViet2.Size = new System.Drawing.Size(69, 17);
            this.lblTiengViet2.Text = "Tiếng Việt";

            // 
            // cboViet
            // 
            this.cboViet.FormattingEnabled = true;
            this.cboViet.Location = new System.Drawing.Point(20, 45);
            this.cboViet.Name = "cboViet";
            this.cboViet.Size = new System.Drawing.Size(200, 25);
            this.cboViet.TabIndex = 0;
            this.cboViet.TextChanged += new System.EventHandler(this.cboViet_TextChanged);
            this.cboViet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboViet_KeyDown);

            // 
            // lstViet
            // 
            this.lstViet.FormattingEnabled = true;
            this.lstViet.ItemHeight = 17;
            this.lstViet.Location = new System.Drawing.Point(20, 80);
            this.lstViet.Name = "lstViet";
            this.lstViet.Size = new System.Drawing.Size(200, 242);
            this.lstViet.TabIndex = 1;
            this.lstViet.DoubleClick += new System.EventHandler(this.lstViet_DoubleClick);

            // 
            // lblTiengAnh2
            // 
            this.lblTiengAnh2.AutoSize = true;
            this.lblTiengAnh2.Location = new System.Drawing.Point(250, 20);
            this.lblTiengAnh2.Name = "lblTiengAnh2";
            this.lblTiengAnh2.Size = new System.Drawing.Size(68, 17);
            this.lblTiengAnh2.Text = "Tiếng Anh";

            // 
            // txtNghiaAnh
            // 
            this.txtNghiaAnh.Location = new System.Drawing.Point(250, 45);
            this.txtNghiaAnh.Multiline = true;
            this.txtNghiaAnh.Name = "txtNghiaAnh";
            this.txtNghiaAnh.ReadOnly = true;
            this.txtNghiaAnh.Size = new System.Drawing.Size(255, 277);
            this.txtNghiaAnh.TabIndex = 2;

            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(430, 410);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 32);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 
            // frmTuDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 455);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabTuDien);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTuDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTuDien_FormClosing);
            this.Load += new System.EventHandler(this.frmTuDien_Load);
            this.tabTuDien.ResumeLayout(false);
            this.tabAnhViet.ResumeLayout(false);
            this.tabAnhViet.PerformLayout();
            this.tabVietAnh.ResumeLayout(false);
            this.tabVietAnh.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabTuDien;
        private System.Windows.Forms.TabPage tabAnhViet;
        private System.Windows.Forms.TabPage tabVietAnh;
        private System.Windows.Forms.Label lblTiengAnh;
        private System.Windows.Forms.ComboBox cboAnh;
        private System.Windows.Forms.ListBox lstAnh;
        private System.Windows.Forms.Label lblTiengViet;
        private System.Windows.Forms.TextBox txtNghiaViet;
        private System.Windows.Forms.Label lblTiengViet2;
        private System.Windows.Forms.ComboBox cboViet;
        private System.Windows.Forms.ListBox lstViet;
        private System.Windows.Forms.Label lblTiengAnh2;
        private System.Windows.Forms.TextBox txtNghiaAnh;
        private System.Windows.Forms.Button btnThoat;
    }
}