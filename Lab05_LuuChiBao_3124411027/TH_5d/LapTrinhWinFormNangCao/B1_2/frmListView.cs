using System;
using System.Windows.Forms;

namespace B1_2
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        // Phương thức kiểm tra trùng mã số sinh viên trước khi thêm vào danh sách
        private bool KiemTraTrungMSSV(string mssv)
        {
            foreach (ListViewItem item in lstv1.Items)
            {
                if (string.Compare(item.Text.Trim(), mssv.Trim(), true) == 0)
                {
                    return true; // Đã tồn tại mã SV này
                }
            }
            return false;
        }

        // Sự kiện click của Button Thêm
        private void btnthem_Click(object sender, EventArgs e)
        {
            string mssv = txtmssv.Text.Trim();
            string hoten = txthoten.Text.Trim();

            if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã số sinh viên
            if (KiemTraTrungMSSV(mssv))
            {
                MessageBox.Show("Mã số sinh viên này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmssv.SelectAll();
                txtmssv.Focus();
                return;
            }

            // Tạo item mới và thêm vào ListView
            ListViewItem item = new ListViewItem();
            ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();

            item.Text = mssv;
            subitem.Text = hoten;
            item.SubItems.Add(subitem);

            lstv1.Items.Add(item);

            // Xóa trắng TextBox sau khi thêm thành công
            txtmssv.Clear();
            txthoten.Clear();
            txtmssv.Focus();
        }

        // Sự kiện click của Button Xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem l in lstv1.SelectedItems)
            {
                l.Remove();
            }

            txtmssv.Clear();
            txthoten.Clear();
        }

        // Sự kiện click của Button Sửa
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lstv1.FocusedItem != null && lstv1.FocusedItem.Index >= 0)
            {
                ListViewItem item = lstv1.FocusedItem;
                item.SubItems[0].Text = txtmssv.Text.Trim();
                item.SubItems[1].Text = txthoten.Text.Trim();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa trên ListView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Khi click chọn dòng trên ListView, hiển thị thông tin lên TextBox
        private void lstv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count > 0)
            {
                ListViewItem item = lstv1.SelectedItems[0];
                txtmssv.Text = item.SubItems[0].Text;
                txthoten.Text = item.SubItems[1].Text;
            }
        }
    }
}