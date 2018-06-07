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
    public partial class NhaCC : Form
    {
        public NhaCC()
        {
            InitializeComponent();
        }
        accessData acc = new accessData();
        public int key = 0;

        public void ClearText()
        {
            tbx_MaNCC.Clear();
            tbx_TenNCC.Clear();
            tbx_Diachi.Clear();
            tbx_Ghichu.Clear();
            tbx_MaNCC.Focus();
            dgv_nhacungcap.ClearSelection();
            tbx_MaNCC.Enabled = false;
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void NhaCC_Load(object sender, EventArgs e)
        {
            acc.AutoComplete(tbx_MaNCC, "SELECT MANCC FROM NHACUNGCAP");
            dgv_nhacungcap.DataSource = acc.Select_Data("SELECT * FROM NHACUNGCAP");
            ClearText();
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            tbx_Diachi.Enabled = false;
            tbx_Ghichu.Enabled = false;
            tbx_MaNCC.Enabled = false;
            tbx_TenNCC.Enabled = false;
            btn_ghinhan.Enabled = false;
            btn_mo.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ClearText();
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            tbx_Diachi.Enabled = true;
            tbx_Ghichu.Enabled = true;
            tbx_MaNCC.Enabled = false;
            tbx_TenNCC.Enabled = true;
            btn_ghinhan.Enabled = true;
            btn_mo.Enabled = true;
            key = 1;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            tbx_Diachi.Enabled = false;
            tbx_Ghichu.Enabled = false;
            tbx_MaNCC.Enabled = true;
            tbx_TenNCC.Enabled = false;
            btn_ghinhan.Enabled = true;
            btn_mo.Enabled = false;
            key = 3;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            tbx_Diachi.Enabled = true;
            tbx_Ghichu.Enabled = true;
            tbx_MaNCC.Enabled = false;
            tbx_TenNCC.Enabled = true;
            btn_ghinhan.Enabled = true;
            btn_mo.Enabled = false;
            key = 2;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            NhaCC_Load(sender, e);
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
                dgv_nhacungcap.DataSource = acc.Select_Data("Select  * from NHACUNGCAP Where MANCC like N'%" + tbx_timkiem.Text + "%' OR TENNHACC like N'%" + tbx_timkiem.Text + "%' OR DIACHI like N'%" + tbx_timkiem.Text + "%'");
                tbx_timkiem.Clear();
                dgv_nhacungcap.ClearSelection();
            }
        }

        private void dgv_nhacungcap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                btn_xoa_Click(sender, e);
            }
        }

        private void dgv_nhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbx_MaNCC.Text = dgv_nhacungcap.CurrentRow.Cells["MANCC"].Value.ToString().Trim();
                tbx_TenNCC.Text = dgv_nhacungcap.CurrentRow.Cells["TENNHACC"].Value.ToString().Trim();
                tbx_Diachi.Text = dgv_nhacungcap.CurrentRow.Cells["DIACHI"].Value.ToString().Trim();
                tbx_Ghichu.Text = dgv_nhacungcap.CurrentRow.Cells["GHICHU"].Value.ToString().Trim();
            }
        }

        private void btn_mo_Click(object sender, EventArgs e)
        {
            tbx_MaNCC.Enabled = true;
            tbx_MaNCC.Focus();
        }

        private void NhaCC_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                if (tbx_TenNCC.Text.Trim() == "" || tbx_Diachi.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin!,", "Thông Báo!");
                    tbx_MaNCC.Focus();
                }
                else
                {
                    DataTable dtncc = new DataTable();
                    dtncc = acc.CheckSql("select * from NHACUNGCAP where MANCC ='" + tbx_MaNCC.Text + "'");
                    if (dtncc.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã Nhà Cung Cấp đã tồn tại!", "Lỗi");
                        tbx_MaNCC.Clear();
                        tbx_MaNCC.Focus();
                    }
                    else
                    {
                        if (tbx_TenNCC.Text == dgv_nhacungcap.CurrentRow.Cells["TENNHACC"].Value.ToString().Trim() && tbx_Ghichu.Text == dgv_nhacungcap.CurrentRow.Cells["GHICHU"].Value.ToString().Trim() && tbx_Diachi.Text == dgv_nhacungcap.CurrentRow.Cells["DIACHI"].Value.ToString().Trim())
                        {
                            MessageBox.Show("Toàn Bộ Thông Tin Nhà Cung Cấp Đã Tồn Tại. Vui Lòng Sủa Lại!", "Thông Báo!");
                        }
                        else
                        {
                            if (MessageBox.Show("Bạn Chắc Chắn Muốn Thêm Nhà Cung Cấp Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                acc.Them_NhaCC(tbx_MaNCC.Text, tbx_TenNCC.Text, tbx_Diachi.Text, tbx_Ghichu.Text);
                                NhaCC_Load(sender, e);
                                MessageBox.Show("Thêm Thành Công!", "Thông Báo!");
                            }
                            else
                            {

                            }
                        }
                    }
                }

            }
            if (key == 2)
            {
                dgv_nhacungcap.BeginEdit(true);
                if (tbx_MaNCC.Text == "" || tbx_TenNCC.Text == "" || tbx_Diachi.Text == "")
                {
                    MessageBox.Show("Chọn Dòng Bạn Muốn Sửa và Hãy Nhập Đầy Đủ Thông Tin!", "Thông Báo!");
                    tbx_MaNCC.Focus();
                }
                else
                {
                    if (tbx_MaNCC.Text != dgv_nhacungcap.CurrentRow.Cells["MANCC"].Value.ToString().Trim() || tbx_MaNCC.Text == "")
                    {
                        MessageBox.Show("Mã Nhà Cung Cấp chưa được nhập hoặc đã bị thay đổi!", "Lỗi");
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn Chắc Chắn Muốn Sửa Nhà Cung Cấp Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            acc.CapNhat_NhaCC(tbx_MaNCC.Text, tbx_TenNCC.Text, tbx_Diachi.Text, tbx_Ghichu.Text);
                            NhaCC_Load(sender, e);
                            MessageBox.Show("Sửa Thành Công!", "Thông Báo!");
                        }
                        else
                        {

                        }
                    }
                }
                dgv_nhacungcap.EndEdit();
            }
            if (key == 3)
            {
                if (tbx_MaNCC.Text.Trim() == "" || dgv_nhacungcap.SelectedRows == null)
                {
                    MessageBox.Show("Hãy Nhập Mã Nhà Cung Cấp Muốn Xóa Hoặc Chọn Dòng Muốm Xóa!,", "Cảnh Báo!");
                    tbx_MaNCC.Focus();
                }
                else
                {
                    DataTable dtsp = new DataTable();
                    dtsp = acc.CheckSql("select * from SANPHAM where MANCC ='" + tbx_MaNCC.Text + "'");
                    DataTable dtnk = new DataTable();
                    dtnk = acc.CheckSql("select * from PHIEUNHAPKHO where MANCC ='" + tbx_MaNCC.Text + "'");
                    if (dtsp.Rows.Count > 0 || dtnk.Rows.Count > 0 /* || tbx_MaBP.Text != dgv_BoPhan.CurrentRow.Cells["MABP"].Value.ToString().Trim() */)
                    {
                        MessageBox.Show("Mã Nhà Cung Cấp đã bị thay đổi Hoặc Mã Nhà Cung Cấp Đang Tốn Tại Ơ Bảng Sản Phẩm, Phiếu Xuất. Vui Lòng Xóa MANCC ở Bảng Sản Phẩm, Phiếu Xuất Trước Khi Thực Hiện Tao Tác!", "Lỗi");
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Nhà Cung Cấp Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            acc.Xoa_NhaCC(tbx_MaNCC.Text);
                            MessageBox.Show("Xóa Thành Công!", "Thông Báo!");
                            NhaCC_Load(sender, e);
                        }
                        else
                        {

                        }
                    }
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Hủy ?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearText();
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                tbx_Diachi.Enabled = false;
                tbx_Ghichu.Enabled = false;
                tbx_MaNCC.Enabled = false;
                tbx_TenNCC.Enabled = false;
                btn_ghinhan.Enabled = false;
                btn_mo.Enabled = false;
            }
        }
    }
}
