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

namespace ChuDe1_Nhom3
{
    public partial class frmTrungtam : Form
    {
        string action;
        DataTable dtTrungtam;

        public frmTrungtam()
        {
            InitializeComponent();
        }

        private void frmTrungtam_Load(object sender, EventArgs e)
        {
            dgvTrungtam.AllowUserToAddRows = false;
            dgvTrungtam.AllowUserToDeleteRows = false;
            txtMatt.MaxLength = 6;
            txtTentt.MaxLength = 60;
            txtTinh.MaxLength = 30;

            string query = "SELECT MaTT, TenTT, Tinh FROM TrungTam";
            DataSet dataSet = new DataSet();
            MyPublic.OpenData(query, dataSet, "TrungTam");
            dtTrungtam = dataSet.Tables["TrungTam"];

            dgvTrungtam.DataSource = dataSet.Tables["TrungTam"];
            dgvTrungtam.Columns[0].Width = 100;
            dgvTrungtam.Columns[0].HeaderText = "Mã trung tâm";
            dgvTrungtam.Columns[1].Width = 195;
            dgvTrungtam.Columns[1].HeaderText = "Tên trung tâm";
            dgvTrungtam.Columns[2].Width = 105;
            dgvTrungtam.Columns[2].HeaderText = "Tỉnh";

            if (MyPublic.quyenSD == "AdTinh" || MyPublic.quyenSD == "AdTruong")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            dgvTrungtam.Enabled = true;
            txtMatt.Enabled = false;
            txtTentt.Enabled = false;
            txtTinh.Enabled = false;

            btnLuu.Enabled = false;
            btnKhongluu.Enabled = false;

            displayRowAt(0);
        }

        private void dgvTrungtam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayRowAt(dgvTrungtam.CurrentRow.Index);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "them";
            txtMatt.Clear();
            txtTentt.Clear();
            txtTinh.Clear();

            toggleEdit(true);

            txtMatt.Select();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            action = "sua";

            toggleEdit(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int currentRow = dgvTrungtam.CurrentRow.Index;

            DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa trung tâm này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No) return;

            if (MyPublic.connection.State == ConnectionState.Closed)
            {
                MyPublic.connection.Open();
            }
            if (MyPublic.tonTaiKhoaChinh("MaTT", txtMatt.Text, "NguoiSuDung") || MyPublic.tonTaiKhoaChinh("MaTT", txtMatt.Text, "LopHoc"))
            {
                MessageBox.Show("Bạn phải xóa các người sử dụng và lớp học có liên quan tới trung tâm này trước!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string query = "DELETE FROM TrungTam WHERE MaTT=@MATT";
            SqlCommand command = new SqlCommand(query, MyPublic.connection);
            command.Parameters.AddWithValue("@MATT", dtTrungtam.Rows[currentRow][0]);

            command.ExecuteNonQuery();
            dtTrungtam.Rows.RemoveAt(currentRow);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatt.Text == "" || txtTentt.Text == "" || txtTinh.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MyPublic.connection.State == ConnectionState.Closed)
            {
                MyPublic.connection.Open();
            }

            string query;
            SqlCommand command;
            int currentRow = dgvTrungtam.CurrentRow.Index;


            if (MyPublic.tonTaiKhoaChinh("MaTT", txtMatt.Text, "TrungTam") && action == "them")
            {

                MessageBox.Show("Trung tâm đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (action == "them")
            {
                query = "INSERT INTO TrungTam VALUES(@MATT, @TENTT, @TINH)";
                command = new SqlCommand(query, MyPublic.connection);
                command.Parameters.AddWithValue("@MATT", txtMatt.Text);
                command.Parameters.AddWithValue("@TENTT", txtTentt.Text);
                command.Parameters.AddWithValue("@TINH", txtTinh.Text);

                dtTrungtam.Rows.Add(txtMatt.Text, txtTentt.Text, txtTinh.Text);
            }
            else
            {
                query = "UPDATE TrungTam SET TenTT=@TENTT, Tinh=@TINH WHERE MaTT=@MATT";
                command = new SqlCommand(query, MyPublic.connection);
                command.Parameters.AddWithValue("@TENTT", txtTentt.Text);
                command.Parameters.AddWithValue("@TINH", txtTinh.Text);
                command.Parameters.AddWithValue("@MATT", txtMatt.Text);

                dtTrungtam.Rows[currentRow]["MaTT"] = txtMatt.Text;
                dtTrungtam.Rows[currentRow]["TenTT"] = txtTentt.Text;
                dtTrungtam.Rows[currentRow]["Tinh"] = txtTinh.Text;
            }

            command.ExecuteNonQuery();

            toggleEdit(false);
        }

        private void btnKhongluu_Click(object sender, EventArgs e)
        {
            displayRowAt(dgvTrungtam.CurrentRow.Index);
            toggleEdit(false);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayRowAt(int index)
        {
            DataGridViewRow row = dgvTrungtam.Rows[index];
            txtMatt.Text = row.Cells["MaTT"].Value.ToString();
            txtTentt.Text = row.Cells["TenTT"].Value.ToString();
            txtTinh.Text = row.Cells["Tinh"].Value.ToString();
        }

        private void toggleEdit(bool flag)
        {
            dgvTrungtam.Enabled = !flag;

            btnThem.Enabled = !flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;

            if (action == "them") txtMatt.Enabled = flag;
            txtTentt.Enabled = flag;
            txtTinh.Enabled = flag;

            btnLuu.Enabled = flag;
            btnKhongluu.Enabled = flag;

        }
    }
}
