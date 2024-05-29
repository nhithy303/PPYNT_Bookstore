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
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using ExcelDataReader;
using OfficeOpenXml;
using Z.Dapper.Plus;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System.Web.UI.WebControls;
using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;

namespace QuanLiNhaSach.Admin
{
    public partial class frmEmployeeManagement : Form
    {
        string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
        SqlConnection connection;
        public frmEmployeeManagement()
        {
            InitializeComponent();
            datetime.Format = DateTimePickerFormat.Custom;
            datetime.CustomFormat = "dd'/'MM'/'yyyy";
            btnNhanVien.BackColor = Color.Goldenrod;
            connection = new SqlConnection(s);
        }

        private void Display()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string str = "select nv.MANV, nv.TENNV, nv.DIACHI, NV.LUONG, nv.MANQL, nv.NGAYSINH,  nv.GT, nv.SDT, pc.CHUCVU, pc.CALAMVIEC\r\nfrom NHANVIEN nv join PHANCONG pc on nv.MANV = pc.MANV";
            SqlCommand cmd = new SqlCommand(str, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvList);
                row.Cells[0].Value = dr.GetInt32(0).ToString(); // ma sach
                row.Cells[1].Value = dr.GetString(1);
                row.Cells[2].Value = dr.GetString(2).ToString();
                row.Cells[3].Value = dr.GetDouble(3).ToString();
                if ((dr["MANQL"] != null && dr["MANQL"] != DBNull.Value) )

