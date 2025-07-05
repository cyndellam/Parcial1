using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class IngresoMapper
    {

        public static Ingreso Map(SqlDataReader reader, Marca marca)
        {
            //  Creamos la instancia
            Ingreso ingreso = new Ingreso();

            // 2Llenamos sus propiedades
            ingreso.IdIngreso = Convert.ToInt32(reader["ID_INGRESO"]);
            ingreso.Marca = marca;
            ingreso.Descripcion = reader["DESCRIPCION"].ToString();
            ingreso.BultosIngresados = Convert.ToInt32(reader["BULTOS_INGRESADOS"]);
            ingreso.CantidadPorBulto = Convert.ToInt32(reader["CANTIDAD_POR_BULTO"]);
            ingreso.DniEmpleado = reader["DNI_EMPLEADO"].ToString();

            // Observaciones puede venir nulo
            if (reader["OBSERVACIONES"] == DBNull.Value)
                ingreso.Observaciones = null;
            else
                ingreso.Observaciones = reader["OBSERVACIONES"].ToString();

            ingreso.FechaRegistro = Convert.ToDateTime(reader["FECHA_REGISTRO"]);

            // 3️⃣ Devolvemos el resultado
            return ingreso;
        }
    }

}
