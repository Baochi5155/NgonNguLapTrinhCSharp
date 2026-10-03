using System;

namespace B3
{
    public class b3
    {
        public void calPow()
        {
            // Nhập hai số nguyên x và y 
            Console.Write("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine()!);

            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine()!);

            // Tính lũy thừa x mũ y
            double cal = Math.Pow(x, y);

            // Xuất kết quả theo định dạng
            Console.WriteLine("Ket qua {0} mu {1} la: {2}", x, y, cal);
        }

        public static void Main(string[] args)
        {
            b3 cal = new();
            cal.calPow();
        }
    } 
}