using System;
using System.Windows.Forms;

namespace B3_1 // Thay tên namespace trùng với tên Project của bạn
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form frmChuoi
            Application.Run(new frmChuoi());
        }
    }
}