using DoAnLapTop.bus;
using DoAnLapTop.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLapTop.gui
{
    public partial class XemHoaDonForm : Form
    {
        public string maHD;
        private XuLyPhieuMua xuly;
        public XemHoaDonForm()
        {
            InitializeComponent();
        }
       
 

     private void hienthi(CPhieuMuaHang pm)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = CChiTietPhieuMuaView.getCChiTietPhieuMuaViews(pm);
            dgvXemCT.DataSource = bs;     
        }

        private void xem_Load(object sender, EventArgs e)
        {
            xuly = new XuLyPhieuMua();
            CPhieuMuaHang pm = xuly.tim(maHD);
            lbMaPM.Text = pm.MaPhieuMua;
            lbNgay.Text = pm.NgayLap.Day.ToString()+"/" + pm.NgayLap.Month.ToString() + "/" +pm.NgayLap.Year.ToString();
            lbMaKH.Text = pm.MaKH;
            lbTenKH.Text = pm.TenKH;
            lbSoDT.Text = pm.SoDT;
            lbDiaChi.Text = pm.DiaChi;
            lbThanhTien.Text = pm.ThanhTien.ToString();
            hienthi(pm);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvXemCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
