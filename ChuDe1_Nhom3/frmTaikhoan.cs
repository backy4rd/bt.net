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
        public frmTaikhoan()
        {
            InitializeComponent();
        }

        private void frmTaikhoan_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("QuyenSD");
            table.Rows.Add("User");
            table.Rows.Add("AdminTruong");
            table.Rows.Add("AdminTinh");

            quyenSDCBBox.DataSource = table;
            quyenSDCBBox.DisplayMember = "QuyenSD";
            quyenSDCBBox.ValueMember = "QuyenSD";

            if (MyPublic.connection.State == ConnectionState.Closed)
            {
                MyPublic.connection.Open();
            }

            string query = "SELECT TenTaiKhoan, QuyenSD, MaTT FROM NguoiSuDung";
            DataSet dataSet = new DataSet();
            MyPublic.OpenData(query, dataSet, "NguoiSuDung");

            dsTKGridView.DataSource = dataSet.Tables["NguoiSuDung"];
        }
    }
}
