using System;
namespace B3
{
    internal class MainB3
    {
        public void Menu()
        {
            int enter;
            bool continuePro = true;
            do
            {
                Console.WriteLine("Menu:\n");
                Console.WriteLine("1. Sort Array");
                Console.WriteLine("2. Sort Array Interface");
                Console.WriteLine("3. Sort Array Delegate");
                Console.WriteLine("4. Equaltion ConsoleMenu");
                Console.WriteLine("5. Employee");
                Console.WriteLine("6. Student");
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
                        new Array1D_B3_1().MainB3();
                        break;
                    case 2:
                        new Array1D_B3_2().MainB3();
                        break;
                    case 3:
                        new Array1D_B3_3().MainB3();
                        break;
                    case 4:
                        new Array1D_B3_4().MainB3();
                        break;
                    case 5:
                        new Array1D_B3_5().MainB3();
                        break;
                    case 6:
                        new Array1D_B3_6().MainB3();
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
            MainB3 menu = new MainB3();
            menu.Menu();
        }
    }
}