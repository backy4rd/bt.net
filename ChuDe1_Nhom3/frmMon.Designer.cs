namespace ChuDe1_Nhom3
{
    partial class frmMon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mamonTextBox = new System.Windows.Forms.TextBox();
            this.tinchiTextBox = new System.Windows.Forms.TextBox();
            this.tenmonTextBox = new System.Windows.Forms.TextBox();
            this.themBtn = new System.Windows.Forms.Button();
            this.khongluuBtn = new System.Windows.Forms.Button();
            this.suaBtn = new System.Windows.Forms.Button();
            this.luuBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.dongBtn = new System.Windows.Forms.Button();
            this.dsMHGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dsMHGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã môn học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tín chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên môn học:";
            // 
            // mamonTextBox
            // 
            this.mamonTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mamonTextBox.Location = new System.Drawing.Point(148, 59);
            this.mamonTextBox.Name = "mamonTextBox";
            this.mamonTextBox.Size = new System.Drawing.Size(377, 30);
            this.mamonTextBox.TabIndex = 4;
            // 
            // tinchiTextBox
            // 
            this.tinchiTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinchiTextBox.Location = new System.Drawing.Point(148, 150);
            this.tinchiTextBox.Name = "tinchiTextBox";
            this.tinchiTextBox.Size = new System.Drawing.Size(377, 30);
            this.tinchiTextBox.TabIndex = 6;
            // 
            // tenmonTextBox
            // 
            this.tenmonTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenmonTextBox.Location = new System.Drawing.Point(148, 104);
            this.tenmonTextBox.Name = "tenmonTextBox";
            this.tenmonTextBox.Size = new System.Drawing.Size(377, 30);
            this.tenmonTextBox.TabIndex = 5;
            // 
            // themBtn
            // 
            this.themBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themBtn.Location = new System.Drawing.Point(86, 415);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(72, 32);
            this.themBtn.TabIndex = 12;
            this.themBtn.Text = "Thêm";
            this.themBtn.UseVisualStyleBackColor = true;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // khongluuBtn
            // 
            this.khongluuBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khongluuBtn.Location = new System.Drawing.Point(360, 415);
            this.khongluuBtn.Name = "khongluuBtn";
            this.khongluuBtn.Size = new System.Drawing.Size(112, 32);
            this.khongluuBtn.TabIndex = 13;
            this.khongluuBtn.Text = "Không lưu";
            this.khongluuBtn.UseVisualStyleBackColor = true;
            this.khongluuBtn.Click += new System.EventHandler(this.khongluuBtn_Click);
            // 
            // suaBtn
            // 
            this.suaBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaBtn.Location = new System.Drawing.Point(164, 415);
            this.suaBtn.Name = "suaBtn";
            this.suaBtn.Size = new System.Drawing.Size(112, 32);
            this.suaBtn.TabIndex = 13;
            this.suaBtn.Text = "Chỉnh sửa";
            this.suaBtn.UseVisualStyleBackColor = true;
            this.suaBtn.Click += new System.EventHandler(this.suaBtn_Click);
            // 
            // luuBtn
            // 
            this.luuBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luuBtn.Location = new System.Drawing.Point(282, 415);
            this.luuBtn.Name = "luuBtn";
            this.luuBtn.Size = new System.Drawing.Size(72, 32);
            this.luuBtn.TabIndex = 14;
            this.luuBtn.Text = "Lưu";
            this.luuBtn.UseVisualStyleBackColor = true;
            this.luuBtn.Click += new System.EventHandler(this.luuBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBtn.Location = new System.Drawing.Point(182, 453);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(72, 32);
            this.xoaBtn.TabIndex = 15;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.UseVisualStyleBackColor = true;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // dongBtn
            // 
            this.dongBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongBtn.Location = new System.Drawing.Point(260, 453);
            this.dongBtn.Name = "dongBtn";
            this.dongBtn.Size = new System.Drawing.Size(122, 32);
            this.dongBtn.TabIndex = 16;
            this.dongBtn.Text = "Đóng Form";
            this.dongBtn.UseVisualStyleBackColor = true;
            this.dongBtn.Click += new System.EventHandler(this.dongBtn_Click);
            // 
            // dsMHGridView
            // 
            this.dsMHGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsMHGridView.Location = new System.Drawing.Point(18, 196);
            this.dsMHGridView.Name = "dsMHGridView";
            this.dsMHGridView.Size = new System.Drawing.Size(507, 213);
            this.dsMHGridView.TabIndex = 17;
            this.dsMHGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsMHGridView_CellClick);
            // 
            // frmMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 495);
            this.Controls.Add(this.dsMHGridView);
            this.Controls.Add(this.dongBtn);
            this.Controls.Add(this.xoaBtn);
            this.Controls.Add(this.luuBtn);
            this.Controls.Add(this.suaBtn);
            this.Controls.Add(this.khongluuBtn);
            this.Controls.Add(this.themBtn);
            this.Controls.Add(this.tenmonTextBox);
            this.Controls.Add(this.tinchiTextBox);
            this.Controls.Add(this.mamonTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin môn học";
            this.Load += new System.EventHandler(this.frmMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMHGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mamonTextBox;
        private System.Windows.Forms.TextBox tinchiTextBox;
        private System.Windows.Forms.TextBox tenmonTextBox;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.Button khongluuBtn;
        private System.Windows.Forms.Button suaBtn;
        private System.Windows.Forms.Button luuBtn;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Button dongBtn;
        private System.Windows.Forms.DataGridView dsMHGridView;
    }
}