using System.Collections.Generic;
using System.Data.SqlClient;
using _19._04._22_ADONET.Model;

namespace _19._04._22_ADONET.Data
{
    public class Kitaplar : ICRUD<Kitap>
    {
        private SqlConnection _connection= MSSQLConnection.SqlConnection;

        public List<Kitap> GetList()
        {
            _connection.Open();
            List<Kitap> kitaplar = new List<Kitap>();
            SqlCommand command = new SqlCommand("Select * from Kitaplar", _connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Kitap kitap = new Kitap()
                    { KitapId = (int)dr["KitapId"], KitapAdi = dr["KitapAdi"].ToString(), KategoriId = (int)dr["KategoriId"], SayfaSayisi = (int?)dr["SayfaSayisi"], Ozet = dr["Ozet"].ToString() };
                kitaplar.Add(kitap);
            }

            _connection.Close();
            return kitaplar;
        }

        public Kitap Get(int id)
        {
            _connection.Open();
            using (SqlCommand command= new SqlCommand("Select * from kitaplar where KitapId=@p1",_connection))
            {
                command.Parameters.AddWithValue("@p1", id);

                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                Kitap kitap = new Kitap(){KitapId = -1};
                if (dr.HasRows)
                {
                    kitap= new Kitap() { KitapId = (int)dr["KitapId"], KitapAdi = dr["KitapAdi"].ToString(), KategoriId = (int)dr["KategoriId"], SayfaSayisi = (int?)dr["SayfaSayisi"], Ozet = dr["Ozet"].ToString() };
                }
                _connection.Close();
                return kitap;

            }
        }

        public void Add(Kitap model)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Insert into Kitaplar (KitapAdi,KategoriId,SayfaSayisi,Ozet) values (@p1,@p2,@p3,@p4)", _connection);
            command.Parameters.AddWithValue("@p1", model.KitapAdi);
            command.Parameters.AddWithValue("@p2", model.KategoriId);
            command.Parameters.AddWithValue("@p3", model.SayfaSayisi);
            command.Parameters.AddWithValue("@p4", model.Ozet);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int id)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Delete from Kitaplar where KitapId=@p1", _connection);
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Kitap model)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Update Kitaplar set KitapAdi=@p1,KategoriId=@p2,SayfaSayisi=@p3,Ozet=@p4 where KitapId=@p5", _connection);
            command.Parameters.AddWithValue("@p1", model.KitapAdi);
            command.Parameters.AddWithValue("@p2", model.KategoriId);
            command.Parameters.AddWithValue("@p3", model.SayfaSayisi);
            command.Parameters.AddWithValue("@p4", model.Ozet);
            command.Parameters.AddWithValue("@p5", model.KitapId);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public int GetCount()
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Select Count(*) from Kitaplar", _connection);
            int count = (int)command.ExecuteScalar();
            _connection.Close();
            return count;
        }
    }
}