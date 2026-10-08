using System;
using System.Drawing;
using System.Windows.Forms;

namespace B2_1
{
    public partial class frmGiaiPT : Form
    {
        public frmGiaiPT()
        {
            InitializeComponent();
        }

        // 1. Khi Form load lên: Button "Giải" mờ đi
        private void frmGiaiPT_Load(object sender, EventArgs e)
        {
            btn_Giai.Enabled = false;
        }

        // 2. Chặn nhập các giá trị khác số vào TextBox
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Cho phép phím điều khiển (Backspace), ký tự số, dấu '.' và dấu '-'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Chỉ cho phép tối đa 1 dấu chấm thập phân
            if (e.KeyChar == '.' && txt != null && txt.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Dấu trừ '-' chỉ được phép nằm ở vị trí đầu tiên
            if (e.KeyChar == '-' && txt != null && (txt.SelectionStart != 0 || txt.Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        // 3. Xử lý khi chuyển đổi giữa RadioButton Bậc nhất và Bậc hai
        private void rdo_Option_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_BacNhat.Checked)
            {
                txt_c.Enabled = false;
                txt_c.Clear();
                lbl_c.ForeColor = SystemColors.GrayText;
            }
            else
            {
                txt_c.Enabled = true;
                lbl_c.ForeColor = SystemColors.ControlText;
            }

            txt_kq.Clear();
            errorProvider1.Clear();
            CheckInputsFilled();
        }

        // 4. Kiểm tra khi nhập đủ thông tin vào TextBox cần thiết thì Button "Giải" sáng lên
        private void txt_Inputs_TextChanged(object sender, EventArgs e)
        {
            CheckInputsFilled();
        }

        private void CheckInputsFilled()
        {
            if (rdo_BacNhat.Checked)
            {
                btn_Giai.Enabled = !string.IsNullOrWhiteSpace(txt_a.Text) && !string.IsNullOrWhiteSpace(txt_b.Text);
            }
            else
            {
                btn_Giai.Enabled = !string.IsNullOrWhiteSpace(txt_a.Text) &&
                                   !string.IsNullOrWhiteSpace(txt_b.Text) &&
                                   !string.IsNullOrWhiteSpace(txt_c.Text);
            }
        }

        // 5. Khi bấm nút Giải: Gọi class tính toán, xuất kết quả và làm mờ nút Giải
        private void btn_Giai_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (!double.TryParse(txt_a.Text.Trim(), out double a))
            {
                errorProvider1.SetError(txt_a, "Hệ số a không hợp lệ!");
                isValid = false;
            }

            if (!double.TryParse(txt_b.Text.Trim(), out double b))
            {
                errorProvider1.SetError(txt_b, "Hệ số b không hợp lệ!");
                isValid = false;
            }

            double c = 0;
            if (rdo_BacHai.Checked)
            {
                if (!double.TryParse(txt_c.Text.Trim(), out c))
                {
                    errorProvider1.SetError(txt_c, "Hệ số c không hợp lệ!");
                    isValid = false;
                }
            }

            if (!isValid) return;

            PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b, c);

            if (rdo_BacNhat.Checked)
            {
                txt_kq.Text = pt.GiaiBacNhat();
            }
            else
            {
                txt_kq.Text = pt.GiaiBacHai();
            }

            // Đề bài yêu cầu: sau khi giải xong, button "Giải" mờ đi
            btn_Giai.Enabled = false;
        }

        // 6. Nút Thoát
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 7. Xác nhận trước khi đóng Form
        private void frmGiaiPT_FormClosing(object sender, FormClosingEventArgs e)
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
