using System.Collections.Generic;
using System.Data.SqlClient;
using _19._04._22_ADONET.Model;

using Microsoft.Extensions.Configuration;

namespace _19._04._22_ADONET.Data
{
    public class Kategoriler : ICRUD<Kategori>
    {
        private SqlConnection _connection = MSSQLConnection.SqlConnection;
        public List<Kategori> GetList()
        {
            _connection.Open();
            List<Kategori> kategoriler = new List<Kategori>();
            SqlCommand command = new SqlCommand("Select * from Kategoriler", _connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Kategori kategori = new Kategori()
                    {KategoriId = (int) dr["KategoriId"], KategoriAdi = dr["KategoriAdi"].ToString()};
                kategoriler.Add(kategori);
            }

            _connection.Close();
            return kategoriler;
        }

        public Kategori Get(int id)
        {
            _connection.Open();
            using (SqlCommand command = new SqlCommand("Select from Kategoriler where KategoriId=@p1", _connection))
            {
                command.Parameters.AddWithValue("@p1", id);

                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                Kategori kategori = new Kategori() {KategoriId = -1};
                if (dr.HasRows)
                {
                    kategori = new Kategori()
                        {KategoriId = (int) dr["KategoriId"], KategoriAdi = dr["KategoriAdi"].ToString()};
                }

                return kategori;
            }
        }

        public void Add(Kategori model)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Insert into Kategoriler (KategoriAdi) values(@p1)", _connection);
            command.Parameters.AddWithValue("@p1", model.KategoriAdi);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int id)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Delete from Kategoriler where KategoriId=@p1", _connection);
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Kategori model)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Update Kategoriler set KategoriAdi=@p1 where KategoriId=@p2", _connection);
            command.Parameters.AddWithValue("@p1", model.KategoriAdi);
            command.Parameters.AddWithValue("@p2", model.KategoriId);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}