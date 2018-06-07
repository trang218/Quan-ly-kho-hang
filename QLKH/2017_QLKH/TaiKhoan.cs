using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_QLKH
{
    public partial class TaiKhoan : Form
    {
        public static string QUYENHAN = "";
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            NguoiDung nguoidung = new NguoiDung();
            nguoidung.ShowDialog();
        }

        private void btn_matkhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chỉ có quyền đổi mật khẩu cho chính bản thân mình nếu bạn là Nhân Viên!");
            this.Hide();
            Doimatkhau dmk = new Doimatkhau();
            dmk.ShowDialog();
        }

        private void btn_quyen_Click(object sender, EventArgs e)
        {
            if(QUYENHAN == "ADMIN     " || QUYENHAN == "Admin     " || QUYENHAN == "admin     ")
            {
                this.Hide();
                DoiQuyen doiquyen = new DoiQuyen();
                doiquyen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN Mới thực hiện được thao tác này!", "Thông Báo!");
            }
        }

        private void TaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }
    }
}
