using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerciProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHamburgerEkle frm = new FrmHamburgerEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSiparisBilgileri frm = new FrmSiparisBilgileri();
            frm.MdiParent = this;
            frm.Show();

        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSiparisOlustur frm = new FrmSiparisOlustur();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEkstraMalzemeEkle frm = new FrmEkstraMalzemeEkle();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
