namespace QuanLiNhaSach.Admin
{
    partial class frmDetailedInvoice_Print
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLiNhaSach.Admin.rptDetailedInvoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(496, 702);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmDetailedInvoice_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(514, 706);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDetailedInvoice_Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn chi tiết";
            this.Load += new System.EventHandler(this.frmDetailedInvoice_Print_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}