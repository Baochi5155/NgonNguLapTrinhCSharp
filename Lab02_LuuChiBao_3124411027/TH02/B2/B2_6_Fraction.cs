using System;
using System.Collections;
namespace B2
{
    public class Fraction
    {
        //Khởi tạo Field
        private int num, den;

        //Khởi tạo Default Constructor 
        public Fraction()
        {
            num = 0;
            den = 1;
        }
        //Khởi tạo Constructor có tham số
        public Fraction(int num, int den)
        {
            this.num = num;
            this.den = den;
            Normalize(); //Gọi hàm đảm bảo luôn rút gọn và đưa dấu âm lên trên tử số
        }
        //Khởi tạo Copy Constructor
        public Fraction(Fraction f)
        {
            this.num = f.num;
            this.den = f.den;
        }
        //Khởi tạo Property
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public int Den
        {
            get { return den; }
            set { if (value != 0) den = value; }
        }
        //Khởi tạo hàm rút gọn phân số
        private static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        //Hàm đưa dấu âm lên trên tử kết hợp rút gọn
        private void Normalize()
        {
            if (Den < 0)
            {
                num = -num;
                den = -den;
            }
            int gcd = GCD(num, den); //Gọi hàm rút gọn
            if (gcd > 1)
            {
                num /= gcd;
                den /= gcd;
            }
        }
        //Hàm cộng 2 phân số
        public Fraction Plus(Fraction f)
        {
            int newNum = Num * f.den + Den * f.num;
            int newDen = Den * f.den;
            return new Fraction(newNum, newDen);
        }
        //Khởi tạo hàm override
        public override string ToString()
        {
            if (Den == 1) return $"{Num}"; //Mẫu =1 thì xuất tử số
            if (Num == 0) return $"0"; //Tử =0 thì phân số =0
            return $"{Num}/{Den}";
        }
    }

    public class FractionList
    {
        //Khởi tạo Field
        private ArrayList fraction;
        private int n;

        //Khởi tạo Default Constructor
        public FractionList()
        {
            fraction=new ArrayList();
            n = 0;
        }

        //Khởi tạo Constructor có tham số
        public FractionList(int n)
        {
            this.n = n;
            fraction = new ArrayList(n);
        }

        //Khởi tạo Property
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public Fraction this[int index]
        {
            get
            {
                if (index < 0 || index >= fraction.Count) //Kiểm tra chỉ số
                    throw new IndexOutOfRangeException("Exceed size."); //Thông báo chỉ số không hợp lệ
                return (Fraction)fraction[index]!; //Trả về danh sách và đảm bảo không bị null
            }
            set
            {
                if (index < 0 || index >= fraction.Count)
                    throw new IndexOutOfRangeException("Exceed size.");
                fraction[index] = value;
            }
        }
        //Khởi tạo Methods
        public void Input()
        {
            fraction.Clear();

            do
            {
                Console.Write("Input number fraction n=");
                int.TryParse(Console.ReadLine(), out this.n);
                if (this.n < 0) Console.WriteLine("n must positive integer.Input again:");
            } while (this.n < 0);
            for(int i = 0; i < n; i++)
            {
                Console.Write("Input numerator{0}=", i + 1);
                int.TryParse(Console.ReadLine(), out int num);

                int den;
                //Nhập và kiểm tra mẫu khác 0
                do
                {
                    Console.Write("Input denomirator{0}=", i + 1);
                    int.TryParse(Console.ReadLine(), out den);
                    if (den == 0) Console.WriteLine("Denomirator must not equal 0.Input again:");
                } while (den == 0);

                Console.WriteLine();
                fraction.Add(new Fraction(num, den)); //Thêm các phần từ vào danh sách
            }
        }

        //Hàm tính tổng n phân số
        public void Sum()
        {
            Fraction sum = new Fraction(0, 1);
            foreach (Fraction f in fraction) //Vòng lặp danh sách
                sum = sum.Plus(f); //Cộng dồn tổng được lấy từ danh sách phân số 
            Console.WriteLine("Sum fraction:{0}\n", sum);
        }
        public void Output()
        {
            Console.WriteLine("List fraction:\n");

            for (int i = 0; i < fraction.Count; i++)
                Console.Write(fraction[i] + (i == fraction.Count - 1 ? "" : ", ")); //In danh sách các phân số 
            Console.WriteLine("\n");
            //Gọi lại hàm Sum
            Sum();
        }
        public void MainB2()
        {
            Input();
            Output();
        }
    }
}