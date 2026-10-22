using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace B3_1 // Thay tên namespace trùng với tên Project của bạn (ví dụ: B1_1 hoặc B2_3)
{
    public partial class frmChuoi : Form
    {
        public frmChuoi()
        {
            InitializeComponent();
        }

        // 1. Nút "Nhập tên ngẫu nhiên": Thêm 50 tên ngẫu nhiên từ 3 mảng HO, TENLOT, TEN
        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lại", "Huỳnh", "La" };
            string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };
            string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };

            Random rand = new Random();
            lstChuoi.Items.Clear();

            for (int i = 0; i < 50; i++)
            {
                string ho = HO[rand.Next(HO.Length)];
                string tenLot = TENLOT[rand.Next(TENLOT.Length)];
                string ten = TEN[rand.Next(TEN.Length)];

                lstChuoi.Items.Add($"{ho} {tenLot} {ten}");
            }
        }

        // 2. Nút "Xóa Phần tử đang chọn"
        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            while (lstChuoi.SelectedItems.Count > 0)
            {
                lstChuoi.Items.Remove(lstChuoi.SelectedItems[0]);
            }
        }

        // 3. Nút "Xóa phần tử có tên là Sơn"
        private void btnXoaTenSon_Click(object sender, EventArgs e)
        {
            for (int i = lstChuoi.Items.Count - 1; i >= 0; i--)
            {
                string fullName = lstChuoi.Items[i].ToString().Trim();
                string[] parts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length > 0 && parts[parts.Length - 1].Equals("Sơn", StringComparison.OrdinalIgnoreCase))
                {
                    lstChuoi.Items.RemoveAt(i);
                }
            }
        }

        // 4. Nút "Xóa Phần tử có họ là Lê"
        private void btnXoaHoLe_Click(object sender, EventArgs e)
        {
            for (int i = lstChuoi.Items.Count - 1; i >= 0; i--)
            {
                string fullName = lstChuoi.Items[i].ToString().Trim();
                string[] parts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length > 0 && parts[0].Equals("Lê", StringComparison.OrdinalIgnoreCase))
                {
                    lstChuoi.Items.RemoveAt(i);
                }
            }
        }

        // 5. Nút "Chuyển PT đang chọn thành chữ HOA"
        private void btnHoa_Click(object sender, EventArgs e)
        {
            int[] selectedIndices = new int[lstChuoi.SelectedIndices.Count];
            lstChuoi.SelectedIndices.CopyTo(selectedIndices, 0);

            foreach (int index in selectedIndices)
            {
                lstChuoi.Items[index] = lstChuoi.Items[index].ToString().ToUpper();
            }
        }

        // 6. Nút "Chuyển PT đang chọn thành chữ thường"
        private void btnThuong_Click(object sender, EventArgs e)
        {
            int[] selectedIndices = new int[lstChuoi.SelectedIndices.Count];
            lstChuoi.SelectedIndices.CopyTo(selectedIndices, 0);

            foreach (int index in selectedIndices)
            {
                lstChuoi.Items[index] = lstChuoi.Items[index].ToString().ToLower();
            }
        }

        // 7. Nút "Chuyển PT đang chọn thành viết Hoa đầu mỗi từ"
        private void btnHoaDau_Click(object sender, EventArgs e)
        {
            int[] selectedIndices = new int[lstChuoi.SelectedIndices.Count];
            lstChuoi.SelectedIndices.CopyTo(selectedIndices, 0);

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            foreach (int index in selectedIndices)
            {
                string text = lstChuoi.Items[index].ToString().ToLower();
                lstChuoi.Items[index] = textInfo.ToTitleCase(text);
            }
        }

        // 8. Nút "Xóa tất cả các Phần tử"
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lstChuoi.Items.Clear();
        }

        // 9. Sự kiện Double-Click trên ListBox: Mở InputBox đổi tên
        private void lstChuoi_DoubleClick(object sender, EventArgs e)
        {
            if (lstChuoi.SelectedIndex != -1)
            {
                int index = lstChuoi.SelectedIndex;
                string oldName = lstChuoi.Items[index].ToString();

                // Gọi trực tiếp namespace Microsoft.VisualBasic.Interaction.InputBox
                string newName = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên mới:", "Thay đổi tên", oldName);

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    lstChuoi.Items[index] = newName.Trim();
                }
            }
        }
    }
}