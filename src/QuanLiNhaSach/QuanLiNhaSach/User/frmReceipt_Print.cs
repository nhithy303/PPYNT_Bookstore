using Microsoft.Reporting.WinForms;
using QuanLiNhaSach.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach.User
{
    public partial class frmReceipt_Print : Form
    {
        DataSet dsReceipt;
        string TenKH, SDT, NgayHD, HinhThucTT, TongCong;
        public frmReceipt_Print(DataSet ds, string tenkh, string sdt, string hinhthuctt, DateTime ngayhd, string tongcong)
        {
            InitializeComponent();
            dsReceipt = new DataSet();
            dsReceipt = ds;
            TenKH = tenkh; SDT = sdt; HinhThucTT = hinhthuctt;
            NgayHD = ngayhd.ToString("dd/MM/yyyy"); TongCong = tongcong;
        }

        private void frmReceipt_Print_Load(object sender, EventArgs e)
        {
            ReportDataSource source = new ReportDataSource("Receipt", dsReceipt.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            ReportParameter[] p = new ReportParameter[5];
            p[0] = new ReportParameter("pTenKH", TenKH, true);
            p[1] = new ReportParameter("pSDT", SDT, true);
            p[2] = new ReportParameter("pNgayHD", NgayHD, true);
            p[3] = new ReportParameter("pHinhThucTT", HinhThucTT, true);
            p[4] = new ReportParameter("pTongCong", TongCong, true);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
