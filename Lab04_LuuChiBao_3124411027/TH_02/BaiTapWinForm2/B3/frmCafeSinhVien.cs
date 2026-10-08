using System;
using System.Windows.Forms;

namespace B3
{
    public partial class frmCafeSinhVien : Form
    {
        private int tongSoKhach = 0;
        private double tongTienTatCa = 0;

        private int soKhachHienTai = 0;
        private double tienHienTai = 0;

        public frmCafeSinhVien()
        {
            InitializeComponent();
        }

        // 1. Form_Load: Con trỏ ở ô tên KH, các button mờ đi
        private void frmCafeSinhVien_Load(object sender, EventArgs e)
        {
            txt_TenKH.Focus();
            btn_TinhTien.Enabled = false;
            btn_NhapLai.Enabled = false;
            btn_ThanhToan.Enabled = false;
        }

        // 2. Chặn Textbox Số khách hàng chỉ cho nhập số
        private void txt_SoKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // 3. Khi nhập đầy đủ thông tin thì nút Tính tiền sáng lên
        private void ThongTin_Changed(object sender, EventArgs e)
        {
            bool coChonNuoc = rdo_CafeDen.Checked || rdo_CafeDa.Checked ||
                              rdo_CafeSua.Checked || rdo_CafeSuaDa.Checked || rdo_CafeKem.Checked;

            bool hopLe = !string.IsNullOrWhiteSpace(txt_TenKH.Text) &&
                         !string.IsNullOrWhiteSpace(txt_SoKH.Text) &&
                         int.TryParse(txt_SoKH.Text.Trim(), out int sk) && sk > 0 &&
                         coChonNuoc;

            btn_TinhTien.Enabled = hopLe;
        }

        // 4. Nút Tính tiền
        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            HoaDonCafe hd = new HoaDonCafe();
            hd.TenKhachHang = txt_TenKH.Text.Trim();
            hd.SoKhachHang = int.Parse(txt_SoKH.Text.Trim());
            hd.LaSinhVien = chk_SinhVien.Checked;

            // Đồ uống
            if (rdo_CafeDen.Checked) hd.GiaNuocUong = 20000;
            else if (rdo_CafeDa.Checked) hd.GiaNuocUong = 25000;
            else if (rdo_CafeSua.Checked) hd.GiaNuocUong = 25000;
            else if (rdo_CafeSuaDa.Checked) hd.GiaNuocUong = 30000;
            else if (rdo_CafeKem.Checked) hd.GiaNuocUong = 35000;

            // Thức ăn
            double tongThucAn = 0;
            if (chk_BanhMyTrung.Checked) tongThucAn += 15000;
            if (chk_BanhMyCa.Checked) tongThucAn += 15000;
            if (chk_MyTomTrung.Checked) tongThucAn += 20000;
            if (chk_MyXaoBo.Checked) tongThucAn += 30000;
            if (chk_MyCay.Checked) tongThucAn += 50000;
            hd.GiaThucAn = tongThucAn;

            tienHienTai = hd.TinhThanhTien();
            soKhachHienTai = hd.SoKhachHang;

            string thongBao = $"Khách hàng: {hd.TenKhachHang}\n" +
                              $"Số khách: {hd.SoKhachHang}\n" +
                              $"Đối tượng: {(hd.LaSinhVien ? "Sinh viên (Giảm 20%)" : "Khách thường")}\n" +
                              $"Tổng tiền thanh toán: {tienHienTai:N0} VNĐ";

            MessageBox.Show(thongBao, "Hóa đơn tính tiền", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_NhapLai.Enabled = true;
            btn_ThanhToan.Enabled = true;
            btn_TinhTien.Enabled = false;
        }

        // 5. Nút Nhập lại: quay về trạng thái ban đầu, nút này mờ đi
        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_TenKH.Clear();
            txt_SoKH.Clear();
            chk_SinhVien.Checked = false;

            rdo_CafeDen.Checked = false;
            rdo_CafeDa.Checked = false;
            rdo_CafeSua.Checked = false;
            rdo_CafeSuaDa.Checked = false;
            rdo_CafeKem.Checked = false;

            chk_BanhMyTrung.Checked = false;
            chk_BanhMyCa.Checked = false;
            chk_MyTomTrung.Checked = false;
            chk_MyXaoBo.Checked = false;
            chk_MyCay.Checked = false;

            btn_TinhTien.Enabled = false;
            btn_NhapLai.Enabled = false;
            btn_ThanhToan.Enabled = false;

            txt_TenKH.Focus();
        }

        // 6. Nút Thanh toán: tích lũy tổng số khách & tiền, sẵn sàng cho nhóm mới
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            tongSoKhach += soKhachHienTai;
            tongTienTatCa += tienHienTai;

            txt_TongKH.Text = tongSoKhach.ToString();
            txt_TongTien.Text = $"{tongTienTatCa:N0} VNĐ";

            btn_ThanhToan.Enabled = false;

            btn_NhapLai_Click(sender, e);
        }

        // 7. Nút Thoát
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCafeSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình hay không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}