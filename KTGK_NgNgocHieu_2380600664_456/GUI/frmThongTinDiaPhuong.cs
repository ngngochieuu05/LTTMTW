using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DAL.Entities;

namespace GUI
{
    public partial class frmThongTinDiaPhuong : Form
    {
        private DiaPhuongBLL bll;
        private bool isSortAscending = false;

        public frmThongTinDiaPhuong()
        {
            InitializeComponent();
            bll = new DiaPhuongBLL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxTrangThai();
            LoadDanhSachDiaPhuong();
        }

        private void LoadDanhSachDiaPhuong()
        {
            try
            {
                var danhSach = bll.GetAll();
                dgvDiaPhuong.Rows.Clear();

                foreach (var dp in danhSach)
                {
                    int rowIndex = dgvDiaPhuong.Rows.Add();
                    DataGridViewRow row = dgvDiaPhuong.Rows[rowIndex];
                    
                    row.Cells["clmMaDP"].Value = dp.MaDP;
                    row.Cells["clnTenDiaPhuong"].Value = dp.TenDP;
                    row.Cells["clmCaNhiem"].Value = dp.SoCaNhiemMoi;
                    row.Cells["colTrangThai"].Value = dp.TrangThai?.TenTT ?? "";
                    row.Tag = dp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxTrangThai()
        {
            try
            {
                var dsTrangThai = bll.GetAllTrangThai();
                cboTrangThai.DataSource = dsTrangThai;
                cboTrangThai.DisplayMember = "TenTT";
                cboTrangThai.ValueMember = "MaTT";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trạng thái: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDiaPhuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDiaPhuong.Rows.Count)
                {
                    DataGridViewRow row = dgvDiaPhuong.Rows[e.RowIndex];
                    DiaPhuong dp = row.Tag as DiaPhuong;
                    
                    if (dp != null)
                    {
                        txtMaDiaPhuong.Text = dp.MaDP;
                        txtTenDiaPhuong.Text = dp.TenDP;
                        txtSoCaNhiem.Text = dp.SoCaNhiemMoi.ToString();
                        cboTrangThai.SelectedValue = dp.MaTT;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMsg = bll.ValidateDiaPhuong(
                    txtMaDiaPhuong.Text.Trim(),
                    txtTenDiaPhuong.Text.Trim(),
                    txtSoCaNhiem.Text.Trim(),
                    false
                );

                if (!string.IsNullOrEmpty(errorMsg))
                {
                    MessageBox.Show(errorMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboTrangThai.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool result = bll.ThemDiaPhuong(
                    txtMaDiaPhuong.Text.Trim(),
                    txtTenDiaPhuong.Text.Trim(),
                    int.Parse(txtSoCaNhiem.Text.Trim()),
                    Convert.ToInt32(cboTrangThai.SelectedValue)
                );

                if (result)
                {
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDiaPhuong();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string maDP = txtMaDiaPhuong.Text.Trim();
                var diaPhuongCu = bll.GetByMa(maDP);
                
                if (diaPhuongCu == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin địa phương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string errorMsg = bll.ValidateDiaPhuong(maDP, txtTenDiaPhuong.Text.Trim(), txtSoCaNhiem.Text.Trim(), true);
                
                if (!string.IsNullOrEmpty(errorMsg))
                {
                    MessageBox.Show(errorMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboTrangThai.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maTTMoi = Convert.ToInt32(cboTrangThai.SelectedValue);

                if (diaPhuongCu.MaTT != maTTMoi)
                {
                    string message = string.Format("Địa phương có sự thay đổi từ {0} -> {1}?",
                        bll.GetTenTrangThai(diaPhuongCu.MaTT),
                        bll.GetTenTrangThai(maTTMoi));

                    if (MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                }

                bool result = bll.CapNhatDiaPhuong(maDP, txtTenDiaPhuong.Text.Trim(), int.Parse(txtSoCaNhiem.Text.Trim()), maTTMoi);

                if (result)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDiaPhuong();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sapXepTheoSoCaNhiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                isSortAscending = !isSortAscending;
                var danhSach = bll.SapXepTheoSoCaNhiem(isSortAscending);
                
                dgvDiaPhuong.Rows.Clear();
                foreach (var dp in danhSach)
                {
                    int rowIndex = dgvDiaPhuong.Rows.Add();
                    DataGridViewRow row = dgvDiaPhuong.Rows[rowIndex];
                    
                    row.Cells["clmMaDP"].Value = dp.MaDP;
                    row.Cells["clnTenDiaPhuong"].Value = dp.TenDP;
                    row.Cells["clmCaNhiem"].Value = dp.SoCaNhiemMoi;
                    row.Cells["colTrangThai"].Value = dp.TrangThai?.TenTT ?? "";
                    row.Tag = dp;
                }

                MessageBox.Show($"Đã sắp xếp theo số ca nhiễm {(isSortAscending ? "tăng dần" : "giảm dần")}", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cacDiaPhuongNhomNguyCoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var danhSach = bll.GetDiaPhuongNguyCo();
                dgvDiaPhuong.Rows.Clear();
                
                foreach (var dp in danhSach)
                {
                    int rowIndex = dgvDiaPhuong.Rows.Add();
                    DataGridViewRow row = dgvDiaPhuong.Rows[rowIndex];
                    
                    row.Cells["clmMaDP"].Value = dp.MaDP;
                    row.Cells["clnTenDiaPhuong"].Value = dp.TenDP;
                    row.Cells["clmCaNhiem"].Value = dp.SoCaNhiemMoi;
                    row.Cells["colTrangThai"].Value = dp.TrangThai?.TenTT ?? "";
                    row.Tag = dp;
                }

                MessageBox.Show($"Tìm thấy {danhSach.Count} địa phương nhóm nguy cơ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xuatBaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBaoCao frmBaoCao = new frmBaoCao();
                frmBaoCao.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDiaPhuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDiaPhuong_CellClick(sender, e);
        }

        private void ClearInputFields()
        {
            txtMaDiaPhuong.Clear();
            txtTenDiaPhuong.Clear();
            txtSoCaNhiem.Text = "0";
            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;
            txtMaDiaPhuong.Focus();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            bll?.Dispose();
        }
    }
}

