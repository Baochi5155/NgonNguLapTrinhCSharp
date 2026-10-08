using System;
using System.Windows.Forms;

namespace B4
{
    public partial class frmMayTinhBoTui : Form
    {
        private double soThuNhat = 0;
        private string phepToanHienTai = "";
        private bool dangNhapSoMoi = true;

        public frmMayTinhBoTui()
        {
            InitializeComponent();
        }

        // 1. Xử lý chung khi bấm các nút số (0 - 9)
        private void btnSo_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (dangNhapSoMoi || txtHienThi.Text == "0")
            {
                txtHienThi.Text = btn.Text;
                dangNhapSoMoi = false;
            }
            else
            {
                txtHienThi.Text += btn.Text;
            }
        }

        // 2. Xử lý chung khi bấm các nút phép toán (+, -, *, /)
        private void btnPhepToan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Nếu người dùng liên tiếp bấm các phép tính, tự động tính giá trị trước đó
            if (!dangNhapSoMoi && !string.IsNullOrEmpty(phepToanHienTai))
            {
                btnBang_Click(sender, e);
            }

            if (double.TryParse(txtHienThi.Text, out double val))
            {
                soThuNhat = val;
            }

            phepToanHienTai = btn.Text;
            dangNhapSoMoi = true;
        }

        // 3. Nút Bằng (=) để thực thi tính toán
        private void btnBang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phepToanHienTai)) return;

            if (double.TryParse(txtHienThi.Text, out double soThuHai))
            {
                try
                {
                    double ketQua = MayTinh.TinhToan(soThuNhat, soThuHai, phepToanHienTai);
                    txtHienThi.Text = ketQua.ToString();
                    soThuNhat = ketQua;
                    phepToanHienTai = "";
                    dangNhapSoMoi = true;
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi tính toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnC_Click(sender, e);
                }
            }
        }

        // 4. Nút C (Clear): Xóa toàn bộ phép tính về ban đầu
        private void btnC_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = "0";
            soThuNhat = 0;
            phepToanHienTai = "";
            dangNhapSoMoi = true;
        }

        // 5. Xác nhận khi đóng form
        private void frmMayTinhBoTui_FormClosing(object sender, FormClosingEventArgs e)
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