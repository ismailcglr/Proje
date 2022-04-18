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
    public partial class FrmSozlesmeEkle : Form
    {
        public FrmSozlesmeEkle()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSozlesmeCancel_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Form Kapatılacak, emin misin", "KAPAT", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }

            

        }

        private void FrmSozlesmeEkle_Load(object sender, EventArgs e)
        {
            MusterilerCls musterilerCls = new MusterilerCls();
            cbSozlesmeMusteri.DataSource = musterilerCls.MusterileriGetir();


            OdalarCls odalarCls = new OdalarCls();
            cbSozlesmeOda.DataSource = odalarCls.OdalarıGetir();
        }

        private void btnSozlesmeSave_Click(object sender, EventArgs e)
        {
            SozlesmelerCls sozlesmelerCls = new SozlesmelerCls();
            sozlesmelerCls.SozlesmeOlustur(Convert.ToInt16(cbSozlesmeMusteri.SelectedValue), Convert.ToInt16(cbSozlesmeOda.SelectedValue),
                                  Convert.ToDecimal(tbSozlesmeToplamTutar.Text), (int)numSozlesmeTaksit.Value, dtpIlkSozlesmeTarih.Value,
                                  dtpSozlesmeBaslangic.Value, dtpSozlesmeBitis.Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
