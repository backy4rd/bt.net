namespace ChuDe1_Nhom3
{
    partial class frmDangNhap
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
            this.taikhoanTextBox = new System.Windows.Forms.TextBox();
            this.matkhauTextBox = new System.Windows.Forms.TextBox();
            this.dangnhapBtn = new System.Windows.Forms.Button();
            this.dongBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
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
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // taikhoanTextBox
            // 
            this.taikhoanTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoanTextBox.Location = new System.Drawing.Point(152, 58);
            this.taikhoanTextBox.Name = "taikhoanTextBox";
            this.taikhoanTextBox.Size = new System.Drawing.Size(222, 30);
            this.taikhoanTextBox.TabIndex = 3;
            this.taikhoanTextBox.TextChanged += new System.EventHandler(this.taikhoanTextBox_TextChanged);
            // 
            // matkhauTextBox
            // 
            this.matkhauTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhauTextBox.Location = new System.Drawing.Point(152, 100);
            this.matkhauTextBox.Name = "matkhauTextBox";
            this.matkhauTextBox.Size = new System.Drawing.Size(222, 30);
            this.matkhauTextBox.TabIndex = 4;
            this.matkhauTextBox.TextChanged += new System.EventHandler(this.matkhauTextBox_TextChanged);
            // 
            // dangnhapBtn
            // 
            this.dangnhapBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhapBtn.Location = new System.Drawing.Point(51, 159);
            this.dangnhapBtn.Name = "dangnhapBtn";
            this.dangnhapBtn.Size = new System.Drawing.Size(112, 34);
            this.dangnhapBtn.TabIndex = 5;
            this.dangnhapBtn.Text = "Đăng nhập";
            this.dangnhapBtn.UseVisualStyleBackColor = true;
            this.dangnhapBtn.Click += new System.EventHandler(this.dangnhapBtn_Click);
            // 
            // dongBtn
            // 
            this.dongBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongBtn.Location = new System.Drawing.Point(217, 159);
            this.dongBtn.Name = "dongBtn";
            this.dongBtn.Size = new System.Drawing.Size(124, 34);
            this.dongBtn.TabIndex = 7;
            this.dongBtn.Text = "Đóng Form";
            this.dongBtn.UseVisualStyleBackColor = true;
            this.dongBtn.Click += new System.EventHandler(this.dongBtn_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 216);
            this.ControlBox = false;
            this.Controls.Add(this.dongBtn);
            this.Controls.Add(this.dangnhapBtn);
            this.Controls.Add(this.matkhauTextBox);
            this.Controls.Add(this.taikhoanTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taikhoanTextBox;
        private System.Windows.Forms.TextBox matkhauTextBox;
        private System.Windows.Forms.Button dangnhapBtn;
        private System.Windows.Forms.Button dongBtn;
    }
}