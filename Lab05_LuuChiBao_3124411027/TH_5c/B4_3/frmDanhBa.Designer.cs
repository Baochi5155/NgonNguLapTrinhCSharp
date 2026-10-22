namespace B4_3
{
    partial class frmDanhBa
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
            this.trvDanhBa = new System.Windows.Forms.TreeView();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();

            // 
            // trvDanhBa
            // 
            this.trvDanhBa.Location = new System.Drawing.Point(15, 15);
            this.trvDanhBa.Name = "trvDanhBa";
            this.trvDanhBa.Size = new System.Drawing.Size(210, 310);
            this.trvDanhBa.TabIndex = 0;

            // 
            // pnlInput
            // 
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.btnAdd);
            this.pnlInput.Controls.Add(this.txtLastName);
            this.pnlInput.Controls.Add(this.lblLastName);
            this.pnlInput.Controls.Add(this.txtFirstName);
            this.pnlInput.Controls.Add(this.lblFirstName);
            this.pnlInput.Location = new System.Drawing.Point(240, 15);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(260, 150);
            this.pnlInput.TabIndex = 1;

            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";

            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(95, 22);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 23);
            this.txtFirstName.TabIndex = 1;

            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 65);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(68, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";

            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(95, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 23);
            this.txtLastName.TabIndex = 3;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(155, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(395, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // frmDanhBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 340);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.trvDanhBa);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDanhBa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBTVN2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhBa_FormClosing);
            this.Load += new System.EventHandler(this.frmDanhBa_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TreeView trvDanhBa;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}