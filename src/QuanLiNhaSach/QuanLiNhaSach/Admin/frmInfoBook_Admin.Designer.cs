namespace QuanLiNhaSach.Admin
{
    partial class frmInfoBook_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoBook_Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoiDungCuonSach = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(170, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tóm tắt nội dung sách";
            // 
            // txtNoiDungCuonSach
            // 
            this.txtNoiDungCuonSach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoiDungCuonSach.Location = new System.Drawing.Point(0, 50);
            this.txtNoiDungCuonSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoiDungCuonSach.Multiline = true;
            this.txtNoiDungCuonSach.Name = "txtNoiDungCuonSach";
            this.txtNoiDungCuonSach.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoiDungCuonSach.Size = new System.Drawing.Size(600, 240);
            this.txtNoiDungCuonSach.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(350, 300);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 40);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(480, 300);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.txtNoiDungCuonSach);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 350);
            this.panel1.TabIndex = 3;
            // 
            // frmInfoBook_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInfoBook_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInfoBook_Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoiDungCuonSach;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
    }
}