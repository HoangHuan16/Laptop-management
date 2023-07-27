using DoAnLapTop.dao;
using DoAnLapTop.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTop.bus
{
    internal class XuLyLapTop
    {
        private List<CLapTop> dsLapTop;
        private List<CNhaCungCap> dsNhaCungCap;
        public XuLyLapTop()
        {
            DsLapTop = TruyCapDuLieu.getInstance().DsLaptop;
            DsNhaCungCap = TruyCapDuLieu.getInstance().DsNhaCungCap;
        }
        public List<CLapTop> DsLapTop { get; set; }
        public List<CNhaCungCap> DsNhaCungCap { get; set; }
        public bool them(CLapTop lt)
        {
            CLapTop lts = tim(lt.MaLapTop);
            if (lts == null)
            {
                DsLapTop.Add(lt);
                return true;
            }
            else return false;
        }
   
        public CLapTop tim(string ma)
        {
            foreach (CLapTop lt in DsLapTop)
                if (lt.MaLapTop.Equals(ma))
                    return lt;
            return null;
        }
        public bool xoa(string maHang)
        {
            CLapTop lt = tim(maHang);
            if (lt != null) 
            {
                DsLapTop.Remove(lt); 
                return true; 
            }
            else return false;
        }
        public bool sua(CLapTop lts)
        {
            CLapTop lt = tim(lts.MaLapTop);
            if (lt != null)
            {
                lt.TenLapTop = lts.TenLapTop;
                lt.NhaCungCap = lts.NhaCungCap;
                lt.DonGia=lts.DonGia;
                return true;
            }
            else return false;
        }
    }
}
