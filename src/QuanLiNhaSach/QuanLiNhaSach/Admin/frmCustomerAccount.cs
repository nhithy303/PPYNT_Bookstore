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
using QuanLiNhaSach.Admin;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using ExcelDataReader;
using Z.Dapper.Plus;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLiNhaSach
{
    public partial class frmCustomerAccount : Form
    {
        string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
        SqlConnection connection = null;
        public frmCustomerAccount()
        {
            InitializeComponent();
            connection = new SqlConnection(s);
            btnTaiKhoan.BackColor = Color.Goldenrod;
        }
        void clear()
        {
            txtMaKH.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtTenDN.Text = string.Empty;
        }
        void display()
        {
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            string str = "select kh.MAKH, kh.TENKH, kh.SDT, kh.TenGmail, dn.TENDN, dn.MATKHAU\r\nfrom KHACHHANG kh join DANGNHAP  dn on kh.MAKH = dn.MAKH";
            SqlDataAdapter sda = new SqlDataAdapter(str, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda.Dispose();
            dgvKH.DataSource = dt;
            connection.Close();
        }
        private void frmCustomerAccount_Load(object sender, EventArgs e)
        {
            display();
        }
        private static readonly string[] VietnameseSigns = new string[]
        {
            "aAeEoOuUiIdDyY",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };
        public static string RemoveSign4VietnameseString(string str)
        {
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return str;
        }
        public bool KT_KhoaNgoai1(string MANQL)
        {
            connection.Open();
            string str = "select count(TENDN)\r\nfrom DANGNHAP\r\nwhere TENDN = @tendn";
            SqlCommand cmd = new SqlCommand(str, connection);
            cmd.Parameters.AddWithValue("@tendn", MANQL);
            SqlDataReader rd = cmd.ExecuteReader();
            int count = -1;
            while (rd.Read())
            {
                count = rd.GetInt32(0);
            } 
            rd.Close();
            connection.Close();
            if(count == 0) return true; // 0  la chu co
            else return false;
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {   
                if (txtGmail.Text == String.Empty ||  txtSDT.Text == String.Empty || txtTenKH.Text == String.Empty ||  txtMatKhau.Text == string.Empty || txtTenDN.Text == string.Empty)
                {
                    MessageBox.Show("Bạn còn điền thiếu một vài thông tin. Vui lòng điền đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!IsValidEmail(txtGmail.Text.Trim()))
                {
                    MessageBox.Show("Định dạng Gmail không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
                else if (txtSDT.Text.Length < 10)
                {
                    MessageBox.Show("Điện thoại phải đủ 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!txtSDT.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại chỉ nên gồm các những con số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
                else if (RemoveSign4VietnameseString(txtTenDN.Text.Trim()) != txtTenDN.Text.Trim())
                {
                    MessageBox.Show("Tên đăng nhập không được gõ tiếng Việt có dấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
                else if (txtTenDN.Text.Length <= 3)
                {
                    MessageBox.Show("Tên tài khoản phải dài hơn 3 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
                else if (txtTenDN.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Tên tài khoản không được là những con số. Phải có chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtSDT.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại phải đủ 10 con số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!KT_KhoaNgoai1(txtTenDN.Text.Trim()))
                {
                    MessageBox.Show("Tên đăng nhập này đã có rồi!\n Vui lòng chọn tên đăng nhập khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                else
                {
                    dgvKH.DataSource = null;
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    string str = "insert into KHACHHANG(TENKH,SDT, TenGmail) VALUES(@tenkh, @sdt,@ten)";
                    SqlCommand cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@tenkh", txtTenKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtGmail.Text.Trim());
                    cmd.ExecuteNonQuery();
                    str = "select MAKH \r\nfrom KHACHHANG\r\nwhere TENKH = @tenkh and SDT = @sdt";
                    cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@tenkh", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int makh = -1;
                    while(reader.Read())
                    {
                        makh = reader.GetInt32(0);
                    }
                    reader.Close();
                    str = "insert into DANGNHAP(MAKH, TENDN, MATKHAU) values (@makh,@tendn, @mk)";
                    cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@makh", makh);
                    cmd.Parameters.AddWithValue("@tendn", txtTenDN.Text.Trim());
                    cmd.Parameters.AddWithValue("@mk", txtMatKhau.Text.Trim());
                    cmd.ExecuteNonQuery();
                    display();
                    MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    connection.Close();
                 }
             } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int KT_KhoaNgoai(string makh)
        {
            if(connection.State == ConnectionState.Closed) connection.Open();
            string str = "select COUNT(MAHD)\r\nfrom HoaDon \r\nwhere MAKH = " + int.Parse(makh);
            SqlCommand cmd = new SqlCommand(str, connection);
            SqlDataReader rd = cmd.ExecuteReader();
            int count = 0;
            while (rd.Read())
            {
                count = rd.GetInt32(0);
            }
            rd.Close();
            return count;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int makh = -1;
                if (txtGmail.Text == String.Empty ||  txtSDT.Text == String.Empty || txtTenKH.Text == String.Empty || txtMaKH.Text == string.Empty || txtMatKhau.Text == string.Empty || txtTenDN.Text == string.Empty)
                {
                    MessageBox.Show("Bạn còn điền thiếu một vài thông tin. Vui lòng điền đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (KT_KhoaNgoai(txtMaKH.Text.Trim()) != 0)
                {
                    MessageBox.Show("Người khách hàng này có hóa đơn. Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }    
                else
                {
                    makh = int.Parse(txtMaKH.Text);
                    dgvKH.DataSource = null;
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    string str = "delete from DANGNHAP where MAKH = @makh";
                    SqlCommand cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@makh", makh);
                    cmd.ExecuteNonQuery();
                    str = "delete from KHACHHANG where MAKH = @ma";
                    cmd.Parameters.AddWithValue("@ma", makh);
                    cmd.ExecuteNonQuery();
                    display();
                    MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
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
            txtMaKH.Clear();
            txtMatKhau.Clear();
            txtTenDN.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtGmail.Clear();
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGmail.Text == String.Empty || txtSDT.Text == String.Empty || txtTenKH.Text == String.Empty || txtMatKhau.Text == string.Empty || txtTenDN.Text == string.Empty)
                {
                    MessageBox.Show("Bạn còn điền thiếu một vài thông tin. Vui lòng điền đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!IsValidEmail(txtGmail.Text.Trim()))
                {
                    MessageBox.Show("Định dạng Email điền chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                }
                else if (txtSDT.Text.Length < 10)
                {
                    MessageBox.Show("Điện thoại phải đủ 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!txtSDT.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại chỉ nên gồm các những con số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
                else if (RemoveSign4VietnameseString(txtTenDN.Text.Trim()) != txtTenDN.Text.Trim())
                {
                    MessageBox.Show("Tên đăng nhập không được gõ tiếng Việt có dấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
                else if (txtTenDN.Text.Length <= 3)
                {
                    MessageBox.Show("Tên tài khoản phải dài hơn 3 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
                else if (txtTenDN.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Tên tài khoản không được là những con số. Phải có chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtSDT.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại phải đủ 10 con số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvKH.DataSource = null;
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    string str = "update DANGNHAP set TENDN  = @tendn, MatKhau = @mk where MaKH  = @MAKH";
                    SqlCommand cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@tendn", txtTenDN.Text);
                    cmd.Parameters.AddWithValue("@mk", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@MAKH", txtMaKH.Text);
                    cmd.ExecuteNonQuery();
                    str = "update KHACHHANG set TENKH = @tenkh, SDT = @sdt, TenGmail = @ten where MAKH = @makh";
                    cmd = new SqlCommand(str, connection);
                    cmd.Parameters.AddWithValue("@tenkh", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@ten", txtGmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@makh", txtMaKH.Text);
                    cmd.ExecuteNonQuery();
                    display();
                    Reset();
                    MessageBox.Show("Bạn đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvKH.CurrentRow;
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtGmail.Text = row.Cells[3].Value.ToString();
                txtTenDN.Text = row.Cells[4].Value.ToString();
                txtMatKhau.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void txtTenKHTK_TextChanged(object sender, EventArgs e)
        {
            dgvKH.DataSource = null;
            if (txtTenKHTK.Text.Length != 0)
            {
                if (ConnectionState.Closed == connection.State)
                {
                    connection.Open();
                }
                string str = "select *\r\nfrom KHACHHANG kh join DANGNHAP dn on kh.MAKH = dn.MAKH\r\nwhere TENKH = @tenkh";
                SqlCommand cmd = new SqlCommand(str, connection);
                cmd.Parameters.AddWithValue("@tenkh", txtTenKHTK.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Dispose();
                dgvKH.DataSource = dt;
                connection.Close();
            }
            else
            {
                display();
            } 
                
        }

        private void txtSDTTK_TextChanged(object sender, EventArgs e)
        {
            dgvKH.DataSource = null;
            if (txtSDTTK.Text.Length != 0)
            {
                if (ConnectionState.Closed == connection.State)
                {
                    connection.Open();
                }
                string str = "select *\r\nfrom KHACHHANG kh join DANGNHAP dn on kh.MAKH = dn.MAKH\r\nwhere SDT LIKE @sdt ";     
                SqlCommand cmd = new SqlCommand(str, connection);
                cmd.Parameters.AddWithValue("@sdt",txtSDTTK.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvKH.DataSource = dt;
                connection.Close();
            }
            else
            {
                display();
            }
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
        void Export(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvKH.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvKH.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvKH.Rows.Count; i++)
            {
                for (int j = 0; j < dgvKH.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvKH.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
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

        private void frmCustomerAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
