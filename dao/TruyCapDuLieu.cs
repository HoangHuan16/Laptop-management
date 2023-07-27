using DoAnLapTop.dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTop.dao
{
    [Serializable]
    internal class TruyCapDuLieu
    {
        private static TruyCapDuLieu _instance = null;
        private List<CLapTop> dsLaptop;
        private List<CKhachHang> dsKhachHang;
        private List<CNhaCungCap> dsNhaCungCap;
        private List<CPhieuMuaHang> dsMuaHang;
        private List<CChiTietPhieuMua> dsChiTietPhieuMua ;
        private List<CChiTietPhieuMuaView> dsChiTietPhieuMuaView;


        private TruyCapDuLieu()
        {
            dsLaptop = new List<CLapTop>();
            dsKhachHang = new List<CKhachHang>();
            dsNhaCungCap = new List<CNhaCungCap>();
            dsMuaHang=new List<CPhieuMuaHang>();
            dsChiTietPhieuMua = new List<CChiTietPhieuMua>();
            dsChiTietPhieuMuaView = new List<CChiTietPhieuMuaView>();

        }
        public List<CLapTop> DsLaptop { get { return dsLaptop; } }
        public List<CKhachHang> DsKhachHang { get { return dsKhachHang; } }
        public List<CNhaCungCap> DsNhaCungCap { get { return dsNhaCungCap; } }
        public List<CPhieuMuaHang> DsPhieuMuaHang { get { return dsMuaHang; } }
        public List<CChiTietPhieuMua> DsChiTietPhieuMua { get { return dsChiTietPhieuMua; } }
        public List<CChiTietPhieuMuaView> DsChiTietPhieuMuaView { get { return dsChiTietPhieuMuaView; } }


        public static TruyCapDuLieu getInstance()
        {
            if (_instance == null)
                if (!docFile("dslt.bin"))
                    _instance = new TruyCapDuLieu();
            return _instance;
        }
        public static bool docFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                _instance = (TruyCapDuLieu)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }
        public static bool ghiFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, getInstance());
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }
    }
}
