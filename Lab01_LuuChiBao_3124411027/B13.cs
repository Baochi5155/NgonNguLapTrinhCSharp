using System;

namespace B13
{
    public class SinhVien
    {
        // Mã sinh viên để kiểu string để lưu được các mã chứa cả chữ và số (ví dụ: SV001)
        private string maSV = "";
        private string hoTen = "";
        private string diaChi = "";
        private int namThu; 
        
        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            maSV = Console.ReadLine() ?? "";
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine() ?? "";
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine() ?? "";
            Console.Write("Sinh vien nam thu may: ");
            namThu = int.Parse(Console.ReadLine() ?? "1");
        }

        public void Xuat()
        {
            Console.WriteLine("\n--- THONG TIN SINH VIEN ---");
            Console.WriteLine("Ma SV: {0}", maSV);
            Console.WriteLine("Ho ten: {0}", hoTen);
            Console.WriteLine("Dia chi: {0}", diaChi);
            Console.WriteLine("Sinh vien nam thu: {0}", namThu);
        }

        public static void Main(string[] args)
        {
            SinhVien sv = new();
            sv.Nhap();
            sv.Xuat();
        }
    }
}