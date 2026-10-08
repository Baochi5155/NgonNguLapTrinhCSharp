using System;

namespace B4
{
    public class MayTinh
    {
        public static double TinhToan(double a, double b, string phepToan)
        {
            switch (phepToan)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if (b == 0)
                        throw new DivideByZeroException("Không thể chia cho 0");
                    return a / b;
                default:
                    return b;
            }
        }
    }
}