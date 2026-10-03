using System;

namespace B12
{
    public class b12
    {
        private string str = "";

        public void Input()
        {
            Console.Write("Nhap chuoi: ");
            str = Console.ReadLine() ?? "";
        }

        public int CountWords(string s)
        {
            // Trả về 0 nếu chuỗi rỗng hoặc chỉ toàn khoảng trắng
            if (string.IsNullOrWhiteSpace(s)) return 0;

            // Trim() bỏ khoảng trắng đầu/cuối chuỗi
            // Split(...) cắt chuỗi theo dấu cách, dấu tab '\t', dấu xuống dòng '\n'
            // StringSplitOptions.RemoveEmptyEntries tự động loại bỏ phần tử rỗng khi người dùng gõ nhiều dấu cách liền nhau
            string[] words = s.Trim().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public void Process()
        {
            Input();
            Console.WriteLine("Chuoi chu thuong: {0}", str.ToLower());
            Console.WriteLine("Chuoi chu hoa: {0}", str.ToUpper());
            Console.WriteLine("So tu trong chuoi: {0}", CountWords(str));
        }

        public static void Main(string[] args)
        {
            b12 app = new();
            app.Process();
        }
    }
}