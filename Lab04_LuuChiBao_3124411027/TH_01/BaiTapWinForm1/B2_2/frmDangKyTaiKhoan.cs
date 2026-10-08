using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace B2_2
{
    public partial class frmDangKyTaiKhoan : Form
    {
        public frmDangKyTaiKhoan()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra định dạng email chuẩn
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // 1. Kiểm tra định dạng của email sau khi nhập và rời khỏi textbox Địa chỉ email (sự kiện Leave)
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(txtEmail, "Vui lòng nhập địa chỉ email!");
            }
            else if (!IsValidEmail(email))
            {
                errorProvider1.SetError(txtEmail, "Địa chỉ email không đúng định dạng (vd: user@example.com)!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

        // 2. Xử lý khi chọn button Đăng ký hoặc nhấn phím Enter
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            // Bắt buộc nhập dữ liệu trên các textbox có (*)
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống!");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Địa chỉ email không được để trống!");
                hopLe = false;
            }
            else if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Địa chỉ email không đúng định dạng!");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu không được để trống!");
                hopLe = false;
            }

            // Kiểm tra khớp xác nhận mật khẩu (nếu có nhập)
            if (!string.IsNullOrEmpty(txtXacNhanMatKhau.Text) && txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMatKhau, "Mật khẩu xác nhận không trùng khớp!");
                hopLe = false;
            }

            if (!hopLe)
            {
                MessageBox.Show("Vui lòng hoàn thiện đúng và đầy đủ các trường thông tin có dấu (*)", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị thông tin của tất cả các textbox lên MessageBox
            string thongTin = "ĐĂNG KÝ TÀI KHOẢN THÀNH CÔNG!\n\n" +
                              $"- Tên đăng nhập: {txtTenDangNhap.Text.Trim()}\n" +
                              $"- Địa chỉ email: {txtEmail.Text.Trim()}\n" +
                              $"- Mật khẩu: {txtMatKhau.Text}\n" +
                              $"- Xác nhận mật khẩu: {txtXacNhanMatKhau.Text}";

            MessageBox.Show(thongTin, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. Hỏi xác nhận trước khi đóng Form
        private void frmDangKyTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có thực sự muốn thoát không?",
                "Xác nhận thoát",
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