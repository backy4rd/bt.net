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
    public partial class frmMon : Form
    {
        private string action;
        private DataTable dsMonHoc;

        public frmMon()
        {
            InitializeComponent();
        }

        private void frmMon_Load(object sender, EventArgs e)
        {
            dsMHGridView.AllowUserToAddRows = false;
            dsMHGridView.AllowUserToDeleteRows = false;
            mamonTextBox.MaxLength = 6;
            tenmonTextBox.MaxLength = 60;
            tinchiTextBox.MaxLength = 10;

            string query = "SELECT MaMon, TenMon, SoTinChi FROM MonHoc";
            DataSet dataSet = new DataSet();
            MyPublic.OpenData(query, dataSet, "MonHoc");
            dsMonHoc = dataSet.Tables["MonHoc"];

            dsMHGridView.DataSource = dataSet.Tables["MonHoc"];
            dsMHGridView.Columns[0].Width = 95;
            dsMHGridView.Columns[0].HeaderText = "Mã Môn";
            dsMHGridView.Columns[1].Width = 250;
            dsMHGridView.Columns[1].HeaderText = "Tên Môn";
            dsMHGridView.Columns[2].Width = 100;
            dsMHGridView.Columns[2].HeaderText = "Số Tín Chỉ";

            if (MyPublic.quyenSD == "AdTinh" || MyPublic.quyenSD == "AdTruong")
            {
                themBtn.Enabled = true;
                suaBtn.Enabled = true;
                xoaBtn.Enabled = true;
            }
            else
            {
                themBtn.Enabled = false;
                suaBtn.Enabled = false;
                xoaBtn.Enabled = false;
            }
            dsMHGridView.Enabled = true;
            mamonTextBox.Enabled = false;
            tenmonTextBox.Enabled = false;
            tinchiTextBox.Enabled = false;

            luuBtn.Enabled = false;
            khongluuBtn.Enabled = false;

            displayRowAt(0);
        }

        private void dsMHGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayRowAt(dsMHGridView.CurrentRow.Index);
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            action = "them";
            mamonTextBox.Clear();
            tenmonTextBox.Clear();
            tinchiTextBox.Clear();

            toggleEdit(true);

            mamonTextBox.Select();
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            action = "sua";

            toggleEdit(true);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            int currentRow = dsMHGridView.CurrentRow.Index;

            DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa môn học này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No) return;

            if (MyPublic.connection.State == ConnectionState.Closed)
            {
                MyPublic.connection.Open();
            }
            if (MyPublic.tonTaiKhoaChinh("MaMon", mamonTextBox.Text, "TheoDoiBaiThi"))
            {
                MessageBox.Show("Bạn phải xóa các bài thi có liên quan tới môn học này trước!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string query = "DELETE FROM MonHoc WHERE MaMon=@MAMON";
            SqlCommand command = new SqlCommand(query, MyPublic.connection);
            command.Parameters.AddWithValue("@MAMON", dsMonHoc.Rows[currentRow]["MaMon"]);
            command.ExecuteNonQuery();

            dsMonHoc.Rows.RemoveAt(currentRow);
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (mamonTextBox.Text == "" || tenmonTextBox.Text == "" || tinchiTextBox.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int sotinchi;
            if (!int.TryParse(tinchiTextBox.Text, out sotinchi))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MyPublic.connection.State == ConnectionState.Closed)
            {
                MyPublic.connection.Open();
            }

            string query;
            SqlCommand command;
            int currentRow = dsMHGridView.CurrentRow.Index;


            if (MyPublic.tonTaiKhoaChinh("MaMon", mamonTextBox.Text, "MonHoc") && action == "them")
            {

                MessageBox.Show("Môn học đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (action == "them")
            {
                query = "INSERT INTO MonHoc VALUES(@MAMON, @TENMON, @SOTINCHI)";
                command = new SqlCommand(query, MyPublic.connection);
                command.Parameters.AddWithValue("@MAMON", mamonTextBox.Text);
                command.Parameters.AddWithValue("@TENMON", tenmonTextBox.Text);
                command.Parameters.AddWithValue("@SOTINCHI", sotinchi);

                dsMonHoc.Rows.Add(mamonTextBox.Text, tenmonTextBox.Text, sotinchi);
            }
            else
            {
                query = "UPDATE MonHoc SET TenMon=@TENMON, SoTinChi=@SOTINCHI WHERE MaMon=@MAMON";
                command = new SqlCommand(query, MyPublic.connection);
                command.Parameters.AddWithValue("@TENMON", tenmonTextBox.Text);
                command.Parameters.AddWithValue("@SOTINCHI", sotinchi);
                command.Parameters.AddWithValue("@MAMON", mamonTextBox.Text);

                dsMonHoc.Rows[currentRow]["MaMon"] = mamonTextBox.Text;
                dsMonHoc.Rows[currentRow]["TenMon"] = tenmonTextBox.Text;
                dsMonHoc.Rows[currentRow]["SoTinChi"] = sotinchi;
            }

            command.ExecuteNonQuery();

            toggleEdit(false);
        }

        private void khongluuBtn_Click(object sender, EventArgs e)
        {
            displayRowAt(dsMHGridView.CurrentRow.Index);
            toggleEdit(false);
        }

        private void dongBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayRowAt(int index)
        {
            DataGridViewRow row = dsMHGridView.Rows[index];
            mamonTextBox.Text = row.Cells["MaMon"].Value.ToString();
            tenmonTextBox.Text = row.Cells["TenMon"].Value.ToString();
            tinchiTextBox.Text = row.Cells["SoTinChi"].Value.ToString();
        }

        private void toggleEdit(bool flag)
        {
            if (flag)
            {
                dsMHGridView.Enabled = false;

                themBtn.Enabled = false;
                suaBtn.Enabled = false;
                xoaBtn.Enabled = false;

                if (action == "them") mamonTextBox.Enabled = true;
                tenmonTextBox.Enabled = true;
                tinchiTextBox.Enabled = true;

                luuBtn.Enabled = true;
                khongluuBtn.Enabled = true;
            }
            else
            {
                dsMHGridView.Enabled = true;

                themBtn.Enabled = true;
                suaBtn.Enabled = true;
                xoaBtn.Enabled = true;

                if (action == "them") mamonTextBox.Enabled = false;
                tenmonTextBox.Enabled = false;
                tinchiTextBox.Enabled = false;

                luuBtn.Enabled = false;
                khongluuBtn.Enabled = false;
            }
        }
    }
}
