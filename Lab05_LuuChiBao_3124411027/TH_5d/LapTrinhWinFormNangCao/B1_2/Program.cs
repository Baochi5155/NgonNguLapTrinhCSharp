using System;
using System.Windows.Forms;

namespace B1_2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form ListView trong namespace B1_2
            Application.Run(new frmListView());
        }
    }
}