namespace QuanLiNhaSach
{
    partial class frmCustomerAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnSach = new FontAwesome.Sharp.IconButton();
            this.btnDonHang = new FontAwesome.Sharp.IconButton();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDTTK = new System.Windows.Forms.TextBox();
            this.txtTenKHTK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSuaSach = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnSach);
            this.panel1.Controls.Add(this.btnDonHang);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Controls.Add(this.pictureBox1);
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
            this.btnDangXuat.TabIndex = 29;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
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
            this.btnTaiKhoan.TabIndex = 30;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
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
            this.btnNhanVien.TabIndex = 31;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
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
            this.btnSach.TabIndex = 32;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
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
            this.btnDonHang.TabIndex = 33;
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
            this.btnTrangChu.TabIndex = 34;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.txtGmail);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTenDN);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 150);
            this.panel2.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(724, 14);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(190, 34);
            this.txtMatKhau.TabIndex = 1;
            // 
            // txtGmail
            // 
            this.txtGmail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGmail.Location = new System.Drawing.Point(478, 54);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(260, 34);
            this.txtGmail.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(140, 97);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(210, 34);
            this.txtSDT.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKH.Location = new System.Drawing.Point(330, 17);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(300, 34);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDN.Location = new System.Drawing.Point(140, 57);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(210, 34);
            this.txtTenDN.TabIndex = 1;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKH.Location = new System.Drawing.Point(136, 14);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(54, 34);
            this.txtMaKH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(636, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label8.Location = new System.Drawing.Point(378, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Gmail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(10, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(196, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // dgvKH
            // 
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.AllowUserToDeleteRows = false;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SDT,
            this.TenGmail,
            this.TenDN,
            this.MK});
            this.dgvKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvKH.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvKH.GridColor = System.Drawing.Color.Black;
            this.dgvKH.Location = new System.Drawing.Point(10, 300);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(945, 380);
            this.dgvKH.TabIndex = 7;
            this.dgvKH.SelectionChanged += new System.EventHandler(this.dgvKH_SelectionChanged);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MAKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TENKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // TenGmail
            // 
            this.TenGmail.DataPropertyName = "TenGmail";
            this.TenGmail.HeaderText = "Tên Gmail";
            this.TenGmail.MinimumWidth = 6;
            this.TenGmail.Name = "TenGmail";
            this.TenGmail.ReadOnly = true;
            // 
            // TenDN
            // 
            this.TenDN.DataPropertyName = "TENDN";
            this.TenDN.HeaderText = "Tên đăng nhập";
            this.TenDN.MinimumWidth = 6;
            this.TenDN.Name = "TenDN";
            this.TenDN.ReadOnly = true;
            // 
            // MK
            // 
            this.MK.DataPropertyName = "MATKHAU";
            this.MK.HeaderText = "Mật khẩu";
            this.MK.MinimumWidth = 6;
            this.MK.Name = "MK";
            this.MK.ReadOnly = true;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.BurlyWood;
            this.btnNhapLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapLai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapLai.ForeColor = System.Drawing.Color.White;
            this.btnNhapLai.Location = new System.Drawing.Point(720, 250);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(170, 40);
            this.btnNhapLai.TabIndex = 2;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Controls.Add(this.txtSDTTK);
            this.groupBox1.Controls.Add(this.txtTenKHTK);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnXuatExcel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.groupBox1.Location = new System.Drawing.Point(10, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtSDTTK
            // 
            this.txtSDTTK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDTTK.Location = new System.Drawing.Point(530, 27);
            this.txtSDTTK.Name = "txtSDTTK";
            this.txtSDTTK.Size = new System.Drawing.Size(183, 34);
            this.txtSDTTK.TabIndex = 1;
            this.txtSDTTK.TextChanged += new System.EventHandler(this.txtSDTTK_TextChanged);
            // 
            // txtTenKHTK
            // 
            this.txtTenKHTK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKHTK.Location = new System.Drawing.Point(140, 27);
            this.txtTenKHTK.Name = "txtTenKHTK";
            this.txtTenKHTK.Size = new System.Drawing.Size(270, 34);
            this.txtTenKHTK.TabIndex = 1;
            this.txtTenKHTK.TextChanged += new System.EventHandler(this.txtTenKHTK_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(416, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Location = new System.Drawing.Point(773, 22);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(130, 33);
            this.btnXuatExcel.TabIndex = 41;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(10, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên khách hàng";
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
            this.btnXoa.Location = new System.Drawing.Point(290, 250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 40);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSuaSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSuaSach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaSach.IconChar = FontAwesome.Sharp.IconChar.StarOfDavid;
            this.btnSuaSach.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSuaSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaSach.IconSize = 28;
            this.btnSuaSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaSach.Location = new System.Drawing.Point(500, 250);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(170, 40);
            this.btnSuaSach.TabIndex = 30;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.UseVisualStyleBackColor = false;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnThem.Location = new System.Drawing.Point(70, 250);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(170, 40);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnNhapLai);
            this.panel3.Controls.Add(this.btnSuaSach);
            this.panel3.Controls.Add(this.dgvKH);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 680);
            this.panel3.TabIndex = 32;
            // 
            // frmCustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Tài khoản khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerAccount_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomerAccount_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDTTK;
        private System.Windows.Forms.TextBox txtTenKHTK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MK;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnSach;
        private FontAwesome.Sharp.IconButton btnDonHang;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSuaSach;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Panel panel3;
    }
}