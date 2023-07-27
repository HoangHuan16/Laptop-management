using DoAnLapTop.dao;
using DoAnLapTop.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTop.bus
{
    internal class XuLyNhaCungCap
    {
        private List<CNhaCungCap> dsNhaCungCap;
        public XuLyNhaCungCap()
        {
            DsNhaCungCap = TruyCapDuLieu.getInstance().DsNhaCungCap;
        }
        public List<CNhaCungCap> DsNhaCungCap { get { return dsNhaCungCap; } set { dsNhaCungCap = value; } }
        public bool them(CNhaCungCap ncc)
        {
            CNhaCungCap nccs = tim(ncc.MaNCC);
            if (nccs == null)
            {
                DsNhaCungCap.Add(ncc);
                return true;
            }
            else return false;
        }
        public CNhaCungCap tim(string ma)
        {
            foreach (CNhaCungCap ncc in DsNhaCungCap)
                if (ncc.MaNCC.Equals(ma))
                    return ncc;
            return null;
        }
     
        public bool xoa(string ma)
        {
            CNhaCungCap ncc = tim(ma);
            if (ncc != null)
            {
                DsNhaCungCap.Remove(ncc);
                return true;
            }
            else return false;
        }
        public bool sua(CNhaCungCap nccs)
        {
            CNhaCungCap ncc = tim(nccs.MaNCC);
            if (ncc != null)
            {
                ncc.TenNCC = nccs.TenNCC;
                ncc.DiaChi = nccs.DiaChi;
                ncc.SoDT = nccs.SoDT;
                return true;
            }
            else return false;
        }
    }
}
