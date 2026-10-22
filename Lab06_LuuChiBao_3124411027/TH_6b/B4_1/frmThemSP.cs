using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace B4
{
    public partial class frmThemSP : Form
    {
        private SqlConnection connsql;

        public frmThemSP()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=TH_6b; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connsql.State == ConnectionState.Closed) connsql.Open();

                // 1. Thêm sản phẩm mới và lấy MaSP tự động tăng vừa sinh ra
                string querySP = "INSERT INTO SANPHAM (TenSP) OUTPUT INSERTED.MaSP VALUES (N'" + txtTenSP.Text.Trim() + "')";
                SqlCommand cmdSP = new SqlCommand(querySP, connsql);
                int newMaSP = (int)cmdSP.ExecuteScalar();

                // 2. Tự động thêm 1 dòng vào bảng TONKHO cho ngày hiện tại (SLDau = 0, SLNhap = 0, SLBan = 0)
                string ngayHienTai = DateTime.Now.ToString("yyyy-MM-dd");
                string queryTon = "INSERT INTO TONKHO (MaSP, NgayTon, SLDau, SLNhap, SLBan) VALUES (" + newMaSP + ", '" + ngayHienTai + "', 0, 0, 0)";
                SqlCommand cmdTon = new SqlCommand(queryTon, connsql);
                cmdTon.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open) connsql.Close();

                MessageBox.Show("Thêm sản phẩm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Clear();
                txtTenSP.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}