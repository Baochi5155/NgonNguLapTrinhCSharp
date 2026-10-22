using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace B4_1
{
    public partial class frmTuDien : Form
    {
        // Cấu trúc dữ liệu lưu trữ từ điển
        public class TuDienItem
        {
            public string TuAnh { get; set; }
            public string TuViet { get; set; }
        }

        private List<TuDienItem> dsTuDien = new List<TuDienItem>();

        public frmTuDien()
        {
            InitializeComponent();
        }

        // Khởi tạo dữ liệu mẫu khi nạp Form
        private void frmTuDien_Load(object sender, EventArgs e)
        {
            dsTuDien.Add(new TuDienItem { TuAnh = "Hello", TuViet = "Xin chào" });
            dsTuDien.Add(new TuDienItem { TuAnh = "Computer", TuViet = "Máy tính" });
            dsTuDien.Add(new TuDienItem { TuAnh = "Programming", TuViet = "Lập trình" });
            dsTuDien.Add(new TuDienItem { TuAnh = "Teacher", TuViet = "Giáo viên" });
            dsTuDien.Add(new TuDienItem { TuAnh = "Student", TuViet = "Sinh viên" });

            NapDanhSachTu();
        }

        // Nạp dữ liệu vào các ComboBox và ListBox của cả 2 tab
        private void NapDanhSachTu()
        {
            cboAnh.Items.Clear();
            lstAnh.Items.Clear();
            cboViet.Items.Clear();
            lstViet.Items.Clear();

            foreach (var item in dsTuDien)
            {
                cboAnh.Items.Add(item.TuAnh);
                lstAnh.Items.Add(item.TuAnh);
                cboViet.Items.Add(item.TuViet);
                lstViet.Items.Add(item.TuViet);
            }
        }

        // --- TAB 1: ANH - VIỆT ---

        private void HienThiNghiaAnhViet()
        {
            string tuCanTra = cboAnh.Text.Trim();
            if (string.IsNullOrEmpty(tuCanTra) && lstAnh.SelectedItem != null)
            {
                tuCanTra = lstAnh.SelectedItem.ToString();
            }

            var item = dsTuDien.FirstOrDefault(x => x.TuAnh.Equals(tuCanTra, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                txtNghiaViet.Text = item.TuViet;
                cboAnh.Text = item.TuAnh;
            }
            else
            {
                txtNghiaViet.Text = "Không tìm thấy từ này trong từ điển!";
            }
        }

        private void cboAnh_TextChanged(object sender, EventArgs e)
        {
            // Tự động tìm và chọn dòng tương ứng trên ListBox khi gõ
            int index = lstAnh.FindString(cboAnh.Text);
            if (index != ListBox.NoMatches)
            {
                lstAnh.SelectedIndex = index;
            }
        }

        private void cboAnh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HienThiNghiaAnhViet();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void lstAnh_DoubleClick(object sender, EventArgs e)
        {
            if (lstAnh.SelectedItem != null)
            {
                cboAnh.Text = lstAnh.SelectedItem.ToString();
                HienThiNghiaAnhViet();
            }
        }

        // --- TAB 2: VIỆT - ANH ---

        private void HienThiNghiaVietAnh()
        {
            string tuCanTra = cboViet.Text.Trim();
            if (string.IsNullOrEmpty(tuCanTra) && lstViet.SelectedItem != null)
            {
                tuCanTra = lstViet.SelectedItem.ToString();
            }

            var item = dsTuDien.FirstOrDefault(x => x.TuViet.Equals(tuCanTra, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                txtNghiaAnh.Text = item.TuAnh;
                cboViet.Text = item.TuViet;
            }
            else
            {
                txtNghiaAnh.Text = "Không tìm thấy từ này trong từ điển!";
            }
        }

        private void cboViet_TextChanged(object sender, EventArgs e)
        {
            // Tự động tìm và chọn dòng tương ứng trên ListBox khi gõ
            int index = lstViet.FindString(cboViet.Text);
            if (index != ListBox.NoMatches)
            {
                lstViet.SelectedIndex = index;
            }
        }

        private void cboViet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HienThiNghiaVietAnh();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void lstViet_DoubleClick(object sender, EventArgs e)
        {
            if (lstViet.SelectedItem != null)
            {
                cboViet.Text = lstViet.SelectedItem.ToString();
                HienThiNghiaVietAnh();
            }
        }

        // --- CHỨC NĂNG THOÁT ---

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTuDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình từ điển không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}