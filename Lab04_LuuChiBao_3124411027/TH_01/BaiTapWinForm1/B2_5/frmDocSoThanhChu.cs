using System;
using System.Windows.Forms;

namespace B2_5
{
    public partial class frmDocSoThanhChu : Form
    {
        public frmDocSoThanhChu()
        {
            InitializeComponent();
        }

        // Chặn không cho nhập ký tự khác số vào ô nhập
        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // 1. Nút "Thực hiện": Kiểm tra dữ liệu và đọc thành chữ
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                errorProvider1.SetError(txtNhap, "Vui lòng nhập số!");
                txtNhap.Focus();
                return;
            }

            if (!int.TryParse(txtNhap.Text.Trim(), out int n) || n < 1 || n > 999)
            {
                errorProvider1.SetError(txtNhap, "Chỉ được nhập số nguyên dương từ 1 đến 999!");
                MessageBox.Show("Số vừa nhập không hợp lệ! Vui lòng nhập số nguyên từ 1 đến 999.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKetQua.Clear();
                txtNhap.Focus();
                return;
            }

            // Gọi class đọc số và hiển thị ra ô kết quả
            txtKetQua.Text = DocSo.ChuyenSoThanhChu(n);
        }

        // 2. Nút "Xóa": Trả form về trạng thái ban đầu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtKetQua.Clear();
            errorProvider1.Clear();
            txtNhap.Focus();
        }

        // 3. Nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 4. Xác nhận trước khi đóng form
        private void frmDocSoThanhChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có thực sự muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}