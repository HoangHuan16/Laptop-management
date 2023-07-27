using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTop.dto
{
    [Serializable]
    internal class CChiTietPhieuMua
    {
        
        private string maPhieuMua;
        private CLapTop lapTop;
        private int soLuong;
        private double donGia;

        public CChiTietPhieuMua(string maPhieuMua, CLapTop lapTop, int soLuong, double donGia)
        {
            MaPhieuMua = maPhieuMua;
            LapTop = lapTop;
            SoLuong = soLuong;
            DonGia = donGia;
        }
        public CChiTietPhieuMua() : this(null,null,0,0) { }
        public double ThanhTien { get { return SoLuong * DonGia;  } }
        public string MaPhieuMua { get { return maPhieuMua; } set { maPhieuMua = value; } }
        public CLapTop LapTop { get { return lapTop; } set { lapTop = value; } }
        public int SoLuong { get { return soLuong; } set { soLuong = value; } }
        public double DonGia { get { return donGia; } set { donGia = value; } }
    }
}
