namespace QuanLiNhaSach
{
    partial class frmDetailedInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailedInvoice));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtCodeOrder = new System.Windows.Forms.TextBox();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.txtSumCost = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.dgvAddBook = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPayPrint = new System.Windows.Forms.Button();
            this.gbThemSach = new System.Windows.Forms.GroupBox();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.gbOrderDetail = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBook)).BeginInit();
            this.gbThemSach.SuspendLayout();
            this.gbOrderDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã đơn hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng tiền thanh toán";
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.AllowUserToAddRows = false;
            this.dgvHoadon.AllowUserToDeleteRows = false;
            this.dgvHoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.MaSach,
            this.BookName,
            this.Count,
            this.Dongia,
            this.Thanhtien,
            this.Chon});
            this.dgvHoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHoadon.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvHoadon.Location = new System.Drawing.Point(270, 20);
            this.dgvHoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.RowHeadersWidth = 51;
            this.dgvHoadon.RowTemplate.Height = 24;
            this.dgvHoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoadon.Size = new System.Drawing.Size(805, 150);
            this.dgvHoadon.TabIndex = 14;
            // 
            // No
            // 
            this.No.HeaderText = "STT";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 70;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 98;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Tên sách";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.Width = 103;
            // 
            // Count
            // 
            this.Count.HeaderText = "Số lượng";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.Width = 103;
            // 
            // Dongia
            // 
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.MinimumWidth = 6;
            this.Dongia.Name = "Dongia";
            this.Dongia.Width = 94;
            // 
            // Thanhtien
            // 
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.MinimumWidth = 6;
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.Width = 113;
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.MinimumWidth = 6;
            this.Chon.Name = "Chon";
            this.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Chon.Width = 76;
            // 
            // txtCodeOrder
            // 
            this.txtCodeOrder.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCodeOrder.Location = new System.Drawing.Point(24, 60);
            this.txtCodeOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodeOrder.Name = "txtCodeOrder";
            this.txtCodeOrder.ReadOnly = true;
            this.txtCodeOrder.Size = new System.Drawing.Size(200, 29);
            this.txtCodeOrder.TabIndex = 15;
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNameCustomer.Location = new System.Drawing.Point(24, 140);
            this.txtNameCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.ReadOnly = true;
            this.txtNameCustomer.Size = new System.Drawing.Size(200, 29);
            this.txtNameCustomer.TabIndex = 15;
            // 
            // txtSumCost
            // 
            this.txtSumCost.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSumCost.Location = new System.Drawing.Point(24, 380);
            this.txtSumCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtSumCost.Name = "txtSumCost";
            this.txtSumCost.ReadOnly = true;
            this.txtSumCost.Size = new System.Drawing.Size(200, 29);
            this.txtSumCost.TabIndex = 15;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.OliveDrab;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuit.Location = new System.Drawing.Point(875, 560);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(200, 40);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // dgvAddBook
            // 
            this.dgvAddBook.AllowUserToAddRows = false;
            this.dgvAddBook.AllowUserToDeleteRows = false;
            this.dgvAddBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAddBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Namebook,
            this.SL,
            this.Gia,
            this.select});
            this.dgvAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAddBook.Location = new System.Drawing.Point(0, 30);
            this.dgvAddBook.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAddBook.Name = "dgvAddBook";
            this.dgvAddBook.RowHeadersWidth = 51;
            this.dgvAddBook.RowTemplate.Height = 24;
            this.dgvAddBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddBook.Size = new System.Drawing.Size(805, 260);
            this.dgvAddBook.TabIndex = 18;
            // 
            // Code
            // 
            this.Code.HeaderText = "Mã sách";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 98;
            // 
            // Namebook
            // 
            this.Namebook.HeaderText = "Tên sách";
            this.Namebook.MinimumWidth = 6;
            this.Namebook.Name = "Namebook";
            this.Namebook.Width = 103;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.Width = 103;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá thành";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 106;
            // 
            // select
            // 
            this.select.HeaderText = "Chọn";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            this.select.Width = 57;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Wheat;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddBook.Location = new System.Drawing.Point(705, 295);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 35);
            this.btnAddBook.TabIndex = 17;
            this.btnAddBook.Text = "Thêm";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Wheat;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(975, 180);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPayPrint
            // 
            this.btnPayPrint.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPayPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnPayPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayPrint.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPayPrint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPayPrint.Location = new System.Drawing.Point(650, 560);
            this.btnPayPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayPrint.Name = "btnPayPrint";
            this.btnPayPrint.Size = new System.Drawing.Size(200, 40);
            this.btnPayPrint.TabIndex = 19;
            this.btnPayPrint.Text = "In";
            this.btnPayPrint.UseVisualStyleBackColor = false;
            this.btnPayPrint.Click += new System.EventHandler(this.btnPayPrint_Click);
            // 
            // gbThemSach
            // 
            this.gbThemSach.BackColor = System.Drawing.Color.Transparent;
            this.gbThemSach.Controls.Add(this.dgvAddBook);
            this.gbThemSach.Controls.Add(this.btnAddBook);
            this.gbThemSach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThemSach.Location = new System.Drawing.Point(270, 210);
            this.gbThemSach.Name = "gbThemSach";
            this.gbThemSach.Size = new System.Drawing.Size(805, 340);
            this.gbThemSach.TabIndex = 20;
            this.gbThemSach.TabStop = false;
            this.gbThemSach.Text = "Thêm sách";
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPaymentMethod.Location = new System.Drawing.Point(24, 220);
            this.txtPaymentMethod.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.ReadOnly = true;
            this.txtPaymentMethod.Size = new System.Drawing.Size(200, 29);
            this.txtPaymentMethod.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(20, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hình thức thanh toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(20, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ngày hóa đơn";
            // 
            // datetime
            // 
            this.datetime.Enabled = false;
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime.Location = new System.Drawing.Point(24, 300);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 29);
            this.datetime.TabIndex = 26;
            // 
            // gbOrderDetail
            // 
            this.gbOrderDetail.Controls.Add(this.label3);
            this.gbOrderDetail.Controls.Add(this.datetime);
            this.gbOrderDetail.Controls.Add(this.label2);
            this.gbOrderDetail.Controls.Add(this.label6);
            this.gbOrderDetail.Controls.Add(this.label1);
            this.gbOrderDetail.Controls.Add(this.txtPaymentMethod);
            this.gbOrderDetail.Controls.Add(this.txtCodeOrder);
            this.gbOrderDetail.Controls.Add(this.label4);
            this.gbOrderDetail.Controls.Add(this.txtNameCustomer);
            this.gbOrderDetail.Controls.Add(this.txtSumCost);
            this.gbOrderDetail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderDetail.Location = new System.Drawing.Point(10, 10);
            this.gbOrderDetail.Name = "gbOrderDetail";
            this.gbOrderDetail.Size = new System.Drawing.Size(250, 540);
            this.gbOrderDetail.TabIndex = 27;
            this.gbOrderDetail.TabStop = false;
            this.gbOrderDetail.Text = "Đơn hàng";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.gbOrderDetail);
            this.panel1.Controls.Add(this.dgvHoadon);
            this.panel1.Controls.Add(this.gbThemSach);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnPayPrint);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 615);
            this.panel1.TabIndex = 28;
            // 
            // frmDetailedInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDetailedInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn chi tiết";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetailedInvoice_FormClosing);
            this.Load += new System.EventHandler(this.frmDetailedInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBook)).EndInit();
            this.gbThemSach.ResumeLayout(false);
            this.gbOrderDetail.ResumeLayout(false);
            this.gbOrderDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.TextBox txtCodeOrder;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.TextBox txtSumCost;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridView dgvAddBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.Button btnPayPrint;
        private System.Windows.Forms.GroupBox gbThemSach;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.GroupBox gbOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.Panel panel1;
    }
}