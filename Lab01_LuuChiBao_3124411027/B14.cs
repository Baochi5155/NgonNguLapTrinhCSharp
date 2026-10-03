using System;

namespace B14
{
    public class NhanVien
    {
        private string hoTen = "";
        private double mucLuong;
        private int soNgayVang;

        public void Nhap()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            hoTen = Console.ReadLine() ?? "";
            Console.Write("Nhap muc luong: ");
            mucLuong = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap so ngay vang: ");
            soNgayVang = int.Parse(Console.ReadLine() ?? "0");
        }

        // Tách riêng phương thức tính toán và trả về giá trị thay vì in trực tiếp
        public double TinhLuong()
        {
            double luongThucLinh = mucLuong - (soNgayVang * 100000);
            return luongThucLinh > 0 ? luongThucLinh : 0;
        }

        public void Xuat()
        {
            Console.WriteLine("\n--- THONG TIN NHAN VIEN ---");
            Console.WriteLine("Ho ten: {0}", hoTen);
            // Định dạng {0:N0} giúp tự thêm dấu phân tách hàng nghìn (ví dụ: 10,000,000)
            Console.WriteLine("Muc luong goc: {0:N0} VND", mucLuong);
            Console.WriteLine("So ngay vang: {0}", soNgayVang);
            Console.WriteLine("Luong thuc linh: {0:N0} VND", TinhLuong());
        }

        public static void Main(string[] args)
        {
            NhanVien nv = new();
            nv.Nhap();
            nv.Xuat();
        }
    }
}