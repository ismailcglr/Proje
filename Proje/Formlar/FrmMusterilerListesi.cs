using Proje.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.Formlar
{
    public partial class FrmMusterilerListesi : Form
    {
        MusterilerCls musterilerCls = new MusterilerCls();

        public FrmMusterilerListesi()
        {
            InitializeComponent();
        }

        private void FrmMusterilerListesi_Load(object sender, EventArgs e)
        {
            grdMusteriler.DataSource = musterilerCls.MusterileriGetir();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle f = new FrmMusteriEkle();
            if(f.ShowDialog() == DialogResult.OK)
            {
                grdMusteriler.DataSource = musterilerCls.MusterileriGetir();  
            }
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secimMusteri = grdMusteriler.CurrentRow;
            int id = Convert.ToInt16(secimMusteri.Cells["Id"].Value);
            FrmMusteriDuzenle f = new FrmMusteriDuzenle();
            f.musteriId = id;

            if(f.ShowDialog() == DialogResult.OK)
            {
                grdMusteriler.DataSource = musterilerCls.MusteriGetir(id);
            }

        }

        private void btnMusteriTaksitleri_Click(object sender, EventArgs e)
        {
            DataGridViewRow secimMusteri = grdMusteriler.CurrentRow;
            int id = Convert.ToInt16(secimMusteri.Cells["Id"].Value);
            string adSoyad = $"{secimMusteri.Cells["Ad"].Value.ToString()} {secimMusteri.Cells["Soyad"].Value.ToString()}";

            FrmMusteriTaksitleri f = new FrmMusteriTaksitleri();
            f.MusteriAdi = adSoyad;
            f.MusteriId = id;
            f.ShowDialog();

            grdMusteriler.DataSource = musterilerCls.MusteriGetir(id);

        }

        private void btnMusteriDel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili Müşteri silinsinmi ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow secim = grdMusteriler.CurrentRow;
                int id = Convert.ToInt16(secim.Cells["Id"].Value);
                MusterilerCls musterilerCls = new MusterilerCls();
                musterilerCls.MusteriSil(id);
                grdMusteriler.DataSource = musterilerCls.MusterileriGetir();
            }
        }
    }
}
