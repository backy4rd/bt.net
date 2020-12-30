using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe1_Nhom3 {
    public partial class frmDangNhap : Form {
        public frmDangNhap() {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e) {
            dangnhapBtn.Enabled = false;
        }

        private void taikhoanTextBox_TextChanged(object sender, EventArgs e) {
            if (taikhoanTextBox.Text == "" || matkhauTextBox.Text == "") {
                dangnhapBtn.Enabled = false;
            } else {
                dangnhapBtn.Enabled = true;

            }
        }

        private void matkhauTextBox_TextChanged(object sender, EventArgs e) {
            if (taikhoanTextBox.Text == "" || matkhauTextBox.Text == "") {
                dangnhapBtn.Enabled = false;
            } else {
                dangnhapBtn.Enabled = true;
            }
        }

        private void dangnhapBtn_Click(object sender, EventArgs e) {
            if (MyPublic.connection.State == ConnectionState.Closed) {
                MyPublic.connection.Open();
            }
            string query = "SELECT TenTaiKhoan, QuyenSD, MaTT FROM NguoiSuDung WHERE TenTaiKhoan = @TAIKHOAN AND MatKhau = @MATKHAU";
            SqlCommand command = new SqlCommand(query, MyPublic.connection);
            command.Parameters.AddWithValue("@TAIKHOAN", taikhoanTextBox.Text);
            command.Parameters.AddWithValue("@MATKHAU", matkhauTextBox.Text);

            SqlDataReader reader = command.ExecuteReader();

            // handle login fail
            if (!reader.HasRows) {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            reader.Read(); 

            MyPublic.tenTaiKhoan = reader.GetString(0);
            MyPublic.quyenSD = reader.GetString(1);
            MyPublic.maTT = reader.GetString(2);
            MyPublic.connection.Close();
        }

        private void dongBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
