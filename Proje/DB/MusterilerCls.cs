using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DB
{
    public class MusterilerCls : DAL   
    {
        public DataTable MusterileriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select m.* , ISNULL ((Select  sum(tutar) from Taksitler
                                    where Odendi = 0 and MusteriId = m.Id
                                    group by MusteriId
                                    ), 0) as KalanBorc from Musteriler m";

            return ExeCuteReader(cmd);
        }

        public DataRow MusteriGetir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Musteriler Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            return ExeCuteReader(cmd).Rows[0];
        }

        public void MusteriEkle(string adi, string soyadi, DateTime dogumTarihi, string tcno, string ceptel, string adres)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Musteriler
                          (Ad, Soyad, DogumTarihi, TcKimlik , CepTelefonu, Adres) VALUES 
                          (@Ad, @Soyad, @DogumTarihi, @TcKimlik , @CepTelefonu, @Adres)";
            cmd.Parameters.AddWithValue("@Ad", adi);
            cmd.Parameters.AddWithValue("@Soyad", soyadi);
            cmd.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
            cmd.Parameters.AddWithValue("@TcKimlik", tcno);
            cmd.Parameters.AddWithValue("@CepTelefonu", ceptel);
            cmd.Parameters.AddWithValue("@Adres", adres);

            ExeCuteReader(cmd);

        }

        public void MusteriDuzenle(int id, string adi, string soyadi, DateTime dogumTarihi, string tcno, string ceptel, string adres)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Uptade Musteriler 
                                SET 
                                Ad = @Ad,
                                Soyad = @Soyad,
                                DogumTarihi = @DogumTarihi,
                                TcKimlik = @TcKimlik,
                                CepTelefonu = @CepTelefonu,
                                Adres = @Adres Where Id = @Id ";

            cmd.Parameters.AddWithValue("@Ad", adi);
            cmd.Parameters.AddWithValue("@Soyad", soyadi);
            cmd.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
            cmd.Parameters.AddWithValue("@TcKimlik", tcno);
            cmd.Parameters.AddWithValue("@CepTelefonu", ceptel);
            cmd.Parameters.AddWithValue("@Adres", adres);

            ExeCuteNonQueryCalistir(cmd);

        }

        public void MusteriSil(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete From Musteriler Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);
            ExeCuteNonQueryCalistir(cmd);
        }

    }
}
