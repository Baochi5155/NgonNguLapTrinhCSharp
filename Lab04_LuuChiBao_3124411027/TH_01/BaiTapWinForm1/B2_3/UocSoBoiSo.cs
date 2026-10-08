using System;

namespace B2_3
{
    public class UocSoBoiSo
    {
        private long _a;
        private long _b;

        public long a
        {
            get => _a;
            set => _a = value;
        }

        public long b
        {
            get => _b;
            set => _b = value;
        }

        public UocSoBoiSo()
        {
            _a = _b = 0;
        }

        public UocSoBoiSo(long a, long b)
        {
            _a = Math.Abs(a);
            _b = Math.Abs(b);
        }

        // Tìm ước số chung lớn nhất bằng thuật toán Euclid
        public long TimUCLN()
        {
            long x = _a;
            long y = _b;

            if (x == 0 && y == 0) return 0; // Không xác định hoặc trả về 0
            if (x == 0) return y;
            if (y == 0) return x;

            while (y != 0)
            {
                long temp = x % y;
                x = y;
                y = temp;
            }
            return x;
        }

        // Tìm bội số chung nhỏ nhất: BCNN(a, b) = (|a * b|) / UCLN(a, b)
        public long TimBCNN()
        {
            if (_a == 0 || _b == 0) return 0;
            long ucln = TimUCLN();
            return (_a / ucln) * _b;
        }
    }
}