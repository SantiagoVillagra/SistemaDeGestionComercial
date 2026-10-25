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
    public partial class FrmNuevoCliente : Form
    {
        RotiseriaServicio Servicio = new RotiseriaServicio();
        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {


            DataTable tablaBarrios = Servicio.TraerBarrios("Barrios");

            cboBarrios.DisplayMember = "nombre_barrio";
            cboBarrios.ValueMember = "id_barrio";
            cboBarrios.DataSource = tablaBarrios;
            cboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrios.SelectedIndex = -1;





        }

        private void FrmNuevoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("¿Desea cerrar el programa?", "SALIR",
            //   MessageBoxButtons.YesNo,
            //   MessageBoxIcon.Question,
            //   MessageBoxDefaultButton.Button2) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿Desea cerrar el programa?", "SALIR",
            //   MessageBoxButtons.YesNo,
            //   MessageBoxIcon.Question,
            //   MessageBoxDefaultButton.Button2) == DialogResult.No)
            //{
            //    this.Dispose();
            //}

            if (MessageBox.Show("¿Desea cerrar el nuevo cliente?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            string nombre = nombreTxt.Text.Trim();
            string apellido = apeTxt.Text.Trim();
            string telefono = telTxt.Text.Trim();
            string direccion = dirTxt.Text.Trim();


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
            if (!long.TryParse(telefono, out _))
            {
                MessageBox.Show("El teléfono debe contener solo números", "Formato incorrecto", MessageBoxButtons.OK);
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

            List<Parametro> listaParametros = new List<Parametro>();

            listaParametros.Add(new Parametro("@nombre", nombreTxt.Text));
            listaParametros.Add(new Parametro("@apellido", apeTxt.Text));
            listaParametros.Add(new Parametro("@telefono", Convert.ToInt64(telTxt.Text)));
            listaParametros.Add(new Parametro("@direccion", dirTxt.Text));
            listaParametros.Add(new Parametro("@barrio", cboBarrios.SelectedValue));

            string consultaSql = $"INSERT INTO clientes(nombre,apellido,telefono,direccion, id_barrio) VALUES(@nombre,@apellido,@telefono,@direccion, @barrio)";
            int filasAfectadas = Servicio.insertarBarrio(consultaSql, listaParametros);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("cliente cargado con exito", "exito", MessageBoxButtons.OK);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("El cliente no se cargo", "No se pudo cargar", MessageBoxButtons.OK);
            }

        }

        private void nuevoBarrioBtn_Click(object sender, EventArgs e)
        {
            FrmNuevoBarrio FormNuevoBarrio = new FrmNuevoBarrio();

            FormNuevoBarrio.ShowDialog();
        }
    }
}
