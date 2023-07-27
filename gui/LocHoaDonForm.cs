using DoAnLapTop.bus;
using DoAnLapTop.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLapTop.gui
{
    public partial class LocHoaDonForm : Form
    {
        private List<CPhieuMuaHang> ds;

        private XuLyKhachHang xlKH;
        private XuLyPhieuMua xuly;
        public LocHoaDonForm()
        {
            InitializeComponent();
            xlKH= new XuLyKhachHang();
        }
        private void hienthi(List<CPhieuMuaHang> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            dgvHoaDon.DataSource = bs;
            
        }
        private void hienthiTen(List<CPhieuMuaHang> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            dgvLocTen.DataSource = bs;

        }

        public void kt(DateTime ngay)
        {
            bool flag = true;
            xuly = new XuLyPhieuMua();
            ds = new List<CPhieuMuaHang>();
            foreach (CPhieuMuaHang pm in xuly.DsPhieuMuaHang)
            {
                if (dtpHoaDon.Value == pm.NgayLap)
                {
                    ds.Add(pm);
                    flag = false;
                }
                hienthi(ds);
            }
            if (flag == true) MessageBox.Show("Không có hóa đơn nào vào " + dtpHoaDon.Value.Day+"/"+dtpHoaDon.Value.Month+"/"+dtpHoaDon.Value.Year,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }


        public void ktTen(string ten)
        {
         
            xuly = new XuLyPhieuMua();
            ds = new List<CPhieuMuaHang>();
            foreach (CPhieuMuaHang pm in xuly.DsPhieuMuaHang)
            {
                if (ten.Equals(pm.TenKH))
                {
                    ds.Add(pm);
                }
                else if(ten =="")ds=new List<CPhieuMuaHang>();
                hienthiTen(ds);

            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            kt(dtpHoaDon.Value);
            //xuly = new XuLyPhieuMua();
            // ds=new List<CPhieuMuaHang>();
            // foreach (CPhieuMuaHang pm in xuly.DsPhieuMuaHang)
            // {
            //     if (dtpHoaDon.Value == pm.NgayLap)
            //     {
            //         ds.Add(pm);
            //     }     
            //     hienthi(ds);
            // } 
        }

        private void LocHoaDonForm_Load(object sender, EventArgs e)
        {
            hienthiTen(xlKH.DsKhachHang);
        }

        private void btnLocTen_Click(object sender, EventArgs e)
        {
            try
            {
            int i = cbTen.SelectedIndex;
            ktTen(xlKH.DsKhachHang[i].TenKH);

            }
            catch (Exception)
            {

                MessageBox.Show("Không có người nào tên là "+cbTen.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void hienthiTen(List<CKhachHang> dskh)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dskh;
            cbTen.DataSource = bs;
        }

        private void btnXemPhieuMua_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvLocTen.SelectedRows)
            {
                string ma = r.Cells[0].Value.ToString();
                XemHoaDonForm x = new XemHoaDonForm();
                x.maHD = ma;
                x.ShowDialog();
                break;
            }
        }
    }
}
