using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace B3
{
    public partial class B3_2 : Form
    {
        private SqlConnection connsql;

        public B3_2()
        {
            InitializeComponent();

            // Khởi tạo chuỗi kết nối đến Server LAPTOP-A9QTNVVO và Database TH_5d
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=TH_5d; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        // 1. Chức năng Thêm điểm
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Ràng buộc: Mã SV, Mã MH, Điểm không được để trống
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtMaMH.Text) ||
                string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Mã sinh viên, Mã môn học và Điểm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra điểm có phải là số hợp lệ hay không
            if (!double.TryParse(txtDiem.Text.Trim(), out double diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là số hợp lệ từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string insertString = "INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('"
                    + txtMaSV.Text.Trim() + "', '"
                    + txtMaMH.Text.Trim() + "', "
                    + diem + ")";

                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Chức năng Xóa điểm
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Ràng buộc: Mã SV, Mã MH không được để trống
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Mã sinh viên và Mã môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string deleteString = "DELETE FROM Diem WHERE MaSV = '" + txtMaSV.Text.Trim() + "' AND MaMH = '" + txtMaMH.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu điểm tương ứng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Chức năng Sửa điểm
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Ràng buộc: Mã SV, Mã MH không được để trống; Điểm phải được nhập liệu
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtMaMH.Text) ||
                string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Mã sinh viên, Mã môn học và Điểm mới không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Điểm chỉ được nhập số từ 0 đến 10
            if (!double.TryParse(txtDiem.Text.Trim(), out double diemMoi) || diemMoi < 0 || diemMoi > 10)
            {
                MessageBox.Show("Điểm mới phải là số hợp lệ từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string updateString = "UPDATE Diem SET Diem = " + diemMoi
                    + " WHERE MaSV = '" + txtMaSV.Text.Trim() + "' AND MaMH = '" + txtMaMH.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(updateString, connsql);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu điểm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtMaMH.Clear();
            txtDiem.Clear();
            txtMaSV.Focus();
        }
    }
}