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
    public partial class MainMenu : Form
    {
        public static string Quyenhan = "";
        public MainMenu()
        {
            InitializeComponent();
            userNamemenu.Text = Quyenhan;
        }

        private void btn_nhanv_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVIen nhanvien = new NhanVIen();
            nhanvien.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhapHeThong DN = new DangNhapHeThong();
            DN.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Phải là ADMIN thì mới đổi được mật khẩu cho tài khoản khác!");
            Doimatkhau dmk = new Doimatkhau();
            dmk.ShowDialog();
        }
        

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NguoiDung ND = new NguoiDung();
            ND.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            NhanVIen.QUYENHD = Quyenhan.Trim();
            BoPhan.QUYENHD = Quyenhan.Trim();
            ThemTaiKhoan.QUYENHD = Quyenhan.Trim();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCao BC = new BaoCao();
            BC.ShowDialog();
        }

        private void btn_danhmuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhMucSP DMSP = new DanhMucSP();
            DMSP.ShowDialog();
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            this.Hide();
            BoPhan bophan = new BoPhan();
            bophan.ShowDialog();
        }

        private void btn_nhacc_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCC nhacc = new NhaCC();
            nhacc.ShowDialog();
        }
        
        private void btn_khohang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHang kho = new KhoHang();
            kho.ShowDialog();
        }

        private void btn_xuatnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapXuat nhapxuat = new NhapXuat();
            nhapxuat.ShowDialog();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang khachhang = new KhachHang();
            khachhang.ShowDialog();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void đổiQuyềnHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                DoiQuyen quyen = new DoiQuyen();
                quyen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới thực hiện được thao tác này!");
            }     
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            this.Hide();
            SANPHAM sanpham = new SANPHAM();
            sanpham.ShowDialog();
        }
    }
}
