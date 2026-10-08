using System;
using System.Windows.Forms;

namespace B2_1
{
    public partial class frmCongTruNhanChia : Form
    {
        public frmCongTruNhanChia()
        {
            InitializeComponent();
        }

        // Mức 2: Chặn không cho người dùng nhập giá trị khác số vào textbox a, b
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Cho phép Backspace, số, dấu '.' và dấu '-'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Chỉ cho phép 1 dấu chấm thập phân
            if (e.KeyChar == '.' && txt != null && txt.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Dấu trừ chỉ được phép ở đầu tiên
            if (e.KeyChar == '-' && txt != null && (txt.SelectionStart != 0 || txt.Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        // Xử lý chung cho cả 4 nút: +, -, x, /
        private void btn_PhepToan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            // Mức 1: Kiểm tra tính hợp lệ dùng ErrorProvider
            if (!float.TryParse(txt_a.Text.Trim(), out float a))
            {
                errorProvider1.SetError(txt_a, "Dữ liệu nhập vào ô a không hợp lệ!");
                hopLe = false;
            }

            if (!float.TryParse(txt_b.Text.Trim(), out float b))
            {
                errorProvider1.SetError(txt_b, "Dữ liệu nhập vào ô b không hợp lệ!");
                hopLe = false;
            }

            // Thông báo lỗi bằng MessageBox nếu dữ liệu không phù hợp
            if (!hopLe)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập ở các ô bị báo lỗi!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_kq.Clear();
                return;
            }

            TinhToan dt = new TinhToan(a, b);
            Button btn = sender as Button;

            if (btn == btn_Cong)
            {
                txt_kq.Text = dt.Cong().ToString();
            }
            else if (btn == btn_Tru)
            {
                txt_kq.Text = dt.Tru().ToString();
            }
            else if (btn == btn_Nhan)
            {
                txt_kq.Text = dt.Nhan().ToString();
            }
            else if (btn == btn_Chia)
            {
                if (b == 0)
                {
                    errorProvider1.SetError(txt_b, "Không thể chia cho 0!");
                    MessageBox.Show("Phép chia không hợp lệ: Không thể chia cho 0!", "Lỗi tính toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_kq.Clear();
                }
                else
                {
                    txt_kq.Text = dt.Chia().ToString();
                }
            }
        }

        // Hỏi xác nhận trước khi đóng Form
        private void frmCongTruNhanChia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có thực sự muốn đóng chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}