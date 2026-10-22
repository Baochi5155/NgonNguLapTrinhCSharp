namespace B1_2
{
    partial class frmListView
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
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.lblmssv = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.lstv1 = new System.Windows.Forms.ListView();
            this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();

            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(80, 20);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(80, 30);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);

            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(180, 20);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(80, 30);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);

            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(280, 20);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(80, 30);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);

            // 
            // lblmssv
            // 
            this.lblmssv.AutoSize = true;
            this.lblmssv.Location = new System.Drawing.Point(80, 65);
            this.lblmssv.Name = "lblmssv";
            this.lblmssv.Size = new System.Drawing.Size(46, 17);
            this.lblmssv.TabIndex = 3;
            this.lblmssv.Text = "Mã SV";

            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(80, 100);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(48, 17);
            this.lblhoten.TabIndex = 4;
            this.lblhoten.Text = "Họ tên";

            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(140, 62);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(280, 24);
            this.txtmssv.TabIndex = 5;

            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(140, 97);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(280, 24);
            this.txthoten.TabIndex = 6;

            // 
            // lstv1
            // 
            this.lstv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMSSV,
            this.colHoTen});
            this.lstv1.FullRowSelect = true;
            this.lstv1.GridLines = true;
            this.lstv1.HideSelection = false;
            this.lstv1.Location = new System.Drawing.Point(30, 140);
            this.lstv1.Name = "lstv1";
            this.lstv1.Size = new System.Drawing.Size(440, 220);
            this.lstv1.TabIndex = 7;
            this.lstv1.UseCompatibleStateImageBehavior = false;
            this.lstv1.View = System.Windows.Forms.View.Details;
            this.lstv1.SelectedIndexChanged += new System.EventHandler(this.lstv1_SelectedIndexChanged);

            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MÃ SỐ SV";
            this.colMSSV.Width = 150;

            // 
            // colHoTen
            // 
            this.colHoTen.Text = "HỌ VÀ TÊN";
            this.colHoTen.Width = 260;

            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.lstv1);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.lblhoten);
            this.Controls.Add(this.lblmssv);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label lblmssv;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.ListView lstv1;
        private System.Windows.Forms.ColumnHeader colMSSV;
        private System.Windows.Forms.ColumnHeader colHoTen;
    }
}