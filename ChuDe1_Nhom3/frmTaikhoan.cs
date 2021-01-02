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
    public partial class frmTaikhoan : Form
    {
        private string action;
        private DataTable dsNguoiSD;

        public frmTaikhoan()
        {
            InitializeComponent();
        }

        private void frmTaikhoan_Load(object sender, EventArgs e)
        {
            dsTKGridView.AllowUserToAddRows = false;
            dsTKGridView.AllowUserToDeleteRows = false;
            tenTKTextBox.MaxLength = 20;

            // set data cho combobox
            DataTable table = new DataTable();
            table.Columns.Add("QuyenSD");
            table.Rows.Add("User");
            table.Rows.Add("AdTruong");
            table.Rows.Add("AdTinh");

            quyenSDCBBox.DataSource = table;
            quyenSDCBBox.DisplayMember = "QuyenSD";
            quyenSDCBBox.ValueMember = "QuyenSD";

            // set data cho data ma tt combobox
            if (MyPublic.connection.State == ConnectionState.Closed)
            {
                MyPublic.connection.Open();
            }

            string query = "SELECT MaTT, TenTT FROM TrungTam";
            DataSet dataSet = new DataSet();
            MyPublic.OpenData(query, dataSet, "TrungTam");

            maTTCBBox.DataSource = dataSet.Tables["TrungTam"];
            maTTCBBox.DisplayMember = "TenTT";
            maTTCBBox.ValueMember = "MaTT";

            // set data cho data grid view
            query = "SELECT TenTaiKhoan, QuyenSD, MaTT FROM NguoiSuDung";
            dataSet = new DataSet();
            MyPublic.OpenData(query, dataSet, "NguoiSuDung");
            dsNguoiSD = dataSet.Tables["NguoiSuDung"];

            dsTKGridView.DataSource = dataSet.Tables["NguoiSuDung"];
            dsTKGridView.Columns[0].Width = 125;
            dsTKGridView.Columns[0].HeaderText = "Tên tài khoản";
            dsTKGridView.Columns[1].Width = 125;
            dsTKGridView.Columns[1].HeaderText = "Quyền sử dụng";
            dsTKGridView.Columns[2].Width = 125;
            dsTKGridView.Columns[2].HeaderText = "Mã trung tâm";

            // highlight cac button
            if (MyPublic.quyenSD == "AdTinh")
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
            dsTKGridView.Enabled = true;
            tenTKTextBox.Enabled = false;
            maTTCBBox.Enabled = false;
            quyenSDCBBox.Enabled = false;

            luuBtn.Enabled = false;
            khongluuBtn.Enabled = false;

            // select tai khoan dau tien
            displayRowAt(0);
        }

        private void dsTKGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayRowAt(dsTKGridView.CurrentRow.Index);
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            action = "them";
            tenTKTextBox.Text = "";
            quyenSDCBBox.SelectedValue = "";
            maTTCBBox.SelectedValue = "";

            toggleEdit(true);

            tenTKTextBox.Select();
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            action = "sua";

            toggleEdit(true);
        }


        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (tenTKTextBox.Text == "" || quyenSDCBBox.SelectedValue == "" || maTTCBBox.SelectedValue == "")
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
            int currentRow = dsTKGridView.CurrentRow.Index;


            if (MyPublic.tonTaiKhoaChinh("TenTaiKhoan", tenTKTextBox.Text, "NguoiSuDung") && action == "them")
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (action == "them")
            {
                query = "INSERT INTO NguoiSuDung VALUES(@TAIKHOAN, @MATKHAU, @QUYENSD, @MATT)";
                command = new SqlCommand(query, MyPublic.connection);
                command.Parameters.AddWithValue("@TAIKHOAN", tenTKTextBox.Text);
                command.Parameters.AddWithValue("@QUYENSD", quyenSDCBBox.SelectedValue);
                command.Parameters.AddWithValue("@MATT", maTTCBBox.SelectedValue);
                command.Parameters.AddWithValue("@MATKHAU", showRequirePasswordPrompt()); ;

                dsNguoiSD.Rows.Add(tenTKTextBox.Text, quyenSDCBBox.SelectedValue, maTTCBBox.SelectedValue);

            }
            else
            {
                query = "UPDATE NguoiSuDung SET QuyenSD=@QUYENSD, MaTT=@MATT WHERE TenTaiKhoan=@TAIKHOAN";
                command = new SqlCommand(query, MyPublic.connection);
                command.Parameters.AddWithValue("@QUYENSD", quyenSDCBBox.SelectedValue);
                command.Parameters.AddWithValue("@MATT", maTTCBBox.SelectedValue);
                command.Parameters.AddWithValue("@TAIKHOAN", tenTKTextBox.Text);

                dsNguoiSD.Rows[currentRow]["TenTaiKhoan"] = tenTKTextBox.Text;
                dsNguoiSD.Rows[currentRow]["QuyenSD"] = quyenSDCBBox.SelectedValue;
                dsNguoiSD.Rows[currentRow]["MaTT"] = maTTCBBox.SelectedValue;
            }

            command.ExecuteNonQuery();

            toggleEdit(false);
        }

        private void khongluuBtn_Click(object sender, EventArgs e)
        {
            displayRowAt(dsTKGridView.CurrentRow.Index);
            toggleEdit(false);
        }

        private void dongBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            int currentRow = dsTKGridView.CurrentRow.Index;

            DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No) return;

            if (MyPublic.connection.State == ConnectionState.Closed)
            {
                MyPublic.connection.Open();
            }
            string query = "DELETE FROM NguoiSuDung WHERE TenTaiKhoan=@TAIKHOAN";
            SqlCommand command = new SqlCommand(query, MyPublic.connection);
            command.Parameters.AddWithValue("@TAIKHOAN", dsNguoiSD.Rows[currentRow][0]);

            command.ExecuteNonQuery();
            dsNguoiSD.Rows.RemoveAt(currentRow);
        }

        private string showRequirePasswordPrompt()
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Yêu cầu",
                StartPosition = FormStartPosition.CenterScreen,
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Vui lòng nhập mật khẩu" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 180, PasswordChar = '*', MaxLength = 20 };
            Button confirmation = new Button() { Text = "Ok", Left = 160, Width = 100, Top = 78, DialogResult = DialogResult.OK };
            textBox.Select();
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void displayRowAt(int index)
        {
            DataGridViewRow row = dsTKGridView.Rows[index];
            tenTKTextBox.Text = row.Cells["TenTaiKhoan"].Value.ToString();
            quyenSDCBBox.SelectedValue = row.Cells["QuyenSD"].Value.ToString();
            maTTCBBox.SelectedValue = row.Cells["MaTT"].Value.ToString();
        }

        private void toggleEdit(bool flag)
        {
            if (flag)
            {
                dsTKGridView.Enabled = false;

                themBtn.Enabled = false;
                suaBtn.Enabled = false;
                xoaBtn.Enabled = false;

                if (action == "them") tenTKTextBox.Enabled = true;
                maTTCBBox.Enabled = true;
                quyenSDCBBox.Enabled = true;

                luuBtn.Enabled = true;
                khongluuBtn.Enabled = true;
            }
            else
            {
                dsTKGridView.Enabled = true;

                themBtn.Enabled = true;
                suaBtn.Enabled = true;
                xoaBtn.Enabled = true;

                if (action == "them") tenTKTextBox.Enabled = false;
                maTTCBBox.Enabled = false;
                quyenSDCBBox.Enabled = false;

                luuBtn.Enabled = false;
                khongluuBtn.Enabled = false;
            }
        }
    }
}
