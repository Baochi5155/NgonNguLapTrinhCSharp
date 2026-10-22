using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace B4
{
    public partial class B4_1 : Form
    {
        private SqlConnection connsql;

        public B4_1()
        {
            InitializeComponent();

            // Khởi tạo chuỗi kết nối đến Server LAPTOP-A9QTNVVO và Database TH_6a
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=TH_6a; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        // 1. Chức năng Thêm lớp
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) ||
                string.IsNullOrWhiteSpace(txtMaLop.Text) ||
                string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Mã khoa, Mã lớp và Tên lớp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string insertString = "INSERT INTO Lop (MaKhoa, MaLop, TenLop) VALUES ('"
                    + txtMaKhoa.Text.Trim() + "', '"
                    + txtMaLop.Text.Trim() + "', N'"
                    + txtTenLop.Text.Trim() + "')";

                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Chức năng Xóa lớp
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string deleteString = "DELETE FROM Lop WHERE MaLop = '" + txtMaLop.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Mã lớp tương ứng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Chức năng Sửa lớp
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasMaKhoa = !string.IsNullOrWhiteSpace(txtMaKhoa.Text);
            bool hasTenLop = !string.IsNullOrWhiteSpace(txtTenLop.Text);

            if (!hasMaKhoa && !hasTenLop)
            {
                MessageBox.Show("Mã khoa hoặc Tên lớp phải có ít nhất 1 trường có dữ liệu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string updateString = "UPDATE Lop SET ";
                bool needComma = false;

                if (hasMaKhoa)
                {
                    updateString += "MaKhoa = '" + txtMaKhoa.Text.Trim() + "'";
                    needComma = true;
                }

                if (hasTenLop)
                {
                    if (needComma) updateString += ", ";
                    updateString += "TenLop = N'" + txtTenLop.Text.Trim() + "'";
                }

                updateString += " WHERE MaLop = '" + txtMaLop.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(updateString, connsql);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thông tin lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Mã lớp để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaKhoa.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMaKhoa.Focus();
        }
    }
}