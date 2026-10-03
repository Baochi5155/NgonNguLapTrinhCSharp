using System;
using System.Collections;
namespace B2
{
    public class Point
    {
        //Khởi tạo Field
        private int x,y;

        //Khởi tạo Default Constructor
        public Point()
        {
            x = 0;
            y = 0;
        }
        //Khởi tạo Constructor chứa tham số
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //Khởi tạo Property
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        //Khởi tạo Methods
        public void InputPoint()
        {
            Console.Write("Input coordinate x=");
            int.TryParse(Console.ReadLine(), out this.x); //Đảm bảo nhập hợp lệ
            Console.Write("Input coordinate y=");
            int.TryParse(Console.ReadLine(), out this.y);
            Console.Write("\n");
        }
        public void OutputPoint()
        {
            Console.WriteLine("Coordinate (x,y)=({0},{1})\n", X, Y);
        }
    }
    public class ArrayPoint
    {
        private ArrayList listPoint;

        //Khởi tạo Default Constructor
        public ArrayPoint()
        {
            listPoint = new ArrayList();
        }
        //Khởi tạo Constructor chứa tham số
        public ArrayPoint(int a)
        {
            listPoint = new ArrayList(a);
        }     
        //Khởi tạo Indexer cho phép truy cập Point thứ i của ArrayList
        public Point this[int index]
        {
            get
            {
                if (index < 0 || index >= listPoint.Count) //Kiểm tra kích thước danh sách
                    throw new IndexOutOfRangeException("Exceed size."); //Dừng ngay nếu ngoài kích thước
                return (Point)listPoint[index]!; //Trả về danh sách và đảm bảo nhập không bị null
            }
            set
            {
                if (index < 0 || index >= listPoint.Count)
                    throw new IndexOutOfRangeException("Exceed size.");
                listPoint[index] = value;
            }
        }

        public void InputListPoint()
        {
            //Nhập số lượng điểm
            Console.Write("Input number point n=");
            int.TryParse(Console.ReadLine(), out int n); //Đảm bảo nhập hợp lệ
            Console.WriteLine();

            //Vòng lặp tạo n điểm và lưu vào danh sách
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Input point {0}:\n", i + 1);
                Point p = new Point();
                p.InputPoint();
                listPoint.Add(p);
            }
        }
        public void OutputListPoint()
        {
            Console.WriteLine("List point:\n");
            for(int i = 0; i < listPoint.Count; i++)
            {
                Console.Write("Point {0}:\n", i + 1);
                this[i].OutputPoint(); //Sử dụng lại Indexer lấy dữ liệu để in ra màn hình
            }
        }
        public void MainB2()
        {
            InputListPoint();
            OutputListPoint();
        }
    }
}