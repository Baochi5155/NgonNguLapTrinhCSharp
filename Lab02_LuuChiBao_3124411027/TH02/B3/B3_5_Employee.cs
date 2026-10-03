using System;
using System.Collections;

namespace B3
{
    //Lớp trừu tượng nhân viên
    public abstract class Employee
    {
        // Khởi tạo Field
        protected string id;
        protected string fullName;

        //Khởi tạo Default Constructor
        public Employee()
        {
            id = "";
            fullName = "";
        }

        //Khởi tạo Constructor có tham số
        public Employee(string id, string fullName)
        {
            this.id = id;
            this.fullName = fullName;
        }

        //Khởi tạo Methods
        public virtual void Input()
        {
            Console.Write("Input employee ID: ");
            id = Console.ReadLine() ?? "";

            Console.Write("Input full name: ");
            fullName = Console.ReadLine() ?? "";
        }

        //Phương thức trừu tượng tính lương
        public abstract double CalculateSalary();

        public virtual void Output()
        {
            Console.Write($"ID: {id}, Name: {fullName}, Salary: {CalculateSalary():N0} VND");
        }
    }

    //Nhân viên kinh doanh
    public class SalesEmployee : Employee
    {
        //Khởi tạo Field
        private double baseSalary;
        private int contractsCount;

        //Khởi tạo Default Constructor
        public SalesEmployee() : base()
        {
            baseSalary = 0;
            contractsCount = 0;
        }

        //Khởi tạo Constructor có tham số
        public SalesEmployee(string id, string fullName, double baseSalary, int contractsCount)
            : base(id, fullName)
        {
            this.baseSalary = baseSalary;
            this.contractsCount = contractsCount;
        }

        //Khởi tạo Methods
        public override void Input()
        {
            base.Input();

            Console.Write("Input base salary: ");
            double.TryParse(Console.ReadLine(), out baseSalary);

            Console.Write("Input signed contracts: ");
            int.TryParse(Console.ReadLine(), out contractsCount);
        }

        //Hàm tính lương
        public override double CalculateSalary()
        {
            return baseSalary + (contractsCount * 500000.0);
        }

        public override void Output()
        {
            Console.Write("[Sales] ");
            base.Output();
            Console.WriteLine();
        }
    }

    //Nhân viên sản xuất
    public class ProductionEmployee : Employee
    {
        //Khởi tạo Field
        private int productsCount;

        //Khởi tạo Default Constructor
        public ProductionEmployee() : base()
        {
            productsCount = 0;
        }

        //Khởi tạo Constructor có tham số
        public ProductionEmployee(string id, string fullName, int productsCount)
            : base(id, fullName)
        {
            this.productsCount = productsCount;
        }

        //Khởi tạo Methods
        public override void Input()
        {
            base.Input();

            Console.Write("Input number of products: ");
            int.TryParse(Console.ReadLine(), out productsCount);
        }

        //Hàm tính lương
        public override double CalculateSalary()
        {
            double salary = productsCount * 1000.0;
            if (productsCount > 3000)
            {
                salary += salary * 0.05;
            }
            return salary;
        }

        public override void Output()
        {
            Console.Write("[Production] ");
            base.Output();
            Console.WriteLine();
        }
    }

    public class Array1D_B3_5
    {
        //Khởi tạo Field
        private Employee[] arr;
        private int n;

        //Khởi tạo Default Constructor
        public Array1D_B3_5()
        {
            n = 0;
            arr = new Employee[0];
        }

        //Khởi tạo Constructor có tham số
        public Array1D_B3_5(int n)
        {
            this.n = n;
            arr = new Employee[n];
        }

        //Khởi tạo Methods
        public void Input()
        {
            do
            {
                Console.Write("Input number employee n=");
                int.TryParse(Console.ReadLine(), out this.n); //Đảm bảo nhập hợp lệ
                if (this.n < 0) Console.WriteLine("n must positive integer.Input again:");
            } while (this.n < 0);

            arr = new Employee[this.n]; //Cấp phát bộ nhớ lại cho danh sách
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nInput employee [{i + 1}]:");
                Console.WriteLine("1. Sales Employee");
                Console.WriteLine("2. Production Employee");
                Console.Write("Choose employee type (1 or 2): ");

                int type;
                int.TryParse(Console.ReadLine(), out type);

                if (type == 1)
                {
                    arr[i] = new SalesEmployee();
                }
                else
                {
                    arr[i] = new ProductionEmployee();
                }

                arr[i].Input(); //Nhập các phần tử
            }
            Console.WriteLine();
        }

        public void Output()
        {
            Console.WriteLine("List employee salary:");
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