namespace _2017_QLKH
{
    partial class BoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoPhan));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_MaKho = new System.Windows.Forms.ComboBox();
            this.tbx_NQL = new System.Windows.Forms.ComboBox();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            this.btn_mo = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tbx_TenBP = new System.Windows.Forms.TextBox();
            this.tbx_Dienthoai = new System.Windows.Forms.TextBox();
            this.tbx_MaBP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_BoPhan = new System.Windows.Forms.DataGridView();
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BoPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bộ Phận";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_MaKho);
            this.groupBox1.Controls.Add(this.tbx_NQL);
            this.groupBox1.Controls.Add(this.btn_ghinhan);
            this.groupBox1.Controls.Add(this.btn_mo);
            this.groupBox1.Controls.Add(this.btn_lammoi);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.tbx_TenBP);
            this.groupBox1.Controls.Add(this.tbx_Dienthoai);
            this.groupBox1.Controls.Add(this.tbx_MaBP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 130);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Trị";
            // 
            // tbx_MaKho
            // 
            this.tbx_MaKho.FormattingEnabled = true;
            this.tbx_MaKho.Location = new System.Drawing.Point(297, 53);
            this.tbx_MaKho.Name = "tbx_MaKho";
            this.tbx_MaKho.Size = new System.Drawing.Size(145, 21);
            this.tbx_MaKho.TabIndex = 4;
            // 
            // tbx_NQL
            // 
            this.tbx_NQL.FormattingEnabled = true;
            this.tbx_NQL.Location = new System.Drawing.Point(297, 25);
            this.tbx_NQL.Name = "tbx_NQL";
            this.tbx_NQL.Size = new System.Drawing.Size(145, 21);
            this.tbx_NQL.TabIndex = 3;
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.Location = new System.Drawing.Point(389, 89);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(75, 23);
            this.btn_ghinhan.TabIndex = 9;
            this.btn_ghinhan.Text = "Ghi Nhận";
            this.btn_ghinhan.UseVisualStyleBackColor = true;
            this.btn_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // btn_mo
            // 
            this.btn_mo.Location = new System.Drawing.Point(197, 23);
            this.btn_mo.Name = "btn_mo";
            this.btn_mo.Size = new System.Drawing.Size(39, 23);
            this.btn_mo.TabIndex = 1;
            this.btn_mo.Text = "Mở";
            this.btn_mo.UseVisualStyleBackColor = true;
            this.btn_mo.Click += new System.EventHandler(this.btn_mo_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(496, 89);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(98, 23);
            this.btn_lammoi.TabIndex = 10;
            this.btn_lammoi.Text = "Làm Mới/Hủy";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(285, 89);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(179, 89);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(73, 89);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tbx_TenBP
            // 
            this.tbx_TenBP.Location = new System.Drawing.Point(91, 54);
            this.tbx_TenBP.Name = "tbx_TenBP";
            this.tbx_TenBP.Size = new System.Drawing.Size(145, 20);
            this.tbx_TenBP.TabIndex = 2;
            // 
            // tbx_Dienthoai
            // 
            this.tbx_Dienthoai.Location = new System.Drawing.Point(533, 25);
            this.tbx_Dienthoai.Name = "tbx_Dienthoai";
            this.tbx_Dienthoai.Size = new System.Drawing.Size(120, 20);
            this.tbx_Dienthoai.TabIndex = 5;
            // 
            // tbx_MaBP
            // 
            this.tbx_MaBP.Location = new System.Drawing.Point(91, 25);
            this.tbx_MaBP.Name = "tbx_MaBP";
            this.tbx_MaBP.Size = new System.Drawing.Size(100, 20);
            this.tbx_MaBP.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "NQL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bộ Phận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã BP";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("btn_quaylai.Image")));
            this.btn_quaylai.Location = new System.Drawing.Point(18, 7);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(52, 34);
            this.btn_quaylai.TabIndex = 13;
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(478, 18);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 12;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_BoPhan);
            this.groupBox2.Controls.Add(this.tbx_timkiem);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 260);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bộ Phận";
            // 
            // dgv_BoPhan
            // 
            this.dgv_BoPhan.AllowUserToAddRows = false;
            this.dgv_BoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BoPhan.Location = new System.Drawing.Point(6, 47);
            this.dgv_BoPhan.Name = "dgv_BoPhan";
            this.dgv_BoPhan.RowHeadersVisible = false;
            this.dgv_BoPhan.Size = new System.Drawing.Size(654, 207);
            this.dgv_BoPhan.TabIndex = 12;
            this.dgv_BoPhan.TabStop = false;
            this.dgv_BoPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BoPhan_CellClick);
            this.dgv_BoPhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_BoPhan_KeyDown);
            // 
            // tbx_timkiem
            // 
            this.tbx_timkiem.Location = new System.Drawing.Point(105, 21);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.Size = new System.Drawing.Size(337, 20);
            this.tbx_timkiem.TabIndex = 11;
            // 
            // BoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BoPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ Phận";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoPhan_FormClosed);
            this.Load += new System.EventHandler(this.BoPhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BoPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_TenBP;
        private System.Windows.Forms.TextBox tbx_Dienthoai;
        private System.Windows.Forms.TextBox tbx_MaBP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbx_timkiem;
        private System.Windows.Forms.DataGridView dgv_BoPhan;
        private System.Windows.Forms.Button btn_mo;
        private System.Windows.Forms.Button btn_ghinhan;
        private System.Windows.Forms.ComboBox tbx_MaKho;
        private System.Windows.Forms.ComboBox tbx_NQL;
    }
}