using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MarcaDao
    {
        public List<Marca> GetAll()
        {
            try
            {
                
                string conectionString = ConfigurationManager.ConnectionStrings["ParcialConn"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();
                    string query = "SELECT ID, DESCRIPCION FROM MARCA";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            List<Marca> tiposMarca = new List<Marca>();
                            while (reader.Read())
                            {
                                tiposMarca.Add(MarcaMapper.Map(reader));
                            }
                            return tiposMarca;
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public Marca GetById(int id)
        {
            try
            {
                Marca marcaEncontrada = null;
                string conectionString = ConfigurationManager.ConnectionStrings["ParcialConn"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();
                    string query = "SELECT ID, DESCRIPCION FROM MARCA WHERE ID = @Id";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<Marca> listaMarcas = new List<Marca>();
                                {
                                    return MarcaMapper.Map(reader);
                                }
                            }
                        }
                    }
                }
                return marcaEncontrada;
            }
            catch
            {
                throw;
            }
        }

    }
}
