using System;
using System.Collections.Generic;
using System.Linq;

namespace B2_2
{
    public class MangSoNguyen
    {
        private List<int> a;

        public List<int> A
        {
            get => a;
            set => a = value;
        }

        public MangSoNguyen()
        {
            a = new List<int>();
        }

        public MangSoNguyen(List<int> list)
        {
            a = new List<int>(list);
        }

        // Tách chuỗi người dùng nhập (phân cách bằng dấu cách) thành danh sách số nguyên
        public static bool TryParse(string input, out MangSoNguyen result)
        {
            result = new MangSoNguyen();
            if (string.IsNullOrWhiteSpace(input)) return false;

            string[] tokens = input.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var token in tokens)
            {
                if (int.TryParse(token, out int val))
                {
                    result.a.Add(val);
                }
                else
                {
                    return false;
                }
            }
            return result.a.Count > 0;
        }

        // Xuất mảng thành chuỗi phân cách bởi dấu cách
        public string XuatChuoi()
        {
            return string.Join(" ", a);
        }

        // 1. Sắp xếp
        public void SapXepTang() => a.Sort();
        public void SapXepGiam() => a.Sort((x, y) => y.CompareTo(x));

        // 2. Tìm kiếm
        public int TimViTriTheoGiaTri(int giaTri) => a.IndexOf(giaTri);
        public int TimGiaTriTheoViTri(int viTri)
        {
            if (viTri >= 0 && viTri < a.Count)
                return a[viTri];
            throw new ArgumentOutOfRangeException();
        }

        // 3. Xóa
        public bool XoaTheoGiaTri(int giaTri) => a.Remove(giaTri);
        public bool XoaTheoViTri(int viTri)
        {
            if (viTri >= 0 && viTri < a.Count)
            {
                a.RemoveAt(viTri);
                return true;
            }
            return false;
        }

        // 4. Thêm
        public bool ChenViTri(int viTri, int giaTri)
        {
            if (viTri >= 0 && viTri <= a.Count)
            {
                a.Insert(viTri, giaTri);
                return true;
            }
            return false;
        }

        // 5. Tổng
        public int TongMang() => a.Sum();
        public int TongChan() => a.Where(x => x % 2 == 0).Sum();
        public int TongLe() => a.Where(x => x % 2 != 0).Sum();

        // 6. Max / Min
        public int Max() => a.Max();
        public int Min() => a.Min();

        // 7. Thay thế
        public bool ThayTheTheoGiaTri(int giaTriCu, int giaTriMoi)
        {
            int idx = a.IndexOf(giaTriCu);
            if (idx != -1)
            {
                a[idx] = giaTriMoi;
                return true;
            }
            return false;
        }

        public bool ThayTheTheoViTri(int viTri, int giaTriMoi)
        {
            if (viTri >= 0 && viTri < a.Count)
            {
                a[viTri] = giaTriMoi;
                return true;
            }
            return false;
        }
    }
}