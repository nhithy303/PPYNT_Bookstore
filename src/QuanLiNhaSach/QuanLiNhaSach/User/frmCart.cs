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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using Microsoft.Ajax.Utilities;

namespace QuanLiNhaSach
{
    public partial class frmCart : Form
    {
        SqlConnection connection;
        string UserName;
        string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
        DataTable dt_Books;
        public frmCart(string username)
        {
            InitializeComponent();
            connection = new SqlConnection(s);
            this.Load += frmCart_Load;
            dgvBook.SelectionChanged += dgvBook_SelectionChanged;
            btnEdit.Enabled = btnDelete.Enabled = false;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnOrder.Click += btnOrder_Click;
            btnExit.Click += btnExit_Click;
            UserName = username;
            dt_Books = new DataTable();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            dgvBook_Load();
            txtTotalPayment.Text = getTotalPayment().ToString();
        }

        private void dgvBook_Load()
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                dt_Books.Columns.Add("MASACH");
                dt_Books.Columns.Add("TENSACH");
                dt_Books.Columns.Add("TENTG");
                dt_Books.Columns.Add("DONGIA");
                dt_Books.Columns.Add("SOLUONG");
                dt_Books.Columns.Add("THANHTIEN");
                foreach (var item in frmHomePageUser.AddedBooks)
                {
                    string query = "select MASACH, TENSACH, TENTG, GIASACH"
                        + " from Sach inner join TACGIA on Sach.MATG = TACGIA.MATG"
                        + " where MASACH = " + item[0];
                    SqlDataReader reader = new SqlCommand(query, connection).ExecuteReader();
                    DataRow dr = dt_Books.NewRow();
                    while (reader.Read())
                    {
                        dr["MASACH"] = reader["MASACH"].ToString();
                        dr["TENSACH"] = reader["TENSACH"].ToString();
                        dr["TENTG"] = reader["TENTG"].ToString();
                        dr["DONGIA"] = reader["GIASACH"].ToString();
                        dr["SOLUONG"] = item[1];
                        dr["THANHTIEN"] = int.Parse(dr["DONGIA"].ToString()) * int.Parse(dr["SOLUONG"].ToString());
                    }
                    reader.Close();
                    dt_Books.Rows.Add(dr);
                }
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                dgvBook.DataSource = dt_Books;
                dgvBook.Columns[0].HeaderText = "Mã sách";
                dgvBook.Columns[1].HeaderText = "Tên sách";
                dgvBook.Columns[2].HeaderText = "Tác giả";
                dgvBook.Columns[3].HeaderText = "Đơn giá";
                dgvBook.Columns[4].HeaderText = "Số lượng";
                dgvBook.Columns[5].HeaderText = "Thành tiền";
                dgvBook.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch 
            {
               showError("Tải dữ liệu giỏ hàng thất bại!");
            }
        }

        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBook.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = btnDelete.Enabled = true;
                txtTitle.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
                txtAuthor.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
                txtUnitPrice.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
                txtQuantity.Text = dgvBook.CurrentRow.Cells[4].Value.ToString();
                txtTotalPrice.Text = dgvBook.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                btnEdit.Enabled = btnDelete.Enabled = false;
                txtTitle.Clear(); txtAuthor.Clear(); txtUnitPrice.Clear(); txtQuantity.Clear(); txtTotalPrice.Clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedRows.Count != 1)
            {
                showError("Vui lòng chọn 1 dòng để sửa số lượng sách!");
                return;
            }
            if (txtQuantity.Text.Trim().Length == 0)
            {
                showError("Vui lòng nhập số lượng sách!");
                return;
            }
            if (!txtQuantity.Text.Trim().All(char.IsDigit))
            {
                showError("Số lượng sách không hợp lệ!");
                return;
            }
            if (txtQuantity.Text.Trim() == "0")
            {
                btnDelete.PerformClick();
                return;
            }
            if (txtQuantity.Text.Trim() != dgvBook.CurrentRow.Cells[4].Value.ToString())
            {
                string masach = dgvBook.CurrentRow.Cells[0].Value.ToString();
                int updateNumber = Convert.ToInt32(dgvBook.CurrentRow.Cells[4].Value) - Convert.ToInt32(txtQuantity.Text);
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query;
                if (updateNumber < 0) // increase quantity
                {
                    // get available quantity of this book in store
                    query = "select SLSACH from SACH where MASACH = " + masach;
                    SqlDataReader reader = new SqlCommand(query, connection).ExecuteReader();
                    int availableQuantity = 0;
                    while (reader.Read())
                    {
                        availableQuantity = reader.GetInt32(0);
                    }
                    reader.Close();
                    // check if there are still enough books available
                    if (availableQuantity < -updateNumber)
                    {
                        showError("Số lượng sách còn lại trong kho không đủ!");
                        return;
                    }
                }
                // update SLSACH in table Sach
                query = "update Sach set SLSACH = SLSACH + " + updateNumber
                    + " where MASACH = " + masach.ToString();
                new SqlCommand(query, connection).ExecuteNonQuery();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                // update book quantity in list AddedBooks
                foreach (ArrayList item in frmHomePageUser.AddedBooks)
                {
                    if (item[0].ToString() == masach)
                    {
                        item[1] = Convert.ToInt32(item[1]) - updateNumber; break;
                    }
                }
                // quick update dgvBook
                dgvBook.CurrentRow.Cells[4].Value = Convert.ToInt32(dgvBook.CurrentRow.Cells[4].Value) - updateNumber;
                dgvBook.CurrentRow.Cells[5].Value = Convert.ToInt32(dgvBook.CurrentRow.Cells[3].Value) * Convert.ToInt32(dgvBook.CurrentRow.Cells[4].Value);
                // update txtTotalPayment
                txtTotalPayment.Text = getTotalPayment().ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedRows.Count != 1)
            {
                showError("Vui lòng chọn 1 dòng để xóa sách khỏi giỏ hàng!");
                return;
            }
            try
            {
                // update SLSACH in table Sach
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "update Sach set SLSACH = SLSACH + " + dgvBook.CurrentRow.Cells[4].Value.ToString()
                    + " where MASACH = " + dgvBook.CurrentRow.Cells[0].Value.ToString();
                new SqlCommand(query, connection).ExecuteNonQuery();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                // delete book in list AddedBooks
                for (int i = 0; i < frmHomePageUser.AddedBooks.Count; i++)
                {
                    if (frmHomePageUser.AddedBooks[i][0].ToString() == dgvBook.CurrentRow.Cells[0].Value.ToString())
                    {
                        frmHomePageUser.AddedBooks.RemoveAt(i); break;
                    }
                }
                // quick update dgvBook
                dgvBook.Rows.Remove(dgvBook.CurrentRow);
                dgvBook.ClearSelection();
                // update txtTotalPayment
                txtTotalPayment.Text = getTotalPayment().ToString();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private int getTotalPayment()
        {
            int total = 0;
            foreach (DataGridViewRow item in dgvBook.Rows)
            {
                total += int.Parse(item.Cells[5].Value.ToString());
            }
            return total;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dgvBook.Rows.Count == 0)
            {
                showError("Giỏ hàng trống!");
                return;
            }
            new frmReceipt(UserName, dt_Books, txtTotalPayment.Text).ShowDialog();
            if (frmHomePageUser.AddedBooks.Count == 0)
            {
                dt_Books.Clear();
                txtTotalPayment.Text = "0";
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }
    }
}
