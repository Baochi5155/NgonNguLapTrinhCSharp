using System;
using System.Windows.Forms;

namespace B3_1
{
    public partial class frmQuanLyHocVien : Form
    {
        public frmQuanLyHocVien()
        {
            InitializeComponent();
        }

        // Khởi tạo một số học viên mẫu
        private void frmQuanLyHocVien_Load(object sender, EventArgs e)
        {
            lstLopA.Items.Add("Trần Hùng");
            lstLopA.Items.Add("Nguyễn Hưng");
            lstLopA.Items.Add("Lâm Tử");

            lstLopB.Items.Add("Tuấn Hưng");
            lstLopB.Items.Add("Hồng Ngọc");
            lstLopB.Items.Add("Anh Minh");
            lstLopB.Items.Add("Bảo Lâm");
        }

        // Phương thức công khai cho phép Form phụ thêm học viên vào ListBox
        public void ThemHocVien(string hoTen, string lop)
        {
            if (lop == "Lớp A")
            {
                lstLopA.Items.Add(hoTen);
            }
            else if (lop == "Lớp B")
            {
                lstLopB.Items.Add(hoTen);
            }
        }

        // Menu "Nhập học viên mới": Mở Form phụ
        private void tsmiNhapHocVienMoi_Click(object sender, EventArgs e)
        {
            frmNhapHocVien frm = new frmNhapHocVien(this);
            frm.ShowDialog();
        }

        // Menu "Chuyển sang lớp B": Chuyển các mục đang chọn từ Lớp A sang Lớp B
        private void tsmiChuyenSangLopB_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên ở Lớp A cần chuyển sang Lớp B!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            while (lstLopA.SelectedItems.Count > 0)
            {
                lstLopB.Items.Add(lstLopA.SelectedItems[0]);
                lstLopA.Items.Remove(lstLopA.SelectedItems[0]);
            }
        }

        // Menu "Chuyển sang lớp A": Chuyển các mục đang chọn từ Lớp B sang Lớp A
        private void tsmiChuyenSangLopA_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên ở Lớp B cần chuyển sang Lớp A!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            while (lstLopB.SelectedItems.Count > 0)
            {
                lstLopA.Items.Add(lstLopB.SelectedItems[0]);
                lstLopB.Items.Remove(lstLopB.SelectedItems[0]);
            }
        }

        // Menu "Xóa học viên": Xóa tất cả học viên đang chọn trong cả Lớp A và Lớp B
        private void tsmiXoaHocVien_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0 && lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            while (lstLopA.SelectedItems.Count > 0)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[0]);
            }

            while (lstLopB.SelectedItems.Count > 0)
            {
                lstLopB.Items.Remove(lstLopB.SelectedItems[0]);
            }
        }

        // Menu "Kết thúc"
        private void tsmiKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hỏi xác nhận trước khi dừng chương trình
        private void frmQuanLyHocVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn dừng chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}