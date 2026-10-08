using System;
using System.Windows.Forms;

namespace B2_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy đúng Form frmDangKyTaiKhoan
            Application.Run(new frmDangKyTaiKhoan());
        }
    }
}