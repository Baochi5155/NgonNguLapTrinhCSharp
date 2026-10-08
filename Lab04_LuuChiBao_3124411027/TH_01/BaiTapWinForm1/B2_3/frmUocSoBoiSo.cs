using System;
using System.Windows.Forms;

namespace B2_3
{
    public partial class frmUocSoBoiSo : Form
    {
        public frmUocSoBoiSo()
        {
            InitializeComponent();
        }

        // Chặn nhập các ký tự không phải số nguyên
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Cho phép Backspace và chữ số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Dấu trừ chỉ được phép ở đầu tiên
            if (e.KeyChar == '-' && txt != null && (txt.SelectionStart != 0 || txt.Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        // 1. Nút Thực Hiện
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            // Kiểm tra số a
            if (!long.TryParse(txtA.Text.Trim(), out long a))
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập số nguyên hợp lệ!");
                hopLe = false;
            }

            // Kiểm tra số b
            if (!long.TryParse(txtB.Text.Trim(), out long b))
            {
                errorProvider1.SetError(txtB, "Vui lòng nhập số nguyên hợp lệ!");
                hopLe = false;
            }

            if (!hopLe)
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng hoặc bị để trống. Vui lòng kiểm tra lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUCLN.Clear();
                txtBCNN.Clear();
                return;
            }

            if (a == 0 && b == 0)
            {
                MessageBox.Show("Cả 2 số không thể cùng bằng 0!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính toán và hiển thị
            UocSoBoiSo tinh = new UocSoBoiSo(a, b);
            txtUCLN.Text = tinh.TimUCLN().ToString();
            txtBCNN.Text = tinh.TimBCNN().ToString();
        }

        // 2. Nút Tiếp Tục: Xóa dữ liệu và đưa con trỏ về ô a
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();
            errorProvider1.Clear();
            txtA.Focus();
        }

        // 3. Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 4. Hỏi xác nhận trước khi đóng Form
        private void frmUocSoBoiSo_FormClosing(object sender, FormClosingEventArgs e)
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