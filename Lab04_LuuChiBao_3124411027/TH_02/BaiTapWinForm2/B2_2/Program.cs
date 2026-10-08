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

            // Chạy Form Mảng Số Nguyên
            Application.Run(new frmMangSoNguyen());
        }
    }
}