using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace B4_2
{
    public partial class frmQuanLySinhVien : Form
    {
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            InitControlData();
        }

        private void InitControlData()
        {
            // Thêm danh sách dân tộc vào ComboBox
            cboDanToc.Items.Clear();
            cboDanToc.Items.AddRange(new string[] { "Kinh", "Tày", "Thái", "Mường", "Khơ-me", "H'Mông", "Khác" });
            cboDanToc.SelectedIndex = 0;

            // Khởi tạo các cột cho DataGridView
            dgvSinhVien.Columns.Clear();
            dgvSinhVien.Columns.Add("colHoTen", "Họ tên");
            dgvSinhVien.Columns.Add("colMSV", "Mã sinh viên");
            dgvSinhVien.Columns.Add("colGioiTinh", "Giới tính");
            dgvSinhVien.Columns.Add("colNgoaiNgu", "Ngoại ngữ");
            dgvSinhVien.Columns.Add("colDanToc", "Dân tộc");
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtMSV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy giới tính
            string gioiTinh = rdbNam.Checked ? "Nam" : (rdbNu.Checked ? "Nữ" : "Khác");

            // Lấy danh sách ngoại ngữ
            List<string> dsNgoaiNgu = new List<string>();
            if (chkAnh.Checked) dsNgoaiNgu.Add("Anh");
            if (chkPhap.Checked) dsNgoaiNgu.Add("Pháp");
            if (chkHoa.Checked) dsNgoaiNgu.Add("Hoa");
            string ngoaiNgu = string.Join(", ", dsNgoaiNgu);

            // Lấy dân tộc
            string danToc = cboDanToc.SelectedItem?.ToString() ?? "";

            // Thêm dữ liệu vào DataGridView
            dgvSinhVien.Rows.Add(txtHoTen.Text.Trim(), txtMSV.Text.Trim(), gioiTinh, ngoaiNgu, danToc);
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtHoTen.Clear();
            txtMSV.Clear();
            rdbNam.Checked = true;
            chkAnh.Checked = false;
            chkPhap.Checked = false;
            chkHoa.Checked = false;
            cboDanToc.SelectedIndex = 0;
            txtHoTen.Focus();
        }
    }
}