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
    public partial class BoPhan : Form
    {
        public BoPhan()
        {
            InitializeComponent();
        }
        accessData acc = new accessData();
        private int key = 0;
        private string MAKHO;
        private string MANV;
        public static string QUYENHD;

        public DataTable ThongTinMaKho(string TEXT)
        {
            accessData acc = new accessData();
            SqlDataReader a = acc.ExecuteReader("Select MAKHO FROM KHOHANG WHERE TENKHO LIKE N'"+ TEXT +"'");
            while (a.Read())
            {
                MAKHO = a["MAKHO"].ToString().Trim();
            }
            return null;
        }

        public DataTable ThongTinMaNV(string TEXT)
        {
            accessData acc = new accessData();
            SqlDataReader a = acc.ExecuteReader("Select MANV FROM NHANVIEN WHERE TENNV LIKE N'" + TEXT + "'");
            while (a.Read())
            {
                MANV = a["MANV"].ToString().Trim();
            }
            return null;
        }
        public void ClearText()
        {
            tbx_MaBP.Clear();
            tbx_TenBP.Clear();
            tbx_Dienthoai.Clear();
            tbx_MaKho.ResetText();
            tbx_NQL.ResetText();
            dgv_BoPhan.ClearSelection();
            tbx_MaBP.Focus();
        }

        private void Disabletbx()
        {
            tbx_MaBP.Enabled = false;
            tbx_MaKho.Enabled = false;
            tbx_NQL.Enabled = false;
            tbx_TenBP.Enabled = false;
            tbx_Dienthoai.Enabled = false;
        }

        private void Enabletbx()
        {
            tbx_MaBP.Enabled = true;
            tbx_MaKho.Enabled = true;
            tbx_NQL.Enabled = true;
            tbx_TenBP.Enabled = true;
            tbx_Dienthoai.Enabled = true;
        }

        private void Disablebtn()
        {
            btn_sua.Enabled = false;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_ghinhan.Enabled = true;
        }

        private void Enablebtn()
        {
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            btn_ghinhan.Enabled = false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            key = 1;
            Disablebtn();
            Enabletbx();
            tbx_MaBP.Enabled = false;
            btn_mo.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            key = 2;
            Disablebtn();
            Enabletbx();
            tbx_MaBP.Enabled = false;
            btn_mo.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            key = 3;
            Disablebtn();
            Disabletbx();
            tbx_MaBP.Enabled = true;
            btn_mo.Enabled = false;
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
                dgv_BoPhan.DataSource = acc.Select_Data("SELECT BOPHAN.MABP, TENBP, BOPHAN.DIENTHOAI, TENKHO, TENNV FROM BOPHAN left join NHANVIEN on BOPHAN.NQL = NHANVIEN.MANV left join KHOHANG on BOPHAN.MAKHO = KHOHANG.MAKHO WHERE ( BOPHAN.MABP like N'%" + tbx_timkiem.Text + "%' OR TENBP like N'%" + tbx_timkiem.Text + "%' OR BOPHAN.DIENTHOAI like N'%" + tbx_timkiem.Text + "%' OR TENKHO like N'%" + tbx_timkiem.Text + "%' OR TENNV like N'%" + tbx_timkiem.Text + "%')");
                tbx_timkiem.Clear();
                dgv_BoPhan.ClearSelection();
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            BoPhan_Load(sender, e);
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void BoPhan_Load(object sender, EventArgs e)
        {
            Disabletbx();
            Enablebtn();
            btn_mo.Enabled = false;
            acc.AutoComplete(tbx_MaBP, "SELECT MABP FROM BOPHAN");
            acc.AutoCompletecbx(tbx_MaKho, "SELECT TENKHO FROM KHOHANG", "TENKHO");
            acc.AutoCompletecbx(tbx_NQL, "SELECT TENNV FROM NHANVIEN", "TENNV");

            dgv_BoPhan.DataSource = acc.Select_Data("SELECT BOPHAN.MABP, TENBP, BOPHAN.DIENTHOAI, TENKHO, TENNV FROM BOPHAN left join NHANVIEN on BOPHAN.NQL = NHANVIEN.MANV left join KHOHANG on BOPHAN.MAKHO = KHOHANG.MAKHO");

            dgv_BoPhan.Columns["MABP"].Width = 80;
            dgv_BoPhan.Columns["TENBP"].Width = 150;
            dgv_BoPhan.Columns["DIENTHOAI"].Width = 120;
            dgv_BoPhan.Columns["TENKHO"].Width = 145;
            dgv_BoPhan.Columns["TENNV"].Width = 150;

            dgv_BoPhan.Columns["MABP"].HeaderText = "Mã BP";
            dgv_BoPhan.Columns["DIENTHOAI"].HeaderText = "Điện Thoại";
            dgv_BoPhan.Columns["TENKHO"].HeaderText = "Kho";
            dgv_BoPhan.Columns["TENNV"].HeaderText = "Nhân Viên";
            dgv_BoPhan.Columns["TENBP"].HeaderText = "Bộ Phận";
            
            dgv_BoPhan.ClearSelection();
            ClearText();

            if (QUYENHD == "ADMIN" || QUYENHD == "Admin" || QUYENHD == "admin")
            {
                btn_xoa.Enabled = true;
            }
            else
            {
                btn_xoa.Enabled = false;
            }
        }

        private void dgv_BoPhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                btn_xoa_Click(sender, e);
            }
        }

        private void btn_mo_Click(object sender, EventArgs e)
        {
            tbx_MaBP.Enabled = true;
            tbx_MaBP.Focus();
        }

        private void dgv_BoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbx_MaBP.Text = dgv_BoPhan.CurrentRow.Cells["MABP"].Value.ToString().Trim();
                tbx_TenBP.Text = dgv_BoPhan.CurrentRow.Cells["TENBP"].Value.ToString().Trim();
                tbx_Dienthoai.Text = dgv_BoPhan.CurrentRow.Cells["DIENTHOAI"].Value.ToString().Trim();
                tbx_MaKho.Text = dgv_BoPhan.CurrentRow.Cells["TENKHO"].Value.ToString().Trim();
                tbx_NQL.Text = dgv_BoPhan.CurrentRow.Cells["TENNV"].Value.ToString().Trim();
            }
        }

        private void BoPhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            if(key == 1)
            {
                if (tbx_TenBP.Text.Trim() == "" || tbx_Dienthoai.Text.Trim() == "" || tbx_MaKho.Text.Trim() == "" || tbx_NQL.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin!", "Thông Báo!");
                    tbx_MaBP.Focus();
                }
                else
                {
                    var itemnv = tbx_NQL.GetItemText(tbx_NQL.SelectedItem);
                    ThongTinMaNV(itemnv);
                    var itemkho = tbx_MaKho.GetItemText(tbx_MaKho.SelectedItem);
                    ThongTinMaKho(itemkho);
                    DataTable dtkho = new DataTable();
                    DataTable dtbp = new DataTable();
                    DataTable dtnql = new DataTable();
                    DataTable dttbp = new DataTable();
                    dtnql = acc.CheckSql("select * from NHANVIEN where TENNV like N'" + itemnv + "'");
                    dtkho = acc.CheckSql("select * from KHOHANG where TENKHO like N'" + itemkho + "'");
                    dtbp = acc.CheckSql("select * from BOPHAN where MABP ='" + tbx_MaBP.Text + "'");
                    dttbp = acc.CheckSql("select * from BOPHAN where TENBP like N'" + tbx_TenBP.Text + "'");
                    if (dtbp.Rows.Count > 0 || dttbp.Rows.Count > 0)
                    {
                        MessageBox.Show("Bộ Phận đã tồn tại!", "Lỗi");
                        tbx_MaBP.Clear();
                        tbx_MaBP.Focus();
                    }
                    else if (dtkho.Rows.Count < 1)
                    {
                        MessageBox.Show("Kho Hàng không tồn tại!", "Lỗi");
                        tbx_MaKho.ResetText();
                    }
                    else if (dtnql.Rows.Count < 1)
                    {
                        MessageBox.Show("Người Quản Lý không tồn tại!", "Lỗi");
                        tbx_NQL.ResetText();
                    }
                    else
                    {
                        if (tbx_MaBP.Text == dgv_BoPhan.CurrentRow.Cells["MABP"].Value.ToString() && tbx_TenBP.Text == dgv_BoPhan.CurrentRow.Cells["TENBP"].Value.ToString().Trim() && tbx_MaKho.Text == dgv_BoPhan.CurrentRow.Cells["TENKHO"].Value.ToString().Trim() && tbx_NQL.Text == dgv_BoPhan.CurrentRow.Cells["TENNV"].Value.ToString().Trim() && tbx_Dienthoai.Text == dgv_BoPhan.CurrentRow.Cells["DIENTHOAI"].Value.ToString().Trim())
                        {
                            MessageBox.Show("Toàn Bộ Thông Tin Bộ Phận Đã Tồn Tại. Vui Lòng Sủa Lại!", "Thông Báo!");
                        }
                        else
                        {
                            acc.Them_BoPhan(tbx_MaBP.Text, tbx_TenBP.Text, tbx_Dienthoai.Text, MAKHO, MANV);
                            BoPhan_Load(sender, e);
                            MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                        }
                    }
                }
            }
            if (key == 2)
            {
                dgv_BoPhan.BeginEdit(true);
                if (tbx_MaBP.Text.Trim() == "" || tbx_NQL.Text.Trim() == "" || tbx_MaKho.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin Hoặc Chọn Dòng Bạn Muốn Sửa. Tối Thiểu MABP + MAKHO + NQL!", "Thông Báo!");
                    tbx_MaBP.Focus();
                }
                else
                {
                    var itemnv = tbx_NQL.GetItemText(tbx_NQL.SelectedItem);
                    ThongTinMaNV(itemnv);
                    var itemkho = tbx_MaKho.GetItemText(tbx_MaKho.SelectedItem);
                    ThongTinMaKho(itemkho);
                    DataTable dtkho = new DataTable();
                    DataTable dtnql = new DataTable();
                    dtnql = acc.CheckSql("select * from NHANVIEN where TENNV like N'" + itemnv + "'");
                    dtkho = acc.CheckSql("select * from KHOHANG where TENKHO like N'" + itemkho + "'");
                    if (tbx_MaBP.Text != dgv_BoPhan.CurrentRow.Cells["MABP"].Value.ToString().Trim())
                    {
                        MessageBox.Show("Mã Bộ Phận đã bị thay đổi!", "Lỗi");
                        tbx_MaBP.Text = dgv_BoPhan.CurrentRow.Cells["MABP"].Value.ToString().Trim();
                    }
                    else if (dtkho.Rows.Count < 1)
                    {
                        MessageBox.Show("Kho Hàng không tồn tại!", "Lỗi");
                        tbx_NQL.Text = dgv_BoPhan.CurrentRow.Cells["TENNV"].Value.ToString().Trim();
                        tbx_MaKho.Text = dgv_BoPhan.CurrentRow.Cells["TENKHO"].Value.ToString().Trim();
                    }
                    else if (dtnql.Rows.Count < 1)
                    {
                        MessageBox.Show("Người Quản Lý không tồn tại!", "Lỗi");
                        tbx_NQL.Text = dgv_BoPhan.CurrentRow.Cells["TENNV"].Value.ToString().Trim();
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn Chắc Chắn Muốn Sửa Bộ Phận Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            acc.CapNhat_BoPhan(tbx_MaBP.Text, tbx_TenBP.Text, tbx_Dienthoai.Text, MAKHO, MANV);
                            MessageBox.Show("Sửa Thành Công!", "Thông Báo");
                            BoPhan_Load(sender, e);
                        }
                        else
                        {

                        }
                    }
                }
                dgv_BoPhan.EndEdit();
            }
            if (key == 3)
            {
                if (tbx_MaBP.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Mã Bộ Phận Hoặc Chọn Dòng Bạn Muốn Xóa!", "Thông Báo!");
                    tbx_MaBP.Focus();
                }
                else
                {
                    DataTable dtnv = new DataTable();
                    dtnv = acc.CheckSql("select * from NHANVIEN where MABP ='" + tbx_MaBP.Text + "'");
                    if (dtnv.Rows.Count > 0 )
                    {
                        if(MessageBox.Show("Bộ Phận Đang Tốn Tại Ơ Bảng Nhân Viên! Bạn Chắc Chắn Muốn Xóa!Toàn Bộ Thông Tin Liên Quan Đến Bộ Phận Sẽ Chuyển Về Default!", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            acc.CheckSql("Update NHANVIEN SET MABP = null WHERE MABP = '" + tbx_MaBP.Text + "'");
                            acc.Xoa_BoPhan(tbx_MaBP.Text);
                            MessageBox.Show("Xóa Thành Công!", "Thông Báo");
                            BoPhan_Load(sender, e);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Bộ Phận Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            acc.Xoa_BoPhan(tbx_MaBP.Text);
                            MessageBox.Show("Xóa Thành Công!", "Thông Báo");
                            BoPhan_Load(sender, e);
                        }
                        else
                        {

                        }
                    }
                }
            }
        }
    }
}
