using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTop.dto
{
    [Serializable]
    internal class CNhaCungCap
    {
        private string maNCC;
        private string tenNCC;
        private string soDT;
        private string diaChi;
        public CNhaCungCap() : this("", "", "", "") { }
        public CNhaCungCap(string maNCC, string tenNCC, string soDT, string diaChi)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            SoDT = soDT;
            DiaChi = diaChi;
        }

        public string MaNCC { get { return maNCC; } set { maNCC = value; } }
        public string TenNCC { get { return tenNCC; } set { tenNCC = value; } }
        public string SoDT { get { return soDT; } set { soDT = value; } }   
        public string DiaChi { get { return diaChi; } set {diaChi = value; } }
        public override string ToString()
        {
            return TenNCC;
        }
    }
}
