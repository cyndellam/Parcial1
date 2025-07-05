using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MarcaBusiness
    {
        private MarcaDao marcaDao = new MarcaDao();

        //opcion sin "seleccione..."
        public List<Marca> GetAll()
        {
            try
            {
                return marcaDao.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //método para llenar el combo que incluye un "Seleccione..."
        public List<Marca> GetAllConSeleccione()
        {
            try
            {
                List<Marca> lista = marcaDao.GetAll();

                // Insertar opción por defecto
                lista.Insert(0, new Marca
                {
                    Id = 0,
                    Descripcion = "Seleccione..."
                });

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
