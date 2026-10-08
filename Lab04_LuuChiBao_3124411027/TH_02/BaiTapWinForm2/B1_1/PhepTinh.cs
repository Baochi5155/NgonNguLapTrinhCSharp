using System;
using System.Windows.Forms;

namespace B1_1
{
    public partial class PhepTinh : Form
    {
        public PhepTinh()
        {
            InitializeComponent();
        }

        // 1. Chặn nhập các giá trị khác số vào TextBox
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Cho phép phím điều khiển (Backspace), số, dấu '.' và dấu '-'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // Chỉ cho phép 1 dấu chấm thập phân
            if ((e.KeyChar == '.') && (txt != null && txt.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Dấu trừ chỉ được phép ở đầu tiên
            if ((e.KeyChar == '-') && (txt != null && (txt.SelectionStart != 0 || txt.Text.IndexOf('-') > -1)))
            {
                e.Handled = true;
            }
        }

        // 2. Xử lý nút Tính
        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool isValid = true;

            // Kiểm tra số a
            if (!float.TryParse(txt_a.Text.Trim(), out float a))
            {
                errorProvider1.SetError(txt_a, "Vui lòng nhập số hợp lệ cho a!");
                isValid = false;
            }

            // Kiểm tra số b
            if (!float.TryParse(txt_b.Text.Trim(), out float b))
            {
                errorProvider1.SetError(txt_b, "Vui lòng nhập số hợp lệ cho b!");
                isValid = false;
            }

            if (!isValid) return;

            // Khởi tạo đối tượng TinhToan
            TinhToan dt = new TinhToan(a, b);

            if (rdo_cong.Checked)
            {
                txt_kq.Text = dt.Cong().ToString();
            }
            else if (rdo_tru.Checked)
            {
                txt_kq.Text = dt.Tru().ToString();
            }
            else if (rdo_nhan.Checked)
            {
                txt_kq.Text = dt.Nhan().ToString();
            }
            else if (rdo_chia.Checked)
            {
                if (b == 0)
                {
                    errorProvider1.SetError(txt_b, "Không thể chia cho 0!");
                    MessageBox.Show("Phép chia bị lỗi: Không thể chia cho 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_kq.Clear();
                }
                else
                {
                    txt_kq.Text = dt.Chia().ToString();
                }
            }
        }

        // 3. Tự động tính khi click đổi RadioButton
        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;
            if (rdo != null && rdo.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txt_a.Text) && !string.IsNullOrWhiteSpace(txt_b.Text))
                {
                    btn_Tinh_Click(sender, e);
                }
            }
        }

        // 4. Hỏi xác nhận trước khi đóng Form
        private void PhepTinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát?",
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