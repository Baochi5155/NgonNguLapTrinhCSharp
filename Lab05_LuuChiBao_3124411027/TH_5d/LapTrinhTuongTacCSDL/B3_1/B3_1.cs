using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace B3
{
    public partial class B3_1 : Form
    {
        private SqlConnection connsql;

        public B3_1()
        {
            InitializeComponent();

            // Khởi tạo chuỗi kết nối đến Server LAPTOP-A9QTNVVO và Database TH_5d
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=TH_5d; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        // 1. Chức năng Thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra: Mã lớp, Mã sinh viên, Tên sinh viên, Ngày sinh không được để trống
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) ||
                string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(mtbNgaySinh.Text) ||
                !DateTime.TryParse(mtbNgaySinh.Text, out DateTime ngaySinh))
            {
                MessageBox.Show("Mã lớp, Mã sinh viên, Họ tên và Ngày sinh (đúng định dạng) không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string insertString = "INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('"
                    + txtMaLop.Text.Trim() + "', '"
                    + txtMaSV.Text.Trim() + "', N'"
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
            // Kiểm tra: Mã sinh viên, Tên sinh viên không được để trống
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Mã sinh viên và Họ tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                // Xóa sinh viên trùng cả mã sinh viên và tên
                string deleteString = "DELETE FROM SinhVien WHERE MaSV = '" + txtMaSV.Text.Trim() + "' AND HoTen = N'" + txtHoTen.Text.Trim() + "'";
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
                    MessageBox.Show("Không tìm thấy sinh viên có Mã và Họ tên trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Chức năng Sửa sinh viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra: Mã sinh viên không được để trống
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra có ít nhất 1 trong 3 trường còn lại được nhập
            bool hasMaLop = !string.IsNullOrWhiteSpace(txtMaLop.Text);
            bool hasHoTen = !string.IsNullOrWhiteSpace(txtHoTen.Text);
            bool hasNgaySinh = !string.IsNullOrWhiteSpace(mtbNgaySinh.Text) && DateTime.TryParse(mtbNgaySinh.Text, out _);

            if (!hasMaLop && !hasHoTen && !hasNgaySinh)
            {
                MessageBox.Show("Mã lớp, Họ tên, Ngày sinh phải có ít nhất một trường có dữ liệu để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                // Xây dựng câu lệnh UPDATE động tùy thuộc vào trường được nhập
                string updateString = "UPDATE SinhVien SET ";
                bool needComma = false;

                if (hasMaLop)
                {
                    updateString += "MaLop = '" + txtMaLop.Text.Trim() + "'";
                    needComma = true;
                }

                if (hasHoTen)
                {
                    if (needComma) updateString += ", ";
                    updateString += "HoTen = N'" + txtHoTen.Text.Trim() + "'";
                    needComma = true;
                }

                if (hasNgaySinh)
                {
                    DateTime.TryParse(mtbNgaySinh.Text, out DateTime dt);
                    if (needComma) updateString += ", ";
                    updateString += "NgaySinh = '" + dt.ToString("yyyy-MM-dd") + "'";
                }

                updateString += " WHERE MaSV = '" + txtMaSV.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(updateString, connsql);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Mã sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaLop.Clear();
            txtMaSV.Clear();
            txtHoTen.Clear();
            mtbNgaySinh.Clear();
            txtMaLop.Focus();
        }
    }
}