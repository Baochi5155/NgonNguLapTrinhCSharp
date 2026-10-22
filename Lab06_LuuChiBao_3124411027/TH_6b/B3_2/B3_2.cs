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

            // Chuỗi kết nối đến Server LAPTOP-A9QTNVVO và Database TH_6b
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=TH_6b; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        // Sự kiện Load của Form
        private void B3_2_Load(object sender, EventArgs e)
        {
            LoadComboBoxMonHoc();
            HienThiDanhSachDiem(""); // Mặc định hiển thị tất cả điểm khi vừa mở form
        }

        // 1. Hiển thị mã môn học trong bảng MonHoc lên ComboBox, thêm item khoảng trắng " "
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
                // Thêm item khoảng trắng ở vị trí đầu tiên (tương ứng với chọn Tất cả môn học)
                cboMonHoc.Items.Add(" ");

                while (reader.Read())
                {
                    cboMonHoc.Items.Add(reader["MaMH"].ToString());
                }
                reader.Close();

                cboMonHoc.SelectedIndex = 0; // Chọn item khoảng trắng mặc định

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Hiển thị dữ liệu lên ListView và tính Tổng điểm
        private void HienThiDanhSachDiem(string maMH)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string query = @"SELECT sv.HoTen, sv.NgaySinh, mh.TenMH, d.Diem 
                                 FROM Diem d 
                                 JOIN SinhVien sv ON d.MaSV = sv.MaSV 
                                 JOIN MonHoc mh ON d.MaMH = mh.MaMH";

                // Nếu chọn một mã môn học cụ thể (khác khoảng trắng)
                if (!string.IsNullOrWhiteSpace(maMH))
                {
                    query += " WHERE d.MaMH = '" + maMH.Trim() + "'";
                }

                SqlCommand cmd = new SqlCommand(query, connsql);
                SqlDataReader reader = cmd.ExecuteReader();

                lvwDanhSachDiem.Items.Clear();
                double tongDiem = 0;
                int stt = 1;

                while (reader.Read())
                {
                    // Cột 1: STT
                    ListViewItem item = new ListViewItem(stt.ToString());

                    // Cột 2: Tên SV
                    item.SubItems.Add(reader["HoTen"].ToString());

                    // Cột 3: Ngày sinh
                    DateTime ngaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                    item.SubItems.Add(ngaySinh.ToString("M/d/yyyy HH:mm:ss..."));

                    // Cột 4: Tên môn học
                    item.SubItems.Add(reader["TenMH"].ToString());

                    // Cột 5: Điểm
                    double diem = Convert.ToDouble(reader["Diem"]);
                    item.SubItems.Add(diem.ToString());

                    // Cộng dồn tính tổng điểm
                    tongDiem += diem;

                    lvwDanhSachDiem.Items.Add(item);
                    stt++;
                }

                reader.Close();

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();

                // Gán tổng điểm hiển thị trên ListView vào TextBox Tổng điểm
                txtTongDiem.Text = tongDiem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Xử lý sự kiện nhấn nút "Lọc dữ liệu"
        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            string maMHChon = cboMonHoc.SelectedItem != null ? cboMonHoc.SelectedItem.ToString() : "";
            HienThiDanhSachDiem(maMHChon);
        }
    }
}