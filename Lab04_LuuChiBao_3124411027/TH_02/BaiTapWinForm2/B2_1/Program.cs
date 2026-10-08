using System;
using System.Windows.Forms;

namespace B2_1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy đúng Form frmGiaiPT đã được đổi tên rõ nghĩa
            Application.Run(new frmGiaiPT());
        }
    }
}