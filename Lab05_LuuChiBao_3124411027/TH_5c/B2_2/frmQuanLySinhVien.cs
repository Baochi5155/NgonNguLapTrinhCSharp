using System;
using System.Windows.Forms;

namespace B1_1
{
    public partial class frmQuanLySinhVien : Form
    {
        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        // 1. Khi Form hiển thị lên 
        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            // Tạo Node gốc "Danh sách lớp"
            TreeNode rootNode = new TreeNode("Danh sách lớp");
            trv_DanhSach.Nodes.Add(rootNode);

            // Danh sách các lớp có sẵn
            string[] dsLop = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };
            foreach (string lop in dsLop)
            {
                rootNode.Nodes.Add(new TreeNode(lop));
                cbo_ChonLop.Items.Add(lop);
            }

            rootNode.Expand();

            if (cbo_ChonLop.Items.Count > 0)
                cbo_ChonLop.SelectedIndex = 0;

            // CheckBox Thêm lớp là false -> ẩn GroupBox Thông tin lớp
            chk_ThemLop.Checked = false;
            grp_ThongTinLop.Visible = false;
        }

        // 2. Bật / Ẩn GroupBox Thông tin lớp khi tích CheckBox
        private void chk_ThemLop_CheckedChanged(object sender, EventArgs e)
        {
            grp_ThongTinLop.Visible = chk_ThemLop.Checked;
        }

        // 3. Button Thêm lớp: Thêm lớp mới vào TreeView và ComboBox (kiểm tra không trùng) 
        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            string tenLop = txt_TenLop.Text.Trim();
            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng nhập tên lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenLop.Focus();
                return;
            }

            TreeNode root = trv_DanhSach.Nodes[0];

            // Kiểm tra tên lớp không được trùng
            foreach (TreeNode node in root.Nodes)
            {
                if (string.Compare(node.Text.Trim(), tenLop, true) == 0)
                {
                    MessageBox.Show("Tên lớp này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenLop.SelectAll();
                    txt_TenLop.Focus();
                    return;
                }
            }

            // Thêm lớp mới vào TreeView và ComboBox    
            root.Nodes.Add(new TreeNode(tenLop));
            cbo_ChonLop.Items.Add(tenLop);
            root.Expand();

            txt_TenLop.Clear();
            MessageBox.Show("Thêm lớp mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hàm hỗ trợ kiểm tra trùng mã sinh viên trên toàn bộ TreeView
        private bool KiemTraTrungMaSV(string maSV)
        {
            TreeNode root = trv_DanhSach.Nodes[0];
            foreach (TreeNode lopNode in root.Nodes)
            {
                foreach (TreeNode svNode in lopNode.Nodes)
                {
                    string[] parts = svNode.Text.Split(',');
                    if (parts.Length > 0 && parts[0].Trim().Equals(maSV.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        return true; // Đã tồn tại mã SV
                    }
                }
            }
            return false;
        }

        // 4. Button Cập Nhật: Thêm sinh viên vào lớp đang chọn trong ComboBox
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (cbo_ChonLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = txt_MaSV.Text.Trim();
            string hoTen = txt_HoTen.Text.Trim();
            string diaChi = txt_DiaChi.Text.Trim();

            // Kiểm tra các TextBox không được để trống 
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV, Họ Tên và Địa Chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra không trùng mã sinh viên
            if (KiemTraTrungMaSV(maSV))
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaSV.SelectAll();
                txt_MaSV.Focus();
                return;
            }

            // Tìm node lớp tương ứng với lớp được chọn trong ComboBox
            string tenLopChon = cbo_ChonLop.SelectedItem.ToString();
            TreeNode root = trv_DanhSach.Nodes[0];
            TreeNode lopTarget = null;

            foreach (TreeNode lopNode in root.Nodes)
            {
                if (lopNode.Text == tenLopChon)
                {
                    lopTarget = lopNode;
                    break;
                }
            }

            if (lopTarget != null)
            {
                // Tạo node Sinh viên và sub-node Địa chỉ   
                TreeNode svNode = new TreeNode($"{maSV}, {hoTen}");
                svNode.Nodes.Add(new TreeNode(diaChi));

                lopTarget.Nodes.Add(svNode);
                lopTarget.Expand();
                svNode.Expand();

                // Xóa dữ liệu nhập
                txt_MaSV.Clear();
                txt_HoTen.Clear();
                txt_DiaChi.Clear();
                txt_MaSV.Focus();
            }
        }

        // 5. Hiển thị thông tin sinh viên lên TextBox tương ứng khi click chọn node
        private void trv_DanhSach_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selected = e.Node;
            if (selected == null) return;

            TreeNode svNode = null;

            // Nếu chọn node Sinh viên (Level 2)
            if (selected.Level == 2)
            {
                svNode = selected;
            }
            // Nếu chọn node Địa chỉ (Level 3)
            else if (selected.Level == 3)
            {
                svNode = selected.Parent;
            }

            if (svNode != null)
            {
                string[] parts = svNode.Text.Split(',');
                if (parts.Length >= 2)
                {
                    txt_MaSV.Text = parts[0].Trim();
                    txt_HoTen.Text = parts[1].Trim();
                }
                if (svNode.Nodes.Count > 0)
                {
                    txt_DiaChi.Text = svNode.Nodes[0].Text;
                }
            }
        }

        // 6. Button Xóa: Chỉ cho phép xóa node là Sinh viên (xác nhận trước khi xóa)
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            TreeNode selected = trv_DanhSach.SelectedNode;
            if (selected == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa trên TreeView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TreeNode svNode = null;
            if (selected.Level == 2)
            {
                svNode = selected;
            }
            else if (selected.Level == 3)
            {
                svNode = selected.Parent;
            }

            // Chỉ cho phép xóa node là sinh viên
            if (svNode == null)
            {
                MessageBox.Show("Chỉ được phép xóa node là sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi xóa   
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên '{svNode.Text}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                svNode.Remove();
                txt_MaSV.Clear();
                txt_HoTen.Clear();
                txt_DiaChi.Clear();
            }
        }
    }
}