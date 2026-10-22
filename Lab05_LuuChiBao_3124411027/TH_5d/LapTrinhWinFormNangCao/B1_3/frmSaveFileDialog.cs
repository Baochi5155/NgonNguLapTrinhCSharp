using System;
using System.IO;
using System.Windows.Forms;

namespace B1_3
{
    public partial class frmSaveFileDialog : Form
    {
        public frmSaveFileDialog()
        {
            InitializeComponent();
        }

        // 1. Sự kiện Click nút "Lưu file"
        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog svg = new SaveFileDialog();
            svg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (svg.ShowDialog() == DialogResult.OK)
            {
                string filename = svg.FileName;
                textBox1.Text = filename; // Gán đường dẫn lên TextBox

                // Ghi nội dung từ RichTextBox vào file
                using (StreamWriter sw = File.CreateText(filename))
                {
                    sw.Write(richTextBox1.Text);
                }

                MessageBox.Show("Lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 2. Sự kiện Click nút "Mở file"
        private void btnMoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Lọc loại đuôi file theo mong muốn
            openFileDialog1.Filter = "All Text File (*.txt)|*.txt|All Document (*.pdf)|*.pdf|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Gán đường dẫn lên TextBox
                textBox1.Text = openFileDialog1.FileName;

                // Đọc dữ liệu từ file txt dùng StreamReader
                using (StreamReader f = new StreamReader(openFileDialog1.FileName))
                {
                    // Đọc dữ liệu text và gán vào RichTextBox
                    richTextBox1.Text = f.ReadToEnd();
                }
            }
        }
    }
}