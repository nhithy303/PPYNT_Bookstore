using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach
{
    public partial class frmUserAccount : Form
    {
        string UserName;
        string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
        SqlConnection connection = null;

        public frmUserAccount(string username)
        {
            InitializeComponent();
            connection = new SqlConnection(s);
            this.UserName = username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNumberPhone.Text.Trim().Length == 0 || txtUserName.Text.Trim().Length == 0)
            {
                showError("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (!txtNumberPhone.Text.All(char.IsDigit))
            {
                showError("Số điện thoại không hợp lệ");
                return;
            }
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string khachhang_update_query = "update KHACHHANG set TENKH = @tenkh, SDT = @sdt where MAKH = @makh";
                SqlCommand command = new SqlCommand(khachhang_update_query, connection);
                command.Parameters.AddWithValue("@tenkh", txtUserName.Text);
                command.Parameters.AddWithValue("@sdt", txtNumberPhone.Text);
                command.Parameters.AddWithValue("@makh", lblMaKH.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công!");
                txtNumberPhone.Text = txtUserName.Text = "";
                connection.Close();
            }
            catch
            {
                showError("Lưu thông tin thất bại");
            }
        }

        private void txtNumberPhone_TextChanged(object sender, EventArgs e)
        {
            if (!txtNumberPhone.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(txtNumberPhone, "Số điện thoại chỉ được bao gồm chữ số!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void frmUserAccount_Load(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select DANGNHAP.MAKH, TENKH, SDT"
                    + " from DANGNHAP inner join KHACHHANG on DANGNHAP.MAKH = KHACHHANG.MAKH"
                    + " where TENDN = '" + UserName + "'";
                SqlDataReader reader = new SqlCommand(query, connection).ExecuteReader();
                while (reader.Read())
                {
                    lblMaKH.Text = reader["MAKH"].ToString();
                    txtUserName.Text = reader["TENKH"].ToString();
                    txtNumberPhone.Text = reader["SDT"].ToString();
                }
                reader.Close();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void showError(string error)
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
