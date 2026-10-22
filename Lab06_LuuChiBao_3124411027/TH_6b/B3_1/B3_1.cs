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

            // Khởi tạo chuỗi kết nối đến Server LAPTOP-A9QTNVVO và Database TH_6b
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=TH_6b; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        // Sự kiện khi nhấn vào button "Hiển thị dữ liệu"
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string query = "SELECT MaLop, TenLop, MaKhoa FROM Lop";
                SqlCommand cmd = new SqlCommand(query, connsql);
                SqlDataReader reader = cmd.ExecuteReader();

                // Xóa các dòng dữ liệu cũ trong ListView trước khi nạp mới
                lvwDanhSachLop.Items.Clear();

                int stt = 1;
                while (reader.Read())
                {
                    // Cột đầu tiên trong ListView đại diện cho STT
                    ListViewItem item = new ListViewItem(stt.ToString());

                    // Các cột phụ (SubItems): Mã lớp, Tên lớp, Mã khoa
                    item.SubItems.Add(reader["MaLop"].ToString());
                    item.SubItems.Add(reader["TenLop"].ToString());
                    item.SubItems.Add(reader["MaKhoa"].ToString());

                    // Thêm dòng vào ListView
                    lvwDanhSachLop.Items.Add(item);
                    stt++;
                }

                reader.Close();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi nhấn vào button "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}