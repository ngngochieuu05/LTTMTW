using System.Windows.Forms;

namespace BTVN3_NgNgocHieu
{
    partial class frmQuanLiSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ListView lvThongTinSinhVien;
        private ColumnHeader clmHeaderLastName;
        private ColumnHeader clmHeaderFirstName;
        private ColumnHeader clmHeaderPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtPhone;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblPhone;
        private Button btnAddName;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvThongTinSinhVien = new System.Windows.Forms.ListView();
            this.clmHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAddName = new System.Windows.Forms.Button();
            this.lblNguyenNgocHieu = new System.Windows.Forms.Label();
            this.lblQuanLISinhVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvThongTinSinhVien
            // 
            this.lvThongTinSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHeaderLastName,
            this.clmHeaderFirstName,
            this.clmHeaderPhone});
            this.lvThongTinSinhVien.FullRowSelect = true;
            this.lvThongTinSinhVien.GridLines = true;
            this.lvThongTinSinhVien.HideSelection = false;
            this.lvThongTinSinhVien.Location = new System.Drawing.Point(12, 12);
            this.lvThongTinSinhVien.MultiSelect = false;
            this.lvThongTinSinhVien.Name = "lvThongTinSinhVien";
            this.lvThongTinSinhVien.Size = new System.Drawing.Size(700, 400);
            this.lvThongTinSinhVien.TabIndex = 0;
            this.lvThongTinSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvThongTinSinhVien.View = System.Windows.Forms.View.Details;
            this.lvThongTinSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvThongTinSinhVien_SelectedIndexChanged);
            // 
            // clmHeaderLastName
            // 
            this.clmHeaderLastName.Text = "Last Name";
            this.clmHeaderLastName.Width = 230;
            // 
            // clmHeaderFirstName
            // 
            this.clmHeaderFirstName.Text = "First Name";
            this.clmHeaderFirstName.Width = 230;
            // 
            // clmHeaderPhone
            // 
            this.clmHeaderPhone.Text = "Phone";
            this.clmHeaderPhone.Width = 270;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(756, 166);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(250, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(756, 226);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(250, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(756, 286);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(756, 146);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(756, 206);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(756, 266);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(817, 339);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(150, 30);
            this.btnAddName.TabIndex = 7;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.buttonAddName_Click);
            // 
            // lblNguyenNgocHieu
            // 
            this.lblNguyenNgocHieu.AutoSize = true;
            this.lblNguyenNgocHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNguyenNgocHieu.Location = new System.Drawing.Point(798, 59);
            this.lblNguyenNgocHieu.Name = "lblNguyenNgocHieu";
            this.lblNguyenNgocHieu.Size = new System.Drawing.Size(190, 15);
            this.lblNguyenNgocHieu.TabIndex = 8;
            this.lblNguyenNgocHieu.Text = "Nguyen Ngoc Hieu - 2380600664";
            this.lblNguyenNgocHieu.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQuanLISinhVien
            // 
            this.lblQuanLISinhVien.AutoSize = true;
            this.lblQuanLISinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLISinhVien.Location = new System.Drawing.Point(752, 27);
            this.lblQuanLISinhVien.Name = "lblQuanLISinhVien";
            this.lblQuanLISinhVien.Size = new System.Drawing.Size(272, 20);
            this.lblQuanLISinhVien.TabIndex = 9;
            this.lblQuanLISinhVien.Text = "HE THONG QUAN LI SINH VIEN";
            this.lblQuanLISinhVien.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(756, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhap Thong Tin:";
            // 
            // frmQuanLiSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuanLISinhVien);
            this.Controls.Add(this.lblNguyenNgocHieu);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lvThongTinSinhVien);
            this.Name = "frmQuanLiSinhVien";
            this.Text = "ListView Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNguyenNgocHieu;
        private Label lblQuanLISinhVien;
        private Label label1;
    }
}

