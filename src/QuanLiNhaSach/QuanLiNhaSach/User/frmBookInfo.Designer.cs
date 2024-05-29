namespace QuanLiNhaSach
{
    partial class frmBookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookInfo));
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbAuthor = new System.Windows.Forms.GroupBox();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.ptbBookInfo = new System.Windows.Forms.PictureBox();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtThongTinSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbBook.SuspendLayout();
            this.gbAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBookInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(845, 595);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(220, 40);
            this.btnAddToCart.TabIndex = 14;
            this.btnAddToCart.Text = "Thêm vào giỏ hàng";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Beige;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnExit.Location = new System.Drawing.Point(670, 595);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // gbBook
            // 
            this.gbBook.BackColor = System.Drawing.Color.OliveDrab;
            this.gbBook.Controls.Add(this.txtPublisher);
            this.gbBook.Controls.Add(this.txtPrice);
            this.gbBook.Controls.Add(this.txtGenre);
            this.gbBook.Controls.Add(this.lblPublisher);
            this.gbBook.Controls.Add(this.lblPrice);
            this.gbBook.Controls.Add(this.lblGenre);
            this.gbBook.Controls.Add(this.txtTitle);
            this.gbBook.Controls.Add(this.lblTitle);
            this.gbBook.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.gbBook.ForeColor = System.Drawing.Color.White;
            this.gbBook.Location = new System.Drawing.Point(20, 20);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(650, 150);
            this.gbBook.TabIndex = 17;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Thông tin sách";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Enabled = false;
            this.txtPublisher.Location = new System.Drawing.Point(140, 107);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(480, 34);
            this.txtPublisher.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(500, 67);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(120, 34);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGenre
            // 
            this.txtGenre.Enabled = false;
            this.txtGenre.Location = new System.Drawing.Point(140, 67);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(260, 34);
            this.txtGenre.TabIndex = 5;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.ForeColor = System.Drawing.Color.White;
            this.lblPublisher.Location = new System.Drawing.Point(20, 110);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(141, 27);
            this.lblPublisher.TabIndex = 4;
            this.lblPublisher.Text = "Nhà xuất bản";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(406, 70);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 27);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Giá tiền";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(20, 70);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(90, 27);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Thể loại";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(140, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(480, 34);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tên sách";
            // 
            // gbAuthor
            // 
            this.gbAuthor.BackColor = System.Drawing.Color.SeaGreen;
            this.gbAuthor.Controls.Add(this.txtBirthPlace);
            this.gbAuthor.Controls.Add(this.lblName);
            this.gbAuthor.Controls.Add(this.txtBirthYear);
            this.gbAuthor.Controls.Add(this.txtName);
            this.gbAuthor.Controls.Add(this.txtGender);
            this.gbAuthor.Controls.Add(this.lblGender);
            this.gbAuthor.Controls.Add(this.lblBirthPlace);
            this.gbAuthor.Controls.Add(this.lblBirthYear);
            this.gbAuthor.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.gbAuthor.ForeColor = System.Drawing.Color.White;
            this.gbAuthor.Location = new System.Drawing.Point(20, 180);
            this.gbAuthor.Name = "gbAuthor";
            this.gbAuthor.Size = new System.Drawing.Size(650, 120);
            this.gbAuthor.TabIndex = 18;
            this.gbAuthor.TabStop = false;
            this.gbAuthor.Text = "Thông tin tác giả";
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Enabled = false;
            this.txtBirthPlace.Location = new System.Drawing.Point(120, 67);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.ReadOnly = true;
            this.txtBirthPlace.Size = new System.Drawing.Size(260, 34);
            this.txtBirthPlace.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 27);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Bút danh";
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.Enabled = false;
            this.txtBirthYear.Location = new System.Drawing.Point(503, 67);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.ReadOnly = true;
            this.txtBirthYear.Size = new System.Drawing.Size(130, 34);
            this.txtBirthYear.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(120, 27);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(260, 34);
            this.txtName.TabIndex = 9;
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(503, 27);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(130, 34);
            this.txtGender.TabIndex = 13;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(400, 30);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(97, 27);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Giới tính";
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.Location = new System.Drawing.Point(20, 70);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(93, 27);
            this.lblBirthPlace.TabIndex = 12;
            this.lblBirthPlace.Text = "Nơi sinh";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(400, 70);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(103, 27);
            this.lblBirthYear.TabIndex = 11;
            this.lblBirthYear.Text = "Năm sinh";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblQuantity.Location = new System.Drawing.Point(520, 315);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(97, 27);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Số lượng";
            // 
            // ptbBookInfo
            // 
            this.ptbBookInfo.BackColor = System.Drawing.Color.White;
            this.ptbBookInfo.Location = new System.Drawing.Point(745, 20);
            this.ptbBookInfo.Name = "ptbBookInfo";
            this.ptbBookInfo.Size = new System.Drawing.Size(320, 320);
            this.ptbBookInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBookInfo.TabIndex = 22;
            this.ptbBookInfo.TabStop = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQuantity.Location = new System.Drawing.Point(610, 310);
            this.txtQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(60, 34);
            this.txtQuantity.TabIndex = 23;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtThongTinSach
            // 
            this.txtThongTinSach.BackColor = System.Drawing.Color.Beige;
            this.txtThongTinSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThongTinSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThongTinSach.Location = new System.Drawing.Point(20, 350);
            this.txtThongTinSach.Multiline = true;
            this.txtThongTinSach.Name = "txtThongTinSach";
            this.txtThongTinSach.ReadOnly = true;
            this.txtThongTinSach.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtThongTinSach.Size = new System.Drawing.Size(1045, 230);
            this.txtThongTinSach.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(20, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tóm tắt nội dung sách:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.gbBook);
            this.panel1.Controls.Add(this.txtThongTinSach);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.btnAddToCart);
            this.panel1.Controls.Add(this.ptbBookInfo);
            this.panel1.Controls.Add(this.gbAuthor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 655);
            this.panel1.TabIndex = 25;
            // 
            // frmBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1084, 651);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sách";
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.gbAuthor.ResumeLayout(false);
            this.gbAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBookInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.GroupBox gbAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.PictureBox ptbBookInfo;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.TextBox txtThongTinSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}