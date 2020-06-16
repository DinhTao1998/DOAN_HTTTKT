using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_HTTTKT.DTO
{
    class NguyenLieu
    {
        //Khai báo constructer
        public NguyenLieu(string msnl,string tennl,string dongia,string dvt, string dvtkhac,string loai, string soluong)
        {
            this.msnl = msnl;
            this.tennl = tennl;
            this.dongia = dongia;
            this.dvt = dvt;
            this.dvtkhac = dvtkhac;
            this.loai = loai;
            this.soluong = soluong;
        }

        public NguyenLieu(DataRow row)
        {
            this.msnl = row["msnl"].ToString();
            this.tennl = row["tennl"].ToString();
            this.dongia = row["dongia"].ToString();
            this.dvt = row["dvt"].ToString();
            this.dvtkhac = row["dvtkhac"].ToString();
            this.loai = row["loai"].ToString();
            this.soluong = row["soluong"].ToString();
        }

        private string msnl;
        private string tennl;
        private string dongia;
        private string dvt;
        private string dvtkhac;
        private string loai;
        private string soluong;

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

        public string Tennl
        {
            get
            {
                return tennl;
            }
            set
            {
                tennl = value;
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

        public string Loai
        {
            get
            {
                return loai;
            }
            set
            {
                loai = value;
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

    }
}
