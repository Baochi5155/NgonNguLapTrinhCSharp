using System;
using System.Windows.Forms;

namespace B4_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Đặt làm Form cha MDI
        }

        // Hàm Generic mở Form con dạng MDI Child (tránh mở trùng lặp)
        private void OpenChildForm<T>() where T : Form, new()
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is T)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.Activate();
                    return;
                }
            }

            T childForm = new T
            {
                MdiParent = this
            };
            childForm.Show();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmQuanLySinhVien>();
        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmQuanLyMonHoc>();
        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi ứng dụng chính?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}