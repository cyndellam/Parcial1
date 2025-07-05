using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class IngresoBusiness
    {


        private IngresoDao ingresoDao = new IngresoDao();


        public List<Ingreso> GetAll()
        {
            try
            {
                return ingresoDao.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarIngreso(Ingreso ingreso)
        {
            using (var trx = new TransactionScope())
            {
                try
                {
                    //VALIDACIONES
                    if (ingreso.Marca == null) //fuerzo a elegir una opción válida de la lista
                        throw new Exception("Debe seleccionar una marca.");

                    if (string.IsNullOrWhiteSpace(ingreso.Descripcion))
                        throw new Exception("La descripción no puede estar vacía.");

                    if (ingreso.Descripcion.Length <= 5)
                        throw new Exception("La descripción debe ser más larga.");

                    if (ingreso.BultosIngresados < 1)
                        throw new Exception("La cantidad de bultos ingresados debe ser mayor o igual a 1.");

                    var cantidadesValidas = new List<int> { 4, 6, 12, 24 }; //fuerzo a elegir una opción de la lista
                    if (!cantidadesValidas.Contains(ingreso.CantidadPorBulto))
                        throw new Exception("La cantidad por bulto debe ser 4, 6, 12 o 24 unidades.");

                    if (string.IsNullOrWhiteSpace(ingreso.DniEmpleado))
                        throw new Exception("Debe ingresar el DNI del empleado.");

                    int dniNumerico;
                    if (!(ingreso.DniEmpleado.Length == 8 && int.TryParse(ingreso.DniEmpleado, out dniNumerico))) //si no son 8 digitos, descarto
                        throw new Exception("El DNI debe tener 8 dígitos numéricos.");

                    if (!string.IsNullOrWhiteSpace(ingreso.Observaciones) && ingreso.Observaciones.Length <= 5)
                        throw new Exception("Si ingresa observaciones, deben tener más de 5 caracteres.");

                    ingreso.FechaRegistro = DateTime.Now;

                    ingresoDao.Guardar(ingreso);
                    trx.Complete();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar el ingreso: " + ex.Message);
                }
            }
        }

        public void AgregarMultiplesIngresos(List<Ingreso> ingresos)
        {
            using (var trx = new TransactionScope())
            {
                foreach (var ingreso in ingresos)
                {
                    GuardarIngreso(ingreso);
                }
                trx.Complete();
            }
        }

        public void EliminarIngreso(int idIngreso)
        {
            try
            {
                // Validar si existe antes de eliminar
                Ingreso ingreso = ingresoDao.GetById(idIngreso);
                using (var trx = new TransactionScope())
                { 
                    if (ingreso != null)
                    {
                        ingresoDao.EliminarIngreso(idIngreso);
                        trx.Complete();
                    }
                    else
                    {
                        throw new Exception("El ingreso seleccionado no existe y no se puede eliminar.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar: " + ex.Message);
            }
        }

        public void modificarCantidad(int idIngreso, int nuevaCantidad)
        {
            try
            {
                //valido si la entrada existe
                Ingreso ingreso = ingresoDao.GetById(idIngreso);


                using (var trx = new TransactionScope())
                { 
                    if (ingreso != null)
                    {
                        ingresoDao.ModificarCantidad(idIngreso, nuevaCantidad);
                        trx.Complete();
                    }
                    else
                    {
                        throw new Exception("El ingreso seleccinado no existe");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


    }
}
