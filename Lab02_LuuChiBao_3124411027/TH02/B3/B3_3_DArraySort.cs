using System;
using System.Collections;

namespace B3
{
    //Khai báo Delegate tổng quát dùng để so sánh 2 phần tử
    //Trả về: > 0 nếu x > y, < 0 nếu x < y, 0 nếu x == y
    public delegate int CustomComparison<T>(T x, T y);

    public class Array1D_B3_3
    {
        //Khởi tạo Field
        private int[] arr;
        private int n;

        //Khởi tạo Default Constructor
        public Array1D_B3_3()
        {
            n = 0;
            arr = new int[0];
        }

        //Khởi tạo Constructor có tham số
        public Array1D_B3_3(int n)
        {
            this.n = n;
            arr = new int[n];
        }

        //Hàm sắp xếp một mảng tổng quát bằng Delegate
        public static void GenericSortByDelegate<T>(T[] array, CustomComparison<T> compare)
        {
            if (array == null || compare == null) return;

            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    // Dùng delegate để so sánh 2 phần tử
                    if (compare(array[i], array[j]) > 0)
                    {
                        // Hoán vị
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        //Hàm so sánh 2 số nguyên để truyền vào Delegate
        private int CompareInt(int a, int b)
        {
            return a.CompareTo(b);
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

            //Gọi thông qua hàm so sánh truyền thống
            GenericSortByDelegate<int>(arr, CompareInt);

            Console.Write("Sort array (via Delegate)= ");
            for (int i = 0; i < n; i++)
                Console.Write("[{0}] ", arr[i]); //In danh sách các phần tử đã sắp xếp
            Console.WriteLine("\n");
        }

        public void MainB3()
        {
            Input();
            Output();
        }
    }
}