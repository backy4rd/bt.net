namespace ChuDe1_Nhom3
{
    partial class frmTaikhoan
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
            this.tenTKTextBox = new System.Windows.Forms.TextBox();
            this.quyenSDCBBox = new System.Windows.Forms.ComboBox();
            this.dsTKGridView = new System.Windows.Forms.DataGridView();
            this.dongBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.luuBtn = new System.Windows.Forms.Button();
            this.suaBtn = new System.Windows.Forms.Button();
            this.khongluuBtn = new System.Windows.Forms.Button();
            this.themBtn = new System.Windows.Forms.Button();
            this.maTTCBBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsTKGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quyền sử dụng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trung tâm:";
            // 
            // tenTKTextBox
            // 
            this.tenTKTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTKTextBox.Location = new System.Drawing.Point(174, 51);
            this.tenTKTextBox.Name = "tenTKTextBox";
            this.tenTKTextBox.Size = new System.Drawing.Size(263, 30);
            this.tenTKTextBox.TabIndex = 4;
            // 
            // quyenSDCBBox
            // 
            this.quyenSDCBBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quyenSDCBBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quyenSDCBBox.FormattingEnabled = true;
            this.quyenSDCBBox.Location = new System.Drawing.Point(174, 104);
            this.quyenSDCBBox.Name = "quyenSDCBBox";
            this.quyenSDCBBox.Size = new System.Drawing.Size(263, 31);
            this.quyenSDCBBox.TabIndex = 5;
            // 
            // dsTKGridView
            // 
            this.dsTKGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTKGridView.Location = new System.Drawing.Point(18, 208);
            this.dsTKGridView.Name = "dsTKGridView";
            this.dsTKGridView.Size = new System.Drawing.Size(419, 150);
            this.dsTKGridView.TabIndex = 7;
            this.dsTKGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTKGridView_CellClick);
            // 
            // dongBtn
            // 
            this.dongBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongBtn.Location = new System.Drawing.Point(205, 413);
            this.dongBtn.Name = "dongBtn";
            this.dongBtn.Size = new System.Drawing.Size(122, 32);
            this.dongBtn.TabIndex = 22;
            this.dongBtn.Text = "Đóng Form";
            this.dongBtn.UseVisualStyleBackColor = true;
            this.dongBtn.Click += new System.EventHandler(this.dongBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBtn.Location = new System.Drawing.Point(127, 413);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(72, 32);
            this.xoaBtn.TabIndex = 21;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.UseVisualStyleBackColor = true;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // luuBtn
            // 
            this.luuBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luuBtn.Location = new System.Drawing.Point(227, 375);
            this.luuBtn.Name = "luuBtn";
            this.luuBtn.Size = new System.Drawing.Size(72, 32);
            this.luuBtn.TabIndex = 20;
            this.luuBtn.Text = "Lưu";
            this.luuBtn.UseVisualStyleBackColor = true;
            this.luuBtn.Click += new System.EventHandler(this.luuBtn_Click);
            // 
            // suaBtn
            // 
            this.suaBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaBtn.Location = new System.Drawing.Point(109, 375);
            this.suaBtn.Name = "suaBtn";
            this.suaBtn.Size = new System.Drawing.Size(112, 32);
            this.suaBtn.TabIndex = 18;
            this.suaBtn.Text = "Chỉnh sửa";
            this.suaBtn.UseVisualStyleBackColor = true;
            this.suaBtn.Click += new System.EventHandler(this.suaBtn_Click);
            // 
            // khongluuBtn
            // 
            this.khongluuBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khongluuBtn.Location = new System.Drawing.Point(305, 375);
            this.khongluuBtn.Name = "khongluuBtn";
            this.khongluuBtn.Size = new System.Drawing.Size(112, 32);
            this.khongluuBtn.TabIndex = 19;
            this.khongluuBtn.Text = "Không lưu";
            this.khongluuBtn.UseVisualStyleBackColor = true;
            this.khongluuBtn.Click += new System.EventHandler(this.khongluuBtn_Click);
            // 
            // themBtn
            // 
            this.themBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themBtn.Location = new System.Drawing.Point(31, 375);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(72, 32);
            this.themBtn.TabIndex = 17;
            this.themBtn.Text = "Thêm";
            this.themBtn.UseVisualStyleBackColor = true;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // maTTCBBox
            // 
            this.maTTCBBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maTTCBBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maTTCBBox.FormattingEnabled = true;
            this.maTTCBBox.Location = new System.Drawing.Point(174, 156);
            this.maTTCBBox.Name = "maTTCBBox";
            this.maTTCBBox.Size = new System.Drawing.Size(263, 31);
            this.maTTCBBox.TabIndex = 23;
            // 
            // frmTaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 462);
            this.Controls.Add(this.maTTCBBox);
            this.Controls.Add(this.dongBtn);
            this.Controls.Add(this.xoaBtn);
            this.Controls.Add(this.luuBtn);
            this.Controls.Add(this.suaBtn);
            this.Controls.Add(this.khongluuBtn);
            this.Controls.Add(this.themBtn);
            this.Controls.Add(this.dsTKGridView);
            this.Controls.Add(this.quyenSDCBBox);
            this.Controls.Add(this.tenTKTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaikhoan";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.frmTaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTKGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tenTKTextBox;
        private System.Windows.Forms.ComboBox quyenSDCBBox;
        private System.Windows.Forms.DataGridView dsTKGridView;
        private System.Windows.Forms.Button dongBtn;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Button luuBtn;
        private System.Windows.Forms.Button suaBtn;
        private System.Windows.Forms.Button khongluuBtn;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.ComboBox maTTCBBox;
    }
}