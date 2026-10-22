using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace B2
{
    public partial class B2_1 : Form
    {
        private SqlConnection connsql;

        public B2_1()
        {
            InitializeComponent();

            // Khởi tạo chuỗi kết nối đến Server LAPTOP-A9QTNVVO và Database TH_6b
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=TH_6b; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        private void B2_1_Load(object sender, EventArgs e)
        {
            LoadComboBoxLop();
        }

        // Lấy danh sách Mã lớp từ CSDL đổ vào ComboBox
        private void LoadComboBoxLop()
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string query = "SELECT MaLop FROM Lop";
                SqlCommand cmd = new SqlCommand(query, connsql);
                SqlDataReader reader = cmd.ExecuteReader();

                cboLop.Items.Clear();
                while (reader.Read())
                {
                    cboLop.Items.Add(reader["MaLop"].ToString());
                }
                reader.Close();

                if (cboLop.Items.Count > 0)
                    cboLop.SelectedIndex = 0;

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 1. Chức năng Thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Ràng buộc: Tất cả thông tin phải được nhập dữ liệu
            if (cboLop.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(mtbNgaySinh.Text) ||
                !DateTime.TryParse(mtbNgaySinh.Text, out DateTime ngaySinh))
            {
                MessageBox.Show("Tất cả thông tin (Lớp, Mã SV, Họ tên, Ngày sinh hợp lệ) phải được nhập đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ràng buộc tuổi: Sinh viên phải có tuổi từ 17 trở lên (tính theo năm sinh)
            int tuoi = DateTime.Now.Year - ngaySinh.Year;
            if (tuoi < 17)
            {
                MessageBox.Show("Sinh viên phải có tuổi từ 17 trở lên (tính theo năm sinh)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string maSV = txtMaSV.Text.Trim();

                // Kiểm tra trùng Mã sinh viên (Khóa chính) trong CSDL
                string checkQuery = "SELECT COUNT(*) FROM SinhVien WHERE MaSV = '" + maSV + "'";
                SqlCommand checkCmd = new SqlCommand(checkQuery, connsql);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại trong hệ thống! Vui lòng nhập mã khác.", "Cảnh báo trùng khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (connsql.State == ConnectionState.Open) connsql.Close();
                    return;
                }

                // Thực hiện thêm dữ liệu
                string insertString = "INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('"
                    + cboLop.SelectedItem.ToString() + "', '"
                    + maSV + "', N'"
                    + txtHoTen.Text.Trim() + "', '"
                    + ngaySinh.ToString("yyyy-MM-dd") + "')";

                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Chức năng Xóa sinh viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string deleteString = "DELETE FROM SinhVien WHERE MaSV = '" + txtMaSV.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Mã sinh viên này để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại (Lỗi khóa ngoại/CSDL): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Chức năng Sửa sinh viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboLop.SelectedItem == null || string.IsNullOrWhiteSpace(txtHoTen.Text) || !DateTime.TryParse(mtbNgaySinh.Text, out DateTime dt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Lớp, Họ tên và Ngày sinh mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string updateString = "UPDATE SinhVien SET MaLop = '" + cboLop.SelectedItem.ToString()
                    + "', HoTen = N'" + txtHoTen.Text.Trim()
                    + "', NgaySinh = '" + dt.ToString("yyyy-MM-dd")
                    + "' WHERE MaSV = '" + txtMaSV.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(updateString, connsql);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Mã sinh viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            mtbNgaySinh.Clear();
            txtMaSV.Focus();
        }
    }
}