using DoAnLapTop.dao;
using DoAnLapTop.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTop.bus
{
    using dto;
    using System.Windows.Forms;

    internal class XuLyKhachHang
    {
      
        public XuLyKhachHang()
        {
            DsKhachHang = TruyCapDuLieu.getInstance().DsKhachHang;
        }
        public List<CKhachHang> DsKhachHang { get; set; }
        public bool them(CKhachHang kh)
        {
            CKhachHang khs = tim(kh.MaKH);
            if (khs == null) {
                DsKhachHang.Add(kh);
                    return true;
            }
            else return false;         
        }
        public CKhachHang tim(string ma)
        {
            foreach (CKhachHang kh in DsKhachHang)
                if (kh.MaKH.Equals(ma))
                    return kh;
            return null;
        }
        public bool xoa(string ma)
        {
            CKhachHang kh = tim(ma);
            if (kh != null)
            {
                DsKhachHang.Remove(kh);
                return true;
            }
            else return false;
        }
        public bool sua(CKhachHang khs)
        {
            CKhachHang kh = tim(khs.MaKH);
            if (kh != null)
            {
                kh.TenKH = khs.TenKH;
                kh.DiaChi = khs.DiaChi;
                kh.SoDT = khs.SoDT;
                return true;
            }
            else return false;
        }
    }
}
