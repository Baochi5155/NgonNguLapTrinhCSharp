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

            // Chạy Form Cbo_Dantoc
            Application.Run(new Cbo_Dantoc());
        }
    }
}