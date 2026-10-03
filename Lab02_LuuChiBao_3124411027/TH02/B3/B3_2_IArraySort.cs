using System;
using System.Collections;

namespace B3
{
    //Interface mô phỏng dùng để so sánh 2 phần tử 
    public interface ICustomComparer<T>
    {
        int Compare(T x, T y);
    }

    //Bộ so sánh mặc định cho số nguyên
    public class IntComparer : ICustomComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y); //Trả về < 0 nếu x < y, 0 nếu x == y, > 0 nếu x > y
        }
    }

    public class Array1D_B3_2
    {
        //Khởi tạo Field
        private int[] arr;
        private int n;

        //Khởi tạo Default Constructor
        public Array1D_B3_2()
        {
            n = 0;
            arr = new int[0];
        }

        //Khởi tạo Constructor có tham số
        public Array1D_B3_2(int n)
        {
            this.n = n;
            arr = new int[n];
        }

        //Hàm sắp xếp mảng tổng quát bằng Interface
        public static void GenericSort<T>(T[] array, ICustomComparer<T> comparer)
        {
            if (array == null || comparer == null) return;

            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    //Dùng interface để so sánh 2 phần tử
                    if (comparer.Compare(array[i], array[j]) > 0)
                    {
                        // Hoán vị nếu đứng sai thứ tự
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
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

            //Gọi phương thức sắp xếp tổng quát bằng interface
            GenericSort<int>(arr, new IntComparer());

            Console.Write("Sort array (via Interface)= ");
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