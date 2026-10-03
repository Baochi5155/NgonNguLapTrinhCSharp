using System;
using System.Collections;

namespace B3
{
    //Abstract base class
    public abstract class Candidate
    {
        //Khởi tạo Field
        protected string id;
        protected string fullName;
        protected double score1;
        protected double score2;
        protected double score3;

        //Khởi tạo Default Constructor
        public Candidate()
        {
            id = "";
            fullName = "";
            score1 = 0;
            score2 = 0;
            score3 = 0;
        }

        //Khởi tạo Constructor có tham số
        public Candidate(string id, string fullName, double score1, double score2, double score3)
        {
            this.id = id;
            this.fullName = fullName;
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        //Khởi tạo Methods
        public virtual void Input()
        {
            Console.Write("Input candidate ID (SBD): ");
            id = Console.ReadLine() ?? "";

            Console.Write("Input full name: ");
            fullName = Console.ReadLine() ?? "";

            Console.Write("Input score exam 1: ");
            double.TryParse(Console.ReadLine(), out score1);

            Console.Write("Input score exam 2: ");
            double.TryParse(Console.ReadLine(), out score2);

            Console.Write("Input score exam 3: ");
            double.TryParse(Console.ReadLine(), out score3);
        }

        //Phương thức trừu tượng tính tổng điểm
        public abstract double CalculateTotalScore();

        public virtual void Output()
        {
            Console.Write($"SBD: {id}, Name: {fullName}, Total Score: {CalculateTotalScore():0.##}");
        }
    }

    //Lớp thí sinh chuyên
    public class SpecializedCandidate : Candidate
    {
        //Khởi tạo Field
        private double englishScore;

        //Khởi tạo Default Constructor
        public SpecializedCandidate() : base()
        {
            englishScore = 0;
        }

        //Khởi tạo Constructor có tham số
        public SpecializedCandidate(string id, string fullName, double s1, double s2, double s3, double englishScore)
            : base(id, fullName, s1, s2, s3)
        {
            this.englishScore = englishScore;
        }

        //Khởi tạo Methods
        public override void Input()
        {
            base.Input();
            Console.Write("Input English score: ");
            double.TryParse(Console.ReadLine(), out englishScore);
        }

        //Tổng 3 bài lập trình + điểm thưởng Tiếng Anh
        public override double CalculateTotalScore()
        {
            double bonus = 0;
            if (englishScore >= 7 && englishScore <= 8)
            {
                bonus = 1;
            }
            else if (englishScore >= 9 && englishScore <= 10)
            {
                bonus = 2;
            }
            return score1 + score2 + score3 + bonus;
        }

        public override void Output()
        {
            Console.Write("[Specialized] ");
            base.Output();
            Console.WriteLine($", English Score: {englishScore}");
        }
    }

    //Lớp thí sinh siêu cúp
    public class SuperCupCandidate : Candidate
    {
        //Khởi tạo Field
        private double dbScore;

        //Khởi tạo Default Constructor
        public SuperCupCandidate() : base()
        {
            dbScore = 0;
        }

        //Khởi tạo Constructor có tham số
        public SuperCupCandidate(string id, string fullName, double s1, double s2, double s3, double dbScore)
            : base(id, fullName, s1, s2, s3)
        {
            this.dbScore = dbScore;
        }

        //Khởi tạo Methods
        public override void Input()
        {
            base.Input();
            Console.Write("Input Database score (CSDL): ");
            double.TryParse(Console.ReadLine(), out dbScore);
        }

        //Tổng điểm của cả 4 bài thi
        public override double CalculateTotalScore()
        {
            return score1 + score2 + score3 + dbScore;
        }

        public override void Output()
        {
            Console.Write("[Super Cup]   ");
            base.Output();
            Console.WriteLine($", Database Score: {dbScore}");
        }
    }

    //Lớp quản lý cuộc thi
    public class Array1D_B3_6
    {
        //Khởi tạo Field
        private Candidate[] arr;
        private int n;

        //Khởi tạo Default Constructor
        public Array1D_B3_6()
        {
            n = 0;
            arr = new Candidate[0];
        }

        //Khởi tạo Constructor có tham số
        public Array1D_B3_6(int n)
        {
            this.n = n;
            arr = new Candidate[n];
        }

        //Khởi tạo Methods
        public void Input()
        {
            do
            {
                Console.Write("Input number candidate n=");
                int.TryParse(Console.ReadLine(), out this.n); //Đảm bảo nhập hợp lệ
                if (this.n < 0) Console.WriteLine("n must positive integer.Input again:");
            } while (this.n < 0);

            arr = new Candidate[this.n]; //Cấp phát bộ nhớ lại cho danh sách
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nInput candidate [{i + 1}]:");
                Console.WriteLine("1. Specialized Candidate (Chuyen)");
                Console.WriteLine("2. Super Cup Candidate (Sieu cup)");
                Console.Write("Choose candidate type (1 or 2): ");

                int type;
                int.TryParse(Console.ReadLine(), out type);

                if (type == 1)
                {
                    arr[i] = new SpecializedCandidate();
                }
                else
                {
                    arr[i] = new SuperCupCandidate();
                }

                arr[i].Input(); //Nhập các phần tử
            }
            Console.WriteLine();
        }

        public void Output()
        {
            Console.WriteLine("List candidates final score:");
            for (int i = 0; i < n; i++)
            {
                arr[i].Output(); //In danh sách các phần tử
            }
            Console.WriteLine();
        }

        public void MainB3()
        {
            Input();
            Output();
        }
    }
}