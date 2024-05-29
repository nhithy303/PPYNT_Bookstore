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
using System.Collections;
using QuanLiNhaSach.User;

namespace QuanLiNhaSach
{
    public partial class frmLoginUser : Form
    {
        static string UserName;
        public static string _UserName
        {
            get { return UserName; }
            set { UserName = value; }
        }
        SqlConnection connection;
        string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
        public frmLoginUser()
        {
            InitializeComponent();
            connection = new SqlConnection(s);
            txtUserName.Focus();
        }

        private bool validUsername()
        {
            return !txtUserName.Text.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (!validUsername())
            {
                showError("Tên đăng nhập không hợp lệ!");
                txtUserName.Focus();
            }
        }

        private void ptUnHide_Click(object sender, EventArgs e)
        {
            ptbUnHide.Hide();
            txtPassword.UseSystemPasswordChar = false;
            ptbHide.Show();
        }

        private void ptbHide_Click(object sender, EventArgs e)
        {
            ptbHide.Hide();
            txtPassword.UseSystemPasswordChar = true;
            ptbUnHide.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length == 0)
            {
                showError("Vui lòng điền tên đăng nhập!");
                txtUserName.Focus(); return;
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                showError("Vui lòng điền mật khẩu!");
                txtPassword.Focus(); return;
            }
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                string query = "select * from DANGNHAP where TENDN = '" + txtUserName.Text + "'";
                SqlDataReader reader = new SqlCommand(query, connection).ExecuteReader();
                if (!reader.HasRows)
                {
                    showError("Tài khoản không tồn tại!");
                    txtUserName.Focus(); return;
                }
                while (reader.Read())
                {
                    if (txtPassword.Text != reader["MATKHAU"].ToString())
                    {
                        showError("Sai mật khẩu!");
                        txtPassword.Focus();
                        reader.Close(); return;
                    }
                }
                reader.Close();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
            catch
            {
                showError("Đăng nhập không thành công!");
                return;
            }
            this.Hide();
            new frmHomePageUser(txtUserName.Text).ShowDialog();
            this.Show();
            txtUserName.Focus();
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void lklAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLoginAdmin frmAdminAccount = new frmLoginAdmin();
            this.Hide();
            frmAdminAccount.ShowDialog();
            this.Close();
        }

        private void showError(string error)
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblTaoTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateAccountUser accountUser = new frmCreateAccountUser();
            accountUser.ShowDialog();
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            frmResetPassword resetPassword = new frmResetPassword();
            resetPassword.ShowDialog();
        }
    }
}