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
    public partial class FrmTaksitler : Form
    {
        TaksitlerCls taksitlerCls = new TaksitlerCls();

        public void TaksitOzetleri()
        {
            DataTable tblOzet = new DataTable();
            tblOzet = taksitlerCls.TaksitOzeti();
            if (tblOzet.Rows.Count == 0)
            {
                lblOdenenToplam.Text = "0";
                lblOdenmeyenToplam.Text = "0";
                lblTaksitlerToplamı.Text = "0";
            }
            else
            {
                DataRow ozet = tblOzet.Rows[0];
                lblOdenenToplam.Text = ozet["Odenen"].ToString();
                lblOdenmeyenToplam.Text = ozet["Kalan"].ToString();
                lblTaksitlerToplamı.Text = ozet["Toplam"].ToString();

            }
        }

        public FrmTaksitler()
        {
            InitializeComponent();
        }

        private void lblGelir1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grdTaksitler.DataSource = taksitlerCls.ButunTaksitler();
        }

        private void btnOdenenler_Click(object sender, EventArgs e)
        {
            grdTaksitler.DataSource = taksitlerCls.ButunTaksitler(true);
        }

        private void btnOdenmeyenler_Click(object sender, EventArgs e)
        {
            grdTaksitler.DataSource = taksitlerCls.ButunTaksitler(false);
        }

        private void btnOdemeal_Click(object sender, EventArgs e)
        {
            DataGridViewRow secimtaksit = grdTaksitler.CurrentRow;
            int id = Convert.ToInt16(secimtaksit.Cells["Id"].Value);
            decimal tutar = Convert.ToDecimal(secimtaksit.Cells["Tutar"].Value);
            bool odendi = Convert.ToBoolean(secimtaksit.Cells["Odendi"].Value);

            if (odendi)
            {
                MessageBox.Show("BU TAKSİT DAHA ÖNCE ÖDENDİ");
            }
            else
            {
                taksitlerCls.TaksitOdemesiAl(id, tutar);
                grdTaksitler.DataSource = taksitlerCls.ButunTaksitler(false);
                TaksitOzetleri();
            }
            
        }

        private void grdTaksitler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTaksitler_Load(object sender, EventArgs e)
        {
            grdTaksitler.DataSource = taksitlerCls.ButunTaksitler(false);
            TaksitOzetleri();
        }
    }
}
