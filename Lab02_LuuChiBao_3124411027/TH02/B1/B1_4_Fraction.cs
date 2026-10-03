using System;
namespace B1
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
        private static int GCD(int a,int b)
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
        //Khởi tạo hàm override
        public override string ToString()
        {
            if (Den == 1) return $"{Num}"; //Mẫu =1 thì xuất tử số
            if (Num == 0) return $"0"; //Tử =0 thì phân số =0
            return $"{Num}/{Den}\n";
        }
        public void Input(Fraction f2)
        {
            //Nhập phân số thứ nhất và hai đồng thời kiểm tra tính hợp lệ khi nhập
            Console.Write("Input numerator 1:");
            int.TryParse(Console.ReadLine(), out this.num); //Đảm bảo nhập hợp lệ
            do
            {
                Console.Write("Input denominator 1:");
                int.TryParse(Console.ReadLine(), out this.den);
                if (this.den == 0) //Kiểm tra mẫu =0 thì buộc nhập lại
                    Console.WriteLine("Denominatior must not equal 0. Input again:");
            } while (this.den == 0);
            this.Normalize(); //Đảm bảo đơn giản hóa phân số
            Console.WriteLine("\n");

            //Truyền tham số có đầu vào là f2
            Console.Write("Input numerator 2:");
            int.TryParse(Console.ReadLine(), out f2.num);
            do
            {
                Console.Write("Input denominator 2:");
                int.TryParse(Console.ReadLine(), out f2.den);
                if (this.den == 0)
                    Console.WriteLine("Denominatior must differen 0. Input again:");
            } while (this.den == 0);
            f2.Normalize();
            Console.WriteLine("\n");
        }
        //Toán tử một ngôi: +
        public Fraction Positive()
        {
            return new Fraction(Num, Den);
        }
        //Toán tử một ngôi: -
        public Fraction Negative()
        {
            return new Fraction(-Num, Den);
        }
        //Toán tử hai ngôi: +
        public Fraction PlusBinary(Fraction f)
        {
            int newNum = Num * f.den + Den * f.num;
            int newDen = Den * f.den;
            return new Fraction(newNum,newDen);
        }
        //Toán tử hai ngôi: -
        public Fraction MinusBinary(Fraction f)
        {
            int newNum = Num * f.den - Den * f.num;
            int newDen = Den * f.den;
            return new Fraction(newNum, newDen);
        }
        //Toán tử hai ngôi: *
        public Fraction MultiBinary(Fraction f)
        {
            int newNum = Num * f.num;
            int newDen = Den * f.den;
            return new Fraction(newNum, newDen);
        }
        //Toán tử hai ngôi: /
        public Fraction DevideBinary(Fraction f)
        {
            int newNum = Num * f.den;
            int newDen = Den * f.num;
            return new Fraction(newNum, newDen);
        }
        //Toán tử so sánh: >
        public bool GreatBinary(Fraction f)
        {
            return Num * f.den > Den * f.num;
        }
        //Toán tử so sánh: <
        public bool LessBinary(Fraction f)
        {
            return Num * f.den < Den * f.num;
        }
        //Toán tử so sánh: >=
        public bool GreatEqualBinary(Fraction f)
        {
            return Num * f.den >= Den * f.num;
        }
        //Toán tử so sánh: <=
        public bool LessEqualBinary(Fraction f)
        {
            return Num * f.den <= Den * f.num;
        }
        //Toán tử so sánh: =
        public bool EqualBinary(Fraction f)
        {
            return Num * f.den == Den * f.num;
        }
        //Toán tử so sánh: !=
        public bool NotEqualBinary(Fraction f)
        {
            return Num * f.den != Den * f.num;
        }
        public void Output(Fraction f2)
        {
            Console.WriteLine("Fraction 1:{0}",this);
            Console.WriteLine("Fraction 2:{0}\n", f2);

            Console.WriteLine("Positive + :{0}", this.Positive());
            Console.WriteLine("Negative - :{0}\n", this.Negative());

            Console.WriteLine("Plus f1+f2 :{0}", this.PlusBinary(f2));
            Console.WriteLine("Minus f1-f2 :{0}", this.MinusBinary(f2));
            Console.WriteLine("Multi f1*f2 :{0}", this.MultiBinary(f2));
            Console.WriteLine("Devide f1/f2 :{0}\n", this.DevideBinary(f2));

            Console.WriteLine("Great f1>f2 :{0}", this.GreatBinary(f2));
            Console.WriteLine("Less f1<f2 :{0}", this.LessBinary(f2));
            Console.WriteLine("Great equal f1>=f2 :{0}", this.GreatEqualBinary(f2));
            Console.WriteLine("Less equal f1<=f2 :{0}", this.LessEqualBinary(f2));
            Console.WriteLine("Equal f1=f2 :{0}", this.EqualBinary(f2));
            Console.WriteLine("Not Equal f1!=f2 :{0}\n", this.NotEqualBinary(f2));
        }
        public void MainB1()
        {
            //Khởi tạo 2 phân số
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();

            f1.Input(f2);
            f1.Output(f2);
        }
    }
}