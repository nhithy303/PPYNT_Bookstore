namespace QuanLiNhaSach
{
    partial class frmLoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginUser));
            this.lblUserNameText = new System.Windows.Forms.Label();
            this.lblPasswordText = new System.Windows.Forms.Label();
            this.lklAdmin = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLoginText = new System.Windows.Forms.Label();
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.ptbHide = new System.Windows.Forms.PictureBox();
            this.ptbUnHide = new System.Windows.Forms.PictureBox();
            this.lblTaoTK = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuenMK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnHide)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserNameText
            // 
            this.lblUserNameText.AutoSize = true;
            this.lblUserNameText.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblUserNameText.Location = new System.Drawing.Point(306, 132);
            this.lblUserNameText.Name = "lblUserNameText";
            this.lblUserNameText.Size = new System.Drawing.Size(150, 27);
            this.lblUserNameText.TabIndex = 1;
            this.lblUserNameText.Text = "Tên tài khoản:";
            // 
            // lblPasswordText
            // 
            this.lblPasswordText.AutoSize = true;
            this.lblPasswordText.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblPasswordText.Location = new System.Drawing.Point(330, 190);
            this.lblPasswordText.Name = "lblPasswordText";
            this.lblPasswordText.Size = new System.Drawing.Size(110, 27);
            this.lblPasswordText.TabIndex = 3;
            this.lblPasswordText.Text = "Mật khẩu:";
            // 
            // lklAdmin
            // 
            this.lklAdmin.AutoSize = true;
            this.lklAdmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lklAdmin.LinkColor = System.Drawing.Color.Chocolate;
            this.lklAdmin.Location = new System.Drawing.Point(430, 350);
            this.lklAdmin.Name = "lklAdmin";
            this.lklAdmin.Size = new System.Drawing.Size(291, 26);
            this.lklAdmin.TabIndex = 6;
            this.lklAdmin.TabStop = true;
            this.lklAdmin.Text = "Đăng nhập với tư cách Admin";
            this.lklAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklAdmin_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(370, 250);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserName.Location = new System.Drawing.Point(460, 125);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 38);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword.Location = new System.Drawing.Point(460, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 38);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblLoginText
            // 
            this.lblLoginText.AutoSize = true;
            this.lblLoginText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoginText.Location = new System.Drawing.Point(490, 70);
            this.lblLoginText.Name = "lblLoginText";
            this.lblLoginText.Size = new System.Drawing.Size(155, 26);
            this.lblLoginText.TabIndex = 0;
            this.lblLoginText.Text = "ĐĂNG NHẬP";
            // 
            // pictureLogin
            // 
            this.pictureLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogin.Image")));
            this.pictureLogin.Location = new System.Drawing.Point(10, 10);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(290, 375);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogin.TabIndex = 6;
            this.pictureLogin.TabStop = false;
            // 
            // ptbHide
            // 
            this.ptbHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbHide.Image = ((System.Drawing.Image)(resources.GetObject("ptbHide.Image")));
            this.ptbHide.Location = new System.Drawing.Point(720, 183);
            this.ptbHide.Name = "ptbHide";
            this.ptbHide.Size = new System.Drawing.Size(35, 35);
            this.ptbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHide.TabIndex = 7;
            this.ptbHide.TabStop = false;
            this.ptbHide.Click += new System.EventHandler(this.ptbHide_Click);
            // 
            // ptbUnHide
            // 
            this.ptbUnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbUnHide.Image = ((System.Drawing.Image)(resources.GetObject("ptbUnHide.Image")));
            this.ptbUnHide.Location = new System.Drawing.Point(720, 183);
            this.ptbUnHide.Name = "ptbUnHide";
            this.ptbUnHide.Size = new System.Drawing.Size(35, 35);
            this.ptbUnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbUnHide.TabIndex = 7;
            this.ptbUnHide.TabStop = false;
            this.ptbUnHide.Click += new System.EventHandler(this.ptUnHide_Click);
            // 
            // lblTaoTK
            // 
            this.lblTaoTK.AutoSize = true;
            this.lblTaoTK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTaoTK.Location = new System.Drawing.Point(400, 310);
            this.lblTaoTK.Name = "lblTaoTK";
            this.lblTaoTK.Size = new System.Drawing.Size(368, 26);
            this.lblTaoTK.TabIndex = 8;
            this.lblTaoTK.TabStop = true;
            this.lblTaoTK.Text = "Bạn chưa có tài khoản? Tạo tài khoản.";
            this.lblTaoTK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTaoTK_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureLogin);
            this.panel1.Controls.Add(this.lblTaoTK);
            this.panel1.Controls.Add(this.lblUserNameText);
            this.panel1.Controls.Add(this.ptbUnHide);
            this.panel1.Controls.Add(this.lblPasswordText);
            this.panel1.Controls.Add(this.ptbHide);
            this.panel1.Controls.Add(this.lklAdmin);
            this.panel1.Controls.Add(this.btnQuenMK);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblLoginText);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 395);
            this.panel1.TabIndex = 9;
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.BackColor = System.Drawing.Color.Goldenrod;
            this.btnQuenMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuenMK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnQuenMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuenMK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuenMK.ForeColor = System.Drawing.Color.White;
            this.btnQuenMK.Location = new System.Drawing.Point(550, 250);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(170, 40);
            this.btnQuenMK.TabIndex = 5;
            this.btnQuenMK.Text = "Quên mật khẩu";
            this.btnQuenMK.UseVisualStyleBackColor = false;
            this.btnQuenMK.Click += new System.EventHandler(this.btnQuenMK_Click);
            // 
            // frmLoginUser
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(786, 396);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoginUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnHide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserNameText;
        private System.Windows.Forms.Label lblPasswordText;
        private System.Windows.Forms.LinkLabel lklAdmin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLoginText;
        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.PictureBox ptbHide;
        private System.Windows.Forms.PictureBox ptbUnHide;
        private System.Windows.Forms.LinkLabel lblTaoTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuenMK;
    }
}

