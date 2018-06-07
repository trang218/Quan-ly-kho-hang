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
    
    public partial class Doimatkhau : Form
    {
        public static string USERNAME = "";
        public static string QUYENHAN = "";
        public Doimatkhau()
        {
            InitializeComponent();
        }

        private void btn_DMK_Click(object sender, EventArgs e)
        {
            accessData access = new accessData();
            if(tbx_tdn.Text == "")
            {
                SqlDataReader reader = access.ExecuteReader("select Password from DANGNHAP where USERNAME= '" + USERNAME + "'");
                while (reader.Read() == true)
                {
                    string sql = "update DANGNHAP set PASSWORD ='" + tbx_matkhaumoi.Text + "' where USERNAME ='" + USERNAME + "'";
                    if (tbx_matkhaucu.Text == "" || tbx_matkhaumoi.Text == "" || tbx_nlmatkhaumoi.Text == "")
                    {
                        MessageBox.Show("Yêu cầu điền đủ vào các mục");
                    }
                    else
                    {
                        if (tbx_matkhaumoi.Text != tbx_nlmatkhaumoi.Text)
                        {
                            MessageBox.Show("Mật khẩu thay thế phải trùng nhau");
                        }
                        else
                        {
                            if (access.executenonquery(sql) == true)
                            {
                                MessageBox.Show("Cập nhật mật khẩu  thành công");
                                this.Hide();
                            }
                        }
                    }
                }
                tbx_matkhaucu.Clear();
            }
            else
            {
                SqlDataReader reader = access.ExecuteReader("select Password from DANGNHAP where USERNAME= '" + tbx_tdn.Text + "'");
                while (reader.Read() == true)
                {
                    string sql = "update DANGNHAP set PASSWORD ='" + tbx_matkhaumoi.Text + "' where USERNAME ='" + tbx_tdn.Text + "'";
                    if (tbx_matkhaucu.Text == "" || tbx_matkhaumoi.Text == "" || tbx_nlmatkhaumoi.Text == "")
                    {
                        MessageBox.Show("Yêu cầu điền đủ vào các mục");
                    }
                    else
                    {
                        if (tbx_matkhaumoi.Text != tbx_nlmatkhaumoi.Text)
                        {
                            MessageBox.Show("Mật khẩu thay thế phải trùng nhau");
                        }
                        else
                        {
                            if (access.executenonquery(sql) == true)
                            {
                                MessageBox.Show("Cập nhật mật khẩu  thành công");
                                this.Hide();
                            }
                        }
                    }
                }
                tbx_matkhaucu.Clear();
            }     
        }

        private void Doimatkhau_Load(object sender, EventArgs e)
        {
            if (QUYENHAN == "ADMIN     " || QUYENHAN == "Admin     " || QUYENHAN == "admin     ")
            {
                    
            }
            else
            {
                tbx_tdn.Enabled = false;
            }
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
    }
}
