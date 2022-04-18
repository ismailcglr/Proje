using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DB
{
    public class SozlesmelerCls : DAL
    {
        public DataTable SozlesmeleriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Sozlesmeler";

            return ExeCuteReader(cmd);
        }

        public void SozlesmeOlustur(int musteriId, int odaId, decimal toplamTutar, int taksitSayisi, DateTime ilktaksittarihi,
                DateTime baslangicTarihi, DateTime bitisTarih)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =   @"INSERT INTO Sozlesmeler
                                (MusteriId, OdaId, SozlesmeTutari, BaslangicTarihi, BitisTarih, SozlesmeTarih, Sonlandi)
                                output INSERTED.Id VALUES
                                (@MusteriId, @OdaId, @SozlesmeTutari, @BaslangicTarihi, @BitisTarih, @SozlesmeTarih, @Sonlandi)";
            cmd.Parameters.AddWithValue("@MusteriId", musteriId);
            cmd.Parameters.AddWithValue("@OdaId", odaId);
            cmd.Parameters.AddWithValue("@SozlesmeTutari", toplamTutar);
            cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
            cmd.Parameters.AddWithValue("@BitisTarih", bitisTarih);
            cmd.Parameters.AddWithValue("@SozlesmeTarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@Sonlandi", false);

            int eklenenSozlesmeId = ExecuteScalarCalistir(cmd);


            decimal taksitTutari = Math.Round(toplamTutar / taksitSayisi, 2);

            TaksitlerCls taksitlerCls = new TaksitlerCls();
            taksitlerCls.TaksitlerEkle(eklenenSozlesmeId, musteriId, odaId, taksitTutari, taksitSayisi, ilktaksittarihi);

        }
        public void SozlesmeSİL(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete From Sozlesmeler Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            ExeCuteNonQueryCalistir(cmd);

        }

    }
}
