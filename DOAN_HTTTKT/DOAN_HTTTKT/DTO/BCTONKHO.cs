using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_HTTTKT.DTO
{
    class BCTONKHO
    {
        public BCTONKHO(string msbc, string mskho, string ngaylapbaocao, string thangbaocao, string tongsltondau, string tongtientondau, string tongsltoncuoi, string tongtientoncuoi, string tongslnhaptrongki, string tongtiennhaptrongki, string tongslnhapchuyenkho, string tongtiennhapchuyenkho, string tongslxuatchuyenkho, string tongtienxuatchuyenkho)
        {
            this.msbc = msbc;
            this.mskho = mskho;
            this.ngaylapbaocao = ngaylapbaocao;
            this.thangbaocao = thangbaocao;
            this.tongsltondau = tongsltondau;
            this.tongtientondau = tongtientondau;
            this.tongsltoncuoi = tongsltoncuoi;
            this.tongtientoncuoi = tongtientoncuoi;
            this.tongslnhaptrongki = tongslnhaptrongki;
            this.tongtiennhaptrongki = tongtiennhaptrongki;
            this.tongslnhapchuyenkho = tongslnhapchuyenkho;
            this.tongtiennhapchuyenkho = tongtiennhapchuyenkho;
            this.tongslxuatchuyenkho = tongslxuatchuyenkho;
            this.tongtienxuatchuyenkho = tongtienxuatchuyenkho;
        }

        public BCTONKHO(DataRow row)
        {
            this.msbc  = row["msbc"].ToString();
            this.mskho = row["mskho"].ToString();
            this.ngaylapbaocao = row["ngaylapbaocao"].ToString();
            this.thangbaocao = row["thangbaocao"].ToString();
            this.tongsltondau = row["tongsltondau"].ToString();
            this.tongtientondau = row["tongtientondau"].ToString();
            this.tongsltoncuoi =  row["tongsltoncuoi"].ToString();
            this.tongtientoncuoi = row["tongtientoncuoi"].ToString();
            this.tongslnhaptrongki = row["tongslnhaptrongki"].ToString();
            this.tongtiennhaptrongki = row["tongtiennhaptrongki"].ToString();
            this.tongslnhapchuyenkho  = row["tongslnhapchuyenkho"].ToString();
            this.tongtiennhapchuyenkho = row["tongtiennhapchuyenkho"].ToString();
            this.tongslxuatchuyenkho = row["tongslxuatchuyenkho"].ToString();
            this.tongtienxuatchuyenkho = row["tongtienxuatchuyenkho"].ToString();
        }

        private string msbc;
        private string mskho;
        private string ngaylapbaocao;
        private string thangbaocao;
        private string tongsltondau;
        private string tongtientondau;
        private string tongsltoncuoi;
        private string tongtientoncuoi;
        private string tongslnhaptrongki;
        private string tongtiennhaptrongki;
        private string tongslnhapchuyenkho;
        private string tongtiennhapchuyenkho;
        private string tongslxuatchuyenkho;
        private string tongtienxuatchuyenkho;


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

        public string Ngaylapbaocao
        {
            get
            {
                return ngaylapbaocao;
            }
            set
            {
                ngaylapbaocao = value;
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

        public string Tongslnhapchuyenkho
        {
            get
            {
                return tongslnhapchuyenkho;
            }
            set
            {
                tongslnhapchuyenkho = value;
            }
        }

        public string Tongtiennhapchuyenkho
        {
            get
            {
                return tongtiennhapchuyenkho;
            }
            set
            {
                tongtiennhapchuyenkho = value;
            }
        }

        public string Tongslxuatchuyenkho
        {
            get
            {
                return tongslxuatchuyenkho;
            }
            set
            {
                tongslxuatchuyenkho = value;
            }
        }

        public string Tongtienxuatchuyenkho
        {
            get
            {
                return tongtienxuatchuyenkho;
            }
            set
            {
                tongtienxuatchuyenkho = value;
            }
        }
    }
}
