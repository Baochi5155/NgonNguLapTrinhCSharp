using System;
using System.Windows.Forms;

namespace B2_4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy đúng Form frmDaySoTinhTong
            Application.Run(new frmDaySoTinhTong());
        }
    }
}