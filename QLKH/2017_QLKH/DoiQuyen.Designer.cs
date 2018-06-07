namespace _2017_QLKH
{
    partial class DoiQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiQuyen));
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_tdn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_dq = new System.Windows.Forms.Button();
            this.tbx_quyencu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_quyenmoi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nâng Cấp Quyền Nhân Viên";
            // 
            // tbx_tdn
            // 
            this.tbx_tdn.Location = new System.Drawing.Point(179, 63);
            this.tbx_tdn.Name = "tbx_tdn";
            this.tbx_tdn.Size = new System.Drawing.Size(135, 20);
            this.tbx_tdn.TabIndex = 11;
            this.tbx_tdn.Validated += new System.EventHandler(this.tbx_tdn_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tên Đăng Nhập";
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(196, 190);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(93, 30);
            this.btn_huy.TabIndex = 18;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_dq
            // 
            this.btn_dq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dq.Location = new System.Drawing.Point(88, 190);
            this.btn_dq.Name = "btn_dq";
            this.btn_dq.Size = new System.Drawing.Size(93, 30);
            this.btn_dq.TabIndex = 17;
            this.btn_dq.Text = "Đổi";
            this.btn_dq.UseVisualStyleBackColor = true;
            this.btn_dq.Click += new System.EventHandler(this.btn_dq_Click);
            // 
            // tbx_quyencu
            // 
            this.tbx_quyencu.Location = new System.Drawing.Point(179, 105);
            this.tbx_quyencu.Name = "tbx_quyencu";
            this.tbx_quyencu.Size = new System.Drawing.Size(136, 20);
            this.tbx_quyencu.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quyền mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quyền hiện Tại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 111);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chú Ý";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "nếu đổi quyền cho tài khoản khác!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "- Tên Đăng Nhập không Thể bỏ trống";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "đổi quyền cho chĩnh bản thân!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "- Tên Đăng Nhập có Thể bỏ trống nếu ";
            // 
            // tbx_quyenmoi
            // 
            this.tbx_quyenmoi.Location = new System.Drawing.Point(179, 146);
            this.tbx_quyenmoi.Name = "tbx_quyenmoi";
            this.tbx_quyenmoi.Size = new System.Drawing.Size(136, 20);
            this.tbx_quyenmoi.TabIndex = 21;
            // 
            // DoiQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 358);
            this.Controls.Add(this.tbx_quyenmoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbx_tdn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dq);
            this.Controls.Add(this.tbx_quyencu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoiQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoiQuyen";
            this.Load += new System.EventHandler(this.DoiQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_tdn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_dq;
        private System.Windows.Forms.TextBox tbx_quyencu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_quyenmoi;
    }
}