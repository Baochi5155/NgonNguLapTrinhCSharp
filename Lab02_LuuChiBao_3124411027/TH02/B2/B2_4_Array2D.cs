using System;
using System.Collections;
namespace B2
{
    public class Array2D
    {
        //Khởi tạo Field
        private ArrayList array;
        private int row;
        private int col;

        //Khởi tạo Default Constructor
        public Array2D()
        {
            array = new ArrayList();
            row = 0;
            col = 0;
        }
        //Khởi tạo Constructor có tham số
        public Array2D(int row, int col)
        {
            this.row = row;
            this.col = col;
            array = new ArrayList(row * col);

            for (int i = 0; i < row * col; i++) // Tạo sẵn các phần tử thực tế để array.Count đủ lớn 
                array.Add(0);
        }
        //Khởi tạo Property
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public int Col
        {
            get { return col; }
            set { col = value; }
        }
        public int this[int i,int j]
        {
            get
            {
                if (i < 0 || i >= row || j < 0 || j >= col) //Kiểm tra kích thước
                    throw new IndexOutOfRangeException("Exceed size."); //Thông báo nếu quá kích thước thì dừng ngay
                int index = i * col + j; //Làm phẳng mảng 1 chiều thành mảng 1 chiều để lưu vào ArrayList
                return (int)array[index]!; //Trả về danh sách và đảm bảo không bị null
            }
            set
            {
                if (i < 0 || i >= row || j < 0 || j >= col)
                    throw new IndexOutOfRangeException("Exceed size.");
                int index = i * col + j;
                array[index] = value;
            }
        }
        //Khởi tạo Methods
        public void Input()
        {
            array.Clear(); //Xóa dữ liệu cũ nếu có 

            Console.Write("Input row=");
            int.TryParse(Console.ReadLine(), out this.row); //Đảm bảo nhập hợp lệ
            Console.Write("Input col=");
            int.TryParse(Console.ReadLine(), out this.col); 
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write("Input arr[{0}][{1}]=", i, j);
                    int.TryParse(Console.ReadLine(), out int val); //Nhập giá trị value và thêm vào Array
                    array.Add(val);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public int Prime(int n)
        {
            if (n < 2) return 1;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return 1;
            }
            return 0;
                
        }
        public void IsPrime()
        {
            Console.WriteLine("Prime number Array:\n");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (Prime(this[i,j]) == 0) //Kiểm tra số nguyên tố
                        Console.Write("[{0,0}] ", this[i,j]); //In ra số nguyên tố thành mảng 2D
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }
        public void Output()
        {
            Console.WriteLine("Array 2D:\n");

            for (int i = 0; i < row; i++) 
            {
                for (int j = 0; j < col; j++) 
                {
                    Console.Write("[{0,0}] ", this[i,j]);
                }
                Console.WriteLine("\n");
            }

            //Gọi lại hàm liệt kê số nguyên tố trong mảng
            IsPrime();
        }
        public void MainB2()
        {
            Input();
            Output();
        }
    }
}