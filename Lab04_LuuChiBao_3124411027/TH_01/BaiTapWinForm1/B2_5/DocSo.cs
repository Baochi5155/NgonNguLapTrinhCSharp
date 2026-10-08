using System;

namespace B2_5
{
    public class DocSo
    {
        private static readonly string[] ChuSo = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

        // Chuyển đổi số từ 1 đến 999 thành chữ
        public static string ChuyenSoThanhChu(int n)
        {
            if (n < 1 || n > 999) return "Số nằm ngoài phạm vi (1 - 999)";

            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int donVi = n % 10;

            string ketQua = "";

            // Xử lý hàng trăm (nếu có 3 chữ số)
            if (tram > 0)
            {
                ketQua += ChuSo[tram] + " Trăm";
            }

            // Xử lý hàng chục
            if (chuc > 1)
            {
                ketQua += (tram > 0 ? " " : "") + ChuSo[chuc] + " Mươi";
            }
            else if (chuc == 1)
            {
                ketQua += (tram > 0 ? " " : "") + "Mười";
            }
            else if (chuc == 0 && tram > 0 && donVi > 0)
            {
                // Khi có hàng trăm và hàng đơn vị nhưng hàng chục bằng 0 (VD: 105 -> Một Trăm Lẻ Năm)
                ketQua += " Lẻ";
            }

            // Xử lý hàng đơn vị
            if (donVi > 0)
            {
                string chuDonVi = ChuSo[donVi];

                if (chuc > 1 && donVi == 1)
                {
                    chuDonVi = "Mốt"; // 21, 31,... -> Hai Mươi Mốt
                }
                else if (chuc >= 1 && donVi == 5)
                {
                    chuDonVi = "Lăm"; // 15, 25,... -> Mười Lăm, Hai Mươi Lăm
                }

                ketQua += (ketQua.Length > 0 ? " " : "") + chuDonVi;
            }

            return ketQua.Trim();
        }
    }
}