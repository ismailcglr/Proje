using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DB
{
    public class OdalarCls : DAL
    {
        public DataTable OdalarıGetir()
        {
            

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Odalar";
            return ExeCuteReader(cmd);

            

        }

        public void OdaEkle(String OdaAdi, decimal Fiyat, int Kapasite)
        {
           

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Odalar (OdaAdi, Fiyat, Kapasite) VALUES (@OdaAdi, @Fiyat, @Kapasite)";
            cmd.Parameters.AddWithValue("@OdaAdi", OdaAdi);
            cmd.Parameters.AddWithValue("@Fiyat", Fiyat);
            cmd.Parameters.AddWithValue("@Kapasite", Kapasite);
            ExeCuteNonQueryCalistir(cmd);
            
        }

        public DataRow OdaGetir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Odalar Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);
            DataTable tbl = new DataTable();
            tbl = ExeCuteReader(cmd);

            return tbl.Rows[0];
        }

        public void OdaDuzenle(int odaId, string YeniOdaAdi, decimal YeniOdaFiyati, int YeniKapasite)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Odalar Set
                                OdaAdi = @OdaAdi,
                                Fiyat = @Fiyat,
                                Kapasite = @Kapasite
                                Where Id = @Id";
            cmd.Parameters.AddWithValue("@OdaAdi", YeniOdaAdi);
            cmd.Parameters.AddWithValue("@Fiyat", YeniOdaFiyati);
            cmd.Parameters.AddWithValue("@Kapasite", YeniKapasite);
            cmd.Parameters.AddWithValue("@Id", odaId);

            ExeCuteNonQueryCalistir(cmd);


        }


    }
}
