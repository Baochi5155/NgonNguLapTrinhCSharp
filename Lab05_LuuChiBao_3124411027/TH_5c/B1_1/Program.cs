using System;
using System.Windows.Forms;

namespace B1_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form chính frmListBox
            Application.Run(new frmListBox());
        }
    }
}