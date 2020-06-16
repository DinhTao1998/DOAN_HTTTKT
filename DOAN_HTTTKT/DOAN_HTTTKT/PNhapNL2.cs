using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN_HTTTKT.DAO;

namespace DOAN_HTTTKT
{
    public partial class PNhapNL2 : Form
    {
        public PNhapNL2()
        {
            InitializeComponent();
            DataTable dt = PHIEU_NHAP_NGUYEN_LIEU.DemPhieuSo();
            /*string PhieuSo = "PN";
            string count = dt.Rows[0]["SoPhieu"].ToString();
            char pad = '0';
            count = count.PadLeft(7,pad);*/
            txtbPhieuSo.Text = PhieuSoNext();
            btnReset.Visible = true;
            btnSaveEdit.Visible = false;
            btnEdit.Visible = false;

        }

        public void load_MaKho()
        {
            cbbMaKho.DataSource = PHIEU_NHAP_NGUYEN_LIEU.layDanhKho();
            cbbMaKho.DisplayMember = "MSKHO";
            cbbMaKho.ValueMember = "MSKHO";
            txtTenCH.DataBindings.Add("TEXT", cbbMaKho.DataSource, "TENKHO");

        }

        public void load_NguyenLieu()
        {
            MSNL.DataSource = PHIEU_NHAP_NGUYEN_LIEU.layDanhNguyenLieu();
            MSNL.DisplayMember = "MSNL";
            MSNL.ValueMember = "MSNL";
        }

        public void load_MaKH()
        {
            cbbMaKH.DataSource = PHIEU_NHAP_NGUYEN_LIEU.layDanhSachKhachHang();
            cbbMaKH.DisplayMember = "MSKH";
            cbbMaKH.ValueMember = "MSKH";
            txtTenKH.DataBindings.Add("TEXT", cbbMaKH.DataSource, "TENKH");
            txtDiaChiKH.DataBindings.Add("TEXT", cbbMaKH.DataSource, "DIACHI");
            txtSDTKH.DataBindings.Add("TEXT", cbbMaKH.DataSource, "SDT");
            txtMSTKH.DataBindings.Add("TEXT", cbbMaKH.DataSource, "MSTHUE");

        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PNhapNL2_Load(object sender, EventArgs e)
        {
            load_MaKho();
            load_MaKH();
            load_NguyenLieu();
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            txtTongTien.Text = "0";
            txtTienChu.Text = "";
            txtThanhToan.Text = "0";
            txtVat2.Text = "0";
            txtVat1.Text = "0";
            btnThemMoi.Visible = false;
          
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = true;
            double tongtien = 0;
            for(int i =0; i< dgvNL.Rows.Count -1; i++)
            {
                SOLUONG.ReadOnly = true;
                DataTable dt = new DataTable();
                dt = PHIEU_NHAP_NGUYEN_LIEU.LayThongTinNL("Where MSNL ='" + dgvNL.Rows[i].Cells[0].Value.ToString() + "'");
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dgvNL.Rows[i].Cells[0].Value.ToString() == dt.Rows[j]["MSNL"].ToString())
                    {
                        SOLUONG.ReadOnly = false;
                        dgvNL.Rows[i].Cells[1].Value = dt.Rows[j]["TENNL"].ToString();
                        dgvNL.Rows[i].Cells[2].Value = dt.Rows[j]["LOAI"].ToString();
                        if (dt.Rows[j]["DVT"].ToString() == "bao" || dt.Rows[j]["DVT"].ToString() == "bình" || dt.Rows[j]["DVT"].ToString() == "cây")
                        {
                            dgvNL.Rows[i].Cells[3].Value = dt.Rows[j]["DVT"].ToString();
                            dgvNL.Rows[i].Cells[4].Value = "";
                        }
                        else { dgvNL.Rows[i].Cells[4].Value = dt.Rows[j]["DVT"].ToString();
                            dgvNL.Rows[i].Cells[3].Value = "";
                        }
                        dgvNL.Rows[i].Cells[6].Value = dt.Rows[j]["DONGIA"].ToString();
                        break;
                    }
                }
                int dg = Convert.ToInt32(dgvNL.Rows[i].Cells[6].Value);
                int sl = 1;
                int n = 0;
                //// Kiểm tra số lượng nhập vào có phải là kí số hay không
                if (dgvNL.Rows[i].Cells[5].Value != null)
                {
                    if (int.TryParse(this.dgvNL.Rows[i].Cells[5].Value.ToString(), out n))
                        sl = Convert.ToInt32(dgvNL.Rows[i].Cells[5].Value);
                    else
                    {
                        if (dgvNL.Rows[i].Cells[5].Value.ToString() != "")
                            MessageBox.Show("Số lượng phải là ký số");
                            dgvNL.Rows[i].Cells[5].Value = 1;
                    }
                }
                else
                    dgvNL.Rows[i].Cells[5].Value = 1;
                ////
                double thanhtien = dg * sl;
                dgvNL.Rows[i].Cells[7].Value = Convert.ToString(thanhtien);
                tongtien = tongtien + thanhtien;
            }
            txtTongTien.Text = Convert.ToString(tongtien);
            txtThanhToan.Text = Convert.ToString(tongtien);
            txtTienChu.Text = NumberToTextVN(decimal.Parse(tongtien.ToString()));
        }

