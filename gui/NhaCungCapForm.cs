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
    public partial class NhaCungCapForm : Form
    {
        private XuLyNhaCungCap xulyNCC;
        public NhaCungCapForm()
        {
            InitializeComponent();
            xulyNCC = new XuLyNhaCungCap();
        }
        private void showDsNCC(List<CNhaCungCap> dsncc)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsncc;
            dgvNCC.DataSource = bs;
        }


        private void clearNCC()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
            txtMaNCC.Focus();
            //dgvNCC.ClearSelection();
        }



        private void btnFixNCC_Click(object sender, EventArgs e)
        {
        
            CNhaCungCap ncc = new CNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtSoDT.Text, txtDiaChi.Text);
            if (ktSo(txtSoDT.Text) == false)
            {
                MessageBox.Show("Số điện thoại sai định dạng");
                txtSoDT.Focus();
            }
            else if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtSoDT.Text == "" || txtDiaChi.Text == "") MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn có chắc là muốn sửa!!!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (xulyNCC.sua(ncc) == true)
                {
                    MessageBox.Show("Đã sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showDsNCC(xulyNCC.DsNhaCungCap);
                    clearNCC();
                }
                else MessageBox.Show("Mã nhà cung cấp bạn muốn sửa không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ktSo(string soDt)
        {

            if (soDt[0] == '0' && soDt.Length == 10)
            {
                for (int i = 1; i <= soDt.Length; i++)
                {
                    if (soDt[i] >= '0' && soDt[i] <= '9') return true;
                }
            }
            return false;
        }
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            if (ktSo(txtSoDT.Text) == false)
            {
                MessageBox.Show("Số điện thoại sai định dạng");
                txtSoDT.Focus();
            }
           else if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
            }
            else if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
            }
            else if (txtSoDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDT.Focus(); ;
            }
            else
            {
                if (xulyNCC.them(new CNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtSoDT.Text, txtDiaChi.Text)) == true)
                {
                    MessageBox.Show("Đã thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showDsNCC(xulyNCC.DsNhaCungCap);
                    clearNCC();
                }
                else
                {
                    MessageBox.Show("Mã đang nhập đã tồn tại!!! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNCC.Focus();
                }
            }
        }
        private void btnDeleNCC_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtSoDT.Text == "" || txtDiaChi.Text == "") MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn có chắc là xóa!!!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (xulyNCC.xoa(txtMaNCC.Text) == true)
                {
                    MessageBox.Show("Đã xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showDsNCC(xulyNCC.DsNhaCungCap);
                    clearNCC();
                }
                else MessageBox.Show("Mã nhà cung cấp bạn muốn xóa không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NhaCungCapForm_Load(object sender, EventArgs e)
        {
            showDsNCC(xulyNCC.DsNhaCungCap);
            clearNCC();
        }




        private void dgvNCC_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvNCC.Rows[e.RowIndex];
            if (dgvNCC.SelectedCells.Count > 0)
            {
                txtMaNCC.Text = r.Cells[0].Value.ToString();
                txtTenNCC.Text = r.Cells[1].Value.ToString();
                txtSoDT.Text = r.Cells[2].Value.ToString();
                txtDiaChi.Text = r.Cells[3].Value.ToString();
            }
        }
    }
}
