using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MarcaBusiness marcaBusiness = new MarcaBusiness();
        private TipoBultoBusiness tipoBultoBusiness = new TipoBultoBusiness();
        private IngresoBusiness ingresoBusiness = new IngresoBusiness();
        List<Ingreso> borradorIngresos = new List<Ingreso>();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarDgvBebidasVendidas();
                cmbMarca.DataSource = marcaBusiness.GetAllConSeleccione();
                cmbMarca.ValueMember = "Id";
                cmbMarca.DisplayMember = "Descripcion";
                cmbCantBulto.DataSource = tipoBultoBusiness.ObtenerTiposDeBultoConSeleccione();
                cmbCantBulto.DropDownStyle = ComboBoxStyle.DropDownList; //solo seleccioon items disponibles
                cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList; //solo seleccioon items disponibles
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }


        private void ActualizarDgvBebidasVendidas()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Autoajusta el tamaño de columnas al contenido
                dataGridView1.RowHeadersVisible = false; // saca el encabezado lateral
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona todo el registro
                dataGridView1.AllowUserToAddRows = false; // evita la fila en blanco al final
                dataGridView1.ReadOnly = true; // solo lectura si no vas a editar desde la grilla
                dataGridView1.DataSource = ingresoBusiness.GetAll();

                #region Modifico encabezado
                dataGridView1.Columns["IdIngreso"].HeaderText = "ID Ingreso";
                dataGridView1.Columns["Marca"].HeaderText = "ID Marca";
                dataGridView1.Columns["BultosIngresados"].HeaderText = "Bultos Ingresados";
                dataGridView1.Columns["CantidadPorBulto"].HeaderText = "Cant. x Bulto";
                dataGridView1.Columns["DniEmpleado"].HeaderText = "Dni Empleado";
                dataGridView1.Columns["FechaRegistro"].HeaderText = "Registrado el";
                //dataGridView1.Columns["FechaValidez"].HeaderText = "Fecha de Validez";
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void LimpiarCampos()
        {
            try { 
            textDescripcion.Clear();
            txtBultos.Clear();
            txtDni.Clear();
            txtObs.Clear();
            txtEliminarID.Clear();
            txtModificarID.Clear();
            txtCantModificar.Clear();
            cmbMarca.DataSource = marcaBusiness.GetAllConSeleccione();
            cmbMarca.ValueMember = "Id";
            cmbMarca.DisplayMember = "Descripcion";
            cmbCantBulto.DataSource = tipoBultoBusiness.ObtenerTiposDeBultoConSeleccione();
            cmbCantBulto.DropDownStyle = ComboBoxStyle.DropDownList; //solo seleccioon items disponibles
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList; //solo seleccioon items disponibles

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Ingreso ingreso = new Ingreso();
                ingreso.Marca = new Marca();

                ingreso.Marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);
                ingreso.Descripcion = textDescripcion.Text;
                ingreso.BultosIngresados = Convert.ToInt32(txtBultos.Text);
                ingreso.CantidadPorBulto = ((TipoBulto)cmbCantBulto.SelectedItem).Cantidad;
                ingreso.DniEmpleado = txtDni.Text;
                ingreso.Observaciones = txtObs.Text;

                // FechaRegistro se setea automáticamente en la BLL

                ingresoBusiness.GuardarIngreso(ingreso);
                ActualizarDgvBebidasVendidas(); // este método actualiza la grilla
                MessageBox.Show("Ingreso guardado exitosamente");

                LimpiarCampos();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ingresoBusiness.EliminarIngreso(Convert.ToInt32(txtEliminarID.Text));
                MessageBox.Show("Ingreso eliminado con éxito");

                ActualizarDgvBebidasVendidas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
  
                try
                {
                    ingresoBusiness.modificarCantidad(Convert.ToInt32(txtModificarID.Text), Convert.ToInt32(txtCantModificar.Text));
                    MessageBox.Show("Entrada modificada con éxito");
                    ActualizarDgvBebidasVendidas();
                    LimpiarCampos();

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private Ingreso getNuevoIngresoCargado()
        {
            Ingreso nuevoIngreso = new Ingreso();

            if (cmbMarca.SelectedIndex == -1)
            {
                nuevoIngreso.Marca = null;
            }
            else
            {
                Marca marca = new Marca();
                marca.Id = Convert.ToInt32(cmbMarca.SelectedValue);
                marca.Descripcion = cmbMarca.Text;
                nuevoIngreso.Marca = marca;
            }
            nuevoIngreso.Descripcion = textDescripcion.Text;
            nuevoIngreso.BultosIngresados = int.Parse(txtBultos.Text);
            if (string.IsNullOrWhiteSpace(cmbCantBulto.Text))
            {
                nuevoIngreso.CantidadPorBulto = 0;
            }
            else
            {
                nuevoIngreso.CantidadPorBulto = int.Parse(cmbCantBulto.Text);
            }
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                nuevoIngreso.DniEmpleado = null;
            }
            else
            {
                nuevoIngreso.DniEmpleado = txtDni.Text;
            }
            nuevoIngreso.Observaciones = txtObs.Text;
            return nuevoIngreso;
        }

        private void btnAgregarALista_Click(object sender, EventArgs e)
        {
            Ingreso nuevoIngreso = getNuevoIngresoCargado();
            borradorIngresos.Add(nuevoIngreso);
            MessageBox.Show("Ingreso agregado al borrador");
        }


        private void btnIngresarListados_Click(object sender, EventArgs e)
        {

            try
            {
                ingresoBusiness.AgregarMultiplesIngresos(borradorIngresos);
                ActualizarDgvBebidasVendidas(); // este método actualiza la grilla
                MessageBox.Show("Ingresos guardados exitosamente");
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
