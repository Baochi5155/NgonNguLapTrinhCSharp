namespace B1_1
{
    partial class Cbo_Dantoc
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
            this.btn_loadDL = new System.Windows.Forms.Button();
            this.lbl_DanToc = new System.Windows.Forms.Label();
            this.cbo_dt = new System.Windows.Forms.ComboBox();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.lbl_kq = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // btn_loadDL
            // 
            this.btn_loadDL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadDL.Location = new System.Drawing.Point(85, 25);
            this.btn_loadDL.Name = "btn_loadDL";
            this.btn_loadDL.Size = new System.Drawing.Size(180, 32);
            this.btn_loadDL.TabIndex = 0;
            this.btn_loadDL.Text = "Load dữ liệu Combobox";
            this.btn_loadDL.UseVisualStyleBackColor = true;
            this.btn_loadDL.Click += new System.EventHandler(this.btn_loadDL_Click);

            // 
            // lbl_DanToc
            // 
            this.lbl_DanToc.AutoSize = true;
            this.lbl_DanToc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanToc.Location = new System.Drawing.Point(40, 80);
            this.lbl_DanToc.Name = "lbl_DanToc";
            this.lbl_DanToc.Size = new System.Drawing.Size(58, 16);
            this.lbl_DanToc.TabIndex = 1;
            this.lbl_DanToc.Text = "Dân tộc"; 

            // 
            // cbo_dt
            // 
            this.cbo_dt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_dt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_dt.FormattingEnabled = true;
            this.cbo_dt.Location = new System.Drawing.Point(120, 77);
            this.cbo_dt.Name = "cbo_dt";
            this.cbo_dt.Size = new System.Drawing.Size(180, 24);
            this.cbo_dt.TabIndex = 2;
            this.cbo_dt.SelectedIndexChanged += new System.EventHandler(this.cbo_dt_SelectedIndexChanged);

            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthi.Location = new System.Drawing.Point(135, 120);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(100, 32);
            this.btn_hienthi.TabIndex = 3;
            this.btn_hienthi.Text = "Hiển thị";     
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);  

            // 
            // lbl_kq   
            // 
            this.lbl_kq.AutoSize = true;
            this.lbl_kq.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kq.ForeColor = System.Drawing.Color.Red; // Chữ màu đỏ theo hình minh họa  
            this.lbl_kq.Location = new System.Drawing.Point(85, 170);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new System.Drawing.Size(0, 17);
            this.lbl_kq.TabIndex = 4;

            // 
            // Cbo_Dantoc   
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 210);
            this.Controls.Add(this.lbl_kq);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.cbo_dt);
            this.Controls.Add(this.lbl_DanToc);
            this.Controls.Add(this.btn_loadDL);
            this.Name = "Cbo_Dantoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cbo_Dantoc";   
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_loadDL;
        private System.Windows.Forms.Label lbl_DanToc;
        private System.Windows.Forms.ComboBox cbo_dt;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Label lbl_kq;
    }
}