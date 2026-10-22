using System;
using System.Windows.Forms;

namespace B4_2
{
    public partial class frmListbox : Form
    {
        public frmListbox()
        {
            InitializeComponent();
        }

        // 1. Thêm số tự nhiên N từ Textbox vào Listbox
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSo.Text.Trim(), out int n) && n >= 0)
            {
                lstSo.Items.Add(n);
                txtSo.Clear();
                txtSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số tự nhiên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.SelectAll();
                txtSo.Focus();
            }
        }

        // Cho phép nhấn Enter trong TextBox để nhập
        private void txtSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNhap_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // 2. Tính tổng các phần tử trong Listbox, hiển thị lên MessageBox
        private void btnTong_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            long sum = 0;
            foreach (var item in lstSo.Items)
            {
                sum += Convert.ToInt64(item);
            }

            MessageBox.Show($"Tổng các phần tử trong List là: {sum}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. Xóa phần tử đầu và cuối của listbox
        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lstSo.Items.Count == 1)
            {
                lstSo.Items.RemoveAt(0);
            }
            else
            {
                // Xóa phần tử cuối trước để tránh bị nhảy chỉ số (index)
                lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
                lstSo.Items.RemoveAt(0);
            }
        }

        // 4. Xóa các phần tử đang chọn trong listbox
        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            while (lstSo.SelectedItems.Count > 0)
            {
                lstSo.Items.Remove(lstSo.SelectedItems[0]);
            }
        }

        // 5. Tăng giá trị mỗi phần tử lên 2
        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lstSo.Items[i]);
                lstSo.Items[i] = val + 2;
            }
        }

        // 6. Thay mỗi giá trị của mỗi phần tử bằng bình phương của chính nó
        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                long val = Convert.ToInt64(lstSo.Items[i]);
                lstSo.Items[i] = val * val;
            }
        }

        // 7. Thực hiện chọn các phần tử trong listbox là số chẵn
        private void btnChonChan_Click(object sender, EventArgs e)
        {
            lstSo.ClearSelected();
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lstSo.Items[i]);
                if (val % 2 == 0)
                {
                    lstSo.SetSelected(i, true);
                }
            }
        }

        // 8. Thực hiện chọn các phần tử trong listbox là số lẻ
        private void btnChonLe_Click(object sender, EventArgs e)
        {
            lstSo.ClearSelected();
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lstSo.Items[i]);
                if (val % 2 != 0)
                {
                    lstSo.SetSelected(i, true);
                }
            }
        }

        // 9. Nút KẾT THÚC
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xác nhận khi thoát form
        private void frmListbox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn kết thúc chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}