using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_HTTTKT.DTO
{
    class PhieuNhapNguyenLieu
    {
        public PhieuNhapNguyenLieu(string mspn, string mskh, string mskho, string pso, string thuesuat, string sohoadon, string ngayhoadon, string lydo, string ngaynhap, string tongtien)
        {
            this.mspn = mspn;
            this.mskh = mskh;
            this.mskho = mskho;
            this.pso = pso;
            this.thuesuat = thuesuat;
            this.sohoadon = sohoadon;
            this.ngayhoadon = ngayhoadon;
            this.lydo = lydo;
            this.ngaynhap = ngaynhap;
            this.tongtien = tongtien;
        }

        public PhieuNhapNguyenLieu(DataRow row)
        {
            this.mspn = row["mspn"].ToString();
            this.mskh = row["mskh"].ToString();
            this.mskho = row["mskho"].ToString();
            this.pso = row["pso"].ToString();
            this.thuesuat = row["thuesuat"].ToString();
            this.sohoadon = row["sohoadon"].ToString();
            this.ngayhoadon = row["ngayhoadon"].ToString();
            this.lydo = row["lydo"].ToString();
            this.ngaynhap = row["ngaynhap"].ToString();
            this.tongtien = row["tongtien"].ToString();
        }

        private string mspn;
        private string mskh;
        private string mskho;
        private string pso;
        private string thuesuat;
        private string sohoadon;
        private string ngayhoadon;
        private string lydo;
        private string ngaynhap;
        private string tongtien; 
        
        
        public string Mspn
        {
            get
            {
                return mspn;
            }
            set
            {
                mspn = value;
            }
        }

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

        public string Mskho
        {
            get
            {
                return mskho;
            }
            set
            {
                mskho = value;
            }
        }

        public string Pso
        {
            get
            {
                return pso;
            }
            set
            {
                pso = value;
            }
        }


        public string Thuesuat
        {
            get
            {
                return thuesuat;
            }
            set
            {
                thuesuat = value;
            }
        }

        public string Sohoadon
        {
            get
            {
                return sohoadon;
            }
            set
            {
                sohoadon = value;
            }
        }

        public string Ngayhoadon
        {
            get
            {
                return ngayhoadon;
            }
            set
            {
                ngayhoadon = value;
            }
        }

        public string Lydo
        {
            get
            {
                return lydo;
            }
            set
            {
                lydo = value;
            }
        }

        public string Ngaynhap
        {
            get
            {
                return ngaynhap;
            }
            set
            {
                ngaynhap = value;
            }
        }

        public string Tongtien
        {
            get
            {
                return tongtien;
            }
            set
            {
                tongtien = value;
            }
        }

    }
}
