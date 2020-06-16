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
    public partial class PXuatNL1 : Form
    {
        public PXuatNL1()
        {
            InitializeComponent();
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PXuatNL2 formPXuatNL2 = new PXuatNL2();
            formPXuatNL2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
