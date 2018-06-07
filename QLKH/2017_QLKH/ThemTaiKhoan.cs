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
    public partial class ThemTaiKhoan : Form
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }
        public static string Username = "";
        private static int key = 0;
        accessData acc = new accessData();
        private string MaNV;
        public static string QUYENHD;

        public DataTable ThongTinMANV(string TENNV)
        {
            accessData acc = new accessData();
            SqlDataReader a = acc.ExecuteReader("Select MANV FROM NHANVIEN WHERE TENNV like N'" + TENNV + "'");
            while (a.Read())
            {
                MaNV = a["MANV"].ToString().Trim();
            }
            return null;
        }

        public void Disabletbx()
        {
            tbx_MaNV.Enabled = false;
            tbx_MK.Enabled = false;
            tbx_TDN.Enabled = false;
            tbx_QuyenHan.Enabled = false;
        }

        public void Disablebtn()
        {
            btn_ghinhan.Enabled = true;
            bt_Sua.Enabled = false;
            bt_xoa.Enabled = false;
            bt_them.Enabled = false;
        }

        public void Enablebtn()
        {
            bt_Sua.Enabled = true;
            bt_xoa.Enabled = true;
            bt_them.Enabled = true;
            btn_ghinhan.Enabled = false;
        }

        public void Enabletbx()
        {
            tbx_MaNV.Enabled = true;
            tbx_MK.Enabled = true;
            tbx_TDN.Enabled = true;
            tbx_QuyenHan.Enabled = true;
        }

        public void Cleartbx()
        {
            tbx_MaNV.ResetText();
            tbx_MK.Clear();
            tbx_QuyenHan.Clear();
            tbx_TDN.Clear();
        }
        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            Disabletbx();
            acc.AutoCompletecbx(tbx_MaNV, "Select TENNV from NHANVIEN", "TENNV");
            acc.AutoComplete(tbx_QuyenHan, "SELECT QUYENHAN FROM DANGNHAP");
            tbx_MaNV.SelectedIndex = -1;

            dgvThemTK.DataSource = acc.Select_Data("Select USERNAME, PASSWORD, TENNV, QUYENHAN from DANGNHAP, NHANVIEN WHERE DANGNHAP.MANV = NHANVIEN.MANV");
            dgvThemTK.ClearSelection();
            // INSERT

            //Dộ rộng cột
            dgvThemTK.Columns[0].Width = 105;
            dgvThemTK.Columns[1].Width = 105;
            dgvThemTK.Columns[2].Width = 145;
            dgvThemTK.Columns[3].Width = 130;

            dgvThemTK.Columns["USERNAME"].HeaderText = "Tên Đăng Nhập";
            dgvThemTK.Columns["PASSWORD"].HeaderText = "Mật Khẩu";
            dgvThemTK.Columns["TENNV"].HeaderText = "Tên Nhân Viên";
            dgvThemTK.Columns["QUYENHAN"].HeaderText = "Quyền Hạn";

            Enablebtn();
            Disabletbx();
            Cleartbx();
            if (QUYENHD == "ADMIN" || QUYENHD == "Admin" || QUYENHD == "admin")
            {
                bt_xoa.Enabled = true;
            }
            else
            {
                bt_xoa.Enabled = false;
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Enabletbx();
            Disablebtn();
            key = 1;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            Enabletbx();
            Disablebtn();
            tbx_MaNV.Enabled = false;
            tbx_TDN.Enabled = false;
            key = 2;
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            Enabletbx();
            Disablebtn();
            tbx_MaNV.Enabled = false;
            tbx_QuyenHan.Enabled = false;
            tbx_MK.Enabled = false;
            key = 3;
        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text.Trim() == "")
            {
                MessageBox.Show("Đề Nghị Bạn Nhập Từ Khóa Càn Tìm!", "Thông Báo!");
                return;
            }
            else
            {
                dgvThemTK.DataSource = acc.Select_Data("Select USERNAME, PASSWORD, TENNV, QUYENHAN from DANGNHAP, NHANVIEN WHERE DANGNHAP.MANV = NHANVIEN.MANV and (USERNAME like '%" + tbx_timkiem.Text + "%' OR PASSWORD like '%" + tbx_timkiem.Text + "%' OR TENNV like N'%" + tbx_timkiem.Text + "%' OR QUYENHAN like '%" + tbx_timkiem.Text + "%')");
                tbx_timkiem.Clear();
                dgvThemTK.ClearSelection();
            }
        }

        private void bt_lammoi_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan_Load(sender, e);
        }

        private void dgvThemTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbx_TDN.Text = dgvThemTK.CurrentRow.Cells["USERNAME"].Value.ToString().Trim();
                tbx_MK.Text = dgvThemTK.CurrentRow.Cells["PASSWORD"].Value.ToString().Trim();
                tbx_MaNV.Text = dgvThemTK.CurrentRow.Cells["TENNV"].Value.ToString().Trim();
                tbx_QuyenHan.Text = dgvThemTK.CurrentRow.Cells["QUYENHAN"].Value.ToString().Trim();
            }
        }

        private void dgvThemTK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                key = 3;
                btn_ghinhan_Click(sender, e);
            }
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                if (tbx_TDN.Text.Trim() == "" || tbx_MK.Text.Trim() == "" || tbx_QuyenHan.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin!,", "Thông Báo!");
                    tbx_TDN.Focus();
                }
                else
                {
                    var item = tbx_MaNV.GetItemText(tbx_MaNV.SelectedItem);
                    ThongTinMANV(item);
                    DataTable dttk = new DataTable();
                    dttk = acc.CheckSql("select * from DANGNHAP where USERNAME ='" + tbx_TDN.Text + "'");
                    DataTable dtnv = new DataTable();
                    dtnv = acc.CheckSql("select * from NHANVIEN where TENNV Like N'" + item + "'");
                    if (dttk.Rows.Count > 0)
                    {
                        MessageBox.Show("Tài Khoản đã tồn tại!", "Lỗi");
                        tbx_TDN.Clear();
                        tbx_TDN.Focus();
                    }
                    else if (dtnv.Rows.Count < 1)
                    {
                        MessageBox.Show("Nhân Viên không tồn tại!", "Lỗi");
                        tbx_MaNV.ResetText();
                    }
                    else
                    {
                        acc.Them_TaiKhoan(tbx_TDN.Text, tbx_MK.Text, MaNV, tbx_QuyenHan.Text);
                        tbx_MaNV.ResetText();
                        tbx_MK.Clear();
                        tbx_TDN.Clear();
                        tbx_QuyenHan.Clear();
                        ThemTaiKhoan_Load(sender, e);
                        MessageBox.Show("Thêm Thành Công!", "Thông Báo!");
                        dgvThemTK.ClearSelection();

                    }
                }
            }

            if (key == 2)
            {
                dgvThemTK.BeginEdit(true);
                if (tbx_TDN.Text.Trim() == "" || tbx_MK.Text.Trim() == "" || tbx_MaNV.Text.Trim() == "" || tbx_QuyenHan.Text.Trim() == "" || dgvThemTK.SelectedCells == null)
                {
                    MessageBox.Show("Chọn Dòng Bạn Muốn Sửa và Hãy Nhập Đầy Đủ Thông Tin!", "Thông Báo!");
                    tbx_TDN.Focus();
                }
                else
                {
                    var item = tbx_MaNV.GetItemText(tbx_MaNV.SelectedItem);
                    ThongTinMANV(item);
                    DataTable dtnv = new DataTable();
                    dtnv = acc.CheckSql("select * from NHANVIEN where TENNV like N'" + tbx_MaNV.Text + "'");
                    if (dtnv.Rows.Count < 1)
                    {
                        MessageBox.Show("Nhân Viên không tồn tại!", "Lỗi");
                        tbx_MaNV.Text = dgvThemTK.CurrentRow.Cells["TENNV"].Value.ToString().Trim();

                    }
                    else if (tbx_TDN.Text != dgvThemTK.CurrentRow.Cells["USERNAME"].Value.ToString().Trim())
                    {
                        MessageBox.Show("Tên Đăng Nhập đã bị thay đổi!", "Lỗi");
                        tbx_TDN.Text = dgvThemTK.CurrentRow.Cells["USERNAME"].Value.ToString().Trim();

                    }
                    else
                    {
                        if (tbx_MaNV.Text == dgvThemTK.CurrentRow.Cells["TENNV"].Value.ToString() &&
                            tbx_MK.Text == dgvThemTK.CurrentRow.Cells["PASSWORD"].Value.ToString().Trim() &&
                            tbx_TDN.Text == dgvThemTK.CurrentRow.Cells["USERNAME"].Value.ToString().Trim() &&
                            tbx_QuyenHan.Text == dgvThemTK.CurrentRow.Cells["QUYENHAN"].Value.ToString().Trim())
                        {
                            MessageBox.Show("Toàn Bộ Thông Tin Kho Hàng Đã Tồn Tại. Vui Lòng Sủa Lại!", "Thông Báo!");
                        }
                        else
                        {
                            acc.CapNhat_TaiKhoan(tbx_TDN.Text, tbx_MK.Text, MaNV, tbx_QuyenHan.Text);
                            tbx_MaNV.ResetText();
                            tbx_MK.Clear();
                            tbx_TDN.Clear();
                            tbx_QuyenHan.Clear();
                            ThemTaiKhoan_Load(sender, e);
                            MessageBox.Show("Sủa Thành Công!", "Thông Báo!");
                            dgvThemTK.ClearSelection();
                        }
                    }
                }
                dgvThemTK.EndEdit();
            }

            if (key == 3)
            {
                if (Username != dgvThemTK.CurrentRow.Cells["USERNAME"].Value.ToString().Trim())
                {
                    if (tbx_TDN.Text.Trim() == "" || dgvThemTK.SelectedRows == null)
                    {
                        MessageBox.Show("Hãy Nhập Tên Đăng Nhập Muốn Xóa Hoặc Chọn Dòng Muốm Xóa!,", "Cảnh Báo!");
                        tbx_TDN.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa tài Khoản Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            acc.Xoa_TaiKhoan(tbx_TDN.Text);
                            tbx_MaNV.ResetText();
                            tbx_MK.Clear();
                            tbx_TDN.Clear();
                            tbx_QuyenHan.Clear();
                            ThemTaiKhoan_Load(sender, e);
                            MessageBox.Show("Xóa Thành Công!", "Thông Báo!");
                            dgvThemTK.ClearSelection();
                        }
                        else
                        {

                        }
                    }
                }

                else
                {
                    MessageBox.Show("Bạn Không Thể Xóa Tài Khoản Đang Đăng Nhập!");
                }
            }
        }
    }
}
