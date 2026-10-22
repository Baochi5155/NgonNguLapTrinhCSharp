using System;
using System.Windows.Forms;

namespace B2_2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form Quản lý thông tin tài khoản trong namespace B2_2
            Application.Run(new frmQuanLyTaiKhoan());
        }
    }
}