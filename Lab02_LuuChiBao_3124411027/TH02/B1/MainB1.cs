using System;
namespace B1
{
    //Sử dụng internal để giới hạn việc truy cập ngoài B1
    internal class MainB1
    {
        public void Menu()
        {
            int enter;
            bool continuePro = true;

            do
            {
                Console.WriteLine("Menu:\n");
                Console.WriteLine("1. Student");
                Console.WriteLine("2. Point");
                Console.WriteLine("3. Person");
                Console.WriteLine("4. Fraction");
                Console.WriteLine("5. Monomial");
                Console.WriteLine("0. End");
                Console.Write("Enter: ");

                //Kiểm tra nếu nhập sai định dạng thì cho nhập lại ngay
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
                        new Student().MainB1();
                        break;
                    case 2:
                        new Point().MainB1();
                        break;
                    case 3:
                        new Person().MainB1();
                        break;
                    case 4:
                        new Fraction().MainB1();
                        break;
                    case 5:
                        new Monomial().MainB1();
                        break;
                    case 0:
                        Console.WriteLine("End program.");
                        return; //Thoát Menu và kết thúc chương trình
                    default:
                        Console.WriteLine("Invalid value. Input again:\n");
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
                        Console.WriteLine("End program");
                        break;
                    }
                    else if (next == 'Y')
                    {
                        continuePro = true;
                        break;
                    }
                    else Console.WriteLine("Invalid choice! Please press only 'Y' or 'N'.");
                } while (true);
            } while (continuePro);
        }
        public static void Main(string[] str)
        {
            MainB1 menu = new MainB1();
            menu.Menu();
        }
    }
}