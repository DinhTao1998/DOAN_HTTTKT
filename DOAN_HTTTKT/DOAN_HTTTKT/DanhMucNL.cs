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
    public partial class DanhMucNL : Form
    {
        public DanhMucNL()
        {
            InitializeComponent();
        }

        public void load_DMNL (){
            DataTable dt = NGUYEN_LIEU.layDanhSachNguyenLieu();
            dgvDMNL.DataSource = dt;
            btnChinhSua.Enabled = false;
           
            btnThemMoi.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DanhMucNL_Load(object sender, EventArgs e)
        {
            load_DMNL();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNL.Text.Length == 0 || txtSoLuong.Text.Length == 0 || txtDonGia.Text.Length == 0|| txtDVT.Text.Length == 0)
            {
                MessageBox.Show("nhập đầy đủ thông tin");
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn lưu dữ liệu không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    btnLuu.Enabled = false;
                    if (txtMSNL.Text.Length == 0)
                    {
                        NGUYEN_LIEU.ThemDMNguyenLieu(txtTenNL.Text, int.Parse(txtDonGia.Text), txtDVT.Text, int.Parse(txtSoLuong.Text));
                        MessageBox.Show("Lưu dữ liệu thành công");
                        DanhMucNL_Load(sender,e);
                        reset();
                    }
                    else
                    {
                        NGUYEN_LIEU.ChinhSuaDMNguyenLieu(int.Parse(txtMSNL.Text),txtTenNL.Text, int.Parse(txtDonGia.Text), txtDVT.Text, int.Parse(txtSoLuong.Text));
                        MessageBox.Show("Lưu dữ liệu thành công");
                        DanhMucNL_Load(sender, e);
                        reset();
                    }
                }
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            int n = 0;
            if (txtDonGia.Text.Length > 0)
            {
                if (!int.TryParse(txtDonGia.Text, out n))
                {
                    MessageBox.Show("Đơn giá phải là kí số");
                    txtDonGia.Text = "0";
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int n = 0;
            if(txtSoLuong.Text.Length > 0)
            {
                if (!int.TryParse(txtSoLuong.Text, out n))
                {
                    MessageBox.Show("Số lượng phải là kí số");
                    txtSoLuong.Text = "0";
                }
            }
        }

        public void reset()
        {
            btnLuu.Enabled = true;
            txtMSNL.Text = null;
            txtDVT.Text = null;
            txtTenNL.Text = null;
            txtDonGia.Text = "0";
            txtSoLuong.Text = "0";
        }
        public void enableALL()
        {
            
            txtDVT.ReadOnly = false;
            txtTenNL.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
        }

        public void disableALL()
        {

            txtDVT.ReadOnly = true;
            txtTenNL.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
        }

        private void dgvDMNL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            btnChinhSua.Enabled = true;
            btnThemMoi.Enabled = true;
            btnLuu.Enabled = false;

            txtMSNL.Enabled = false;
            txtDVT.ReadOnly = true;
            txtTenNL.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtSoLuong.ReadOnly = true;

            txtMSNL.Text = dgvDMNL.Rows[index].Cells["MSNL"].Value.ToString();
            txtSoLuong.Text = dgvDMNL.Rows[index].Cells["SOLUONG"].Value.ToString();
            txtDonGia.Text = dgvDMNL.Rows[index].Cells["DONGIA"].Value.ToString();
            txtTenNL.Text = dgvDMNL.Rows[index].Cells["TENNL"].Value.ToString();
            txtDVT.Text = dgvDMNL.Rows[index].Cells["DVT"].Value.ToString();

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnChinhSua.Enabled = false;
            btnThemMoi.Enabled = false;
            enableALL();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnThemMoi.Enabled = false;
            btnLuu.Enabled = true;
            btnChinhSua.Enabled = false;
            enableALL();
        }
    }
}
