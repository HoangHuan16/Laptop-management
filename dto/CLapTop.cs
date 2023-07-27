using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTop.dto
{
    [Serializable]
   
    internal class CLapTop
    {
        private string maLapTop;
        private string tenLapTop;
        private double donGia;
        private CNhaCungCap nhaCungCap;
        public CLapTop() : this("","",0,null) { }

        public CLapTop(string maLapTop, string tenLapTop, double donGia, CNhaCungCap nhaCungCap)
        {
            MaLapTop = maLapTop;
            TenLapTop = tenLapTop;
            DonGia = donGia;
            NhaCungCap = nhaCungCap;
           
        }

        public string MaLapTop { get { return maLapTop; } set { maLapTop = value; } }
        public string TenLapTop { get { return tenLapTop; } set { tenLapTop = value; } }
        public double DonGia { get { return donGia; } set { donGia = value; } }
        public CNhaCungCap NhaCungCap { get { return nhaCungCap; } set { nhaCungCap = value; } }


      
    }
}
