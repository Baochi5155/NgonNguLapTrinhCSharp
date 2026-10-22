using System;
using System.Windows.Forms;

namespace B4_2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form frmListbox
            Application.Run(new frmListbox());
        }
    }
}