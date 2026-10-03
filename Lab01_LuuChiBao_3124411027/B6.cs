using System;

namespace B6
{
    public class b6
    {
        // Phương thức nhận đủ 3 tham số và return kết quả theo yêu cầu
        public int TimMax(int a, int b, int c)
        {
            // Khởi tạo max bằng chính số đầu tiên 'a' thay vì gán max = 0, đảm bảo đúng cả khi cả 3 số đều âm
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }

        public void Run()
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine()!);

            int max = TimMax(a, b, c);
            Console.WriteLine("Gia tri lon nhat trong 3 so la: {0}", max);
        }

        public static void Main(string[] args)
        {
            b6 cal = new();
            cal.Run();
        }
    }
}