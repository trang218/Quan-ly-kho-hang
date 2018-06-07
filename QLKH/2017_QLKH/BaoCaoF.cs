using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_QLKH
{
    public partial class BaoCaoF : Form
    {
        public BaoCaoF()
        {
            InitializeComponent();
        }

        accessData acc = new accessData();
        public static string TDN;
        public static int keyn = 0;
        public static string TenKho = null;
        public static string TenNcc_Kh = null;
        public static string TenSp = null;
        public static string TenNv = null;
        public static string Gia = null;
        public static string NgayNh_Xu = null;
        public static string TuNgay = null;
        public static string DenNgay = null;
        public static string MAPN;
        public static string MAPX;


        private void BaoCaoF_Load(object sender, EventArgs e)
        {
            if (keyn == 1)
            {
                SqlConnection con = new SqlConnection();
                string sql = @"Data Source=TRANG\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True";
                con.ConnectionString = sql;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BCN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENNV", TenNv));
                cmd.Parameters.Add(new SqlParameter("@TENSP", TenSp));
                cmd.Parameters.Add(new SqlParameter("@TENNCC", TenNcc_Kh));
                cmd.Parameters.Add(new SqlParameter("@TENKHO", TenKho));
                cmd.Parameters.Add(new SqlParameter("@NGAYNHAP", NgayNh_Xu));
                cmd.Parameters.Add(new SqlParameter("@GIA", Gia));
                cmd.Parameters.Add(new SqlParameter("@TUNGAY", TuNgay));
                cmd.Parameters.Add(new SqlParameter("@DENNGAY", DenNgay));
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                //ReportParameter tungay = new ReportParameter("Tungay", TuNgay);
                //ReportParameter denngay = new ReportParameter("Denngay", DenNgay);
                //ReportParameter tu = new ReportParameter("Tu", "Từ");
                //ReportParameter den = new ReportParameter("Den", "Đến");
                rpv_baocao.ProcessingMode = ProcessingMode.Local;
                rpv_baocao.LocalReport.ReportPath = "BaoCaoNhap.rdlc";
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "BaoCaoNhap";
                    rds.Value = ds.Tables[0];
                    rpv_baocao.LocalReport.DataSources.Clear();
                    rpv_baocao.LocalReport.DataSources.Add(rds);
                    //rpv_baocao.LocalReport.SetParameters(new ReportParameter[] { tu });
                    //rpv_baocao.LocalReport.SetParameters(new ReportParameter[] { den });
                    //rpv_baocao.LocalReport.SetParameters(new ReportParameter[] { tungay });
                    //rpv_baocao.LocalReport.SetParameters(new ReportParameter[] { denngay });
                    rpv_baocao.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không Có Dữ Liệu!");
                    BaoCaoF bcf = new BaoCaoF();
                    bcf.Hide();
                }
            }

            if (keyn == 2)
            {
                SqlConnection con = new SqlConnection();
                string sql = @"Data Source=TRANG\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True";
                con.ConnectionString = sql;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BCX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENNV", TenNv));
                cmd.Parameters.Add(new SqlParameter("@TENSP", TenSp));
                cmd.Parameters.Add(new SqlParameter("@TENKH", TenNcc_Kh));
                cmd.Parameters.Add(new SqlParameter("@TENKHO", TenKho));
                cmd.Parameters.Add(new SqlParameter("@NGAYXUAT", NgayNh_Xu));
                cmd.Parameters.Add(new SqlParameter("@GIA", Gia));
                cmd.Parameters.Add(new SqlParameter("@TUNGAY", TuNgay));
                cmd.Parameters.Add(new SqlParameter("@DENNGAY", DenNgay));
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                rpv_baocao.ProcessingMode = ProcessingMode.Local;
                rpv_baocao.LocalReport.ReportPath = "BaoCaoXuat.rdlc";
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "BaoCaoXuat";
                    rds.Value = ds.Tables[0];
                    rpv_baocao.LocalReport.DataSources.Clear();
                    rpv_baocao.LocalReport.DataSources.Add(rds);
                    rpv_baocao.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không Có Dữ Liệu!");
                    BaoCaoF bcf = new BaoCaoF();
                    bcf.Hide();
                }
            }
            if (keyn == 3)
            {
                SqlConnection con = new SqlConnection();
                string sql = @"Data Source=TRANG\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True";
                con.ConnectionString = sql;
                con.Open();
                acc.OpenConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "HOADONBANHANG";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAPX", MAPX));
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                rpv_baocao.ProcessingMode = ProcessingMode.Local;
                rpv_baocao.LocalReport.ReportPath = "HoaDonBanHang.rdlc";
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "HoaDonBanHang";
                    rds.Value = ds.Tables[0];
                    rpv_baocao.LocalReport.DataSources.Clear();
                    rpv_baocao.LocalReport.DataSources.Add(rds);
                    rpv_baocao.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không Có Dữ Liệu!");
                    BaoCaoF bcf = new BaoCaoF();
                    bcf.Hide();
                }
            }
            if (keyn == 4)
            {
                SqlConnection con = new SqlConnection();
                string sql = @"Data Source=TRANG\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True";
                con.ConnectionString = sql;
                con.Open();
                acc.OpenConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "HOADONMUAHANG";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAPN", MAPN));
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                rpv_baocao.ProcessingMode = ProcessingMode.Local;
                rpv_baocao.LocalReport.ReportPath = "PhieuNhapKho.rdlc";
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "PhieuNhapKho";
                    rds.Value = ds.Tables[0];
                    rpv_baocao.LocalReport.DataSources.Clear();
                    rpv_baocao.LocalReport.DataSources.Add(rds);
                    rpv_baocao.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không Có Dữ Liệu!");
                    BaoCaoF bcf = new BaoCaoF();
                    bcf.Hide();
                }
            }
        }
    }
}
