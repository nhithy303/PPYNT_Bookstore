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
using Microsoft.Office.Interop.Excel;
using System.Collections;
using System.IO;
using System.Windows.Media.Animation;

namespace QuanLiNhaSach
{
    public partial class frmBookInfo : Form
    {
        SqlConnection connection;
        string selectedBook;
        int bookQuantity;
        string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
        string UserName;
        public frmBookInfo(string SelectedBook, string username)
        {
            InitializeComponent();
            connection = new SqlConnection(s);
            this.selectedBook = SelectedBook;
            this.Load += frmBookInfo_Load;
            btnAddToCart.Click += btnAddToCart_Click;
            btnExit.Click += btnExit_Click;
            UserName = username;
        }

        private void frmBookInfo_Load(object sender, EventArgs e)
        {
            loadBookInfo();
            txtQuantity_Reset();
        }

        private void txtQuantity_Reset()
        {
            if (bookQuantity == 0) { txtQuantity.Value = 0; }
            else { txtQuantity.Value = 1; }
            txtQuantity.Minimum = 0;
            txtQuantity.Maximum = bookQuantity;
        }

        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        private string validNgaySinh(DateTime birthday)
        {
            return birthday.ToString("dd/MM/yyyy");
        }

        private void loadBookInfo()
        {         
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select *"
                    + " from Sach inner join TACGIA on Sach.MATG = TACGIA.MATG inner join NXB on Sach.MANXB = NXB.MANXB"
                    + " where MASACH = '" + selectedBook + "'";
                SqlDataReader dr = new SqlCommand(query, connection).ExecuteReader();
                while (dr.Read())
                {
                    txtTitle.Text = dr["TENSACH"].ToString();
                    txtGenre.Text = dr["TENTL"].ToString();
                    txtPrice.Text = dr["GIASACH"].ToString();
                    txtPublisher.Text = dr["TENNXB"].ToString();
                    txtName.Text = dr["TENTG"].ToString();
                    txtGender.Text = dr["GIOITINH"].ToString();
                    txtBirthPlace.Text = dr["NOISINH"].ToString();
                    if (dr["NAMSINH"].ToString() != string.Empty)
                    txtBirthYear.Text = validNgaySinh(DateTime.Parse(dr["NAMSINH"].ToString()));
                    byte[] bytes = (byte[])dr["HinhAnh"];
                    ptbBookInfo.Image = ByteArrayToImage(bytes);
                    bookQuantity = int.Parse(dr["SLSACH"].ToString());
                    txtThongTinSach.Text = dr["TomTat"].ToString();
                }
                dr.Close();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
            catch
            {
                showError("Tải dữ liệu thông tin sách thất bại!");
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Value == 0)
            {
                showError("Số lượng sách không hợp lệ!");
                txtQuantity_Reset();
                return;
            }
            bookQuantity -= Convert.ToInt32(txtQuantity.Value);
            int addedBooksCount = frmHomePageUser.AddedBooks.Count;
            if (addedBooksCount == 0 || (addedBooksCount > 0 && frmHomePageUser.AddedBooks[addedBooksCount - 1][0].ToString() != selectedBook))
            // cart is empty or selected book doesn't exist in cart
            {
                frmHomePageUser.AddedBooks.Add(new ArrayList { selectedBook, txtQuantity.Value });
            }
            else
            // selected book exists in cart so just have to add the quantity
            {
                frmHomePageUser.AddedBooks[addedBooksCount - 1][1]
                    = int.Parse(frmHomePageUser.AddedBooks[addedBooksCount - 1][1].ToString())
                    + txtQuantity.Value;
            }
            txtQuantity_Reset();
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "update Sach set SLSACH = " + bookQuantity
                    + " where MASACH = '" + selectedBook + "'";
                new SqlCommand(query, connection).ExecuteNonQuery();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                MessageBox.Show("Bạn đã thêm thành công sách vào giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                showError("Cập nhật số lượng sách thất bại!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showError(string error)
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
