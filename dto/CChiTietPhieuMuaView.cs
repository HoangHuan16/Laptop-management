using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTop.dto
{
    [Serializable]
    internal class CChiTietPhieuMuaView
    {
        public string malaptop { get; set; }
        public string tenlaptop { get; set; }
        public string hanglaptop { get; set; }
        public string dongia { get; set; }
        public string soluong { get; set; }
        public string thanhtien { get; set; }
        public static List<CChiTietPhieuMuaView> getCChiTietPhieuMuaViews(CPhieuMuaHang pmh)
        {
            List<CChiTietPhieuMuaView> ds = new List<CChiTietPhieuMuaView>();
            foreach (CChiTietPhieuMua ct in pmh.DsChiTietPhieuMua)
            {
                CChiTietPhieuMuaView viewItem = new CChiTietPhieuMuaView();
                viewItem.malaptop = ct.LapTop.MaLapTop;
                viewItem.hanglaptop = ct.LapTop.NhaCungCap.TenNCC;
                viewItem.tenlaptop = ct.LapTop.TenLapTop;
                viewItem.dongia = ct.LapTop.DonGia.ToString();
                viewItem.soluong = ct.SoLuong.ToString();
                viewItem.thanhtien = ct.ThanhTien.ToString();
                ds.Add(viewItem);
            }
            return ds;
        }
     
    }
}
