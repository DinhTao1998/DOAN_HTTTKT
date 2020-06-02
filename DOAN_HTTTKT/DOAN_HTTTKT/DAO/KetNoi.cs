using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_HTTTKT.DAO
{
    class KetNoi
    {
        private static KetNoi instance;
        public string conn = @"Data Source=.\SQLEXPRESS;Initial Catalog=giavonhangban;Integrated Security=True";

        public static KetNoi Instance
        {
            get
            {
                if (instance == null)
                    instance = new KetNoi();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
    }
}
