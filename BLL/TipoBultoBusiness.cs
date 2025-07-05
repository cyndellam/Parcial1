using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TipoBultoBusiness
    {
        public List<TipoBulto> ObtenerTiposDeBultoConSeleccione()
        {
            try
            {
                var lista = new List<TipoBulto>
        {
            new TipoBulto(0), //para seleccione...
            new TipoBulto(4),
            new TipoBulto(6),
            new TipoBulto(12),
            new TipoBulto(24)
        };

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los tipos de bulto:", ex);
            }
        }

    }
}
