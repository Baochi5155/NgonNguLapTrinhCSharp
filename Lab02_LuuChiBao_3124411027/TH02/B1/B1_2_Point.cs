using System;
namespace B1
{
    public class Point
    {
        //Khởi tạo Field
        private int x1,y1,x2,y2;

        //Khởi tạo Default Constructor
        public Point()
        {
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = 0;
        }
        //Khởi tạo Constructor chứa tham số
        public Point(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        //Khởi tạo Property
        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        //Khởi tạo Methods
        public void Input()
        {
            Console.WriteLine("Input coordinate A:");
            Console.Write("Input coordinate x1=");
            int.TryParse(Console.ReadLine(), out this.x1); //Đảm bảo nhập hợp lệ
            Console.Write("Input coordinate y1=");
            int.TryParse(Console.ReadLine(), out this.y1);
            Console.Write("\n");

            Console.WriteLine("Input coordinate B:");
            Console.Write("Input coordinate x2=");
            int.TryParse(Console.ReadLine(), out this.x2);
            Console.Write("Input coordinate y2=");
            int.TryParse(Console.ReadLine(), out this.y2);
            Console.Write("\n");
        }
        //Phương thức thành viên
        public void DistanceMember()
        {
            double dis = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            Console.WriteLine("Distance member AB={0:F2}\n", dis); //In ra khoảng cách đến số thập phân thứ 2
        }
        //Phương thức tĩnh
        public static void DistanceStatic(Point p)
        {
            double dis = Math.Sqrt(Math.Pow(p.X1 - p.X2, 2) + Math.Pow(p.Y1 - p.Y2, 2));
            Console.WriteLine("Distance static AB={0:F2}\n", dis);
        }
        //Phương thức thành viên
        public void MidPointMember()
        {
            double midX = (X1 + X2) / 2;
            double midY = (Y1 + Y2) / 2;
            Console.WriteLine("Mid point member AB=(x,y)=({0:F2}),({1:F2})\n", midX, midY);
        }
        //Phương thức tĩnh
        public static void MidPointStatic(Point p)
        {
            double midX = (p.X1 + p.X2) / 2;
            double midY = (p.Y1 + p.Y2) / 2;
            Console.WriteLine("Mid point member AB=(x,y)=({0:F2}),({1:F2})\n", midX, midY);
        }
        //Khởi tạo hàm override
        public override string ToString()
        {
            return $"Coordinate A=(x1,y1)=({X1},{Y1})\n"
                 + $"Coordinate B=(x2,y2)=({X2},{Y2})\n";
        }

        public void Output()
        {
            Console.WriteLine(this);
            DistanceMember();
            Point.DistanceStatic(this);
            MidPointMember();
            Point.MidPointStatic(this);
        }
        public void MainB1()
        {
            Input();
            Output();
        }     
    }
}