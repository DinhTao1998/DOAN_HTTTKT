using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_HTTTKT.DTO
{
    class ChiTietXuatNguyenLieu
    {
        public ChiTietXuatNguyenLieu(string msctpxnl, string mspxnl, string msnl, string soluong, string sotienxuat, string dvt, string dvtkhac)
        {
            this.msctpxnl = msctpxnl;
            this.mspxnl = mspxnl;
            this.msnl = msnl;
            this.soluong = soluong;
            this.sotienxuat = sotienxuat;
            this.dvt = dvt;
            this.dvtkhac = dvtkhac;
        }

        public ChiTietXuatNguyenLieu(DataRow row)
        {
            this.msctpxnl = row["msctpxnl"].ToString();
            this.mspxnl = row["mspxnl"].ToString();
            this.msnl = row["msnl"].ToString();
            this.soluong = row["soluong"].ToString();
            this.sotienxuat = row["sotienxuat"].ToString();
            this.dvt = row["dvt"].ToString();
            this.dvtkhac = row["dvtkhac"].ToString();
        }

        private string msctpxnl;
        private string mspxnl;
        private string msnl;
        private string soluong;
        private string sotienxuat;
        private string dvt;
        private string dvtkhac;

        public string Msctpxnl
        {
            get
            {
                return msctpxnl;
            }
            set
            {
                msctpxnl = value;
            }
        }

        public string Mspxnl
        {
            get
            {
                return mspxnl;
            }
            set
            {
                mspxnl = value;
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

        public string Sotienxuat
        {
            get
            {
                return sotienxuat;
            }
            set
            {
                sotienxuat = value;
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
