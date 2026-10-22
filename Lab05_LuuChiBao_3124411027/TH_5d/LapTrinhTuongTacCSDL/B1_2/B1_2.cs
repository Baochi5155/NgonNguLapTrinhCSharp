using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace B1_2
{
    public partial class B1_2 : Form
    {
        // Khai báo đối tượng kết nối SQL Server
        private SqlConnection connsql;

        public B1_2()
        {
            InitializeComponent();

            // Khởi tạo chuỗi kết nối đến Server LAPTOP-A9QTNVVO và Database QLKhoaDB
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=QLKhoaDB; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        // Chức năng Thêm dữ liệu Khoa
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string insertString = "insert into Khoa values('" + txtMaKhoa.Text + "', N'" + txtTenKhoa.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }

                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message);
            }
        }

        // Chức năng Xóa dữ liệu Khoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string deleteString = "delete Khoa where MaKhoa='" + txtMaKhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }

                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message);
            }
        }

        // Chức năng Sửa dữ liệu Khoa
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string updateString = "update Khoa set TenKhoa=N'" + txtTenKhoa.Text + "' where MaKhoa='" + txtMaKhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(updateString, connsql);
                cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }

                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message);
            }
        }
    }
}