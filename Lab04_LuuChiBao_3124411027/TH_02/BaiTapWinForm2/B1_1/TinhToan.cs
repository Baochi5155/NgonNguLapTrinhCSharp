using System;

namespace B1_1
{
    public class TinhToan
    {
        private float _a;
        private float _b;

        public float a
        {
            get { return _a; }
            set { _a = value; }
        }

        public float b
        {
            get { return _b; }
            set { _b = value; }
        }

        public TinhToan()
        {
            a = b = 0;
        }

        public TinhToan(float a, float b)
        {
            _a = a;
            _b = b;
        }

        public float Cong()
        {
            return _a + _b;
        }

        public float Tru()
        {
            return _a - _b;
        }

        public float Nhan()
        {
            return _a * _b;
        }

        public float Chia()
        {
            return _a / _b;
        }
    }
}