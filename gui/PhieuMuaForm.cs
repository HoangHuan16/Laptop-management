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
    public partial class PhieuMuaForm : Form
    {
        private XuLyPhieuMua xuly;
        private CPhieuMuaHang pm;
        public PhieuMuaForm()
        {
            InitializeComponent();
        }
        private void clear() 
        {
            pm=new CPhieuMuaHang();
            txtMaPhieu.Text = "";
            dtpNgayLap.Value = DateTime.Today;
            txtMaKH.Text = "";
            cboTenKH.SelectedIndex = 0;
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
            dgvCTPM.DataSource = CChiTietPhieuMuaView.getCChiTietPhieuMuaViews(pm);
        }
        private void hienThiChiTiet(CPhieuMuaHang pm)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = CChiTietPhieuMuaView.getCChiTietPhieuMuaViews(pm);
            dgvCTPM.DataSource=bs;
        }
        private void hienthi() 
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xuly.DsPhieuMuaHang;
            dgvPhieuMua.DataSource = bs;
        }

       


        private void btnXemPhieuMua_Click(object sender, EventArgs e)//can chinh sua lai
        {
            //if (dgvPhieuMua.SelectedRows.Count == 0) return;
            //int i = dgvPhieuMua.SelectedRows[0].Index;
            //pm = xuly.DsPhieuMuaHang[i];
            //txtMaPhieu.Text = pm.MaPhieuMua;
            //dgvCTPM.DataSource = CChiTietPhieuMuaView.getCChiTietPhieuMuaViews(pm);
            foreach (DataGridViewRow r in dgvPhieuMua.SelectedRows)
            {
                string ma = r.Cells[0].Value.ToString();
                XemHoaDonForm x = new XemHoaDonForm();
                x.maHD = ma;
                x.ShowDialog();
                break;
            }
        }
        private void btnTaoPhieuMua_Click(object sender, EventArgs e)
        {
            clear();
            cboTenKH.Focus();

        }

        private void btnXoaPhieuMua_Click(object sender, EventArgs e)
        {
            //if (dgvPhieuMua.SelectedRows.Count == 0) return;
            //string ma = dgvPhieuMua.SelectedRows[0].Cells[0].Value.ToString();
            //xuly.xoa(ma);
            //hienthi();
            xuly.xoa(txtMaPhieu.Text);
            hienthi();
    
        }
        private void dgvCTPM_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvCTPM.Rows[e.RowIndex];
            if (dgvCTPM.SelectedCells.Count > 0)
            {
                txtMaLapTop.Text = r.Cells[0].Value.ToString();
                cboTenLapTop.Text = r.Cells[1].Value.ToString();
                txtTenNCC.Text = r.Cells[2].Value.ToString();
                txtSoLuong.Text = r.Cells[3].Value.ToString();
                txtDonGia.Text = r.Cells[4].Value.ToString();
            }
        }

        private void dgvPhieuMua_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvPhieuMua.Rows[e.RowIndex];
            if (dgvPhieuMua.SelectedCells.Count > 0)
            {
                txtMaPhieu.Text = r.Cells[0].Value.ToString();
                dtpNgayLap.Text = r.Cells[1].Value.ToString();
                cboTenKH.Text = r.Cells[2].Value.ToString();
                txtMaKH.Text = r.Cells[3].Value.ToString();
             
            }
        }
       

        private void PhieuMuaForm_Load(object sender, EventArgs e)
        {
            dgvPhieuMua.AutoGenerateColumns = false;
            xuly = new XuLyPhieuMua();
            pm = new CPhieuMuaHang();
            xuly = new XuLyPhieuMua();
            hienthi();
            BindingSource bs1=new BindingSource();
            bs1.DataSource = xuly.DsKhachHang;
            cboTenKH.DataSource = bs1;
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = xuly.DsLapTop;
            cboTenLapTop.DataSource= bs2;
        }

        private void btnChonCTPM_Click(object sender, EventArgs e)
        {
            CLapTop lt = xuly.DsLapTop[cboTenLapTop.SelectedIndex];
            int soLuong = 0;
            try
            {
                soLuong = int.Parse(txtSoLuong.Text.Trim());
            }
            catch (Exception)
            {
            }
              if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
            }
           else xuly.them(pm, lt, soLuong, lt.DonGia);
            dgvCTPM.DataSource = CChiTietPhieuMuaView.getCChiTietPhieuMuaViews(pm);
            txtSoLuong.Text = "";
        }

        private void btnLapCTPM_Click(object sender, EventArgs e)
        {
            
            if (pm.DsChiTietPhieuMua.Count == 0)
            {
                clear();
                return;
            };
                int i = cboTenKH.SelectedIndex;
                CKhachHang kh = xuly.DsKhachHang[i];
            //if (txtMaPhieu.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập mã phiếu mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtMaPhieu.Focus();
            //}

            //else
            //{
                int count = 0;
                count = dgvPhieuMua.Rows.Count+1;
                if (count < 10) txtMaPhieu.Text = "PM0" + count++.ToString();
                else if (count >= 10) txtMaPhieu.Text = "PM" + count++.ToString(); 
                pm.MaPhieuMua = txtMaPhieu.Text;
                pm.NgayLap = dtpNgayLap.Value;
                pm.khachHang.TenKH = kh.TenKH;
                pm.khachHang.MaKH = kh.MaKH;
                pm.khachHang.DiaChi = kh.DiaChi;
                pm.khachHang.SoDT = kh.SoDT;
                xuly.them(pm);
                clear();
                hienthi();
            //}

        }

  

        private void cboTenKH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CKhachHang kh = xuly.DsKhachHang[cboTenKH.SelectedIndex];
            txtDiaChi.Text = kh.DiaChi;
            txtMaKH.Text = kh.MaKH;
            txtSoDT.Text = kh.SoDT;
        }

        private void cboTenLapTop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CLapTop lt = xuly.DsLapTop[cboTenLapTop.SelectedIndex];
            txtMaLapTop.Text = lt.MaLapTop;
            txtDonGia.Text = lt.DonGia.ToString();
            txtTenNCC.Text = lt.NhaCungCap.TenNCC;
        }


        private void btnXoaCTPM_Click_1(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgvCTPM.SelectedRows)
            {
                string malaptop = r.Cells[0].Value.ToString();
                foreach(CChiTietPhieuMua n in pm.DsChiTietPhieuMua)
                {
                    if (n.LapTop.MaLapTop == malaptop)
                    {
                        pm.DsChiTietPhieuMua.Remove(n);
                        hienThiChiTiet(pm);
                        return;
                    }
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
