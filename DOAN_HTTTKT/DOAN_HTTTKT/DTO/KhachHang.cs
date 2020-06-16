using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_HTTTKT.DTO
{
    class KhachHang
    {
        public KhachHang(string mskh, string tenkhachhang, string diachi, string sdt, string sotaikhoan, string nganhang, string msthue)
        {
            this.mskh = mskh;
            this.tenkhachhang = tenkhachhang;
            this.diachi = diachi;
            this.sdt = sdt;
            this.sotaikhoan = sotaikhoan;
            this.nganhang = nganhang;
            this.msthue = msthue;
        }

        public KhachHang(DataRow row)
        {
            this.mskh = row["mskh"].ToString();
            this.tenkhachhang = row["tenkhachhang"].ToString();
            this.diachi = row["diachi"].ToString();
            this.sdt = row["sdt"].ToString();
            this.sotaikhoan = row["sotaikhoan"].ToString();
            this.nganhang = row["nganhang"].ToString();
            this.msthue = row["msthue"].ToString();
        }

        private string mskh;
        private string tenkhachhang;
        private string diachi;
        private string sdt;
        private string sotaikhoan;
        private string nganhang;
        private string msthue;


        public string Mskh
        {
            get
            {
                return mskh;
            }
            set
            {
                mskh = value;
            }
        }

        public string Tenkhachhang
        {
            get
            {
                return tenkhachhang;
            }
            set
            {
                tenkhachhang = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }
            set
            {
                diachi = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }

        public string Sotaikhoan
        {
            get
            {
                return sotaikhoan;
            }
            set
            {
                sotaikhoan = value;
            }
        }

        public string Nganhang
        {
            get
            {
                return nganhang;
            }
            set
            {
                nganhang = value;
            }
        }

        public string Msthue
        {
            get
            {
                return msthue;
            }
            set
            {
                msthue = value;
            }
        }
    }
}
