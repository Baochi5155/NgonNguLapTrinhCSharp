using System;
using System.Windows.Forms;

namespace B2_2
{
    public partial class frmMangSoNguyen : Form
    {
        private MangSoNguyen mang = null;

        public frmMangSoNguyen()
        {
            InitializeComponent();
        }

        // Đọc mảng từ TextBox txt_NhapMang
        private bool DocDuLieuVaoMang()
        {
            if (!MangSoNguyen.TryParse(txt_NhapMang.Text, out mang))
            {
                MessageBox.Show("Vui lòng nhập chuỗi số nguyên hợp lệ (cách nhau bởi dấu cách)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // 1. Thực hiện sắp xếp
        private void btn_ThucHienSapXep_Click(object sender, EventArgs e)
        {
            if (!DocDuLieuVaoMang()) return;

            if (rdo_SapXepTang.Checked)
            {
                mang.SapXepTang();
            }
            else
            {
                mang.SapXepGiam();
            }

            txt_KqMang.Text = mang.XuatChuoi();
        }

        // 2. Tìm kiếm
        private void btn_ThucHienTimKiem_Click(object sender, EventArgs e)
        {
            if (!DocDuLieuVaoMang()) return;

            if (rdo_TimGiaTri.Checked)
            {
                if (int.TryParse(txt_GiaTriCanTim.Text.Trim(), out int val))
                {
                    int viTri = mang.TimViTriTheoGiaTri(val);
                    if (viTri != -1)
                        txt_KqTimKiem.Text = viTri.ToString();
                    else
                        MessageBox.Show("Không tìm thấy giá trị này trong mảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập giá trị số nguyên cần tìm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // Tìm theo vị trí
            {
                if (int.TryParse(txt_ViTriCanTim.Text.Trim(), out int idx))
                {
                    try
                    {
                        int val = mang.TimGiaTriTheoViTri(idx);
                        txt_KqTimKiem.Text = val.ToString();
                    }
                    catch
                    {
                        MessageBox.Show($"Vị trí không hợp lệ! (Vị trí từ 0 đến {mang.A.Count - 1})", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập vị trí hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // 3. Xóa
        private void btn_ThucHienXoa_Click(object sender, EventArgs e)
        {
            if (!DocDuLieuVaoMang()) return;

            if (rdo_XoaTheoGiaTri.Checked)
            {
                if (int.TryParse(txt_GiaTriCanXoa.Text.Trim(), out int val))
                {
                    if (mang.XoaTheoGiaTri(val))
                    {
                        txt_KqMang.Text = mang.XuatChuoi();
                        txt_NhapMang.Text = mang.XuatChuoi();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giá trị cần xóa trong mảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập giá trị cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // Xóa theo vị trí
            {
                if (int.TryParse(txt_ViTriCanXoa.Text.Trim(), out int idx))
                {
                    if (mang.XoaTheoViTri(idx))
                    {
                        txt_KqMang.Text = mang.XuatChuoi();
                        txt_NhapMang.Text = mang.XuatChuoi();
                    }
                    else
                    {
                        MessageBox.Show($"Vị trí xóa không hợp lệ! (Từ 0 đến {mang.A.Count - 1})", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập vị trí cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // 4. Thêm
        private void btn_ThucHienThem_Click(object sender, EventArgs e)
        {
            if (!DocDuLieuVaoMang()) return;

            if (!int.TryParse(txt_GiaTriCanThem.Text.Trim(), out int val))
            {
                MessageBox.Show("Vui lòng nhập giá trị cần thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_ViTriCanThem.Text.Trim(), out int idx))
            {
                MessageBox.Show("Vui lòng nhập vị trí cần thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mang.ChenViTri(idx, val))
            {
                txt_KqMang.Text = mang.XuatChuoi();
                txt_NhapMang.Text = mang.XuatChuoi();
            }
            else
            {
                MessageBox.Show($"Vị trí thêm không hợp lệ! (Từ 0 đến {mang.A.Count})", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 5. Tổng mảng
        private void btn_Tong_Click(object sender, EventArgs e)
        {
            if (!DocDuLieuVaoMang()) return;

            txt_TongMang.Text = mang.TongMang().ToString();
            txt_TongChan.Text = mang.TongChan().ToString();
            txt_TongLe.Text = mang.TongLe().ToString();
        }

        // 6. Max - Min
        private void btn_TimMaxMin_Click(object sender, EventArgs e)
        {
            if (!DocDuLieuVaoMang()) return;

            txt_Max.Text = mang.Max().ToString();
            txt_Min.Text = mang.Min().ToString();
        }

        // 7. Thay thế
        private void btn_ThucHienThayThe_Click(object sender, EventArgs e)
        {
            if (!DocDuLieuVaoMang()) return;

            if (!int.TryParse(txt_SoThayTheMoi.Text.Trim(), out int soMoi))
            {
                MessageBox.Show("Vui lòng nhập số thay thế mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdo_ThayTheTheoGiaTri.Checked)
            {
                if (int.TryParse(txt_GiaTriCanThayThe.Text.Trim(), out int giaTriCu))
                {
                    if (mang.ThayTheTheoGiaTri(giaTriCu, soMoi))
                    {
                        txt_KqMang.Text = mang.XuatChuoi();
                        txt_NhapMang.Text = mang.XuatChuoi();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giá trị cần thay thế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập giá trị cần thay thế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // Thay thế theo vị trí
            {
                if (int.TryParse(txt_ViTriCanThayThe.Text.Trim(), out int idx))
                {
                    if (mang.ThayTheTheoViTri(idx, soMoi))
                    {
                        txt_KqMang.Text = mang.XuatChuoi();
                        txt_NhapMang.Text = mang.XuatChuoi();
                    }
                    else
                    {
                        MessageBox.Show($"Vị trí cần thay thế không hợp lệ! (Từ 0 đến {mang.A.Count - 1})", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập vị trí cần thay thế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // 8. Nút Reset
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_NhapMang.Clear();
            txt_KqMang.Clear();
            txt_GiaTriCanTim.Clear();
            txt_ViTriCanTim.Clear();
            txt_KqTimKiem.Clear();
            txt_GiaTriCanXoa.Clear();
            txt_ViTriCanXoa.Clear();
            txt_GiaTriCanThem.Clear();
            txt_ViTriCanThem.Clear();
            txt_TongMang.Clear();
            txt_TongChan.Clear();
            txt_TongLe.Clear();
            txt_Max.Clear();
            txt_Min.Clear();
            txt_GiaTriCanThayThe.Clear();
            txt_ViTriCanThayThe.Clear();
            txt_SoThayTheMoi.Clear();
        }

        // 9. Nút Thoát
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 10. Xác nhận trước khi đóng Form
        private void frmMangSoNguyen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có thực sự muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}