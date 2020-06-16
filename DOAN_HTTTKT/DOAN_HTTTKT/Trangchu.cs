using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_HTTTKT
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nạpDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lậpPhiếuNhậpNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PNhapNL2 formPNhapNL2 = new PNhapNL2();
            formPNhapNL2.Show();
        }

        private void lậpPhiếuXuấtNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PXuatNL2 formPXuatNL2 = new PXuatNL2();
            formPXuatNL2.Show();
        }

        private void danhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucNL formPXuatNL2 = new DanhMucNL();
            formPXuatNL2.Show();
        }

        private void thẻKhoNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
