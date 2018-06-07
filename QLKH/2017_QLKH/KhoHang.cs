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
    public partial class KhoHang : Form
    {
        public void clearText()
        {
            tbx_makho.Clear();
            tbx_tenkho.Clear();
            tbx_tongdmsp.Value = 0;
            tbx_ghichu.Clear();
            dgvKHOHANG.ClearSelection();
        }
        public KhoHang()
        {
            InitializeComponent();
        }
        accessData acc = new accessData();
        private int key = 0;
        public void Disable()
        {
            tbx_tenkho.Enabled = false; tbx_ghichu.Enabled = false; tbx_tongdmsp.Enabled = false;
        }
        public void Enable()
        {
             tbx_ghichu.Enabled = true; tbx_tongdmsp.Enabled = true; tbx_tenkho.Enabled = true;
        }
        private void KhoHang_Load(object sender, EventArgs e)
        {        
            dgvKHOHANG.DataSource = acc.Select_Data("SELECT * FROM KHOHANG");
            dgvKHOHANG.ClearSelection();
            groupBox_ketquatimkiem.Text = "";
            tbx_makho.Text = "";
            tbx_tenkho.Focus();
            Disable();
            
            //btn_chophepsua.Enabled = false; btn_ghinhan.Enabled = false; bt_xoa.Enabled = false;
            //hiển thị tiêu đề của cột:
            dgvKHOHANG.Columns[0].HeaderText = "Mã Kho";
            dgvKHOHANG.Columns[1].HeaderText = "Tên Kho";
            dgvKHOHANG.Columns[2].HeaderText = "Tổng Số Danh Mục";
            dgvKHOHANG.Columns[3].HeaderText = "Ghi Chú";

            // can chinh do rong cot:
            dgvKHOHANG.Columns[0].Width = 80;
            dgvKHOHANG.Columns[1].Width = 250;
            dgvKHOHANG.Columns[2].Width = 70;
            dgvKHOHANG.Columns[3].Width = 160;

            btn_ghinhan.Enabled = false;
            bt_them.Enabled = true;
            bt_xoa.Enabled = true;
            btn_chophepsua.Enabled = true;
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void dgvKHOHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            clearText();
            Enable();
            tbx_tenkho.Focus();
            tbx_makho.Enabled = false;
            btn_ghinhan.Enabled = true;
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            key = 1;
            
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            KhoHang_Load(sender, e);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            clearText();
            Disable();
            tbx_makho.Enabled = true;
            btn_ghinhan.Enabled = true;
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            key = 3;
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //btn_ghinhan.Enabled = true; btn_chophepsua.Enabled = false; bt_xoa.Enabled = true;
            clearText();
            Enable();
            tbx_tenkho.Focus();
            tbx_makho.Enabled = false;
            btn_ghinhan.Enabled = true;
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            key = 2;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhoHang_Load(sender, e);
        }

        private void bt_prev_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvKHOHANG_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbx_makho.Text = dgvKHOHANG.CurrentRow.Cells["MAKHO"].Value.ToString().Trim();
                tbx_tenkho.Text = dgvKHOHANG.CurrentRow.Cells["TENKHO"].Value.ToString().Trim();
                tbx_tongdmsp.Text = dgvKHOHANG.CurrentRow.Cells["TONGSODMSP"].Value.ToString().Trim();
                tbx_ghichu.Text = dgvKHOHANG.CurrentRow.Cells["GHICHU"].Value.ToString().Trim();

            }
        }

        private void KhoHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void tbx_tongdmsp_Validating(object sender, CancelEventArgs e)
        {

        }
        // ghi nhan lai su thay doi

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                if (tbx_tenkho.Text == ""  || tbx_tongdmsp.Value ==0)
                {
                    MessageBox.Show("Hãy Nhập Đủ hết thông tin", "Lỗi Nhập!");
                    tbx_makho.Focus();
                }
                else
                {
                    DataTable dtkh = acc.CheckSql("SELECT *FROM KHOHANG WHERE MAKHO='" + tbx_makho.Text + "'");
                    if (dtkh.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã Kho đã tồn tại!!", "Cảnh Báo");
                        tbx_makho.Clear();
                        tbx_makho.Focus();
                    }
                    else
                    {
                        acc.THEM_KHOHANG(tbx_makho.Text, tbx_tenkho.Text, Convert.ToInt32(tbx_tongdmsp.Value), tbx_ghichu.Text);
                        KhoHang_Load(sender, e);
                        clearText();
                    }
                }
            }
            if(key == 2)
            {
                if (tbx_makho.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Đầy Đủ THông Tin Hoặc Chọn Dòng Bạn Muốn sửa!", "Thông Báo");
                    tbx_makho.Focus();
                }
                else
                {
                    acc.SUA_KHOHANG(tbx_makho.Text, tbx_tenkho.Text, Convert.ToInt32(tbx_tongdmsp.Value), tbx_ghichu.Text);
                    KhoHang_Load(sender, e);
                    clearText();
                    //bt_them.Enabled = true; bt_xoa.Enabled = false;
                }
            }
           
           if(key == 3)
            {
                if (tbx_makho.Text == "" || dgvKHOHANG.SelectedRows == null)
                {
                    MessageBox.Show("Hãy Nhập mã Kho Hàng Bạn Muốn Xóa hoặc Chọn Tại Bảng!", "Thông Báo");
                    tbx_makho.Focus();
                }
                else
                {
                    if (MessageBox.Show("Bạn có Chắc Chắn Muốn xóa Kho này?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //acc.Custom_ByQuery("UPDATE DANHMUC SET MAKHO=NULL WHERE MAKHO='" + this.tbx_makho.Text + "'");
                        //acc.Custom_ByQuery("UPDATE PHIEUNHAPKHO SET MAKHO=NULL WHERE MAKHO='" + this.tbx_makho.Text + "'");
                        //acc.Custom_ByQuery("UPDATE PHIEUXUAT SET MAKHO=NULL WHERE MAKHO='" + this.tbx_makho.Text + "'");
                        //acc.Custom_ByQuery("UPDATE BOPHAN SET MAKHO=NULL WHERE MAKHO='" + this.tbx_makho.Text + "'");
                        //acc.Custom_ByQuery("UPDATE BAOCAOTHONGKE SET MAKHO=NULL WHERE MAKHO='" + this.tbx_makho.Text + "'");                    
                        acc.XOA_KHOHANG(tbx_makho.Text);
                        KhoHang_Load(sender, e);
                        clearText();
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //bt_them.Enabled = true; btn_chophepsua.Enabled = false;
            KhoHang_Load(sender, e);
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

        private void button2_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btn_timkiem_Click_1(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "")
            {
                MessageBox.Show("Hãy Nhập Thông Tin cần Tìm Kiếm", "Thông Báo");
                tbx_timkiem.Focus();
                return;
            }
            else
            {
                groupBox_ketquatimkiem.Text = "Kết Quả Tìm Kiếm";
                dgvKHOHANG.DataSource = acc.Select_Data("SELECT * FROM KHOHANG WHERE MAKHO LIKE '%" + tbx_timkiem.Text + "%' OR TENKHO LIKE '%" + tbx_timkiem.Text + "%' OR TONGSODMSP LIKE '%" + tbx_timkiem.Text + "%' OR GHICHU LIKE '%" + tbx_timkiem.Text + "%'");
                tbx_timkiem.Clear();
                dgvKHOHANG.ClearSelection();
            }
        }
    }
}
