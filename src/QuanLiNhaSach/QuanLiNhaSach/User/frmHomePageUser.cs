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
using System.Collections;

namespace QuanLiNhaSach
{
    public partial class frmHomePageUser : Form
    {
        SqlConnection connection;
        string UserName;
        static List<ArrayList> addedBooks; // cart (MASACH - SLMUA)
        public static List<ArrayList> AddedBooks
        {
            get { return addedBooks; }
            set { addedBooks = value; }
        }
        public frmHomePageUser(string userName)
        {
            InitializeComponent();
            string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
            connection = new SqlConnection(s);
            UserName = userName;
            addedBooks = new List<ArrayList>();
            this.Load += frmHomePageUser_Load;
            lsvBook.SelectedIndexChanged += lsvBook_SelectedIndexChanged;
            btnSearch.Click += btnSearch_Click;
            btnShowInfo.Click += btnShowInfo_Click;
            btnCart.Click += btnCart_Click;
            btnUserAccount.Click += btnUserAccount_Click;
            this.FormClosing += frmHomePageUser_FormClosing;
        }

        private void frmHomePageUser_Load(object sender, EventArgs e)
        {
            cboGenre_Load();
            cboAuthor_Load();
            lsvBook_Load();
            lblTenKH_Load();
            btnShowInfo.Enabled = false;
        }

        private void lblTenKH_Load()
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select TENKH"
                    + " from DANGNHAP inner join KHACHHANG on DANGNHAP.MAKH = KHACHHANG.MAKH"
                    + " where TENDN = '" + UserName + "'";
                SqlDataReader reader = new SqlCommand(query, connection).ExecuteReader();
                while (reader.Read())
                {
                    lblTenKH.Text = "Tên khách hàng:\n" + reader.GetString(0);
                }
                reader.Close();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
            catch
            {
                showError("Tải thông tin khách hàng thất bại!");
            }
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
                showError("Tải dữ liệu thể loại sách thất bại!");
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
                showError("Tải dữ liệu tác giả thất bại!");
            }
        }

        private void lsvBook_Load()
        {
            try
            {
                lsvBook.Items.Clear();
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select MASACH, TENSACH, TENTG, GIASACH, SLSACH"
                    + " from Sach inner join TACGIA on Sach.MATG = TACGIA.MATG";
                bool genreSelected = false;
                if (cboGenre.SelectedIndex > 0)
                {
                    query += " where TENTL = N'" + cboGenre.SelectedValue + "'";
                    genreSelected = true;
                }
                if (cboAuthor.SelectedIndex > 0)
                {
                    if (genreSelected) { query += " and"; }
                    else { query += " where"; }
                    query += " Sach.MATG = '" + cboAuthor.SelectedValue + "'";
                }
                SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(query, connection));
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lsvBook.Items.Add(new ListViewItem(new[]
                        {
                            dt.Rows[i]["MASACH"].ToString(),
                            dt.Rows[i]["TENSACH"].ToString(),
                            dt.Rows[i]["TENTG"].ToString(),
                            dt.Rows[i]["GIASACH"].ToString(),
                            dt.Rows[i]["SLSACH"].ToString()
                        }));
                    }
                }
                else
                {
                    showError("Không tìm thấy sách tương ứng!");
                }
            }
            catch
            {
                showError("Tải dữ liệu sách thất bại!");
            }
        }
        
        private void lsvBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBook.SelectedItems.Count > 0)
            {
                btnShowInfo.Enabled = true;
            }
            else
            {
                btnShowInfo.Enabled = false;
            }
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lsvBook_Load();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
           
            if (lsvBook.SelectedItems.Count > 0)
            {
                new frmBookInfo(lsvBook.FocusedItem.Text, UserName).ShowDialog();
                lsvBook_Load();
            }
            else
            {
                showError("Bạn chưa chọn sách!");
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            new frmCart(UserName).ShowDialog();
            lsvBook_Load();
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            new frmUserAccount(UserName).ShowDialog();
            lblTenKH_Load();
        }
        
        private void showError(string error)
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHomePageUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Bạn có chắn chắn muốn đăng xuất không?", "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (addedBooks.Count > 0) // there are books in cart that haven't paid
                {
                    r = MessageBox.Show("Bạn còn sách chưa thanh toán trong giỏ hàng!\nThanh toán ngay bây giờ?",
                        "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        e.Cancel = true;
                        new frmCart(UserName).ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            // restore book quantity
                            if (connection.State == ConnectionState.Closed) { connection.Open(); }
                            foreach (ArrayList item in addedBooks)
                            {
                                string query = "update Sach set SLSACH = SLSACH + " + item[1]
                                    + " where MASACH = '" + item[0] + "'";
                                new SqlCommand(query, connection).ExecuteNonQuery();
                            }
                            if (connection.State == ConnectionState.Open) { connection.Close(); }
                        }
                        catch
                        {
                            showError("Khôi phục số lượng sách thất bại!");
                        }
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
