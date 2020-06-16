using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_HTTTKT.DTO
{
    class CTBCTONKHO
    {
        public CTBCTONKHO(string msct, string msbc, string sltondau, string tientondau, string sltoncuoi, string tientoncuoi, string slnhaptrongki, string tiennhaptrongki, string slnhapchuyenkho, string tienhapchuyenkho, string slxuatchuyenkho, string tienxuatchuyenkho)
        {
            this.msct = msct;
            this.msbc = msbc;
            this.sltondau = sltondau;
            this.tientondau = tientondau;
            this.sltoncuoi = sltoncuoi;
            this.tientoncuoi = tientoncuoi;
            this.slnhaptrongki = slnhaptrongki;
            this.tiennhaptrongki = tiennhaptrongki;
            this.slnhapchuyenkho = slnhapchuyenkho;
            this.tiennhapchuyenkho = tienhapchuyenkho;
            this.slxuatchuyenkho = slxuatchuyenkho;
            this.tienxuatchuyenkho = tienxuatchuyenkho;
        }

        public CTBCTONKHO(DataRow row)
        {
            this.msct = row["msct"].ToString();
            this.msbc = row["msbc"].ToString();
            this.sltondau = row["sltondau"].ToString();
            this.tientondau = row["tientondau"].ToString();
            this.sltoncuoi = row["sltoncuoi"].ToString();
            this.tientoncuoi = row["tientoncuoi"].ToString();
            this.slnhaptrongki = row["slnhaptrongki"].ToString();
            this.tiennhaptrongki = row["tiennhaptrongki"].ToString();
            this.slnhapchuyenkho = row["slnhapchuyenkho"].ToString();
            this.tiennhapchuyenkho = row["tiennhapchuyenkho"].ToString();
            this.slxuatchuyenkho = row["slxuatchuyenkho"].ToString();
            this.tienxuatchuyenkho = row["tienxuatchuyenkho"].ToString();
        }

        private string msct;
        private string msbc;
        private string ngaylapbaocao;
        private string thangbaocao;
        private string sltondau;
        private string tientondau;
        private string sltoncuoi;
        private string tientoncuoi;
        private string slnhaptrongki;
        private string tiennhaptrongki;
        private string slnhapchuyenkho;
        private string tiennhapchuyenkho;
        private string slxuatchuyenkho;
        private string tienxuatchuyenkho;


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

        public string Msbc
        {
            get
            {
                return msbc;
            }
            set
            {
                msbc = value;
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

        public string Tiennhaptrongki
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

        public string Slnhapchuyenkho
        {
            get
            {
                return slnhapchuyenkho;
            }
            set
            {
                slnhapchuyenkho = value;
            }
        }

        public string Tiennhapchuyenkho
        {
            get
            {
                return tiennhapchuyenkho;
            }
            set
            {
                tiennhapchuyenkho = value;
            }
        }

        public string Slxuatchuyenkho
        {
            get
            {
                return slxuatchuyenkho;
            }
            set
            {
                slxuatchuyenkho = value;
            }
        }

        public string Tienxuatchuyenkho
        {
            get
            {
                return tienxuatchuyenkho;
            }
            set
            {
                tienxuatchuyenkho = value;
            }
        }
    }
}
