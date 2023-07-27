using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTop.dto
{
    [Serializable]
    internal class CPhieuMuaHang
    {

        public string MaPhieuMua { get; set; }
        public DateTime NgayLap { get; set; }
        internal CKhachHang khachHang { get; set; }
        internal List<CChiTietPhieuMua> DsChiTietPhieuMua { get; set; }
        public CPhieuMuaHang(string maPhieuMua, DateTime ngayLap, CKhachHang KhachHang, List<CChiTietPhieuMua> dsChiTietPhieuMua)
        {
            MaPhieuMua = maPhieuMua;
            NgayLap = ngayLap;
            khachHang = KhachHang;
            DsChiTietPhieuMua = dsChiTietPhieuMua;
        }
        public CPhieuMuaHang() : this("",DateTime.MaxValue,new CKhachHang(),new List<CChiTietPhieuMua>()) { }
        public string TenKH
        { get { return khachHang.TenKH; } }
        public string MaKH
        { get { return khachHang.MaKH; } }
        public string SoDT
        { get { return khachHang.SoDT; } }
        public string DiaChi
        { get { return khachHang.DiaChi; } }
     
        public double ThanhTien
        {
            get
            {
                double sum = 0;
                foreach (CChiTietPhieuMua ct in DsChiTietPhieuMua)
                    sum += ct.ThanhTien;
                return sum;
            }
        }
    }
}
