using Microsoft.SqlServer.Server;
using Proje.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void odaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.FrmOdaEkle f = new Formlar.FrmOdaEkle();
            f.ShowDialog();
        }

        private void odaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.FrmOdalarListesi f = new Formlar.FrmOdalarListesi();
            f.ShowDialog();
        }

        private void müşlterilerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusterilerListesi f = new FrmMusterilerListesi();
            f.ShowDialog();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle f = new FrmMusteriEkle();
            f.ShowDialog();
        }

        private void sözleşmelerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.FrmSozlesmeler f = new FrmSozlesmeler();
            f.ShowDialog();
        }

        private void sözleşmeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.FrmSozlesmeEkle f = new FrmSozlesmeEkle();
            f.ShowDialog();
        }

        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.FrmKasaHareketleri f = new FrmKasaHareketleri();
            f.ShowDialog();
        }

        private void taksitlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTaksitler f = new FrmTaksitler();
            f.ShowDialog();
        }
    }
}
