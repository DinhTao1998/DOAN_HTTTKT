using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_HTTTKT.DTO
{
    class ChiTietNhapNguyenLieu
    {
        public ChiTietNhapNguyenLieu(string mscpn, string mspn, string msnl, string soluong, string dongia, string sotiennhap, string dvt, string dvtkhac)
        {
            this.msctpn = mscpn;
            this.mspn = mspn;
            this.msnl = msnl;
            this.soluong = soluong;
            this.dongia = dongia;
            this.sotiennhap = sotiennhap;
            this.dvt = dvt;
            this.dvtkhac = dvtkhac;
        }

        public ChiTietNhapNguyenLieu(DataRow row)
        {
            this.msctpn     = row["msctpn"].ToString();
            this.mspn       = row["mspn"].ToString();
            this.msnl = row["msnl"].ToString();
            this.soluong    = row["soluong"].ToString();
            this.dongia     = row["dongia"].ToString();
            this.sotiennhap = row["sotiennhap"].ToString();
            this.dvt        = row["dvt"].ToString();
        }

        private string msctpn;
        private string mspn;
        private string msnl;
        private string soluong;
        private string dongia;
        private string sotiennhap;
        private string dvt;
        private string dvtkhac;


        public string Msctpn
        {
            get
            {
                return msctpn;
            }
            set
            {
                msctpn = value;
            }
        }

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

        public string Msnl
        {
            get
            {
                return msnl;
            }
            set
            {
                msnl = value;
            }
        }

        public string Soluong
        {
            get
            {
                return soluong;
            }
            set
            {
                soluong = value;
            }
        }

        public string Dongia
        {
            get
            {
                return dongia;
            }
            set
            {
                dongia = value;
            }
        }


        public string Sotiennhap
        {
            get
            {
                return sotiennhap;
            }
            set
            {
                sotiennhap = value;
            }
        }

        public string Dvt
        {
            get
            {
                return dvt;
            }
            set
            {
                dvt = value;
            }
        }

        public string Dvtkhac
        {
            get
            {
                return dvtkhac;
            }
            set
            {
                dvtkhac = value;
            }
        }


    }
}

