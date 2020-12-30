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
    public partial class frmDoiMK : Form {
        public frmDoiMK() {
            InitializeComponent();
        }

        private void frmDoiMK_Load(object sender, EventArgs e) {
            doimkBtn.Enabled = false;
            mkcuTextBox.PasswordChar = '*';
            mkmoiTextBox.PasswordChar = '*';
            xacnhanTextBox.PasswordChar = '*';
        }

        private void mkcuTextBox_TextChanged(object sender, EventArgs e) {
            if (mkcuTextBox.Text == "" || mkmoiTextBox.Text == "" || xacnhanTextBox.Text == "") {
                doimkBtn.Enabled = false;
            } else {
                doimkBtn.Enabled = true;
            }
        }

        private void mkmoiTextBox_TextChanged(object sender, EventArgs e) {
            if (mkcuTextBox.Text == "" || mkmoiTextBox.Text == "" || xacnhanTextBox.Text == "") {
                doimkBtn.Enabled = false;
            } else {
                doimkBtn.Enabled = true;
            }
        }

        private void xacnhanTextBox_TextChanged(object sender, EventArgs e) {
            if (mkcuTextBox.Text == "" || mkmoiTextBox.Text == "" || xacnhanTextBox.Text == "") {
                doimkBtn.Enabled = false;
            } else {
                doimkBtn.Enabled = true;
            }
        }

        private void doimkBtn_Click(object sender, EventArgs e) {
            if (mkmoiTextBox.Text != xacnhanTextBox.Text) {
                MessageBox.Show("Mật khẩu nhập lại không chính xác!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            if (MyPublic.connection.State == ConnectionState.Closed) {
                MyPublic.connection.Open();
            }

            string query = "SELECT 1 FROM NguoiSuDung WHERE TenTaiKhoan = @TAIKHOAN AND MatKhau = @MATKHAU";
            SqlCommand command = new SqlCommand(query, MyPublic.connection);
            command.Parameters.AddWithValue("@TAIKHOAN", MyPublic.tenTaiKhoan);
            command.Parameters.AddWithValue("@MATKHAU", mkcuTextBox.Text);

            SqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows) {
                MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông Báo", MessageBoxButtons.OK);
                reader.Close();
                return;
            }
            reader.Close();

            query = "UPDATE NguoiSuDung SET MatKhau = @MATKHAU WHERE TenTaiKhoan = @TAIKHOAN";
            command = new SqlCommand(query, MyPublic.connection);
            command.Parameters.AddWithValue("@MATKHAU", mkmoiTextBox.Text);
            command.Parameters.AddWithValue("@TAIKHOAN", MyPublic.tenTaiKhoan);
            command.ExecuteNonQuery();

            MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông Báo", MessageBoxButtons.OK);
            this.Close();
        }

        private void xacnhanTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                doimkBtn.PerformClick();
            }
        }

        private void dongBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
