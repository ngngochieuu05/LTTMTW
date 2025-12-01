using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02_02_QuanLiSinhVien_NgNgocHieu
{
    public partial class frmQuanLiSinhVien_Load : Form
    {
        private int tongSVNam = 0;
        private int tongSVNu = 0;

        public frmQuanLiSinhVien_Load()
        {
            InitializeComponent();
        }

        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value != null &&
                    dgvStudent.Rows[i].Cells[0].Value.ToString().Equals(studentID, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtStudentID.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtFullName.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = optFemale.Checked ? "Nu" : "Nam";

            float diemTB = float.Parse(txtAverageScore.Text.Trim());
            dgvStudent.Rows[selectedRow].Cells[3].Value = diemTB.ToString("F2");

            dgvStudent.Rows[selectedRow].Cells[4].Value = cmbFaculty.Text;
        }

        private void ClearInputs()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();

            optMale.Checked = false;
            optFemale.Checked = false;

            cmbFaculty.SelectedIndex = 0;

            txtStudentID.Focus();
        }

        private void TinhTongVaHienThi()
        {
            tongSVNam = 0;
            tongSVNu = 0;

            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[2].Value != null)
                {
                    string gioiTinh = dgvStudent.Rows[i].Cells[2].Value.ToString();
                    if (gioiTinh == "Nam")
                    {
                        tongSVNam++;
                    }
                    else if (gioiTinh == "Nu")
                    {
                        tongSVNu++;
                    }
                }
            }

            txtTongNam.Text = tongSVNam.ToString();
            txtTongNu.Text = tongSVNu.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFaculty.SelectedIndex = 0;

            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudent.AllowUserToAddRows = false;
        }

        private void btnThem_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                    string.IsNullOrWhiteSpace(txtFullName.Text) ||
                    string.IsNullOrWhiteSpace(txtAverageScore.Text) ||
                    (!optMale.Checked && !optFemale.Checked))
                {
                    throw new Exception("Vui long nhap day du thong tin sinh vien!");
                }

                float diemTB;
                if (!float.TryParse(txtAverageScore.Text.Trim(), out diemTB))
                {
                    throw new Exception("Diem TB phai la mot so hop le!");
                }
                if (diemTB < 0 || diemTB > 10)
                {
                    throw new Exception("Diem TB phai nam trong khoang tu 0 den 10.");
                }

                int selectedRow = GetSelectedRow(txtStudentID.Text);

                if (selectedRow == -1)
                {
                    int newRowIndex = dgvStudent.Rows.Add();
                    InsertUpdate(newRowIndex);
                    MessageBox.Show("Them moi du lieu sinh vien thanh cong!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cap nhat du lieu sinh vien thanh cong!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClearInputs();

                TinhTongVaHienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Cho phep xoa truc tiep bang cach chon dong ma khong can nhap MSSV
                if (string.IsNullOrWhiteSpace(txtStudentID.Text))
                {
                    if (dgvStudent.CurrentRow != null && dgvStudent.CurrentRow.Index >= 0 && dgvStudent.CurrentRow.Cells[0].Value != null)
                    {
                        // Lay MSSV tu dong dang duoc chon
                        txtStudentID.Text = dgvStudent.CurrentRow.Cells[0].Value.ToString();
                    }
                    else
                    {
                        throw new Exception("Vui long chon sinh vien can xoa trong bang!");
                    }
                }

                int selectedRow = GetSelectedRow(txtStudentID.Text);

                if (selectedRow == -1)
                {
                    throw new Exception("Khong tim thay MSSV can xoa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Ban co muon xoa sinh vien nay khong?", "Xac nhan xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xoa thong tin sinh vien thanh cong!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ClearInputs();

                TinhTongVaHienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvStudent.Rows.Count)
            {
                if (dgvStudent.Rows[e.RowIndex].Cells[0].Value == null) return;

                DataGridViewRow selectedRow = dgvStudent.Rows[e.RowIndex];

                txtStudentID.Text = selectedRow.Cells[0].Value?.ToString();
                txtFullName.Text = selectedRow.Cells[1].Value?.ToString();

                string gioiTinh = selectedRow.Cells[2].Value?.ToString();
                if (gioiTinh == "Nam")
                {
                    optMale.Checked = true;
                }
                else if (gioiTinh == "Nu")
                {
                    optFemale.Checked = true;
                }
                else
                {
                    optMale.Checked = false;
                    optFemale.Checked = false;
                }

                txtAverageScore.Text = selectedRow.Cells[3].Value?.ToString();
                cmbFaculty.Text = selectedRow.Cells[4].Value?.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtMSSV_TextChanged(object sender, EventArgs e) { }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void optFemale_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}