using System;
namespace B1
{
    public class Person
    {
        //Khởi tạo Field
        private string id;
        private string name;
        private int yob;
        private int yod;

        //Khởi tạo Default Constructor
        public Person()
        {
            id = "";
            name = "";
            yob = 0;
            yod = 0;
        }
        //Khởi tạo Constructor chứa tham số
        public Person(string id, string name, int yob,int yod)
        {
            this.id = id;
            this.name = name;
            this.yob = yob;
            this.yod = yod;
        }
        //Khởi tạo Copy Constructor
        public Person(Person p)
        {
            this.id = p.id;
            this.name = p.name;
            this.yob = p.yob;
            this.yod = p.yod;
        }
        //Khởi tạo Property
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Yob
        {
            get { return yob; }
            set { yob = value; }
        }
        public int Yod
        {
            get { return yod; }
            set { yod = value; }
        }
        //Khởi tạo Methods
        public void Input()
        {
            Console.WriteLine("Input inform person:\n");
            Console.Write("Input id:");
            Id = Console.ReadLine() ?? "0";
            Console.Write("Input name:");
            Name = Console.ReadLine() ?? "0";
            Console.Write("Input year of birth:");
            int.TryParse(Console.ReadLine(), out this.yob); //Đảm bảo nhập hợp lệ
            Console.Write("Input year of die:");
            int.TryParse(Console.ReadLine(), out this.yod);
            Console.WriteLine("\n");
        }
        public bool IsLiving()
        {
            return Yod == 0; //Kiểm tra nếu không có năm mất thì vẫn còn sống
        }
        public void Output()
        {
            Console.WriteLine("Inform person:\n");
            Console.WriteLine("Id:{0}", Id);
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("Year of birth:{0}", Yob);
            if (IsLiving()) Console.WriteLine("Status living\n\n");
            else Console.WriteLine("Year of die:{0}\n\n", Yod);
        }
        public void MainB1()
        {
            Input();
            Output();
        }
    }
}