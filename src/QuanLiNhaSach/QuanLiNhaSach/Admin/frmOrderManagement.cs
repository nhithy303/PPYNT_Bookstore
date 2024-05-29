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
using Excel = Microsoft.Office.Interop.Excel;
using QuanLiNhaSach.Admin;
using System.Web.ModelBinding;

namespace QuanLiNhaSach
{
    public partial class frmOrderManagement : Form
    {
        string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
        SqlConnection connection = null;
        DataTable dtTenKH, dtTenKHTK;
        public frmOrderManagement()
        {
            InitializeComponent();
            connection = new SqlConnection(s);
            btnDonHang.BackColor = Color.Goldenrod;
            dateTimeTK.Format = DateTimePickerFormat.Custom;
            dateTimeTK.CustomFormat = "dd'/'MM'/'yyyy";
            dtTenKH = new DataTable();
            dtTenKHTK = new DataTable();
            cboTenKH.SelectedIndexChanged += cboThem_SelectedIndexChanged;
            cboHTTT.SelectedIndexChanged += cboThem_SelectedIndexChanged;
        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            dtTenKH_Load();
            cboTenKH_Load();
            cboTenKHTK_Load();
            cboHTTT_Load();
            cboHTTK_Load();
            cboKenhMua_Load();
            Display();
            dateTimeTK.Value = DateTime.Now;
            gbThemHoaDon.Visible = false;
            btnThem.Text = "Thêm";
            btnXoa.Enabled = btnHDChiTiet.Enabled = false;
        }

        private void Display()
        {
            // load dgvOrder
            dgvOrder.DataSource = null;
            if (connection.State == ConnectionState.Closed) connection.Open();
            string str = "select hd.MAHD, kh.TENKH, hd.HinhThucTT, hd.NgayHD, hd.TongTien, hd.KenhMua" +
                " from HoaDon hd join KHACHHANG kh on kh.MAKH = hd.MAKH";
            SqlCommand cmd = new SqlCommand(str, connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connection.Close();
            dgvOrder.DataSource = dt;
            dgvOrder.Columns[0].HeaderText = "Mã hóa đơn";
            dgvOrder.Columns[1].HeaderText = "Tên khách hàng";
            dgvOrder.Columns[2].HeaderText = "Hình thức thanh toán";
            dgvOrder.Columns[3].HeaderText = "Ngày hóa đơn";
            dgvOrder.Columns[4].HeaderText = "Tổng tiền";
            dgvOrder.Columns[5].HeaderText = "Kênh mua";

            // reset gbTimKiem
            cboTenKHTK.SelectedIndex = 0;
            cboHTTK.SelectedIndex = 0;
            cboKenhMua.SelectedIndex = 0;
            cbNgayHD.Checked = false;
            dateTimeTK.Enabled = false;
        }

        private void dtTenKH_Load()
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select MAKH, TENKH from KHACHHANG";
                SqlDataAdapter sda = new SqlDataAdapter(new SqlCommand(query, connection));
                sda.Fill(dtTenKH);
                sda.Fill(dtTenKHTK);
                sda.Dispose();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                // insert allRow to dtTenKH
                DataRow allRow = dtTenKH.NewRow();
                allRow[0] = 0;
                allRow[1] = "Tất cả";
                dtTenKH.Rows.InsertAt(allRow, 0);
                // insert allRow to dtTenKHTK
                allRow = dtTenKHTK.NewRow();
                allRow[0] = 0;
                allRow[1] = "Tất cả";
                dtTenKHTK.Rows.InsertAt(allRow, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboTenKH_Load()
        {
            cboTenKH.DataSource = dtTenKH;
            cboTenKH.DisplayMember = "TENKH";
            cboTenKH.ValueMember = "MAKH";
            cboTenKH.SelectedIndex = 0;
        }

        private void cboTenKHTK_Load()
        {
            cboTenKHTK.DataSource = dtTenKHTK;
            cboTenKHTK.DisplayMember = "TENKH";
            cboTenKHTK.ValueMember = "MAKH";
            cboTenKHTK.SelectedIndex = 0;
        }

        private void cboHTTT_Load()
        {
            cboHTTT.Items.Clear();
            cboHTTT.Items.Add("Tất cả");
            cboHTTT.Items.Add("Chuyển tiền");
            cboHTTT.Items.Add("Tiền mặt");
            cboHTTT.SelectedIndex = 0;
        }

        private void cboHTTK_Load()
        {
            cboHTTK.Items.Clear();
            cboHTTK.Items.Add("Tất cả");
            cboHTTK.Items.Add("Chuyển tiền");
            cboHTTK.Items.Add("Tiền mặt");
            cboHTTK.SelectedIndex = 0;
        }

        private void cboKenhMua_Load()
        {
            cboKenhMua.Items.Clear();
            cboKenhMua.Items.Add("Tất cả");
            cboKenhMua.Items.Add("Online");
            cboKenhMua.Items.Add("Offline");
            cboKenhMua.SelectedIndex = 0;
        }

        private void cbNgayHD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNgayHD.Checked)
            {
                dateTimeTK.Enabled = true;
            }
            else
            {
                dateTimeTK.Enabled = false;
            }
        }

