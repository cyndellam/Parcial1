using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MarcaMapper
    {
        public static Marca Map(SqlDataReader reader)
        {
            Marca marca = new Marca();
            marca.Id = Convert.ToInt32(reader["ID"]);
            marca.Descripcion = reader["Descripcion"].ToString();
            return marca;
        }
    }
}
