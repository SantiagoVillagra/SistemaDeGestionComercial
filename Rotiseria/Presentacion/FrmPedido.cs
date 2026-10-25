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
    public partial class FrmPedido : Form
    {
        RotiseriaServicio rotiseriaServ = new RotiseriaServicio();

        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            checkBoxFecha.Checked = false;
            dtpFiltro.Enabled = false;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.MultiSelect = false;
            CargarPedidos();
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFiltro.Enabled = checkBoxFecha.Checked;
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            CargarPedidos();
        }

        private void CargarPedidos()
        {
            string filtro = null;
            DateTime? filtroFecha = null;

            if (!string.IsNullOrEmpty(textBoxFiltro.Text.Trim()))
            {
                filtro = textBoxFiltro.Text.Trim();
            }
            if (checkBoxFecha.Checked)
            {
                filtroFecha = dtpFiltro.Value;
            }

            List<Pedido> lPedidos = rotiseriaServ.TraerPedidos(filtro, filtroFecha);
            dgvPedidos.Rows.Clear();
            foreach (Pedido p in lPedidos)
            {
                string nomApeCliente = p.Cliente.ApeCliente + ", " + p.Cliente.NomCliente;
                string nomApeRepartidor = p.Envio.Repartidor.ApeRepartidor + ", " + p.Envio.Repartidor.NomRepartidor;
                string fecha = p.HoraPedido.ToString("dd/MM/yyyy");
                dgvPedidos.Rows.Add(p.IdPedido, nomApeCliente, fecha, p.Total, nomApeRepartidor);
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoPedido frmNP = new FrmNuevoPedido();
            frmNP.ShowDialog();
            CargarPedidos();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un pedido para modificar",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int idPedidoUpdate = (int)dgvPedidos.SelectedRows[0].Cells[0].Value;
            Pedido p = rotiseriaServ.TraerPedidoPorId(idPedidoUpdate);
            List<DetallePedido> lDetalles = rotiseriaServ.TraerSoloDetalles(idPedidoUpdate);
            FrmNuevoPedido frmNP = new FrmNuevoPedido(true, p, lDetalles);
            frmNP.ShowDialog();

            CargarPedidos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un pedido para eliminar",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int idPedidoDelete = (int)dgvPedidos.SelectedRows[0].Cells[0].Value;

            if (rotiseriaServ.BorrarPedido(idPedidoDelete) == 0)
            {
                MessageBox.Show("Error al eliminar pedido!",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Pedido Eliminado exitosamente.",
                "ELIMINADO", MessageBoxButtons.OK);
            }
            CargarPedidos();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de pedidos?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }

        }

        private void DgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPedido = (int)dgvPedidos.Rows[e.RowIndex].Cells[0].Value;

            FormDetallePedido fdp = new FormDetallePedido(idPedido);
            fdp.ShowDialog();
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
