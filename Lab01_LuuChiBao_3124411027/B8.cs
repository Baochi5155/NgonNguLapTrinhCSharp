using System;

namespace B8
{
    public class b8
    {
        // Từ khóa ref truyền địa chỉ ô nhớ, thay đổi trực tiếp giá trị của 2 biến bên ngoài hàm gọi
        public void Swap(ref float a, ref float b)
        {
            float temp = a;
            a = b;
            b = temp;
        }

        public void NumSwap()
        {
            Console.Write("Nhap so thuc a: ");
            float a = float.Parse(Console.ReadLine()!);
            Console.Write("Nhap so thuc b: ");
            float b = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Truoc khi hoan vi: a = {0}, b = {1}", a, b);
            // Khi gọi phương thức có tham số ref, bắt buộc phải truyền kèm từ khóa ref
            Swap(ref a, ref b);
            Console.WriteLine("Sau khi hoan vi:   a = {0}, b = {1}", a, b);
        }

        public static void Main(string[] args)
        {
            b8 cal = new();
            cal.NumSwap();
        }
    }
}