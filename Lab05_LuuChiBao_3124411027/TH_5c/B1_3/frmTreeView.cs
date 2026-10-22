using System;
using System.Windows.Forms;

namespace B1_1
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        // Phương thức kiểm tra trùng phòng ban (không phân biệt chữ hoa/thường)
        private bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            foreach (TreeNode node in trv_DS.Nodes)
            {
                // So sánh chuỗi không phân biệt chữ hoa/thường bằng string.Compare
                if (string.Compare(node.Text.Trim(), s.Trim(), true) == 0)
                {
                    return false; // Đã tồn tại phòng ban này
                }
            }
            return true; // Chưa tồn tại, hợp lệ để thêm
        }

        // Sự kiện Form Load[cite: 9]
        private void frmTreeView_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" };  

            foreach (string s in pb)
            {
                trv_DS.Nodes.Add(s); // Thêm node vào TreeView
                cbo_phongban.Items.Add(s); // Thêm item vào ComboBox
            }

            if (cbo_phongban.Items.Count > 0)
            {
                cbo_phongban.SelectedIndex = 0; // Item đầu tiên được chọn
            }
        }

        // Thêm phòng ban mới vào TreeView và ComboBox
        private void btn_ThemPB_Click(object sender, EventArgs e)
        {
            if (kiemtra(txt_phongban.Text)) 
            {
                trv_DS.Nodes.Add(txt_phongban.Text); 
                cbo_phongban.Items.Add(txt_phongban.Text);  
                txt_phongban.Clear();
                txt_phongban.Focus();
            }
            else
            {
                MessageBox.Show("Phòng ban đã tồn tại!"); 
                txt_phongban.Text = ""; 
                txt_phongban.Focus(); 
            }
        }

        // Xóa phòng ban được chọn trong TreeView
        private void btn_XoaPB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes) 
            {
                // Một phòng ban trong TreeView được chọn
                if (trv_DS.SelectedNode != null)
                {
                    cbo_phongban.Items.Remove(trv_DS.SelectedNode.Text); 
                    trv_DS.Nodes.Remove(trv_DS.SelectedNode);   
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng ban cần xóa trên TreeView!");
                }
            }
        }

        // Thêm nhân viên vào phòng ban được chọn lên TreeView  
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_hoten.Text) || string.IsNullOrWhiteSpace(txt_maso.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã số và họ tên nhân viên!");
                return;
            }

            // Tìm index của node có nội dung là item được chọn trong combobox phòng ban
            int index = -1;
            foreach (TreeNode node in trv_DS.Nodes)
            {
                if (node.Text == cbo_phongban.Text) 
                {
                    index = node.Index; 
                    break; 
                }
            }

            if (index != -1)
            {
                trv_DS.Nodes[index].Nodes.Add(txt_hoten.Text + " (" + txt_maso.Text + ")"); 
                trv_DS.ExpandAll(); // Mở rộng TreeView

                // Xóa trắng ô nhập liệu sau khi thêm
                txt_maso.Clear();
                txt_hoten.Clear();
                txt_diachi.Clear();
                txt_maso.Focus();
            }
        }

        // Nút Thoát    
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xác nhận đóng Form (Sự kiện FormClosing) 
        private void frmTreeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}