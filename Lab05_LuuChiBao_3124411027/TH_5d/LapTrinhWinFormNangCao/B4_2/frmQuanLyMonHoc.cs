using System;
using System.Windows.Forms;

namespace B4_2
{
    public partial class frmQuanLyMonHoc : Form
    {
        public frmQuanLyMonHoc()
        {
            InitializeComponent();
            InitDataGridView();
        }

        private void InitDataGridView()
        {
            dgvMonHoc.Columns.Clear();
            dgvMonHoc.Columns.Add("colMaMon", "Mã môn học");
            dgvMonHoc.Columns.Add("colTenMon", "Tên môn học");
            dgvMonHoc.Columns.Add("colSoTinChi", "Số tín chỉ");
            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text) || string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã môn và Tên môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvMonHoc.Rows.Add(txtMaMon.Text.Trim(), txtTenMon.Text.Trim(), nudSoTinChi.Value);

            txtMaMon.Clear();
            txtTenMon.Clear();
            nudSoTinChi.Value = 3;
            txtMaMon.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow != null && !dgvMonHoc.CurrentRow.IsNewRow)
            {
                dgvMonHoc.Rows.Remove(dgvMonHoc.CurrentRow);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}