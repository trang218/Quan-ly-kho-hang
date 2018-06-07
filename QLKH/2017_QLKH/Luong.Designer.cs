namespace _2017_QLKH
{
    partial class Luong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Luong));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.group_bangluon = new System.Windows.Forms.GroupBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.group_quantri = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.tbx_Manv = new System.Windows.Forms.TextBox();
            this.tb_manv = new System.Windows.Forms.Label();
            this.tbx_luong = new System.Windows.Forms.TextBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.group_bangluon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.group_quantri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lương Nhân Viên";
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quaylai.Location = new System.Drawing.Point(490, 20);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(77, 24);
            this.bt_quaylai.TabIndex = 5;
            this.bt_quaylai.Text = "Quay Lại";
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click);
            // 
            // group_bangluon
            // 
            this.group_bangluon.Controls.Add(this.btn_lammoi);
            this.group_bangluon.Controls.Add(this.btn_timkiem);
            this.group_bangluon.Controls.Add(this.tbx_timkiem);
            this.group_bangluon.Controls.Add(this.dgvLuong);
            this.group_bangluon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_bangluon.Location = new System.Drawing.Point(12, 137);
            this.group_bangluon.Name = "group_bangluon";
            this.group_bangluon.Size = new System.Drawing.Size(555, 301);
            this.group_bangluon.TabIndex = 2;
            this.group_bangluon.TabStop = false;
            this.group_bangluon.Text = "Bảng Lương";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(440, 28);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(74, 22);
            this.btn_lammoi.TabIndex = 9;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(317, 28);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 8;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // tbx_timkiem
            // 
            this.tbx_timkiem.Location = new System.Drawing.Point(41, 30);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.Size = new System.Drawing.Size(259, 20);
            this.tbx_timkiem.TabIndex = 7;
            // 
            // dgvLuong
            // 
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Location = new System.Drawing.Point(6, 60);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.Size = new System.Drawing.Size(544, 232);
            this.dgvLuong.TabIndex = 6;
            this.dgvLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CellClick);
            // 
            // group_quantri
            // 
            this.group_quantri.Controls.Add(this.btn_sua);
            this.group_quantri.Controls.Add(this.tbx_Manv);
            this.group_quantri.Controls.Add(this.tb_manv);
            this.group_quantri.Controls.Add(this.tbx_luong);
            this.group_quantri.Controls.Add(this.bt_xoa);
            this.group_quantri.Controls.Add(this.label2);
            this.group_quantri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_quantri.Location = new System.Drawing.Point(12, 61);
            this.group_quantri.Name = "group_quantri";
            this.group_quantri.Size = new System.Drawing.Size(555, 70);
            this.group_quantri.TabIndex = 3;
            this.group_quantri.TabStop = false;
            this.group_quantri.Text = "Quản Trị";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(390, 23);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(62, 25);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // tbx_Manv
            // 
            this.tbx_Manv.Location = new System.Drawing.Point(77, 26);
            this.tbx_Manv.Name = "tbx_Manv";
            this.tbx_Manv.Size = new System.Drawing.Size(100, 20);
            this.tbx_Manv.TabIndex = 0;
            // 
            // tb_manv
            // 
            this.tb_manv.AutoSize = true;
            this.tb_manv.Location = new System.Drawing.Point(10, 29);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(45, 13);
            this.tb_manv.TabIndex = 6;
            this.tb_manv.Text = "Mã NV";
            // 
            // tbx_luong
            // 
            this.tbx_luong.Location = new System.Drawing.Point(266, 26);
            this.tbx_luong.Name = "tbx_luong";
            this.tbx_luong.Size = new System.Drawing.Size(100, 20);
            this.tbx_luong.TabIndex = 1;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(473, 23);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(62, 25);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lương";
            // 
            // Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 441);
            this.Controls.Add(this.group_quantri);
            this.Controls.Add(this.group_bangluon);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Luong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luong";
            this.Load += new System.EventHandler(this.Luong_Load);
            this.group_bangluon.ResumeLayout(false);
            this.group_bangluon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.group_quantri.ResumeLayout(false);
            this.group_quantri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.GroupBox group_bangluon;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.GroupBox group_quantri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.TextBox tbx_Manv;
        private System.Windows.Forms.TextBox tbx_luong;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox tbx_timkiem;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Label tb_manv;
    }
}