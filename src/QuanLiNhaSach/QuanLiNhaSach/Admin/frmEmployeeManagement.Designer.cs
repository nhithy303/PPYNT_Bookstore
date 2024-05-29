namespace QuanLiNhaSach.Admin
{
    partial class frmEmployeeManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManagement));
            this.label7 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnDonHang = new FontAwesome.Sharp.IconButton();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnSach = new FontAwesome.Sharp.IconButton();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.txtMucLuong = new System.Windows.Forms.NumericUpDown();
            this.cboCaLV = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtChucvu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMANQL = new System.Windows.Forms.TextBox();
            this.btnCapNhatLai = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenNVTK = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSDTTK = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboCLV = new System.Windows.Forms.ComboBox();
            this.btnXoaNV = new FontAwesome.Sharp.IconButton();
            this.btnSuaNV = new FontAwesome.Sharp.IconButton();
            this.btnThemNV = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMucLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label7.Location = new System.Drawing.Point(10, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Mức lương";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.DIACHI,
            this.LUONG,
            this.MaNQL,
            this.NGAYSINH,
            this.GT,
            this.SDT,
            this.ChucVu,
            this.CaLamViec});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvList.Location = new System.Drawing.Point(10, 370);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(945, 230);
            this.dgvList.TabIndex = 6;
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên NV";
            this.TENNV.MinimumWidth = 6;
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            // 
            // LUONG
            // 
            this.LUONG.DataPropertyName = "LUONG";
            this.LUONG.HeaderText = "Lương";
            this.LUONG.MinimumWidth = 6;
            this.LUONG.Name = "LUONG";
            this.LUONG.ReadOnly = true;
            // 
            // MaNQL
            // 
            this.MaNQL.DataPropertyName = "MANQL";
            this.MaNQL.HeaderText = "Mã NQL";
            this.MaNQL.MinimumWidth = 6;
            this.MaNQL.Name = "MaNQL";
            this.MaNQL.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // GT
            // 
            this.GT.DataPropertyName = "GT";
            this.GT.HeaderText = "Giới tính";
            this.GT.MinimumWidth = 6;
            this.GT.Name = "GT";
            this.GT.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "CHUCVU";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // CaLamViec
            // 
            this.CaLamViec.DataPropertyName = "CALAMVIEC";
            this.CaLamViec.HeaderText = "Ca làm việc";
            this.CaLamViec.MinimumWidth = 6;
            this.CaLamViec.Name = "CaLamViec";
            this.CaLamViec.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.panel1.Controls.Add(this.btnDonHang);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnSach);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 680);
            this.panel1.TabIndex = 4;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnDangXuat.IconColor = System.Drawing.Color.Salmon;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(15, 590);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(270, 60);
            this.btnDangXuat.TabIndex = 35;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLiNhaSach.Properties.Resources.BookStorePink;
            this.pictureBox1.Location = new System.Drawing.Point(40, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.PeachPuff;
            this.btnTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnTaiKhoan.IconColor = System.Drawing.Color.Salmon;
            this.btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(15, 520);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(270, 60);
            this.btnTaiKhoan.TabIndex = 36;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonHang.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDonHang.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnDonHang.IconColor = System.Drawing.Color.Salmon;
            this.btnDonHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.Location = new System.Drawing.Point(15, 310);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(270, 60);
            this.btnDonHang.TabIndex = 39;
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = false;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.PeachPuff;
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrangChu.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnTrangChu.IconColor = System.Drawing.Color.Salmon;
            this.btnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(15, 240);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(270, 60);
            this.btnTrangChu.TabIndex = 40;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.PeachPuff;
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnNhanVien.IconColor = System.Drawing.Color.Salmon;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(15, 450);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(270, 60);
            this.btnNhanVien.TabIndex = 37;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSach.IconChar = FontAwesome.Sharp.IconChar.BookJournalWhills;
            this.btnSach.IconColor = System.Drawing.Color.Salmon;
            this.btnSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSach.Location = new System.Drawing.Point(15, 380);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(270, 60);
            this.btnSach.TabIndex = 38;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(554, 66);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(120, 34);
            this.cboGioiTinh.TabIndex = 19;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtSDT.Location = new System.Drawing.Point(730, 67);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(212, 34);
            this.txtSDT.TabIndex = 17;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtTenNV.Location = new System.Drawing.Point(151, 63);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(294, 34);
            this.txtTenNV.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label5.Location = new System.Drawing.Point(613, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(10, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label6.Location = new System.Drawing.Point(679, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(453, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(-4, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtDiaChi.Location = new System.Drawing.Point(130, 107);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 87);
            this.txtDiaChi.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.datetime);
            this.groupBox1.Controls.Add(this.txtMucLuong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboCaLV);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtChucvu);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMANQL);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 270);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(727, 24);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(212, 34);
            this.datetime.TabIndex = 36;
            this.datetime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnXuatExcel.Location = new System.Drawing.Point(70, 623);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(130, 42);
            this.btnXuatExcel.TabIndex = 35;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtMucLuong.Location = new System.Drawing.Point(130, 207);
            this.txtMucLuong.Maximum = new decimal(new int[] {
            30000000,
            0,
            0,
            0});
            this.txtMucLuong.Minimum = new decimal(new int[] {
            1500000,
            0,
            0,
            0});
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.Size = new System.Drawing.Size(120, 34);
            this.txtMucLuong.TabIndex = 27;
            this.txtMucLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMucLuong.Value = new decimal(new int[] {
            1500000,
            0,
            0,
            0});
            // 
            // cboCaLV
            // 
            this.cboCaLV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaLV.FormattingEnabled = true;
            this.cboCaLV.Items.AddRange(new object[] {
            "Ca sáng",
            "Ca chiều",
            "Ca tối"});
            this.cboCaLV.Location = new System.Drawing.Point(552, 203);
            this.cboCaLV.Name = "cboCaLV";
            this.cboCaLV.Size = new System.Drawing.Size(182, 34);
            this.cboCaLV.TabIndex = 19;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtMaNV.Location = new System.Drawing.Point(130, 27);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(60, 34);
            this.txtMaNV.TabIndex = 16;
            // 
            // txtChucvu
            // 
            this.txtChucvu.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtChucvu.Location = new System.Drawing.Point(552, 122);
            this.txtChucvu.Multiline = true;
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.Size = new System.Drawing.Size(200, 72);
            this.txtChucvu.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(390, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã NQL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label12.Location = new System.Drawing.Point(420, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 27);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ca làm việc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label11.Location = new System.Drawing.Point(453, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 27);
            this.label11.TabIndex = 10;
            this.label11.Text = "Chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label8.Location = new System.Drawing.Point(10, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 27);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã NV";
            // 
            // txtMANQL
            // 
            this.txtMANQL.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtMANQL.Location = new System.Drawing.Point(490, 27);
            this.txtMANQL.Name = "txtMANQL";
            this.txtMANQL.Size = new System.Drawing.Size(60, 34);
            this.txtMANQL.TabIndex = 15;
            // 
            // btnCapNhatLai
            // 
            this.btnCapNhatLai.BackColor = System.Drawing.Color.MistyRose;
            this.btnCapNhatLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnCapNhatLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatLai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLai.Location = new System.Drawing.Point(220, 615);
            this.btnCapNhatLai.Name = "btnCapNhatLai";
            this.btnCapNhatLai.Size = new System.Drawing.Size(170, 50);
            this.btnCapNhatLai.TabIndex = 22;
            this.btnCapNhatLai.Text = "Cập nhật lại";
            this.btnCapNhatLai.UseVisualStyleBackColor = false;
            this.btnCapNhatLai.Click += new System.EventHandler(this.btnCapNhatLai_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Beige;
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTenNVTK);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtSDTTK);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cboCLV);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(10, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(945, 70);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label13.Location = new System.Drawing.Point(10, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 22);
            this.label13.TabIndex = 10;
            this.label13.Text = "Tên nhân viên";
            // 
            // txtTenNVTK
            // 
            this.txtTenNVTK.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtTenNVTK.Location = new System.Drawing.Point(134, 27);
            this.txtTenNVTK.Name = "txtTenNVTK";
            this.txtTenNVTK.Size = new System.Drawing.Size(300, 34);
            this.txtTenNVTK.TabIndex = 16;
            this.txtTenNVTK.TextChanged += new System.EventHandler(this.txtTenNVTK_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label14.Location = new System.Drawing.Point(440, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 22);
            this.label14.TabIndex = 12;
            this.label14.Text = "SĐT";
            // 
            // txtSDTTK
            // 
            this.txtSDTTK.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtSDTTK.Location = new System.Drawing.Point(490, 27);
            this.txtSDTTK.Name = "txtSDTTK";
            this.txtSDTTK.Size = new System.Drawing.Size(160, 34);
            this.txtSDTTK.TabIndex = 17;
            this.txtSDTTK.TextChanged += new System.EventHandler(this.txtSDTTK_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label15.Location = new System.Drawing.Point(660, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 22);
            this.label15.TabIndex = 10;
            this.label15.Text = "Ca làm việc";
            // 
            // cboCLV
            // 
            this.cboCLV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCLV.FormattingEnabled = true;
            this.cboCLV.Items.AddRange(new object[] {
            "Tất cả",
            "Ca sáng",
            "Ca chiều",
            "Ca tối"});
            this.cboCLV.Location = new System.Drawing.Point(770, 27);
            this.cboCLV.Name = "cboCLV";
            this.cboCLV.Size = new System.Drawing.Size(160, 34);
            this.cboCLV.TabIndex = 19;
            this.cboCLV.SelectedIndexChanged += new System.EventHandler(this.cboCLV_SelectedIndexChanged);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXoaNV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaNV.ForeColor = System.Drawing.Color.White;
            this.btnXoaNV.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaNV.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.btnXoaNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaNV.IconSize = 28;
            this.btnXoaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNV.Location = new System.Drawing.Point(785, 615);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(170, 50);
            this.btnXoaNV.TabIndex = 32;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSuaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSuaNV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaNV.IconChar = FontAwesome.Sharp.IconChar.StarOfDavid;
            this.btnSuaNV.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSuaNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaNV.IconSize = 28;
            this.btnSuaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNV.Location = new System.Drawing.Point(600, 615);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(170, 50);
            this.btnSuaNV.TabIndex = 33;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnThemNV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemNV.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.btnThemNV.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThemNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemNV.IconSize = 28;
            this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNV.Location = new System.Drawing.Point(410, 615);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(170, 50);
            this.btnThemNV.TabIndex = 34;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnXuatExcel);
            this.panel2.Controls.Add(this.btnXoaNV);
            this.panel2.Controls.Add(this.btnCapNhatLai);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btnThemNV);
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Controls.Add(this.btnSuaNV);
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 680);
            this.panel2.TabIndex = 35;
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployeeManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMucLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtMucLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMANQL;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Button btnCapNhatLai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboCaLV;
        private System.Windows.Forms.TextBox txtChucvu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaLamViec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenNVTK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSDTTK;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboCLV;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private FontAwesome.Sharp.IconButton btnDonHang;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnSach;
        private FontAwesome.Sharp.IconButton btnXoaNV;
        private FontAwesome.Sharp.IconButton btnSuaNV;
        private FontAwesome.Sharp.IconButton btnThemNV;
        private System.Windows.Forms.Panel panel2;
    }
}