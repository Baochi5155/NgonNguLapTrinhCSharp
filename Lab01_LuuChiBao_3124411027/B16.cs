using System;

namespace B16
{
    public class b16
    {
        private string[] names = Array.Empty<string>();
        private int n;

        public void Input()
        {
            Console.Write("Nhap so luong nguoi n = ");
            n = int.Parse(Console.ReadLine() ?? "0");
            names = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ho ten nguoi thu {0}: ", i + 1);
                names[i] = Console.ReadLine() ?? "";
            }
        }

        public void SortArray()
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    // string.Compare > 0 nghĩa là names[i] đứng sau names[j] trong bảng chữ cái (sai thứ tự tăng dần A-Z)
                    // CurrentCultureIgnoreCase để so sánh không phân biệt chữ hoa, chữ thường
                    if (string.Compare(names[i], names[j], StringComparison.CurrentCultureIgnoreCase) > 0)
                    {
                        string temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;
                    }
                }
            }
        }

        public void Output()
        {
            SortArray();
            Console.WriteLine("\n--- DANH SACH HO TEN SAU KHI SAP XEP TANG DAN ---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, names[i]);
            }
        }

        public static void Main(string[] args)
        {
            b16 per = new();
            per.Input();
            per.Output();
        }
    }
}