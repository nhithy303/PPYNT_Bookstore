using Microsoft.Office.Interop.Excel;
using QuanLiNhaSach.Admin;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach
{
    public partial class frmDetailedInvoice : Form
    {
        // connect to SQL server
        SqlConnection connsql;
        // Mã hóa đơn
        string MAHD;
        string KenhMua;
        double TongTien;
        bool ThanhToan; // true: đơn hàng đã thanh toán => không thể thêm sách
                        // false: đơn hàng vừa tạo mới => có thể thêm sách

        public frmDetailedInvoice(string MHD, string kenhmua, bool thanhtoan)
        {
            InitializeComponent();
            string s = @"Data Source=" + Program.server_name + ";Initial Catalog = QLNS; Integrated Security = True";
            connsql = new SqlConnection(s);
            MAHD = MHD;
            KenhMua = kenhmua;
            ThanhToan = thanhtoan;
            datetime.Format = DateTimePickerFormat.Custom;
            datetime.CustomFormat = "dd'/'MM'/'yyyy";
        }

        private void frmDetailedInvoice_Load(object sender, EventArgs e)
        {
            // load date lên datagridview
            dgvHoadon.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAddBook.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHoaDon_Load();
            if (KenhMua == "Offline")
            {
                gbOrderDetail.Text = "Đơn hàng Offline";
            }
            else
            {
                gbOrderDetail.Text = "Đơn hàng Online";
            }
            ThanhToan_Changed();

            // load data lên textbox
            if (connsql.State == ConnectionState.Closed) { connsql.Open(); }
            string str = "SELECT TENKH, HinhThucTT, NgayHD, TongTien " +
                "FROM HoaDon INNER JOIN KHACHHANG ON HoaDon.MAKH = KHACHHANG.MAKH " +
                "WHERE HoaDon.MaHD = " + MAHD;
            SqlCommand cmd = new SqlCommand(str, connsql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtNameCustomer.Text = dr.GetString(0);
                txtPaymentMethod.Text = dr.GetString(1);
                datetime.Value = dr.GetDateTime(2);
                TongTien = dr.GetDouble(3);
            }
            dr.Close();
            if (connsql.State == ConnectionState.Open) { connsql.Close(); }
            txtCodeOrder.Text = MAHD;
            txtSumCost.Text = TongTien.ToString();
        }

        private void ThanhToan_Changed()
        {
            if (!ThanhToan)
            {
                btnQuit.Text = "Hủy";
                btnPayPrint.Text = "Thanh toán và in";
                btnDelete.Visible = true;
                gbThemSach.Visible = true;
                dgvAddBook_Load();
            }
            else
            {
                btnQuit.Text = "Thoát";
                btnPayPrint.Text = "In hóa đơn";
                btnDelete.Visible = false;
                gbThemSach.Visible = false;
                dgvHoadon.ReadOnly = true;
            }
        }

        private void dgvHoaDon_Load()
        {
            try
            {
                dgvHoadon.Rows.Clear();
                if (connsql.State == ConnectionState.Closed) { connsql.Open(); }
                string str = "SELECT Sach.MASACH, Sach.TENSACH, ChiTietHoaDon.SLSach, Sach.GIASACH, TongGiaSach " +
                    "FROM HoaDon INNER JOIN ChiTietHoaDon ON HoaDon.MaHD = ChiTietHoaDon.MAHD " +
                    "INNER JOIN Sach ON ChiTietHoaDon.MaSach = Sach.MASACH " +
                    "WHERE HoaDon.MaHD = " + MAHD;
                SqlCommand cmd = new SqlCommand(str, connsql);
                SqlDataReader dr = cmd.ExecuteReader();
                int stt = 1;
                while (dr.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvHoadon);
                    row.Cells[0].Value = stt++;
                    row.Cells[1].Value = dr.GetInt32(0);
                    row.Cells[2].Value = dr.GetString(1);
                    row.Cells[3].Value = dr.GetInt32(2).ToString();
                    row.Cells[4].Value = dr.GetDouble(3).ToString();
                    row.Cells[5].Value = dr.GetInt32(4);
                    dgvHoadon.Rows.Add(row);
                }
                dr.Close();
                if (connsql.State == ConnectionState.Open) { connsql.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAddBook_Load()
        {
            try
            {
                dgvAddBook.Rows.Clear();
                if (connsql.State == ConnectionState.Closed) { connsql.Open(); }
                string str = "SELECT MASACH, TENSACH, SLSACH, GIASACH FROM Sach";
                SqlCommand cmd = new SqlCommand(str, connsql);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvAddBook);
                    row.Cells[0].Value = dr.GetInt32(0).ToString();
                    row.Cells[1].Value = dr.GetString(1);
                    row.Cells[2].Value = dr.GetInt32(2).ToString();
                    row.Cells[3].Value = dr.GetDouble(3).ToString();
                    dgvAddBook.Rows.Add(row);
                }
                dr.Close();
                if (connsql.State == ConnectionState.Open) { connsql.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string str;
            int kq;
            if (connsql.State == ConnectionState.Closed) { connsql.Open(); }
            foreach (DataGridViewRow row in dgvAddBook.Rows)
            {
                //chk checkbox trong drvAddBook
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[4];

                if (Convert.ToBoolean(chk.Value) == true)
                {
                    //Kiểm tra số lượng sách trong kho
                    string ms = row.Cells[0].Value.ToString(); // get mã sách được thêm
                    str = "SELECT SLSach FROM SACH WHERE MaSach = " + ms ;
                    SqlCommand cmd = new SqlCommand(str, connsql);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.GetInt32(0) == 0)
                        {
                            MessageBox.Show("Sách bạn chọn hiện tại đã hết hàng, hẹn bạn lần sau nhé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    dr.Close();

                    //Tăng giá trị hóa đơn
                    string gs = row.Cells[3].Value.ToString(); // get giá sách được thêm
                    TongTien += Convert.ToDouble(gs);
                    txtSumCost.Text = TongTien.ToString();

                    //Giảm số lượng sách trong kho
                    str = "UPDATE SACH SET SLSach = SLSach - 1" + " WHERE MASACH = " + ms;
                    cmd = new SqlCommand(str, connsql);
                    kq = cmd.ExecuteNonQuery();

                    //Giảm số lượng sách trong dgvAddBook
                    row.Cells[2].Value = (int.Parse(row.Cells[2].Value.ToString()) - 1).ToString();

                    //Kiểm tra sách có tồn tại trong đơn hàng
                    bool check = false;
                    str = "SELECT MaSach, SLSach FROM ChiTietHoaDon WHERE MaSach = " + ms + " AND MaHD = " + MAHD;
                    cmd = new SqlCommand(str, connsql);
                    dr = cmd.ExecuteReader();
                    int msinDH = 0;
                    int slsach = 0;
                    while (dr.Read())
                    {
                        msinDH = dr.GetInt32(0);
                        slsach = dr.GetInt32(1);
                        check = true;
                    }
                    dr.Close();

                    //Thêm sách vào Chi tiết hóa đơn
                    if (check == false) 
                    {
                        str = "INSERT INTO ChiTietHoaDon VALUES (" + MAHD + ", " + ms + ", 1, " + gs + ")";
                        cmd = new SqlCommand(str, connsql);
                        kq = cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        slsach++;
                        str = "UPDATE ChiTietHoaDon SET SLSach = " + slsach.ToString() + ", TongGiaSach = " + (slsach * Convert.ToInt32(gs)).ToString()
                            + " WHERE MaHD = " + MAHD.ToString() + " AND MaSach = " + msinDH.ToString();
                        SqlCommand cm = new SqlCommand(str, connsql);
                        kq = cm.ExecuteNonQuery();
                    }

                    //uncheck
                    row.Cells[4].Value = false;
                }
            }

            //Cập nhật bảng hóa đơn
            str = "UPDATE HoaDon SET TongTien = " + TongTien.ToString() + "WHERE MaHD = " + MAHD;
            SqlCommand command = new SqlCommand(str, connsql);
            kq = command.ExecuteNonQuery();
            if (connsql.State == ConnectionState.Open) { connsql.Close(); }

            //update
            dgvHoaDon_Load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str;
            if (connsql.State == ConnectionState.Closed) { connsql.Open(); }
            foreach (DataGridViewRow row in dgvHoadon.Rows)
            {
                //chk checkbox trong drvHoaDon
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[6];

                if (Convert.ToBoolean(chk.Value) == true)
                {
                    // get mã sách bị xóa
                    //string ts = row.Cells[1].Value.ToString();
                    //str = "SELECT MASACH FROM SACH WHERE TENSACH = N'" + ts + "'" ;
                    //SqlCommand cm = new SqlCommand(str, connsql);
                    //SqlDataReader dr = cm.ExecuteReader();
                    //string ms = "";
                    //while (dr.Read()) ms = dr.GetInt32(0).ToString();
                    //dr.Close();

                    //Xóa sách trong Chi tiết hóa đơn
                    string ms = row.Cells[1].Value.ToString(); // get mã sách bị xóa
                    string tgs = row.Cells[5].Value.ToString(); // get tổng giá sách bị xóa
                    str = "DELETE FROM ChiTietHoaDon WHERE MaSach = " + ms + " and MAHD = " + MAHD;
                    SqlCommand cmd = new SqlCommand(str, connsql);
                    cmd.ExecuteNonQuery();

                    //Giảm giá trị hóa đơn
                    TongTien -= Convert.ToDouble(tgs);
                    txtSumCost.Text = TongTien.ToString();

                    //Tăng số lượng sách trong kho
                    str = "UPDATE SACH SET SLSach = SLSach + " + row.Cells[3].Value.ToString() + " WHERE MASACH = " + ms;
                    cmd = new SqlCommand(str, connsql);
                    cmd.ExecuteNonQuery();

                    //Tăng số lượng sách trong dgvAddBook
                    foreach (DataGridViewRow row1 in dgvAddBook.Rows)
                    {
                        //Tìm mã sách của sách bị xóa trong dgvAddBook
                        if (row1.Cells[0].Value.ToString() == ms)
                        {
                            row1.Cells[2].Value = (int.Parse(row1.Cells[2].Value.ToString()) + int.Parse(row.Cells[3].Value.ToString())).ToString();
                            break;
                        }
                    }
                }
            }

            //Cập nhật bảng hóa đơn
            str = "UPDATE HoaDon SET TongTien = " + TongTien.ToString() + "WHERE MaHD = " + MAHD;
            SqlCommand cmd1 = new SqlCommand(str, connsql);
            cmd1.ExecuteNonQuery();
            if (connsql.State == ConnectionState.Open) { connsql.Close(); }

            //update
            dgvHoaDon_Load();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void btnPayPrint_Click(object sender, EventArgs e)
        {
            // Thanh toán đơn hàng
            if (btnPayPrint.Text == "Thanh toán và in")
            {
                if (dgvHoadon.Rows.Count == 0)
                {
                    MessageBox.Show("Đơn hàng hiện đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult r = MessageBox.Show("Tổng số tiền thanh toán là: " + txtSumCost.Text + "\nBạn có chắc chắn muốn thanh toán không?",
                    "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No) { return; }
                
                // Thanh toán thành công
                ThanhToan = true;
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThanhToan_Changed();
            }

            // In hóa đơn
            DataSet ds = new DataSet();
            ds.Tables.Add("DetailedInvoice");
            ds.Tables[0].Columns.Add("TENSACH");
            ds.Tables[0].Columns.Add("SOLUONG");
            ds.Tables[0].Columns.Add("DONGIA");
            ds.Tables[0].Columns.Add("THANHTIEN");
            foreach (DataGridViewRow row in dgvHoadon.Rows)
            {
                DataRow newRow_Books = ds.Tables[0].NewRow();
                for (int i = 0; i < 4; i++)
                {
                    newRow_Books[i] = row.Cells[i + 2].Value;
                }
                ds.Tables[0].Rows.Add(newRow_Books);
            }
            new frmDetailedInvoice_Print(ds, txtCodeOrder.Text, datetime.Value.ToString("yyyy/MM/dd"), txtNameCustomer.Text, txtSumCost.Text).ShowDialog();
        }

        private void frmDetailedInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnQuit.Text == "Hủy")
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng này không?", "Hủy đơn hàng",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        if (connsql.State == ConnectionState.Closed) { connsql.Open(); }
                        // Xóa Chi tiết đơn hàng của Đơn hàng muốn hủy
                        string query = "delete from ChiTietHoaDon where MAHD = " + txtCodeOrder.Text;
                        new SqlCommand(query, connsql).ExecuteNonQuery();
                        
                        // Cập nhật lại số lượng sách
                        foreach (DataGridViewRow row in dgvHoadon.Rows)
                        {
                            query = "update Sach set SLSACH = SLSACH + " + row.Cells[3].Value.ToString()
                                + " where MASACH = " + row.Cells[1].Value.ToString();
                            new SqlCommand(query, connsql).ExecuteNonQuery();
                        }

                        // Cập nhật Tổng tiền của Hóa đơn
                        query = "update HoaDon set TongTien = 0 where MaHD = " + txtCodeOrder.Text;
                        new SqlCommand(query, connsql).ExecuteNonQuery();
                        if (connsql.State == ConnectionState.Open) { connsql.Close(); }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else { e.Cancel = true; }
            }
        }

        /*
        private void chbAddBook_CheckedChanged(object sender, EventArgs e)
        {
            // show / hide thêm sách
            if (!chbAddBook.Checked)
            {
                btnAddBook.Hide();
                dgvAddBook.Hide();
            }
            else
            {
                btnAddBook.Show();
                dgvAddBook.Show();
            }
        }
        */
    }
}
