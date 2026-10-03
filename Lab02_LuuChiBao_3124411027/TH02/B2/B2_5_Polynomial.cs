using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
namespace B2
{
    public class Polynomial
    {
        //Khởi tạo Field
        private ArrayList poly;
        private int n;

        //Khởi tạo Defalt Constructor
        public Polynomial()
        {
            poly = new ArrayList();
            poly.Add(0.0);
            n = 0;
        }

        //Khởi tạo Constructor có tham số
        public Polynomial(int n)
        {
            this.n = (n < 0) ? 0 : n; //Kiểm tra tính hợp lệ của bậc đa thức
            poly = new ArrayList();
            for (int i = 0; i <= this.n; i++)
                poly.Add(0.0); //Cấp phát bộ nhớ với số lượng phần tử =0
        }
        //Khởi tạo Property
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public double this[int index]
        {
            get
            {
                if (index < 0 || index > n) //Kiểm tra chỉ số
                    throw new IndexOutOfRangeException("Exceed size."); //Thông báo chỉ số không hợp lệ
                return (double)poly[index]!; //Trả về danh sách và đảm bảo không bị null
            }
            set
            {
                if (index < 0 || index > n)
                    throw new IndexOutOfRangeException("Exceed size.");
                poly[index] = value;
            }
        }
        //Khởi tạo Methods
        public void Input()
        {
            poly.Clear(); //Xóa dữ liệu cũ nếu có 

            do
            {
                Console.Write("Input monomial number n=");
                int.TryParse(Console.ReadLine(), out this.n); //Đảm bảo nhập hợp lệ
                if (this.n < 0) Console.WriteLine("n must positive integer.Input again:");
            } while (this.n < 0);
            Console.WriteLine();

            for (int i = 0; i <= n; i++)  
            {
                Console.Write("Input index a{0} of x^{0}:", i); //Nhập hệ số tương ứng với bậc đa thức
                //Nhập các giá trị và thêm vào Polynomial
                double.TryParse(Console.ReadLine(), out double a);
                poly.Add(a);     
            }
            Console.WriteLine("\n");
        }
        public void SumPolynomial()
        {
            Console.Write("Input x=");
            double.TryParse(Console.ReadLine(), out double x);

            double S = 0;
            for(int i = 0; i <= n; i++)
            {
                double a = (double)poly[i]!; //lấy dữ liệu từ indexer và đẩm bảo không bị null
                S += a * Math.Pow(x, i);
            }
            Console.WriteLine("Sum P(x) = {0}", S);
        }
        public void Output()
        {
            Console.WriteLine("Polynomial:\n");
            Console.Write("P(x) = ");
            bool IsFirst = true;

            for (int i = n; i >= 0; i--)  //Duyệt lùi để in đúng thứ tự bậc giảm dần
            {
                double a = (double)poly[i]!;
                if (a == 0) continue; //Hệ số =0 thì không cần in, tiếp tục vòng lặp
                if (!IsFirst) //Kiểm tra xem có phải hạng tử đầu tiên được in hay không để thêm dấu nối
                {
                    //Xử lý dấu âm hoặc dương
                    if (a > 0) Console.Write(" + ");
                    else
                    {
                        Console.Write(" - ");
                        a = Math.Abs(a); //Lấy trị tuyệt đối để khỏi bị lặp dấu
                    }
                }
                else if (a < 0) //Kiểm tra dấu của số hạng đầu tiên 
                {
                    Console.Write("-");
                    a = Math.Abs(a);
                }
                //In phần biến x và số mũ để đa thức đơn giản hơn
                if (i == 0) Console.Write($"{a}");
                else if (i == 1) Console.Write(a == 1 ? "x" : $"{a}x");
                else Console.Write(a == 1 ? $"x^{i}" : $"{a}x^{i}");
                IsFirst = false; //Đánh dấu xong 1 số hạng
            }

            if (IsFirst) Console.Write("0"); //Nếu toàn bộ biểu thức đề hệ số là 0 thì in P(x)=0
            Console.WriteLine("\n");

            //Gọi hàm để thực hiện phép tính tổng P(x) tại X
            SumPolynomial();
        }
        public void MainB2()
        {
            Input();
            Output();
        }
    }
}