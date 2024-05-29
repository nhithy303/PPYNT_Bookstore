using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach.Admin
{
    public partial class frmDetailedInvoice_Print : Form
    {
        DataSet dsDetailedInvoice;
        string MaHD, NgayHD, TenKH, TongCong;
        public frmDetailedInvoice_Print(DataSet ds, string mahd, string ngayhd, string tenkh, string tongcong)
        {
            InitializeComponent();
            dsDetailedInvoice = new DataSet();
            dsDetailedInvoice = ds;
            MaHD = mahd; NgayHD = ngayhd; TenKH = tenkh; TongCong = tongcong;
        }
        
        private void frmDetailedInvoice_Print_Load(object sender, EventArgs e)
        {
            ReportDataSource source = new ReportDataSource("DetailedInvoice", dsDetailedInvoice.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            ReportParameter[] p = new ReportParameter[4];
            p[0] = new ReportParameter("pMaHD", MaHD, true);
            p[1] = new ReportParameter("pNgayHD", NgayHD, true);
            p[2] = new ReportParameter("pTenKH", TenKH, true);
            p[3] = new ReportParameter("pTongCong", TongCong, true);
            this.reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.RefreshReport();
        }
    }
}
