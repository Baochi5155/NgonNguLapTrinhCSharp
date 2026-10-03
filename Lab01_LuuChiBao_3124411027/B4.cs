using System;

namespace B4
{
    public class b4
    {
        public void numPowCondition()
        {
            int x, y;

            // Nhập x và lặp lại nếu không phải số nguyên hợp lệ
            Console.Write("Nhap so nguyen x: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Loi: x phai la so nguyen. Vui long nhap lai!");
                Console.Write("Nhap so nguyen x: ");
            }

            // Nhập y và lặp lại nếu không phải số nguyên hợp lệ
            Console.Write("Nhap so nguyen y: ");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Loi: y phai la so nguyen. Vui long nhap lai!");
                Console.Write("Nhap so nguyen y: ");
            }

            // Tính toán và xuất kết quả theo định dạng bài 3
            double cal = Math.Pow(x, y);
            Console.WriteLine("Ket qua {0} mu {1} la: {2}", x, y, cal);
        }

        public static void Main(string[] args)
        {
            b4 cal = new();
            cal.numPowCondition();
        }
    } 
}