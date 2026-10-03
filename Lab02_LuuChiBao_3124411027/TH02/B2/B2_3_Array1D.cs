using System;
using System.Collections;
using System.Collections.Generic;
namespace B2
{
    public class Array1D
    {
        //Khởi tạo Field
        private ArrayList array;

        //Khởi tạo Default Constructor
        public Array1D()
        {
            array = new ArrayList();
            array.Add(0.0);
        }
        //Khởi tạo Constructor có tham số
        public Array1D(int a)
        {
            array = new ArrayList(a);
        }
        //Khởi tạo Property Indexer 
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Count) //Kiểm tra kích thước
                    throw new IndexOutOfRangeException("Exceed size."); //Thông báo nếu quá kích thước thì dừng ngay
                return (int)array[index]!; //Trả về danh sách và đảm bảo không bị null
            }
            set
            {
                if (index < 0 || index >= array.Count)
                    throw new IndexOutOfRangeException("Exceed size.");
                array[index] = value;
            }
        }
        //Khởi tạo Methods
        public void Input()
        {
            array.Clear(); //Xóa dữ liệu cũ nếu có 

            Console.Write("Input number n=");
            int.TryParse(Console.ReadLine(), out int n); //Đảm bảo nhập hợp lệ
            Console.WriteLine();
            for(int i = 0; i < n; i++)
            {
                Console.Write("Input arr[{0}]=", i + 1);
                int.TryParse(Console.ReadLine(), out int val); //Nhập giá trị value và thêm vào Array
                array.Add(val);
            }
            Console.WriteLine();
        }
        public void EvenNum()
        {
            Console.Write("Even number Array=");
            for (int i = 0; i < array.Count; i++)
            {
                if (this[i] % 2 == 0) //Kiểm tra chia hết cho 2
                    Console.Write("[{0}] ", this[i]); //In ra số chẵn thành 1 mảng
            }
            Console.WriteLine();
        }
        public void Output()
        {
            Console.WriteLine("Array 1D:\n");
            Console.Write("Array=");

            for (int i = 0; i < array.Count; i++)
                Console.Write("[{0}] ",this[i]); 
            Console.WriteLine("\n");

            //Gọi lại hàm liệt kê số chẵn trong mảng
            EvenNum();
        }
        public void MainB2()
        {
            Input();
            Output();
        }
    }
}