        private void dgvNL_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double tongtien = 0;
            for (int i = 0; i < dgvNL.Rows.Count - 1; i++)
            {
                double thanhtien = Convert.ToDouble(dgvNL.Rows[i].Cells[7].Value);
                tongtien = tongtien + thanhtien;
            }

            txtTongTien.Text = Convert.ToString(tongtien);
            txtThanhToan.Text = Convert.ToString(tongtien);
            txtTienChu.Text = NumberToTextVN(decimal.Parse(tongtien.ToString()));

        }

        private void txtVat2_TextChanged(object sender, EventArgs e)
        {
           

        }

        public String NumberToTextVN(decimal total)
        {
            try
            {
                string rs = "";
                total = Math.Round(total, 0);
                string[] ch = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string[] rch = { "lẻ", "mốt", "", "", "", "lăm" };
                string[] u = { "", "mươi", "trăm", "ngàn", "", "", "triệu", "", "", "tỷ", "", "", "ngàn", "", "", "triệu" };
                string nstr = total.ToString();

                int[] n = new int[nstr.Length];
                int len = n.Length;
                for (int i = 0; i < len; i++)
                {
                    n[len - 1 - i] = Convert.ToInt32(nstr.Substring(i, 1));
                }

                for (int i = len - 1; i >= 0; i--)
                {
                    if (i % 3 == 2)// số 0 ở hàng trăm
                    {
                        if (n[i] == 0 && n[i - 1] == 0 && n[i - 2] == 0) continue;//nếu cả 3 số là 0 thì bỏ qua không đọc
                    }
                    else if (i % 3 == 1) // số ở hàng chục
                    {
                        if (n[i] == 0)
                        {
                            if (n[i - 1] == 0) { continue; }// nếu hàng chục và hàng đơn vị đều là 0 thì bỏ qua.
                            else
                            {
                                rs += " " + rch[n[i]]; continue;// hàng chục là 0 thì bỏ qua, đọc số hàng đơn vị
                            }
                        }
                        if (n[i] == 1)//nếu số hàng chục là 1 thì đọc là mười
                        {
                            rs += " mười"; continue;
                        }
                    }
                    else if (i != len - 1)// số ở hàng đơn vị (không phải là số đầu tiên)
                    {
                        if (n[i] == 0)// số hàng đơn vị là 0 thì chỉ đọc đơn vị
                        {
                            if (i + 2 <= len - 1 && n[i + 2] == 0 && n[i + 1] == 0) continue;
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 1)// nếu là 1 thì tùy vào số hàng chục mà đọc: 0,1: một / còn lại: mốt
                        {
                            rs += " " + ((n[i + 1] == 1 || n[i + 1] == 0) ? ch[n[i]] : rch[n[i]]);
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 5) // cách đọc số 5
                        {
                            if (n[i + 1] != 0) //nếu số hàng chục khác 0 thì đọc số 5 là lăm
                            {
                                rs += " " + rch[n[i]];// đọc số 
                                rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);// đọc đơn vị
                                continue;
                            }
                        }
                    }

                    rs += (rs == "" ? " " : ", ") + ch[n[i]];// đọc số
                    rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);// đọc đơn vị
                }
                if (rs[rs.Length - 1] != ' ')
                    rs += " đồng";
                else
                    rs += "đồng";

                if (rs.Length > 2)
                {
                    string rs1 = rs.Substring(0, 2);
                    rs1 = rs1.ToUpper();
                    rs = rs.Substring(2);
                    rs = rs1 + rs;
                }
                return rs.Trim().Replace("lẻ,", "lẻ").Replace("mươi,", "mươi").Replace("trăm,", "trăm").Replace("mười,", "mười");
            }
            catch
            {
                return "";
            }

        }
        public void Reset()
        {
            this.Close();
            PNhapNL2 formPNhapNL2 = new PNhapNL2();
            formPNhapNL2.Show();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn lưu dữ liệu không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                DataTable dt = PHIEU_NHAP_NGUYEN_LIEU.DemPhieuSo();
                int MSPN = 1;
                if (dt.Rows.Count > 0)
                {
                    string current = dt.Rows[0]["PSO"].ToString();
                    current = current.Substring(2);
                    int cur = int.Parse(current);
                    cur = cur + 1;
                    MSPN = cur;
                }
                PHIEU_NHAP_NGUYEN_LIEU.ThemPhieuNhapNL(MSPN, int.Parse(cbbMaKH.SelectedValue.ToString()), int.Parse(cbbMaKho.SelectedValue.ToString())
                    , int.Parse(txtVat1.Text.ToString()),txtHDNhap.Text.ToString(),dtpNgayPHHD.Value.Date,txtLido.Text.ToString(),
                    dtpNgayNhap.Value.Date, int.Parse(txtTongTien.Text.ToString()), int.Parse(txtThanhToan.Text.ToString()),txtbPhieuSo.Text.ToString());
                DataTable dt1 = PHIEU_NHAP_NGUYEN_LIEU.LayThongTinPhieuNhapNL("WHERE PSO = '" + txtbPhieuSo.Text + "'");
                // lưu ct_hóa đơn
                for(int i=0; i< dgvNL.Rows.Count -1; i++)
                {
                    string dvt = dgvNL.Rows[i].Cells[4].Value.ToString();
                    if(dvt == "")
                        dvt = dgvNL.Rows[i].Cells[3].Value.ToString();



                    PHIEU_NHAP_NGUYEN_LIEU.ThemCTPhieuNhapLieu(int.Parse(dt1.Rows[0]["MSPN"].ToString()), int.Parse(dgvNL.Rows[i].Cells[0].Value.ToString()), 
                        int.Parse(dgvNL.Rows[i].Cells[5].Value.ToString()),
                        int.Parse(dgvNL.Rows[i].Cells[6].Value.ToString()), int.Parse(dgvNL.Rows[i].Cells[7].Value.ToString()), 
                       dvt);
                    NGUYEN_LIEU.CongThemNguyenLieu(int.Parse(dgvNL.Rows[i].Cells[0].Value.ToString()), int.Parse(dgvNL.Rows[i].Cells[5].Value.ToString()));
                }
                MessageBox.Show("Lưu dữ liệu thành công");
                Reset();
                btnSave.Enabled = false;
            }
        }

        public void ResetDataTable()
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            //// Xóa hết record trong dgvPhieuSuaChua
            if (dgvNL.Rows.Count > 1)
            {
                while (1 < dgvNL.Rows.Count)
                {
                    dgvNL.Rows.Remove(dgvNL.Rows[0]);
                }
            }
            ////
            //// Xóa hết record trong dgvCT_SDVTPT
            txtTongTien.Text = "0";
            txtTienChu.Text = "";
            txtThanhToan.Text = "0";
            txtVat2.Text = "0";
            txtHDNhap.Text = "";
            txtLido.Text = "";
        }


        private void txtbPhieuSo_TextChanged(object sender, EventArgs e)
        {
            string PhieuSo = txtbPhieuSo.Text;
            btnThemMoi.Visible = true;
            btnReset.Visible = false;
            DataTable TTPN = PHIEU_NHAP_NGUYEN_LIEU.LayThongTinPhieuNhapNL("Where PSO ='" + PhieuSo + "'");
            if(TTPN.Rows.Count > 0)
            {
                btnEdit.Visible = true;
                btnSave.Visible = false;
                enableALL();
              
                DataTable CTPN = PHIEU_NHAP_NGUYEN_LIEU.LayThongTinCTPhieuNhapNL("Where MSPN ='" + TTPN.Rows[0]["MSPN"] + "'");
                ResetDataTable();
                cbbMaKho.SelectedValue = TTPN.Rows[0]["MSKHO"].ToString();
                cbbMaKH.SelectedValue = TTPN.Rows[0]["MSKH"].ToString();
                dtpNgayNhap.Value = Convert.ToDateTime(TTPN.Rows[0]["NGAYNHAP"]);
                txtHDNhap.Text = TTPN.Rows[0]["SOHOADON"].ToString();
                txtLido.Text = TTPN.Rows[0]["LYDO"].ToString();
                txtTongTien.Text = TTPN.Rows[0]["TONGTIEN"].ToString();
                txtThanhToan.Text = TTPN.Rows[0]["TONGTIENTT"].ToString();
                txtVat1.Text = TTPN.Rows[0]["THUESUAT"].ToString();
                txtTienChu.Text = NumberToTextVN(decimal.Parse(TTPN.Rows[0]["TONGTIENTT"].ToString()));
              
                for (int i=0; i<CTPN.Rows.Count; i++) {
                    DataGridViewRow row = (DataGridViewRow)dgvNL.Rows[0].Clone();
                    row.Cells[0].Value = CTPN.Rows[i]["MSNL"];
                    DataTable CTNL =  PHIEU_NHAP_NGUYEN_LIEU.LayThongTin1NL("Where MSNL ='" + CTPN.Rows[i]["MSNL"] + "'");
                    if(CTNL.Rows.Count >0)
                        row.Cells[1].Value = CTNL.Rows[0]["TENNL"];
                    if (CTNL.Rows[0]["DVT"].ToString() == "bao" || CTNL.Rows[0]["DVT"].ToString() == "bình" || CTNL.Rows[0]["DVT"].ToString() == "cây")
                    {
                        row.Cells[3].Value = CTNL.Rows[0]["DVT"].ToString();
                        row.Cells[4].Value = "";

                    }
                    else { row.Cells[4].Value = CTNL.Rows[0]["DVT"].ToString();
                        row.Cells[3].Value = "";
                    }
                    row.Cells[5].Value = CTPN.Rows[i]["SOLUONG"];
                    row.Cells[6].Value = CTPN.Rows[i]["DONGIA"];
                    row.Cells[7].Value = CTPN.Rows[i]["SOTIENNHAP"];
                    dgvNL.Rows.Add(row);
                }

                btnDelete.Enabled = true;

            }
        }
        public void enableALL()
        {
            cbbMaKho.Enabled = false;
            cbbMaKH.Enabled = false;
            dtpNgayNhap.Enabled = false;
            dtpNgayPHHD.Enabled = false;
            txtHDNhap.ReadOnly = true;
            txtLido.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtThanhToan.ReadOnly = true;
            txtVat2.ReadOnly = true;
            txtVat1.ReadOnly = true;
            txtTienChu.ReadOnly = true;
            btnReset.Enabled = false;
            btnSave.Enabled = false;
            dgvNL.ReadOnly = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
                    }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            this.Close();
            PNhapNL2 formPNhapNL2 = new PNhapNL2();
            formPNhapNL2.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn xóa liệu không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                DataTable dt = PHIEU_NHAP_NGUYEN_LIEU.LayPhieuNhapLieuByPhieuSo("WHERE PSO = '" + txtbPhieuSo.Text + "'");
                if(int.Parse(dt.Rows[0]["count_mspn"].ToString()) > 0)
                {
                    DataTable dt2 = PHIEU_NHAP_NGUYEN_LIEU.LayThongTinPhieuNhapNL("WHERE PSO = '" + txtbPhieuSo.Text + "'");
                    DataTable dt3 = PHIEU_NHAP_NGUYEN_LIEU.LayThongTinCTPhieuNhapNL("WHERE MSPN ='" + dt2.Rows[0]["MSPN"].ToString() + "'");
                    PHIEU_NHAP_NGUYEN_LIEU.XoaCTPhieuNhapLieu(dt2.Rows[0]["MSPN"].ToString());
                    PHIEU_NHAP_NGUYEN_LIEU.XoaPhieuNhapLieu(txtbPhieuSo.Text);
                   
                    for(int i=0; i < dt3.Rows.Count; i++)
                    {
                        NGUYEN_LIEU.TruBotNguyenLieu(int.Parse(dt3.Rows[i]["MSNL"].ToString()), int.Parse(dt3.Rows[i]["SOLUONG"].ToString()));
                    }
                    MessageBox.Show("Xóa dữ liệu thành công");
                    Reset();

                }
               
            }
        }

        public string PhieuSoNext()
        {
            DataTable dt = PHIEU_NHAP_NGUYEN_LIEU.DemPhieuSo();
            if (dt.Rows.Count > 0)
            {
                string current = dt.Rows[0]["PSO"].ToString();
                current = current.Substring(2);
                int cur = int.Parse(current);
                cur = cur + 1;
                string next = cur.ToString();
                string PhieuSo = "PN";
                char pad = '0';
                next = next.PadLeft(7, pad);
                return PhieuSo + next;
            }

            else
                return "PN0000001";
           
        }

        private void txtVat1_TextChanged(object sender, EventArgs e)
        {
            if (txtVat1.Text != null)
            {
                int n = 0;
                if (int.TryParse(this.txtVat1.Text, out n))
                {
                    int vat = int.Parse(txtVat1.Text);
                    if (vat > 100)
                    {
                        MessageBox.Show("Vat phải bé hơn 100");
                        txtVat1.Text = "0";
                    }
                    else
                    {
                        int tongtien = int.Parse(txtTongTien.Text);
                        double thanhtoan = tongtien - tongtien * vat / 100;
                        txtVat2.Text = (tongtien * vat / 100).ToString();
                        txtThanhToan.Text = thanhtoan.ToString();
                        txtTienChu.Text = NumberToTextVN(decimal.Parse(thanhtoan.ToString()));
                    }

                    //Kiểm tra số tiền thu có bé hơn hoặc bằng Chi Phí sửa chữa hay không
                }
                else
                {
                    if (txtVat2.Text != "")
                        MessageBox.Show("Vat phải là ký số");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cbbMaKho.Enabled = true;
            cbbMaKH.Enabled = true;
            dgvNL.ReadOnly = false;
            dtpNgayNhap.Enabled = true;
            dtpNgayPHHD.Enabled = true;
            txtHDNhap.ReadOnly = false;
            txtLido.ReadOnly = false;
            txtTongTien.ReadOnly = true;
            txtThanhToan.ReadOnly = false;
            txtVat2.ReadOnly = true;
            txtVat1.ReadOnly = false;
            txtTienChu.ReadOnly = true;
            btnReset.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Visible = false;
            btnSaveEdit.Visible = true;
           

        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn lưu dữ liệu không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                DataTable dt = PHIEU_NHAP_NGUYEN_LIEU.LayThongTinPhieuNhapNL("WHERE PSO = '" + txtbPhieuSo.Text + "'");
                DataTable dt3 = PHIEU_NHAP_NGUYEN_LIEU.LayThongTinCTPhieuNhapNL("WHERE MSPN ='" + dt.Rows[0]["MSPN"].ToString() + "'");
                PHIEU_NHAP_NGUYEN_LIEU.ChinhSuaPhieuNhapNL(int.Parse(dt.Rows[0]["MSPN"].ToString()), int.Parse(cbbMaKH.SelectedValue.ToString()), int.Parse(cbbMaKho.SelectedValue.ToString())
                    , int.Parse(txtVat1.Text.ToString()), txtHDNhap.Text.ToString(), dtpNgayPHHD.Value.Date, txtLido.Text.ToString(),
                    dtpNgayNhap.Value.Date, int.Parse(txtTongTien.Text.ToString()), int.Parse(txtThanhToan.Text.ToString()), txtbPhieuSo.Text.ToString());
                PHIEU_NHAP_NGUYEN_LIEU.XoaCTPhieuNhapLieu(dt.Rows[0]["MSPN"].ToString());
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    NGUYEN_LIEU.TruBotNguyenLieu(int.Parse(dt3.Rows[i]["MSNL"].ToString()), int.Parse(dt3.Rows[i]["SOLUONG"].ToString()));
                }
                // lưu ct_hóa đơn
                for (int i = 0; i < dgvNL.Rows.Count - 1; i++)
                {
                    string dvt = dgvNL.Rows[i].Cells[4].Value.ToString();
                    if (dvt == "")
                        dvt = dgvNL.Rows[i].Cells[3].Value.ToString();
                    PHIEU_NHAP_NGUYEN_LIEU.ThemCTPhieuNhapLieu(int.Parse(dt.Rows[0]["MSPN"].ToString()), int.Parse(dgvNL.Rows[i].Cells[0].Value.ToString()),
                        int.Parse(dgvNL.Rows[i].Cells[5].Value.ToString()),
                        int.Parse(dgvNL.Rows[i].Cells[6].Value.ToString()), int.Parse(dgvNL.Rows[i].Cells[7].Value.ToString()),
                        dvt);
                    NGUYEN_LIEU.CongThemNguyenLieu(int.Parse(dgvNL.Rows[i].Cells[0].Value.ToString()), int.Parse(dgvNL.Rows[i].Cells[5].Value.ToString()));
                }
                MessageBox.Show("Lưu dữ liệu thành công");
                Reset();
                btnSave.Enabled = false;
            }
        }
    }
}
