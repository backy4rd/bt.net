using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe1_Nhom3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MyPublic.createConnection();
            mnuDulieu.Enabled = false;
            mnuTienich.Enabled = false;
            mnuDoimatkhau.Enabled = false;
            mnuThoatdangnhap.Enabled = false;
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuGioithieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là ứng dụng giúp quản lý bài thi", "Giới thiệu");
        }

        private void mnuDangnhap_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap(this);
            dangnhap.Show();
        }

        private void mnuDoimatkhau_Click(object sender, EventArgs e)
        {
            frmDoiMK doimk = new frmDoiMK();
            doimk.Show();
        }

        private void mnuThoatdangnhap_Click(object sender, EventArgs e)
        {
            MyPublic.tenTaiKhoan = "";
            MyPublic.quyenSD = "";
            MyPublic.maTT = "";

            mnuDulieu.Enabled = false;
            mnuTienich.Enabled = false;
            mnuDoimatkhau.Enabled = false;
            mnuThoatdangnhap.Enabled = false;
            mnuDangnhap.Enabled = true;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap(this);
            dangnhap.Show();
        }

        private void mnuTaikhoan_Click(object sender, EventArgs e)
        {
            frmTaikhoan taikhoan = new frmTaikhoan();
            taikhoan.Show();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLop lop = new frmLop();
            lop.Show();
        }

        private void mnuMon_Click(object sender, EventArgs e)
        {
            frmMon mon = new frmMon();
            mon.Show();
        }

        private void mnuBaithi_Click(object sender, EventArgs e)
        {
            frmBaithi baithi = new frmBaithi();
            baithi.Show();
        }

        private void mnuTrungtam_Click(object sender, EventArgs e)
        {
            frmTrungtam trungtam = new frmTrungtam();
            trungtam.Show();
        }

        private void mnuBaithitheomon_Click(object sender, EventArgs e)
        {
            frmBaithitheomon baithitheomon = new frmBaithitheomon();
            baithitheomon.Show();
        }

        private void mnuBaithitheolop_Click(object sender, EventArgs e)
        {
            frmBaithitheolophoc baithitheolop = new frmBaithitheolophoc();
            baithitheolop.Show();
        }
    }
}
