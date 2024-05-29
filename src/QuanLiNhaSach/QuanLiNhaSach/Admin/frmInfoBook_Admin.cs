using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach.Admin
{
    public partial class frmInfoBook_Admin : Form
    {
        public string NoiDungCuonsach = "";
        public frmInfoBook_Admin()
        {
            InitializeComponent();
        }
        public frmInfoBook_Admin(string chuyendulieu)
        {
            InitializeComponent();
            txtNoiDungCuonSach.Text = chuyendulieu;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            NoiDungCuonsach = txtNoiDungCuonSach.Text;
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
