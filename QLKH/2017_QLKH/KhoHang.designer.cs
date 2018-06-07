namespace _2017_QLKH
{
    partial class KhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoHang));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_tongdmsp = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_chophepsua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.tbx_ghichu = new System.Windows.Forms.TextBox();
            this.tbx_tenkho = new System.Windows.Forms.TextBox();
            this.tbx_makho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềTrangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_ketquatimkiem = new System.Windows.Forms.GroupBox();
            this.dgvKHOHANG = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_tongdmsp)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox_ketquatimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHOHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kho Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_tongdmsp);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_ghinhan);
            this.groupBox1.Controls.Add(this.btn_lammoi);
            this.groupBox1.Controls.Add(this.btn_chophepsua);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.tbx_ghichu);
            this.groupBox1.Controls.Add(this.tbx_tenkho);
            this.groupBox1.Controls.Add(this.tbx_makho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Trị Kho Hàng";
            // 
            // tbx_tongdmsp
            // 
            this.tbx_tongdmsp.Location = new System.Drawing.Point(103, 70);
            this.tbx_tongdmsp.Name = "tbx_tongdmsp";
            this.tbx_tongdmsp.Size = new System.Drawing.Size(65, 20);
            this.tbx_tongdmsp.TabIndex = 64;
            this.tbx_tongdmsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(483, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 44);
            this.button2.TabIndex = 63;
            this.button2.Text = "Hủy Nhập";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ghinhan.Location = new System.Drawing.Point(483, 76);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(83, 43);
            this.btn_ghinhan.TabIndex = 43;
            this.btn_ghinhan.Text = "Ghi Nhận";
            this.btn_ghinhan.UseVisualStyleBackColor = true;
            this.btn_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_lammoi.Location = new System.Drawing.Point(392, 76);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(83, 43);
            this.btn_lammoi.TabIndex = 11;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_chophepsua
            // 
            this.btn_chophepsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chophepsua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_chophepsua.Location = new System.Drawing.Point(392, 20);
            this.btn_chophepsua.Name = "btn_chophepsua";
            this.btn_chophepsua.Size = new System.Drawing.Size(83, 44);
            this.btn_chophepsua.TabIndex = 10;
            this.btn_chophepsua.Text = "Cho Phép Sửa";
            this.btn_chophepsua.UseVisualStyleBackColor = true;
            this.btn_chophepsua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_xoa.Location = new System.Drawing.Point(300, 76);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(83, 43);
            this.bt_xoa.TabIndex = 9;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_them.Location = new System.Drawing.Point(300, 20);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(83, 44);
            this.bt_them.TabIndex = 8;
            this.bt_them.Text = "Thêm Mới";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // tbx_ghichu
            // 
            this.tbx_ghichu.Location = new System.Drawing.Point(102, 96);
            this.tbx_ghichu.Multiline = true;
            this.tbx_ghichu.Name = "tbx_ghichu";
            this.tbx_ghichu.Size = new System.Drawing.Size(176, 30);
            this.tbx_ghichu.TabIndex = 7;
            // 
            // tbx_tenkho
            // 
            this.tbx_tenkho.Location = new System.Drawing.Point(103, 44);
            this.tbx_tenkho.Name = "tbx_tenkho";
            this.tbx_tenkho.Size = new System.Drawing.Size(175, 20);
            this.tbx_tenkho.TabIndex = 5;
            // 
            // tbx_makho
            // 
            this.tbx_makho.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_makho.Enabled = false;
            this.tbx_makho.ForeColor = System.Drawing.Color.Black;
            this.tbx_makho.Location = new System.Drawing.Point(103, 18);
            this.tbx_makho.Name = "tbx_makho";
            this.tbx_makho.Size = new System.Drawing.Size(175, 20);
            this.tbx_makho.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng  SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Kho";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tùyChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vềTrangChủToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tùyChọnToolStripMenuItem.Text = "Tùy Chọn";
            // 
            // vềTrangChủToolStripMenuItem
            // 
            this.vềTrangChủToolStripMenuItem.Name = "vềTrangChủToolStripMenuItem";
            this.vềTrangChủToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.vềTrangChủToolStripMenuItem.Text = "Về  Trang Chủ";
            this.vềTrangChủToolStripMenuItem.Click += new System.EventHandler(this.vềTrangChủToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox_ketquatimkiem
            // 
            this.groupBox_ketquatimkiem.Controls.Add(this.dgvKHOHANG);
            this.groupBox_ketquatimkiem.Controls.Add(this.button1);
            this.groupBox_ketquatimkiem.Controls.Add(this.btn_timkiem);
            this.groupBox_ketquatimkiem.Controls.Add(this.tbx_timkiem);
            this.groupBox_ketquatimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ketquatimkiem.Location = new System.Drawing.Point(15, 171);
            this.groupBox_ketquatimkiem.Name = "groupBox_ketquatimkiem";
            this.groupBox_ketquatimkiem.Size = new System.Drawing.Size(577, 259);
            this.groupBox_ketquatimkiem.TabIndex = 4;
            this.groupBox_ketquatimkiem.TabStop = false;
            this.groupBox_ketquatimkiem.Text = "Danh Sách Kho Hàng";
            // 
            // dgvKHOHANG
            // 
            this.dgvKHOHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKHOHANG.Location = new System.Drawing.Point(5, 45);
            this.dgvKHOHANG.Name = "dgvKHOHANG";
            this.dgvKHOHANG.ReadOnly = true;
            this.dgvKHOHANG.RowHeadersVisible = false;
            this.dgvKHOHANG.Size = new System.Drawing.Size(567, 206);
            this.dgvKHOHANG.TabIndex = 0;
            this.dgvKHOHANG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKHOHANG_CellClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(303, 15);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(86, 24);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click_1);
            // 
            // tbx_timkiem
            // 
            this.tbx_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_timkiem.ForeColor = System.Drawing.Color.Red;
            this.tbx_timkiem.Location = new System.Drawing.Point(94, 18);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.Size = new System.Drawing.Size(203, 20);
            this.tbx_timkiem.TabIndex = 1;
            // 
            // KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 438);
            this.Controls.Add(this.groupBox_ketquatimkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KhoHang_FormClosed);
            this.Load += new System.EventHandler(this.KhoHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_tongdmsp)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_ketquatimkiem.ResumeLayout(false);
            this.groupBox_ketquatimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHOHANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_ghichu;
        private System.Windows.Forms.TextBox tbx_tenkho;
        private System.Windows.Forms.TextBox tbx_makho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button btn_chophepsua;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_ghinhan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vềTrangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown tbx_tongdmsp;
        private System.Windows.Forms.GroupBox groupBox_ketquatimkiem;
        private System.Windows.Forms.DataGridView dgvKHOHANG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox tbx_timkiem;
    }
}