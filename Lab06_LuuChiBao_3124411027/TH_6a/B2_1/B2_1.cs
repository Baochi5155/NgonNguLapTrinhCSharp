using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace B2
{
    public partial class B2_1 : Form
    {
        // Khai báo đối tượng kết nối SQL Server
        private SqlConnection connsql;

        public B2_1()
        {
            InitializeComponent();

            // Khởi tạo chuỗi kết nối đến Server LAPTOP-A9QTNVVO và Database TH_6a
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=TH_6a; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        // 1. Chức năng Thêm môn học
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc: Mã MH và Tên MH không được để trống
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Mã môn học và Tên môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string insertString = "INSERT INTO MonHoc VALUES ('" + txtMaMH.Text.Trim() + "', N'" + txtTenMH.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }

                MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMH.Clear();
                txtTenMH.Clear();
                txtMaMH.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Chức năng Xóa môn học
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc: Mã môn học không được để trống
            if (string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Mã môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string deleteString = "DELETE FROM MonHoc WHERE MaMH = '" + txtMaMH.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaMH.Clear();
                    txtTenMH.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Mã môn học này để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Chức năng Sửa môn học
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc: Mã MH và Tên MH không được để trống
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Mã môn học và Tên môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string updateString = "UPDATE MonHoc SET TenMH = N'" + txtTenMH.Text.Trim() + "' WHERE MaMH = '" + txtMaMH.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(updateString, connsql);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Mã môn học để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}