using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe1_Nhom3 {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
            MyPublic.createConnection();
        }

        private void mnuThoat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void mnuGioithieu_Click(object sender, EventArgs e) {
            MessageBox.Show("Đây là ứng dụng giúp quản lý bài thi", "Giới thiệu");
        }

        private void mnuDangnhap_Click(object sender, EventArgs e) {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.Show();
        }


    }
}
