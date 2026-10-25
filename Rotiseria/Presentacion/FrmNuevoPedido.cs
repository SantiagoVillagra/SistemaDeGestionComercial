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
    public partial class FrmNuevoPedido : Form
    {
        RotiseriaServicio rotiseriaServ;
        decimal totalPedido = 0;
        bool modificando = false;
        Pedido pedidoModificar = null;
        List<DetallePedido> lDetalleMod = new List<DetallePedido>();
        public FrmNuevoPedido()
        {
            InitializeComponent();
            rotiseriaServ = new RotiseriaServicio();
        }
        internal FrmNuevoPedido(bool modificando, Pedido pedidoModificar, List<DetallePedido> lDetalleMod)
        {
            InitializeComponent();
            rotiseriaServ = new RotiseriaServicio();
            this.modificando = modificando;
            this.pedidoModificar = pedidoModificar;
            this.lDetalleMod = lDetalleMod;
        }

        private void FrmNuevoPedido_Load(object sender, EventArgs e)
        {
            textBoxIdCliente.Enabled = false;
            textBoxNomCliente.Enabled = false;
            textBoxTelCliente.Enabled = false;
            textBoxDirCliente.Enabled = false;
            textBoxTotal.Enabled = false;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.MultiSelect = false;
            cargarComboRepartidor();
            cargarComboFormaPago();
            if (!modificando)
            {
                labelHoraPedido.Visible = false;
                dtpPedido.Visible = false;
                dtpPedido.Enabled = false;
                labelHoraEntrega.Visible = false;
                dtpEntrega.Visible = false;
                dtpEntrega.Enabled = false;
            }
            if (modificando)
            {
                buttonCargar.Text = "Modificar";
                textBoxIdCliente.Text = pedidoModificar.Cliente.IdCliente.ToString();
                textBoxNomCliente.Text = pedidoModificar.Cliente.ToString();
                textBoxTelCliente.Text = pedidoModificar.Cliente.TelCliente.ToString();
                textBoxDirCliente.Text = pedidoModificar.Cliente.DirCliente;
                comboBoxRepartidor.SelectedIndex = pedidoModificar.Envio.Repartidor.IdRepartidor - 1;
                comboBoxFormaPago.SelectedIndex = pedidoModificar.FormaPago.IdFormaPago - 1;
                dtpPedido.Value = pedidoModificar.HoraPedido;
                dtpEntrega.Value = pedidoModificar.HoraEntrega;
                textBoxTotal.Text = pedidoModificar.Total.ToString();
                foreach (DetallePedido dp in lDetalleMod)
                {
                    decimal subtotal = dp.Cantidad * dp.Precio;
                    dgvDetalles.Rows.Add(dp.Producto.IdProducto, dp.Producto.NomProducto, dp.Cantidad,
                        dp.Precio, subtotal);
                }
                dgvDetalles.Enabled = false;
                buttonAgregar.Enabled = false;
                buttonQuitar.Enabled = false;
                textBoxTotal.Enabled = false;

                buttonCargar.Enabled = false;
            }
        }

        private void cargarComboFormaPago()
        {
            comboBoxFormaPago.DataSource = rotiseriaServ.TraerFormasPago();
            comboBoxFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormaPago.SelectedIndex = -1;
        }

        private void cargarComboRepartidor()
        {
            comboBoxRepartidor.DataSource = rotiseriaServ.TraerRepartidores();
            comboBoxRepartidor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRepartidor.SelectedIndex = -1;
        }

       

        private bool validar()
        {
            if (string.IsNullOrEmpty(textBoxIdCliente.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente!", "ERROR CLIENTE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSeleccionar.Focus();
                return false;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar productos al pedido!", "ERROR PRODUCTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonAgregar.Focus();
                return false;
            }
            if (comboBoxRepartidor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un repartidor!", "ERROR REPARTIDOR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxRepartidor.Focus();
                return false;
            }
            if (comboBoxFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una forma de pago!", "ERROR FORMA DE PAGO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxFormaPago.Focus();
                return false;
            }
            return true;
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            FrmCliente fCliente = new FrmCliente(true);

            if (fCliente.ShowDialog() == DialogResult.OK)
            {
                int idCliente = fCliente.clienteSelec;
                string apeNomCliente = fCliente.nomClienteSelec;
                int telCliente = fCliente.telClienteSelec;
                string dirCliente = fCliente.dirClienteSelec;
                textBoxIdCliente.Text = idCliente.ToString();
                textBoxNomCliente.Text = apeNomCliente;
                textBoxTelCliente.Text = telCliente.ToString();
                textBoxDirCliente.Text = dirCliente;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarProducto fNuevoProducto = new FormAgregarProducto();

            if (fNuevoProducto.ShowDialog() == DialogResult.OK)
            {
                int idProdSelecc = fNuevoProducto.idProdSelect;
                string nomProducto = fNuevoProducto.productoSelec;
                int cantidad = fNuevoProducto.cantidad;
                decimal precio = fNuevoProducto.precio;
                decimal subtotal = cantidad * precio;
                dgvDetalles.Rows.Add(idProdSelecc, nomProducto, cantidad, precio, subtotal);
                totalPedido += subtotal;
                textBoxTotal.Text = totalPedido.ToString();
            }
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count > 0)
            {
                decimal subtotal = Convert.ToDecimal(dgvDetalles.SelectedRows[0].Cells[4].Value);
                totalPedido -= subtotal;
                textBoxTotal.Text = totalPedido.ToString();
                dgvDetalles.Rows.RemoveAt(dgvDetalles.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Debe selecionar un producto para quitar",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void buttonCargar_Click_1(object sender, EventArgs e)
        {
            if (validar() && !modificando)
            {
                Repartidor r = (Repartidor)comboBoxRepartidor.SelectedItem;
                Envio oEnvio = new Envio();
                oEnvio.Repartidor = r;
                oEnvio.HoraSalida = DateTime.Now;

                int idEnvio = rotiseriaServ.CrearEnvio(oEnvio);

                Pedido p = new Pedido();
                p.Cliente = new Cliente();
                p.Cliente.IdCliente = Convert.ToInt32(textBoxIdCliente.Text);
                p.HoraPedido = DateTime.Now;
                p.HoraEntrega = DateTime.Now;
                p.Envio = new Envio();
                p.Envio.IdEnvio = idEnvio;
                p.FormaPago = (FormaPago)comboBoxFormaPago.SelectedItem;
                p.Total = totalPedido;

                int idPedido = rotiseriaServ.CrearPedido(p);

                foreach (DataGridViewRow dgvRow in dgvDetalles.Rows)
                {
                    DetallePedido detPedido = new DetallePedido();
                    detPedido.Producto = new Producto();
                    detPedido.Producto.IdProducto = Convert.ToInt32(dgvRow.Cells[0].Value);
                    detPedido.Cantidad = Convert.ToInt32(dgvRow.Cells[2].Value);
                    detPedido.Precio = Convert.ToDecimal(dgvRow.Cells[3].Value);
                    detPedido.Pedido = new Pedido();
                    detPedido.Pedido.IdPedido = idPedido;
                    detPedido.Aclaraciones = "";

                    rotiseriaServ.CrearDetalle(detPedido);
                }
                MessageBox.Show("Pedido cargado con éxito!",
                    "EXITO", MessageBoxButtons.OK);
                this.Close();
            }
            if (validar() && modificando)
            {
                Repartidor r = (Repartidor)comboBoxRepartidor.SelectedItem;
                Envio oEnvio = new Envio();
                oEnvio.IdEnvio = pedidoModificar.Envio.IdEnvio;
                oEnvio.Repartidor = r;

                Pedido p = new Pedido();
                p.IdPedido = pedidoModificar.IdPedido;
                p.Cliente = new Cliente();
                p.Cliente.IdCliente = Convert.ToInt32(textBoxIdCliente.Text);
                p.HoraPedido = (DateTime)dtpPedido.Value;
                p.HoraEntrega = (DateTime)dtpEntrega.Value;
                p.Envio = oEnvio;
                p.FormaPago = (FormaPago)comboBoxFormaPago.SelectedItem;

                if (rotiseriaServ.ModificarPedido(p) == 0)
                {
                    MessageBox.Show("error al modificar el pedido",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("PedidoModificado!",
                    "EXITO", MessageBoxButtons.OK);
                    this.Close();
                }
            }
           
        }
        private void ValidarCambiosModificacion()
        {
            
            if (!modificando || pedidoModificar == null) return;

           
            bool cambioRepartidor = comboBoxRepartidor.SelectedIndex != (pedidoModificar.Envio.Repartidor.IdRepartidor - 1);
            bool cambioFormaPago = comboBoxFormaPago.SelectedIndex != (pedidoModificar.FormaPago.IdFormaPago - 1);
            bool cambioHoraPedido = dtpPedido.Value != pedidoModificar.HoraPedido;
            bool cambioHoraEntrega = dtpEntrega.Value != pedidoModificar.HoraEntrega;

            
            buttonCargar.Enabled = cambioRepartidor || cambioFormaPago || cambioHoraPedido || cambioHoraEntrega;
        }

        private void comboBoxRepartidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCambiosModificacion();
        }

        private void comboBoxFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCambiosModificacion();
        }
        private void dtpPedido_ValueChanged(object sender, EventArgs e)
        {
            ValidarCambiosModificacion();
        }

        private void dtpEntrega_ValueChanged(object sender, EventArgs e)
        {
            ValidarCambiosModificacion();
        }
    }
}
