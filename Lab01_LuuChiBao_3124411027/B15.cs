using System;
using System.Collections.Generic;

namespace B15
{
    public class b15
    {
        // Khởi tạo mảng rỗng để tránh cảnh báo null
        private int[] arr = Array.Empty<int>();
        private int n;

        public void NhapMang()
        {
            Console.Write("Nhap so phan tu n = ");
            n = int.Parse(Console.ReadLine() ?? "0");
            // Cấp phát đúng kích thước n vừa nhập thay vì cố định new int[100]
            arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine() ?? "0");
            }
        }

        public void InMang(int[] a)
        {
            foreach (int item in a)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        public void TimMaxMin(out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
        }

        public bool IsPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        // Trả về một mảng int[] các số nguyên tố theo đúng yêu cầu đề bài
        public int[] LayMangSoNguyenTo()
        {
            // Dùng List để gom các số nguyên tố vì chưa biết trước số lượng
            List<int> primeList = new();
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(arr[i]))
                {
                    primeList.Add(arr[i]);
                }
            }
            // Chuyển toàn bộ List về mảng int[]
            return primeList.ToArray();
        }

        public void Run()
        {
            NhapMang();
            Console.Write("\nMang vua nhap: ");
            InMang(arr);

            TimMaxMin(out int max, out int min);
            Console.WriteLine("Phan tu lon nhat (Max) = {0}", max);
            Console.WriteLine("Phan tu nho nhat (Min) = {0}", min);

            int[] primes = LayMangSoNguyenTo();
            Console.Write("Cac so nguyen to trong mang: ");
            if (primes.Length > 0)
                InMang(primes);
            else
                Console.WriteLine("Khong co so nguyen to nao.");
        }

        public static void Main(string[] args)
        {
            b15 app = new();
            app.Run();
        }
    }
}