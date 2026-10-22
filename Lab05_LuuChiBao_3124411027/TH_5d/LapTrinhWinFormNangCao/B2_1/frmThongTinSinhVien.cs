using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace B2_1
{
    public partial class frmThongTinSinhVien : Form
    {
        public frmThongTinSinhVien()
        {
            InitializeComponent();
        }

        // 1. Khi Load form: Thêm dữ liệu vào ComboBox dân tộc
        private void frmThongTinSinhVien_Load(object sender, EventArgs e)
        {
            string[] danToc = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khác" };
            cboDanToc.Items.AddRange(danToc);
            if (cboDanToc.Items.Count > 0)
                cboDanToc.SelectedIndex = 0;

            rdoNam.Checked = true;
        }

        // Hàm hỗ trợ lấy chuỗi các Ngoại ngữ được chọn
        private string GetNgoaiNgu()
        {
            List<string> list = new List<string>();
            if (chkAnh.Checked) list.Add("Anh");
            if (chkPhap.Checked) list.Add("Pháp");
            if (chkHoa.Checked) list.Add("Hoa");
            return string.Join(", ", list);
        }

        // Hàm hỗ trợ kiểm tra trùng Mã sinh viên
        private bool KiemTraTrungMaSV(string maSV)
        {
            foreach (ListViewItem item in lsvSinhVien.Items)
            {
                if (string.Compare(item.SubItems[1].Text.Trim(), maSV.Trim(), true) == 0)
                {
                    return true; // Đã tồn tại mã SV này
                }
            }
            return false;
        }

        // 2. Button Thêm: Thêm sinh viên mới (không cho trùng mã sinh viên)
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string maSV = txtMaSV.Text.Trim();

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra không cho trùng mã sinh viên
            if (KiemTraTrungMaSV(maSV))
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại trong danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.SelectAll();
                txtMaSV.Focus();
                return;
            }

            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            string ngoaiNgu = GetNgoaiNgu();
            string danToc = cboDanToc.SelectedItem != null ? cboDanToc.SelectedItem.ToString() : "";

            // Tạo item mới hiển thị lên ListView
            ListViewItem item = new ListViewItem(hoTen);
            item.SubItems.Add(maSV);
            item.SubItems.Add(gioiTinh);
            item.SubItems.Add(ngoaiNgu);
            item.SubItems.Add(danToc);

            lsvSinhVien.Items.Add(item);

            ResetInput();
        }

        // 3. Button Xóa (và gọi từ ContextMenuStrip)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa trên ListView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên đang chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (ListViewItem item in lsvSinhVien.SelectedItems)
                {
                    lsvSinhVien.Items.Remove(item);
                }
                ResetInput();
            }
        }

        // 4. Button Sửa: Cập nhật thông tin (không cho sửa Mã sinh viên)
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng sinh viên cần sửa trên ListView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = lsvSinhVien.SelectedItems[0];

            // Cập nhật các thông tin khác trừ Mã SV
            item.SubItems[0].Text = txtHoTen.Text.Trim();
            item.SubItems[2].Text = rdoNam.Checked ? "Nam" : "Nữ";
            item.SubItems[3].Text = GetNgoaiNgu();
            item.SubItems[4].Text = cboDanToc.SelectedItem != null ? cboDanToc.SelectedItem.ToString() : "";

            MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetInput();
        }

        // Đổ dữ liệu từ dòng được chọn lên các control nhập liệu
        private void lsvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvSinhVien.SelectedItems[0];
                txtHoTen.Text = item.SubItems[0].Text;
                txtMaSV.Text = item.SubItems[1].Text;
                txtMaSV.Enabled = false; // Không cho phép sửa Mã sinh viên

                if (item.SubItems[2].Text == "Nam")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;

                string ngoaiNgu = item.SubItems[3].Text;
                chkAnh.Checked = ngoaiNgu.Contains("Anh");
                chkPhap.Checked = ngoaiNgu.Contains("Pháp");
                chkHoa.Checked = ngoaiNgu.Contains("Hoa");

                cboDanToc.Text = item.SubItems[4].Text;
            }
            else
            {
                txtMaSV.Enabled = true;
            }
        }

        // Hàm xóa trắng ô nhập liệu
        private void ResetInput()
        {
            txtHoTen.Clear();
            txtMaSV.Clear();
            txtMaSV.Enabled = true;
            rdoNam.Checked = true;
            chkAnh.Checked = false;
            chkPhap.Checked = false;
            chkHoa.Checked = false;
            if (cboDanToc.Items.Count > 0)
                cboDanToc.SelectedIndex = 0;
            txtHoTen.Focus();
        }

        // 5. Hỏi xác nhận trước khi đóng Form
        private void frmThongTinSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}