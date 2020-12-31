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
    public partial class frmLop : Form
    {
        DataSet lop = new DataSet();
        DataSet trungtam = new DataSet();
        bool blnThem = false;

        public frmLop()
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
            txtMalop.ReadOnly = true;
            txtTenlop.ReadOnly = true;
        }

        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhsua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongluu.Enabled = true;
            btnXoa.Enabled = false;
            btnDongform.Enabled = false;
            txtMalop.ReadOnly = false;
            txtTenlop.ReadOnly = false;
            txtMalop.Clear();
            txtTenlop.Clear();
            cbTrungtam.SelectedIndex = -1;
            txtMalop.Select();
        }

        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhsua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongluu.Enabled = true;
            btnXoa.Enabled = false;
            btnDongform.Enabled = false;
            txtMalop.ReadOnly = true;
            txtTenlop.ReadOnly = false;
            txtMalop.Select();
        }

        void GanDuLieu()
        {
            if (lop.Tables["LopHoc"].Rows.Count > 0)
            {
                txtMalop.Text = dgvLophoc[0, dgvLophoc.CurrentRow.Index].Value.ToString();
                txtTenlop.Text = dgvLophoc[1, dgvLophoc.CurrentRow.Index].Value.ToString();
                cbTrungtam.SelectedValue = dgvLophoc[2, dgvLophoc.CurrentRow.Index].Value.ToString();
            }
            else
            {
                txtMalop.Clear();
                txtTenlop.Clear();
                cbTrungtam.SelectedIndex = -1;
            }
        }


        private void btnDongform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            string strSelect = "Select * From LopHoc";
            MyPublic.OpenData(strSelect, lop, "LopHoc");

            strSelect = "Select MaTT, TenTT From TrungTam";
            MyPublic.OpenData(strSelect, trungtam, "TrungTam");

            cbTrungtam.DataSource = trungtam.Tables["TrungTam"];
            cbTrungtam.DisplayMember = "TenTT";
            cbTrungtam.ValueMember = "MaTT";


            txtMalop.MaxLength = 8;
            txtTenlop.MaxLength = 40;

            dgvLophoc.DataSource = lop;
            dgvLophoc.DataMember = "LopHoc";
            dgvLophoc.Width = 526;
            dgvLophoc.AllowUserToAddRows = false;
            dgvLophoc.AllowUserToDeleteRows = false;
            dgvLophoc.Columns[0].Width = 100;
            dgvLophoc.Columns[0].HeaderText = "Mã lớp";
            dgvLophoc.Columns[1].Width = 265;
            dgvLophoc.Columns[1].HeaderText = "Tên lớp";
            dgvLophoc.Columns[2].Width = 100;
            dgvLophoc.Columns[2].HeaderText = "Mã trung tâm";
            dgvLophoc.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void dgvLophoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKhienKhiThem();
        }

        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        void Luu()
        {
            string sql, matt;
            if (blnThem)
                sql = "Insert Into LopHoc Values(@MaLop, @TenLop, @MaTT)";
            else
                sql = "Update LopHoc Set TenLop = @TenLop, MaTT = @MaTT Where MaLop = @MaLop"; 
            if (MyPublic.connection.State == ConnectionState.Closed)
                MyPublic.connection.Open();
            SqlCommand command = new SqlCommand(sql, MyPublic.connection);
            command.Parameters.AddWithValue("@MaLop", txtMalop.Text);
            command.Parameters.AddWithValue("@TenLop", txtTenlop.Text);
            matt = cbTrungtam.SelectedValue.ToString();
            command.Parameters.AddWithValue("@MaTT", matt);
           
            command.ExecuteNonQuery();
            MyPublic.connection.Close();
            if (blnThem)
            {
                lop.Tables["LopHoc"].Rows.Add(txtMalop.Text, txtTenlop.Text, matt);
                GanDuLieu();
                blnThem = false;
            }
            else
            {
                int curRow = dgvLophoc.CurrentRow.Index;
                lop.Tables["LopHoc"].Rows[curRow][0] = txtMalop.Text;
                lop.Tables["LopHoc"].Rows[curRow][1] = txtTenlop.Text;
                lop.Tables["LopHoc"].Rows[curRow][2] = matt;
            }
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
             if ((txtMalop.Text == "") || (txtTenlop.Text == "") || (cbTrungtam.SelectedIndex == -1))
                MessageBox.Show("Lỗi nhập dữ liệu !");
            else
                 if ((blnThem) && (MyPublic.tonTaiKhoaChinh(txtMalop.Text, "MaLop", "LopHoc")))
                {
                    MessageBox.Show("Mã số lớp này đã có rồi !");
                    txtMalop.Focus();
                }
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
            if (MyPublic.tonTaiKhoaChinh(txtMalop.Text, "MaLop", "LopHoc"))
                MessageBox.Show("Phải xóa bài thi của lớp trước !");
            else
            {
                DialogResult dongY;
                dongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác Nhận", MessageBoxButtons.YesNo);
                if (dongY == DialogResult.Yes)
                {
                    string delete = "Delete LopHoc Where MaLop = @MaLop";
                    if (MyPublic.connection.State == ConnectionState.Closed)
                        MyPublic.connection.Open();
                    SqlCommand cmdCommand = new SqlCommand(delete, MyPublic.connection);
                    cmdCommand.Parameters.AddWithValue("@MaLop", txtMalop.Text);
                    cmdCommand.ExecuteNonQuery();
                    MyPublic.connection.Close();
                    int curRow = dgvLophoc.CurrentRow.Index;
                    lop.Tables["LopHoc"].Rows.RemoveAt(curRow);
                    GanDuLieu();
                }
            }
            DieuKhienKhiBinhThuong();
        }



    }
}
