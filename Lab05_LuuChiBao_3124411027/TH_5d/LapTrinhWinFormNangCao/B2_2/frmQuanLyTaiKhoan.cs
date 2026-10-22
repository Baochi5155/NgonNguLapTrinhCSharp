using System;
using System.Windows.Forms;

namespace B2_2
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        // Khi Form load lên
        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            UpdateSTTVaTongTien();
        }

        // Hàm hỗ trợ tính tổng tiền và đánh lại STT tự động
        private void UpdateSTTVaTongTien()
        {
            decimal tongTien = 0;

            for (int i = 0; i < lsvTaiKhoan.Items.Count; i++)
            {
                ListViewItem item = lsvTaiKhoan.Items[i];
                // Đánh lại STT tự động
                item.SubItems[0].Text = (i + 1).ToString();

                // Tính tổng tiền
                string strSoTien = item.SubItems[4].Text.Replace(",", "").Replace(".", "").Trim();
                if (decimal.TryParse(strSoTien, out decimal soTien))
                {
                    tongTien += soTien;
                }
            }

            // Hiển thị tổng tiền dạng 6,400,000
            txtTongTien.Text = tongTien.ToString("#,##0");
        }

        // Hàm xóa trắng ô nhập liệu
        private void ClearTextBoxes()
        {
            txtSoTaiKhoan.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
        }

        // Nút Thêm / Hủy
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                ClearTextBoxes();
                txtSoTaiKhoan.Focus();
            }
            else // Khi bấm "Hủy"
            {
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                ClearTextBoxes();
            }
        }

        // Nút Lưu: Lưu dữ liệu từ các Textbox vào ListView
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string stk = txtSoTaiKhoan.Text.Trim();
            string ten = txtTenKhachHang.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string strSoTien = txtSoTien.Text.Trim();

            if (string.IsNullOrEmpty(stk) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(strSoTien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(strSoTien, out decimal soTien) || soTien < 0)
            {
                MessageBox.Show("Số tiền trong tài khoản phải là một số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTien.SelectAll();
                txtSoTien.Focus();
                return;
            }

            // Kiểm tra xem số tài khoản đã tồn tại trong ListView chưa (nếu thêm mới)
            bool isExist = false;
            foreach (ListViewItem item in lsvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text.Trim().Equals(stk, StringComparison.OrdinalIgnoreCase))
                {
                    isExist = true;
                    // Cập nhật thông tin nếu đã tồn tại
                    item.SubItems[2].Text = ten;
                    item.SubItems[3].Text = diaChi;
                    item.SubItems[4].Text = soTien.ToString("#,##0");
                    break;
                }
            }

            if (!isExist)
            {
                // Tạo mới phần tử ListView
                ListViewItem item = new ListViewItem(""); // STT sẽ được tự đánh
                item.SubItems.Add(stk);
                item.SubItems.Add(ten);
                item.SubItems.Add(diaChi);
                item.SubItems.Add(soTien.ToString("#,##0"));

                lsvTaiKhoan.Items.Add(item);
            }

            // Cập nhật lại STT và Tổng tiền
            UpdateSTTVaTongTien();

            // Trả trạng thái button về ban đầu
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            ClearTextBoxes();
            MessageBox.Show("Lưu thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Xóa mẫu tin hiện hành trong ListView
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvTaiKhoan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                foreach (ListViewItem item in lsvTaiKhoan.SelectedItems)
                {
                    lsvTaiKhoan.Items.Remove(item);
                }

                ClearTextBoxes();
                btnXoa.Enabled = false;
                UpdateSTTVaTongTien();
            }
        }

        // Hiển thị thông tin lên Textbox khi click chọn trong ListView
        private void lsvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvTaiKhoan.SelectedItems[0];
                txtSoTaiKhoan.Text = item.SubItems[1].Text;
                txtTenKhachHang.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;

                // Chuẩn hóa số tiền về dạng số thuần để dễ sửa đổi
                string rawSoTien = item.SubItems[4].Text.Replace(",", "").Replace(".", "");
                txtSoTien.Text = rawSoTien;

                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hỏi xác nhận trước khi đóng Form
        private void frmQuanLyTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}