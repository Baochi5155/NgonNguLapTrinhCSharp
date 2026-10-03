using System;

namespace B9
{
    public class b9
    {
        // Từ khóa out cho phép trả về đồng thời nhiều giá trị, bên trong hàm bắt buộc phải gán giá trị cho chúng
        public void FindMinMax(float a, float b, float c, out float max, out float min)
        {
            max = a;
            min = a;

            if (b > max) max = b;
            if (c > max) max = c;

            if (b < min) min = b;
            if (c < min) min = c;
        }

        public void Run()
        {
            Console.Write("Nhap so thuc a: ");
            float a = float.Parse(Console.ReadLine()!);
            Console.Write("Nhap so thuc b: ");
            float b = float.Parse(Console.ReadLine()!);
            Console.Write("Nhap so thuc c: ");
            float c = float.Parse(Console.ReadLine()!);

            // Khai báo biến trực tiếp ngay trong lời gọi hàm có tham số out (Inline out variables)
            FindMinMax(a, b, c, out float max, out float min);

            Console.WriteLine("Gia tri lon nhat (Max) = {0}", max);
            Console.WriteLine("Gia tri nho nhat (Min) = {0}", min);
        }

        public static void Main(string[] args)
        {
            b9 cal = new();
            cal.Run();
        }
    }
}