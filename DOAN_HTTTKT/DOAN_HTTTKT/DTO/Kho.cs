using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_HTTTKT.DTO
{
    class Kho
    {
        public Kho(string mskho, string tenkho, string diachi, string sdt)
        {
            this.mskho = mskho;
            this.tenkho = tenkho;
            this.diachi = diachi;
            this.sdt = sdt;
        }

        public Kho(DataRow row)
        {
            this.mskho = row["mskho"].ToString();
            this.tenkho = row["tenkho"].ToString();
            this.diachi = row["diachi"].ToString();
            this.sdt = row["sdt"].ToString();
        }

        private string mskho;
        private string tenkho;
        private string diachi;
        private string sdt;


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

        public string Tenkho
        {
            get
            {
                return tenkho;
            }
            set
            {
                tenkho = value;
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

    }
}

