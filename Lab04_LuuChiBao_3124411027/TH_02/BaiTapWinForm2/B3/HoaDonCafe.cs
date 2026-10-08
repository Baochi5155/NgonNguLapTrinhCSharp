using System.Collections.Generic;

namespace B3
{
    public class HoaDonCafe
    {
        public string TenKhachHang { get; set; }
        public int SoKhachHang { get; set; }
        public bool LaSinhVien { get; set; }

        public double GiaNuocUong { get; set; }
        public double GiaThucAn { get; set; }

        public HoaDonCafe()
        {
            TenKhachHang = "";
            SoKhachHang = 1;
            LaSinhVien = false;
            GiaNuocUong = 0;
            GiaThucAn = 0;
        }

        // Tính tổng tiền cho nhóm khách
        public double TinhThanhTien()
        {
            // Tiền đồ uống tính theo số lượng khách
            double tongTien = (GiaNuocUong * SoKhachHang) + GiaThucAn;

            // Nếu là sinh viên: giảm giá 20%
            if (LaSinhVien)
            {
                tongTien *= 0.8;
            }

            return tongTien;
        }
    }
}