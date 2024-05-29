namespace QuanLiNhaSach
{
    partial class frmOrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderManagement));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbThemHoaDon = new System.Windows.Forms.GroupBox();
            this.cboTenKH = new System.Windows.Forms.ComboBox();
            this.cboHTTT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.cbNgayHD = new System.Windows.Forms.CheckBox();
            this.cboKenhMua = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTenKHTK = new System.Windows.Forms.ComboBox();
            this.dateTimeTK = new System.Windows.Forms.DateTimePicker();
            this.cboHTTK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.btnDonHang = new FontAwesome.Sharp.IconButton();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSach = new FontAwesome.Sharp.IconButton();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnHDChiTiet = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KenhMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.gbThemHoaDon.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel2.Controls.Add(this.gbThemHoaDon);
            this.panel2.Controls.Add(this.gbTimKiem);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 230);
            this.panel2.TabIndex = 12;
            // 
            // gbThemHoaDon
            // 
            this.gbThemHoaDon.BackColor = System.Drawing.Color.Moccasin;
            this.gbThemHoaDon.Controls.Add(this.label2);
            this.gbThemHoaDon.Controls.Add(this.cboTenKH);
            this.gbThemHoaDon.Controls.Add(this.cboHTTT);
            this.gbThemHoaDon.Controls.Add(this.label4);
            this.gbThemHoaDon.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThemHoaDon.Location = new System.Drawing.Point(20, 140);
            this.gbThemHoaDon.Name = "gbThemHoaDon";
            this.gbThemHoaDon.Size = new System.Drawing.Size(905, 70);
            this.gbThemHoaDon.TabIndex = 39;
            this.gbThemHoaDon.TabStop = false;
            this.gbThemHoaDon.Text = "Thêm hóa đơn";
            // 
            // cboTenKH
            // 
            this.cboTenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenKH.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cboTenKH.FormattingEnabled = true;
            this.cboTenKH.Location = new System.Drawing.Point(160, 27);
            this.cboTenKH.Name = "cboTenKH";
            this.cboTenKH.Size = new System.Drawing.Size(300, 34);
            this.cboTenKH.TabIndex = 2;
            // 
            // cboHTTT
            // 
            this.cboHTTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHTTT.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cboHTTT.FormattingEnabled = true;
            this.cboHTTT.Items.AddRange(new object[] {
            "Chuyển tiền",
            "Tiền mặt"});
            this.cboHTTT.Location = new System.Drawing.Point(670, 27);
            this.cboHTTT.Name = "cboHTTT";
            this.cboHTTT.Size = new System.Drawing.Size(200, 34);
            this.cboHTTT.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(490, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hình thức thanh toán";
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.BackColor = System.Drawing.Color.Moccasin;
            this.gbTimKiem.Controls.Add(this.cbNgayHD);
            this.gbTimKiem.Controls.Add(this.cboKenhMua);
            this.gbTimKiem.Controls.Add(this.label1);
            this.gbTimKiem.Controls.Add(this.cboTenKHTK);
            this.gbTimKiem.Controls.Add(this.dateTimeTK);
            this.gbTimKiem.Controls.Add(this.cboHTTK);
            this.gbTimKiem.Controls.Add(this.label3);
            this.gbTimKiem.Controls.Add(this.label7);
            this.gbTimKiem.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.gbTimKiem.Location = new System.Drawing.Point(20, 20);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(905, 110);
            this.gbTimKiem.TabIndex = 38;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // cbNgayHD
            // 
            this.cbNgayHD.AutoSize = true;
            this.cbNgayHD.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbNgayHD.Location = new System.Drawing.Point(6, 75);
            this.cbNgayHD.Name = "cbNgayHD";
            this.cbNgayHD.Size = new System.Drawing.Size(141, 26);
            this.cbNgayHD.TabIndex = 40;
            this.cbNgayHD.Text = "Ngày hóa đơn";
            this.cbNgayHD.UseVisualStyleBackColor = true;
            this.cbNgayHD.CheckedChanged += new System.EventHandler(this.cbNgayHD_CheckedChanged);
            // 
            // cboKenhMua
            // 
            this.cboKenhMua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKenhMua.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cboKenhMua.FormattingEnabled = true;
            this.cboKenhMua.Items.AddRange(new object[] {
            "Tất cả",
            "Chuyển tiền",
            "Tiền mặt"});
            this.cboKenhMua.Location = new System.Drawing.Point(670, 67);
            this.cboKenhMua.Name = "cboKenhMua";
            this.cboKenhMua.Size = new System.Drawing.Size(200, 34);
            this.cboKenhMua.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(490, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kênh mua";
            // 
            // cboTenKHTK
            // 
            this.cboTenKHTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenKHTK.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cboTenKHTK.FormattingEnabled = true;
            this.cboTenKHTK.Location = new System.Drawing.Point(160, 27);
            this.cboTenKHTK.Name = "cboTenKHTK";
            this.cboTenKHTK.Size = new System.Drawing.Size(300, 34);
            this.cboTenKHTK.TabIndex = 2;
            // 
            // dateTimeTK
            // 
            this.dateTimeTK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTK.Location = new System.Drawing.Point(160, 67);
            this.dateTimeTK.Name = "dateTimeTK";
            this.dateTimeTK.Size = new System.Drawing.Size(300, 34);
            this.dateTimeTK.TabIndex = 37;
            this.dateTimeTK.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cboHTTK
            // 
            this.cboHTTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHTTK.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cboHTTK.FormattingEnabled = true;
            this.cboHTTK.Items.AddRange(new object[] {
            "Tất cả",
            "Chuyển tiền",
            "Tiền mặt"});
            this.cboHTTK.Location = new System.Drawing.Point(670, 27);
            this.cboHTTK.Name = "cboHTTK";
            this.cboHTTK.Size = new System.Drawing.Size(200, 34);
            this.cboHTTK.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(490, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hình thức thanh toán";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnDonHang);
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSach);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 680);
            this.panel1.TabIndex = 10;
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
            this.btnDangXuat.TabIndex = 47;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
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
            this.btnDonHang.TabIndex = 51;
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = false;
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
            this.btnTaiKhoan.TabIndex = 48;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
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
            this.btnTrangChu.TabIndex = 52;
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
            this.btnNhanVien.TabIndex = 49;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLiNhaSach.Properties.Resources.BookStorePink;
            this.pictureBox1.Location = new System.Drawing.Point(40, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.btnSach.TabIndex = 50;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.BurlyWood;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(785, 250);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(170, 40);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "In Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnHDChiTiet
            // 
            this.btnHDChiTiet.BackColor = System.Drawing.Color.BurlyWood;
            this.btnHDChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHDChiTiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHDChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHDChiTiet.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHDChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnHDChiTiet.Location = new System.Drawing.Point(590, 250);
            this.btnHDChiTiet.Name = "btnHDChiTiet";
            this.btnHDChiTiet.Size = new System.Drawing.Size(170, 40);
            this.btnHDChiTiet.TabIndex = 7;
            this.btnHDChiTiet.Text = "Hóa đơn chi tiết";
            this.btnHDChiTiet.UseVisualStyleBackColor = false;
            this.btnHDChiTiet.Click += new System.EventHandler(this.btnHDChiTiet_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.TENKH,
            this.HinhThucTT,
            this.NgayHD,
            this.TongTien,
            this.KenhMua});
            this.dgvOrder.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvOrder.Location = new System.Drawing.Point(10, 300);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(945, 370);
            this.dgvOrder.TabIndex = 13;
            this.dgvOrder.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MAHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.MinimumWidth = 6;
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            // 
            // HinhThucTT
            // 
            this.HinhThucTT.DataPropertyName = "HinhThucTT";
            this.HinhThucTT.HeaderText = "Hình thức thanh toán";
            this.HinhThucTT.MinimumWidth = 6;
            this.HinhThucTT.Name = "HinhThucTT";
            this.HinhThucTT.ReadOnly = true;
            // 
            // NgayHD
            // 
            this.NgayHD.DataPropertyName = "NgayHD";
            this.NgayHD.HeaderText = "Ngày hóa đơn";
            this.NgayHD.MinimumWidth = 6;
            this.NgayHD.Name = "NgayHD";
            this.NgayHD.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // KenhMua
            // 
            this.KenhMua.DataPropertyName = "KenhMua";
            this.KenhMua.HeaderText = "Kênh mua";
            this.KenhMua.MinimumWidth = 6;
            this.KenhMua.Name = "KenhMua";
            this.KenhMua.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dgvOrder);
            this.panel3.Controls.Add(this.btnHDChiTiet);
            this.panel3.Controls.Add(this.btnExcel);
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 680);
            this.panel3.TabIndex = 14;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 28;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(390, 250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 40);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.btnThem.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 28;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(200, 250);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(170, 40);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.BurlyWood;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(10, 250);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(170, 40);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmOrderManagement_Load);
            this.panel2.ResumeLayout(false);
            this.gbThemHoaDon.ResumeLayout(false);
            this.gbThemHoaDon.PerformLayout();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboHTTT;
        private System.Windows.Forms.ComboBox cboTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboHTTK;
        private System.Windows.Forms.Button btnHDChiTiet;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.ComboBox cboTenKHTK;
        private System.Windows.Forms.DateTimePicker dateTimeTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboKenhMua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThemHoaDon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn KenhMua;
        private System.Windows.Forms.CheckBox cbNgayHD;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnDonHang;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnSach;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
    }
}