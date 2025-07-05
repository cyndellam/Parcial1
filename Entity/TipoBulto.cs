using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TipoBulto
    {

        public int Cantidad { get; set; }

        public TipoBulto(int cantidad)
        {
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            if (Cantidad == 0)
            {
                return "Seleccione...";
            }
            else
            {
                return Cantidad.ToString();
            }
        }
    }
}
