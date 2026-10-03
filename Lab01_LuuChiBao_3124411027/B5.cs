using System;

namespace B5
{
    public class b5
    {
        private float x = 0, y = 0;

        public void InputRealNumber()
        {
            Console.Write("Nhap x: ");
            x = float.Parse(Console.ReadLine()!);
            Console.Write("Nhap y: ");
            y = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Da nhap: x = {0}, y = {1}\n", x, y);
        }

        public void CalPow()
        {
            double cal = Math.Pow(x, y);
            Console.WriteLine("Ket qua {0}^{1} = {2}\n", x, y, cal);
        }

        public void CalRoot()
        {
            // Kiểm tra điều kiện x >= 0 trước khi tính căn bậc hai để tránh sinh ra lỗi NaN (Not a Number)
            if (x >= 0)
                Console.WriteLine("Can bac 2 cua x ({0}) la: {1}", x, Math.Sqrt(x));
            else
                Console.WriteLine("Khong the tinh can bac 2 cua x vi x < 0");

            // Bổ sung xử lý tính căn bậc hai cho y theo đúng đề bài yêu cầu
            if (y >= 0)
                Console.WriteLine("Can bac 2 cua y ({0}) la: {1}", y, Math.Sqrt(y));
            else
                Console.WriteLine("Khong the tinh can bac 2 cua y vi y < 0");

            Console.WriteLine();
        }

        public void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");

                // Kiểm tra nếu người dùng vô tình gõ chữ thay vì số
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Vui long nhap so tu 1 den 4!\n");
                    // Bỏ qua các dòng lệnh bên dưới và quay lại đầu vòng lặp do-while
                    continue;
                }

                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        InputRealNumber();
                        break;
                    case 2:
                        CalPow();
                        break;
                    case 3:
                        CalRoot();
                        break;
                    case 4:
                        Console.WriteLine("Ket thuc chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai!\n");
                        break;
                }
            } while (choice != 4);
        }

        public static void Main(string[] args)
        {
            b5 app = new();
            app.Menu();
        }
    }
}