using System;
using System.Collections.Generic;

namespace B17
{
    public class b17
    {
        private int row, col;
        private int[,] arr = new int[0, 0];
        private readonly Random rand = new();

        public void SinhMang()
        {
            Console.Write("Nhap so hang (n): ");
            row = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap so cot (m): ");
            col = int.Parse(Console.ReadLine() ?? "0");
            arr = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    // rand.Next(min, max) chỉ lấy đến max - 1, do đó đặt cận trên là 101 để lấy được cả giá trị 100
                    arr[i, j] = rand.Next(10, 101);
                }
            }
        }

        public void InMang2D()
        {
            Console.WriteLine("\nMa tran A[{0}x{1}]:", row, col);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    // {0,6} định dạng độ rộng mỗi ô là 6 ký tự giúp các cột ma trận thẳng hàng
                    Console.Write("{0,6}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        // Dùng 2 tham số out để phương thức có thể trả về cùng lúc cả 2 mảng kết quả
        public void TachChanLe(out int[] mangChan, out int[] mangLe)
        {
            List<int> dsChan = new();
            List<int> dsLe = new();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (arr[i, j] % 2 == 0)
                        dsChan.Add(arr[i, j]);
                    else
                        dsLe.Add(arr[i, j]);
                }
            }

            // Gán kết quả mảng đã chuyển đổi vào 2 biến tham số out
            mangChan = dsChan.ToArray();
            mangLe = dsLe.ToArray();
        }

        public void InMang1D(int[] a)
        {
            foreach (int item in a)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        public void Run()
        {
            SinhMang();
            InMang2D();

            // Gọi hàm nhận đồng thời 2 mảng tách biệt
            TachChanLe(out int[] chan, out int[] le);

            Console.Write("\nMang cac so chan: ");
            InMang1D(chan);

            Console.Write("Mang cac so le: ");
            InMang1D(le);
        }

        public static void Main(string[] args)
        {
            b17 app = new();
            app.Run();
        }
    }
}