using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DOAN_HTTTKT.DAO
{
    class PHIEU_XUAT_NGUYEN_LIEU
    {
        public static DataTable DemPhieuSo()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select PSO from PHIEUXUATNGUYENLIEU ORDER BY PSO DESC", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public static void ThemPhieuXuatNL(int MSPXNL, int MSKHO, int MSKHODEN,string LYDO
           , DateTime NGAYXUAT, int TONGTIENTT, string PHIEUSO,string NGUOIVANCHUYEN)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ThemPhieuXuatNL", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MSPXNL", SqlDbType.Int);
            cmd.Parameters.Add("@MSKHO", SqlDbType.Int);
            cmd.Parameters.Add("@MSKHODEN", SqlDbType.Int);
            cmd.Parameters.Add("@PHIEUSO", SqlDbType.VarChar);
            cmd.Parameters.Add("@LYDO", SqlDbType.NVarChar);
            cmd.Parameters.Add("@NGAYXUAT", SqlDbType.DateTime);
            cmd.Parameters.Add("@NGUOIVANCHUYEN", SqlDbType.NVarChar);
            cmd.Parameters.Add("@TONGTIENTT", SqlDbType.Int);

            cmd.Parameters["@MSPXNL"].Value = MSPXNL;
            cmd.Parameters["@PHIEUSO"].Value = PHIEUSO;
            cmd.Parameters["@MSKHO"].Value = MSKHO;
            cmd.Parameters["@MSKHODEN"].Value = MSKHODEN;
            cmd.Parameters["@LYDO"].Value = LYDO;
            cmd.Parameters["@NGAYXUAT"].Value = NGAYXUAT;
            cmd.Parameters["@NGUOIVANCHUYEN"].Value = NGUOIVANCHUYEN;
            cmd.Parameters["@TONGTIENTT"].Value = TONGTIENTT;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }

        public static void ThemCTPhieuXuatNguyenLieu(int MSPXNL, int MSNL, int SOLUONG, int DONGIA, int SOTIENXUAT, string DVT)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ThemCTPhieuXuatNL", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MSPXNL", SqlDbType.Int);
            cmd.Parameters.Add("@MSNL", SqlDbType.Int);
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int);
            cmd.Parameters.Add("@DONGIA", SqlDbType.Int);
            cmd.Parameters.Add("@DVT", SqlDbType.VarChar);
            cmd.Parameters.Add("@SOTIENXUAT", SqlDbType.Int);

            cmd.Parameters["@MSPXNL"].Value = MSPXNL;
            cmd.Parameters["@MSNL"].Value = MSNL;
            cmd.Parameters["@SOLUONG"].Value = SOLUONG;
            cmd.Parameters["@DONGIA"].Value = DONGIA;
            cmd.Parameters["@DVT"].Value = DVT;
            cmd.Parameters["@SOTIENXUAT"].Value = SOTIENXUAT;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }

        public static DataTable LayThongTinPhieuXuatNL(string dk)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUXUATNGUYENLIEU " + dk, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable LayThongTinCTPhieuNhapNL(string dk)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from CHITIET_XUATNGUYENLIEU " + dk, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void XoaPhieuXuatNguyenLieu(string PHIEUSO)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("XoaPhieuXuatNL", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PHIEUSO", SqlDbType.VarChar);
           
           
            cmd.Parameters["@PHIEUSO"].Value = PHIEUSO;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }

        public static void XoaCTPhieuXuatNguyenLieu(int MSPXNL)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("XoaCTPhieuXuatNL", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MSPXNL", SqlDbType.Int);


            cmd.Parameters["@MSPXNL"].Value = MSPXNL;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }

        public static DataTable LayPhieuXuatLieuByPhieuSo(string dk)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(MSPXNL) as count_mspn from PHIEUXUATNGUYENLIEU "+ dk, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void ChinhSuaPhieuXuatNL(int MSPXNL, int MSKHO, int MSKHODEN, string LYDO
           , DateTime NGAYXUAT, int TONGTIENTT, string PHIEUSO, string NGUOIVANCHUYEN)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ChinhSuaPhieuXuatNL", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MSPXNL", SqlDbType.Int);
            cmd.Parameters.Add("@MSKHO", SqlDbType.Int);
            cmd.Parameters.Add("@MSKHODEN", SqlDbType.Int);
            cmd.Parameters.Add("@PHIEUSO", SqlDbType.VarChar);
            cmd.Parameters.Add("@LYDO", SqlDbType.NVarChar);
            cmd.Parameters.Add("@NGAYXUAT", SqlDbType.DateTime);
            cmd.Parameters.Add("@NGUOIVANCHUYEN", SqlDbType.NVarChar);
            cmd.Parameters.Add("@TONGTIENTT", SqlDbType.Int);

            cmd.Parameters["@MSPXNL"].Value = MSPXNL;
            cmd.Parameters["@PHIEUSO"].Value = PHIEUSO;
            cmd.Parameters["@MSKHO"].Value = MSKHO;
            cmd.Parameters["@MSKHODEN"].Value = MSKHODEN;
            cmd.Parameters["@LYDO"].Value = LYDO;
            cmd.Parameters["@NGAYXUAT"].Value = NGAYXUAT;
            cmd.Parameters["@NGUOIVANCHUYEN"].Value = NGUOIVANCHUYEN;
            cmd.Parameters["@TONGTIENTT"].Value = TONGTIENTT;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }
    }
}
