using System;
using System.Windows.Forms;

namespace B4_1
{
    public partial class frmDongHo : Form
    {
        // 30 phút = 1800 giây
        private int totalSeconds = 30 * 60;

        public frmDongHo()
        {
            InitializeComponent();
        }

        private void frmDongHo_Load(object sender, EventArgs e)
        {
            lblTime.Text = "30:00";
            timer1.Interval = 1000; // Cấu hình 1 giây (1000ms)
        }

        // Nút "Bắt đầu" / "Tạm dừng"
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                btnBatDau.Text = "Tạm dừng";
            }
            else
            {
                timer1.Stop();
                btnBatDau.Text = "Bắt đầu";
            }
        }

        // Sự kiện Tick của Timer mỗi giây
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds % 60;

                // Hiển thị định dạng mm:ss (ví dụ: 30:00)
                lblTime.Text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
            else
            {
                timer1.Stop();
                btnBatDau.Text = "Bắt đầu";
                MessageBox.Show("Hết giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}