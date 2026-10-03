using System;

namespace B2
{
    public class b2
    {
        public void Input()
        {
            // Nhắc người dùng nhập họ tên theo định dạng mẫu
            Console.Write("Nhap ho ten cua ban: ");
            string? name = Console.ReadLine();

            // In câu chào mừng kèm họ tên 
            Console.WriteLine("Chao ban {0}!", name);
        }

        public static void Main(string[] args)
        {
            b2 app = new();
            app.Input();
        }
    } 
}