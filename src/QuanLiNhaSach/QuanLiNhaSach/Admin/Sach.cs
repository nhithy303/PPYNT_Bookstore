using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.Admin
{
    internal class Sach
    {
        public string MASACH { get; set; }
        public string TENSACH { get; set; }
        public int MATG { get; set; }
        public string TENTL { get; set; }
        public float GIASACH { get; set; }
        public int SLSACH { get; set; }
        public int MANXB { get; set; }
        public byte[] HinhAnh { get; set; }
        public string TomTat { get; set; }
    }
}
