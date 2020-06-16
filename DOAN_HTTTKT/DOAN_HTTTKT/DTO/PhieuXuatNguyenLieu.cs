using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_HTTTKT.DTO
{
    class PhieuXuatNguyenLieu
    {
        public PhieuXuatNguyenLieu(string mspxnl, string mskhoxuat, string mskhonhap, string pso, string nguoivanchuyen, string ngayxuat, string tongtien, string tongtientt, string lydo)
        {
            this.mspxnl = mspxnl;
            this.mskhoxuat = mskhoxuat;
            this.mskhonhap = mskhonhap;
            this.pso = pso;
            this.nguoivanchuyen = nguoivanchuyen;
            this.tongtien = tongtien;
            this.tongtientt = tongtientt;
            this.lydo = lydo;

        }

        public PhieuXuatNguyenLieu(DataRow row)
        {
            this.mspxnl = row["mspxnl"].ToString();
            this.mskhoxuat = row["mskhoxuat"].ToString();
            this.mskhonhap = row["mskhonhap"].ToString();
            this.pso = row["pso"].ToString();
            this.nguoivanchuyen = row["nguoivanchuyen"].ToString();
            this.tongtien = row["tongtien"].ToString();
            this.tongtientt = row["tongtientt"].ToString();
            this.lydo = row["lydo"].ToString();
        }

        private string mspxnl;
        private string mskhoxuat;
        private string mskhonhap;
        private string pso;
        private string nguoivanchuyen;
        private string tongtien;
        private string tongtientt;
        private string lydo;

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

        public string Mskhoxuat
        {
            get
            {
                return mskhoxuat;
            }
            set
            {
                mskhoxuat = value;
            }
        }

        public string Mskhonhap
        {
            get
            {
                return mskhonhap;
            }
            set
            {
                mskhonhap = value;
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


        public string Nguoivanchuyen
        {
            get
            {
                return nguoivanchuyen;
            }
            set
            {
                nguoivanchuyen = value;
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

        public string Tongtientt
        {
            get
            {
                return tongtientt;
            }
            set
            {
                tongtientt = value;
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

    }
}

