namespace B4_1
{
    partial class frmDongHo
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
            this.lblTime = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(50, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(160, 35);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "30:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(85, 65);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(90, 32);
            this.btnBatDau.TabIndex = 1;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);

            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // 
            // frmDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 120);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.lblTime);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDongHo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồng hồ";
            this.Load += new System.EventHandler(this.frmDongHo_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Timer timer1;
    }
}