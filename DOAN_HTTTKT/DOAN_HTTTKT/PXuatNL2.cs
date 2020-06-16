using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN_HTTTKT.DAO;

namespace DOAN_HTTTKT
{
    public partial class PXuatNL2 : Form
    {
        public PXuatNL2()
        {
            InitializeComponent();
            txtbPhieuSo.Text = PhieuSoNext();
            btnReset.Visible = true;
            btnThemMoi.Visible = false;
            btnEdit.Visible = false;
            btnSaveEdit.Visible = false;
        }

        public void load_MaKho()
        {
            cbbKhoXuat.DataSource = PHIEU_NHAP_NGUYEN_LIEU.layDanhKho();
            cbbKhoXuat.DisplayMember = "MSKHO";
            cbbKhoXuat.ValueMember = "MSKHO";
            txtbTenCH.DataBindings.Add("TEXT", cbbKhoXuat.DataSource, "TENKHO");

        }

        public void load_MaKho_Den()
        {
            cbbKhoNhap.DataSource = PHIEU_NHAP_NGUYEN_LIEU.layDanhKho();
            cbbKhoNhap.DisplayMember ="DIACHI";
            cbbKhoNhap.ValueMember = "MSKHO";
            
        }

        public void load_NguyenLieu()
        {
            MSNL.DataSource = PHIEU_NHAP_NGUYEN_LIEU.layDanhNguyenLieu();
            MSNL.DisplayMember = "MSNL";
            MSNL.ValueMember = "MSNL";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PXuatNL2_Load(object sender, EventArgs e)
        {
            load_MaKho();
            load_MaKho_Den();
            load_NguyenLieu();
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            txtTongTien.Text = "0";
            txtTienChu.Text = "";
          
        }

        private void dgvXuatNL_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = true;
            double tongtien = 0;
            for (int i = 0; i < dgvXuatNL.Rows.Count - 1; i++)
            {
                SOLUONG.ReadOnly = true;
                DataTable dt = new DataTable();
                dt = PHIEU_NHAP_NGUYEN_LIEU.LayThongTinNL("Where MSNL ='" + dgvXuatNL.Rows[i].Cells[0].Value.ToString() + "'");
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dgvXuatNL.Rows[i].Cells[0].Value.ToString() == dt.Rows[j]["MSNL"].ToString())
                    {
                        SOLUONG.ReadOnly = false;
                        dgvXuatNL.Rows[i].Cells[1].Value = dt.Rows[j]["TENNL"].ToString();
                        dgvXuatNL.Rows[i].Cells[2].Value = dt.Rows[j]["LOAI"].ToString();
                        if (dt.Rows[j]["DVT"].ToString() == "bao" || dt.Rows[j]["DVT"].ToString() == "bình" || dt.Rows[j]["DVT"].ToString() == "cây")
                        {
                            dgvXuatNL.Rows[i].Cells[3].Value = dt.Rows[j]["DVT"].ToString();
                            dgvXuatNL.Rows[i].Cells[4].Value = "";
                        }
                        else { dgvXuatNL.Rows[i].Cells[4].Value = dt.Rows[j]["DVT"].ToString();
                            dgvXuatNL.Rows[i].Cells[3].Value = "";
                        }
                        dgvXuatNL.Rows[i].Cells[6].Value = dt.Rows[j]["DONGIA"].ToString();
                        break;
                    }
                }
                int dg = Convert.ToInt32(dgvXuatNL.Rows[i].Cells[6].Value);
                int sl = 1;
                int n = 0;
                //// Kiểm tra số lượng nhập vào có phải là kí số hay không
                if (dgvXuatNL.Rows[i].Cells[5].Value != null)
                {
                    if (int.TryParse(this.dgvXuatNL.Rows[i].Cells[5].Value.ToString(), out n))
                        sl = Convert.ToInt32(dgvXuatNL.Rows[i].Cells[5].Value);
                    else
                    {
                        if (dgvXuatNL.Rows[i].Cells[5].Value.ToString() != "")
                            MessageBox.Show("Số lượng phải là ký số");
                        dgvXuatNL.Rows[i].Cells[5].Value = 1;
                    }
                }
                else
                    dgvXuatNL.Rows[i].Cells[5].Value = 1;
                ////
                double thanhtien = dg * sl;
                dgvXuatNL.Rows[i].Cells[7].Value = Convert.ToString(thanhtien);
                tongtien = tongtien + thanhtien;
            }
            txtTongTien.Text = Convert.ToString(tongtien);
            txtTienChu.Text = NumberToTextVN(decimal.Parse(tongtien.ToString()));
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

