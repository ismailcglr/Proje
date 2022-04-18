using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DB
{
    public class DAL
    {
        SqlConnection baglanti;
        string connectionstring = "SERVER = DESKTOP-6DKJ7TR; Database = Proje; Trusted_Connection = True";


        public void baglantiAc()
        {
            baglanti = new SqlConnection();
            baglanti.ConnectionString = connectionstring;
            baglanti.Open();
        }
        public void baglantiKapat()
        {
            baglanti.Close();
        }
        public void ExeCuteNonQueryCalistir(SqlCommand cmd)
        {
            baglantiAc();
            cmd.Connection = baglanti;
            cmd.ExecuteNonQuery();

        }
        public int ExecuteScalarCalistir(SqlCommand cmd)
        {
            baglantiAc();
            cmd.Connection = baglanti;
            return (int)cmd.ExecuteScalar();

        }
        public DataTable ExeCuteReader(SqlCommand cmd)
        {

            baglantiAc();
            cmd.Connection = baglanti;
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            baglantiKapat();

            return tbl;

        }
    }
}
