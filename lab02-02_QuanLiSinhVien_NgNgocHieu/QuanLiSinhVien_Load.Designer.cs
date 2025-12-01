namespace lab02_02_QuanLiSinhVien_NgNgocHieu
{
    partial class frmQuanLiSinhVien_Load
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optMale = new System.Windows.Forms.CheckBox();
            this.optFemale = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.txtChuyenNganh = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho_va_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblNu = new System.Windows.Forms.Label();
            this.txtTongNam = new System.Windows.Forms.TextBox();
            this.txtTongNu = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(568, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1491, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "HE THONG QUAN LI SINH VIEN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(972, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(703, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "- HUTECH_by NG HIEU - ";
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optMale.Location = new System.Drawing.Point(312, 810);
            this.optMale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(132, 48);
            this.optMale.TabIndex = 3;
            this.optMale.Text = "Nam";
            this.optMale.UseVisualStyleBackColor = true;
            this.optMale.CheckedChanged += new System.EventHandler(this.optMale_CheckedChanged);
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optFemale.Location = new System.Drawing.Point(502, 810);
            this.optFemale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(99, 48);
            this.optFemale.TabIndex = 4;
            this.optFemale.Text = "Nu";
            this.optFemale.UseVisualStyleBackColor = true;
            this.optFemale.CheckedChanged += new System.EventHandler(this.optFemale_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(236, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 63);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thong Tin Sinh Vien ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTen.Location = new System.Drawing.Point(46, 658);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(213, 44);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "Ho va Ten: ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinh.Location = new System.Drawing.Point(46, 817);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(193, 44);
            this.lblGioiTinh.TabIndex = 7;
            this.lblGioiTinh.Text = "Gioi Tinh: ";
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiemTB.Location = new System.Drawing.Point(46, 981);
            this.lblDiemTB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(188, 44);
            this.lblDiemTB.TabIndex = 8;
            this.lblDiemTB.Text = "Diem TB: ";
            // 
            // txtChuyenNganh
            // 
            this.txtChuyenNganh.AutoSize = true;
            this.txtChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChuyenNganh.Location = new System.Drawing.Point(36, 1148);
            this.txtChuyenNganh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtChuyenNganh.Name = "txtChuyenNganh";
            this.txtChuyenNganh.Size = new System.Drawing.Size(291, 44);
            this.txtChuyenNganh.TabIndex = 10;
            this.txtChuyenNganh.Text = "Chuyen Nganh: ";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMSSV.Location = new System.Drawing.Point(46, 502);
            this.lblMSSV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(147, 44);
            this.lblMSSV.TabIndex = 12;
            this.lblMSSV.Text = "MSSV: ";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbFaculty.Location = new System.Drawing.Point(346, 1142);
            this.cmbFaculty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(328, 52);
            this.cmbFaculty.TabIndex = 13;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.Ho_va_Ten,
            this.Gioi_Tinh,
            this.DTB,
            this.Khoa});
            this.dgvStudent.Location = new System.Drawing.Point(1016, 381);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidth = 82;
            this.dgvStudent.Size = new System.Drawing.Size(1590, 937);
            this.dgvStudent.TabIndex = 14;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 10;
            this.MSSV.Name = "MSSV";
            // 
            // Ho_va_Ten
            // 
            this.Ho_va_Ten.HeaderText = "Ho_va_Ten";
            this.Ho_va_Ten.MinimumWidth = 10;
            this.Ho_va_Ten.Name = "Ho_va_Ten";
            // 
            // Gioi_Tinh
            // 
            this.Gioi_Tinh.HeaderText = "Gioi_Tinh";
            this.Gioi_Tinh.MinimumWidth = 10;
            this.Gioi_Tinh.Name = "Gioi_Tinh";
            // 
            // DTB
            // 
            this.DTB.HeaderText = "DTB";
            this.DTB.MinimumWidth = 10;
            this.DTB.Name = "DTB";
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 10;
            this.Khoa.Name = "Khoa";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFullName.Location = new System.Drawing.Point(296, 650);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(668, 58);
            this.txtFullName.TabIndex = 16;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAverageScore.Location = new System.Drawing.Point(292, 975);
            this.txtAverageScore.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAverageScore.Multiline = true;
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(378, 58);
            this.txtAverageScore.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(1602, 1350);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 44);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tong_SV_Nam: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(2210, 1350);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 44);
            this.label5.TabIndex = 19;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNam.Location = new System.Drawing.Point(1948, 1350);
            this.lblNam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(100, 44);
            this.lblNam.TabIndex = 20;
            this.lblNam.Text = "Nam";
            // 
            // lblNu
            // 
            this.lblNu.AutoSize = true;
            this.lblNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNu.Location = new System.Drawing.Point(2286, 1350);
            this.lblNu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNu.Name = "lblNu";
            this.lblNu.Size = new System.Drawing.Size(67, 44);
            this.lblNu.TabIndex = 21;
            this.lblNu.Text = "Nu";
            // 
            // txtTongNam
            // 
            this.txtTongNam.Location = new System.Drawing.Point(2066, 1344);
            this.txtTongNam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTongNam.Multiline = true;
            this.txtTongNam.Name = "txtTongNam";
            this.txtTongNam.Size = new System.Drawing.Size(172, 58);
            this.txtTongNam.TabIndex = 22;
            // 
            // txtTongNu
            // 
            this.txtTongNu.Location = new System.Drawing.Point(2374, 1346);
            this.txtTongNu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTongNu.Multiline = true;
            this.txtTongNu.Name = "txtTongNu";
            this.txtTongNu.Size = new System.Drawing.Size(176, 58);
            this.txtTongNu.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(54, 1313);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(296, 83);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Them / Sua";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnThem_Sua_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(526, 1313);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(296, 83);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Xoa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtStudentID.Location = new System.Drawing.Point(296, 487);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStudentID.Multiline = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(378, 58);
            this.txtStudentID.TabIndex = 15;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtMSSV_TextChanged);
            // 
            // frmQuanLiSinhVien_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 965);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTongNu);
            this.Controls.Add(this.txtTongNam);
            this.Controls.Add(this.lblNu);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAverageScore);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.txtChuyenNganh);
            this.Controls.Add(this.lblDiemTB);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.optFemale);
            this.Controls.Add(this.optMale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmQuanLiSinhVien_Load";
            this.Text = "Lab02-02_QuanLiSinhVien_NgHieu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox optMale;
        private System.Windows.Forms.CheckBox optFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label txtChuyenNganh;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblNu;
        private System.Windows.Forms.TextBox txtTongNam;
        private System.Windows.Forms.TextBox txtTongNu;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho_va_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_Tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.TextBox txtStudentID;
    }
}

