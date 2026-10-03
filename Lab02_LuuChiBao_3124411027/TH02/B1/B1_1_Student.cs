using System;
namespace B1
{
    public class Student
    {
        //Khởi tạo Field
        private string name = "";
        private int year;

        //Khởi tạo Default Constructor
        public Student()
        {
            name = "";
            year = 0;
        }
        //Khởi tạo Constructor chứa tham số
        public Student(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
        //Khởi tạo Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        //Khởi tạo Methods
        public int CalAge()
        {
            return 2026 - year;
        }
        public void Input()
        {
            Console.Write("Input name student:");
            Name = Console.ReadLine() ?? "0";
            Console.Write("Input year student:");
            int.TryParse(Console.ReadLine(), out this.year); //Đảm bảo nhập hợp lệ
            Console.WriteLine("\n");
        }
        public void Output()
        {
            Console.WriteLine("\nName student:{0}", Name);
            Console.WriteLine("Birth:{0}", Year);
            Console.WriteLine("Age student:{0}\n", CalAge());
        }
        public void MainB1()
        {
            Input();
            Output();
        }
    }
}