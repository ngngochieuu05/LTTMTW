using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DAL.Entities;

namespace GUI
{
    public partial class frmBaoCao : Form
    {
        private DiaPhuongBLL bll;

        public frmBaoCao()
        {
            InitializeComponent();
            bll = new DiaPhuongBLL();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            LoadTrangThai();
        }

        private void LoadTrangThai()
        {
            try
            {
                var dsTrangThai = bll.GetAllTrangThai();
                var allOption = new TrangThai { MaTT = 0, TenTT = "Tất cả" };
                var danhSachFull = new List<TrangThai> { allOption };
                danhSachFull.AddRange(dsTrangThai);
                
                cboTrangThai.DataSource = danhSachFull;
                cboTrangThai.DisplayMember = "TenTT";
                cboTrangThai.ValueMember = "MaTT";
                cboTrangThai.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trạng thái: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                int maTT = Convert.ToInt32(cboTrangThai.SelectedValue);
                List<DiaPhuong> danhSach;

                if (maTT == 0)
                    danhSach = bll.GetAll();
                else
                    danhSach = bll.GetAll().Where(dp => dp.MaTT == maTT).ToList();

                HienThiBaoCao(danhSach);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xem báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiBaoCao(List<DiaPhuong> danhSach)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaDP", typeof(string));
            dt.Columns.Add("TenDP", typeof(string));
            dt.Columns.Add("SoCaNhiem", typeof(int));

            foreach (var dp in danhSach)
            {
                dt.Rows.Add(dp.MaDP, dp.TenDP, dp.SoCaNhiemMoi);
            }

            dgvBaoCao.DataSource = dt;
            
            if (dgvBaoCao.Columns["MaDP"] != null)
                dgvBaoCao.Columns["MaDP"].HeaderText = "Mã ĐP";
            if (dgvBaoCao.Columns["TenDP"] != null)
                dgvBaoCao.Columns["TenDP"].HeaderText = "Tên ĐP";
            if (dgvBaoCao.Columns["SoCaNhiem"] != null)
                dgvBaoCao.Columns["SoCaNhiem"].HeaderText = "Số ca nhiễm";

            lblTieuDe.Text = $"Thông tin tình hình dịch bệnh\ntại các địa phương\n\nTình hình: {cboTrangThai.Text}";
            lblThongKe.Text = $"Tổng số địa phương: {danhSach.Count}\nTổng ca nhiễm: {danhSach.Sum(dp => dp.SoCaNhiemMoi)}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            bll?.Dispose();
        }
    }
}

