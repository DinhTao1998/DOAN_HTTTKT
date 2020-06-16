using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_HTTTKT.DTO
{
    class TheKho
    {
        public TheKho(string msthekho, string mskho, string msnl, string ngaylapthekho, string thangbaocao, string tongsltondau, string tongtientondau, string tongsltoncuoi, string tongtientoncuoi, string tongslnhaptrongki, string tongtiennhaptrongki, string tongslxuattrongki, string tongtienxuattrongki)
        {
            this.msthekho = msthekho;
            this.mskho = mskho;
            this.msnl = msnl;
            this.ngaylapthekho = ngaylapthekho;
            this.thangbaocao = thangbaocao;
            this.tongsltondau = tongsltondau;
            this.tongtientondau = tongtientondau;
            this.tongsltoncuoi = tongsltoncuoi;
            this.tongtientoncuoi = tongtientoncuoi;
            this.tongslnhaptrongki = tongslnhaptrongki;
            this.tongtiennhaptrongki = tongtiennhaptrongki;
            this.tongslxuattrongki = tongslxuattrongki;
            this.tongtienxuattrongki = tongtienxuattrongki;
        }

        public TheKho(DataRow row)
        {
            this.msthekho = row["msthekho"].ToString();
            this.mskho = row["mskho"].ToString();
            this.msnl = row["msnl"].ToString();
            this.ngaylapbaocao = row["ngaylapbaocao"].ToString();
            this.thangbaocao = row["thangbaocao"].ToString();
            this.tongsltondau = row["tongsltondau"].ToString();
            this.tongtientondau = row["tongtientondau"].ToString();
            this.tongsltoncuoi = row["tongsltoncuoi"].ToString();
            this.tongtientoncuoi = row["tongtientoncuoi"].ToString();
            this.tongslnhaptrongki = row["tongslnhaptrongki"].ToString();
            this.tongtiennhaptrongki = row["tongtiennhaptrongki"].ToString();
            this.tongslxuattrongki = row["tongslxuattrongki"].ToString();
            this.tongtienxuattrongki = row["tongtienxuattrongki"].ToString();
        }

        private string msthekho;
        private string mskho;
        private string msnl;
        private string ngaylapthekho;
        private string thangbaocao;
        private string tongsltondau;
        private string tongtientondau;
        private string tongsltoncuoi;
        private string tongtientoncuoi;
        private string tongslnhaptrongki;
        private string tongtiennhaptrongki;
        private string tongslxuattrongki;
        private string tongtienxuattrongki;
        private string ngaylapbaocao;


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

        public string Ngaylapthekho
        {
            get
            {
                return ngaylapthekho;
            }
            set
            {
                ngaylapthekho = value;
            }
        }

        public string Thangbaocao
        {
            get
            {
                return thangbaocao;
            }
            set
            {
                thangbaocao = value;
            }
        }

        public string Tongsltondau
        {
            get
            {
                return tongsltondau;
            }
            set
            {
                tongsltondau = value;
            }
        }


        public string Tongtientondau
        {
            get
            {
                return tongtientondau;
            }
            set
            {
                tongtientondau = value;
            }
        }

        public string Tongtientoncuoi
        {
            get
            {
                return tongtientoncuoi;
            }
            set
            {
                tongtientoncuoi = value;
            }
        }

        public string Tongsltoncuoi
        {
            get
            {
                return tongsltoncuoi;
            }
            set
            {
                tongsltoncuoi = value;
            }
        }

        public string Tongslnhaptrongki
        {
            get
            {
                return tongslnhaptrongki;
            }
            set
            {
                tongslnhaptrongki = value;
            }
        }

        public string Tongtiennhaptrongki
        {
            get
            {
                return tongtiennhaptrongki;
            }
            set
            {
                tongtiennhaptrongki = value;
            }
        }

        public string Tongslxuattrongki
        {
            get
            {
                return tongslxuattrongki;
            }
            set
            {
                tongslxuattrongki = value;
            }
        }

        public string Tongtienxuattrongki
        {
            get
            {
                return tongtienxuattrongki;
            }
            set
            {
                tongtienxuattrongki = value;
            }
        }
    }
}
