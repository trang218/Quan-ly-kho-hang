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
    public partial class Luong : Form
    {
        public Luong()
        {
            InitializeComponent();
            tbx_Manv.Focus();
        }
        accessData acc = new accessData();
        SqlDataAdapter sdaL;
        SqlConnection con;
        DataSet ds;
        DataView dv;

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu Menu = new MainMenu();
            Menu.ShowDialog();
        }

        private void Luong_Load(object sender, EventArgs e)
        {
            acc.AutoComplete(tbx_Manv, "SELECT MANV FROM NHANVIEN");

            dgvLuong.DataSource = acc.Select_Data("Select MANV, TENNV, NS, GT, LUONG from NHANVIEN");
            dgvLuong.ClearSelection();
        }
       
        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbx_Manv.Text = (dgvLuong.CurrentRow.Cells["MANV"].Value.ToString());
                tbx_luong.Text = (dgvLuong.CurrentRow.Cells["LUONG"].Value.ToString());
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dgvLuong.BeginEdit(true);
            if (tbx_Manv.Text.Trim() == "" || tbx_luong.Text.Trim() == "")
            {
                MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin!,", "Thông Báo!");
                tbx_Manv.Focus();
            }
            else
            {
                acc.CapNhat_Luong(tbx_Manv.Text,float.Parse(tbx_luong.Text));
                dgvLuong.DataSource = acc.Select_Data("Select MANV, TENNV, NS, GT, LUONG from NHANVIEN");
                tbx_Manv.Clear();
                tbx_luong.Clear();
                dgvLuong.ClearSelection();
            }
            dgvLuong.EndEdit();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (tbx_Manv.Text.Trim() == "" || dgvLuong.SelectedRows == null)
            {
                MessageBox.Show("Hãy Nhập Mã Nhân Viên Muốn Xóa Hoặc Chọn Dòng Muốm Xóa!,", "Cảnh Báo!");
                tbx_Manv.Focus();
            }
            else
            {
                acc.Xoa_TaiKhoan(tbx_Manv.Text);
                dgvLuong.DataSource = acc.Select_Data("Select MANV, TENNV, NS, GT, LUONG from NHANVIEN");
                tbx_Manv.Clear();
                tbx_luong.Clear();
                dgvLuong.ClearSelection();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text.Trim() == "")
            {
                MessageBox.Show("Đề Nghị Bạn Nhập Từ Khóa Càn Tìm!", "Thông Báo!");
                return;
            }
            else
            {
                dgvLuong.DataSource = acc.Select_Data("Select  * from NHANVIEN Where TENNV like '%" + tbx_timkiem.Text + "%' OR LUONG like '%" + tbx_timkiem.Text + "%' ");
                dgvLuong.ClearSelection();
                tbx_timkiem.Clear()
;            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            dgvLuong.DataSource = acc.Select_Data("Select MANV, TENNV, NS, GT, LUONG from NHANVIEN");
            dgvLuong.ClearSelection();
        }
    }
}
