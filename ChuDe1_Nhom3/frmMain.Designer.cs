namespace ChuDe1_Nhom3
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDulieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaithi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrungtam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienich = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaithitheomon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaithitheolop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTuychon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoatdangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGioithieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDulieu,
            this.mnuTienich,
            this.mnuTuychon});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDulieu
            // 
            this.mnuDulieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaikhoan,
            this.mnuLop,
            this.mnuMon,
            this.mnuBaithi,
            this.mnuTrungtam});
            this.mnuDulieu.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDulieu.Name = "mnuDulieu";
            this.mnuDulieu.Size = new System.Drawing.Size(84, 27);
            this.mnuDulieu.Text = "Dữ liệu";
            // 
            // mnuTaikhoan
            // 
            this.mnuTaikhoan.Name = "mnuTaikhoan";
            this.mnuTaikhoan.Size = new System.Drawing.Size(271, 28);
            this.mnuTaikhoan.Text = "Tài khoản người dùng";
            // 
            // mnuLop
            // 
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(271, 28);
            this.mnuLop.Text = "Lớp học";
            // 
            // mnuMon
            // 
            this.mnuMon.Name = "mnuMon";
            this.mnuMon.Size = new System.Drawing.Size(271, 28);
            this.mnuMon.Text = "Môn học";
            // 
            // mnuBaithi
            // 
            this.mnuBaithi.Name = "mnuBaithi";
            this.mnuBaithi.Size = new System.Drawing.Size(271, 28);
            this.mnuBaithi.Text = "Theo dõi bài thi";
            // 
            // mnuTrungtam
            // 
            this.mnuTrungtam.Name = "mnuTrungtam";
            this.mnuTrungtam.Size = new System.Drawing.Size(271, 28);
            this.mnuTrungtam.Text = "Trung tâm";
            // 
            // mnuTienich
            // 
            this.mnuTienich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaithitheomon,
            this.mnuBaithitheolop});
            this.mnuTienich.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTienich.Name = "mnuTienich";
            this.mnuTienich.Size = new System.Drawing.Size(90, 27);
            this.mnuTienich.Text = "Tiện ích";
            // 
            // mnuBaithitheomon
            // 
            this.mnuBaithitheomon.Name = "mnuBaithitheomon";
            this.mnuBaithitheomon.Size = new System.Drawing.Size(338, 28);
            this.mnuBaithitheomon.Text = "Theo dõi bài thi theo môn học";
            // 
            // mnuBaithitheolop
            // 
            this.mnuBaithitheolop.Name = "mnuBaithitheolop";
            this.mnuBaithitheolop.Size = new System.Drawing.Size(338, 28);
            this.mnuBaithitheolop.Text = "Theo dõi bài thi theo lớp học";
            // 
            // mnuTuychon
            // 
            this.mnuTuychon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangnhap,
            this.mnuDoimatkhau,
            this.mnuThoatdangnhap,
            this.toolStripSeparator2,
            this.mnuGioithieu,
            this.mnuThoat});
            this.mnuTuychon.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTuychon.Name = "mnuTuychon";
            this.mnuTuychon.Size = new System.Drawing.Size(102, 27);
            this.mnuTuychon.Text = "Tùy chọn";
            // 
            // mnuDangnhap
            // 
            this.mnuDangnhap.Name = "mnuDangnhap";
            this.mnuDangnhap.Size = new System.Drawing.Size(227, 28);
            this.mnuDangnhap.Text = "Đăng nhập";
            this.mnuDangnhap.Click += new System.EventHandler(this.mnuDangnhap_Click);
            // 
            // mnuDoimatkhau
            // 
            this.mnuDoimatkhau.Name = "mnuDoimatkhau";
            this.mnuDoimatkhau.Size = new System.Drawing.Size(227, 28);
            this.mnuDoimatkhau.Text = "Đổi mật khẩu";
            this.mnuDoimatkhau.Click += new System.EventHandler(this.mnuDoimatkhau_Click);
            // 
            // mnuThoatdangnhap
            // 
            this.mnuThoatdangnhap.Name = "mnuThoatdangnhap";
            this.mnuThoatdangnhap.Size = new System.Drawing.Size(227, 28);
            this.mnuThoatdangnhap.Text = "Thoát đăng nhập";
            this.mnuThoatdangnhap.Click += new System.EventHandler(this.mnuThoatdangnhap_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // mnuGioithieu
            // 
            this.mnuGioithieu.Name = "mnuGioithieu";
            this.mnuGioithieu.Size = new System.Drawing.Size(227, 28);
            this.mnuGioithieu.Text = "Giới thiệu";
            this.mnuGioithieu.Click += new System.EventHandler(this.mnuGioithieu_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(227, 28);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 430);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý bài thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTaikhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuMon;
        private System.Windows.Forms.ToolStripMenuItem mnuBaithi;
        private System.Windows.Forms.ToolStripMenuItem mnuTrungtam;
        private System.Windows.Forms.ToolStripMenuItem mnuBaithitheomon;
        private System.Windows.Forms.ToolStripMenuItem mnuBaithitheolop;
        private System.Windows.Forms.ToolStripMenuItem mnuTuychon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuGioithieu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        public System.Windows.Forms.ToolStripMenuItem mnuDulieu;
        public System.Windows.Forms.ToolStripMenuItem mnuTienich;
        public System.Windows.Forms.ToolStripMenuItem mnuDangnhap;
        public System.Windows.Forms.ToolStripMenuItem mnuDoimatkhau;
        public System.Windows.Forms.ToolStripMenuItem mnuThoatdangnhap;
    }
}