        private void cboThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenKH.SelectedIndex > 0 && cboHTTT.SelectedIndex > 0)
            {
                btnThem.Text = "Lưu";
            }
            else
            {
                btnThem.Text = "Hủy";
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvOrder.DataSource = null;
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select hd.MAHD, kh.TENKH, hd.HinhThucTT, hd.NgayHD, hd.TongTien, hd.KenhMua" +
                    " from HoaDon hd join KHACHHANG kh on kh.MAKH = hd.MAKH" +
                    " where hd.MAKH = ";
                if (cboTenKHTK.SelectedIndex > 0)
                {
                    query += cboTenKHTK.SelectedValue;
                }
                else { query += "hd.MAKH"; }
                query += " and hd.HinhThucTT = ";
                if (cboHTTK.SelectedIndex > 0)
                {
                    query += "N'" + cboHTTK.SelectedItem.ToString() + "'";
                }
                else { query += "hd.HinhThucTT"; }
                query += " and hd.KenhMua = ";
                if (cboKenhMua.SelectedIndex > 0)
                {
                    query += "'" + cboKenhMua.SelectedItem.ToString() + "'";
                }
                else { query += "hd.KenhMua"; }
                if (dateTimeTK.Enabled)
                {
                    query += " and hd.NgayHD = '" + dateTimeTK.Value.ToString("yyyy/MM/dd") + "'";
                }
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Dispose();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                if (dt.Rows.Count > 0)
                {
                    dgvOrder.DataSource = dt;
                    dgvOrder.Columns[0].HeaderText = "Mã hóa đơn";
                    dgvOrder.Columns[1].HeaderText = "Tên khách hàng";
                    dgvOrder.Columns[2].HeaderText = "Hình thức thanh toán";
                    dgvOrder.Columns[3].HeaderText = "Ngày hóa đơn";
                    dgvOrder.Columns[4].HeaderText = "Tổng tiền";
                    dgvOrder.Columns[5].HeaderText = "Kênh mua";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn tương ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                gbThemHoaDon.Visible = true;
                btnThem.Text = "Hủy";
                cboTenKH.SelectedIndex = 0;
                cboHTTT.SelectedIndex = 0;
                gbTimKiem.Enabled = false;
            }
            else if (btnThem.Text == "Hủy")
            {
                gbThemHoaDon.Visible = false;
                btnThem.Text = "Thêm";
                gbTimKiem.Enabled = true;
            }
            else
            {
                try
                {
                    if (cboTenKH.SelectedIndex == 0 || cboHTTT.SelectedIndex == 0)
                    {
                        MessageBox.Show("Vui lòng điền đẩy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (connection.State == ConnectionState.Closed) { connection.Open(); }
                        string str = "insert into HOADON (MAKH,HinhThucTT,NgayHD,TongTien,KenhMua) VALUES (@makh, @tt, @ngayhd, @tongtien, @kenhmua)";
                        SqlCommand cmd = new SqlCommand(str, connection);
                        cmd.Parameters.AddWithValue("@makh", cboTenKH.SelectedValue);
                        cmd.Parameters.AddWithValue("@tt", cboHTTT.SelectedItem);
                        cmd.Parameters.AddWithValue("@ngayhd", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@tongtien", 0);
                        cmd.Parameters.AddWithValue("@kenhmua", "Offline");
                        cmd.ExecuteNonQuery();
                        Display();
                        MessageBox.Show("Bạn đã thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        Display();

                        // Hiện frmDetailedInvoice thêm sách cho đơn hàng vừa tạo mới
                        DataGridViewRow latestRow = dgvOrder.Rows[dgvOrder.Rows.Count - 1];
                        string mahd = latestRow.Cells[0].Value.ToString();
                        string kenhmua = latestRow.Cells[5].Value.ToString();
                        new frmDetailedInvoice(mahd, kenhmua, false).ShowDialog();
                        Display();

                        // Đơn hàng vừa tạo mới bị hủy
                        latestRow = dgvOrder.Rows[dgvOrder.Rows.Count - 1];
                        if (latestRow.Cells[4].Value.ToString() == "0")
                        {
                            // delete latest order
                            try
                            {
                                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                                string query = "delete from HoaDon where MaHD = " + mahd;
                                SqlCommand cmd1 = new SqlCommand(query, connection);
                                cmd1.ExecuteNonQuery();
                                if (connection.State == ConnectionState.Open) { connection.Close(); }
                                Display();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                        // Ẩn chức năng Thêm & hiện chức năng Tìm kiếm
                        gbThemHoaDon.Visible = false;
                        btnThem.Text = "Thêm";
                        gbTimKiem.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string str = "delete from ChiTietHoaDon where MaHD = @mahd";
                SqlCommand cmd = new SqlCommand(str, connection);
                cmd.Parameters.AddWithValue("@mahd", dgvOrder.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                str = "delete from HOADON where MAHD = @mahd";
                cmd = new SqlCommand(str, connection);
                cmd.Parameters.AddWithValue("@mahd", dgvOrder.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                Display();
                MessageBox.Show("Bạn đã xóa thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHDChiTiet_Click(object sender, EventArgs e)
        {
            // Hiện frmDetailedInvoice để xem và in hóa đơn của đơn hàng đã thanh toán
            string mahd = dgvOrder.CurrentRow.Cells[0].Value.ToString();
            string kenhmua = dgvOrder.CurrentRow.Cells[5].Value.ToString();
            new frmDetailedInvoice(mahd, kenhmua, true).ShowDialog();
            Display();
        }

        void Export(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvOrder.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvOrder.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                for (int j = 0; j < dgvOrder.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvOrder.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất File";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Export(saveFileDialog.FileName);
                    MessageBox.Show("Bạn đã xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHomePageAdmin().Show();
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
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất khỏi ứng dụng không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmOrderManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                btnXoa.Enabled = btnHDChiTiet.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = btnHDChiTiet.Enabled = false;
            }
        }
    }
}
