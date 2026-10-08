using System;
using System.Windows.Forms;

namespace B2_4
{
    public partial class frmDaySoTinhTong : Form
    {
        private DaySo daySo = new DaySo();

        public frmDaySoTinhTong()
        {
            InitializeComponent();
        }

        // Chặn không cho nhập ký tự khác số nguyên vào ô Nhập số
        private void txtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Cho phép Backspace, phím số và dấu '-'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Dấu trừ chỉ được phép nhập ở đầu tiên
            if (e.KeyChar == '-' && txt != null && (txt.SelectionStart != 0 || txt.Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        // 1. Nhấn nút "Nhập": Thêm số vào dãy và hiển thị ra textbox
        private void btnNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!int.TryParse(txtNhapSo.Text.Trim(), out int so))
            {
                errorProvider1.SetError(txtNhapSo, "Vui lòng nhập một số nguyên hợp lệ!");
                txtNhapSo.Focus();
                return;
            }

            // Thêm vào đối tượng dãy số
            daySo.ThemSo(so);
            txtDayVuaNhap.Text = daySo.XuatDaySo();

            // Tự động cập nhật cả 3 kết quả tính toán ngay khi thêm
            txtTongDay.Text = daySo.TinhTong().ToString();
            txtTongChan.Text = daySo.TinhTongChan().ToString();
            txtTongLe.Text = daySo.TinhTongLe().ToString();

            // Chuẩn bị cho lần nhập tiếp theo
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        // 2. Button Tính Tổng
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (!daySo.CoPhanTu())
            {
                MessageBox.Show("Dãy số hiện đang trống! Vui lòng nhập số trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtTongDay.Text = daySo.TinhTong().ToString();
        }

        // 3. Button Tổng Chẵn
        private void btnTongChan_Click(object sender, EventArgs e)
        {
            if (!daySo.CoPhanTu())
            {
                MessageBox.Show("Dãy số hiện đang trống! Vui lòng nhập số trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtTongChan.Text = daySo.TinhTongChan().ToString();
        }

        // 4. Button Tổng Lẻ
        private void btnTongLe_Click(object sender, EventArgs e)
        {
            if (!daySo.CoPhanTu())
            {
                MessageBox.Show("Dãy số hiện đang trống! Vui lòng nhập số trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtTongLe.Text = daySo.TinhTongLe().ToString();
        }

        // 5. Button Tiếp Tục: Trả lại trạng thái ban đầu của Form
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            daySo.XoaDay();
            txtNhapSo.Clear();
            txtDayVuaNhap.Clear();
            txtTongDay.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            errorProvider1.Clear();
            txtNhapSo.Focus();
        }

        // 6. Button Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 7. Xác nhận trước khi đóng Form
        private void frmDaySoTinhTong_FormClosing(object sender, FormClosingEventArgs e)
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