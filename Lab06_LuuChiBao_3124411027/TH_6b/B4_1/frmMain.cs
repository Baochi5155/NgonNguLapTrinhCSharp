using B4;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace B4_1
{
    public partial class frmMain : Form
    {
        private SqlConnection connsql;

        public frmMain()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LAPTOP-A9QTNVVO; Initial Catalog=TH_6b; Integrated Security=True; TrustServerCertificate=True";
            connsql = new SqlConnection(connectionString);
        }

        // 1. Chức năng Tạo tồn kho
        private void btnTaoTonKho_Click(object sender, EventArgs e)
        {
            string ngayHienTai = DateTime.Now.ToString("yyyy-MM-dd");

            try
            {
                if (connsql.State == ConnectionState.Closed) connsql.Open();

                string checkQuery = "SELECT COUNT(*) FROM TONKHO WHERE NgayTon = '" + ngayHienTai + "'";
                SqlCommand checkCmd = new SqlCommand(checkQuery, connsql);
                int countToday = (int)checkCmd.ExecuteScalar();

                if (countToday > 0)
                {
                    MessageBox.Show("Ngày hôm nay (" + ngayHienTai + ") đã tạo tồn kho rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (connsql.State == ConnectionState.Open) connsql.Close();
                    return;
                }

                string insertTonQuery = @"
                    INSERT INTO TONKHO (MaSP, NgayTon, SLDau, SLNhap, SLBan)
                    SELECT sp.MaSP, '" + ngayHienTai + @"', 
                           ISNULL(tkLast.SLDau + tkLast.SLNhap - tkLast.SLBan, 0) AS SLTonMoi,
                           0 AS SLNhapMoi,
                           0 AS SLBanMoi
                    FROM SANPHAM sp
                    OUTER APPLY (
                        SELECT TOP 1 SLDau, SLNhap, SLBan 
                        FROM TONKHO tk 
                        WHERE tk.MaSP = sp.MaSP AND tk.NgayTon < '" + ngayHienTai + @"'
                        ORDER BY tk.NgayTon DESC
                    ) tkLast";

                SqlCommand cmdInsert = new SqlCommand(insertTonQuery, connsql);
                int rows = cmdInsert.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open) connsql.Close();

                MessageBox.Show("Đã tạo xong dữ liệu tồn kho cho ngày " + ngayHienTai + " cho " + rows + " sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo tồn kho: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Mở Form Thêm sản phẩm
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            pnlCenter.Visible = false; // Ẩn panel trung tâm

            frmThemSP frm = new frmThemSP();
            frm.MdiParent = this;
            frm.FormClosed += (s, args) =>
            {
                if (this.MdiChildren.Length <= 1) pnlCenter.Visible = true;
            };
            frm.Show();
        }

        // 3. Mở Form Bán hàng
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            pnlCenter.Visible = false; // Ẩn panel trung tâm

            frmBanHang frm = new frmBanHang();
            frm.MdiParent = this;
            frm.FormClosed += (s, args) =>
            {
                if (this.MdiChildren.Length <= 1) pnlCenter.Visible = true;
            };
            frm.Show();
        }

        // 4. Nút Trang chủ
        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            pnlCenter.Visible = true;
        }
    }
}