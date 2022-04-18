using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DB
{
    public class DemirbaslarCls : DAL
    {
        public DataTable OdanınDemirbasGetir(int odaId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Demirbas Where OdaId = @OdaId";
            cmd.Parameters.AddWithValue("@OdaId", odaId);

            return ExeCuteReader(cmd);
        }
        public void DemirbasEkle(int odaId, String adi, int adet)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Demirbas (OdaID, DemirbasAdi, Adet) VALUES (@OdaId, @DemirbasAdi, @Adet)";
            cmd.Parameters.AddWithValue("@OdaId", odaId);
            cmd.Parameters.AddWithValue("@DemirbasAdi", adi);
            cmd.Parameters.AddWithValue("@Adet", adet);

            ExeCuteNonQueryCalistir(cmd);
        }
        public void DemirbasSil(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete From Demirbas Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);
            ExeCuteNonQueryCalistir(cmd);
        }
    }
}
