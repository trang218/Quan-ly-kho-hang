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
    public partial class DoiQuyen : Form
    {
        public static string USERNAME = "";
        public static string QuyenHan = "";
        accessData acc = new accessData();
        public DoiQuyen()
        {
            InitializeComponent();
        }

        public DataTable QH(string USERNAME)
        {
            accessData acc = new accessData();
            SqlDataReader a = acc.ExecuteReader("SELECT QUYENHAN FROM DANGNHAP WHERE USERNAME='" + USERNAME + "'");
            while (a.Read())
            {
                QuyenHan = a["QUYENHAN"].ToString();

            }
            return null;
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Hủy Thao Tác?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {

            }
        }

        private void btn_dq_Click(object sender, EventArgs e)
        {
            accessData access = new accessData();
            if (tbx_tdn.Text == null )
            {
                SqlDataReader reader = access.ExecuteReader("select QUYENHAN from DANGNHAP where USERNAME= '" + USERNAME + "'");
                while (reader.Read() == true)
                {
                    string sql = "update DANGNHAP set QUYENHAN ='" + tbx_quyenmoi.Text + "' where USERNAME ='" + USERNAME + "'";
                    if (tbx_quyencu.Text == "" || tbx_quyenmoi.Text == "")
                    {
                        MessageBox.Show("Yêu cầu điền đủ vào các mục");
                    }
                    else
                    {
                        if (tbx_quyenmoi.Text == tbx_quyencu.Text)
                        {
                            MessageBox.Show("Quyền Hạn mới phải khác Quyền Hạn cũ!");
                            tbx_quyenmoi.Clear();
                        }
                        else
                        {
                            if (access.executenonquery(sql) == true)
                            {
                                MessageBox.Show("Cập nhật quyền hạn thành công");
                                this.Hide();
                            }
                        }
                    }
                }
            }
            else
            {
                SqlDataReader reader = access.ExecuteReader("select QUYENHAN from DANGNHAP where USERNAME= '" + tbx_tdn.Text + "'");
                while (reader.Read() == true)
                {
                    string sql = "update DANGNHAP set QUYENHAN ='" + tbx_quyenmoi.Text + "' where USERNAME ='" + tbx_tdn.Text + "'";
                    if (tbx_quyencu.Text == "" || tbx_quyenmoi.Text == "")
                    {
                        MessageBox.Show("Yêu cầu điền đủ vào các mục");
                    }
                    else
                    {
                        if (tbx_quyenmoi.Text == tbx_quyencu.Text)
                        {
                            MessageBox.Show("Quyền Hạn mới phải khác Quyền Hạn cũ!");
                            tbx_quyenmoi.Clear();
                        }
                        else
                        {
                            if (access.executenonquery(sql) == true)
                            {
                                MessageBox.Show("Cập nhật quyền hạn thành công");
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }

        private void DoiQuyen_Load(object sender, EventArgs e)
        {
            acc.AutoComplete(tbx_tdn, "SELECT USERNAME FROM DANGNHAP");
            acc.AutoComplete(tbx_quyencu, "SELECT QUYENHAN FROM DANGNHAP");
            acc.AutoComplete(tbx_quyenmoi, "SELECT QUYENHAN FROM DANGNHAP");
        }

        private void tbx_tdn_Validated(object sender, EventArgs e)
        {
            if( tbx_tdn.Text == null)
            {
                tbx_tdn.Enabled = false;
                QH(USERNAME);
                tbx_quyencu.Text = QuyenHan.Trim();
            }
            else
            {
                QH(tbx_tdn.Text);
                tbx_quyencu.Text = QuyenHan.Trim();
            }
        }
    }
}