        private void dgvXuatNL_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double tongtien = 0;
            for (int i = 0; i < dgvXuatNL.Rows.Count - 1; i++)
            {
                double thanhtien = Convert.ToDouble(dgvXuatNL.Rows[i].Cells[7].Value);
                tongtien = tongtien + thanhtien;
            }

            txtTongTien.Text = Convert.ToString(tongtien);
            txtTienChu.Text = NumberToTextVN(decimal.Parse(tongtien.ToString()));
        }

        public string PhieuSoNext()
        {
            DataTable dt = PHIEU_XUAT_NGUYEN_LIEU.DemPhieuSo();
            if(dt.Rows.Count > 0) {
                string current = dt.Rows[0]["PSO"].ToString();
                current = current.Substring(2);
                int cur = int.Parse(current);
                cur = cur + 1;
                string next = cur.ToString();
                string PhieuSo = "PX";
                char pad = '0';
                next = next.PadLeft(7, pad);
                return PhieuSo + next;
            }
            else
            {
                return "PX0000001";
            }
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn lưu dữ liệu không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                DataTable dt = PHIEU_XUAT_NGUYEN_LIEU.DemPhieuSo();
            

                PHIEU_XUAT_NGUYEN_LIEU.ThemPhieuXuatNL(0, int.Parse(cbbKhoXuat.SelectedValue.ToString()), int.Parse(cbbKhoNhap.SelectedValue.ToString())
                    ,txtLiDo.Text.ToString(),dtpNgayXuat.Value.Date,int.Parse(txtTongTien.Text.ToString()), txtbPhieuSo.Text.ToString(),txtNguoiGiao.Text.ToString());
                // lưu ct_hóa đơn
                for (int i = 0; i < dgvXuatNL.Rows.Count - 1; i++)
                {
                    DataTable dt1 = PHIEU_XUAT_NGUYEN_LIEU.LayThongTinPhieuXuatNL("WHERE PSO = '" + txtbPhieuSo.Text + "'");
                    PHIEU_XUAT_NGUYEN_LIEU.ThemCTPhieuXuatNguyenLieu(int.Parse(dt1.Rows[0]["MSPXNL"].ToString()), int.Parse(dgvXuatNL.Rows[i].Cells[0].Value.ToString()),
                        int.Parse(dgvXuatNL.Rows[i].Cells[5].Value.ToString()),
                        int.Parse(dgvXuatNL.Rows[i].Cells[6].Value.ToString()), int.Parse(dgvXuatNL.Rows[i].Cells[7].Value.ToString()),
                        dgvXuatNL.Rows[i].Cells[4].Value.ToString()+ dgvXuatNL.Rows[i].Cells[3].Value.ToString());
                    NGUYEN_LIEU.TruBotNguyenLieu(int.Parse(dgvXuatNL.Rows[i].Cells[0].Value.ToString()),
                        int.Parse(dgvXuatNL.Rows[i].Cells[5].Value.ToString()));
                }
                MessageBox.Show("Lưu dữ liệu thành công");
                Reset();
                btnSave.Enabled = false;
            }
        }

        public void Reset()
        {
            this.Close();
            PXuatNL2 formXuatNL2 = new PXuatNL2();
            formXuatNL2.Show();
        }

        public void ResetDataTable()
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            //// Xóa hết record trong dgvPhieuSuaChua
            if (dgvXuatNL.Rows.Count > 1)
            {
                while (1 < dgvXuatNL.Rows.Count)
                {
                    dgvXuatNL.Rows.Remove(dgvXuatNL.Rows[0]);
                }
            }
            ////
            //// Xóa hết record trong dgvCT_SDVTPT
            txtTongTien.Text = "0";
            txtTienChu.Text = "";
           
            txtLiDo.Text = "";
        }

        private void txtbPhieuSo_TextChanged(object sender, EventArgs e)
        {
            string PhieuSo = txtbPhieuSo.Text;
            btnThemMoi.Visible = true;
            btnReset.Visible = false;
            DataTable TTPN = PHIEU_XUAT_NGUYEN_LIEU.LayThongTinPhieuXuatNL("Where PSO ='" + PhieuSo + "'");
            if (TTPN.Rows.Count > 0)
            {
                enableALL();
                btnEdit.Visible = true;
                btnSave.Visible = false;
                DataTable CTPN = PHIEU_XUAT_NGUYEN_LIEU.LayThongTinCTPhieuNhapNL("Where MSPXNL ='" + TTPN.Rows[0]["MSPXNL"] + "'");
                ResetDataTable();
                cbbKhoXuat.SelectedValue = TTPN.Rows[0]["MSKHOXUAT"].ToString();
                cbbKhoNhap.SelectedValue = TTPN.Rows[0]["MSKHONHAP"].ToString();
                dtpNgayXuat.Value = Convert.ToDateTime(TTPN.Rows[0]["NGAYXUAT"]);
                
                txtLiDo.Text = TTPN.Rows[0]["LYDO"].ToString();
                txtTongTien.Text = TTPN.Rows[0]["TONGTIENTT"].ToString();
                txtNguoiGiao.Text = TTPN.Rows[0]["NGUOIVANCHUYEN"].ToString();

                txtTienChu.Text = NumberToTextVN(decimal.Parse(TTPN.Rows[0]["TONGTIENTT"].ToString()));

                for (int i = 0; i < CTPN.Rows.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvXuatNL.Rows[0].Clone();
                    row.Cells[0].Value = CTPN.Rows[i]["MSNL"];
                    DataTable CTNL = PHIEU_NHAP_NGUYEN_LIEU.LayThongTin1NL("Where MSNL ='" + CTPN.Rows[i]["MSNL"] + "'");
                    if (CTNL.Rows.Count > 0)
                        row.Cells[1].Value = CTNL.Rows[0]["TENNL"];
                    if (CTNL.Rows[0]["DVT"].ToString() == "bao" || CTNL.Rows[0]["DVT"].ToString() == "bình" || CTNL.Rows[0]["DVT"].ToString() == "cây")
                    {
                        row.Cells[3].Value = CTNL.Rows[0]["DVT"].ToString();
                        row.Cells[4].Value = "";

                    }
                    else
                    {
                        row.Cells[4].Value = CTNL.Rows[0]["DVT"].ToString();
                        row.Cells[3].Value = "";
                    }
                    row.Cells[5].Value = CTPN.Rows[i]["SOLUONG"];
                    row.Cells[6].Value = CTPN.Rows[i]["DONGIA"];
                    row.Cells[7].Value = CTPN.Rows[i]["SOTIENXUAT"];
                    dgvXuatNL.Rows.Add(row);
                }

                btnDelete.Enabled = true;

            }
        }
        public void enableALL()
        {
            cbbKhoNhap.Enabled = false;
            cbbKhoXuat.Enabled = false;
            dtpNgayXuat.Enabled = false;
            txtTienChu.ReadOnly = true;
            btnReset.Enabled = false;
            btnSave.Enabled = false;
            dgvXuatNL.ReadOnly = true;
            txtNguoiGiao.ReadOnly = true;
            txtLiDo.ReadOnly = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn xóa liệu không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                DataTable dt = PHIEU_XUAT_NGUYEN_LIEU.LayPhieuXuatLieuByPhieuSo("WHERE PSO = '" + txtbPhieuSo.Text + "'");
                if (int.Parse(dt.Rows[0]["count_mspn"].ToString()) > 0)
                {
                    DataTable dt2 = PHIEU_XUAT_NGUYEN_LIEU.LayThongTinPhieuXuatNL("WHERE PSO = '" + txtbPhieuSo.Text + "'");
                    DataTable dt3 = PHIEU_XUAT_NGUYEN_LIEU.LayThongTinCTPhieuNhapNL("WHERE MSPXNL = '" + dt2.Rows[0]["MSPXNL"].ToString() + "'");
                    PHIEU_XUAT_NGUYEN_LIEU.XoaCTPhieuXuatNguyenLieu(int.Parse(dt2.Rows[0]["MSPXNL"].ToString()));
                    PHIEU_XUAT_NGUYEN_LIEU.XoaPhieuXuatNguyenLieu(txtbPhieuSo.Text);
                    for(int i=0; i < dt3.Rows.Count; i++)
                    {
                        NGUYEN_LIEU.CongThemNguyenLieu(int.Parse(dt3.Rows[i]["MSNL"].ToString()), int.Parse(dt3.Rows[i]["SOLUONG"].ToString()));
                    }
                    MessageBox.Show("Xóa dữ liệu thành công");
                    Reset();

                }

            }
        }

        private void dtpNgayXuat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cbbKhoNhap.Enabled = true;
            cbbKhoXuat.Enabled = true;
            dtpNgayXuat.Enabled = true;
            txtTienChu.ReadOnly =false;
            btnReset.Enabled = false;
            btnSave.Enabled = false;
            dgvXuatNL.ReadOnly = false;
            txtNguoiGiao.ReadOnly = false;
            txtLiDo.ReadOnly = false;
            btnEdit.Visible = false;
            btnSaveEdit.Visible = true;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn lưu dữ liệu không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                DataTable dt = PHIEU_XUAT_NGUYEN_LIEU.LayThongTinPhieuXuatNL("WHERE PSO = '" + txtbPhieuSo.Text + "'");
                DataTable dt3 = PHIEU_XUAT_NGUYEN_LIEU.LayThongTinCTPhieuNhapNL("WHERE MSPXNL = '" + dt.Rows[0]["MSPXNL"].ToString() + "'");

                PHIEU_XUAT_NGUYEN_LIEU.ChinhSuaPhieuXuatNL(int.Parse(dt.Rows[0]["MSPXNL"].ToString()), int.Parse(cbbKhoXuat.SelectedValue.ToString()), int.Parse(cbbKhoNhap.SelectedValue.ToString())
                    , txtLiDo.Text.ToString(), dtpNgayXuat.Value.Date, int.Parse(txtTongTien.Text.ToString()), txtbPhieuSo.Text.ToString(), txtNguoiGiao.Text.ToString());
                // lưu ct_hóa đơn
                PHIEU_XUAT_NGUYEN_LIEU.XoaCTPhieuXuatNguyenLieu(int.Parse(dt.Rows[0]["MSPXNL"].ToString()));
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    NGUYEN_LIEU.CongThemNguyenLieu(int.Parse(dt3.Rows[i]["MSNL"].ToString()), int.Parse(dt3.Rows[i]["SOLUONG"].ToString()));
                }
                for (int i = 0; i < dgvXuatNL.Rows.Count - 1; i++)
                {
                    PHIEU_XUAT_NGUYEN_LIEU.ThemCTPhieuXuatNguyenLieu(int.Parse(dt.Rows[0]["MSPXNL"].ToString()), int.Parse(dgvXuatNL.Rows[i].Cells[0].Value.ToString()),
                        int.Parse(dgvXuatNL.Rows[i].Cells[5].Value.ToString()),
                        int.Parse(dgvXuatNL.Rows[i].Cells[6].Value.ToString()), int.Parse(dgvXuatNL.Rows[i].Cells[7].Value.ToString()),
                        dgvXuatNL.Rows[i].Cells[4].Value.ToString()+ dgvXuatNL.Rows[i].Cells[3].Value.ToString());
                    NGUYEN_LIEU.TruBotNguyenLieu(int.Parse(dgvXuatNL.Rows[i].Cells[0].Value.ToString()),
                        int.Parse(dgvXuatNL.Rows[i].Cells[5].Value.ToString()));
                }
                MessageBox.Show("Lưu dữ liệu thành công");
                Reset();
                btnSave.Enabled = false;
            }

        }
    }
}
