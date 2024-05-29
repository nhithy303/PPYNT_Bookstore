using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Web.Services.Description;
using Antlr.Runtime.Tree;
using System.Data.SqlClient;
using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.Ajax.Utilities;
using OfficeOpenXml.FormulaParsing.ExpressionGraph.FunctionCompilers;

namespace QuanLiNhaSach.User
{
    public partial class frmResetPassword : Form
    {
        string conso;
        string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
        SqlConnection conn;
        int count = 3;

        public frmResetPassword()
        {
            InitializeComponent();
            btnGuiMa.Enabled = false;
            btnXacthuc.Enabled = false;
            conn = new SqlConnection(s);
            grDatMK.Visible = false;
        }

        private string TenGmail(string tenkh, string sdt)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string str = "select TenGmail\r\nfrom KHACHHANG\r\nwhere TENKH = @tenkh and SDT = @sdt";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            SqlDataReader reader = cmd.ExecuteReader();
            string tenGmail = "";
            while(reader.Read())
            {
                tenGmail = reader.GetString(0);
            }
            conn.Close();
            return tenGmail;         
        }
        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            if (!KT_TEKH(txtTenKH.Text.Trim()) && txtTenKH.Text.Length > 0)
            {
                MessageBox.Show("Tên khách hàng này chưa tạo tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!KT_SDT(txtSDT.Text.Trim()) && txtSDT.Text.Length > 0)
            {
                MessageBox.Show("Tên khách hàng này chưa tạo tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                try
                {
                    string fromMail = "tangphung126@gmail.com";
                    string fromPasswword = "smcmxqrhytsnwfuj";
                    Random random = new Random();
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(fromMail);
                    message.Subject = "Thư reset mật khẩu của nhà sách PPYNT";
                    message.To.Add(new MailAddress(TenGmail(txtTenKH.Text.Trim(), txtSDT.Text.Trim())));
                    conso = random.Next(10000, 99999).ToString();
                    message.Body = "<html> <body> Dưới đây là con số reset mật khẩu của bạn: " + conso + " </body> </html>";

                    message.IsBodyHtml = true;

                    var smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential(fromMail, fromPasswword),
                        EnableSsl = true,
                    };
                    smtpClient.Send(message);
                    MessageBox.Show("Hệ thống đã gửi mail cho bạn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuiMa.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }        
        }

        private void btnXacthuc_Click(object sender, EventArgs e)
        {
            if(txtMaXacThuc.Text.Trim() == conso)
            {
                grDatMK.Visible = true;          
            }  
            else if (txtMaXacThuc.Text.Trim() != conso)
            {
                int so = count - 1;
                if (so == 0)
                {
                    MessageBox.Show("Bạn mất quyền đổi mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mã xác thực không đúng\nVui lòng nhập lại \nBạn còn " + so + " lượt điền nữa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count--;
                }
            }
            else if (count == 0)
            {
               
            }
        }

        private void ptbHide_Click(object sender, EventArgs e)
        {
            ptbHide.Hide();
            txtPassNew.UseSystemPasswordChar = true;
            ptbUnHide.Show();
        }

        private void ptbUnHide_Click(object sender, EventArgs e)
        {
            ptbUnHide.Hide();
            txtPassNew.UseSystemPasswordChar = false;
            ptbHide.Show();
        }

        private void ptbHide1_Click(object sender, EventArgs e)
        {
            ptbHide1.Hide();
            txtPassNew2.UseSystemPasswordChar = true;
            ptbUnHide1.Show();
        }

        private void ptbUnHide1_Click(object sender, EventArgs e)
        {
            ptbUnHide1.Hide();
            txtPassNew2.UseSystemPasswordChar = false;
            ptbHide1.Show();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.Trim() == String.Empty || txtPassNew.Text.Trim() == String.Empty ||txtTenKH.Text.Trim() == String.Empty || txtPassNew2.Text.Trim() == String.Empty )
            {
                MessageBox.Show("Bạn điền thiếu thông tin rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(txtPassNew.Text.Trim() != txtPassNew2.Text.Trim())
            {
                MessageBox.Show("Mật khẩu mới không khớp. Xin vùi lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else if (txtPassNew.Text.Length < 3)
            {
                MessageBox.Show("Mật khẩu phải dài hơn 3 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ConnectionState.Closed == conn.State) conn.Open();
                string str = "select MAKH\r\nfrom  KHACHHANG\r\nwhere TENKH = @tenkh and SDT = @sdt";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("@tenkh", txtTenKH.Text.Trim());
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();
                int makh = -1;
                while(reader.Read())
                {
                    makh = reader.GetInt32(0);  
                }
                reader.Close();
                str = "update DANGNHAP set MATKHAU = @mknew where MAKH = @makh";
                cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("@mknew", txtPassNew.Text.Trim());
                cmd.Parameters.AddWithValue("@makh", makh);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã đổi thành công mật khẩu","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                conn.Close();
                txtMaXacThuc.Clear(); txtPassNew.Clear(); txtPassNew2.Clear();
            } 
                
        }
        public bool KT_TEKH(string tenkh)
        {
            if (ConnectionState.Closed == conn.State) conn.Open();
            string str = "select count(makh)\r\nfrom KHACHHANG\r\nwhere TENKH = @ten";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.Parameters.AddWithValue("@ten", tenkh);
            SqlDataReader rd = cmd.ExecuteReader();
            int count = -1;
            while (rd.Read())
            {
                count = rd.GetInt32(0);
            }
            rd.Close();
            conn.Close();
            if (count == 0) return false; // 0 - chua co tai khoan
            else return true;
        }
        public bool KT_SDT(string sdt)
        {
            if (ConnectionState.Closed == conn.State) conn.Open();
            string str = "select count(makh)\r\nfrom KHACHHANG\r\nwhere SDT = @sdt";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            SqlDataReader rd = cmd.ExecuteReader();
            int count = -1;
            while (rd.Read())
            {
                count = rd.GetInt32(0);
            }
            rd.Close();
            conn.Close();
            if (count == 0) return false; // 0 - chua co tai khoan
            else return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtconso_TextChanged(object sender, EventArgs e)
        {
            if (txtMaXacThuc.Text.Length > 0)
            {
                btnXacthuc.Enabled = true;
            }
            else
            {
                btnXacthuc.Enabled = false;
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length > 0 && txtTenKH.Text.Length > 0)
            {
                btnGuiMa.Enabled = true;
            }
            else
            {
                btnGuiMa.Enabled = false;
            }
        }

        private void txtTenKH_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length == 0)
            {
                errorProvider1.SetError(ctr, "Bạn chưa điền tên của mình");
            }
            else if (!KT_TEKH(txtTenKH.Text.Trim()) && txtTenKH.Text.Length > 0)
            {
                errorProvider1.SetError(ctr, "Tên khách hàng này chưa tạo tài khoản");
            }
            else errorProvider1.Clear();
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length == 0)
            {
                errorProvider1.SetError(ctr, "Bạn chưa điền SDT của mình");
            }
            else if (!KT_SDT(txtSDT.Text.Trim()) && txtSDT.Text.Length > 0)
            {
                errorProvider1.SetError(ctr, "Tên khách hàng này chưa tạo tài khoản");
            }
            else errorProvider1.Clear();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length > 0 && txtTenKH.Text.Length > 0 )
            {
                btnGuiMa.Enabled = true;
            }
            else
            {
                btnGuiMa.Enabled = false;
            } 
               
        }
    }
}
