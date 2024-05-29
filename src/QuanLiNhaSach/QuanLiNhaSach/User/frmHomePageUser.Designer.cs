namespace QuanLiNhaSach
{
    partial class frmHomePageUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePageUser));
            this.cboAuthor = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnUserAccount = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvBook = new System.Windows.Forms.ListView();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAuthor
            // 
            this.cboAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboAuthor.FormattingEnabled = true;
            this.cboAuthor.Location = new System.Drawing.Point(500, 103);
            this.cboAuthor.Name = "cboAuthor";
            this.cboAuthor.Size = new System.Drawing.Size(400, 34);
            this.cboAuthor.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MintCream;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(10, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.SeaShell;
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCart.Location = new System.Drawing.Point(25, 250);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(250, 50);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "Xem giỏ hàng";
            this.btnCart.UseVisualStyleBackColor = false;
            // 
            // btnUserAccount
            // 
            this.btnUserAccount.BackColor = System.Drawing.Color.SeaShell;
            this.btnUserAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAccount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUserAccount.Location = new System.Drawing.Point(25, 350);
            this.btnUserAccount.Name = "btnUserAccount";
            this.btnUserAccount.Size = new System.Drawing.Size(250, 50);
            this.btnUserAccount.TabIndex = 3;
            this.btnUserAccount.Text = "Tài khoản";
            this.btnUserAccount.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.SeaShell;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogOut.Location = new System.Drawing.Point(25, 450);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(250, 50);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // cboGenre
            // 
            this.cboGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(500, 43);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(400, 34);
            this.cboGenre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(389, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thể loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(398, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tác giả:";
            // 
            // Code
            // 
            this.Code.Text = "Mã sách";
            this.Code.Width = 90;
            // 
            // Title
            // 
            this.Title.Text = "Tên sách";
            this.Title.Width = 360;
            // 
            // Author
            // 
            this.Author.Text = "Tác giả";
            this.Author.Width = 250;
            // 
            // Price
            // 
            this.Price.Text = "Giá tiền";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 130;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Số lượng";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Width = 100;
            // 
            // lsvBook
            // 
            this.lsvBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Title,
            this.Author,
            this.Price,
            this.Quantity});
            this.lsvBook.FullRowSelect = true;
            this.lsvBook.GridLines = true;
            this.lsvBook.HideSelection = false;
            this.lsvBook.Location = new System.Drawing.Point(10, 200);
            this.lsvBook.MultiSelect = false;
            this.lsvBook.Name = "lsvBook";
            this.lsvBook.Size = new System.Drawing.Size(945, 470);
            this.lsvBook.TabIndex = 4;
            this.lsvBook.UseCompatibleStateImageBehavior = false;
            this.lsvBook.View = System.Windows.Forms.View.Details;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.BackColor = System.Drawing.Color.MintCream;
            this.btnShowInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnShowInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowInfo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowInfo.Location = new System.Drawing.Point(170, 120);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(140, 40);
            this.btnShowInfo.TabIndex = 10;
            this.btnShowInfo.Text = "Thông tin sách";
            this.btnShowInfo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Controls.Add(this.btnUserAccount);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 680);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLiNhaSach.Properties.Resources.BookStorePink;
            this.pictureBox1.Location = new System.Drawing.Point(40, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lsvBook);
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 680);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel3.Controls.Add(this.lblTenKH);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cboGenre);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnShowInfo);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.cboAuthor);
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 180);
            this.panel3.TabIndex = 11;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(110, 30);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(19, 22);
            this.lblTenKH.TabIndex = 12;
            this.lblTenKH.Text = "?";
            this.lblTenKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLiNhaSach.Properties.Resources.Employee;
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // frmHomePageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHomePageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboAuthor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnUserAccount;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ListView lsvBook;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}