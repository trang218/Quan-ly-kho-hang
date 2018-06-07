namespace _2017_QLKH
{
    partial class TaiKhoan
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_quyen = new System.Windows.Forms.Button();
            this.btn_matkhau = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_taikhoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ Thống";
            // 
            // btn_quyen
            // 
            this.btn_quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quyen.Location = new System.Drawing.Point(75, 90);
            this.btn_quyen.Name = "btn_quyen";
            this.btn_quyen.Size = new System.Drawing.Size(126, 28);
            this.btn_quyen.TabIndex = 3;
            this.btn_quyen.Text = "Nâng Cấp Quyền";
            this.btn_quyen.UseVisualStyleBackColor = true;
            this.btn_quyen.Click += new System.EventHandler(this.btn_quyen_Click);
            // 
            // btn_matkhau
            // 
            this.btn_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matkhau.Location = new System.Drawing.Point(75, 122);
            this.btn_matkhau.Name = "btn_matkhau";
            this.btn_matkhau.Size = new System.Drawing.Size(126, 28);
            this.btn_matkhau.TabIndex = 4;
            this.btn_matkhau.Text = "Đổi Mật Khẩu";
            this.btn_matkhau.UseVisualStyleBackColor = true;
            this.btn_matkhau.Click += new System.EventHandler(this.btn_matkhau_Click);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(75, 154);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(126, 27);
            this.btn_quaylai.TabIndex = 5;
            this.btn_quaylai.Text = "Trở Về Menu";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taikhoan.Location = new System.Drawing.Point(75, 58);
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.Size = new System.Drawing.Size(126, 28);
            this.btn_taikhoan.TabIndex = 2;
            this.btn_taikhoan.Text = "Tài Khoản";
            this.btn_taikhoan.UseVisualStyleBackColor = true;
            this.btn_taikhoan.Click += new System.EventHandler(this.btn_taikhoan_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 192);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.btn_matkhau);
            this.Controls.Add(this.btn_quyen);
            this.Controls.Add(this.btn_taikhoan);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaiKhoan_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_quyen;
        private System.Windows.Forms.Button btn_matkhau;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_taikhoan;
    }
}