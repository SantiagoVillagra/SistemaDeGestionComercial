using Rotiseria.Datos;
using Rotiseria.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotiseria.Presentacion
{
    public partial class frmUpdated : Form
    {
        RotiseriaServicio rotiseriaServicio = new RotiseriaServicio();
        private string nombreCliente = "";
        private string apeCliente = "";
        private string telCliente = "";
        private string direCliente = "";
        private int idBarrioSeleccionado;
        private int idClienteSeleccionado;

        public frmUpdated()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdated_Load(object sender, EventArgs e)
        {
            nombreTxt.Text = nombreCliente;
            apeTxt.Text = apeCliente;
            telTxt.Text = telCliente;
            dirTxt.Text = direCliente;

            DataTable tablaBarrios = rotiseriaServicio.TraerBarrios("Barrios");
            
            cboBarrios.DisplayMember = "nombre_barrio";
            cboBarrios.ValueMember = "id_barrio";
            cboBarrios.DataSource = tablaBarrios;

            cboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrios.SelectedValue = idBarrioSeleccionado;

        }

        public frmUpdated(string nombreCliente, string apeCliente, string telCliente, string direCliente, int id_barrio, int idCliente)
        {
            InitializeComponent();
            this.nombreCliente = nombreCliente;
            this.apeCliente = apeCliente;
            this.telCliente = telCliente;
            this.direCliente = direCliente;
            this.Text = "Modificar cliente " + nombreCliente;
            this.idBarrioSeleccionado = id_barrio;
            this.idClienteSeleccionado = idCliente;
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombreTxt.Text))
            {
                MessageBox.Show("Debe ingresar nombre", "Faltan datos", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(apeTxt.Text))
            {
                MessageBox.Show("Debe ingresar apellido", "Faltan datos", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(telTxt.Text))
            {
                MessageBox.Show("Debe ingresar telefono", "Faltan datos", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(dirTxt.Text))
            {
                MessageBox.Show("Debe ingresar direccion", "Faltan datos", MessageBoxButtons.OK);
                return;
            }
            if (cboBarrios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar barrio", "Faltan datos", MessageBoxButtons.OK);
                return;
            }


           
            string consultaUpdate = "UPDATE clientes SET nombre = @nombre, apellido = @apellido,telefono = @telefono,direccion = @direccion, id_barrio = @barrio WHERE id_cliente = @id_cliente";

                List<Parametro> listaParametros = new List<Parametro>();


                listaParametros.Add(new Parametro("@nombre", nombreTxt.Text));
                listaParametros.Add(new Parametro("@apellido", apeTxt.Text));
                listaParametros.Add(new Parametro("@telefono", Convert.ToInt32(telTxt.Text)));
                listaParametros.Add(new Parametro("@direccion", dirTxt.Text));
                listaParametros.Add(new Parametro("@barrio", Convert.ToInt32(cboBarrios.SelectedValue)));
                listaParametros.Add(new Parametro("@id_cliente", idClienteSeleccionado));

                int filasAfectadas = rotiseriaServicio.ModificarCliente(consultaUpdate, listaParametros);



          
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Modificacion exitosa", "carga exitosa", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el cliente", "Fallo", MessageBoxButtons.OK);
                this.Close();
            }

        }

        private void nuevoBarrioBtn_Click(object sender, EventArgs e)
        {
            FrmNuevoBarrio FormNuevoBarrio = new FrmNuevoBarrio();

            FormNuevoBarrio.ShowDialog();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la modificacion?",
               "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}

