namespace QuanLiNhaSach
{
    partial class frmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(10, 10);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(685, 280);
            this.dgvBook.TabIndex = 4;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalPayment.Location = new System.Drawing.Point(495, 467);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.ReadOnly = true;
            this.txtTotalPayment.Size = new System.Drawing.Size(200, 34);
            this.txtTotalPayment.TabIndex = 11;
            this.txtTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTotalPayment.Location = new System.Drawing.Point(262, 470);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(217, 27);
            this.lblTotalPayment.TabIndex = 12;
            this.lblTotalPayment.Text = "Tổng tiền thanh toán:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Beige;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnExit.Location = new System.Drawing.Point(350, 510);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 40);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(535, 510);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(160, 40);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Đặt mua";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvBook);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.txtTotalPayment);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblTotalPayment);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 565);
            this.panel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(10, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 150);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(480, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 35);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa khỏi giỏ hàng";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(480, 63);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(170, 35);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Sửa số lượng";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(120, 107);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 34);
            this.txtTotalPrice.TabIndex = 9;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(360, 67);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 34);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(120, 67);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(130, 34);
            this.txtUnitPrice.TabIndex = 7;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(480, 27);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(170, 34);
            this.txtAuthor.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(120, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(280, 34);
            this.txtTitle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thành tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tác giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giỏ hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}