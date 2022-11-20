using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphanem
{
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yardim = new yardim();
            yardim.Show();
        }

        private void kitapTürüEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitap_turu = new kitap_turu();
            kitap_turu.Show();
        }

        private void yazınTürüEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yazin_turu = new yazin_turu();
            yazin_turu.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitapekle = new kitapekle();
            kitapekle.Show();
        }

        private void kategorizasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kulekle = new kulekle();
            kulekle.Show();
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kulsil = new kulsil();
            kulsil.Show();
        }

        private void kitapBilgisiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitapbilgun = new kitapbilgun();
            kitapbilgun.Show();
        }
    }
}
