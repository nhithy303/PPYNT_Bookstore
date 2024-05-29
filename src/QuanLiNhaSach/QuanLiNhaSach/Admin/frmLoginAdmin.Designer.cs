namespace QuanLiNhaSach
{
    partial class frmLoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginAdmin));
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.ptbUnHide = new System.Windows.Forms.PictureBox();
            this.ptbHide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llblUserLogin = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(40, 200);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(250, 34);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(40, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(40, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtMK.Location = new System.Drawing.Point(40, 270);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(250, 34);
            this.txtMK.TabIndex = 3;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangnhap.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangnhap.Location = new System.Drawing.Point(95, 320);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(150, 40);
            this.btnDangnhap.TabIndex = 4;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // ptbUnHide
            // 
            this.ptbUnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbUnHide.Image = ((System.Drawing.Image)(resources.GetObject("ptbUnHide.Image")));
            this.ptbUnHide.Location = new System.Drawing.Point(290, 270);
            this.ptbUnHide.Name = "ptbUnHide";
            this.ptbUnHide.Size = new System.Drawing.Size(30, 30);
            this.ptbUnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbUnHide.TabIndex = 8;
            this.ptbUnHide.TabStop = false;
            this.ptbUnHide.Click += new System.EventHandler(this.ptbUnHide_Click);
            // 
            // ptbHide
            // 
            this.ptbHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbHide.Image = ((System.Drawing.Image)(resources.GetObject("ptbHide.Image")));
            this.ptbHide.Location = new System.Drawing.Point(290, 270);
            this.ptbHide.Name = "ptbHide";
            this.ptbHide.Size = new System.Drawing.Size(30, 30);
            this.ptbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHide.TabIndex = 9;
            this.ptbHide.TabStop = false;
            this.ptbHide.Click += new System.EventHandler(this.ptbHide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLiNhaSach.Properties.Resources.Admin;
            this.pictureBox1.Location = new System.Drawing.Point(95, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // llblUserLogin
            // 
            this.llblUserLogin.AutoSize = true;
            this.llblUserLogin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblUserLogin.Location = new System.Drawing.Point(3, 375);
            this.llblUserLogin.Name = "llblUserLogin";
            this.llblUserLogin.Size = new System.Drawing.Size(346, 27);
            this.llblUserLogin.TabIndex = 10;
            this.llblUserLogin.TabStop = true;
            this.llblUserLogin.Text = "Đăng nhập với tư cách khách hàng";
            this.llblUserLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llblUserLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblUserLogin_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.llblUserLogin);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Controls.Add(this.btnDangnhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ptbUnHide);
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.ptbHide);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 414);
            this.panel1.TabIndex = 11;
            // 
            // frmLoginAdmin
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(355, 411);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập Admin";
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.PictureBox ptbUnHide;
        private System.Windows.Forms.PictureBox ptbHide;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.LinkLabel llblUserLogin;
        private System.Windows.Forms.Panel panel1;
    }
}