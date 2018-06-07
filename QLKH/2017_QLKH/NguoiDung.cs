using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_QLKH
{
    public partial class NguoiDung : Form
    {
        accessData acc = new accessData();
        public static string QuyenHan = "";
        public static string TenDangNhap = "";
        public static string filepath = "";
        private string filename;
        private string filepaths;
        private string MaNV;
        public NguoiDung()
        {
            InitializeComponent();
        }
        public DataTable SelectThongTin(string TDN)
        {
            SqlDataReader a = acc.ExecuteReader("SELECT TENNV, NS, GT, DIENTHOAI, CHUCVU, HINHANH FROM NHANVIEN, DANGNHAP WHERE NHANVIEN.MANV = DANGNHAP.MANV AND DANGNHAP.USERNAME='" + TDN + "'");
            while (a.Read())
            {
                lbxNameUser.Text = a["TENNV"].ToString();
                string NS = a["NS"].ToString();
                DateTime dt = Convert.ToDateTime(NS);
                lbxNS.Text = dt.ToString("dd/MM/yyyy");
                lbxGT.Text = a["GT"].ToString();
                lbxDT.Text = a["DIENTHOAI"].ToString();
                lbxCV.Text = a["CHUCVU"].ToString();
                filename = a["HINHANH"].ToString();
                if (filename == null || filename == "")
                {
                    pc_nguoidung.Image = null;
                }
                else
                {
                    filepath = Application.StartupPath + "\\Images\\" + filename;
                    pc_nguoidung.Image = Image.FromFile(filepath.ToString());
                    pc_nguoidung.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
            return null;
        }

        public DataTable NV(string UN)
        {
            accessData acc = new accessData();
            SqlDataReader a = acc.ExecuteReader("SELECT MANV FROM DANGNHAP WHERE USERNAME='" + UN + "'");
            while (a.Read())
            {
                MaNV = a["MANV"].ToString().Trim();
            }
            return null;
        }
        private void NguoiDung_Load(object sender, EventArgs e)
        {
            lbxUserName.Text = TenDangNhap;
            SelectThongTin(TenDangNhap);
            pc_nguoidung.ImageLocation = filepath;
            pc_nguoidung.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_luu.Enabled = false;
        }


        private void btThemUser_Click(object sender, EventArgs e)
        {
            if (QuyenHan.Trim() == "ADMIN" || QuyenHan.Trim() == "Admin" || QuyenHan.Trim() == "admin")
            {
                ThemTaiKhoan Them = new ThemTaiKhoan();
                Them.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới thực hiện được thao tác này!");
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            filepaths = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            PictureBox objpt = new PictureBox();
            ofdImages.Title = "Chọn File Ảnh!";
            ofdImages.InitialDirectory = @"Documents";//Thư mục mặc định khi mở
            ofdImages.Filter = "All files (*.*)|*.*";// Lọc ra những file cần hiển thị
            ofdImages.FilterIndex = 1;//chúng ta có All files là 1,jpg là 2
            ofdImages.RestoreDirectory = true;
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                string filenameX = ofdImages.FileName;
                pc_nguoidung.Image = Image.FromFile(ofdImages.FileName);
                filename = Path.GetFileName(ofdImages.FileName);
                pc_nguoidung.SizeMode = PictureBoxSizeMode.StretchImage;
                filepath = Application.StartupPath + "\\Images\\" + filename;
                btn_luu.Enabled = true;
                if (!File.Exists(filenameX)) return;

                if (File.Exists(filepath))
                {

                }

                else
                    try
                    {
                        File.Copy(filenameX, filepath);
                    }
                    catch
                    {
                        MessageBox.Show("Đã phát sinh lỗi trong việc chọn ảnh upload, vui lòng kiểm tra lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                filename = "";
                pc_nguoidung.Image = null;
                btn_luu.Enabled = false;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (filepath.Length > 0)
            {
                NV(TenDangNhap);
                acc.CapNhat_NguoiDung(MaNV, filename);
                btn_luu.Enabled = false;
                filename = null;
            }

        }
    }
}
