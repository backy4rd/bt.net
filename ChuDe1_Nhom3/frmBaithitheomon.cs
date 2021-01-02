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
    public partial class frmBaithitheomon : Form
    {
        DataSet lop = new DataSet();
        DataSet mon = new DataSet();
        DataSet dsbaithi = new DataSet();
        DataView dvbaithi = new DataView();
        bool blnThem = false;

        public frmBaithitheomon()
        {
            InitializeComponent();
        }

        void DieuKhienKhiBinhThuong()
        {
            if (MyPublic.quyenSD == "AdTinh" || MyPublic.quyenSD == "AdTruong")
            {
                btnThem.Enabled = true;
                btnChinhsua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnChinhsua.Enabled = false;
                btnXoa.Enabled = false;
            }
            btnLuu.Enabled = false;
            btnKhongluu.Enabled = false;
            btnDongform.Enabled = true;
            txtNamhoc.ReadOnly = true;
            txtSobaithi.ReadOnly = true;
            txtLanthi.ReadOnly = true;
            cbLophoc.Enabled = false;
            cbMonhoc.Enabled = true;
            rbtnHocky1.Enabled = false;
            rbtnHocky2.Enabled = false;
            dtpNgaythi.Enabled = false;
            dtpNgaynhan.Enabled = false;
            dtpHannop.Enabled = false;
        }

        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhsua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongluu.Enabled = true;
            btnXoa.Enabled = false;
            btnDongform.Enabled = false;
            txtNamhoc.ReadOnly = false;
            txtSobaithi.ReadOnly = false;
            txtLanthi.ReadOnly = false;
            cbMonhoc.Enabled = false;
            cbLophoc.Enabled = true;
            rbtnHocky1.Enabled = true;
            rbtnHocky2.Enabled = true;
            rbtnHocky1.Checked = true;
            txtNamhoc.Clear();
            txtSobaithi.Clear();
            txtLanthi.Clear();
            cbMonhoc.Select();
            dtpNgaythi.Enabled = true;
            dtpNgaynhan.Enabled = true;
            dtpHannop.Enabled = true;
        }

        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhsua.Enabled = false;
            btnDongform.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongluu.Enabled = true;
            btnXoa.Enabled = false;
            txtSobaithi.Select();
            rbtnHocky1.Enabled = true;
            rbtnHocky2.Enabled = true; 
            cbLophoc.Enabled = false;
            txtSobaithi.ReadOnly = false;
            dtpNgaythi.Enabled = true;
            dtpNgaynhan.Enabled = true;
            dtpHannop.Enabled = true;
        }

        void GanDuLieu()
        {
            if (dvbaithi.Count > 0)
            {
                cbMonhoc.SelectedValue = dgvBaithitheomon[0, dgvBaithitheomon.CurrentRow.Index].Value.ToString();
                cbLophoc.SelectedValue = dgvBaithitheomon[1, dgvBaithitheomon.CurrentRow.Index].Value.ToString();
                txtLanthi.Text = dgvBaithitheomon[2, dgvBaithitheomon.CurrentRow.Index].Value.ToString();
                if (dgvBaithitheomon[3, dgvBaithitheomon.CurrentRow.Index].Value.ToString() == "1")
                    rbtnHocky1.Checked = true;
                else
                    rbtnHocky2.Checked = true;
                txtNamhoc.Text = dgvBaithitheomon[4, dgvBaithitheomon.CurrentRow.Index].Value.ToString();
                dtpNgaythi.Value = DateTime.Parse(dgvBaithitheomon[5, dgvBaithitheomon.CurrentRow.Index].Value.ToString());
                txtSobaithi.Text = dgvBaithitheomon[6, dgvBaithitheomon.CurrentRow.Index].Value.ToString();

                DateTime ngaynhan;
                DateTime hannop;

                if (!DateTime.TryParse(dgvBaithitheomon[7, dgvBaithitheomon.CurrentRow.Index].Value.ToString(), out ngaynhan))
                {
                    dtpNgaynhan.MinDate = new DateTime(2000, 1, 1);
                    dtpNgaynhan.Value = dtpNgaynhan.MinDate;
                }
                else
                    dtpNgaynhan.Value = DateTime.Parse(dgvBaithitheomon[7, dgvBaithitheomon.CurrentRow.Index].Value.ToString());
                if (!DateTime.TryParse(dgvBaithitheomon[8, dgvBaithitheomon.CurrentRow.Index].Value.ToString(), out hannop))
                {
                    dtpHannop.MinDate = new DateTime(2000, 1, 1);
                    dtpHannop.Value = dtpHannop.MinDate;
                }
                else
                    dtpHannop.Value = DateTime.Parse(dgvBaithitheomon[8, dgvBaithitheomon.CurrentRow.Index].Value.ToString());
            }
            else
            {
                cbLophoc.SelectedIndex = -1;
                txtNamhoc.Clear();
                txtSobaithi.Clear();
                txtLanthi.Clear();
                dtpNgaythi.Value = DateTime.Today;
                dtpNgaynhan.Value = DateTime.Today;
                dtpHannop.Value = DateTime.Today;
                rbtnHocky1.Checked = false;
                rbtnHocky2.Checked = false;
            }
        }

        private void frmBaithitheomon_Load(object sender, EventArgs e)
        {
            string select = "Select MaMon, MaLop, LanThi, HocKy, NamHoc, NgayThi, SoBai, NgayNhan, HanNop  From TheoDoiBaiThi";
            MyPublic.OpenData(select, dsbaithi, "TheoDoiBaiThi");

            select = "Select MaLop, TenLop From LopHoc";
            MyPublic.OpenData(select, lop, "LopHoc");

            select = "Select MaMon, TenMon From MonHoc";
            MyPublic.OpenData(select, mon, "MonHoc");

            cbLophoc.DataSource = lop.Tables["LopHoc"];
            cbLophoc.DisplayMember = "TenLop";
            cbLophoc.ValueMember = "MaLop";

            cbMonhoc.DataSource = mon.Tables["MonHoc"];
            cbMonhoc.DisplayMember = "TenMon";
            cbMonhoc.ValueMember = "MaMon";

            dvbaithi.Table = dsbaithi.Tables["TheoDoiBaiThi"];
            dvbaithi.RowFilter = "MaMon like '" + cbMonhoc.SelectedValue + "'";

            dgvBaithitheomon.DataSource = dvbaithi;
            dgvBaithitheomon.Width = 723;
            dgvBaithitheomon.AllowUserToAddRows = false;
            dgvBaithitheomon.AllowUserToDeleteRows = false;
            dgvBaithitheomon.Columns[0].Width = 70;
            dgvBaithitheomon.Columns[0].HeaderText = "Mã Môn";
            dgvBaithitheomon.Columns[1].Width = 70;
            dgvBaithitheomon.Columns[1].HeaderText = "Mã Lớp";
            dgvBaithitheomon.Columns[2].Width = 65;
            dgvBaithitheomon.Columns[2].HeaderText = "Lần thi";
            dgvBaithitheomon.Columns[3].Width = 70;
            dgvBaithitheomon.Columns[3].HeaderText = "Học Kỳ";
            dgvBaithitheomon.Columns[4].Width = 80;
            dgvBaithitheomon.Columns[4].HeaderText = "Năm học";
            dgvBaithitheomon.Columns[5].Width = 80;
            dgvBaithitheomon.Columns[5].HeaderText = "Ngày thi";
            dgvBaithitheomon.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBaithitheomon.Columns[6].Width = 80;
            dgvBaithitheomon.Columns[6].HeaderText = "Số bài thi";
            dgvBaithitheomon.Columns[7].Width = 85;
            dgvBaithitheomon.Columns[7].HeaderText = "Ngày nhận";
            dgvBaithitheomon.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBaithitheomon.Columns[8].Width = 80;
            dgvBaithitheomon.Columns[8].HeaderText = "Hạn nộp";
            dgvBaithitheomon.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBaithitheomon.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        void Luu()
        {
            string sql, hocky = "1";

            if (blnThem == true)
                sql = "Insert Into TheoDoiBaiThi Values(@MaMon, @MaLop, @LanThi, @HocKy, @NamHoc, @NgayThi, @SoBai, @NgayNhan, @HanNop)";
            else
                sql = "Update TheoDoiBaiThi Set NgayThi = @NgayThi, SoBai = @SoBai, NgayNhan = @NgayNhan, HanNop = @HanNop Where MaLop = @MaLop And MaMon = @MaMon And LanThi = @LanThi And HocKy = @HocKy And NamHoc = @NamHoc";

            if (MyPublic.connection.State == ConnectionState.Closed)
                MyPublic.connection.Open();
            SqlCommand command = new SqlCommand(sql, MyPublic.connection);

            command.Parameters.AddWithValue("@MaLop", cbLophoc.SelectedValue);
            command.Parameters.AddWithValue("@MaMon", cbMonhoc.SelectedValue);
            command.Parameters.AddWithValue("@LanThi", txtLanthi.Text);
            if (rbtnHocky2.Checked)
                hocky = "2";
            command.Parameters.AddWithValue("@HocKy", hocky);
            command.Parameters.AddWithValue("@NamHoc", txtNamhoc.Text);
            command.Parameters.AddWithValue("@NgayThi", dtpNgaythi.Value);
            command.Parameters.AddWithValue("@SoBai", txtSobaithi.Text);
            command.Parameters.AddWithValue("@NgayNhan", dtpNgaynhan.Value);
            command.Parameters.AddWithValue("@HanNop", dtpHannop.Value);
            command.ExecuteNonQuery();
            MyPublic.connection.Close();
           
            if (blnThem == true)
            {
                dsbaithi.Tables["TheoDoiBaiThi"].Rows.Add(cbMonhoc.SelectedValue, cbLophoc.SelectedValue, txtLanthi.Text, hocky, txtNamhoc.Text, dtpNgaythi.Value, txtSobaithi.Text, dtpNgaynhan.Value, dtpHannop.Value);
                GanDuLieu();
                blnThem = false;
            }
            else
            {
                int curRow;
                for (curRow = 0; curRow < dsbaithi.Tables["TheoDoiBaiThi"].Rows.Count; curRow++)
                {
                    var row = dsbaithi.Tables["TheoDoiBaiThi"].Rows[curRow];
                    if (row[0].ToString() == cbMonhoc.SelectedValue.ToString() && 
                        row[1].ToString() == cbLophoc.SelectedValue.ToString() && 
                        row[2].ToString() == txtLanthi.Text && 
                        row[3].ToString() == hocky && 
                        row[4].ToString() == txtNamhoc.Text)
                    {
                        break;
                    }
                }
                dvbaithi.Table.Rows[curRow][5] = dtpNgaythi.Value;
                dvbaithi.Table.Rows[curRow][6] = txtSobaithi.Text;
                dvbaithi.Table.Rows[curRow][7] = dtpNgaynhan.Value;
                dvbaithi.Table.Rows[curRow][8] = dtpHannop.Value;
            }
            DieuKhienKhiBinhThuong();
            
        }

        private void btnDongform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBaithitheomon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MyPublic.tonTaiKhoaChinh("MaLop", cbMonhoc.SelectedValue.ToString(), "LopHoc"))
                MessageBox.Show("Phải xóa dữ liệu lớp học này trước !");
            else
            {
                DialogResult dongY;
                dongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác Nhận", MessageBoxButtons.YesNo);
                if (dongY == DialogResult.Yes)
                {
                    string delete = "Delete TheoDoiBaiThi Where MaMon = @MaMon And MaLop = @MaLop";
                    if (MyPublic.connection.State == ConnectionState.Closed)
                        MyPublic.connection.Open();
                    SqlCommand command = new SqlCommand(delete, MyPublic.connection);
                    command.Parameters.AddWithValue("@MaMon", cbMonhoc.SelectedValue);
                    command.Parameters.AddWithValue("@MaLop", cbLophoc.SelectedValue);
                    command.ExecuteNonQuery();
                    MyPublic.connection.Close();
                    int curRow = dgvBaithitheomon.CurrentRow.Index;
                    dsbaithi.Tables["TheoDoiBaiThi"].Rows.RemoveAt(curRow);
                    GanDuLieu();
                }
            }
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((cbLophoc.SelectedIndex == -1) || (txtNamhoc.Text == "") || (txtLanthi.Text == "") || (txtSobaithi.Text == "") || ((rbtnHocky1.Checked = false) && (rbtnHocky2.Checked = false)))
                MessageBox.Show("Lỗi nhập dữ liệu !");
            else
                Luu();
        }

        private void btnKhongluu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            blnThem = false;
            DieuKhienKhiChinhSua();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKhienKhiThem();
        }

        private void dtpHannop_ValueChanged(object sender, EventArgs e)
        {
            dtpHannop.Format = DateTimePickerFormat.Custom;
            dtpHannop.CustomFormat = "dd-MM-yyyy";
        }

        private void dtpNgaynhan_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaynhan.Format = DateTimePickerFormat.Custom;
            dtpNgaynhan.CustomFormat = "dd-MM-yyyy";
        }

        private void dtpNgaythi_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaythi.Format = DateTimePickerFormat.Custom;
            dtpNgaythi.CustomFormat = "dd-MM-yyyy";
        }

        private void txtSobaithi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtLanthi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void cbMonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbMonhoc.SelectedIndex != -1))
            {
                dvbaithi.RowFilter = "MaMon like '" + cbMonhoc.SelectedValue + "'";
                dgvBaithitheomon.DataSource = dvbaithi;
                GanDuLieu();
            }
        }

    }
}