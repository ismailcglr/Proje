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
    public partial class FrmOdemeYap : Form
    {
        public FrmOdemeYap()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            KasalarCls kasalarCls = new KasalarCls();
            kasalarCls.KasaHaraketiEkle(dtpOdemeTarih.Value, tbOdemeAcıklama.Text, 0, Convert.ToDecimal(tbOdemeTutar.Text));

            this.DialogResult = DialogResult.OK;
        }
    }
}
