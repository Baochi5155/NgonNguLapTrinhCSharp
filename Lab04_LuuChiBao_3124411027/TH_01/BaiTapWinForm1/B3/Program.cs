using System;
using System.Windows.Forms;

namespace B3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form frmBanVeRapChieuBong trong namespace B3
            Application.Run(new frmBanVeRapChieuBong());
        }
    }
}