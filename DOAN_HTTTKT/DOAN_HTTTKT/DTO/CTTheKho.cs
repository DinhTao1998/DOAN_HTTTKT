using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_HTTTKT.DTO
{
    class CTTheKho
    {
        public CTTheKho(string msct, string mskh, string mskho, string msthekho, string mspxnl, string ngaynhapxuat, string sohoadon,   string sltondau, string tientondau, string sltoncuoi, string tientoncuoi, string slnhaptrongki, string tiennhaptrongki, string slxuattrongki, string tienxuattrongki)
        {
            this.msct = msct;
            this.mskh = mskh;
            this.mskho = mskho;
            this.msthekho = msthekho;
            this.mspxnl = mspxnl;
            this.ngaynhapxuat = ngaynhapxuat;
            this.sohoadon = sohoadon;
            this.sltondau = sltondau;
            this.tientondau = tientondau;
            this.sltoncuoi = sltoncuoi;
            this.tientoncuoi = tientoncuoi;
            this.slnhaptrongki = slnhaptrongki;
            this.tiennhaptrongki = tiennhaptrongki;
            this.slxuattrongki = slxuattrongki;
            this.tienxuattrongki = tienxuattrongki;
        }

        public CTTheKho(DataRow row)
        {
            this.msct = row["msct"].ToString();
            this.mskh = row["mskh"].ToString();
            this.mskho = row["mskho"].ToString();
            this.msthekho = row["msthekho"].ToString();
            this.ngaynhapxuat = row["ngaynhapxuat"].ToString();
            this.sohoadon = row["sohoadon"].ToString();
            this.sltondau = row["sltondau"].ToString();
            this.tientondau = row["tientondau"].ToString();
            this.sltoncuoi = row["sltoncuoi"].ToString();
            this.tientoncuoi = row["tientoncuoi"].ToString();
            this.slnhaptrongki = row["slnhaptrongki"].ToString();
            this.tiennhaptrongki = row["tiennhaptrongki"].ToString();
            this.slxuattrongki = row["slxuattrongki"].ToString();
            this.tienxuattrongki = row["tienxuattrongki"].ToString();
        }

        private string msct;
        private string mskh;
        private string mskho;
        private string msthekho;
        private string ngaynhapxuat;
        private string sohoadon;
        private string sltondau;
        private string tientondau;
        private string sltoncuoi;
        private string tientoncuoi;
        private string slnhaptrongki;
        private string tiennhaptrongki;
        private string slxuattrongki;
        private string tienxuattrongki;
        private string mspxnl;


        public string Msct
        {
            get
            {
                return msct;
            }
            set
            {
                msct = value;
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

        public string Msthekho
        {
            get
            {
                return msthekho;
            }
            set
            {
                msthekho = value;
            }
        }

        public string Ngaynhapxuat
        {
            get
            {
                return ngaynhapxuat;
            }
            set
            {
                ngaynhapxuat = value;
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

        public string Sltondau
        {
            get
            {
                return sltondau;
            }
            set
            {
                sltondau = value;
            }
        }


        public string Tientondau
        {
            get
            {
                return tientondau;
            }
            set
            {
                tientondau = value;
            }
        }

        public string Tientoncuoi
        {
            get
            {
                return tientoncuoi;
            }
            set
            {
                tientoncuoi = value;
            }
        }

        public string Sltoncuoi
        {
            get
            {
                return sltoncuoi;
            }
            set
            {
                sltoncuoi = value;
            }
        }

        public string Slnhaptrongki
        {
            get
            {
                return slnhaptrongki;
            }
            set
            {
                slnhaptrongki = value;
            }
        }

        public string Siennhaptrongki
        {
            get
            {
                return tiennhaptrongki;
            }
            set
            {
                tiennhaptrongki = value;
            }
        }


        public string Slxuattrongki
        {
            get
            {
                return slxuattrongki;
            }
            set
            {
                slxuattrongki = value;
            }
        }

        public string Tienxuattrongki
        {
            get
            {
                return tienxuattrongki;
            }
            set
            {
                tienxuattrongki = value;
            }
        }
    }
}
