using QuanLiNhaSach.Admin;
using QuanLiNhaSach.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string server_name = "LAPTOP-F1HDEG46\\TANGNGOCPHUNG";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSplash());
            //Application.Run(new frmLoginUser());
        }
    }
}
