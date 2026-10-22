using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace B4
{
    public partial class frmBanHang : Form
    {
        private SqlConnection connsql;
        private int maHDHienTai = -1;

        public frmBanHang()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=TH_6b; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            EnableChiTietForm(false);
            LoadComboBoxSanPham();
        }

        private void EnableChiTietForm(bool enable)
        {
            txtMaHD.Enabled = false;
            cboMaSP.Enabled = enable;
            txtSoLuong.Enabled = enable;
            btnThem.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThanhToan.Enabled = enable;
        }

        private void LoadComboBoxSanPham()
        {
            try
            {
                if (connsql.State == ConnectionState.Closed) connsql.Open();
                string query = "SELECT MaSP FROM SANPHAM";
                SqlCommand cmd = new SqlCommand(query, connsql);
                SqlDataReader reader = cmd.ExecuteReader();

                cboMaSP.Items.Clear();
                while (reader.Read())
                {
                    cboMaSP.Items.Add(reader["MaSP"].ToString());
                }
                reader.Close();

                if (cboMaSP.Items.Count > 0) cboMaSP.SelectedIndex = 0;
                if (connsql.State == ConnectionState.Open) connsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed) connsql.Open();

                string query = "INSERT INTO HOADON (NgayTao, TinhTrangThanhToan) OUTPUT INSERTED.MaHD VALUES (GETDATE(), 0)";
                SqlCommand cmd = new SqlCommand(query, connsql);
                maHDHienTai = (int)cmd.ExecuteScalar();

                if (connsql.State == ConnectionState.Open) connsql.Close();

                txtMaHD.Text = maHDHienTai.ToString();
                EnableChiTietForm(true);
                MessageBox.Show("Đã tạo hóa đơn mới số: " + maHDHienTai, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaSP.SelectedItem == null || string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn Mã sản phẩm và nhập Số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuongBan) || soLuongBan <= 0)
            {
                MessageBox.Show("Số lượng bán phải là số nguyên lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maSP = int.Parse(cboMaSP.SelectedItem.ToString());
            string ngayHienTai = DateTime.Now.ToString("yyyy-MM-dd");

            try
            {
                if (connsql.State == ConnectionState.Closed) connsql.Open();

                // 1. Kiểm tra số lượng tồn hiện tại của sản phẩm
                string queryTon = "SELECT TOP 1 (SLDau + SLNhap - SLBan) AS SLTon FROM TONKHO WHERE MaSP = " + maSP + " ORDER BY NgayTon DESC";
                SqlCommand cmdTon = new SqlCommand(queryTon, connsql);
                object result = cmdTon.ExecuteScalar();
                int slTon = result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;

                if (soLuongBan > slTon)
                {
                    MessageBox.Show("Số lượng bán (" + soLuongBan + ") vượt quá số lượng tồn kho hiện tại (" + slTon + ")!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (connsql.State == ConnectionState.Open) connsql.Close();
                    return;
                }

                // 2. Thêm vào bảng CHITIET_HOADON
                string queryCT = "INSERT INTO CHITIET_HOADON (MaHD, MaSP, SoLuong) VALUES (" + maHDHienTai + ", " + maSP + ", " + soLuongBan + ")";
                SqlCommand cmdCT = new SqlCommand(queryCT, connsql);
                cmdCT.ExecuteNonQuery();

                // 3. Cập nhật lại số lượng bán trong bảng TONKHO
                string queryUpdateTon = "UPDATE TONKHO SET SLBan = SLBan + " + soLuongBan + " WHERE MaSP = " + maSP + " AND NgayTon = '" + ngayHienTai + "'";
                SqlCommand cmdUpdateTon = new SqlCommand(queryUpdateTon, connsql);
                int rows = cmdUpdateTon.ExecuteNonQuery();

                // Nếu ngày hôm nay chưa có dòng tồn kho thì thêm dòng mới
                if (rows == 0)
                {
                    string insertTonHomNay = "INSERT INTO TONKHO (MaSP, NgayTon, SLDau, SLNhap, SLBan) VALUES (" + maSP + ", '" + ngayHienTai + "', " + slTon + ", 0, " + soLuongBan + ")";
                    SqlCommand cmdInsertTon = new SqlCommand(insertTonHomNay, connsql);
                    cmdInsertTon.ExecuteNonQuery();
                }

                if (connsql.State == ConnectionState.Open) connsql.Close();

                MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi (kiểm tra trùng khóa/khóa ngoại): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtSoLuong.Clear();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed) connsql.Open();
                string query = "UPDATE HOADON SET TinhTrangThanhToan = 1 WHERE MaHD = " + maHDHienTai;
                SqlCommand cmd = new SqlCommand(query, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open) connsql.Close();

                MessageBox.Show("Thanh toán hóa đơn " + maHDHienTai + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnableChiTietForm(false);
                txtMaHD.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}