using System;

namespace B7
{
    public class b7
    {
        // Sử dụng kiểu trả về bool (true/false) đúng theo tiêu đề "Phương thức bool"
        public bool IsPrime(int n)
        {
            if (n < 2) return false;
            // Chỉ cần duyệt đến căn bậc hai của n để tối ưu thời gian kiểm tra
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public void NumPrime()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine()!);

            // Dùng trực tiếp hàm bool trong câu điều kiện if
            if (IsPrime(n))
                Console.WriteLine("{0} la so nguyen to.", n);
            else
                Console.WriteLine("{0} khong phai la so nguyen to.", n);
        }

        public static void Main(string[] args)
        {
            b7 cal = new();
            cal.NumPrime();
        }
    }
}