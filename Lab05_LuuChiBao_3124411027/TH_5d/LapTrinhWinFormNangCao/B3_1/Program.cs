using System;
using System.Windows.Forms;

namespace B3_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form Quản lý học viên trong namespace B3_1
            Application.Run(new frmQuanLyHocVien());
        }
    }
}