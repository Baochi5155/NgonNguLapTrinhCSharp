using System;
using System.Windows.Forms;

namespace B4_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form chính frmMain
            Application.Run(new frmMain());
        }
    }
}