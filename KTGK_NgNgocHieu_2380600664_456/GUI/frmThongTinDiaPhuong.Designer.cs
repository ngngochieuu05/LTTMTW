namespace GUI
{
    partial class frmThongTinDiaPhuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sapXepTheoSoCaNhiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuatBaoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.txtSoCaNhiem = new System.Windows.Forms.TextBox();
            this.txtTenDiaPhuong = new System.Windows.Forms.TextBox();
            this.txtMaDiaPhuong = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSoCaNhiem = new System.Windows.Forms.Label();
            this.lblTenDiaPhuong = new System.Windows.Forms.Label();
            this.lblMaDiaPhuong = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvDiaPhuong = new System.Windows.Forms.DataGridView();
            this.clmMaDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTenDiaPhuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCaNhiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaPhuong)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sapXepTheoSoCaNhiemToolStripMenuItem,
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem,
            this.xuatBaoCaoToolStripMenuItem});
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chucNangToolStripMenuItem.Text = "Chức năng";
            // 
            // sapXepTheoSoCaNhiemToolStripMenuItem
            // 
            this.sapXepTheoSoCaNhiemToolStripMenuItem.Name = "sapXepTheoSoCaNhiemToolStripMenuItem";
            this.sapXepTheoSoCaNhiemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.sapXepTheoSoCaNhiemToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.sapXepTheoSoCaNhiemToolStripMenuItem.Text = "Sắp xếp theo số ca nhiễm";
            this.sapXepTheoSoCaNhiemToolStripMenuItem.Click += new System.EventHandler(this.sapXepTheoSoCaNhiemToolStripMenuItem_Click);
            // 
            // cacDiaPhuongNhomNguyCoToolStripMenuItem
            // 
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem.Name = "cacDiaPhuongNhomNguyCoToolStripMenuItem";
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem.Text = "Các địa phương nhóm nguy cơ";
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem.Click += new System.EventHandler(this.cacDiaPhuongNhomNguyCoToolStripMenuItem_Click);
            // 
            // xuatBaoCaoToolStripMenuItem
            // 
            this.xuatBaoCaoToolStripMenuItem.Name = "xuatBaoCaoToolStripMenuItem";
            this.xuatBaoCaoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuatBaoCaoToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.xuatBaoCaoToolStripMenuItem.Text = "Xuất Báo cáo";
            this.xuatBaoCaoToolStripMenuItem.Click += new System.EventHandler(this.xuatBaoCaoToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(370, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(354, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tình hình dịch Covid 19";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.cboTrangThai);
            this.grpThongTin.Controls.Add(this.txtSoCaNhiem);
            this.grpThongTin.Controls.Add(this.txtTenDiaPhuong);
            this.grpThongTin.Controls.Add(this.txtMaDiaPhuong);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.lblSoCaNhiem);
            this.grpThongTin.Controls.Add(this.lblTenDiaPhuong);
            this.grpThongTin.Controls.Add(this.lblMaDiaPhuong);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.btnCapNhat);
            this.grpThongTin.Location = new System.Drawing.Point(12, 90);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(358, 350);
            this.grpThongTin.TabIndex = 2;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin địa phương";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Bình Thường",
            "Bình Thường Mới",
            "Cách Ly Xã Hội",
            "Khóa Chặt Đóng Cứng",
            "Hết Cứu"});
            this.cboTrangThai.Location = new System.Drawing.Point(141, 190);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(160, 24);
            this.cboTrangThai.TabIndex = 9;
            // 
            // txtSoCaNhiem
            // 
            this.txtSoCaNhiem.Location = new System.Drawing.Point(141, 145);
            this.txtSoCaNhiem.Name = "txtSoCaNhiem";
            this.txtSoCaNhiem.Size = new System.Drawing.Size(193, 22);
            this.txtSoCaNhiem.TabIndex = 8;
            // 
            // txtTenDiaPhuong
            // 
            this.txtTenDiaPhuong.Location = new System.Drawing.Point(141, 97);
            this.txtTenDiaPhuong.Name = "txtTenDiaPhuong";
            this.txtTenDiaPhuong.Size = new System.Drawing.Size(193, 22);
            this.txtTenDiaPhuong.TabIndex = 7;
            // 
            // txtMaDiaPhuong
            // 
            this.txtMaDiaPhuong.Location = new System.Drawing.Point(141, 45);
            this.txtMaDiaPhuong.Name = "txtMaDiaPhuong";
            this.txtMaDiaPhuong.Size = new System.Drawing.Size(193, 22);
            this.txtMaDiaPhuong.TabIndex = 6;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(20, 193);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(76, 16);
            this.lblTrangThai.TabIndex = 5;
            this.lblTrangThai.Text = "Trạng Thái:";
            // 
            // lblSoCaNhiem
            // 
            this.lblSoCaNhiem.AutoSize = true;
            this.lblSoCaNhiem.Location = new System.Drawing.Point(20, 148);
            this.lblSoCaNhiem.Name = "lblSoCaNhiem";
            this.lblSoCaNhiem.Size = new System.Drawing.Size(109, 16);
            this.lblSoCaNhiem.TabIndex = 4;
            this.lblSoCaNhiem.Text = "Số ca nhiễm mới:";
            // 
            // lblTenDiaPhuong
            // 
            this.lblTenDiaPhuong.AutoSize = true;
            this.lblTenDiaPhuong.Location = new System.Drawing.Point(16, 100);
            this.lblTenDiaPhuong.Name = "lblTenDiaPhuong";
            this.lblTenDiaPhuong.Size = new System.Drawing.Size(106, 16);
            this.lblTenDiaPhuong.TabIndex = 3;
            this.lblTenDiaPhuong.Text = "Tên Địa Phương:";
            // 
            // lblMaDiaPhuong
            // 
            this.lblMaDiaPhuong.AutoSize = true;
            this.lblMaDiaPhuong.Location = new System.Drawing.Point(20, 48);
            this.lblMaDiaPhuong.Name = "lblMaDiaPhuong";
            this.lblMaDiaPhuong.Size = new System.Drawing.Size(101, 16);
            this.lblMaDiaPhuong.TabIndex = 2;
            this.lblMaDiaPhuong.Text = "Mã Địa Phương:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(24, 260);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(143, 59);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(188, 260);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(146, 59);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dgvDiaPhuong
            // 
            this.dgvDiaPhuong.AllowUserToAddRows = false;
            this.dgvDiaPhuong.AllowUserToDeleteRows = false;
            this.dgvDiaPhuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiaPhuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaPhuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaDP,
            this.clnTenDiaPhuong,
            this.clmCaNhiem,
            this.colTrangThai});
            this.dgvDiaPhuong.Location = new System.Drawing.Point(376, 99);
            this.dgvDiaPhuong.MultiSelect = false;
            this.dgvDiaPhuong.Name = "dgvDiaPhuong";
            this.dgvDiaPhuong.ReadOnly = true;
            this.dgvDiaPhuong.RowHeadersVisible = false;
            this.dgvDiaPhuong.RowHeadersWidth = 51;
            this.dgvDiaPhuong.RowTemplate.Height = 24;
            this.dgvDiaPhuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiaPhuong.Size = new System.Drawing.Size(661, 341);
            this.dgvDiaPhuong.TabIndex = 3;
            this.dgvDiaPhuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiaPhuong_CellClick);
            this.dgvDiaPhuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiaPhuong_CellContentClick);
            // 
            // clmMaDP
            // 
            this.clmMaDP.HeaderText = "Mã ĐP";
            this.clmMaDP.MinimumWidth = 6;
            this.clmMaDP.Name = "clmMaDP";
            this.clmMaDP.ReadOnly = true;
            // 
            // clnTenDiaPhuong
            // 
            this.clnTenDiaPhuong.HeaderText = "Tên ĐP";
            this.clnTenDiaPhuong.MinimumWidth = 6;
            this.clnTenDiaPhuong.Name = "clnTenDiaPhuong";
            this.clnTenDiaPhuong.ReadOnly = true;
            // 
            // clmCaNhiem
            // 
            this.clmCaNhiem.HeaderText = "Ca Nhiễm";
            this.clmCaNhiem.MinimumWidth = 6;
            this.clmCaNhiem.Name = "clmCaNhiem";
            this.clmCaNhiem.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // frmThongTinDiaPhuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 461);
            this.Controls.Add(this.dgvDiaPhuong);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmThongTinDiaPhuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin địa phương";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaPhuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sapXepTheoSoCaNhiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacDiaPhuongNhomNguyCoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuatBaoCaoToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtSoCaNhiem;
        private System.Windows.Forms.TextBox txtTenDiaPhuong;
        private System.Windows.Forms.TextBox txtMaDiaPhuong;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSoCaNhiem;
        private System.Windows.Forms.Label lblTenDiaPhuong;
        private System.Windows.Forms.Label lblMaDiaPhuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvDiaPhuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTenDiaPhuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCaNhiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
