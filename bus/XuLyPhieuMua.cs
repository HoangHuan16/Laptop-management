using DoAnLapTop.dao;
using DoAnLapTop.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLapTop.bus
{
    internal class XuLyPhieuMua
    {

      
        public List<CKhachHang> DsKhachHang { get; set; }
        public List<CLapTop> DsLapTop { get; set; }
        public List<CPhieuMuaHang> DsPhieuMuaHang { get; set; }
        public XuLyPhieuMua()
        {
            DsKhachHang = TruyCapDuLieu.getInstance().DsKhachHang;
            DsLapTop = TruyCapDuLieu.getInstance().DsLaptop;
            DsPhieuMuaHang = TruyCapDuLieu.getInstance().DsPhieuMuaHang;
      
        }
      
        public void them(CPhieuMuaHang pmh)
        {

                CPhieuMuaHang pmh1 = tim(pmh.MaPhieuMua);
                if (pmh1 == null) DsPhieuMuaHang.Add(pmh);
                else
                MessageBox.Show("Mã phiếu mua "+pmh.MaPhieuMua+"bị trùng!!! mời bạn nhập lại.","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
  
        }
        public CPhieuMuaHang tim(string ma)
        {
            foreach (CPhieuMuaHang pmh in DsPhieuMuaHang)
                if (pmh.MaPhieuMua.Equals(ma))
                    return pmh;
            return null;
        }
    
        
      
        public void them(CPhieuMuaHang pmh,CLapTop lt,int soLuong,double donGia)
        {
            CChiTietPhieuMua ctpm = null;
            foreach(CChiTietPhieuMua _ctpm in pmh.DsChiTietPhieuMua)
                if (_ctpm.LapTop.MaLapTop.Equals(lt.MaLapTop))
                {
                    ctpm = _ctpm;
                    break;
                }
            if (ctpm == null)
            {
                ctpm = new CChiTietPhieuMua(pmh.MaPhieuMua, lt, 0, lt.DonGia);
                pmh.DsChiTietPhieuMua.Add(ctpm);
            }
            ctpm.SoLuong+=soLuong;
        }
        public void xoa(string ma)
        {
            CPhieuMuaHang pmh = tim(ma);
            if (pmh != null) 
                DsPhieuMuaHang.Remove(pmh);
        }
    }
}
