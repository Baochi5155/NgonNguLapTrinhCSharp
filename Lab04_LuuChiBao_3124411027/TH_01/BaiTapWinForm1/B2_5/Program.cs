using System;
using System.Windows.Forms;

namespace B2_5
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy đúng Form frmDocSoThanhChu
            Application.Run(new frmDocSoThanhChu());
        }
    }
}