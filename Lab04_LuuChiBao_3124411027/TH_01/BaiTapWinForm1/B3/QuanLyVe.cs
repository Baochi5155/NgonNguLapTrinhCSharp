namespace B3
{
    public class QuanLyVe
    {
        // Xác định giá vé dựa trên số thứ tự ghế (1 - 15)
        public static double LayGiaVe(int soGhe)
        {
            if (soGhe >= 1 && soGhe <= 5)
                return 1000; // Lô A (Hàng 1)
            else if (soGhe >= 6 && soGhe <= 10)
                return 1500; // Lô B (Hàng 2)
            else if (soGhe >= 11 && soGhe <= 15)
                return 2000; // Lô C (Hàng 3)

            return 0;
        }
    }
}