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
    public partial class frmBaithi : Form
    {
        string action;
        DataTable dtBaithi;

        public frmBaithi()
        {
            InitializeComponent();
        }

        private void frmBaithi_Load(object sender, EventArgs e)
        {
            dtpNgaythi.Format = DateTimePickerFormat.Custom;
            dtpNgaythi.CustomFormat = "dd-MM-yyyy";
            dtpNgaynhan.Format = DateTimePickerFormat.Custom;
            dtpNgaynhan.CustomFormat = "dd-MM-yyyy";
            dtpHannop.Format = DateTimePickerFormat.Custom;
            dtpHannop.CustomFormat = "dd-MM-yyyy";

            dgvBaithi.AllowUserToAddRows = false;
            dgvBaithi.AllowUserToDeleteRows = false;
            txtNamhoc.MaxLength = 10;
            txtLanthi.MaxLength = 10;
            txtSobaithi.MaxLength = 10;

            string select = "Select MaLop, TenLop From LopHoc";
            DataSet dataset = new DataSet();
            MyPublic.OpenData(select, dataset, "LopHoc");
            cbLophoc.DataSource = dataset.Tables["LopHoc"];
            cbLophoc.DisplayMember = "TenLop";
            cbLophoc.ValueMember = "MaLop";

            select = "Select MaMon, TenMon From MonHoc";
            dataset = new DataSet();
            MyPublic.OpenData(select, dataset, "MonHoc");
            cbMonhoc.DataSource = dataset.Tables["MonHoc"];
            cbMonhoc.DisplayMember = "TenMon";
            cbMonhoc.ValueMember = "MaMon";

            select = "Select * From TheoDoiBaiThi";
            dataset = new DataSet();
            MyPublic.OpenData(select, dataset, "TheoDoiBaiThi");

            dtBaithi = dataset.Tables["TheoDoiBaiThi"];
            dgvBaithi.DataSource = dataset.Tables["TheoDoiBaiThi"];
            dgvBaithi.Width = 723;
            dgvBaithi.Columns[0].Width = 70;
            dgvBaithi.Columns[0].HeaderText = "Mã Môn";
            dgvBaithi.Columns[1].Width = 70;
            dgvBaithi.Columns[1].HeaderText = "Mã Lớp";
            dgvBaithi.Columns[2].Width = 65;
            dgvBaithi.Columns[2].HeaderText = "Lần thi";
            dgvBaithi.Columns[3].Width = 70;
            dgvBaithi.Columns[3].HeaderText = "Học Kỳ";
            dgvBaithi.Columns[4].Width = 80;
            dgvBaithi.Columns[4].HeaderText = "Năm học";
            dgvBaithi.Columns[5].Width = 80;
            dgvBaithi.Columns[5].HeaderText = "Ngày thi";
            dgvBaithi.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBaithi.Columns[6].Width = 80;
            dgvBaithi.Columns[6].HeaderText = "Số bài thi";
            dgvBaithi.Columns[7].Width = 85;
            dgvBaithi.Columns[7].HeaderText = "Ngày nhận";
            dgvBaithi.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBaithi.Columns[8].Width = 80;
            dgvBaithi.Columns[8].HeaderText = "Hạn nộp";
            dgvBaithi.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";

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
            dgvBaithi.Enabled = true;

            cbMonhoc.Enabled = false;
            cbLophoc.Enabled = false;
            txtLanthi.Enabled = false;
            rbtnHocky1.Enabled = false;
            rbtnHocky2.Enabled = false;
            txtNamhoc.Enabled = false;
            dtpNgaythi.Enabled = false;
            txtSobaithi.Enabled = false;
            dtpNgaynhan.Enabled = false;
            dtpHannop.Enabled = false;

            btnLuu.Enabled = false;
            btnKhongluu.Enabled = false;

            displayRowAt(0);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "them";
            cbLophoc.SelectedIndex = -1;
            cbMonhoc.SelectedIndex = -1;
            rbtnHocky1.Checked = false;
            rbtnHocky2.Checked = false;
            txtLanthi.Clear();
            txtNamhoc.Clear();
            txtSobaithi.Clear();
            dtpNgaythi.Value = dtpNgaythi.MinDate;
            dtpNgaynhan.Value = dtpNgaynhan.MinDate;
            dtpHannop.Value = dtpHannop.MinDate;

            toggleEdit(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            action = "sua";

            toggleEdit(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int currentRow = dgvBaithi.CurrentRow.Index;

            DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa bài thi này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No) return;

            if (MyPublic.connection.State == ConnectionState.Closed)
            {
                MyPublic.connection.Open();
            }
            string query = "DELETE FROM TheoDoiBaithi WHERE MaLop=@MALOP And MaMon=@MAMON And LanThi=@LANTHI And HocKy=@HOCKY And NamHoc=@NAMHOC";
            SqlCommand command = new SqlCommand(query, MyPublic.connection);
            command.Parameters.AddWithValue("@MAMON", cbMonhoc.SelectedValue);
            command.Parameters.AddWithValue("@MALOP", cbLophoc.SelectedValue);
            command.Parameters.AddWithValue("@LANTHI", txtLanthi.Text);
            command.Parameters.AddWithValue("@HOCKY", rbtnHocky1.Checked ? "1" : "2");
            command.Parameters.AddWithValue("@NAMHOC", txtNamhoc.Text);

            command.ExecuteNonQuery();
            dtBaithi.Rows.RemoveAt(currentRow);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (
                cbLophoc.SelectedIndex == -1 ||
                cbMonhoc.SelectedIndex == -1 ||
                txtNamhoc.Text == "" ||
                txtLanthi.Text == "" ||
                (rbtnHocky1.Checked == false && rbtnHocky2.Checked == false) ||
                txtSobaithi.Text == ""
            )
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
            int currentRow = dgvBaithi.CurrentRow.Index;
            string hocky = rbtnHocky1.Checked ? "1" : "2";

            if (action == "them")
            {
                query = "SELECT 1 FROM TheoDoiBaiThi WHERE MaLop=@MALOP And MaMon=@MAMON And LanThi=@LANTHI And HocKy=@HOCKY And NamHoc=@NAMHOC";
                command = new SqlCommand(query, MyPublic.connection);
                command.Parameters.AddWithValue("@MAMON", cbMonhoc.SelectedValue);
                command.Parameters.AddWithValue("@MALOP", cbLophoc.SelectedValue);
                command.Parameters.AddWithValue("@LANTHI", txtLanthi.Text);
                command.Parameters.AddWithValue("@HOCKY", hocky);
                command.Parameters.AddWithValue("@NAMHOC", txtNamhoc.Text);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Bài thi đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                    reader.Close();
                    return;
                }
                reader.Close();
            }

            if (action == "them")
            {
                query = "INSERT INTO TheoDoiBaiThi VALUES(@MAMON, @MALOP, @LANTHI, @HOCKY, @NAMHOC, @NGAYTHI, @SOBAITHI, @NGAYNHAN, @HANNOP)";
                command = new SqlCommand(query, MyPublic.connection);
                command.Parameters.AddWithValue("@MAMON", cbMonhoc.SelectedValue);
                command.Parameters.AddWithValue("@MALOP", cbLophoc.SelectedValue);
                command.Parameters.AddWithValue("@LANTHI", txtLanthi.Text);
                command.Parameters.AddWithValue("@HOCKY", hocky);
                command.Parameters.AddWithValue("@NAMHOC", txtNamhoc.Text);
                command.Parameters.AddWithValue("@NGAYTHI", dtpNgaythi.Value);
                command.Parameters.AddWithValue("@SOBAITHI", txtSobaithi.Text);
                command.Parameters.AddWithValue("@NGAYNHAN", dtpNgaynhan.Value);
                command.Parameters.AddWithValue("@HANNOP", dtpHannop.Value);

                dtBaithi.Rows.Add(cbMonhoc.SelectedValue, cbLophoc.SelectedValue, txtLanthi.Text, hocky, txtNamhoc.Text, dtpNgaythi.Value, txtSobaithi.Text, dtpNgaynhan.Value, dtpHannop.Value);
            }
            else
            {
                query = "UPDATE TheoDoiBaiThi SET NgayThi=@NGAYTHI, SoBai=@SOBAITHI, NgayNhan=@NGAYNHAN, HanNop=@HANNOP WHERE MaLop=@MALOP And MaMon=@MAMON And LanThi=@LANTHI And HocKy=@HOCKY And NamHoc=@NAMHOC";
                command = new SqlCommand(query, MyPublic.connection);
                command.Parameters.AddWithValue("@MALOP", cbLophoc.SelectedValue);
                command.Parameters.AddWithValue("@MAMON", cbMonhoc.SelectedValue);
                command.Parameters.AddWithValue("@LANTHI", txtLanthi.Text);
                command.Parameters.AddWithValue("@HOCKY", hocky);
                command.Parameters.AddWithValue("@NAMHOC", txtNamhoc.Text);
                command.Parameters.AddWithValue("@NGAYTHI", dtpNgaythi.Value);
                command.Parameters.AddWithValue("@SOBAITHI", txtSobaithi.Text);
                command.Parameters.AddWithValue("@NGAYNHAN", dtpNgaynhan.Value);
                command.Parameters.AddWithValue("@HANNOP", dtpHannop.Value);

                dtBaithi.Rows[currentRow]["NgayThi"] = dtpNgaythi.Value;
                dtBaithi.Rows[currentRow]["SoBai"] = txtSobaithi.Text;
                dtBaithi.Rows[currentRow]["NgayNhan"] = dtpNgaynhan.Value;
                dtBaithi.Rows[currentRow]["HanNop"] = dtpHannop.Value;
            }

            command.ExecuteNonQuery();

            toggleEdit(false);
        }

        private void btnKhongluu_Click(object sender, EventArgs e)
        {
            displayRowAt(dgvBaithi.CurrentRow.Index);
            toggleEdit(false);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBaithi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayRowAt(dgvBaithi.CurrentRow.Index);
        }

        private void allowNumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void displayRowAt(int index)
        {
            DataGridViewRow row = dgvBaithi.Rows[index];
            cbMonhoc.SelectedValue = row.Cells["MaMon"].Value.ToString();
            cbLophoc.SelectedValue = row.Cells["MaLop"].Value.ToString();
            txtNamhoc.Text = row.Cells["NamHoc"].Value.ToString();
            txtSobaithi.Text = row.Cells["SoBai"].Value.ToString();
            txtLanthi.Text = row.Cells["LanThi"].Value.ToString();

            if (row.Cells["HocKy"].Value.ToString() == "1")
            {
                rbtnHocky1.Checked = true;
            }
            else
            {
                rbtnHocky2.Checked = true;
            }

            DateTime ngaynhan;
            DateTime hannop;

            if (!DateTime.TryParse(row.Cells["NgayNhan"].Value.ToString(), out ngaynhan))
            {
                dtpNgaynhan.Value = dtpNgaynhan.MinDate;
            }
            else
            {
                dtpNgaynhan.Value = ngaynhan;
            }
            if (!DateTime.TryParse(row.Cells["HanNop"].Value.ToString(), out hannop))
            {
                dtpHannop.Value = dtpHannop.MinDate;
            }
            else
            {
                dtpHannop.Value = hannop;
            }
            dtpNgaythi.Value = DateTime.Parse(row.Cells["NgayThi"].Value.ToString());
        }

        private void toggleEdit(bool flag)
        {
            dgvBaithi.Enabled = !flag;

            btnThem.Enabled = !flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;

            if (action == "them")
            {
                cbMonhoc.Enabled = flag;
                cbLophoc.Enabled = flag;
                txtLanthi.Enabled = flag;
                rbtnHocky1.Enabled = flag;
                rbtnHocky2.Enabled = flag;
                txtNamhoc.Enabled = flag;
            }
            dtpNgaythi.Enabled = flag;
            txtSobaithi.Enabled = flag;
            dtpNgaynhan.Enabled = flag;
            dtpHannop.Enabled = flag;

            btnLuu.Enabled = flag;
            btnKhongluu.Enabled = flag;
        }
    }
}
