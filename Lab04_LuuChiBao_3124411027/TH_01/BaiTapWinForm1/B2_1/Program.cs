using System;
using System.Windows.Forms;

namespace B2_1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy đúng Form frmCongTruNhanChia
            Application.Run(new frmCongTruNhanChia());
        }
    }
}