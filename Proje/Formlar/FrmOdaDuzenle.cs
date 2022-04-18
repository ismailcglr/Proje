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
    public partial class FrmOdaDuzenle : Form
    {

        public int odaID;

        public FrmOdaDuzenle()
        {
            InitializeComponent();
        }

        private void FrmOdaDuzenle_Load(object sender, EventArgs e)
        {
            DataRow oda = new OdalarCls().OdaGetir(odaID);
            tbOdaAdi.Text = oda["OdaAdi"].ToString();
            tbFiyat.Text = oda["Fiyat"].ToString();
            numKapasite.Value = Convert.ToInt16(oda["Kapasite"]);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OdalarCls odalarCls = new OdalarCls();
            odalarCls.OdaDuzenle(odaID, tbOdaAdi.Text, Convert.ToDecimal(tbFiyat.Text), (int)numKapasite.Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
