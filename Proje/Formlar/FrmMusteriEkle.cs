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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnMusteriSave_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();

            bool Kayıt = true;

            if (string.IsNullOrWhiteSpace(tbMusteriAdi.Text))
            {
                Kayıt = false;
                errorProvider1.SetError(tbMusteriAdi, "MÜŞTERİ ADI BOŞ GEÇİLEMEZ");
            }
            if (string.IsNullOrWhiteSpace(tbMusteriSoyadi.Text))
            {
                Kayıt = false;
                errorProvider1.SetError(tbMusteriSoyadi, "MÜŞTERİ SOYADI BOŞ GEÇİLEMEZ");
            }
            if (string.IsNullOrWhiteSpace(tbMusteriTc.Text))
            {
                Kayıt = false;
                errorProvider1.SetError(tbMusteriTc, "MÜŞTERİ TC KİMLİK NO BOŞ GEÇİLEMEZ");
            }




            if (Kayıt)
            {
                MusterilerCls musterilerCls = new MusterilerCls();
                musterilerCls.MusteriEkle(tbMusteriAdi.Text, tbMusteriSoyadi.Text, dtpMusteriDogumTarih.Value, tbMusteriTc.Text, tbMusteriTel.Text, tbMusteriAdres.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("LÜTFEN BOŞLUKLARI DOLDURUNUZ");
            }

            
        }

        private void tbMusteriAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMusteriTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMusteriTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpMusteriDogumTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbMusteriSoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMusteriAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
