using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_HTTTKT.DTO
{
    // Đây là nơi khai báo các model cho hệ thống. Mỗi bảng trong co sở dữ liệu sẽ là một model tương ứng với các class
    class HangHoa
    {
        // Khai báo constructer
        public HangHoa(string ma, string ten, string dvt, string loai)
        {
            this.ma = ma;
            this.loai = loai;
            this.ten = ten;
            this.dvt = dvt;
        }

        public HangHoa(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.ten = row["ten"].ToString();
            this.dvt = row["dvt"].ToString();
            this.loai = row["loai"].ToString();
        }// kết thúc khai báo constructer

        // Khai báo các thuộc tính trong bảng CSDL mỗi cột trong CSDL tương ứng với kiểu thuộc tính tương ứng
        private string ma;
        private string ten;
        private string dvt;
        private string loai;
        // End khai báo

            // Khai báo các phương thức get và set vho từng thuộc tính
        public string Ma
        {
            get
            {
                return ma;
            }
            set
            {
                ma = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }
            set
            {
                ten = value;
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
    }
}
