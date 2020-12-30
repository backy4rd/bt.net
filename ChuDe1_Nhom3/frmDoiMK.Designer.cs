namespace ChuDe1_Nhom3 {
    partial class frmDoiMK {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mkcuTextBox = new System.Windows.Forms.TextBox();
            this.mkmoiTextBox = new System.Windows.Forms.TextBox();
            this.doimkBtn = new System.Windows.Forms.Button();
            this.dongBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.xacnhanTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // mkcuTextBox
            // 
            this.mkcuTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkcuTextBox.Location = new System.Drawing.Point(182, 58);
            this.mkcuTextBox.Name = "mkcuTextBox";
            this.mkcuTextBox.Size = new System.Drawing.Size(222, 30);
            this.mkcuTextBox.TabIndex = 11;
            this.mkcuTextBox.TextChanged += new System.EventHandler(this.mkcuTextBox_TextChanged);
            // 
            // mkmoiTextBox
            // 
            this.mkmoiTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkmoiTextBox.Location = new System.Drawing.Point(182, 100);
            this.mkmoiTextBox.Name = "mkmoiTextBox";
            this.mkmoiTextBox.Size = new System.Drawing.Size(222, 30);
            this.mkmoiTextBox.TabIndex = 12;
            this.mkmoiTextBox.TextChanged += new System.EventHandler(this.mkmoiTextBox_TextChanged);
            // 
            // doimkBtn
            // 
            this.doimkBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doimkBtn.Location = new System.Drawing.Point(65, 195);
            this.doimkBtn.Name = "doimkBtn";
            this.doimkBtn.Size = new System.Drawing.Size(143, 34);
            this.doimkBtn.TabIndex = 14;
            this.doimkBtn.Text = "Đổi mật khẩu";
            this.doimkBtn.UseVisualStyleBackColor = true;
            this.doimkBtn.Click += new System.EventHandler(this.doimkBtn_Click);
            // 
            // dongBtn
            // 
            this.dongBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongBtn.Location = new System.Drawing.Point(259, 195);
            this.dongBtn.Name = "dongBtn";
            this.dongBtn.Size = new System.Drawing.Size(124, 34);
            this.dongBtn.TabIndex = 15;
            this.dongBtn.Text = "Đóng Form";
            this.dongBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Xác nhận:";
            // 
            // xacnhanTextBox
            // 
            this.xacnhanTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xacnhanTextBox.Location = new System.Drawing.Point(182, 143);
            this.xacnhanTextBox.Name = "xacnhanTextBox";
            this.xacnhanTextBox.Size = new System.Drawing.Size(222, 30);
            this.xacnhanTextBox.TabIndex = 13;
            this.xacnhanTextBox.TextChanged += new System.EventHandler(this.xacnhanTextBox_TextChanged);
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 250);
            this.Controls.Add(this.xacnhanTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dongBtn);
            this.Controls.Add(this.doimkBtn);
            this.Controls.Add(this.mkmoiTextBox);
            this.Controls.Add(this.mkcuTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMK";
            this.Load += new System.EventHandler(this.frmDoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mkcuTextBox;
        private System.Windows.Forms.TextBox mkmoiTextBox;
        private System.Windows.Forms.Button doimkBtn;
        private System.Windows.Forms.Button dongBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xacnhanTextBox;

    }
}