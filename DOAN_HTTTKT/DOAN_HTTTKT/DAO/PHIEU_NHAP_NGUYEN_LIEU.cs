using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOAN_HTTTKT.DAO
{
    class PHIEU_NHAP_NGUYEN_LIEU
    {
        public static DataTable layDanhSachKhachHang()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from KHACHHANG", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public static DataTable layDanhKho()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from KHO", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public static DataTable layDanhNguyenLieu()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NGUYENLIEU", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public static  DataTable DemPhieuSo()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select PSO from PHIEUNHAPNGUYENLIEU ORDER BY PSO DESC", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public static DataTable LayThongTinNL(string dk)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NGUYENLIEU", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void ThemPhieuNhapNL(int MSPN, int MSKH, int MSKHO, int THUESUAT,string SOHOADON, DateTime NGAYHOADON,string LYDO
            ,DateTime NGAYNHAP, int TONGTIEN, int TONGTIENTT,string PHIEUSO)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ThemPhieuNhapNL", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MSPN", SqlDbType.Int);
            cmd.Parameters.Add("@MSKH", SqlDbType.Int);
            cmd.Parameters.Add("@MSKHO", SqlDbType.Int);
            cmd.Parameters.Add("@PHIEUSO", SqlDbType.VarChar);
            cmd.Parameters.Add("@THUESUAT", SqlDbType.Int);
            cmd.Parameters.Add("@SOHOADON", SqlDbType.VarChar);
            cmd.Parameters.Add("@NGAYHOADON", SqlDbType.DateTime);
            cmd.Parameters.Add("@LYDO", SqlDbType.NVarChar);
            cmd.Parameters.Add("@NGAYNHAP", SqlDbType.DateTime);
            cmd.Parameters.Add("@TONGTIEN", SqlDbType.Int);
            cmd.Parameters.Add("@TONGTIENTT", SqlDbType.Int);

            cmd.Parameters["@MSPN"].Value = MSPN;
            cmd.Parameters["@PHIEUSO"].Value = PHIEUSO;
            cmd.Parameters["@MSKH"].Value = MSKH;
            cmd.Parameters["@MSKHO"].Value = MSKHO;
            cmd.Parameters["@THUESUAT"].Value = THUESUAT;
            cmd.Parameters["@SOHOADON"].Value = SOHOADON;
            cmd.Parameters["@NGAYHOADON"].Value = NGAYHOADON;
            cmd.Parameters["@LYDO"].Value = LYDO;
            cmd.Parameters["@NGAYNHAP"].Value = NGAYNHAP;
            cmd.Parameters["@TONGTIEN"].Value = TONGTIEN;
            cmd.Parameters["@TONGTIENTT"].Value = TONGTIENTT;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }
        public static void ThemCTPhieuNhapLieu(int MSPN, int MSNL, int SOLUONG, int DONGIA, int SOTIENNHAP, string DVT)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ThemCTPhieuNhapNL", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MSPN", SqlDbType.Int);
            cmd.Parameters.Add("@MSNL", SqlDbType.Int);
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int);
            cmd.Parameters.Add("@DONGIA", SqlDbType.Int);
            cmd.Parameters.Add("@DVT", SqlDbType.VarChar);
            cmd.Parameters.Add("@SOTIENNHAP", SqlDbType.Int);

            cmd.Parameters["@MSPN"].Value = MSPN;
            cmd.Parameters["@MSNL"].Value = MSNL;
            cmd.Parameters["@SOLUONG"].Value = SOLUONG;
            cmd.Parameters["@DONGIA"].Value = DONGIA;
            cmd.Parameters["@DVT"].Value = DVT;
            cmd.Parameters["@SOTIENNHAP"].Value = SOTIENNHAP;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }

        public static void XoaPhieuNhapLieu(string PHIEUSO)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("XoaPhieuNhapNL", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PHIEUSO", SqlDbType.VarChar);
           
            cmd.Parameters["@PHIEUSO"].Value = PHIEUSO;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }
        public static DataTable LayPhieuNhapLieuByPhieuSo(string dk)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(MSPN) as count_mspn from PHIEUNHAPNGUYENLIEU "+ dk, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void XoaCTPhieuNhapLieu(string MSPN)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("XoaCTPhieuNhapNL", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MSPN", SqlDbType.Int);

            cmd.Parameters["@MSPN"].Value = MSPN;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }

        public static DataTable LayThongTinPhieuNhapNL(string dk)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUNHAPNGUYENLIEU "+ dk, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable LayThongTinCTPhieuNhapNL(string dk)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from CHITIET_NHAPNGUYENLIEU "+dk, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable LayThongTin1NL(string dk)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NGUYENLIEU " + dk, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void ChinhSuaPhieuNhapNL(int MSPN, int MSKH, int MSKHO, int THUESUAT, string SOHOADON, DateTime NGAYHOADON, string LYDO
            , DateTime NGAYNHAP, int TONGTIEN, int TONGTIENTT, string PHIEUSO)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ChinhSuaPhieuNhapNL", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MSPN", SqlDbType.Int);
            cmd.Parameters.Add("@MSKH", SqlDbType.Int);
            cmd.Parameters.Add("@MSKHO", SqlDbType.Int);
            cmd.Parameters.Add("@PHIEUSO", SqlDbType.VarChar);
            cmd.Parameters.Add("@THUESUAT", SqlDbType.Int);
            cmd.Parameters.Add("@SOHOADON", SqlDbType.VarChar);
            cmd.Parameters.Add("@NGAYHOADON", SqlDbType.DateTime);
            cmd.Parameters.Add("@LYDO", SqlDbType.NVarChar);
            cmd.Parameters.Add("@NGAYNHAP", SqlDbType.DateTime);
            cmd.Parameters.Add("@TONGTIEN", SqlDbType.Int);
            cmd.Parameters.Add("@TONGTIENTT", SqlDbType.Int);

            cmd.Parameters["@MSPN"].Value = MSPN;
            cmd.Parameters["@PHIEUSO"].Value = PHIEUSO;
            cmd.Parameters["@MSKH"].Value = MSKH;
            cmd.Parameters["@MSKHO"].Value = MSKHO;
            cmd.Parameters["@THUESUAT"].Value = THUESUAT;
            cmd.Parameters["@SOHOADON"].Value = SOHOADON;
            cmd.Parameters["@NGAYHOADON"].Value = NGAYHOADON;
            cmd.Parameters["@LYDO"].Value = LYDO;
            cmd.Parameters["@NGAYNHAP"].Value = NGAYNHAP;
            cmd.Parameters["@TONGTIEN"].Value = TONGTIEN;
            cmd.Parameters["@TONGTIENTT"].Value = TONGTIENTT;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }
    }
}
