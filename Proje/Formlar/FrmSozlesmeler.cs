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
    public partial class FrmSozlesmeler : Form
    {

        SozlesmelerCls sozlesmelerCls = new SozlesmelerCls();

        public FrmSozlesmeler()
        {
            InitializeComponent();
        }

        private void FrmSozlesmeler_Load(object sender, EventArgs e)
        {
            grdSozlesmeler.DataSource = sozlesmelerCls.SozlesmeleriGetir();
        }

        private void btnSozlesmeEkle_Click(object sender, EventArgs e)
        {
            Formlar.FrmSozlesmeEkle f = new FrmSozlesmeEkle();
            if(f.ShowDialog() == DialogResult.OK)
            {
                grdSozlesmeler.DataSource = sozlesmelerCls.SozlesmeleriGetir();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili sözleşme silinsinmi ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow secim = grdSozlesmeler.CurrentRow;
                int id = Convert.ToInt16(secim.Cells["Id"].Value);
                sozlesmelerCls.SozlesmeSİL(id);
                grdSozlesmeler.DataSource = sozlesmelerCls.SozlesmeleriGetir();
            }
        }
    }
}
