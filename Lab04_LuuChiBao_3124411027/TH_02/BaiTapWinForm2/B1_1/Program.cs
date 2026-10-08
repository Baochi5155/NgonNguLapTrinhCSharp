using System;
using System.Windows.Forms;

namespace B1_1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy đúng Form PhepTinh với namespace B1_1
            Application.Run(new PhepTinh());
        }
    }
}