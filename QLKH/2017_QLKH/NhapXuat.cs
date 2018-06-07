using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _2017_QLKH
{
    public partial class NhapXuat : Form
    {
        public NhapXuat()
        {
            InitializeComponent();
        }

        public DataTable data;
        int keyn = 0;
        int keyx = 0;
        accessData acc = new accessData();
        public static string filepart = "";
        private string NVNHAP;
        private string NVXUAT;
        private string MASPPN;
        private string MASPPX;
        private string MANCC;
        private string MAKH;
        private string MAKHOPN;
        private string MAKHOPX;
        public DataTable ThongTinNCC(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MANCC FROM NHACUNGCAP WHERE TENNHACC LIKE N'%" + TEXT + "%'");
            while (a.Read())
            {
                MANCC = a["MANCC"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinNVNHAP(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MANV FROM NHANVIEN WHERE TENNV LIKE N'%" + TEXT + "%'");
            while (a.Read())
            {
                NVNHAP = a["MANV"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinNVXUAT(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MANV FROM NHANVIEN WHERE TENNV LIKE N'%" + TEXT + "%'");
            while (a.Read())
            {
                NVXUAT = a["MANV"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinKH(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MAKH FROM KHACHHANG WHERE TENKH LIKE N'%" + TEXT + "%'");

            while (a.Read())
            {
                MAKH = a["MAKH"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinSPPN(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MASP FROM SANPHAM WHERE TENSP LIKE N'%" + TEXT + "%'");
            while (a.Read())
            {
                MASPPN = a["MASP"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinSPPX(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MASP FROM SANPHAM WHERE TENSP LIKE N'%" + TEXT + "%'");
            while (a.Read())
            {
                MASPPX = a["MASP"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinKHOPN(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MAKHO FROM KHOHANG WHERE TENKHO LIKE N'%" + TEXT + "%'");
            while (a.Read())
            {
                MAKHOPN = a["MAKHO"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinKHOPX(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MAKHO FROM KHOHANG WHERE TENKHO LIKE N'%" + TEXT + "%'");
            while (a.Read())
            {
                MAKHOPX = a["MAKHO"].ToString().Trim();
            }
            return null;
        }
        public void EnablePX()
        {
            txb_manvPX.Enabled = true;
            ngayxuat.Enabled = true;
            txb_maspPX.Enabled = true;
            txb_soluongPX.Enabled = true;
            txb_tongtienPX.Enabled = true;
            txb_makh.Enabled = true;
            txb_makhoPX.Enabled = true;
            txb_ghichuPX.Enabled = true;
        }
        public void DisablePX()
        {
            txb_manvPX.Enabled = false;
            ngayxuat.Enabled = false;
            txb_maspPX.Enabled = false;
            txb_soluongPX.Enabled = false;
            txb_tongtienPX.Enabled = false;
            txb_makh.Enabled = false;
            txb_makhoPX.Enabled = false;
            txb_ghichuPX.Enabled = false;
        }
        public void EnablePN()
        {
            txb_nvnhap.Enabled = true;
            ngaynhap.Enabled = true;
            txb_maspPN.Enabled = true;
            txb_soluongPN.Enabled = true;
            txb_tongtienPN.Enabled = true;
            txb_mancc.Enabled = true;
            txb_makhoPN.Enabled = true;
            txb_ghichu.Enabled = true;
        }
        public void DisablePN()
        {
            txb_nvnhap.Enabled = false;
            ngaynhap.Enabled = false;
            txb_maspPN.Enabled = false;
            txb_soluongPN.Enabled = false;
            txb_tongtienPN.Enabled = false;
            txb_mancc.Enabled = false;
            txb_makhoPN.Enabled = false;
            txb_ghichu.Enabled = false;
        }
        public void cleartextPN()
        {
            txb_nvnhap.Focus();
            tbx_maPN.Clear(); txb_ghichu.Clear(); txb_nvnhap.ResetText();
            txb_makhoPN.ResetText(); txb_timkiem_N.Clear();
            txb_tongtienPN.Clear();
            txb_soluongPN.Clear(); txb_mancc.ResetText(); txb_maspPN.ResetText();
        }
        public void autoWidth()
        {

        }
        public void cleartextPX()
        {
            txb_maPX.Clear();
            txb_manvPX.ResetText();
            txb_maspPX.ResetText();
            txb_soluongPX.Clear();
            txb_tongtienPX.Clear();
            txb_manvPX.Focus();
            txb_makh.ResetText();
            txb_makhoPX.ResetText();
            txb_ghichuPX.Clear();
            txb_timkiemPX.Clear();

        }
        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }
        private void NhapXuat_Load(object sender, EventArgs e)
        {
            acc.AutoCompletecbx(txb_nvnhap, "select TENNV from NHANVIEN", "TENNV");
            acc.AutoCompletecbx(txb_maspPN, "Select TENSP from SANPHAM", "TENSP");
            acc.AutoCompletecbx(txb_mancc, "SELECT TENNHACC FROM NHACUNGCAP", "TENNHACC");
            acc.AutoCompletecbx(txb_makhoPN, "SELECT TENKHO FROM KHOHANG", "TENKHO");
            acc.AutoCompletecbx(txb_manvPX, "select TENNV from NHANVIEN", "TENNV");
            acc.AutoCompletecbx(txb_maspPX, "Select TENSP from SANPHAM", "TENSP");
            acc.AutoCompletecbx(txb_makh, "select TENKH from KHACHHANG", "TENKH");
            acc.AutoCompletecbx(txb_makhoPX, "SELECT TENKHO FROM KHOHANG", "TENKHO");
            // 

            tbx_maPN.Text = ""; txb_maPX.Text = ""; DisablePN(); DisablePX();
            dgv_phieunhap.DataSource = acc.Select_Data("SELECT PN.MAPN, KHOHANG.TENKHO,NHANVIEN.TENNV,NGAYNHAP,NHACUNGCAP.TENNHACC,SANPHAM.TENSP,CT.SOLUONG,TONGTIEN,PN.GHICHU FROM PHIEUNHAPKHO PN left join NHACUNGCAP on NHACUNGCAP.MANCC = PN.MANCC left join KHOHANG on KHOHANG.MAKHO = PN.MAKHO left join NHANVIEN on NHANVIEN.MANV = PN.NVNHAP INNER JOIN CHITIETPHIEUNHAP CT ON PN.MAPN=CT.MAPN INNER join SANPHAM on SANPHAM.MASP = CT.MASP");
            dgv_phieuxuat.DataSource = acc.Select_Data("SELECT PX.MAPX, KHOHANG.TENKHO, NHANVIEN.TENNV,NGAYXUAT,KHACHHANG.TENKH,SANPHAM.TENSP,CT.SOLUONG,TONGTIEN,PX.GHICHU FROM PHIEUXUAT PX LEFT join NHANVIEN on NHANVIEN.MANV = PX.NVXUAT left join KHACHHANG on KHACHHANG.MAKH = PX.MAKH left join KHOHANG on KHOHANG.MAKHO = PX.MAKHO INNER JOIN CHITIETPHIEUXUAT CT ON PX.MAPX = CT.MAPX INNER join SANPHAM on SANPHAM.MASP = CT.MASP");

            cleartextPN();
            dgv_phieunhap.ClearSelection();
            autoWidth();

            // Hiển thị tên cột nhập hàng:

            dgv_phieunhap.Columns[0].HeaderText = "Mã Phiếu Nhập";
            dgv_phieunhap.Columns[1].HeaderText = "Tên Kho";
            dgv_phieunhap.Columns[2].HeaderText = "Tên Nhân Viên";
            dgv_phieunhap.Columns[3].HeaderText = "Ngày Nhập";
            dgv_phieunhap.Columns[4].HeaderText = "Tên Nhà Cung Cấp";
            dgv_phieunhap.Columns[5].HeaderText = "Tên Sản Phẩm";
            dgv_phieunhap.Columns[6].HeaderText = "Số lượng";
            dgv_phieunhap.Columns[7].HeaderText = "Tổng Tiền";
            dgv_phieunhap.Columns[8].HeaderText = "Ghi Chú";
            // căn chỉnh độ rộng cột:
            dgv_phieunhap.Columns[0].Width = 60;
            dgv_phieunhap.Columns[1].Width = 150;
            dgv_phieunhap.Columns[2].Width = 150;
            dgv_phieunhap.Columns[6].Width = 50;
            dgv_phieunhap.Columns[3].Width = 80;
            dgv_phieunhap.Columns[4].Width = 200;
            dgv_phieunhap.Columns[5].Width = 200;
            // Hiển Thị tên cột xuất hàng:
            dgv_phieuxuat.Columns[0].HeaderText = "Mã Phiếu Xuất";
            dgv_phieuxuat.Columns[1].HeaderText = "Tên kho";
            dgv_phieuxuat.Columns[2].HeaderText = "Nhân Viên Xuất";
            dgv_phieuxuat.Columns[3].HeaderText = "Ngày Xuất";
            dgv_phieuxuat.Columns[4].HeaderText = "Tên Khách Hàng";
            dgv_phieuxuat.Columns[5].HeaderText = "Tên Sản Phẩm";
            dgv_phieuxuat.Columns[6].HeaderText = "Số Lượng";
            dgv_phieuxuat.Columns[7].HeaderText = "Tổng Tiền";
            dgv_phieuxuat.Columns[8].HeaderText = "Ghi Chú";
            // can do rong cot:
            dgv_phieuxuat.Columns[0].Width = 60;
            dgv_phieuxuat.Columns[1].Width = 150;
            dgv_phieuxuat.Columns[2].Width = 150;
            dgv_phieuxuat.Columns[4].Width = 150;

            dgv_phieuxuat.Columns[5].Width = 150;
            dgv_phieuxuat.Columns[6].Width = 50;

            bt_xoa.Enabled = true;
            bt_them.Enabled = true;
            btn_themPX.Enabled = true;
            button_chophepsua.Enabled = true;
            btn_xoaPX.Enabled = true;
            btn_themPX.Enabled = true;
            btn_ghinhan.Enabled = false;
            btn_chophepsua.Enabled = true;
            btn_suaPX.Enabled = false;
            DisablePN();
            DisablePX();
            tbx_maPN.Enabled = false;
            txb_maPX.Enabled = false;
            textBox1.Enabled = false;
        }
        //hien thi danh sach xuat hang:
        private void dgv_phieuxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_maPX.Text = dgv_phieuxuat.CurrentRow.Cells["MAPX"].Value.ToString();
            txb_manvPX.Text = dgv_phieuxuat.CurrentRow.Cells["TENNV"].Value.ToString();

            ngayxuat.Text = dgv_phieuxuat.CurrentRow.Cells["NGAYXUAT"].Value.ToString().Trim();
            txb_maspPX.Text = dgv_phieuxuat.CurrentRow.Cells["TENSP"].Value.ToString().Trim();

            txb_soluongPX.Text = dgv_phieuxuat.CurrentRow.Cells["SOLUONG"].Value.ToString().Trim();
            txb_tongtienPX.Text = dgv_phieuxuat.CurrentRow.Cells["TONGTIEN"].Value.ToString();
            txb_makh.Text = dgv_phieuxuat.CurrentRow.Cells["TENKH"].Value.ToString();

            txb_makhoPX.Text = dgv_phieuxuat.CurrentRow.Cells["TENKHO"].Value.ToString();

            txb_ghichuPX.Text = dgv_phieuxuat.CurrentRow.Cells["GHICHU"].Value.ToString();
        }
        // hien thi  danh sach nhap:
        private void dgv_nhapSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_maPN.Text = dgv_phieunhap.CurrentRow.Cells["MAPN"].Value.ToString().Trim();
            ngaynhap.Text = dgv_phieunhap.CurrentRow.Cells["NGAYNHAP"].Value.ToString().Trim();
            txb_nvnhap.Text = dgv_phieunhap.CurrentRow.Cells["TENNV"].Value.ToString().Trim();
            txb_maspPN.Text = dgv_phieunhap.CurrentRow.Cells["TENSP"].Value.ToString().Trim();

            txb_soluongPN.Text = dgv_phieunhap.CurrentRow.Cells["SOLUONG"].Value.ToString().Trim();
            txb_tongtienPN.Text = dgv_phieunhap.CurrentRow.Cells["TONGTIEN"].Value.ToString().Trim();
            txb_mancc.Text = dgv_phieunhap.CurrentRow.Cells["TENNHACC"].Value.ToString().Trim();


            txb_makhoPN.Text = dgv_phieunhap.CurrentRow.Cells["TENKHO"].Value.ToString().Trim();

            txb_ghichu.Text = dgv_phieunhap.CurrentRow.Cells["GHICHU"].Value.ToString().Trim();




        }
        private void NhapXuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cleartextPN();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            groupBox_DSNhap_Xuat.Text = "Nhập Hàng";

        }

        private void btn_taianh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filepart = dialog.FileName;

            }
            else
            {

            }
        }


        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu home = new MainMenu();
            home.ShowDialog();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            NhapXuat_Load(sender, e);
        }
        // them phieu nhap
        private void bt_them_Click(object sender, EventArgs e)
        {
            cleartextPN();
            EnablePN();
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            button_chophepsua.Enabled = false;
            btn_ghinhan.Enabled = true;
            keyn = 1;

        }

        //xoa 1 phieu nhap :
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            cleartextPN();
            tbx_maPN.Enabled = true;
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            button_chophepsua.Enabled = false;
            btn_ghinhan.Enabled = true;
            keyn = 3;

        }
        //sua phieu nhap san pham:
        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            if (keyn == 1)
            {
                if (txb_nvnhap.Text == "" || txb_makhoPN.Text == "" || txb_mancc.Text == "")
                {
                    MessageBox.Show("Hãy điền đủ thông tin vào các ô");
                    ngaynhap.Focus();
                }
                else
                {
                    var nvNhapitem = txb_nvnhap.GetItemText(txb_nvnhap.SelectedItem);
                    ThongTinNVNHAP(nvNhapitem);
                    var spNhapitem = txb_maspPN.GetItemText(txb_maspPN.SelectedItem);
                    ThongTinSPPN(spNhapitem);
                    var nccitem = txb_mancc.GetItemText(txb_mancc.SelectedItem);
                    ThongTinNCC(nccitem);
                    var khoitem = txb_makhoPN.GetItemText(txb_makhoPN.SelectedItem);
                    ThongTinKHOPN(khoitem);
                    DataTable dtnv = acc.CheckSql("select *from NHANVIEN WHERE TENNV like N'" + txb_nvnhap.Text + "'");
                    DataTable dtkho = acc.CheckSql("SELECT *from KHOHANG WHERE TENKHO like N'" + txb_makhoPN.Text + "'");
                    DataTable dtncc = acc.CheckSql("SELECT *FROM NHACUNGCAP WHERE TENNHACC like N'" + txb_mancc.Text + "'");
                    if (dtnv.Rows.Count < 1)
                    {
                        MessageBox.Show("Mã Nhân Viên Đã tồn tại", "Thông Báo");
                        txb_nvnhap.Focus();
                    }
                    else if (dtkho.Rows.Count < 1)
                    {
                        MessageBox.Show("Mã kho đã tồn tại", "Thông Báo");
                        txb_makhoPN.Focus();

                    }
                    else if (dtncc.Rows.Count < 1)
                    {
                        MessageBox.Show("Mã Nhà cung cấp đã tồn tại", "Thông  Báo");
                        txb_makhoPN.Focus();
                    }
                    else
                    {

                        acc.THEMPHIEUNHAP(tbx_maPN.Text, MAKHOPN, NVNHAP, ngaynhap.Value, MANCC, txb_ghichu.Text);
                        SqlDataReader sda = acc.ExecuteReader("SELECT TOP 1 MAPN FROM PHIEUNHAPKHO ORDER BY MAPN DESC");
                        if (sda.Read() == true)
                        {
                            acc.THEMCTPN(sda[0].ToString(), MASPPN, Convert.ToInt16(txb_soluongPN.Text), float.Parse(txb_tongtienPN.Text));
                        }
                        NhapXuat_Load(sender, e);
                        dgv_phieunhap.ClearSelection();
                    }
                }
            }
            if (keyn == 2)
            {
                if (dgv_phieunhap.SelectedRows == null)
                {
                    MessageBox.Show("Hãy chọn 1 phiếu nhập để sửa");
                }
                else if (txb_nvnhap.Text == "" || txb_makhoPN.Text == "" || txb_mancc.Text == "" || txb_soluongPN.Text == "" || txb_tongtienPN.Text == "")
                {
                    MessageBox.Show("Hãy điền đủ thông tin vào các ô");
                    ngaynhap.Focus();
                }
                else
                {
                    var nvNhapitem = txb_nvnhap.GetItemText(txb_nvnhap.SelectedItem);
                    ThongTinNVNHAP(nvNhapitem);
                    var spNhapitem = txb_maspPN.GetItemText(txb_maspPN.SelectedItem);
                    ThongTinSPPN(spNhapitem);
                    var nccitem = txb_mancc.GetItemText(txb_mancc.SelectedItem);
                    ThongTinNCC(nccitem);
                    var khoitem = txb_makhoPN.GetItemText(txb_makhoPN.SelectedItem);
                    ThongTinKHOPN(khoitem);
                    DataTable dtnv = acc.CheckSql("select *from NHANVIEN WHERE TENNV LIKE N'" + txb_nvnhap.GetItemText(txb_nvnhap.SelectedItem) + "'");
                    DataTable dtkho = acc.CheckSql("SELECT *from KHOHANG WHERE TENKHO LIKE N'" + txb_makhoPN.GetItemText(txb_makhoPN.SelectedItem) + "'");
                    DataTable dtncc = acc.CheckSql("SELECT *FROM NHACUNGCAP WHERE TENNHACC LIKE N'" + txb_mancc.GetItemText(txb_mancc.SelectedItem) + "'");
                    if (dtnv.Rows.Count < 1)
                    {
                        MessageBox.Show(" Nhân Viên Không tồn tại", "Lỗi Nhập");
                        txb_nvnhap.Focus();
                    }
                    else if (dtkho.Rows.Count < 1)
                    {
                        MessageBox.Show(" kho Không tồn tại", "Lỗi Nhập");
                        txb_makhoPN.Focus();

                    }
                    else if (dtncc.Rows.Count < 1)
                    {
                        MessageBox.Show(" Nhà cung cấp Không tồn tại", "Lỗi Nhập");
                        txb_makhoPN.Focus();
                    }
                    else
                    {

                        acc.SUAPHIEUNHAP(tbx_maPN.Text, MAKHOPN, NVNHAP, ngaynhap.Value, MANCC, txb_ghichu.Text);
                        acc.SUACTPN(tbx_maPN.Text, MASPPN, Convert.ToInt16(txb_soluongPN.Text), float.Parse(txb_tongtienPN.Text));
                        NhapXuat_Load(sender, e);
                        dgv_phieunhap.ClearSelection();
                        cleartextPN();
                    }
                }
            }
            if (keyn == 3)
            {
                if (tbx_maPN.Text == "" || dgv_phieunhap.SelectedRows == null)
                {
                    MessageBox.Show("Hãy Chọn 1 phiếu nhập để xóa");
                }
                else if (MessageBox.Show("Bạn Có chắc chắn muốn xóa phiếu xuất", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    acc.XOAPHIEUNHAP(tbx_maPN.Text);
                    NhapXuat_Load(sender, e);
                    dgv_phieunhap.ClearSelection();
                    cleartextPN();
                }
            }
        }

        private void btn_themPX_Click(object sender, EventArgs e)
        {
            EnablePX();
            cleartextPX();
            btn_themPX.Enabled = false;
            btn_xoaPX.Enabled = false;
            btn_chophepsua.Enabled = false;
            btn_suaPX.Enabled = true;
            txb_maPX.Focus();
            keyx = 1;

        }
        // sua phieu xuat:
        private void btn_suaPX_Click(object sender, EventArgs e)
        {
            if (keyx == 1)
            {
                if (txb_manvPX.Text == "" || txb_makhoPX.Text == "" || txb_makh.Text == "")
                {
                    MessageBox.Show("Hãy điền đủ thông tin vào các ô");
                    ngayxuat.Focus();
                }
                else
                {
                    var nvXuatitem = txb_manvPX.GetItemText(txb_manvPX.SelectedItem);
                    ThongTinNVXUAT(nvXuatitem);
                    var spXuatitem = txb_maspPX.GetItemText(txb_maspPX.SelectedItem);
                    ThongTinSPPX(spXuatitem);
                    var KHitem = txb_makh.GetItemText(txb_makh.SelectedItem);
                    ThongTinKH(KHitem);
                    var khoitem = txb_makhoPX.GetItemText(txb_makhoPX.SelectedItem);
                    ThongTinKHOPX(khoitem);
                    DataTable dtnv = acc.CheckSql("select *from NHANVIEN WHERE TENNV like N'" + txb_manvPX.GetItemText(txb_manvPX.SelectedItem) + "'");
                    DataTable dtkho = acc.CheckSql("SELECT *from KHOHANG WHERE TENKHO like N'" + txb_makhoPX.GetItemText(txb_makhoPX.SelectedItem) + "'");
                    DataTable dtkh = acc.CheckSql("SELECT *FROM KHACHHANG WHERE TENKH like N'" + txb_makh.GetItemText(txb_makh.SelectedItem) + "'");
                    if (dtnv.Rows.Count < 1)
                    {
                        MessageBox.Show("Mã Nhân Viên Đã tồn tại", "Thông Báo");
                        txb_manvPX.Focus();
                    }
                    else if (dtkho.Rows.Count < 1)
                    {
                        MessageBox.Show("Mã kho đã tồn tại", "Thông Báo");
                        txb_makhoPX.Focus();

                    }
                    else if (dtkh.Rows.Count < 1)
                    {
                        MessageBox.Show("Mã Khách Hàng đã tồn tại", "Thông  Báo");
                        txb_makh.Focus();
                    }
                    else
                    {

                        acc.THEMPHIEUXUAT(txb_maPX.Text, MAKHOPX, NVXUAT, ngayxuat.Value, MAKH, txb_ghichuPX.Text);
                        SqlDataReader sda = acc.ExecuteReader("SELECT TOP 1 MAPX FROM PHIEUXUAT ORDER BY MAPX DESC");
                        if (sda.Read() == true)
                        {
                            acc.THEMCTPX(sda[0].ToString(), MASPPX, Convert.ToInt16(txb_soluongPX.Text), float.Parse(txb_tongtienPX.Text));
                        }
                        MessageBox.Show("Thêm Thành Công");
                        NhapXuat_Load(sender, e);
                        dgv_phieuxuat.ClearSelection();
                    }
                }
            }
            if (keyx == 2)
            {
                if (dgv_phieuxuat.SelectedRows == null || txb_maspPX.Text == "")
                {
                    MessageBox.Show("Hãy Chọn 1 phiếu xuất để sửa");
                }
                else if (txb_manvPX.Text == "" || txb_makhoPX.Text == "" || txb_makh.Text == "" || txb_soluongPX.Text == "" || txb_tongtienPX.Text == "" || txb_maspPX.Text == "")
                {
                    MessageBox.Show("Hãy điền đủ thông tin vào các ô");
                    ngayxuat.Focus();
                }
                else
                {
                    var nvXuatitem = txb_manvPX.GetItemText(txb_manvPX.SelectedItem);
                    ThongTinNVXUAT(nvXuatitem);
                    var spXuatitem = txb_maspPX.GetItemText(txb_maspPX.SelectedItem);
                    ThongTinSPPX(spXuatitem);
                    var KHitem = txb_makh.GetItemText(txb_makh.SelectedItem);
                    ThongTinKH(KHitem);
                    var khoitem = txb_makhoPX.GetItemText(txb_makhoPX.SelectedItem);
                    ThongTinKHOPX(khoitem);
                    DataTable dtnv = acc.CheckSql("select *from NHANVIEN WHERE TENNV like N'" + txb_manvPX.GetItemText(txb_manvPX.SelectedItem) + "'");
                    DataTable dtkho = acc.CheckSql("SELECT *from KHOHANG WHERE TENKHO like N'" + txb_makhoPX.GetItemText(txb_makhoPX.SelectedItem) + "'");
                    DataTable dtkh = acc.CheckSql("SELECT *FROM KHACHHANG WHERE TENKH like N'" + txb_makh.GetItemText(txb_makh.SelectedItem) + "'");
                    if (dtnv.Rows.Count < 1)
                    {
                        MessageBox.Show("Mã Nhân Viên Đã tồn tại", "Thông Báo");
                        txb_nvnhap.Focus();
                    }
                    else if (dtkho.Rows.Count < 1)
                    {
                        MessageBox.Show("Mã kho đã tồn tại", "Thông Báo");
                        txb_makhoPN.Focus();

                    }
                    else if (dtkh.Rows.Count < 1)
                    {
                        MessageBox.Show("Mã Khách Hàng đã tồn tại", "Thông  Báo");
                        txb_makhoPN.Focus();
                    }
                    else
                    {
                        acc.SUAPHIEUXUAT(txb_maPX.Text, MAKHOPX, NVXUAT, ngayxuat.Value, MAKH, txb_ghichuPX.Text);
                        acc.SUACTPX(txb_maPX.Text, MASPPX, Convert.ToInt16(txb_soluongPX.Text), float.Parse(txb_tongtienPX.Text));
                        MessageBox.Show("Sửa Thành Công");
                        NhapXuat_Load(sender, e);
                        cleartextPX();
                        dgv_phieunhap.ClearSelection();
                    }
                }
            }
            if (keyx == 3)
            {
                if (dgv_phieuxuat.SelectedRows == null || txb_maPX.Text == "")
                {
                    MessageBox.Show("Hãy chọn 1 phiếu để XÓA");
                }
                else if (MessageBox.Show("Bạn Có chắc chắn muốn xóa phiếu xuất", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    acc.XOAPHIEUXUAT(txb_maPX.Text);
                    NhapXuat_Load(sender, e);
                    cleartextPX();
                }
            }
        }
        // lam moi phieu xuat:
        private void button_lammoiPX_Click(object sender, EventArgs e)
        {
            cleartextPX();
            textBox1.Clear();
            NhapXuat_Load(sender, e);
        }

        private void btn_xoaPX_Click(object sender, EventArgs e)
        {
            cleartextPX();
            btn_themPX.Enabled = false;
            btn_xoaPX.Enabled = false;
            btn_chophepsua.Enabled = false;
            btn_suaPX.Enabled = true;
            txb_maPX.Enabled = true;
            keyx = 3;

        }


        private void btn_chophepsua_Click(object sender, EventArgs e)
        {
            EnablePX();
            cleartextPX();
            btn_themPX.Enabled = false;
            btn_xoaPX.Enabled = false;
            btn_chophepsua.Enabled = false;
            btn_suaPX.Enabled = true;
            txb_maPX.Enabled = false;
            keyx = 2;
        }

        private void button_chophepsua_Click(object sender, EventArgs e)
        {
            EnablePN();
            cleartextPN();
            tbx_maPN.Enabled = false;
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            button_chophepsua.Enabled = false;
            btn_ghinhan.Enabled = true;
            keyn = 2;
        }
        // xuất hóa đơn:
        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            if (txb_maPX.Text == null || txb_maPX.Text == "")
            {
                MessageBox.Show("Nhập Mã Phiếu Để in!");
            }
            else
            {
                BaoCaoF.MAPX = txb_maPX.Text;
                BaoCaoF.keyn = 3;
                BaoCaoF baocaof = new BaoCaoF();
                baocaof.ShowDialog();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbx_maPN.Text == null || tbx_maPN.Text == "")
            {
                MessageBox.Show("Hãy Chọn 1 phiếu để In");

            }
            else
            {
                BaoCaoF.MAPN = tbx_maPN.Text;
                BaoCaoF.keyn = 4;
                BaoCaoF baocaof = new BaoCaoF();
                baocaof.ShowDialog();
            }
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu home = new MainMenu();
            home.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu home = new MainMenu();
            home.ShowDialog();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            cleartextPN();
        }

        private void btn_huyx_Click(object sender, EventArgs e)
        {
            cleartextPX();
        }

        private void btn_timkiem_N_Click(object sender, EventArgs e)
        {
            if(txb_timkiem_N.Text=="")
            {
                MessageBox.Show("Hãy nhập thông tin tìm kiếm", "Thông báo");
                txb_timkiem_N.Focus();
            }else
            {
                label_ketquatimkiemN.Text = "Kết Quả Tìm Kiếm";
                ThongTinKHOPN(txb_timkiem_N.Text);
                ThongTinNCC(txb_timkiem_N.Text);
                ThongTinNVNHAP(txb_timkiem_N.Text);
                ThongTinSPPN(txb_timkiem_N.Text);
                textBox1.Text = MAKHOPN;
                dgv_phieunhap.DataSource = acc.Select_Data("SELECT PN.MAPN, KHOHANG.TENKHO,NHANVIEN.TENNV,NGAYNHAP,NHACUNGCAP.TENNHACC,SANPHAM.TENSP,CT.SOLUONG,TONGTIEN,PN.GHICHU FROM PHIEUNHAPKHO PN left join NHANVIEN on NHANVIEN.MANV = PN.NVNHAP left join NHACUNGCAP on NHACUNGCAP.MANCC = PN.MANCC left join KHOHANG on KHOHANG.MAKHO = PN.MAKHO INNER JOIN CHITIETPHIEUNHAP CT ON PN.MAPN=CT.MAPN INNER join SANPHAM on SANPHAM.MASP = CT.MASP where PN.MAPN LIKE N'%" + txb_timkiem_N.Text + "%' OR KHOHANG.TENKHO like N'%" + txb_timkiem_N.Text + "%'");
                dgv_phieunhap.ClearSelection();
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_timkiemPX_Click(object sender, EventArgs e)
        {
            if (txb_timkiemPX.Text == "")
            {
                MessageBox.Show("Hãy nhập thông tin tìm kiếm", "Thông báo");
                txb_timkiem_N.Focus();
            }
            else
            {
                dgv_phieuxuat.DataSource = acc.Select_Data("SELECT PX.MAPX, KHOHANG.TENKHO, NHANVIEN.TENNV,NGAYXUAT,KHACHHANG.TENKH,SANPHAM.TENSP,CT.SOLUONG,TONGTIEN,PX.GHICHU FROM PHIEUXUAT PX LEFT join NHANVIEN on NHANVIEN.MANV = PX.NVXUAT left join KHACHHANG on KHACHHANG.MAKH = PX.MAKH left join KHOHANG on KHOHANG.MAKHO = PX.MAKHO INNER JOIN CHITIETPHIEUXUAT CT ON PX.MAPX = CT.MAPX INNER join SANPHAM on SANPHAM.MASP = CT.MASP where PX.MAPX LIKE N'%" + txb_timkiemPX.Text + "%' OR KHOHANG.TENKHO like N'%" + txb_timkiemPX.Text + "%'");
                dgv_phieuxuat.ClearSelection();
            }
        }

        private void txb_soluongPX_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt16(txb_soluongPX.Text)>2000)
            {
                MessageBox.Show("Không thể xuất quá 2000 sản phẩm", "Lỗi");
                txb_soluongPX.Clear();
            }
        }
    }
}
