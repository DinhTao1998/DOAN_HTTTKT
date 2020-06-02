using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOAN_HTTTKT.DAO
{
    class Logic
    {
        // Các sử lý dữ liệu và process cho dựa án
        // ví dụ
        public static DataTable LayDSHoaDon()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from cthoadonbanhang order by mahg, ngayb", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

    }
}
