using System;
using System.Windows.Forms;

namespace B1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy đúng Form frmMyProject trong namespace B1
            Application.Run(new frmMyProject());
        }
    }
}