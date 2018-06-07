namespace _2017_QLKH
{
    partial class DangNhapHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapHeThong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.chb_showpass = new System.Windows.Forms.CheckBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.lb_STT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(145, 68);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(133, 20);
            this.tbx_username.TabIndex = 3;
            this.tbx_username.Text = "1";
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(145, 124);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(133, 20);
            this.tbx_password.TabIndex = 4;
            this.tbx_password.Text = "1";
            this.tbx_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_password_KeyDown);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(197, 209);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(81, 23);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // chb_showpass
            // 
            this.chb_showpass.AutoSize = true;
            this.chb_showpass.Location = new System.Drawing.Point(145, 178);
            this.chb_showpass.Name = "chb_showpass";
            this.chb_showpass.Size = new System.Drawing.Size(97, 17);
            this.chb_showpass.TabIndex = 7;
            this.chb_showpass.Text = "Hiện Mật Khẩu";
            this.chb_showpass.UseVisualStyleBackColor = true;
            this.chb_showpass.CheckedChanged += new System.EventHandler(this.chb_showpass_CheckedChanged);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.Location = new System.Drawing.Point(68, 209);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(81, 23);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_STT
            // 
            this.lb_STT.AutoSize = true;
            this.lb_STT.ForeColor = System.Drawing.Color.Red;
            this.lb_STT.Location = new System.Drawing.Point(56, 159);
            this.lb_STT.Name = "lb_STT";
            this.lb_STT.Size = new System.Drawing.Size(31, 13);
            this.lb_STT.TabIndex = 8;
            this.lb_STT.Text = "STT:";
            // 
            // DangNhapHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.lb_STT);
            this.Controls.Add(this.chb_showpass);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhapHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhapHeThong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.CheckBox chb_showpass;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Label lb_STT;
    }
}