using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ingreso
    {

        public int IdIngreso { get; set; }
        //public int IdMarca { get; set; }
        public string Descripcion { get; set; }
        public int BultosIngresados { get; set; }
        public int CantidadPorBulto { get; set; }
        public string DniEmpleado { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Marca Marca { get; set; }


        //Constructor por defecto
        public Ingreso() { }

        //Constructor sobrecargado sin descripcion marca
        public Ingreso(int idIngreso, Marca marca, string descripcion, int bultosIngresados, int cantidadPorBulto, string dniEmpleado, string observaciones, DateTime fechaRegistro)
        {
            IdIngreso = idIngreso;
            Marca = marca;
            Descripcion = descripcion;
            BultosIngresados = bultosIngresados;
            CantidadPorBulto = cantidadPorBulto;
            DniEmpleado = dniEmpleado;
            Observaciones = observaciones;
            FechaRegistro = fechaRegistro;

        }


    }
}
