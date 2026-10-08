using System;

namespace B2_1
{
    public class PhuongTrinhBacHai
    {
        private double _a;
        private double _b;
        private double _c;

        public double a { get => _a; set => _a = value; }
        public double b { get => _b; set => _b = value; }
        public double c { get => _c; set => _c = value; }

        public PhuongTrinhBacHai()
        {
            _a = _b = _c = 0;
        }

        public PhuongTrinhBacHai(double a, double b)
        {
            _a = a;
            _b = b;
            _c = 0;
        }

        public PhuongTrinhBacHai(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        // Giải phương trình ax + b = 0
        public string GiaiBacNhat()
        {
            if (_a == 0)
            {
                if (_b == 0)
                    return "Phương trình có vô số nghiệm";
                else
                    return "Phương trình vô nghiệm";
            }
            double x = -_b / _a;
            return $"Phương trình có nghiệm x = {x:0.00}";
        }

        // Giải phương trình ax^2 + bx + c = 0
        public string GiaiBacHai()
        {
            if (_a == 0)
            {
                if (_b == 0)
                {
                    if (_c == 0)
                        return "Phương trình có vô số nghiệm";
                    else
                        return "Phương trình vô nghiệm";
                }
                double x = -_c / _b;
                return $"Phương trình có nghiệm x = {x:0.00}";
            }

            double delta = _b * _b - 4 * _a * _c;
            if (delta < 0)
            {
                return "Phương trình vô nghiệm";
            }
            else if (delta == 0)
            {
                double x = -_b / (2 * _a);
                return $"Phương trình có nghiệm kép x1 = x2 = {x:0.00}";
            }
            else
            {
                double x1 = (-_b + Math.Sqrt(delta)) / (2 * _a);
                double x2 = (-_b - Math.Sqrt(delta)) / (2 * _a);
                return $"Phương trình có 2 nghiệm phân biệt:\r\nx1 = {x1:0.00}\r\nx2 = {x2:0.00}";
            }
        }
    }
}