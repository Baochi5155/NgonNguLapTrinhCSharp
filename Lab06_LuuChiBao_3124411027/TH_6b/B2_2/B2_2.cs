using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace B2
{
    public partial class B2_2 : Form
    {
        private SqlConnection connsql;

        public B2_2()
        {
            InitializeComponent();

            // Khởi tạo chuỗi kết nối đến Server LAPTOP-A9QTNVVO và Database TH_6b
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=TH_6b; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        private void B2_2_Load(object sender, EventArgs e)
        {
            LoadComboBoxSinhVien();
            LoadComboBoxMonHoc();
        }

        // 1. Hiển thị mã sinh viên lên ComboBox Sinh viên
        private void LoadComboBoxSinhVien()
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string query = "SELECT MaSV FROM SinhVien";
                SqlCommand cmd = new SqlCommand(query, connsql);
                SqlDataReader reader = cmd.ExecuteReader();

                cboSinhVien.Items.Clear();
                while (reader.Read())
                {
                    cboSinhVien.Items.Add(reader["MaSV"].ToString());
                }
                reader.Close();

                if (cboSinhVien.Items.Count > 0)
                    cboSinhVien.SelectedIndex = 0;

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Hiển thị mã môn học lên ComboBox Môn học
        private void LoadComboBoxMonHoc()
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string query = "SELECT MaMH FROM MonHoc";
                SqlCommand cmd = new SqlCommand(query, connsql);
                SqlDataReader reader = cmd.ExecuteReader();

                cboMonHoc.Items.Clear();
                while (reader.Read())
                {
                    cboMonHoc.Items.Add(reader["MaMH"].ToString());
                }
                reader.Close();

                if (cboMonHoc.Items.Count > 0)
                    cboMonHoc.SelectedIndex = 0;

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Chức năng Thêm điểm mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tất cả thông tin phải được nhập dữ liệu
            if (cboSinhVien.SelectedItem == null || cboMonHoc.SelectedItem == null || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng chọn Sinh viên, Môn học và nhập Điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Điểm phải nằm trong khoảng (0-10)
            if (!double.TryParse(txtDiem.Text.Trim(), out double diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là số và nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = cboSinhVien.SelectedItem.ToString();
            string maMH = cboMonHoc.SelectedItem.ToString();

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                // Kiểm tra trùng khóa chính (MaSV, MaMH) trong bảng Điểm
                string checkQuery = "SELECT COUNT(*) FROM Diem WHERE MaSV = '" + maSV + "' AND MaMH = '" + maMH + "'";
                SqlCommand checkCmd = new SqlCommand(checkQuery, connsql);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Điểm của sinh viên " + maSV + " cho môn " + maMH + " đã tồn tại trong CSDL!", "Cảnh báo trùng khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (connsql.State == ConnectionState.Open) connsql.Close();
                    return;
                }

                // Thực hiện thêm điểm
                string insertQuery = "INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('" + maSV + "', '" + maMH + "', " + diem + ")";
                SqlCommand cmd = new SqlCommand(insertQuery, connsql);
                cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Chức năng Xóa điểm
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedItem == null || cboMonHoc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Sinh viên và Môn học cần xóa điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = cboSinhVien.SelectedItem.ToString();
            string maMH = cboMonHoc.SelectedItem.ToString();

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string deleteQuery = "DELETE FROM Diem WHERE MaSV = '" + maSV + "' AND MaMH = '" + maMH + "'";
                SqlCommand cmd = new SqlCommand(deleteQuery, connsql);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiem.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu điểm tương ứng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại (Lỗi ràng buộc CSDL): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5. Chức năng Sửa điểm
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedItem == null || cboMonHoc.SelectedItem == null || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng chọn Sinh viên, Môn học và nhập Điểm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Điểm phải nằm trong khoảng (0-10)
            if (!double.TryParse(txtDiem.Text.Trim(), out double diemMoi) || diemMoi < 0 || diemMoi > 10)
            {
                MessageBox.Show("Điểm mới phải là số nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = cboSinhVien.SelectedItem.ToString();
            string maMH = cboMonHoc.SelectedItem.ToString();

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string updateQuery = "UPDATE Diem SET Diem = " + diemMoi + " WHERE MaSV = '" + maSV + "' AND MaMH = '" + maMH + "'";
                SqlCommand cmd = new SqlCommand(updateQuery, connsql);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu điểm để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}