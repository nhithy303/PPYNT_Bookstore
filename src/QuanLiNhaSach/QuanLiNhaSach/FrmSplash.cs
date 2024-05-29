using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace QuanLiNhaSach
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
            timer1.Start();
        }
        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 2;
            MyProgress.Value = startP;
            lblPercent.Text = startP.ToString() + "%";
            if (MyProgress.Value == 100)
            {
                startP = 0;
                frmLoginUser user = new frmLoginUser();
                user.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
