using DoAnLapTop.bus;
using DoAnLapTop.dao;
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
    public partial class KhachHangForm : Form
    {
        private XuLyKhachHang xulyKH;
        public KhachHangForm()
        {
            InitializeComponent();
            xulyKH = new XuLyKhachHang();
        }
        private void hienthi(List<CKhachHang> dskh)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dskh;
            dgvKH.DataSource = bs;
        }
        private void clear()
        {
            txtDiaChi.Text = "";
            txtMaKH.Text = "";
            txtSDT.Text = "";
            txtTenKH.Text = "";
            txtMaKH.Focus();
            //dgvKH.ClearSelection();
        }
        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            hienthi(xulyKH.DsKhachHang);
            clear();

        }
        private bool ktSo(string soDt)
        {
         
            if (soDt[0] == '0'&& soDt.Length == 10)
            {
                for (int i = 1; i <= soDt.Length; i++)
                {
                    if (soDt[i] >= '0' && soDt[i] <= '9')  return true;
                }
            }
           return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktSo(txtSDT.Text) == false)
            { 
                MessageBox.Show("Số điện thoại sai định dạng");
                txtSDT.Focus();
            }
            else if (txtMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
            }
            else if (txtTenKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hoặc số điện thoại nhập sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
            }
            else
            {
                if (xulyKH.them(new CKhachHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text)) == true)
                {
                    MessageBox.Show("Đã thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi(xulyKH.DsKhachHang);
                    clear();
                }
                else
                {
                    MessageBox.Show("Mã đang nhập đã tồn tại!!! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKH.Focus();

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "") MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn có chắc là muốn xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (xulyKH.xoa(txtMaKH.Text) == true)
                {
                    MessageBox.Show("Đã xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi(xulyKH.DsKhachHang);
                    clear();
                }
                else MessageBox.Show("Mã khách hàng bạn muốn xóa không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    

        private void btnSua_Click(object sender, EventArgs e)
        {
            CKhachHang kh = new CKhachHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text);
            if (ktSo(txtSDT.Text) == false)
            {
                MessageBox.Show("Số điện thoại sai định dạng");
                txtSDT.Focus();
            }
            else if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "") MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn có chắc là muốn sửa!!!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (xulyKH.sua(kh) == true)
                {
                    MessageBox.Show("Đã sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi(xulyKH.DsKhachHang);
                    clear();
                }
                else MessageBox.Show("Mã nhà cung cấp bạn muốn sửa không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvKH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvKH.Rows[e.RowIndex];
            if (dgvKH.SelectedCells.Count > 0)
            {
                txtMaKH.Text = r.Cells[0].Value.ToString();
                txtTenKH.Text = r.Cells[1].Value.ToString();
                txtDiaChi.Text = r.Cells[3].Value.ToString();
                txtSDT.Text = r.Cells[2].Value.ToString();
            }
        }


    }
}