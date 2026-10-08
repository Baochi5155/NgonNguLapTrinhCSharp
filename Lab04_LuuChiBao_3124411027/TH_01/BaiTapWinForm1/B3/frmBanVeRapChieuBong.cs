using System;
using System.Drawing;
using System.Windows.Forms;

namespace B3
{
    public partial class frmBanVeRapChieuBong : Form
    {
        public frmBanVeRapChieuBong()
        {
            InitializeComponent();
        }

        // 1. Xử lý click chọn hoặc hủy chọn ghế trên sơ đồ
        private void btnGhe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Nếu ghế đã bán (Màu Vàng) -> Báo lỗi
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show($"Ghế số {btn.Text} đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Nếu ghế chưa bán (Màu Trắng) -> Đổi sang Xanh (đang chọn)
            else if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White;
            }
            // Nếu ghế đang chọn (Màu Xanh) -> Đổi về Trắng (bỏ chọn)
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
        }

        // 2. Nút "Chọn": Chuyển các ghế đang chọn (Xanh) sang Vàng (đã bán) và tính tiền
        private void btnChon_Click(object sender, EventArgs e)
        {
            double tongTien = 0;
            int soGheMua = 0;

            foreach (Control ctr in pnlGhe.Controls)
            {
                if (ctr is Button btn && btn.BackColor == Color.Blue)
                {
                    int soGhe = int.Parse(btn.Text);
                    tongTien += QuanLyVe.LayGiaVe(soGhe);

                    btn.BackColor = Color.Yellow;
                    btn.ForeColor = Color.Black;
                    soGheMua++;
                }
            }

            if (soGheMua == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế trước khi nhấn Chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtThanhTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        // 3. Nút "Hủy bỏ": Đổi các ghế đang chọn về lại Trắng, ô Thành tiền về 0
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in pnlGhe.Controls)
            {
                if (ctr is Button btn && btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }

            txtThanhTien.Text = "0";
        }

        // 4. Nút "Kết thúc"
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 5. Xác nhận khi đóng Form
        private void frmBanVeRapChieuBong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có thực sự muốn kết thúc chương trình không?",
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