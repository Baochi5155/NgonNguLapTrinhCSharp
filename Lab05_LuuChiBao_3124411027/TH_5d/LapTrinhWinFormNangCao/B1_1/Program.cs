using System;
using System.Windows.Forms;

namespace B1_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form Demo Timer trong namespace B1_1[cite: 22]
            Application.Run(new frmDemoTimer());
        }
    }
}