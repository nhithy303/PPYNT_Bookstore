namespace QuanLiNhaSach
{
    partial class frmReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceipt));
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblPhoneNumberText = new System.Windows.Forms.Label();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTienMat = new System.Windows.Forms.CheckBox();
            this.chkChuyenTien = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.PowderBlue;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOrder.ForeColor = System.Drawing.Color.SeaShell;
            this.btnOrder.Location = new System.Drawing.Point(450, 550);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(270, 40);
            this.btnOrder.TabIndex = 21;
            this.btnOrder.Text = "Thanh toán và in hóa đơn";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Beige;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(280, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalPayment.Location = new System.Drawing.Point(292, 507);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(211, 26);
            this.lblTotalPayment.TabIndex = 20;
            this.lblTotalPayment.Text = "Tổng tiền thanh toán:";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(20, 300);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(700, 190);
            this.dgvBook.TabIndex = 14;
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNameText.Location = new System.Drawing.Point(100, 100);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(167, 26);
            this.lblNameText.TabIndex = 23;
            this.lblNameText.Text = "Tên khách hàng:";
            // 
            // lblPhoneNumberText
            // 
            this.lblPhoneNumberText.AutoSize = true;
            this.lblPhoneNumberText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhoneNumberText.Location = new System.Drawing.Point(100, 140);
            this.lblPhoneNumberText.Name = "lblPhoneNumberText";
            this.lblPhoneNumberText.Size = new System.Drawing.Size(141, 26);
            this.lblPhoneNumberText.TabIndex = 23;
            this.lblPhoneNumberText.Text = "Số điện thoại:";
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.BackColor = System.Drawing.Color.Transparent;
            this.lblReceipt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReceipt.Location = new System.Drawing.Point(43, 9);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(622, 78);
            this.lblReceipt.TabIndex = 24;
            this.lblReceipt.Text = "NHÀ SÁCH PPYNT\r\nĐịa chỉ: 280 An Dương Vương, Phường 4, Quận 5, TP.HCM\r\n--------HÓ" +
    "A ĐƠN--------\r\n";
            this.lblReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Enabled = false;
            this.txtNumberPhone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNumberPhone.Location = new System.Drawing.Point(250, 137);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(375, 34);
            this.txtNumberPhone.TabIndex = 26;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserName.Location = new System.Drawing.Point(250, 97);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(375, 34);
            this.txtUserName.TabIndex = 27;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtTotalPayment.Location = new System.Drawing.Point(520, 507);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.ReadOnly = true;
            this.txtTotalPayment.Size = new System.Drawing.Size(200, 34);
            this.txtTotalPayment.TabIndex = 28;
            this.txtTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(100, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ngày hóa đơn:";
            // 
            // datetime
            // 
            this.datetime.Enabled = false;
            this.datetime.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime.Location = new System.Drawing.Point(250, 177);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(375, 34);
            this.datetime.TabIndex = 37;
            this.datetime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Beige;
            this.groupBox1.Controls.Add(this.chkTienMat);
            this.groupBox1.Controls.Add(this.chkChuyenTien);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(250, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 70);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình thức thanh toán";
            // 
            // chkTienMat
            // 
            this.chkTienMat.AutoSize = true;
            this.chkTienMat.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.chkTienMat.Location = new System.Drawing.Point(240, 30);
            this.chkTienMat.Name = "chkTienMat";
            this.chkTienMat.Size = new System.Drawing.Size(118, 31);
            this.chkTienMat.TabIndex = 0;
            this.chkTienMat.Text = "Tiền mặt";
            this.chkTienMat.UseVisualStyleBackColor = true;
            // 
            // chkChuyenTien
            // 
            this.chkChuyenTien.AutoSize = true;
            this.chkChuyenTien.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.chkChuyenTien.Location = new System.Drawing.Point(30, 30);
            this.chkChuyenTien.Name = "chkChuyenTien";
            this.chkChuyenTien.Size = new System.Drawing.Size(151, 31);
            this.chkChuyenTien.TabIndex = 0;
            this.chkChuyenTien.Text = "Chuyển tiền";
            this.chkChuyenTien.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblReceipt);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvBook);
            this.panel1.Controls.Add(this.datetime);
            this.panel1.Controls.Add(this.lblTotalPayment);
            this.panel1.Controls.Add(this.txtTotalPayment);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtNumberPhone);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblNameText);
            this.panel1.Controls.Add(this.lblPhoneNumberText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 615);
            this.panel1.TabIndex = 39;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biên nhận";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblPhoneNumberText;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.TextBox txtNumberPhone;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTienMat;
        private System.Windows.Forms.CheckBox chkChuyenTien;
        private System.Windows.Forms.Panel panel1;
    }
}