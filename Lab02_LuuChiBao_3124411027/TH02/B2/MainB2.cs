using System;
namespace B2
{
    internal class MainB2
    {
        public void Menu()
        {
            int enter;
            bool continuePro = true;
            do
            {
                Console.WriteLine("Menu:\n");
                Console.WriteLine("1. List Point");
                Console.WriteLine("2. List Person");
                Console.WriteLine("3. Array 1D");
                Console.WriteLine("4. Array 2D");
                Console.WriteLine("5. Polynomial");
                Console.WriteLine("6. Fraction");
                Console.WriteLine("7. Employee");
                Console.WriteLine("0. Exit");
                Console.Write("Enter: ");
                if (!int.TryParse(Console.ReadLine(), out enter))
                {
                    Console.ReadKey();
                    Console.WriteLine("\n");
                    continue;
                }
                Console.WriteLine("\n");
                //Xử lý các lựa chọn
                switch (enter)
                {
                    case 1:
                        new ArrayPoint().MainB2();
                        break;
                    case 2:
                        new PersonList().MainB2();
                        break;
                    case 3:
                        new Array1D().MainB2();
                        break;
                    case 4:
                        new Array2D().MainB2();
                        break;
                    case 5:
                        new Polynomial().MainB2();
                        break;
                    case 6:
                        new FractionList().MainB2();
                        break;
                    case 7:
                        new EmployeeList().MainB2();
                        break;
                    case 0:
                        Console.WriteLine("End program.");
                        return; //Thoát menu kết thúc chương trình
                    default:
                        Console.Write("Invalid value. Input again:");
                        continue; //Nhập số ngoài menu thì chọn lại
                }
                //Chỉ hỏi tiếp tục khi đã chạy xong các case
                char next;
                do
                {
                    Console.Write("\nDo you want to continue? (Y/N): ");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    next = char.ToUpper(keyInfo.KeyChar);
                    Console.WriteLine();

                    if (next == 'N')
                    {
                        continuePro = false;
                        Console.WriteLine("End program.");
                        break;
                    }
                    else if (next == 'Y')
                    {
                        continuePro = true;
                        break;
                    }
                    else Console.WriteLine("Invalid choice! Please press only 'Y' or 'N'.");
                } while (true);
                Console.WriteLine("\n");
            } while (continuePro);
        }
        public static void Main(string[] str)
        {
            MainB2 menu = new MainB2();
            menu.Menu();
        }
    }
}