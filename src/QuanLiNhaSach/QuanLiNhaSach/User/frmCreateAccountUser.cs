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

namespace QuanLiNhaSach.User
{
    public partial class frmCreateAccountUser : Form
    {
        string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
        SqlConnection connection;
        public frmCreateAccountUser()
        {
            InitializeComponent();
            connection = new SqlConnection(s);
        }

        private void ptbUnHide_Click(object sender, EventArgs e)
        {
            ptbUnHide.Hide();
            txtMK.UseSystemPasswordChar = false;
            ptbHide.Show();
        }

        private void ptbHide_Click(object sender, EventArgs e)
        {
            ptbHide.Hide();
            txtMK.UseSystemPasswordChar = true;
            ptbUnHide.Show();
        }
        public bool KT_KhoaNgoai(string TENDN)
        {
            connection.Open();
            string str = "select *\r\nfrom DANGNHAP\r\nwhere TENDN = @tendn";
            SqlCommand cmd = new SqlCommand(str, connection);
            cmd.Parameters.AddWithValue("@tendn", TENDN);
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
        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (txtTenGmail.Text == string.Empty ||  txtTenKH.Text == string.Empty || txtTenTK.Text == string.Empty || txtSDT.Text == string.Empty || txtMK.Text == string.Empty || txtNhapLai.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(!txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ nên gồm các những con số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);return;
            }    
            else if(RemoveSign4VietnameseString(txtTenTK.Text.Trim()) != txtTenTK.Text.Trim())
            {
                MessageBox.Show("Tên đăng nhập không được gõ tiếng Việt có dấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);return;
            }  
            else if (txtTenTK.Text.Length <= 3)
            {
                MessageBox.Show("Tên tài khoản phải dài hơn 3 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);return;
            }    
            else if (txtTenTK.Text.All(char.IsDigit))
            {
                MessageBox.Show("Tên tài khoản không được là những con số. Phải có chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
            else if (txtSDT.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 con số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else if (!KT_KhoaNgoai(txtTenTK.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập này đã có rồi!\n Vui lòng chọn tên đăng nhập khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }  
            else if (!IsValidEmail(txtTenGmail.Text.Trim()))
            {
                MessageBox.Show("Email không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }    
            else
            {
                if (txtMK.Text.Trim() == txtNhapLai.Text.Trim())
                {
                    try
                    {
                        if (ConnectionState.Closed == connection.State) connection.Open();
                        string str = "insert into  KHACHHANG(TENKH, SDT, TenGmail) values (@tenkh, @sdt, @tengmail)";
                        SqlCommand cmd = new SqlCommand(str, connection);
                        cmd.Parameters.AddWithValue("@tenkh", txtTenKH.Text);
                        cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@tengmail", txtTenGmail.Text.Trim());
                        cmd.ExecuteNonQuery();
                        str = "select MAKH \r\nfrom KHACHHANG \r\nwhere SDT = @sdt and TENKH = @tenkh";
                        cmd = new SqlCommand(str, connection);
                        cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@tenkh",txtTenKH.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = cmd.ExecuteReader();
                        int makh = -1;
                        while(reader.Read())
                         makh = reader.GetInt32(0);
                        reader.Close();
                        str = "insert into DANGNHAP(MAKH, TENDN, MATKHAU) values (@makh, @dn, @mk)";
                        cmd = new SqlCommand(str, connection);
                        cmd.Parameters.AddWithValue("@makh", makh);
                        cmd.Parameters.AddWithValue("@dn", txtTenTK.Text);
                        cmd.Parameters.AddWithValue("@mk", txtMK.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bạn đã tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        txtTenKH.Clear(); txtSDT.Clear(); txtTenTK.Clear(); txtMK.Clear(); txtNhapLai.Clear(); txtTenGmail.Clear();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn điền mật khẩu lần 2 sai rồi. Vui lòng điền mật khẩu khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                } 
                    
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!ctr.Text.All(char.IsDigit) && ctr.Text.Length != 0)
            {
                errorProvider1.SetError(ctr, "SDT chỉ gồm những con số");
            }
            else if (ctr.Text.Length < 10)
            {
                errorProvider1.SetError(ctr, "SDT phải đủ 10 chữ số");
            }    
            else errorProvider1.Clear();
        }

        private void txtTenTK_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length != 0 && RemoveSign4VietnameseString(txtTenTK.Text) != txtTenTK.Text)
            {
                errorProvider1.SetError(ctr, "Tên đăng nhập không được gõ dấu tiếng Việt");
            }
            else if (ctr.Text.Length <= 3)
            {
                errorProvider1.SetError(ctr, "Tên đăng nhập phải dài hơn 3 ký tự");
            }    
            else if (ctr.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(ctr, "Tên đăng nhập không được là những con số. Phải có chữ ký tự");
            }    
            else if(!KT_KhoaNgoai(txtTenTK.Text.Trim()))
            {
                errorProvider1.SetError(ctr, "Tên đăng nhập này đã có rồi!");
            }    
            else errorProvider1.Clear();
        }

        private void ptbUnHide1_Click(object sender, EventArgs e)
        {
            ptbUnHide1.Hide();
            txtNhapLai.UseSystemPasswordChar = false;
            ptbHide1.Show();
        }

        private void ptbHide1_Click(object sender, EventArgs e)
        {
            ptbHide1.Hide();
            txtNhapLai.UseSystemPasswordChar = true;
            ptbUnHide1.Show();
        }

        private void txtTenGmail_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length != 0 && !IsValidEmail(txtTenGmail.Text.Trim()))
            {
                errorProvider1.SetError(ctr, "Email đã sai cú pháp rồi");
            }
            else errorProvider1.Clear();
        }
    }
}
