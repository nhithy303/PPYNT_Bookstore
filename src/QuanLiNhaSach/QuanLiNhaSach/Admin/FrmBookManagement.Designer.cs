namespace QuanLiNhaSach
{
    partial class FrmBookManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnSach = new FontAwesome.Sharp.IconButton();
            this.btnDonHang = new FontAwesome.Sharp.IconButton();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.txtSoLuongSach = new System.Windows.Forms.NumericUpDown();
            this.btnTomTat = new System.Windows.Forms.Button();
            this.ptbHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboNXB = new System.Windows.Forms.ComboBox();
            this.cboTacGia = new System.Windows.Forms.ComboBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaiAnhLen = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboAuthor = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.btnThemSach = new FontAwesome.Sharp.IconButton();
            this.btnSuaSach = new FontAwesome.Sharp.IconButton();
            this.btnXoaSach = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.TabIndex = 0;
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
            this.btnDangXuat.TabIndex = 28;
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
            this.btnTaiKhoan.TabIndex = 28;
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
            this.btnNhanVien.TabIndex = 28;
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
            this.btnSach.TabIndex = 28;
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
            this.btnDonHang.TabIndex = 28;
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
            this.btnTrangChu.TabIndex = 28;
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.txtSoLuongSach);
            this.groupBox1.Controls.Add(this.btnTomTat);
            this.groupBox1.Controls.Add(this.ptbHinhAnh);
            this.groupBox1.Controls.Add(this.btnTaiAnhLen);
            this.groupBox1.Controls.Add(this.txtTheLoai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboNXB);
            this.groupBox1.Controls.Add(this.cboTacGia);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGiaSach);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 304);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnXuatExcel.Location = new System.Drawing.Point(742, 400);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(174, 40);
            this.btnXuatExcel.TabIndex = 42;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // txtSoLuongSach
            // 
            this.txtSoLuongSach.Location = new System.Drawing.Point(158, 68);
            this.txtSoLuongSach.Name = "txtSoLuongSach";
            this.txtSoLuongSach.Size = new System.Drawing.Size(60, 34);
            this.txtSoLuongSach.TabIndex = 27;
            this.txtSoLuongSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTomTat
            // 
            this.btnTomTat.BackColor = System.Drawing.Color.Ivory;
            this.btnTomTat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTomTat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnTomTat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomTat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomTat.Location = new System.Drawing.Point(325, 258);
            this.btnTomTat.Name = "btnTomTat";
            this.btnTomTat.Size = new System.Drawing.Size(130, 35);
            this.btnTomTat.TabIndex = 22;
            this.btnTomTat.Text = "Tóm tắt";
            this.btnTomTat.UseVisualStyleBackColor = false;
            this.btnTomTat.Click += new System.EventHandler(this.btnTomTat_Click);
            // 
            // ptbHinhAnh
            // 
            this.ptbHinhAnh.BackColor = System.Drawing.Color.White;
            this.ptbHinhAnh.Location = new System.Drawing.Point(660, 15);
            this.ptbHinhAnh.Name = "ptbHinhAnh";
            this.ptbHinhAnh.Size = new System.Drawing.Size(280, 280);
            this.ptbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHinhAnh.TabIndex = 4;
            this.ptbHinhAnh.TabStop = false;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTheLoai.Location = new System.Drawing.Point(94, 127);
            this.txtTheLoai.Multiline = true;
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(190, 91);
            this.txtTheLoai.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(5, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Thể loại";
            // 
            // cboNXB
            // 
            this.cboNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNXB.FormattingEnabled = true;
            this.cboNXB.Location = new System.Drawing.Point(384, 181);
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Size = new System.Drawing.Size(270, 34);
            this.cboNXB.TabIndex = 20;
            // 
            // cboTacGia
            // 
            this.cboTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTacGia.FormattingEnabled = true;
            this.cboTacGia.Location = new System.Drawing.Point(384, 127);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Size = new System.Drawing.Size(270, 34);
            this.cboTacGia.TabIndex = 19;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSach.Location = new System.Drawing.Point(268, 24);
            this.txtTenSach.Multiline = true;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(386, 94);
            this.txtTenSach.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số lượng sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(-4, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(288, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(288, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(172, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên sách";
            // 
            // txtGiaSach
            // 
            this.txtGiaSach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaSach.Location = new System.Drawing.Point(97, 230);
            this.txtGiaSach.Name = "txtGiaSach";
            this.txtGiaSach.Size = new System.Drawing.Size(187, 34);
            this.txtGiaSach.TabIndex = 15;
            this.txtGiaSach.Text = " ";
            this.txtGiaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSach.Location = new System.Drawing.Point(106, 27);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(60, 34);
            this.txtMaSach.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã sách";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MistyRose;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(410, 400);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 40);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaiAnhLen
            // 
            this.btnTaiAnhLen.BackColor = System.Drawing.Color.MistyRose;
            this.btnTaiAnhLen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiAnhLen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnTaiAnhLen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiAnhLen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiAnhLen.Location = new System.Drawing.Point(484, 255);
            this.btnTaiAnhLen.Name = "btnTaiAnhLen";
            this.btnTaiAnhLen.Size = new System.Drawing.Size(150, 40);
            this.btnTaiAnhLen.TabIndex = 24;
            this.btnTaiAnhLen.Text = "Tải ảnh lên";
            this.btnTaiAnhLen.UseVisualStyleBackColor = false;
            this.btnTaiAnhLen.Click += new System.EventHandler(this.btnTaiAnhLen_Click);
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
            this.MaSach,
            this.TenSach,
            this.MaTG,
            this.TenTL,
            this.GiaSach,
            this.SLSach,
            this.MaNXB,
            this.NoiDung,
            this.HinhAnh});
            this.dgvList.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvList.Location = new System.Drawing.Point(10, 450);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(945, 230);
            this.dgvList.TabIndex = 3;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Beige;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cboGenre);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cboAuthor);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cboPublisher);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(10, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(945, 70);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(10, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thể loại";
            // 
            // cboGenre
            // 
            this.cboGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(94, 27);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(220, 34);
            this.cboGenre.TabIndex = 10;
            this.cboGenre.SelectedIndexChanged += new System.EventHandler(this.cboTheLoai_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(320, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 27);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tác giả";
            // 
            // cboAuthor
            // 
            this.cboAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboAuthor.FormattingEnabled = true;
            this.cboAuthor.Location = new System.Drawing.Point(400, 27);
            this.cboAuthor.Name = "cboAuthor";
            this.cboAuthor.Size = new System.Drawing.Size(220, 34);
            this.cboAuthor.TabIndex = 9;
            this.cboAuthor.SelectedIndexChanged += new System.EventHandler(this.cboAuthor_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(620, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 27);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tên NXB";
            // 
            // cboPublisher
            // 
            this.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(731, 27);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(200, 34);
            this.cboPublisher.TabIndex = 20;
            this.cboPublisher.SelectedIndexChanged += new System.EventHandler(this.cboPublisher_SelectedIndexChanged);
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThemSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnThemSach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemSach.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.btnThemSach.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThemSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemSach.IconSize = 28;
            this.btnThemSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSach.Location = new System.Drawing.Point(50, 400);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(150, 40);
            this.btnThemSach.TabIndex = 28;
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
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
            this.btnSuaSach.Location = new System.Drawing.Point(230, 400);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(150, 40);
            this.btnSuaSach.TabIndex = 28;
            this.btnSuaSach.Text = "Sửa sách";
            this.btnSuaSach.UseVisualStyleBackColor = false;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXoaSach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaSach.ForeColor = System.Drawing.Color.White;
            this.btnXoaSach.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaSach.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.btnXoaSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaSach.IconSize = 28;
            this.btnXoaSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSach.Location = new System.Drawing.Point(585, 400);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(150, 40);
            this.btnXoaSach.TabIndex = 28;
            this.btnXoaSach.Text = "Xóa sách";
            this.btnXoaSach.UseVisualStyleBackColor = false;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnXuatExcel);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnXoaSach);
            this.panel2.Controls.Add(this.btnSuaSach);
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Controls.Add(this.btnThemSach);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 680);
            this.panel2.TabIndex = 29;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MASACH";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TENSACH";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MATG";
            this.MaTG.HeaderText = "Mã tác giả";
            this.MaTG.MinimumWidth = 6;
            this.MaTG.Name = "MaTG";
            this.MaTG.ReadOnly = true;
            // 
            // TenTL
            // 
            this.TenTL.DataPropertyName = "TENTL";
            this.TenTL.HeaderText = "Tên thể loại";
            this.TenTL.MinimumWidth = 6;
            this.TenTL.Name = "TenTL";
            this.TenTL.ReadOnly = true;
            // 
            // GiaSach
            // 
            this.GiaSach.DataPropertyName = "GIASACH";
            this.GiaSach.HeaderText = "Giá sách";
            this.GiaSach.MinimumWidth = 6;
            this.GiaSach.Name = "GiaSach";
            this.GiaSach.ReadOnly = true;
            // 
            // SLSach
            // 
            this.SLSach.DataPropertyName = "SLSACH";
            this.SLSach.HeaderText = "Số lượng";
            this.SLSach.MinimumWidth = 6;
            this.SLSach.Name = "SLSach";
            this.SLSach.ReadOnly = true;
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MANXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.MinimumWidth = 6;
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "TomTat";
            this.NoiDung.HeaderText = "Tóm tắt";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            this.HinhAnh.Visible = false;
            // 
            // FrmBookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBookManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBookManagement_FormClosing);
            this.Load += new System.EventHandler(this.FrmBookManagement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboNXB;
        private System.Windows.Forms.ComboBox cboTacGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.PictureBox ptbHinhAnh;
        private System.Windows.Forms.Button btnTaiAnhLen;
        private System.Windows.Forms.NumericUpDown txtSoLuongSach;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnTomTat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboAuthor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboPublisher;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private FontAwesome.Sharp.IconButton btnDonHang;
        private FontAwesome.Sharp.IconButton btnSach;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnThemSach;
        private FontAwesome.Sharp.IconButton btnSuaSach;
        private FontAwesome.Sharp.IconButton btnXoaSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
    }
}