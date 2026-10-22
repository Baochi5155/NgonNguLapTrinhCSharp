using System;
using System.Windows.Forms;

namespace B1_3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form Save File Dialog trong namespace B1_3
            Application.Run(new frmSaveFileDialog());
        }
    }
}