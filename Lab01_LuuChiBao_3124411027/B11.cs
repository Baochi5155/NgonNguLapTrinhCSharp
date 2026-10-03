using System;

namespace B11
{
    public class b11
    {
        private string str = "";

        public void Input()
        {
            Console.Write("Nhap chuoi s: ");
            str = Console.ReadLine() ?? "";
        }

        public string ReverseString(string s)
        {
            // Đưa về mảng ký tự do kiểu string trong C# là bất biến (immutable)
            char[] arr = s.ToCharArray();

            // Phương thức Array.Reverse đảo ngược mảng tại chỗ (in-place)
            Array.Reverse(arr);

            // Gom các ký tự đã đảo ngược thành chuỗi mới
            return new string(arr);
        }

        public void Output()
        {
            Input();
            string rev = ReverseString(str);
            Console.WriteLine("Chuoi ban dau: {0}", str);
            Console.WriteLine("Chuoi dao nguoc: {0}", rev);
        }

        public static void Main(string[] args)
        {
            b11 app = new();
            app.Output();
        }
    }
}