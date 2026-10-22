using System;
using System.Windows.Forms;

namespace B1_1
{
    public partial class frmDemoTimer : Form
    {
        public frmDemoTimer()
        {
            InitializeComponent();
        }

        // Sự kiện Load Form: Cập nhật thời gian ngay khi mở
        private void frmDemoTimer_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
        }

        // Sự kiện Tick của Timer phát sinh mỗi giây (Interval = 1000ms)
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hệ thống thực tế và hiển thị lên label
            label1.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
        }
    }
}