using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_QLKH.Control
{
    class Control_ThemTaiKhoan
    {
        accessData acc = new accessData();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        public SqlCommand Them_TaiKhoan(string username, string password, string manv, string quyenhan)
        {
            acc.getconnection();
            cmd = new SqlCommand("THEM_TAIKHOAN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@manv", manv));
            cmd.Parameters.Add(new SqlParameter("@quyenhan", quyenhan));       
            cmd.ExecuteNonQuery();
            return cmd;
        }

        public SqlCommand Update_TaiKhoan(string username, string password, string manv, string quyenhan)
        {
            acc.OpenConnect();
            cmd = new SqlCommand("UPDATE_TAIKHOAN", con);
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@manv", manv));
            cmd.Parameters.Add(new SqlParameter("@quyenhan", quyenhan));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            acc.CloseConnect();
            return cmd;
        }
    }
}
