namespace B1_1
{
    partial class frmListBox
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
            this.lst_Trai = new System.Windows.Forms.ListBox();
            this.lst_Phai = new System.Windows.Forms.ListBox();
            this.btnQuaPhai = new System.Windows.Forms.Button();
            this.btnQuaPhaiAll = new System.Windows.Forms.Button();
            this.btnQuaTrai = new System.Windows.Forms.Button();
            this.btnQuaTraiAll = new System.Windows.Forms.Button();
            this.btnChuyenTuyY = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lst_Trai
            this.lst_Trai.FormattingEnabled = true;
            this.lst_Trai.ItemHeight = 18;
            this.lst_Trai.Location = new System.Drawing.Point(30, 30);
            this.lst_Trai.Name = "lst_Trai";
            this.lst_Trai.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Trai.Size = new System.Drawing.Size(150, 220);
            this.lst_Trai.TabIndex = 0;

            // lst_Phai
            this.lst_Phai.FormattingEnabled = true;
            this.lst_Phai.ItemHeight = 18;
            this.lst_Phai.Location = new System.Drawing.Point(260, 30);
            this.lst_Phai.Name = "lst_Phai";
            this.lst_Phai.Size = new System.Drawing.Size(150, 220);
            this.lst_Phai.TabIndex = 1;

            // btnQuaPhai
            this.btnQuaPhai.Location = new System.Drawing.Point(195, 40);
            this.btnQuaPhai.Name = "btnQuaPhai";
            this.btnQuaPhai.Size = new System.Drawing.Size(50, 30);
            this.btnQuaPhai.TabIndex = 2;
            this.btnQuaPhai.Text = ">";
            this.btnQuaPhai.UseVisualStyleBackColor = true;
            this.btnQuaPhai.Click += new System.EventHandler(this.btnQuaPhai_Click);

            // btnQuaPhaiAll
            this.btnQuaPhaiAll.Location = new System.Drawing.Point(195, 80);
            this.btnQuaPhaiAll.Name = "btnQuaPhaiAll";
            this.btnQuaPhaiAll.Size = new System.Drawing.Size(50, 30);
            this.btnQuaPhaiAll.TabIndex = 3;
            this.btnQuaPhaiAll.Text = ">>";
            this.btnQuaPhaiAll.UseVisualStyleBackColor = true;
            this.btnQuaPhaiAll.Click += new System.EventHandler(this.btnQuaPhaiAll_Click);

            // btnQuaTrai
            this.btnQuaTrai.Location = new System.Drawing.Point(195, 120);
            this.btnQuaTrai.Name = "btnQuaTrai";
            this.btnQuaTrai.Size = new System.Drawing.Size(50, 30);
            this.btnQuaTrai.TabIndex = 4;
            this.btnQuaTrai.Text = "<";
            this.btnQuaTrai.UseVisualStyleBackColor = true;
            this.btnQuaTrai.Click += new System.EventHandler(this.btnQuaTrai_Click);

            // btnQuaTraiAll
            this.btnQuaTraiAll.Location = new System.Drawing.Point(195, 160);
            this.btnQuaTraiAll.Name = "btnQuaTraiAll";
            this.btnQuaTraiAll.Size = new System.Drawing.Size(50, 30);
            this.btnQuaTraiAll.TabIndex = 5;
            this.btnQuaTraiAll.Text = "<<";
            this.btnQuaTraiAll.UseVisualStyleBackColor = true;
            this.btnQuaTraiAll.Click += new System.EventHandler(this.btnQuaTraiAll_Click);

            // btnChuyenTuyY
            this.btnChuyenTuyY.Location = new System.Drawing.Point(30, 260);
            this.btnChuyenTuyY.Name = "btnChuyenTuyY";
            this.btnChuyenTuyY.Size = new System.Drawing.Size(150, 30);
            this.btnChuyenTuyY.TabIndex = 6;
            this.btnChuyenTuyY.Text = "Chuyển tùy ý";
            this.btnChuyenTuyY.UseVisualStyleBackColor = true;
            this.btnChuyenTuyY.Click += new System.EventHandler(this.btnChuyenTuyY_Click);

            // frmListBox
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 310);
            this.Controls.Add(this.btnChuyenTuyY);
            this.Controls.Add(this.btnQuaTraiAll);
            this.Controls.Add(this.btnQuaTrai);
            this.Controls.Add(this.btnQuaPhaiAll);
            this.Controls.Add(this.btnQuaPhai);
            this.Controls.Add(this.lst_Phai);
            this.Controls.Add(this.lst_Trai);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Font Tahoma 11pt
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng listbox"; // Tiêu đề Form
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListBox_FormClosing); // Sự kiện FormClosing
            this.Load += new System.EventHandler(this.frmListBox_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lst_Trai;
        private System.Windows.Forms.ListBox lst_Phai;
        private System.Windows.Forms.Button btnQuaPhai;
        private System.Windows.Forms.Button btnQuaPhaiAll;
        private System.Windows.Forms.Button btnQuaTrai;
        private System.Windows.Forms.Button btnQuaTraiAll;
        private System.Windows.Forms.Button btnChuyenTuyY;
    }
}