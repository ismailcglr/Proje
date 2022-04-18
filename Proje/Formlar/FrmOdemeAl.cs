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
    public partial class FrmOdemeAl : Form
    {
        public FrmOdemeAl()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            KasalarCls kasalarCls = new KasalarCls();
            kasalarCls.KasaHaraketiEkle(dtpOdemeTarih.Value, tbOdemeAcıklama.Text, Convert.ToDecimal(tbOdemeTutar.Text), 0);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
