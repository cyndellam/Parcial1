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
    public class IngresoDao
    {
        private MarcaDao marcaDao = new MarcaDao();


        public List<Ingreso> GetAll()
        {
            try
            {
                var lista = new List<Ingreso>();
                string connectionString = ConfigurationManager.ConnectionStrings["ParcialConn"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT ID_INGRESO, ID_MARCA, DESCRIPCION, BULTOS_INGRESADOS, 
                                     CANTIDAD_POR_BULTO, DNI_EMPLEADO, OBSERVACIONES, FECHA_REGISTRO 
                                     FROM INGRESO";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                      
                        while (reader.Read())
                        {
                            //leo la marca
                            int idMarca = Convert.ToInt32(reader["ID_MARCA"]);
                            //matcheo con el id
                            Marca marca = new MarcaDao().GetById(idMarca);
                            //se lo paso
                            Ingreso ingreso = IngresoMapper.Map(reader, marca);
                            
                           lista.Add(ingreso);

                        }
                        return lista;
                    }
                }

                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los ingresos: " + ex.Message);
            }
        }

        public void Guardar(Ingreso ingreso)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ParcialConn"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO INGRESO 
                                     (ID_MARCA, DESCRIPCION, BULTOS_INGRESADOS, CANTIDAD_POR_BULTO, DNI_EMPLEADO, OBSERVACIONES, FECHA_REGISTRO)
                                     VALUES 
                                     (@IdMarca, @Descripcion, @BultosIngresados, @CantidadPorBulto, @DniEmpleado, @Observaciones, @FechaRegistro)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdMarca", ingreso.Marca.Id);
                        cmd.Parameters.AddWithValue("@Descripcion", ingreso.Descripcion);
                        cmd.Parameters.AddWithValue("@BultosIngresados", ingreso.BultosIngresados);
                        cmd.Parameters.AddWithValue("@CantidadPorBulto", ingreso.CantidadPorBulto);
                        cmd.Parameters.AddWithValue("@DniEmpleado", ingreso.DniEmpleado);
                        cmd.Parameters.AddWithValue("@Observaciones", ingreso.Observaciones);
                        cmd.Parameters.AddWithValue("@FechaRegistro", ingreso.FechaRegistro);

                        //corro la query
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el ingreso en la base de datos: " + ex.Message);
            }
        }

        public void ModificarCantidad(int idIngreso, int nuevaCantidad)
        {
            string conexionString = ConfigurationManager.ConnectionStrings["ParcialConn"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    con.Open();
                    string query = "UPDATE INGRESO SET BULTOS_INGRESADOS = @BultosIngresados WHERE ID_INGRESO = @NumeroIngreso";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@NumeroIngreso", idIngreso);
                        command.Parameters.AddWithValue("@BultosIngresados", nuevaCantidad);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarIngreso(int idIngreso)
        {
            string conexionString = ConfigurationManager.ConnectionStrings["ParcialConn"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    con.Open();
                    string query = "DELETE FROM INGRESO WHERE ID_INGRESO = @NumeroIngreso";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@NumeroIngreso", idIngreso);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ingreso GetById(int idIngreso)
        {
            
            try
            {
                string conexionString = ConfigurationManager.ConnectionStrings["ParcialConn"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    con.Open();
                    string query = @"SELECT ID_INGRESO, ID_MARCA, DESCRIPCION, BULTOS_INGRESADOS, 
                                    CANTIDAD_POR_BULTO, DNI_EMPLEADO, OBSERVACIONES, FECHA_REGISTRO 
                             FROM INGRESO 
                             WHERE ID_INGRESO = @IdIngreso";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdIngreso", idIngreso);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idMarca = (Convert.ToInt32(reader["ID_MARCA"]));
                                Marca marca = new MarcaDao().GetById(idMarca);
                                Ingreso ingreso = IngresoMapper.Map(reader, marca);
                                return ingreso;
                           
                            }
                        }
                    }
                }

                // Si no encontró ningún registro
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ingreso por ID: " + ex.Message, ex);
            }
        }
    }




    


}
