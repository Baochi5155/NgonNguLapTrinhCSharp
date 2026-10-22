using System;
using System.Windows.Forms;

namespace B2_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form Thông tin sinh viên trong namespace B2_1
            Application.Run(new frmThongTinSinhVien());
        }
    }
}