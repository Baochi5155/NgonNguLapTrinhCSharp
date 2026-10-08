using System;
using System.Windows.Forms;

namespace B2_3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy đúng Form frmUocSoBoiSo
            Application.Run(new frmUocSoBoiSo());
        }
    }
}