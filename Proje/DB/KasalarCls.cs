using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DB
{
    public class KasalarCls : DAL
    {

        public void KasaHaraketiEkle(DateTime islemTarihi, string aciklama, decimal girentutar, decimal cıkantutar)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO KasaHaraketleri (IslemTarihi, Aciklama, KasayaGelenTutar, KasadanCıkanTutar)
                               values 
                               (@IslemTarihi, @Aciklama, @KasayaGelenTutar, @KasadanCıkanTutar) ";

            cmd.Parameters.AddWithValue("@IslemTarihi", islemTarihi);
            cmd.Parameters.AddWithValue("@Aciklama", aciklama);
            cmd.Parameters.AddWithValue("@KasayaGelenTutar", girentutar);
            cmd.Parameters.AddWithValue("@KasadanCıkanTutar", cıkantutar);

            ExeCuteNonQueryCalistir(cmd);

        }
        public DataTable KasaHareketleriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from KasaHaraketleri order by Id desc";

            return ExeCuteReader(cmd);
        }
        public  DataTable KasaOzeti()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select sum(KasayaGelenTutar) as ToplamGiren , sum(KasadanCıkanTutar) as ToplamGiden,
                                sum(KasayaGelenTutar - KasadanCıkanTutar) as Kalan
                                from KasaHaraketleri";

            return ExeCuteReader(cmd);

        }

    }
}
