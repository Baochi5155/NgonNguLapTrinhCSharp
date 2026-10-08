using System;

namespace B2_1
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
            _a = _b = 0;
        }

        public TinhToan(float a, float b)
        {
            _a = a;
            _b = b;
        }

        public float Cong() => _a + _b;
        public float Tru() => _a - _b;
        public float Nhan() => _a * _b;
        public float Chia() => _a / _b;
    }
}