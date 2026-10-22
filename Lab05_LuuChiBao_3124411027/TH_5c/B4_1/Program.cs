using System;
using System.Windows.Forms;

namespace B4_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy Form Từ điển Anh - Việt & Việt - Anh
            Application.Run(new frmTuDien());
        }
    }
}