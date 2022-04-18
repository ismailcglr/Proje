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
    public partial class FrmMusteriTaksitleri : Form
    {
        public string MusteriAdi;
        public int MusteriId;

        TaksitlerCls taksitlerCls = new TaksitlerCls();



        public FrmMusteriTaksitleri()
        {
            InitializeComponent();
        }
        public void MusteriTaksitleri()
        {
            grdTaksitler.DataSource = taksitlerCls.MusterininTaksitleriniGetir(MusteriId);
            DataTable tblborclar = new DataTable();
            tblborclar = taksitlerCls.MusterininBorcları(MusteriId);

            if (tblborclar.Rows.Count == 0)
            {
                lblKalanBorc.Text = "0";
                lblOdenenBorc.Text = "0";
                lblToplamBorc.Text = "0";
            }
            else
            {
                DataRow borcbilgisi = tblborclar.Rows[0];
                lblKalanBorc.Text = borcbilgisi["Kalan"].ToString();
                lblOdenenBorc.Text = borcbilgisi["Odenen"].ToString();
                lblToplamBorc.Text = borcbilgisi["Toplam"].ToString();
            }
        }

        private void FrmMusteriTaksitleri_Load(object sender, EventArgs e)
        {
            lblMusteriAdi.Text = MusteriAdi;
            MusteriTaksitleri();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
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
                MusteriTaksitleri();
            }

            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOdenenBorc_Click(object sender, EventArgs e)
        {

        }
    }
}
