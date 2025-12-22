using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI
{
    public partial class QuanLiSinhVien : Form
    {
        private StudentService studentService = new StudentService();

        public QuanLiSinhVien()
        {
            InitializeComponent();
        }

        private void QuanLiSinhVien_NgNgocHieu_Load(object sender, EventArgs e)
        {
            try
            {
                cbNam.Checked = true;
                cbNu.Checked = false;
                cboKhoa.SelectedIndex = 0;
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi load du lieu: " + ex.Message + "\n\n" + ex.InnerException?.Message,
                    "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataGrid()
        {
            try
            {
                dgvSinhVien.Rows.Clear();
                DataTable dt = studentService.GetAllStudents();
                foreach (DataRow row in dt.Rows)
                {
                    string maSV = row["MaSV"]?.ToString() ?? "";
                    string hoTen = row["HoTen"]?.ToString() ?? "";
                    string gioiTinh = row["GioiTinh"]?.ToString() ?? "";
                    string khoa = row["Khoa"]?.ToString() ?? "";
                    string diemTB = "";
                    if (row["DiemTB"] != null && row["DiemTB"] != DBNull.Value)
                    {
                        diemTB = Convert.ToDecimal(row["DiemTB"]).ToString("0.00");
                    }
                    dgvSinhVien.Rows.Add(maSV, hoTen, gioiTinh, khoa, diemTB);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi load du lieu: " + ex.Message + "\n\nChi tiet: " + ex.ToString(),
                    "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Student LayThongTinSinhVien()
        {
            decimal diemTB = 0;
            if (!string.IsNullOrWhiteSpace(txtDTB.Text))
            {
                if (!decimal.TryParse(txtDTB.Text.Trim(), out diemTB))
                {
                    MessageBox.Show("Diem trung binh khong hop le! Se su dung gia tri 0.",
                        "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    diemTB = 0;
                }
                else if (diemTB < 0 || diemTB > 10)
                {
                    MessageBox.Show("Diem trung binh phai tu 0 den 10!",
                        "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    diemTB = diemTB < 0 ? 0 : 10;
                }
            }
            return new Student
            {
                StudentID = txtMaSV.Text.Trim(),
                FullName = txtHoTen.Text.Trim(),
                DateOfBirth = DateTime.Now.AddYears(-18),
                Gender = cbNam.Checked ? "Nam" : "Nu",
                Faculty = cboKhoa.Text,
                AverageScore = diemTB,
                ProfilePicture = null
            };
        }

        private void LamSachForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDTB.Clear();
            cbNam.Checked = true;
            cbNu.Checked = false;
            cboKhoa.SelectedIndex = 0;
            txtMaSV.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Student sv = LayThongTinSinhVien();
                string error;
                if (studentService.AddStudent(sv, out error))
                {
                    MessageBox.Show("Them sinh vien thanh cong!", "Thong bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    LamSachForm();
                }
                else
                {
                    MessageBox.Show(error, "Loi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSV.Text))
                {
                    MessageBox.Show("Vui long chon sinh vien can sua!", "Thong bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show(
                    "Ban co chac chan muon sua thong tin sinh vien nay?",
                    "Xac nhan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Student sv = LayThongTinSinhVien();
                    string error;
                    if (studentService.UpdateStudent(sv, out error))
                    {
                        MessageBox.Show("Sua thong tin sinh vien thanh cong!", "Thong bao",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGrid();
                        LamSachForm();
                    }
                    else
                    {
                        MessageBox.Show(error, "Loi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSV.Text))
                {
                    MessageBox.Show("Vui long chon sinh vien can xoa!", "Thong bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show(
                    "Ban co chac chan muon xoa sinh vien nay?",
                    "Xac nhan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string error;
                    if (studentService.DeleteStudent(txtMaSV.Text, out error))
                    {
                        MessageBox.Show("Xoa sinh vien thanh cong!", "Thong bao",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGrid();
                        LamSachForm();
                    }
                    else
                    {
                        MessageBox.Show(error, "Loi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();
                dgvSinhVien.Rows.Clear();
                DataTable dt = studentService.SearchStudents(keyword);
                foreach (DataRow row in dt.Rows)
                {
                    string maSV = row["MaSV"]?.ToString() ?? "";
                    string hoTen = row["HoTen"]?.ToString() ?? "";
                    string gioiTinh = row["GioiTinh"]?.ToString() ?? "";
                    string khoa = row["Khoa"]?.ToString() ?? "";
                    string diemTB = "";
                    if (row["DiemTB"] != null && row["DiemTB"] != DBNull.Value)
                    {
                        diemTB = Convert.ToDecimal(row["DiemTB"]).ToString("0.00");
                    }
                    dgvSinhVien.Rows.Add(maSV, hoTen, gioiTinh, khoa, diemTB);
                }
                if (dgvSinhVien.Rows.Count == 0)
                {
                    MessageBox.Show("Khong tim thay sinh vien nao!", "Thong bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi tim kiem: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                    txtMaSV.Text = row.Cells[0].Value?.ToString();
                    txtHoTen.Text = row.Cells[1].Value?.ToString();
                    string gioiTinh = row.Cells[2].Value?.ToString();
                    if (gioiTinh == "Nam")
                    {
                        cbNam.Checked = true;
                        cbNu.Checked = false;
                    }
                    else
                    {
                        cbNam.Checked = false;
                        cbNu.Checked = true;
                    }
                    cboKhoa.Text = row.Cells[3].Value?.ToString();
                    txtDTB.Text = row.Cells[4].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNam.Checked)
            {
                cbNu.Checked = false;
            }
        }

        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNu.Checked)
            {
                cbNam.Checked = false;
            }
        }
    }
}
