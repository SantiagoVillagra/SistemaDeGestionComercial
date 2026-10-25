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
    public partial class FrmCliente : Form
    { 
        RotiseriaServicio Servicio = new RotiseriaServicio();
        public int clienteSelec;
        public string nomClienteSelec;
        public int telClienteSelec;
        public string dirClienteSelec;
        public bool llamoPedido = false;

        public FrmCliente()
        {
            InitializeComponent();
        }

        public FrmCliente(bool llamoPedido)
        {
            InitializeComponent();
            Servicio = new RotiseriaServicio();
            this.llamoPedido = true;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

            //string filtro = "";

            ////if (!string.IsNullOrEmpty(txtFiltro.Text))
            ////{
            ////    filtro = txtFiltro.Text;
            ////}

            //List<Cliente> listaClientes = Servicio.TraerClientes(filtro);
            //foreach (Cliente cliente in listaClientes)
            //{
            //    dgvCliente.Rows.Add(cliente.NomCliente, cliente.ApeCliente, cliente.TelCliente, cliente.DirCliente, cliente.BarCliente, cliente.IdCliente);
            //}

            //if (llamoPedido)
            //{
            //    eliminarBtn.Enabled = false;
            //    nuevoBtn.Enabled = false;
            //    modificarBtn.Enabled = false;
            //}
            CargarClientes();

        }
   private void button1_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            string filtro = "";

            if (!string.IsNullOrEmpty(txtFiltro.Text))
            {
                if (!int.TryParse(txtFiltro.Text.Trim(), out int numeroCliente))
                {
                    MessageBox.Show("Por favor, ingrese un número de telefono válido",
                                    "Formato Incorrecto", MessageBoxButtons.OK);

                    txtFiltro.Focus();
                    txtFiltro.SelectAll(); 
                    return; 
                }
                filtro = txtFiltro.Text.Trim();
            }

            List<Cliente> listaClientes = Servicio.TraerClientes(filtro);

            if (listaClientes == null || listaClientes.Count == 0)
            {
                MessageBox.Show("No se encontró ningún cliente con el número ingresado.",
                                "Sin Resultados", MessageBoxButtons.OK);

                dgvCliente.Rows.Clear();
                txtFiltro.Focus();
                txtFiltro.SelectAll();
                return;
            }

            dgvCliente.Rows.Clear();
            foreach (Cliente cliente in listaClientes)
            {
                dgvCliente.Rows.Add(cliente.NomCliente, cliente.ApeCliente, cliente.TelCliente, cliente.DirCliente, cliente.BarCliente, cliente.IdCliente);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("¿Desea cerrar la ventana?", "SALIR",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
              this.Close();
            }
        }

        private void FrmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("¿Desea cerrar la ventana?", "SALIR",
            //   MessageBoxButtons.YesNo,
            //   MessageBoxIcon.Question,
            //   MessageBoxDefaultButton.Button2) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frmNuevoCliente = new FrmNuevoCliente();
            frmNuevoCliente.ShowDialog();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null)
            {
                MessageBox.Show("Selecciones cliente a modificar", "Modificacion", MessageBoxButtons.OK);
                return;
            }

            
            string nombreCliente = dgvCliente.CurrentRow.Cells["nomCliente"].Value.ToString();
            string apeCliente = dgvCliente.CurrentRow.Cells["apeCliente"].Value.ToString();
            string telCliente = dgvCliente.CurrentRow.Cells["telCliente"].Value.ToString();

            DialogResult aviso1 = MessageBox.Show("¿Esta seguro que desea borrar el cliente?", "BORRAR", MessageBoxButtons.YesNo);


            if (aviso1 == DialogResult.Yes)
            {
                DialogResult aviso2 = MessageBox.Show($"¿Confirma borrado del cliente  {nombreCliente}, {apeCliente}?",
                                                              "CONFIRMACIÓN",
                                                              MessageBoxButtons.YesNo);

                if (aviso2 == DialogResult.Yes)
                {
                    string consultaDelete = $"DELETE FROM clientes WHERE telefono = @telefono";

                    List<Parametro> parametros = new List<Parametro>();

                    parametros.Add(new Parametro("@telefono", telCliente));

                    int filasAfectadas = Servicio.borrarCliente(consultaDelete, parametros);



                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("El cliente se elimino correctamente.",
                                        "Éxito", MessageBoxButtons.OK);

                        //  EL REFRESCO: Volvemos a consultar para que la fila desaparezca visualmente
                        button1_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo borrar el cliente",
                                        "Problema", MessageBoxButtons.OK);
                    }
                }

            }
            CargarClientes();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null)
            {
                MessageBox.Show("Selecciones cliente a modificar", "Modificacion", MessageBoxButtons.OK);
                return;
            }

            string nombreCliente = dgvCliente.CurrentRow.Cells["nomCliente"].Value.ToString();
            string apeCliente = dgvCliente.CurrentRow.Cells["apeCliente"].Value.ToString();
            string telCliente = dgvCliente.CurrentRow.Cells["telCliente"].Value.ToString();
            string direCliente = dgvCliente.CurrentRow.Cells["direCliente"].Value.ToString();
            Barrio barrioDelCliente = (Barrio)dgvCliente.CurrentRow.Cells["barrioCliente"].Value;
            int id_barrio = barrioDelCliente.IdBarrio;
            int idCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells["idCliente"].Value);

            frmUpdated formUpdated = new frmUpdated(nombreCliente, apeCliente, telCliente, direCliente, id_barrio, idCliente);
            formUpdated.ShowDialog();

            button1_Click(null, null);
        }

        private void DgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (llamoPedido)
            {
                string nom = (string)dgvCliente.Rows[e.RowIndex].Cells[0].Value;
                string ape = (string)dgvCliente.Rows[e.RowIndex].Cells[1].Value;
                clienteSelec = (int)dgvCliente.Rows[e.RowIndex].Cells[5].Value;
                nomClienteSelec = ape + ", " + nom;
                telClienteSelec = (int)dgvCliente.Rows[e.RowIndex].Cells[2].Value;
                dirClienteSelec = (string)dgvCliente.Rows[e.RowIndex].Cells[3].Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            CargarClientes();
        }
    }
}
