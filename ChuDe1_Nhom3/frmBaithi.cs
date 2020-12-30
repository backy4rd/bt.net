using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe1_Nhom3
{
    public partial class frmBaithi : Form
    {
        public frmBaithi()
        {
            InitializeComponent();
        }

        private void dtpNgaythi_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaythi.Format = DateTimePickerFormat.Custom; 
            dtpNgaythi.CustomFormat = "dd-MM-yyyy";
        }

    }
}
