using System.Collections.Generic;
using System.Linq;

namespace B2_4
{
    public class DaySo
    {
        private List<int> _danhSach;

        public List<int> DanhSach
        {
            get => _danhSach;
            set => _danhSach = value;
        }

        public DaySo()
        {
            _danhSach = new List<int>();
        }

        // Thêm một phần tử vào dãy
        public void ThemSo(int so)
        {
            _danhSach.Add(so);
        }

        // Xuất chuỗi các số cách nhau bằng dấu cách
        public string XuatDaySo()
        {
            return string.Join(" ", _danhSach);
        }

        // Tính tổng toàn bộ dãy
        public int TinhTong()
        {
            return _danhSach.Sum();
        }

        // Tính tổng các số chẵn
        public int TinhTongChan()
        {
            return _danhSach.Where(x => x % 2 == 0).Sum();
        }

        // Tính tổng các số lẻ
        public int TinhTongLe()
        {
            return _danhSach.Where(x => x % 2 != 0).Sum();
        }

        // Kiểm tra dãy có phần tử hay chưa
        public bool CoPhanTu()
        {
            return _danhSach.Count > 0;
        }

        // Làm rỗng dãy
        public void XoaDay()
        {
            _danhSach.Clear();
        }
    }
}