using System;
namespace B1
{
	public class Monomial
	{
		//Khởi tạo Field
		private int n;
		private float a,x;

		//Khởi tạo Default Constructor 
		public Monomial()
		{
			n = 0;
			a = 0;
			x = 0;
		}
		//Khởi tạo Construtor chứa tham số
		public Monomial(int n, float a, float x)
		{
			this.n = n;
			this.a = a;
			this.x = x;
		}
		//Khởi tạo Property
		public int N
		{
			get { return n; }
			set { n = value; }
		}
		public float A
		{
			get { return a; }
			set { a = value; }
		}
		public float X
		{
			get { return x; }
			set { x = value; }
		}
		//Khởi tạo Methods
		public void Input()
		{
			Console.WriteLine("Input monomial:\n");
			do
			{
				Console.Write("Input n:");
				int.TryParse(Console.ReadLine(), out this.n);
				if (this.n < 0) Console.WriteLine("n must positive integer.Input again:");
			} while (this.n < 0);
			Console.Write("Input a:");
			float.TryParse(Console.ReadLine(), out this.a);
			Console.Write("Input x:");
			float.TryParse(Console.ReadLine(), out this.x);
			Console.WriteLine("\n");
		}
		//Hàm tính giá trị đơn thức P(x)
		public void CalMonomial()
		{
			double P = A * Math.Pow(X, N);
			Console.WriteLine("Value P(x) = {0}", P);
		}
		//Hàm tính đạo hàm đơn thức Q(x) = P'(x)
		public void DerivativeMonomial()
		{
			if (n == 0 || A == 0) Console.WriteLine("Derivative Q(x) = P'(x) = 0"); //Kiểm tra nếu n=0 thì đạo hàm bằng 0
			else if (n == 1) Console.WriteLine("Derivative Q(x) = P'(x) = {0}", A); //n=1 thì Q(x)=a
			else if (n == 2) Console.WriteLine("Derivative Q(x) = P'(x) = {0}x", 2 * A);
			else Console.WriteLine("Derivative Q(x) = P'(x) = {0}x^{1}", A * N, N - 1);
		}
		public void Output()
		{
			//Xét các điều kiện để viết gọn biểu thức
			if (n == 0 || a == 0) Console.WriteLine("P(x) = {0}", A);
			else if (n == 1)
			{
				if (a == 1) Console.WriteLine("P(x) = x");
				else if (a == -1) Console.WriteLine("P(x) = -x");
				else Console.WriteLine("P(x) = {0}x", A);
			}
			else
			{
				if (a == 1) Console.WriteLine("P(x) = x^{0}", N);
				else if (a == -1) Console.WriteLine("P(x) = -x^{0}", N);
				else Console.WriteLine("P(x) = {0}x^{1}", A, N);
			}
			//Gọi hàm để thực hiện phép tính
            CalMonomial();
			DerivativeMonomial();
		}
		public void MainB1()
		{
			Input();
			Output();
		}
	}
}