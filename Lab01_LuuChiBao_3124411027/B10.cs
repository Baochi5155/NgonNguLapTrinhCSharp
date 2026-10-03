using System;

namespace B10
{
    public class b10
    {
        private string str = "";

        public void Input()
        {
            Console.Write("Nhap chuoi s: ");
            str = Console.ReadLine() ?? "";
        }

        public bool IsPalindrome()
        {
            // Sử dụng kỹ thuật Two-pointer (2 con trỏ) duyệt đối xứng từ 2 đầu chuỗi
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                // Nếu có bất kỳ cặp ký tự đối diện nào khác nhau, kết luận chuỗi không đối xứng
                if (str[left] != str[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        public void CheckPalindrome()
        {
            Input();
            if (IsPalindrome())
                Console.WriteLine("Chuoi \"{0}\" la chuoi doi xung.", str);
            else
                Console.WriteLine("Chuoi \"{0}\" khong phai la chuoi doi xung.", str);
        }

        public static void Main(string[] args)
        {
            b10 s = new();
            s.CheckPalindrome();
        }
    }
}