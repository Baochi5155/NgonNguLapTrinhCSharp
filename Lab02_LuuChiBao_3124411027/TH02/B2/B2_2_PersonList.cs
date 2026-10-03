using System;
using System.Collections;
namespace B2
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
        public Person(string id, string name, int yob, int yod)
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
    }
    
    public class PersonList
    {
        //Khởi tạo Field
        private ArrayList personList;

        //Khởi tạo Default Constructor
        public PersonList()
        {
            personList = new ArrayList();
        }
        //Khởi tạo Constructor có tham số
        public PersonList(int a)
        {
            personList = new ArrayList(a);
        }
        //Khởi tạo Property
        public Person this[int index]
        {
            get
            {
                if (index < 0 || index >= personList.Count) //Kiểm tra kích thước
                    throw new IndexOutOfRangeException("Exceed size."); //Thông báo nếu quá kích thước thì dừng ngay
                return (Person)personList[index]!; //Trả về danh sách và đảm bảo không bị null
            }
            set
            {
                if (index < 0 || index >= personList.Count)
                    throw new IndexOutOfRangeException("Exceed size.");
                personList[index] = value;
            }
        }
        //Khởi tạo Methods
        public void InputPersonList()
        {
            Console.Write("Input number person:");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Input inform person {0}:\n", i + 1);
                Person p = new Person();
                p.Input();
                personList.Add(p); //Thêm vào danh sách Person
            }
        }
        public void OutputPersonList()
        {
            Console.WriteLine("Person living list:\n");
            for (int i = 0; i < personList.Count; i++)
            {
                if (this[i].IsLiving())
                {
                    Console.Write("Person {0}:\n", i + 1);
                    this[i].Output(); //Sử dụng Indexer lấy dữ liệu để in ra màn hình những người còn sống
                }       
            }
        }
        public void MainB2()
        {
            InputPersonList();
            OutputPersonList();
        }
    }
}