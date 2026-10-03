using System;
using System.Collections;
namespace B3
{
    public class Array1D_B3_1
    {
        //Khởi tạo Field
        private int[] arr;
        private int n;

        //Khởi tạo Default Constructor
        public Array1D_B3_1()
        {
            n = 0;
            arr = new int[0];
        }

        //Khởi tạo Constructor có tham số
        public Array1D_B3_1(int n)
        {
            this.n = n;
            arr = new int[n];
        }

        //Khởi tạo Methods
        public void Input()
        {
            do
            {
                Console.Write("Input number n=");
                int.TryParse(Console.ReadLine(), out this.n); //Đảm bảo nhập hợp lệ
                if (this.n < 0) Console.WriteLine("n must positive integer.Input again:");
            } while (this.n < 0);

            arr = new int[this.n]; //Cấp phát bộ nhớ lại cho danh sách
            for (int i = 0; i < n; i++)
            {
                Console.Write("Input array[{0}]=", i + 1);
                int.TryParse(Console.ReadLine(), out arr[i]); //Nhập các phần tử
            }
            Console.WriteLine();
        }
        public void Output()
        {
            Console.Write("List array= ");

            for (int i = 0; i < n; i++)
                Console.Write("[{0}] ", arr[i]); //In danh sách các phần tử
            Console.WriteLine("\n");

            Array.Sort(arr);
            Console.Write("Sort array= ");
            for (int i = 0; i < n; i++)
                Console.Write("[{0}] ", arr[i]); //In danh sách các phần tử được sắp xếp
            Console.WriteLine("\n");
        }
        public void MainB3()
        {
            Input();
            Output();
        }
    }
}
