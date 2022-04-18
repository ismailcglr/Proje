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
    public partial class FrmDemirbaslar : Form
    {
        int odaId;

        public FrmDemirbaslar(int gelenOdaId, string gelenOdaAdi)
        {
            InitializeComponent();
            lblOdaBilgi.Text = $"{gelenOdaId.ToString()} - {gelenOdaAdi}";

            odaId = gelenOdaId;
        }

        private void FrmDemirbaslar_Load(object sender, EventArgs e)
        {
            DemirbaslarCls demirbaslarCls = new DemirbaslarCls();
            gridDemirbaslar.DataSource = demirbaslarCls.OdanınDemirbasGetir(odaId); 
        }

        private void lblOdaBilgi_Click(object sender, EventArgs e)
        {

        }

        private void btnDemirbasSave_Click(object sender, EventArgs e)
        {
            DemirbaslarCls demirbaslarCls = new DemirbaslarCls();
            demirbaslarCls.DemirbasEkle(odaId, tbDemirbasAdi.Text, (int)numDemirbasAdet.Value);

            gridDemirbaslar.DataSource = demirbaslarCls.OdanınDemirbasGetir(odaId);
        }

        private void btnDemirbasDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili Demirbaş silinsinmi ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow secim = gridDemirbaslar.CurrentRow;
                int id = Convert.ToInt16(secim.Cells["Id"].Value);
                DemirbaslarCls demirbaslarCls = new DemirbaslarCls();
                demirbaslarCls.DemirbasSil(id);
                gridDemirbaslar.DataSource = demirbaslarCls.OdanınDemirbasGetir(odaId);
            }

        }
    }
}
