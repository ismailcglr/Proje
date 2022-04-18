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
    public partial class FrmMusteriDuzenle : Form
    {

        public int musteriId;
        MusterilerCls musterilerCls = new MusterilerCls();


        public FrmMusteriDuzenle()
        {
            InitializeComponent();
        }

        private void FrmMusteriDuzenle_Load(object sender, EventArgs e)
        {
            DataRow musteri = musterilerCls.MusteriGetir(musteriId);
            tbMusteriAdi.Text = musteri["Ad"].ToString();
            tbMusteriSoyadi.Text = musteri["Soyad"].ToString();
            tbMusteriTc.Text = musteri["TcKimlik"].ToString();
            tbMusteriTel.Text = musteri["CepTelefonu"].ToString();
            tbMusteriAdres.Text = musteri["Adres"].ToString();
            dtpMusteriDogumTarih.Value = Convert.ToDateTime(musteri["DogumTarihi"]);
        }

        private void btnMusteriCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnMusteriSave_Click(object sender, EventArgs e)
        {

             MusterilerCls musterilerCls = new MusterilerCls();
             musterilerCls.MusteriDuzenle(musteriId, tbMusteriAdi.Text, tbMusteriSoyadi.Text, dtpMusteriDogumTarih.Value, tbMusteriTc.Text, tbMusteriTel.Text, tbMusteriAdres.Text);
             this.DialogResult = DialogResult.OK;
        }
    }
}
