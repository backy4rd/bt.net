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
    public partial class frmBaithitheolophoc : Form
    {
        DataSet lop = new DataSet();
        DataSet mon = new DataSet();
        DataSet hocky = new DataSet();
        DataSet dsbaithi = new DataSet();
        DataView dvbaithi = new DataView();
        bool blnThem = false;

        public frmBaithitheolophoc()
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
            cbLophoc.Enabled = true;

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
            cbLophoc.Enabled = false;
            txtNamhoc.Clear();
            txtSobaithi.Clear();
            txtLanthi.Clear();
            cbMonhoc.Select();
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
            cbHocki.Enabled = false;
            cbMonhoc.Enabled = false;
            txtSobaithi.ReadOnly = false;
        }

        void GanDuLieu()
        {
            if (dvbaithi.Count > 0)
            {
                cbLophoc.SelectedValue = dgvBaithitheolop[0, dgvBaithitheolop.CurrentRow.Index].Value.ToString();
                cbMonhoc.SelectedValue = dgvBaithitheolop[1, dgvBaithitheolop.CurrentRow.Index].Value.ToString();
                txtLanthi.Text = dgvBaithitheolop[2, dgvBaithitheolop.CurrentRow.Index].Value.ToString();
                cbHocki.SelectedValue = dgvBaithitheolop[3, dgvBaithitheolop.CurrentRow.Index].Value.ToString();
                txtNamhoc.Text = dgvBaithitheolop[4, dgvBaithitheolop.CurrentRow.Index].Value.ToString();
                dtpNgaythi.Value = DateTime.Parse(dgvBaithitheolop[5, dgvBaithitheolop.CurrentRow.Index].Value.ToString());
                txtSobaithi.Text = dgvBaithitheolop[6, dgvBaithitheolop.CurrentRow.Index].Value.ToString();
               
                DateTime ngaynhan;
                DateTime hannop;

                if (!DateTime.TryParse(dgvBaithitheolop[7, dgvBaithitheolop.CurrentRow.Index].Value.ToString(), out ngaynhan))
                {
                    dtpNgaynhan.MinDate = new DateTime(2000, 1, 1);
                    dtpNgaynhan.Value = dtpNgaynhan.MinDate;
                }
                else
                    dtpNgaynhan.Value = DateTime.Parse(dgvBaithitheolop[7, dgvBaithitheolop.CurrentRow.Index].Value.ToString());
                if (!DateTime.TryParse(dgvBaithitheolop[8, dgvBaithitheolop.CurrentRow.Index].Value.ToString(), out hannop))
                {
                    dtpHannop.MinDate = new DateTime(2000, 1, 1);
                    dtpHannop.Value = dtpHannop.MinDate;
                }
                else
                    dtpHannop.Value = DateTime.Parse(dgvBaithitheolop[8, dgvBaithitheolop.CurrentRow.Index].Value.ToString());

              
            }
            else
            {
                cbMonhoc.SelectedIndex = -1;
                txtNamhoc.Clear();
                txtSobaithi.Clear();
                txtLanthi.Clear();
                dtpNgaythi.Value = DateTime.Today;
                cbHocki.SelectedIndex = -1;
            }
        }
       
        private void btnDongform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBaithitheolophoc_Load(object sender, EventArgs e)
        {
            string select = "Select MaLop, MaMon, LanThi, HocKy, NamHoc, NgayThi, SoBai, NgayNhan, HanNop  From TheoDoiBaiThi";
            MyPublic.OpenData(select, dsbaithi, "TheoDoiBaiThi");

            select = "Select TenLop, MaLop From LopHoc";
            MyPublic.OpenData(select, lop, "LopHoc");

            select = "Select MaMon, TenMon From MonHoc";
            MyPublic.OpenData(select, mon, "MonHoc");

            cbLophoc.DataSource = lop.Tables["LopHoc"];
            cbLophoc.DisplayMember = "TenLop";
            cbLophoc.ValueMember = "MaLop";

            cbMonhoc.DataSource = mon.Tables["MonHoc"];
            cbMonhoc.DisplayMember = "TenMon";
            cbMonhoc.ValueMember = "MaMon";

            hocky.Tables.Add("TheoDoiBaiThi");
            hocky.Tables["TheoDoiBaiThi"].Columns.Add("HocKy");
            hocky.Tables["TheoDoiBaiThi"].Rows.Add("1");
            hocky.Tables["TheoDoiBaiThi"].Rows.Add("2");
            cbHocki.DataSource = hocky;
            cbHocki.DisplayMember = "TheoDoiBaiThi.HocKy";
            cbHocki.ValueMember = "TheoDoiBaiThi.HocKy";

            dvbaithi.Table = dsbaithi.Tables["TheoDoiBaiThi"];
            dvbaithi.RowFilter = "MaLop like '" + cbLophoc.SelectedValue + "'";

            dgvBaithitheolop.DataSource = dvbaithi;
            dgvBaithitheolop.Width = 702;
            dgvBaithitheolop.AllowUserToAddRows = false;
            dgvBaithitheolop.AllowUserToDeleteRows = false;
            dgvBaithitheolop.Columns[0].Width = 70;
            dgvBaithitheolop.Columns[0].HeaderText = "Mã lớp";
            dgvBaithitheolop.Columns[1].Width = 70;
            dgvBaithitheolop.Columns[1].HeaderText = "Mã môn";
            dgvBaithitheolop.Columns[2].Width = 65;
            dgvBaithitheolop.Columns[2].HeaderText = "Lần thi";
            dgvBaithitheolop.Columns[3].Width = 70;
            dgvBaithitheolop.Columns[3].HeaderText = "Học Kỳ";
            dgvBaithitheolop.Columns[4].Width = 80;
            dgvBaithitheolop.Columns[4].HeaderText = "Năm học";
            dgvBaithitheolop.Columns[5].Width = 80;
            dgvBaithitheolop.Columns[5].HeaderText = "Ngày thi";
            dgvBaithitheolop.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBaithitheolop.Columns[6].Width = 80;
            dgvBaithitheolop.Columns[6].HeaderText = "Số bài thi";
            dgvBaithitheolop.Columns[7].Width = 85;
            dgvBaithitheolop.Columns[7].HeaderText = "Ngày nhận";
            dgvBaithitheolop.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBaithitheolop.Columns[8].Width = 80;
            dgvBaithitheolop.Columns[8].HeaderText = "Hạn nộp";
            dgvBaithitheolop.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBaithitheolop.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void txtLanthi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtSobaithi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //    e.Handled = true;
        }

        private void dtpNgaythi_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaythi.Format = DateTimePickerFormat.Custom;
            dtpNgaythi.CustomFormat = "dd-MM-yyyy";
        }

        private void dtpNgaynhan_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaynhan.Format = DateTimePickerFormat.Custom;
            dtpNgaynhan.CustomFormat = "dd-MM-yyyy";
        }

        private void dtpHannop_ValueChanged(object sender, EventArgs e)
        {
            dtpHannop.Format = DateTimePickerFormat.Custom;
            dtpHannop.CustomFormat = "dd-MM-yyyy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKhienKhiThem();
        }

        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            blnThem = false;
            DieuKhienKhiChinhSua();
        }

        void Luu()
        {
            string sql, hocky;

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
            hocky = cbHocki.SelectedValue.ToString();
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
                dsbaithi.Tables["TheoDoiBaiThi"].Rows.Add(cbLophoc.SelectedValue, cbMonhoc.SelectedValue, txtLanthi.Text, hocky, txtNamhoc.Text, dtpNgaythi.Value, txtSobaithi.Text, dtpNgaynhan.Value, dtpHannop.Value);
                GanDuLieu();
                blnThem = false;
            }
            else
            {
                int curRow = dgvBaithitheolop.CurrentRow.Index;
                //dsbaithi.Tables["TheoDoiBaiThi"].Rows[curRow][1] = cbMonhoc.SelectedValue;
                //dsbaithi.Tables["TheoDoiBaiThi"].Rows[curRow][2] = txtLanthi.Text;
                //dsbaithi.Tables["TheoDoiBaiThi"].Rows[curRow][3] = hocky;
                //dsbaithi.Tables["TheoDoiBaiThi"].Rows[curRow][4] = txtNamhoc.Text;
                dsbaithi.Tables["TheoDoiBaiThi"].Rows[curRow][5] = dtpNgaythi.Value;
                dsbaithi.Tables["TheoDoiBaiThi"].Rows[curRow][6] = txtSobaithi.Text;
                dsbaithi.Tables["TheoDoiBaiThi"].Rows[curRow][7] = dtpNgaynhan.Value;
                dsbaithi.Tables["TheoDoiBaiThi"].Rows[curRow][8] = dtpHannop.Value;
            }
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((cbMonhoc.SelectedIndex == -1) || (txtNamhoc.Text == "") || (txtLanthi.Text == "") || (txtSobaithi.Text == "") || (cbHocki.SelectedIndex == -1))
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublic.tonTaiKhoaChinh("MaMon", cbMonhoc.SelectedValue.ToString(), "MonHoc"))
                MessageBox.Show("Phải xóa dữ liệu môn học này trước !");
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
                    int curRow = dgvBaithitheolop.CurrentRow.Index;
                    dsbaithi.Tables["TheoDoiBaiThi"].Rows.RemoveAt(curRow);
                    GanDuLieu();
                }
            }
            DieuKhienKhiBinhThuong();
        }

        private void dgvLophoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void cbLophoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbLophoc.SelectedIndex != -1) && (blnThem == false))
            {
                dvbaithi.RowFilter = "MaLop like '" + cbLophoc.SelectedValue + "'";
                dgvBaithitheolop.DataSource = dvbaithi;
                GanDuLieu();
            }
        }
    }
}
