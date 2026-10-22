using System;
using System.Windows.Forms;

namespace B4_3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form Danh bạ frmDanhBa trong namespace B4_3
            Application.Run(new frmDanhBa());
        }
    }
}