using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOAN_HTTTKT.DAO
{
    class NGUYEN_LIEU
    {
        public static void ThemDMNguyenLieu(string TENNL, int DONGIA, string DVT, int SOLUONG)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ThemDMNguyenLieu", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TENNL", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DONGIA", SqlDbType.Int);
            cmd.Parameters.Add("@DVT", SqlDbType.NVarChar);
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int);
           

            cmd.Parameters["@TENNL"].Value = TENNL;
            cmd.Parameters["@DONGIA"].Value = DONGIA;
            cmd.Parameters["@DVT"].Value = DVT;
            cmd.Parameters["@SOLUONG"].Value = SOLUONG;
          
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }

        public static void ChinhSuaDMNguyenLieu(int MSNL,string TENNL, int DONGIA, string DVT, int SOLUONG)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ChinhSuaDMNguyenLieu", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MSNL", SqlDbType.Int);
            cmd.Parameters.Add("@TENNL", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DONGIA", SqlDbType.Int);
            cmd.Parameters.Add("@DVT", SqlDbType.NVarChar);
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int);

            cmd.Parameters["@MSNL"].Value = MSNL;
            cmd.Parameters["@TENNL"].Value = TENNL;
            cmd.Parameters["@DONGIA"].Value = DONGIA;
            cmd.Parameters["@DVT"].Value = DVT;
            cmd.Parameters["@SOLUONG"].Value = SOLUONG;

            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }

        public static void TruBotNguyenLieu(int MSNL, int SOLUONG)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("TruBotNguyenLieu", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MSNL", SqlDbType.Int);
            
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int);

            cmd.Parameters["@MSNL"].Value = MSNL;
           
            cmd.Parameters["@SOLUONG"].Value = SOLUONG;

            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }

        public static void CongThemNguyenLieu(int MSNL, int SOLUONG)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("CongThemNguyenLieu", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MSNL", SqlDbType.Int);

            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int);

            cmd.Parameters["@MSNL"].Value = MSNL;

            cmd.Parameters["@SOLUONG"].Value = SOLUONG;

            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }
        public static DataTable layDanhSachNguyenLieu()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MSNL, DONGIA, DVT, TENNL, SOLUONG from NGUYENLIEU", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}
