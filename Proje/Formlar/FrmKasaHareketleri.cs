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
    public partial class FrmKasaHareketleri : Form
    {

        KasalarCls kasalarCls = new KasalarCls();

        public FrmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void KasaBilgileri()
        {
            grdKasa.DataSource = kasalarCls.KasaHareketleriGetir();

            DataTable tbozet = kasalarCls.KasaOzeti();
            if (tbozet.Rows.Count == 0)
            {
                lblKasadakiPara.Text = "0";
                lblGider.Text = "0";
                lblGelir.Text = "0";
            }
            else
            {
                DataRow ozet = tbozet.Rows[0];
                lblKasadakiPara.Text = ozet["Kalan"].ToString();
                lblGider.Text = ozet["ToplamGiden"].ToString();
                lblGelir.Text = ozet["ToplamGiren"].ToString();
            }
        }

        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            KasaBilgileri();
        }

        private void btnKasaOdemeYap_Click(object sender, EventArgs e)
        {
            FrmOdemeYap f = new FrmOdemeYap();
            if (f.ShowDialog() == DialogResult.OK)
            {
                KasaBilgileri();
            }

        }

        private void btnKasaOdemeAl_Click(object sender, EventArgs e)
        {
            FrmOdemeAl f = new FrmOdemeAl();
            if (f.ShowDialog() == DialogResult.OK)
            {
                KasaBilgileri();
            }
        }
    }
}
