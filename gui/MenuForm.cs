using DoAnLapTop.dao;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            cutomizeDesing();
           
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cutomizeDesing()
        {
            panelMenu.Visible= false;
            panelHoaDon.Visible= false;
        }
        //private void hideSubMenu()
        //{
        //    if(panelMenu.Visible==true)
        //        panelMenu.Visible=false;
        //    if(panelHoaDon.Visible==true)
        //        panelHoaDon.Visible = false;
        //}
     
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
             
                subMenu.Visible=true;
            }
            else subMenu.Visible=false;
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenu);
        }

    



        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHoaDon);
        }
        private void btnNCC_Click(object sender, EventArgs e)
        {
            openChildForm(new NhaCungCapForm());
        }

        private void btnLapTop_Click(object sender, EventArgs e)
        {
            openChildForm(new LapTopForm());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new KhachHangForm());
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new PhieuMuaForm());
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new LocHoaDonForm());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm) 
        {
            if(activeForm!=null)activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

     

     

        private void panelLogo_MouseClick(object sender, MouseEventArgs e)
        {
            this.panelChildForm.Controls.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn ghi File", "Ghi File", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TruyCapDuLieu.ghiFile("dslt.bin")) MessageBox.Show("Ghi thành công!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Ghi thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void testForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn đóng!!!", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