                {
                    row.Cells[4].Value = dr["MANQL"].ToString();
                }
                else if (dr["MANQL"].ToString() == "0")
                {
                    row.Cells[4].Value = DBNull.Value;
                }    
                else
                {
                    row.Cells[4].Value = DBNull.Value;
                }
                var tmp = dr.GetDateTime(5);
                row.Cells[5].Value = tmp.ToString("MM/dd/yyyy"); // do trong excel chi de dươc thang - nam - ngay --> quên khiến mất nhiều thời gian.
                row.Cells[6].Value = dr.GetString(6).ToString();
                row.Cells[7].Value = dr.GetString(7).ToString();
                row.Cells[8].Value = dr.GetString(8).ToString();
                row.Cells[9].Value = dr.GetString(9).ToString();
                dgvList.Rows.Add(row);
            }
            dr.Close();
            connection.Close();
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvList.CurrentRow;
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtMucLuong.Text = row.Cells[3].Value.ToString();
                txtMANQL.Text = row.Cells[4].Value.ToString();
                cboGioiTinh.SelectedItem = row.Cells[6].Value.ToString();
                txtSDT.Text = row.Cells[7].Value.ToString();
                txtChucvu.Text = row.Cells[8].Value.ToString();
                cboCaLV.SelectedItem = row.Cells[9].Value.ToString();
                datetime.Text = row.Cells[5].Value.ToString();
            }
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            Display();    
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text; 
            try
            {
                if (txtDiaChi.Text == string.Empty || cboGioiTinh.SelectedIndex == -1 || txtMaNV.Text == string.Empty || txtSDT.Text == string.Empty || txtTenNV.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa điền đẩy đủ thông tin của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtMANQL.Text == string.Empty && !KT_KhoaNgoai(txtMANQL.Text) )
                {
                    MessageBox.Show("Bạn nhân viên này đang quản lý các bạn khác.\nKhông thể xóa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                } 
                    
                else
                {
                    dgvList.Rows.Clear();
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string str = "delete from PHANCONG where MANV = @manv";
                    SqlCommand cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@manv", manv);
                    cmd.ExecuteNonQuery();
                    str = "delete from NHANVIEN where MANV = @manv";

                    cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@manv", txtMaNV.Text);
                    cmd.ExecuteNonQuery();                  
                    Display();
                    Reset();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiaChi.Text == string.Empty || cboGioiTinh.SelectedIndex == -1 || txtMaNV.Text == string.Empty || txtSDT.Text == string.Empty || txtTenNV.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa điền đẩy đủ thông tin của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string str = "";
                    dgvList.Rows.Clear();
                    str = "update PHANCONG set CHUCVU = @cv, CALAMVIEC = @clv where MANV = @manv";
                    SqlCommand cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@cv", txtChucvu.Text);
                    cmd.Parameters.AddWithValue("@clv", cboCaLV.SelectedItem);
                    cmd.Parameters.AddWithValue("@manv", int.Parse(txtMaNV.Text));
                    cmd.ExecuteNonQuery();
                    if (txtMANQL.Text != string.Empty)// dan thuong
                        str = "update NHANVIEN set TENNV = @tennv, DIACHI = @diachi, LUONG = @luong, MANQL = @manql,NGAYSINH = @ngaysinh, GT = @gt, SDT= @sdt where MANV = @manv";
                       // str = "alter procedure capnhat2bang @manv int\r\nas\r\nbegin\r\n\tupdate NHANVIEN set TENNV = @tennv, DIACHI = @diachi, LUONG = @luong, MANQL = @manql,NGAYSINH = @ngaysinh, GT = @gt, SDT= @sdt where MANV = @manv\r\n\tupdate PHANCONG set CHUCVU = @cv, CALAMVIEC = @clv where MANV  = @manv\r\nend";
                    else str = "update NHANVIEN set TENNV = @tennv, DIACHI = @diachi, LUONG = @luong,NGAYSINH = @ngaysinh, GT = @gt, SDT= @sdt where MANV = @manv";
                    cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@tennv", txtTenNV.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@luong", txtMucLuong.Value);
                    if (txtMANQL.Text != string.Empty) cmd.Parameters.AddWithValue("@manql", txtMANQL.Text);
                    if (!validNgaySinh(datetime.Value))
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cmd.Parameters.AddWithValue("@ngaysinh", datetime.Value.ToString("yyyy'-'MM'-'dd"));
                    cmd.Parameters.AddWithValue("@gt", cboGioiTinh.SelectedItem);
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@manv", int.Parse(txtMaNV.Text));
                    cmd.ExecuteNonQuery();
                   
                    Display();
                    Reset();
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Reset()
        {
            txtDiaChi.Clear();
            txtMANQL.Clear();
            txtMucLuong.Value = 1500000;
            txtSDT.Clear();
            txtTenNV.Clear();
            datetime.Text = "01/01/2000";
            txtMaNV.Clear();
            txtChucvu.Clear();
            cboCaLV.SelectedIndex = -1;
            cboGioiTinh.SelectedIndex = -1;
        }

        public bool KT_KhoaChinh(string pMa, string sdt)
        {
            connection.Open();
            string str = "select count(MANV) from NHANVIEN  where TENNV = N'" + pMa + "' and SDT = '" + sdt + "'";
            SqlCommand cmd = new SqlCommand(str, connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.FieldCount == 1)
            {
                rd.Close();
                connection.Close();
                return false;
            }    
            else
            {
                rd.Close();
                connection.Close();
                return true;
            }
        }

        public bool KT_KhoaNgoai(string MANQL)
        {
            connection.Open();
            string str = "select count(MANV) from NHANVIEN where MANQL = cast(@manql as int)";
            SqlCommand cmd = new SqlCommand(str, connection);
            cmd.Parameters.AddWithValue("@manql", MANQL);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                connection.Close();
                return false;
            }
            else
            {
                rd.Close();
                connection.Close();
                return true;
            }
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string str = "";
            txtMucLuong.Text = string.Empty;
            try
            {
                if (txtDiaChi.Text == string.Empty || cboGioiTinh.SelectedIndex == -1  || txtSDT.Text == string.Empty || txtTenNV.Text == string.Empty || txtChucvu.Text == String.Empty || cboCaLV.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa điền đẩy đủ thông tin của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (KT_KhoaChinh(txtTenNV.Text, txtSDT.Text))
                {
                    MessageBox.Show("Bạn điền trùng tên và số điện thoại với nhân viên đang có trong bộ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    dgvList.Rows.Clear();
                    if (txtMANQL.Text != string.Empty)
                    str = "insert NHANVIEN (TENNV, DIACHI, LUONG, MANQL, NGAYSINH, GT, SDT) " +
                    "values (@tennv, @diachi, @luong, @manql, @ngaysinh, @gt, @sdt)";
                    else str  = "insert NHANVIEN(TENNV, DIACHI, LUONG, MANQL, NGAYSINH, GT, SDT) " +
                    "values (@tennv, @diachi, @luong, NULL, @ngaysinh, @gt, @sdt)";
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@tennv", txtTenNV.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@luong", txtMucLuong.Value);
                    if(txtMANQL.Text != string.Empty) cmd.Parameters.AddWithValue("@manql", txtMANQL.Text);
                    if (!validNgaySinh(datetime.Value))
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cmd.Parameters.AddWithValue("@ngaysinh", datetime.Value.ToString("yyyy'-'MM'-'dd"));
                    cmd.Parameters.AddWithValue("@gt", cboGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    cmd.ExecuteNonQuery();
                    str = "\r\nselect MANV \r\nfrom NHANVIEN\r\nwhere  TENNV = @tennv and DIACHI = @dc and GT = @gt AND SDT = @sdt AND LUONG = @luong";
                    cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@tennv", txtTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@gt", cboGioiTinh.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@luong",txtMucLuong.Value.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();
                    int manv = -1;
                    while (reader.Read())
                    {
                        manv = reader.GetInt32(0);
                    }
                    reader.Close();
                    str = "insert into PHANCONG(MANV, CHUCVU, CALAMVIEC) values (@manv, @cv, @clv)";
                    cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@manv",manv);
                    cmd.Parameters.AddWithValue("@cv", txtChucvu.Text.Trim());
                    cmd.Parameters.AddWithValue("@clv", cboCaLV.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    Display();
                    Reset();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Thất bại khi thêm nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private bool validNgaySinh(DateTime birthday)
        {
            return DateTime.Now.Year - birthday.Year >= 18;
        }
        void Export(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvList.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvList.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                for (int j = 0; j < dgvList.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvList.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
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

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = s;
                DapperPlusManager.Entity<NhanVien>().Table("NHANVIEN");
                List<NhanVien> saches = dgvList.DataSource as List<NhanVien>;
                if (saches != null)
                {
                    using (SqlConnection connection = new SqlConnection(connstring))
                    {
                        connection.BulkInsert(saches);
                    }
                }
                MessageBox.Show("Finish!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhatLai_Click(object sender, EventArgs e)
        {
            Display();
            Reset();
        }
        private void lsvNV_Load()
        {
            try
            {
                dgvList.DataSource = null;
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select nv.MANV, nv.TENNV, nv.DIACHI, NV.LUONG, nv.MANQL, nv.NGAYSINH,  nv.GT, nv.SDT, pc.CHUCVU, pc.CALAMVIEC\r\nfrom NHANVIEN nv join PHANCONG pc on nv.MANV = pc.MANV";
                bool genreSelected = false;
                if (txtTenNVTK.Text.Length >0 )
                {
                    query += " where nv.TENNV = N'" + txtTenNVTK.Text.Trim() + "'";
                    genreSelected = true;
                }
                if (txtSDTTK.Text.Length > 0)
                {
                    if (genreSelected) { query += " and"; }
                    else { query += " where"; }
                    query += " nv.SDT = '" + txtSDTTK.Text.Trim() + "'";
                }
                if (cboCLV.SelectedIndex > 0)
                {
                    if (cboCLV.SelectedItem.ToString() != "Tất cả")
                    {
                        if (genreSelected) { query += " and"; }
                        else { query += " where"; }
                        query += " pc.CALAMVIEC = N'" + cboCLV.SelectedItem.ToString() + "'";
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(query, connection));
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                if (dt.Rows.Count > 0)
                {
                    dgvList.DataSource = dt;
                }
                
            }
            catch
            {
                MessageBox.Show("Tải dữ liệu nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtTenNVTK_TextChanged(object sender, EventArgs e)
        {
            lsvNV_Load();
        }

        private void cboCLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvNV_Load();
        }

        private void txtSDTTK_TextChanged(object sender, EventArgs e)
        {
            lsvNV_Load();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHomePageAdmin().Show();
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

        private void frmEmployeeManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
