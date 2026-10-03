using System;
using System.Collections;
namespace B2
{
    public class Employee
    {
        //Khởi tạo Field
        private string name;
        private double salary;
        private int absent;

        //Khởi tạo Default Constructor
        public Employee()
        {
            name = "";
            salary = 0;
            absent = 0;
        }

        //Khởi tạo Constructor có tham số
        public Employee(string name, double salary,int absent)
        {
            this.name = name;
            this.salary = salary;
            this.absent = absent;
        }

        //Khởi tạo Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int Absent
        {
            get { return absent; }
            set { absent = value; }
        }

        //Khởi tạo Methods
        public void Input()
        {
            Console.Write("Input name:");
            name = Console.ReadLine() ?? "0";
            Console.Write("Input salary:");
            double.TryParse(Console.ReadLine(), out this.salary); //Đảm bảo nhập hợp lệ
            Console.Write("Input absent:");
            int.TryParse(Console.ReadLine(), out this.absent);
            Console.WriteLine();
        }

        //Hàm tính lương nhân viên
        public double EmpSalary()
        {
            double result = Salary - 100000 * Absent;
            return result;
        }
        public void Output()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Salary:{0} VND", Salary);
            Console.WriteLine("Absent:{0}", Absent);
            Console.WriteLine("Employee salary:{0} VND", EmpSalary());
            Console.WriteLine();
        }  
    }
    public class EmployeeList
    {
        //Khởi tạo Field
        private ArrayList emp;
        private int n;

        //Khởi tạo Default Constructor
        public EmployeeList() 
        {
            emp = new ArrayList();
            n = 0;
        }

        //Khởi tạo Constructor có tham số
        public EmployeeList(int n)
        {
            this.n = n;
            emp = new ArrayList(n);
        }

        //Khởi tạo Property
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public Employee this[int index]
        {
            get
            {
                if (index < 0 || index >= emp.Count) //Kiểm tra chỉ số
                    throw new IndexOutOfRangeException("Exceed size."); //Thông báo chỉ số không hợp lệ
                return (Employee)emp[index]!; //Trả về danh sách và đảm bảo không bị null
            }
            set
            {
                if (index < 0 || index >= emp.Count)
                    throw new IndexOutOfRangeException("Exceed size.");
                emp[index] = value;
            }
        }
      
        //Khởi tạo Methods
        public void InputList()
        {
            emp.Clear();

            do
            {
                Console.Write("Input number employee n=");
                int.TryParse(Console.ReadLine(), out this.n);
                if (this.n < 0) Console.WriteLine("n must positive integer.Input again:"); //Đảm bảo nhập n không âm
            } while (this.n < 0);
            Console.WriteLine();

            Console.WriteLine("Input inform employee:\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input employee{0}:", i + 1);
                Employee e = new Employee();
                e.Input();
                emp.Add(e); //Thêm các phần từ vào danh sách
            }
        }

        //Hàm tính tổng lương nhân viên của một phòng ban
        public void SumSalary()
        {
            double sum = 0;
            foreach(Employee e in emp) //Vòng lặp danh sách
                sum += e.EmpSalary(); //Cộng dồn từ danh sách
            Console.WriteLine("Sum salary:{0}\n", sum);
        }
        public void OutputList()
        {
            Console.WriteLine("Employee list:\n");
            for(int i = 0;i < n; i++)
            {
                Console.WriteLine("Employee{0}:", i + 1);
                this[i].Output(); //Lấy dữ liệu lại từ indexer
            }
            Console.WriteLine("\n");
            //Gọi lại hàm tính tổng lương phòng ban
            SumSalary();
        }
        public void MainB2()
        {
            InputList();
            OutputList();
        }
    }
}
