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
    public partial class LapTopForm : Form
    {
        private XuLyLapTop xuly;
        public LapTopForm()
        {
            InitializeComponent();
            xuly=new XuLyLapTop();
        }
        private void hienthiLapTop(List<CLapTop> dslt)
        {
            BindingSource bs=new BindingSource();
            bs.DataSource= dslt;
            dgvLapTop.DataSource= bs;
 
        }
        private void hienthiNCC(List<CNhaCungCap> dsncc)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsncc;
            cboNCC.DataSource = bs;
        }
        private void clear()
        {
            txtDonGia.Text = "";
            txtMaLapTop.Text = "";
            txtTenLapTop.Text = "";
            cboNCC.SelectedIndex = 0;
            
            txtMaLapTop.Focus();
        }

        private void btnThemLapTop_Click(object sender, EventArgs e)
        {
                CNhaCungCap ncc= xuly.DsNhaCungCap[cboNCC.SelectedIndex];
            if (txtMaLapTop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã laptop", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLapTop.Focus();
            }
            else if (txtTenLapTop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên laptop", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLapTop.Focus();
            }
            else if (txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
            }
            else
            {
                try
                {
                    if (xuly.them(new CLapTop(txtMaLapTop.Text, txtTenLapTop.Text, double.Parse(txtDonGia.Text.Trim()), ncc)) == true)
                    {
                        MessageBox.Show("Đã thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienthiLapTop(xuly.DsLapTop);
                        clear();
                    }

                    else
                    {
                        MessageBox.Show("Mã đang nhập đã tồn tại!!! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLapTop.Focus();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Đơn giá bạn nhập không hợp lệ!!! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDonGia.Focus();
                }
              
            }
        }

        private void btnFixLapTop_Click(object sender, EventArgs e)
        {
            CNhaCungCap ncc = xuly.DsNhaCungCap[cboNCC.SelectedIndex];

            if (txtMaLapTop.Text == "" || txtTenLapTop.Text == "" || txtDonGia.Text == "") MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn có chắc là sửa!!!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (xuly.sua(new CLapTop(txtMaLapTop.Text, txtTenLapTop.Text, double.Parse(txtDonGia.Text.Trim()), ncc)) == true)
                    {
                        MessageBox.Show("Đã sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienthiLapTop(xuly.DsLapTop);
                        clear();
                    }
                    else MessageBox.Show("Mã Lap Top bạn muốn sửa không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {


                    MessageBox.Show("Đơn giá bạn sửa không hợp lệ!!! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDonGia.Focus();
                }
            
            }
        }

        private void btnDeleLapTop_Click(object sender, EventArgs e)
        {
           if(txtMaLapTop.Text=="" || txtTenLapTop.Text=="" || txtDonGia.Text=="") MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn có chắc là xóa!!!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (xuly.xoa(txtMaLapTop.Text) == true)
                {
                    MessageBox.Show("Đã xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthiLapTop(xuly.DsLapTop);
                    clear();
                }
                else MessageBox.Show("Mã Lap Top bạn muốn xóa không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LapTop_Load(object sender, EventArgs e)
        {
            hienthiLapTop(xuly.DsLapTop);
            hienthiNCC(xuly.DsNhaCungCap);
        }

        private void dgvLapTop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvLapTop.Rows[e.RowIndex];
            if (dgvLapTop.SelectedCells.Count > 0)
            {
                txtMaLapTop.Text = r.Cells[0].Value.ToString();
                txtTenLapTop.Text = r.Cells[1].Value.ToString();
                txtDonGia.Text = r.Cells[2].Value.ToString();
                cboNCC.Text = r.Cells[3].Value.ToString();
            }
        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
