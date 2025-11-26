using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN3_NgNgocHieu
{
    public partial class frmQuanLiSinhVien : Form
    {
        public frmQuanLiSinhVien()
        {
            InitializeComponent();
        }

        private void buttonAddName_Click(object sender, EventArgs e)
        {
            var last = txtLastName.Text.Trim();
            var first = txtFirstName.Text.Trim();
            var phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(last) && string.IsNullOrEmpty(first) && string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Nhap thong tin vao di may!!!");
                return;
            }
            var item = new ListViewItem(last);
            item.SubItems.Add(first);
            item.SubItems.Add(phone);

            lvThongTinSinhVien.Items.Add(item);

            txtLastName.Clear();
            txtFirstName.Clear();
            txtPhone.Clear();
        }

        private void lvThongTinSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThongTinSinhVien.SelectedItems.Count == 0)
                return;

            var item = lvThongTinSinhVien.SelectedItems[0];
            txtLastName.Text = item.SubItems[0].Text;
            txtFirstName.Text = item.SubItems[1].Text;
            txtPhone.Text = item.SubItems[2].Text;
        }

        // placeholder handlers referenced by designer
        private void llblNguyenNgocHieu_LinkClicked(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}