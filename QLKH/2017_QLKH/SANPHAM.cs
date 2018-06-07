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
using System.IO;

namespace _2017_QLKH
{
    public partial class SANPHAM : Form
    {
        public SANPHAM()
        {
            InitializeComponent();
        }
        private string[] DS_PhanLoai = new string[] { "Hàng Mới Quốc Tế", "Hàng Cũ Quốc Tế", "Hàng Xách Tay", "Hàng Xách Tay Cũ" };
        accessData acc = new accessData();
        private int key = 0;
        public static string filepart = "";
        private string filename;
        private string MANCC;
        private string MADM;
        public void ConverttoString(DateTime dt)
        {

        }
        public void Disable()
        {
            tbx_tensp.Enabled = false; txb_madm.Enabled = false; txb_ncc.Enabled = false; txb_phanloai.Enabled = false; txb_serial.Enabled = false;
            txb_soluong.Enabled = false; txb_giasp.Enabled = false; button8.Enabled = false; txb_ghichu.Enabled = false;
            dtpicker_nsx.Enabled = false; dtpicker_hsd.Enabled = false;
        }
        public void Enable()
        {
            tbx_tensp.Enabled = true; txb_madm.Enabled = true; txb_ncc.Enabled = true; txb_phanloai.Enabled = true; txb_serial.Enabled = true;
            txb_soluong.Enabled = true; txb_giasp.Enabled = true; button8.Enabled = true; txb_ghichu.Enabled = true;
            dtpicker_nsx.Enabled = true; dtpicker_hsd.Enabled = true;
        }
        public void cleartext()
        {
            txb_giasp.Clear(); txb_madm.ResetText();
            txb_ghichu.Clear(); txb_ncc.ResetText(); txb_phanloai.Clear(); tbx_masp.Clear();
            tbx_tensp.Clear(); txb_serial.Clear(); txb_soluong.Value = 0; pictureBox_sanpham.Image = null; filepart = "";
        }
        public DataTable ThongTinNCC(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MANCC FROM NHACUNGCAP WHERE TENNHACC LIKE N'" + TEXT + "'");
            while (a.Read())
            {
                MANCC = a["MANCC"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinDM(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MADANHMUC FROM DANHMUC WHERE TENDANHMUC LIKE N'" + TEXT + "'");
            while (a.Read())
            {
                MADM = a["MADANHMUC"].ToString().Trim();
            }
            return null;
        }
        private void SANPHAM_Load(object sender, EventArgs e)
        {
            acc.AutoCompletecbx(txb_madm, "SELECT TENDANHMUC FROM DANHMUC", "TENDANHMUC");
            acc.AutoCompletecbx(txb_ncc, "SELECT TENNHACC FROM NHACUNGCAP", "TENNHACC");
            acc.AutoCompleteByArray(txb_phanloai, DS_PhanLoai);
            Disable();
            tbx_masp.Enabled = false; tbx_tensp.Focus();
            tbx_masp.Text = " ";
            label_thongbaoSP.Text = "";
            txb_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            dgv_SANPHAM.DataSource = acc.Select_Data("SELECT MASP,TENSP,GIA,SERIAL,NHACUNGCAP.TENNHACC,DANHMUC.TENDANHMUC ,NGAYSANXUAT,HANSUDUNG,SOLUONG,PHANLOAI,HINHANH,SP.GHICHU  FROM SANPHAM SP LEFT JOIN DANHMUC on DANHMUC.MADANHMUC = SP.MADANHMUC left join NHACUNGCAP on NHACUNGCAP.MANCC = SP.MANCC");
            dgv_SANPHAM.ClearSelection();
            groupBox_DSSP.Text = "Danh Sách Sản Phẩm";

            // CUSTOM SIZE COLUMN:
            dgv_SANPHAM.Columns[0].Width = 70;
            dgv_SANPHAM.Columns[1].Width = 150;
            dgv_SANPHAM.Columns[2].Width = 100;
            dgv_SANPHAM.Columns[3].Width = 100;
            dgv_SANPHAM.Columns[4].Width = 200;
            dgv_SANPHAM.Columns[5].Width = 180;
            dgv_SANPHAM.Columns[8].Width = 50;
            dgv_SANPHAM.Columns[9].Width = 150;
            // hiển thị tiêu đề của các cột:
            dgv_SANPHAM.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgv_SANPHAM.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgv_SANPHAM.Columns[2].HeaderText = "Giá";
            dgv_SANPHAM.Columns[3].HeaderText = "Serial";
            dgv_SANPHAM.Columns[4].HeaderText = "Tên Nhà Cung Cấp";
            dgv_SANPHAM.Columns[5].HeaderText = "Tên Danh Mục";
            dgv_SANPHAM.Columns[6].HeaderText = "Ngày Sản Xuất";
            dgv_SANPHAM.Columns[7].HeaderText = "Hạn Sử Dụng";
            dgv_SANPHAM.Columns[8].HeaderText = "Số Lượng";
            dgv_SANPHAM.Columns[9].HeaderText = "Phân Loại";
            dgv_SANPHAM.Columns[10].HeaderText = "Hình Ảnh ";
            dgv_SANPHAM.Columns[11].HeaderText = "Ghi Chú";
            //

            textBox_showpart.Enabled = false;

            btn_themmoi.Enabled = true;
            btn_xoa.Enabled = true;
            btn_chophepsua.Enabled = true;
            btn_ghinhan.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu = new MainMenu();
            mainmenu.ShowDialog();
        }
        //them san pham
        private void button1_Click(object sender, EventArgs e)
        {
            key = 1;
            cleartext();
            Enable();
            tbx_tensp.Focus();
            btn_themmoi.Enabled = false;
            btn_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            btn_ghinhan.Enabled = true;
        }
        //tai anh len
        private void button8_Click(object sender, EventArgs e)
        {
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
                pictureBox_sanpham.Image = Image.FromFile(ofdImages.FileName);
                filename = Path.GetFileName(ofdImages.FileName);
                pictureBox_sanpham.SizeMode = PictureBoxSizeMode.StretchImage;
                filepart = Application.StartupPath + "\\Images\\" + filename;
                if (!File.Exists(filenameX)) return;

                if (File.Exists(filepart))
                {

                }

                else
                    try
                    {
                        File.Copy(filenameX, filepart);
                    }
                    catch
                    {
                        MessageBox.Show("Đã phát sinh lỗi trong việc chọn ảnh upload, vui lòng kiểm tra lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                filename = "";
                pictureBox_sanpham.Image = null;
            }
        }

        private void button_toggle_masp_Click(object sender, EventArgs e)
        {
            if (tbx_masp.Enabled == false)
            {
                tbx_masp.Enabled = true;
            }
            else
            {
                tbx_masp.Enabled = false;
            }
        }
        //HIEN THỊ NỘI DUNG LÊN TEXTBOX
        private void dgv_SANPHAM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbx_masp.Text = dgv_SANPHAM.CurrentRow.Cells["MASP"].Value.ToString().Trim();
                tbx_tensp.Text = dgv_SANPHAM.CurrentRow.Cells["TENSP"].Value.ToString().Trim();
                txb_madm.Text = dgv_SANPHAM.CurrentRow.Cells["TENDANHMUC"].Value.ToString().Trim();
                txb_ncc.Text = dgv_SANPHAM.CurrentRow.Cells["TENNHACC"].Value.ToString().Trim();
                txb_serial.Text = dgv_SANPHAM.CurrentRow.Cells["SERIAL"].Value.ToString().Trim();
                txb_soluong.Text = dgv_SANPHAM.CurrentRow.Cells["SOLUONG"].Value.ToString().Trim();
                txb_giasp.Text = dgv_SANPHAM.CurrentRow.Cells["GIA"].Value.ToString().Trim();
                txb_phanloai.Text = dgv_SANPHAM.CurrentRow.Cells["PHANLOAI"].Value.ToString().Trim();
                dtpicker_nsx.Text = dgv_SANPHAM.CurrentRow.Cells["NGAYSANXUAT"].Value.ToString();
                dtpicker_hsd.Text = dgv_SANPHAM.CurrentRow.Cells["HANSUDUNG"].Value.ToString().Trim();
                txb_ghichu.Text = dgv_SANPHAM.CurrentRow.Cells["GHICHU"].Value.ToString().Trim();
                filename = dgv_SANPHAM.CurrentRow.Cells["HINHANH"].Value.ToString().Trim();
                if (filename == "")
                {
                    pictureBox_sanpham.Image = null;
                }
                else
                {
                    filepart = Application.StartupPath + "\\Images\\" + filename;
                    if (!File.Exists(filepart))
                    {
                        pictureBox_sanpham.Image = null;
                        //MessageBox.Show("Đường dẫn ảnh không đúng", "Lỗi");
                    }
                    else
                    {
                        pictureBox_sanpham.Image = Image.FromFile(filepart.ToString());
                        pictureBox_sanpham.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
            }
        }

        //sửa thông tin sản phẩm:
        private void button2_Click(object sender, EventArgs e)
        {
            Enable();
            tbx_masp.Enabled = false;
            btn_themmoi.Enabled = false;
            btn_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            btn_ghinhan.Enabled = true;
            key = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbx_masp.Enabled = true;
            btn_themmoi.Enabled = false;
            btn_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            btn_ghinhan.Enabled = true;
            key = 3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SANPHAM_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SANPHAM_Load(sender, e);
            dgv_SANPHAM.ClearSelection();
            groupBox_DSSP.Text = "Danh Sách Sản Phẩm";

        }
        // Tìm kiếm sản phẩm
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txb_timkiem.Text == "")
            {
                MessageBox.Show("Nhập Từ Khóa Tìm Kiếm", "thông Báo");
                txb_timkiem.Focus();
            }
            else
            {
                dgv_SANPHAM.DataSource = acc.Select_Data("SELECT MASP,TENSP,GIA,SERIAL,NHACUNGCAP.TENNHACC,DANHMUC.TENDANHMUC ,NGAYSANXUAT,HANSUDUNG,SOLUONG,PHANLOAI,HINHANH,SANPHAM.GHICHU  FROM SANPHAM  LEFT JOIN DANHMUC on DANHMUC.MADANHMUC = SANPHAM.MADANHMUC left join NHACUNGCAP on NHACUNGCAP.MANCC = SANPHAM.MANCC WHERE (MASP like N'%" + txb_timkiem.Text + "%' OR TENSP like N'%" + txb_timkiem.Text + "%' OR TENNHACC like N'%" + txb_timkiem.Text + "%' OR  GIA like N'%" + txb_timkiem.Text + "%' OR TENDANHMUC like N'%" + txb_timkiem.Text + "%' OR SERIAL like N'%" + txb_timkiem.Text + "%' OR  PHANLOAI like N'%" + txb_timkiem.Text + "%' OR SANPHAM.GHICHU like N'%" + txb_timkiem.Text + "%')");
                txb_timkiem.Clear();
                dgv_SANPHAM.ClearSelection();
                groupBox_DSSP.Text = "Kết Quả Tìm Kiếm";

            }
        }

        private void txb_timkiem_Leave(object sender, EventArgs e)
        {
            if (txb_timkiem.Text == "")
            {
                txb_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

        private void txb_timkiem_Enter(object sender, EventArgs e)
        {
            if (txb_timkiem.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                txb_timkiem.Text = "";
            }
        }

        private void bt_prev_Click(object sender, EventArgs e)
        {

        }

        private void SANPHAM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }
        // ghi nhan:
        private void button6_Click_1(object sender, EventArgs e)
        {
            if (key == 1)
            {
                if (tbx_tensp.Text == "" || txb_madm.Text == "" || txb_ncc.Text == "" || txb_phanloai.Text == "" || txb_serial.Text == "" || txb_soluong.Value == 0)
                {
                    MessageBox.Show("Hãy Điền đủ thông tin vào Các Mục", "Thông Báo");
                    tbx_masp.Focus();
                }
                else if (filepart == "")
                {
                    MessageBox.Show("Hãy Chọn ảnh Sản Phẩm", "Cảnh Báo");
                    button8.Focus();
                }
                else
                {
                    DataTable dtncc = new DataTable();
                    DataTable dtdm = new DataTable();
                    DataTable dtsp = acc.CheckSql("select *from SANPHAM where MASP='" + tbx_masp.Text + "'");
                    dtncc = acc.CheckSql("Select *from NHACUNGCAP WHERE MANCC='" + txb_ncc.Text + "'");
                    dtdm = acc.CheckSql("SELECT *FROM DANHMUC WHERE MADANHMUC='" + txb_madm.Text + "'");
                    if (dtncc.Rows.Count < 0)
                    {
                        MessageBox.Show("NHÀ CUNG CẤP CHƯA TỒN TẠI", "Thông Báo");
                        tbx_masp.Clear();
                        txb_madm.ResetText();
                        txb_madm.Focus();
                    }
                    else if (dtdm.Rows.Count < 0)
                    {
                        MessageBox.Show("DANH MỤC CHƯA TỒN TẠI", "THÔNG BÁO");
                        txb_madm.ResetText();
                        txb_madm.Focus();
                    }
                    else if (dtsp.Rows.Count > 0)
                    {
                        MessageBox.Show("MÃ SẢN PHẨM ĐÃ TỒN TẠI", "THÔNG BÁO");
                        tbx_masp.Clear();
                        tbx_masp.Focus();
                    }
                    else
                    {
                        var itemNCC = txb_ncc.GetItemText(txb_ncc.SelectedItem);
                        ThongTinNCC(itemNCC);
                        var itemDM = txb_madm.GetItemText(txb_madm.SelectedItem);
                        ThongTinDM(itemDM);
                        //filepart = openFile_PictureSP.FileName;
                        acc.THEM_SANPHAM(tbx_masp.Text, tbx_tensp.Text, MANCC, float.Parse(txb_giasp.Text), MADM, txb_serial.Text, filename, dtpicker_nsx.Value, dtpicker_hsd.Value, txb_ghichu.Text, Convert.ToInt32(txb_soluong.Value), txb_phanloai.Text);
                        SANPHAM_Load(sender, e);
                        cleartext();
                        dgv_SANPHAM.ClearSelection();
                        label_thongbaoSP.Text = "Thêm THành Công Sản Phẩm mới";
                        tbx_tensp.Focus();

                    }


                }
            }
            if (key == 2)
            {
                DataTable dtdm = acc.CheckSql("SELECT *From DANHMUC where MADANHMUC='" + txb_madm.Text + "'");
                DataTable dtncc = acc.CheckSql("SELECT *From NHACUNGCAP where MANCC='" + txb_ncc.Text + "'");
                if (dtdm.Rows.Count < 0)
                {
                    MessageBox.Show("Mã danh mục không tồn tại", "THông báo");
                    txb_madm.ResetText();
                    txb_madm.Focus();
                }
                else if (dtncc.Rows.Count < 0)
                {
                    MessageBox.Show("MÃ nhà cung cấp không tồn tại", "Thông Báo");
                    txb_ncc.ResetText();
                    txb_ncc.Focus();
                }
                else
                {
                    var itemNCC = txb_ncc.GetItemText(txb_ncc.SelectedItem);
                    ThongTinNCC(itemNCC);
                    var itemDM = txb_madm.GetItemText(txb_madm.SelectedItem);
                    ThongTinDM(itemDM);
                    //filepart = openFile_PictureSP.FileName;
                    acc.SUA_SANPHAM(tbx_masp.Text, tbx_tensp.Text, MANCC, float.Parse(txb_giasp.Text), MADM, txb_serial.Text, filename, dtpicker_nsx.Value, dtpicker_hsd.Value, txb_ghichu.Text, Convert.ToInt32(txb_soluong.Value), txb_phanloai.Text);
                    SANPHAM_Load(sender, e);
                    dgv_SANPHAM.ClearSelection();
                    cleartext();
                    label_thongbaoSP.Text = "Sửa Thông Tin thành công";
                }
            }
            if (key == 3)
            {
                if (dgv_SANPHAM.SelectedRows == null || tbx_masp.Text == "")
                {
                    MessageBox.Show("Hãy chọn 1 sản phẩm để xóa", "Cảnh Báo");

                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        acc.XOA_SANPHAM(tbx_masp.Text);
                        SANPHAM_Load(sender, e);
                        dgv_SANPHAM.ClearSelection();
                        cleartext();
                        label_thongbaoSP.Text = "Đã xóa thành công";
                    }
                }
            }
        }

        private void vềTrangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu home = new MainMenu();
            home.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Ứng Dụng", "Quản Lý KHo Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // chuc nang huy nhap:
        private void btn_huynhap_Click(object sender, EventArgs e)
        {
            //if (tbx_tensp.Text != "" || txb_madm.Text != "")
            //{
            //    if (MessageBox.Show("Bạn có chắc chắn muốn hủy Nhập", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        cleartext();
            //    }
            //}
            //else
            //{
            //    cleartext();
            //    string masp = "";
            //    SqlDataReader sda = acc.ExecuteReader("Select TOP 1 MASP FROM SANPHAM ORDER BY MASP DESC");
            //    if (sda.Read() == true)
            //    {
            //        masp = sda[0].ToString();
            //        SqlDataReader sp = acc.ExecuteReader("SELECT MASP,TENSP,GIA,SERIAL,(SELECT TENNHACC FROM NHACUNGCAP WHERE MANCC=SP.MANCC) AS TENNCC,(SELECT TENDANHMUC FROM DANHMUC WHERE MADANHMUC=SP.MADANHMUC) AS TENDANHMUC,NGAYSANXUAT,HANSUDUNG,SOLUONG,PHANLOAI,HINHANH,GHICHU  FROM SANPHAM SP WHERE MASP='" + masp + "'");
            //        if (sp.Read() == true)
            //        {
            //            tbx_masp.Text = sp[0].ToString(); tbx_tensp.Text = sp[1].ToString(); txb_ncc.Text = sp[4].ToString(); txb_madm.Text = sp[5].ToString();
            //            txb_serial.Text = sp[3].ToString(); dtpicker_nsx.Text = sp[6].ToString(); dtpicker_hsd.Text = sp[7].ToString(); txb_soluong.Value = Convert.ToInt16(sp[8].ToString());
            //            txb_phanloai.Text = sp[9].ToString(); txb_giasp.Text = sp[2].ToString(); txb_ghichu.Text = sp[11].ToString();
            //            filename = sp[10].ToString(); pictureBox_sanpham.Image = Image.FromFile(Application.StartupPath + "\\Images\\" + filename.ToString());
            //            textBox_showpart.Text = filename.ToString();
            //            pictureBox_sanpham.SizeMode = PictureBoxSizeMode.StretchImage;
            //        }
            //    }
            //    if (MessageBox.Show("Bạn có chắc chắn muốn hủy sản phẩm vừa được thêm ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        acc.XOA_SANPHAM(masp);
            //        MessageBox.Show("Hủy Thành Công");
            //        SANPHAM_Load(sender, e);
            //    }
            //}
            cleartext();

        }
    }
}
