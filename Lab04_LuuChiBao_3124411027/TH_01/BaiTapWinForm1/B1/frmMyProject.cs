using System;
using System.Windows.Forms;

namespace B1
{
    public partial class frmMyProject : Form
    {
        public frmMyProject()
        {
            InitializeComponent();
        }

        // 1. Kiểm tra Textbox YourName đã được nhập nội dung chưa khi rời con trỏ chuột khỏi ô (Leave)
        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "You must enter Your Name");
            }
            else
            {
                this.errorProvider1.SetError(ctr, "");
            }
        }

        // 2. Yêu cầu Textbox Year phải nhập số, nhập sai dùng ErrorProvider thông báo lỗi
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            // Kiểm tra ký tự cuối cùng vừa nhập có phải số không
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "This is not a valid number");
            }
            else
            {
                this.errorProvider1.SetError(ctr, "");
            }
        }

        // 3. Hiển thị tên và tuổi khi nhấn button Show
        private void btnShow_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên
            if (string.IsNullOrWhiteSpace(txtYourName.Text))
            {
                this.errorProvider1.SetError(txtYourName, "You must enter Your Name");
                txtYourName.Focus();
                return;
            }

            // Kiểm tra năm sinh
            if (!int.TryParse(txtYear.Text.Trim(), out int yearOfBirth) || yearOfBirth > DateTime.Now.Year)
            {
                this.errorProvider1.SetError(txtYear, "This is not a valid number");
                txtYear.Focus();
                return;
            }

            int age = DateTime.Now.Year - yearOfBirth;
            string s = "My Name is: " + txtYourName.Text.Trim() + "\n";
            s += "Age: " + age.ToString();

            MessageBox.Show(s, "Thông báo");
        }

        // 4. Button Clear: Xóa sạch dữ liệu và đưa con trỏ về ô YourName
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            errorProvider1.Clear();
            txtYourName.Focus();
        }

        // 5. Thoát chương trình khi nhấn button Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 6. Xác nhận khi Form chuẩn bị đóng
        private void frmMyProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có muốn thoát?",
                "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}