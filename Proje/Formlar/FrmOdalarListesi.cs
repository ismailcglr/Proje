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
    public partial class FrmOdalarListesi : Form
    {
        public FrmOdalarListesi()
        {
            InitializeComponent();
        }
        
        public void OdalarıGetir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "SERVER = DESKTOP-6DKJ7TR; Database = Proje; Trusted_Connection = True";
            baglanti.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Odalar";
            cmd.Connection = baglanti;

            DataTable tblOdalar = new DataTable();
            tblOdalar.Load(cmd.ExecuteReader());
            baglanti.Close();

            grdOdalar.DataSource = tblOdalar;

        }

        private void FrmOdalarListesi_Load(object sender, EventArgs e)
        {
            OdalarıGetir();


        }

        private void btnYeniOda_Click(object sender, EventArgs e)
        {
            FrmOdaEkle f = new FrmOdaEkle();
            f.ShowDialog();

            OdalarıGetir();
        }
        private void btnDemirbas_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow secim = grdOdalar.CurrentRow;
            int id = Convert.ToInt16(secim.Cells["Id"].Value);
            string odaAdi = secim.Cells["OdaAdi"].Value.ToString();

            FrmDemirbaslar f = new FrmDemirbaslar(id, odaAdi);
            f.ShowDialog();
        }

        private void btnOdaDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secim = grdOdalar.CurrentRow;
            int id = Convert.ToInt16(secim.Cells["Id"].Value);
            FrmOdaDuzenle f = new FrmOdaDuzenle();
            f.odaID = id;
            if (f.ShowDialog() == DialogResult.OK)
            {
                OdalarıGetir();
            }
           
            
        }
    }
}
