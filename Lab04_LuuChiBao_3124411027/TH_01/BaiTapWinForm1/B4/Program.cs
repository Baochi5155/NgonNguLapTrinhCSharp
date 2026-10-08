using System;
using System.Windows.Forms;

namespace B4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy đúng Form frmMayTinhBoTui
            Application.Run(new frmMayTinhBoTui());
        }
    }
}