namespace QuanLiNhaSach
{
    partial class frmUserAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccount));
            this.lblUserNameText = new System.Windows.Forms.Label();
            this.lblPhoneNumberText = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblUserCode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserNameText
            // 
            this.lblUserNameText.AutoSize = true;
            this.lblUserNameText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUserNameText.Location = new System.Drawing.Point(3, 70);
            this.lblUserNameText.Name = "lblUserNameText";
            this.lblUserNameText.Size = new System.Drawing.Size(171, 27);
            this.lblUserNameText.TabIndex = 3;
            this.lblUserNameText.Text = "Tên khách hàng:";
            // 
            // lblPhoneNumberText
            // 
            this.lblPhoneNumberText.AutoSize = true;
            this.lblPhoneNumberText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhoneNumberText.Location = new System.Drawing.Point(20, 110);
            this.lblPhoneNumberText.Name = "lblPhoneNumberText";
            this.lblPhoneNumberText.Size = new System.Drawing.Size(143, 27);
            this.lblPhoneNumberText.TabIndex = 5;
            this.lblPhoneNumberText.Text = "Số điện thoại:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserName.Location = new System.Drawing.Point(180, 67);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(255, 34);
            this.txtUserName.TabIndex = 4;
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNumberPhone.Location = new System.Drawing.Point(180, 110);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(255, 34);
            this.txtNumberPhone.TabIndex = 6;
            this.txtNumberPhone.TextChanged += new System.EventHandler(this.txtNumberPhone_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Beige;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(160, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(315, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaKH.Location = new System.Drawing.Point(160, 30);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(24, 27);
            this.lblMaKH.TabIndex = 2;
            this.lblMaKH.Text = "1";
            // 
            // lblUserCode
            // 
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUserCode.Location = new System.Drawing.Point(20, 30);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(166, 27);
            this.lblUserCode.TabIndex = 0;
            this.lblUserCode.Text = "Mã khách hàng:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblUserCode);
            this.panel1.Controls.Add(this.lblMaKH);
            this.panel1.Controls.Add(this.lblUserNameText);
            this.panel1.Controls.Add(this.lblPhoneNumberText);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtNumberPhone);
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 215);
            this.panel1.TabIndex = 9;
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(444, 211);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản khách hàng";
            this.Load += new System.EventHandler(this.frmUserAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUserNameText;
        private System.Windows.Forms.Label lblPhoneNumberText;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtNumberPhone;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.Panel panel1;
    }
}