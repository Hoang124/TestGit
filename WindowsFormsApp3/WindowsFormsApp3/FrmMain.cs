using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.FormCon;

namespace WindowsFormsApp3
{
    public partial class FrmMain : Form
    {
        private Form currentchildform;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void motrangcon(Form trangcon)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = trangcon;
            trangcon.TopLevel = false;
            trangcon.Dock = DockStyle.Fill;
            panelFormCon.Controls.Add(trangcon);
            panelFormCon.Tag = trangcon;
            trangcon.BringToFront();
            trangcon.Show();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            pnChay.Visible = false;
            pnChay.Height = btnBan.Height;
            pnChay_Danhmuc.Visible = false;
            pnChay_Kho.Visible = false;
            pnChay_SP.Visible = false;
            pnbtnKho.Height = 50;
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            if (pnChay.Visible == false) pnChay.Visible = true;
            pnChay.Top = btnBan.Top;

            pnChay_Danhmuc.Visible = false;
            pnChay_Kho.Visible = false;
            pnChay_SP.Visible = false;

            if (pnbtnKho.Height == 151) pnbtnKho.Height = 50;
            motrangcon(new FrmBanHang());
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (pnChay.Visible == false) pnChay.Visible = true;
            pnChay.Top = btnNhap.Top;

            pnChay_Danhmuc.Visible = false;
            pnChay_Kho.Visible = false;
            pnChay_SP.Visible = false;
            if (pnbtnKho.Height == 151) pnbtnKho.Height = 50;
            motrangcon(new FrmTaiKhoan());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            if (pnChay.Visible == false) pnChay.Visible = true;
            pnChay.Top = btnTaiKhoan.Top;

            pnChay_Danhmuc.Visible = false;
            pnChay_Kho.Visible = false;
            pnChay_SP.Visible = false;
            if (pnbtnKho.Height == 151) pnbtnKho.Height = 50;
            motrangcon(new FrmDonHang());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (pnChay.Visible == false) pnChay.Visible = true;
            pnChay.Top = btnThongKe.Top;

            pnChay_Danhmuc.Visible = false;
            pnChay_Kho.Visible = false;
            pnChay_SP.Visible = false;
            if (pnbtnKho.Height == 151) pnbtnKho.Height = 50;
            motrangcon(new FrmThongKe());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (pnChay.Visible == false) pnChay.Visible = true;
            pnChay.Top = btnKhachHang.Top;

            pnChay_Danhmuc.Visible = false;
            pnChay_Kho.Visible = false;
            pnChay_SP.Visible = false;
            if (pnbtnKho.Height == 151) pnbtnKho.Height = 50;
            motrangcon(new FrmKhachHang());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            if (pnChay_Kho.Visible == false) pnChay_Kho.Visible = true;
            pnChay.Visible = false;
            pnChay_Danhmuc.Visible = false;
            pnChay_SP.Visible = false;

            if (pnbtnKho.Height == 151) pnbtnKho.Height = 50;
            else pnbtnKho.Height = 151;

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            if (pnChay_SP.Visible == false) pnChay_SP.Visible = true;
            pnChay.Visible = false;
            pnChay_Danhmuc.Visible = false;
            pnChay_Kho.Visible = false;
            motrangcon(new FrmSanPham());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (pnChay_Danhmuc.Visible == false) pnChay_Danhmuc.Visible = true;
            pnChay.Visible = false;
            pnChay_SP.Visible = false;
            pnChay_Kho.Visible = false;
            motrangcon(new FrmDanhMuc());

        }

        private void panelFormCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmLogin().Show();
        }
    }
}
