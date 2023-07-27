using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTop.dto
{
    [Serializable]
    internal class CKhachHang
    {
        private string maKH;
        private string tenKH;
        private string soDT;
        private string diaChi;
        public CKhachHang() : this("", "", "", "") { }
        public CKhachHang(string maKH, string tenKH, string soDT, string diaChi)
        {
            MaKH= maKH;
            TenKH = tenKH;
            SoDT = soDT;
            DiaChi = diaChi;
        }

        public string MaKH { get { return maKH; } set { maKH = value; } }
        public string TenKH { get { return tenKH; } set { tenKH = value; } }
        public string SoDT { get { return soDT; } set { soDT = value; } }
        public string DiaChi { get { return diaChi; } set { diaChi = value; } }
    }
}
