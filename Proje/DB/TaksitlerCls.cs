using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DB
{
    class TaksitlerCls : DAL
    {
        public void TaksitlerEkle(int sozlesmeId, int musteriId, int odaId, decimal taksitTutari, int taksitSayisi, DateTime ilkTaksitTarih)
        {
            for (int i = 0; i < taksitSayisi; i++)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"INSERT INTO Taksitler
                                  (SozlesmeId, OdaId, MusteriId, Tutar, OdenecekTarih, Odendi) Values
                                  (@SozlesmeId, @OdaId, @MusteriId, @Tutar, @OdenecekTarih, @Odendi)";
                cmd.Parameters.AddWithValue("@SozlesmeId", sozlesmeId);
                cmd.Parameters.AddWithValue("@OdaId", odaId);
                cmd.Parameters.AddWithValue("@MusteriId", musteriId);
                cmd.Parameters.AddWithValue("@Tutar", taksitTutari);
                cmd.Parameters.AddWithValue("@OdenecekTarih", ilkTaksitTarih.AddMonths(i));
                cmd.Parameters.AddWithValue("@Odendi", false);

                ExeCuteNonQueryCalistir(cmd);

            }
        }
        public DataTable MusterininTaksitleriniGetir(int musteriId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Taksitler Where MusteriId = @MusteriId";
            cmd.Parameters.AddWithValue("@MusteriId", musteriId);
            return ExeCuteReader(cmd);

        }
        public void TaksitOdemesiAl(int id, decimal tutar)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Taksitler SET Odendi = @Odendi, OdenenTarih = @OdenenTarih Where Id = @Id";
            cmd.Parameters.AddWithValue("@Odendi", true);
            cmd.Parameters.AddWithValue("@OdenenTarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@Id", id);

            ExeCuteNonQueryCalistir(cmd);

            KasalarCls kasalarCls = new KasalarCls();
            kasalarCls.KasaHaraketiEkle(DateTime.Now, "Taksit ödemesi", tutar, 0);


        }
        public DataTable MusterininBorcları(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select 
                                    (
                                    select ISNULL(sum(tutar),0) from Taksitler
                                    where MusteriId = @MusteriId and Odendi = 0 ) as Kalan,
                                    (
                                    select ISNULL(sum (tutar),0) from Taksitler
                                    where MusteriId = @MusteriId and odendi = 1) as Odenen,
                                    (
                                    select ISNULL(sum (tutar),0) from Taksitler
                                    where MusteriId =  @MusteriId ) as Toplam
                                    ";
            cmd.Parameters.AddWithValue("@MusteriId", id);
            return ExeCuteReader(cmd);

        }
        public DataTable ButunTaksitler()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Taksitler Order by OdenecekTarih";

            return ExeCuteReader(cmd);

        }
        public DataTable ButunTaksitler(bool durum)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Taksitler Where Odendi = @Odendi Order by OdenecekTarih";
            cmd.Parameters.AddWithValue("@Odendi", durum);
            return ExeCuteReader(cmd);
        }
        public DataTable TaksitOzeti()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select
                                        (
                                        select ISNULL(sum(tutar), 0) from Taksitler
                                        where Odendi = 0) as Kalan,
                                        (
                                        select ISNULL(sum(tutar), 0) from Taksitler
                                        where odendi = 1) as Odenen,
                                        (
                                        select ISNULL(sum(tutar), 0) from Taksitler) 
                                        as Toplam ";

            return ExeCuteReader(cmd);
        }
    }
}
