using QuanLiNhaSach.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using OfficeOpenXml;
using Z.Dapper.Plus;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;

namespace QuanLiNhaSach
{
    public partial class FrmBookManagement : Form
    {
        string s = @"Data Source="+ Program.server_name +";Initial Catalog = QLNS; Integrated Security = True";

        public string tomtat = "";
        SqlConnection connection = null;
        public FrmBookManagement()
        {
            InitializeComponent();
            connection =  new SqlConnection(s);
            btnSach.BackColor = Color.Goldenrod;
        }
        private void Display()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("select MASACH, TENSACH, MATG, TENTL, GIASACH, SLSACH, MANXB, TomTat, HinhAnh from SACH", connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            sda.Dispose();
            connection.Close();
            dgvList.DataSource = dt;
            dgvList.Columns[0].HeaderText = "Mã sách";
            dgvList.Columns[1].HeaderText = "Tên sách";
            dgvList.Columns[2].HeaderText = "Mã tác giả";
            dgvList.Columns[3].HeaderText = "Thể loại";
            dgvList.Columns[4].HeaderText = "Giá sách";
            dgvList.Columns[5].HeaderText = "Số lượng";
            dgvList.Columns[6].HeaderText = "Mã NXB";
            dgvList.Columns[7].HeaderText = "Tóm tắt";
            dgvList.Columns[8].Visible = false;
        }
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedCells.Count > 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string delete_sach_query = "delete from ChiTietHoaDon where MASACH = @masach"
                    + "\ndelete from SACH where MASACH = @masach";
                SqlCommand command = new SqlCommand(delete_sach_query, connection);
                command.Parameters.AddWithValue("@masach", txtMaSach.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                connection.Close();
                Display();
                txtMaSach.Text = txtTenSach.Text = txtGiaSach.Text = txtSoLuongSach.Text = txtTheLoai.Text = cboNXB.Text = cboTacGia.Text = null;
                tomtat = "";
                ptbHinhAnh.Image = null;
                tomtat = null;
            }
        }
        private void dgvList_Load()
        {
            try
            {
                dgvList.DataSource = null;
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select MASACH, TENSACH, MATG, TENTL, GIASACH, SLSACH, MANXB, TomTat, HinhAnh"
                    + " from Sach";
                bool genreSelected = false;
                bool authorSelected = false;
                if (cboGenre.SelectedIndex > 0)
                {
                    query += " where TENTL = N'" + cboGenre.SelectedValue + "'";
                    genreSelected = true;
                }
                if (cboAuthor.SelectedIndex > 0)
                {
                    if (genreSelected) { query += " and"; }
                    else { query += " where"; }
                    query += " MATG = '" + cboAuthor.SelectedValue + "'";
                    authorSelected = true;
                }
                if (cboPublisher.SelectedIndex > 0 )
                {
                    if (genreSelected || authorSelected) { query += " and"; }
                    else { query += " where"; }
                    query += " MANXB = '" + cboPublisher.SelectedValue + "'";
                }    
                SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(query, connection));
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                if (dt.Rows.Count > 0)
                {
                    dgvList.DataSource = dt;
                    dgvList.Columns[0].HeaderText = "Mã sách";
                    dgvList.Columns[1].HeaderText = "Tên sách";
                    dgvList.Columns[2].HeaderText = "Mã tác giả";
                    dgvList.Columns[3].HeaderText = "Thể loại";
                    dgvList.Columns[4].HeaderText = "Giá sách";
                    dgvList.Columns[5].HeaderText = "Số lượng";
                    dgvList.Columns[6].HeaderText = "Mã NXB";
                    dgvList.Columns[7].HeaderText = "Tóm tắt";
                    dgvList.Columns[8].Visible = false;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách tương ứng!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Tải dữ liệu sách thất bại!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmBookManagement_Load(object sender, EventArgs e)
        {
            cboGenre_Load();
            cboAuthor_Load();
            cboPublish_Load();
            try
            {
                btnLuu.Enabled = btnSuaSach.Enabled = btnXoaSach.Enabled = false;
                txtGiaSach.Enabled = txtMaSach.Enabled = txtSoLuongSach.Enabled = txtTenSach.Enabled = txtTheLoai.Enabled = false;
                cboNXB.Enabled = cboTacGia.Enabled = false;
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string tacgia_select_query = "select TENTG from TACGIA";
                SqlDataReader reader = new SqlCommand(tacgia_select_query, connection).ExecuteReader();
                while (reader.Read())
                {
                    cboTacGia.Items.Add(reader.GetString(0));
                }
                reader.Close();
                string nxb_select_query = "select TENNXB from NXB";
                SqlDataReader dr = new SqlCommand(nxb_select_query, connection).ExecuteReader();
                while (dr.Read())
                {
                    cboNXB.Items.Add(dr.GetString(0));
                }
                dr.Close();
                connection.Close();
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                btnSuaSach.Enabled = btnXoaSach.Enabled = true;
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = dgvList.CurrentRow;
                //Đưa dữ liệu vào textbox
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtTheLoai.Text = row.Cells[3].Value.ToString();
                txtGiaSach.Text = row.Cells[4].Value.ToString();
                txtSoLuongSach.Text = row.Cells[5].Value.ToString();
                tomtat = row.Cells[7].Value.ToString();
                if (row.Cells[8].Value != null)
                {
                    byte[] bytes = (byte[])row.Cells[8].Value;
                    ptbHinhAnh.Image = ByteArrayToImage(bytes);
                }
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string tacgia_select_query = "select TENTG from TACGIA where MATG = @matg";
                SqlCommand command = new SqlCommand(tacgia_select_query, connection);
                command.Parameters.AddWithValue("@matg", row.Cells[2].Value.ToString());
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cboTacGia.Text = dt.Rows[0]["TENTG"].ToString();

                string nxb_select_query = "select TENNXB from NXB where MANXB = @manxb";
                SqlCommand command1 = new SqlCommand(nxb_select_query, connection);
                command1.Parameters.AddWithValue("@manxb", row.Cells[6].Value.ToString());
                command1.ExecuteNonQuery();
                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                cboNXB.Text = dt1.Rows[0]["TENNXB"].ToString();
                connection.Close();
            }
            Image ByteArrayToImage(byte[] b)
            {
                MemoryStream m = new MemoryStream(b);
                return Image.FromStream(m);
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {        
            txtMaSach.Text = txtTenSach.Text = txtGiaSach.Text = txtSoLuongSach.Text = txtTheLoai.Text = cboNXB.Text = cboTacGia.Text = null;
            ptbHinhAnh.Image = null;
            txtMaSach.Enabled = true;
            btnLuu.Enabled = true;
            txtGiaSach.Enabled = txtSoLuongSach.Enabled = txtTenSach.Enabled = txtTheLoai.Enabled = true;
            cboNXB.Enabled = cboTacGia.Enabled = true;
            tomtat = "";
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaSach.Enabled = false;
            txtGiaSach.Enabled = txtSoLuongSach.Enabled = txtTenSach.Enabled = txtTheLoai.Enabled = true;
            cboNXB.Enabled = cboTacGia.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string luu_query = "";
            byte[] b = null;
            if (txtMaSach.Enabled == true)
            {
                if (txtTenSach.Text.Trim().Length
                    == 0 || txtGiaSach.Text.Trim().Length == 0 || txtSoLuongSach.Text.Trim().Length
                    == 0 || txtTheLoai.Text.Trim().Length == 0 || ptbHinhAnh.Image == null)
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                    return;
                }
                if (cboTacGia.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn tên tác giả!");
                    return;
                }
                if (cboNXB.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn tên nhà xuất bản!");
                    return;
                }
                for (int i = 0; i < dgvList.Rows.Count - 1; i++)
                {
                    if (txtMaSach.Text == dgvList.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Mã sách đã tồn tại!");
                        txtMaSach.Text = null;
                        return;
                    }
                }
                 b = ImageToByteArray(ptbHinhAnh.Image);
                luu_query = "SET IDENTITY_INSERT SACH ON\n"
                    + "insert into SACH (MASACH, TENSACH, MATG, TENTL, GIASACH, SLSACH, MANXB,TomTat, HinhAnh)  values (@masach, @tensach, @matg, @tentl, @giasach, @slsach, @manxb, @tomtat,@hinhanh)"
                    + "\nSET IDENTITY_INSERT SACH OFF";
            }
            else
            {
                if (txtMaSach.Text.Trim().Length == 0 || txtTenSach.Text.Trim().Length
                    == 0 || txtGiaSach.Text.Trim().Length == 0 || txtSoLuongSach.Text.Trim().Length
                    == 0 || txtTheLoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                    return;
                }
                if (cboTacGia.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn tên tác giả!");
                    return;
                }
                b = ImageToByteArray(ptbHinhAnh.Image);
                luu_query = "update SACH set "
                    + "TENSACH = @tensach, MATG = @matg, TENTL = @tentl, GIASACH = @giasach, SLSACH = @slsach, MANXB = @manxb, TomTat = @tomtat, HinhAnh = @hinhanh"
                    + " where MASACH = @masach";
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand(luu_query, connection);
            command.Parameters.AddWithValue("@masach", txtMaSach.Text);
            command.Parameters.AddWithValue("@tensach", txtTenSach.Text);
            command.Parameters.AddWithValue("@giasach", txtGiaSach.Text);
            command.Parameters.AddWithValue("@slsach", txtSoLuongSach.Text);
            command.Parameters.AddWithValue("@tentl", txtTheLoai.Text);
            command.Parameters.AddWithValue("@tomtat", tomtat);
            command.Parameters.AddWithValue("@hinhanh", b);
            string tacgia_select_query = "select MATG from TACGIA where TENTG like N'" + cboTacGia.SelectedItem.ToString() + "'";
            SqlDataReader reader = new SqlCommand(tacgia_select_query, connection).ExecuteReader();
            while (reader.Read())
            {
                command.Parameters.AddWithValue("@matg", reader.GetInt32(0).ToString());
            }
            reader.Close();

            string nxb_select_query = "select MANXB from NXB where TENNXB like N'" + cboNXB.SelectedItem.ToString() + "'";
            SqlDataReader dr1 = new SqlCommand(nxb_select_query, connection).ExecuteReader();
            while (dr1.Read())
            {
                command.Parameters.AddWithValue("@manxb", dr1.GetInt32(0).ToString());
            }
            dr1.Close();

            command.ExecuteNonQuery();
            Display();
            MessageBox.Show("Lưu thành công!");
            connection.Close();
        }

        private void btnTaiAnhLen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbHinhAnh.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        void Export(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvList.Columns.Count -1 ; i++)
            {
                application.Cells[1, i + 1] = dgvList.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                for (int j = 0; j < dgvList.Columns.Count - 1; j++)
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

        private void btnTomTat_Click(object sender, EventArgs e)
        {
            frmInfoBook_Admin _Admin = new frmInfoBook_Admin(tomtat);
            _Admin.ShowDialog();
            tomtat = _Admin.NoiDungCuonsach;
        }
        private void cboGenre_Load()
        {
            try
            {
                cboGenre.DataSource = null;
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select distinct TENTL from Sach order by TENTL";
                SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(query, connection));
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                DataRow allRow = dt.NewRow();
                allRow[0] = "Tất cả";
                dt.Rows.InsertAt(allRow, 0);
                cboGenre.DataSource = dt;
                cboGenre.DisplayMember = "TENTL";
                cboGenre.ValueMember = "TENTL";
            }
            catch
            {
                MessageBox.Show("Tải dữ liệu thể loại sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        private void cboAuthor_Load()
        {
            try
            {
                cboAuthor.DataSource = null;
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select MATG, TENTG from TACGIA order by TENTG";
                SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(query, connection));
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                DataRow allRow = dt.NewRow();
                allRow[0] = 0;
                allRow[1] = "Tất cả";
                dt.Rows.InsertAt(allRow, 0);
                cboAuthor.DataSource = dt;
                cboAuthor.DisplayMember = "TENTG";
                cboAuthor.ValueMember = "MATG";
            }
            catch
            {
                MessageBox.Show("Tải dữ liệu tác giả thất bại!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cboPublish_Load()
        {
            try
            {
                cboPublisher.DataSource = null;
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select MANXB, TENNXB from NXB order by TENNXB";
                SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(query, connection));
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                DataRow allRow = dt.NewRow();
                allRow[0] = 0;
                allRow[1] = "Tất cả";
                dt.Rows.InsertAt(allRow, 0);
                cboPublisher.DataSource = dt;
                cboPublisher.DisplayMember = "TENNXB";
                cboPublisher.ValueMember = "MANXB";
            }
            catch
            {
                MessageBox.Show("Tải dữ liệu tác giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvList_Load();
        }

        private void cboAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvList_Load();
        }

        private void cboPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvList_Load();
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

        private void FrmBookManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
