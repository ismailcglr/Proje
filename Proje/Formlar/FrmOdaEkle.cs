using Proje.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.Formlar
{
    public partial class FrmOdaEkle : Form
    {
        public FrmOdaEkle()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            OdalarCls odalarCls = new OdalarCls();
            odalarCls.OdaEkle(tbOdaAdi.Text, Convert.ToDecimal(tbFiyat.Text), (int)numKapasite.Value);


            this.DialogResult = DialogResult.OK;
        }
    }
}
