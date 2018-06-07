namespace _2017_QLKH
{
    partial class BaoCaoF
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoF));
            this.rpv_baocao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpv_baocao
            // 
            this.rpv_baocao.DocumentMapWidth = 1;
            reportDataSource1.Name = "BaoCaoNhap";
            reportDataSource1.Value = null;
            this.rpv_baocao.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_baocao.LocalReport.ReportEmbeddedResource = "_2017_QLKH.BaoCao.BaoCaoNhap.rdlc";
            this.rpv_baocao.Location = new System.Drawing.Point(12, 12);
            this.rpv_baocao.Name = "rpv_baocao";
            this.rpv_baocao.Size = new System.Drawing.Size(669, 671);
            this.rpv_baocao.TabIndex = 0;
            // 
            // BaoCaoF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(693, 695);
            this.Controls.Add(this.rpv_baocao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaoCaoF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCaoF";
            this.Load += new System.EventHandler(this.BaoCaoF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_baocao;
        
    }
}