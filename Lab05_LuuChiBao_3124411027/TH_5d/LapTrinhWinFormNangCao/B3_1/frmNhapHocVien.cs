using System;
using System.Drawing;
using System.Windows.Forms;

namespace B3_1
{
    public partial class frmNhapHocVien : Form
    {
        private frmQuanLyHocVien mainForm;

        public frmNhapHocVien(frmQuanLyHocVien form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void frmNhapHocVien_Load(object sender, EventArgs e)
        {
            cboLop.Items.Add("Lớp A");
            cboLop.Items.Add("Lớp B");
            cboLop.SelectedIndex = 0;
        }

        // Click button Cập nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();

            // Nếu Họ và Tên rỗng
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên học viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // Cập nhật họ tên vào listbox tương ứng trên form chính
            string lop = cboLop.SelectedItem.ToString();
            mainForm.ThemHocVien(hoTen, lop);

            txtHoTen.Clear();
            txtHoTen.Focus();
        }

        // Click button Trở về
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}