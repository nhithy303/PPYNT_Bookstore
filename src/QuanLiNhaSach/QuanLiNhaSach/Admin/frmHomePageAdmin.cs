using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using QuanLiNhaSach.Admin;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLiNhaSach
{
    public partial class frmHomePageAdmin : Form
    {
        string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
        SqlConnection conn = null;
        public frmHomePageAdmin()
        {
            InitializeComponent();
            conn = new SqlConnection(s);
            btnTrangChu.BackColor = Color.Goldenrod;
            fillChart();
        }
        private void fillChart()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "SELECT TENNXB, COUNT(Sach.MANXB) AS DAUSACH FROM Sach INNER JOIN NXB ON Sach.MANXB = NXB.MANXB GROUP BY TENNXB";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            ad.Fill(ds);
            chart1.DataSource = ds;
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                string tennxb = ds.Rows[i].Field<string>("TENNXB");
                int dausach = ds.Rows[i].Field<int>("DAUSACH");
                chart1.Series["Nhà xuất bản"].Points.AddXY(tennxb, dausach);
            }
        }
        private void frmHomePageAdmin_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Sach", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblTongSach.Text = dt.Rows[0][0].ToString();
            sda = new SqlDataAdapter("select count (*) from NhanVien", conn);
            dt = new DataTable();
            sda.Fill(dt);
            lblTongNV.Text = dt.Rows[0][0].ToString();
            conn.Close();
            sda = new SqlDataAdapter("select count (*) from KhachHang", conn);
            dt = new DataTable();
            sda.Fill(dt);
            lblTongKH.Text = dt.Rows[0][0].ToString();
            sda = new SqlDataAdapter("select sum(TongTien) from HoaDon", conn);
            dt = new DataTable();
            sda.Fill(dt);
            lblTongTien.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void chkBieuDoTron_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBieuDoTron.Checked == true)
            {
                chart1.Series[0].ChartType = SeriesChartType.Pie;
            }
            else
            {
                chart1.Series[0].ChartType = SeriesChartType.Column;
            }
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmOrderManagement().Show();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmBookManagement().Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmEmployeeManagement().Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCustomerAccount().Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất khỏi ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                this.Close();
            }
        }

        private void frmHomePageAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
