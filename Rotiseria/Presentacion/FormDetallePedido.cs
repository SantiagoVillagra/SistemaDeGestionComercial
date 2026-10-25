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
    public partial class FormDetallePedido : Form
    {
        RotiseriaServicio rotiseriaServ;
        private int idPedido;
        public FormDetallePedido()
        {
            InitializeComponent();
            rotiseriaServ = new RotiseriaServicio();
        }
        public FormDetallePedido(int idPedido)
        {
            InitializeComponent();
            rotiseriaServ = new RotiseriaServicio();
            this.idPedido = idPedido;
        }
        private void DetallePedido_Load(object sender, EventArgs e)
        {
            List<DetallePedido> lDetalles = rotiseriaServ.TraerDetalles(idPedido);
            Pedido pedido = lDetalles[0].Pedido;
            labelNroPedido.Text += $" {pedido.IdPedido}";
            labelCliente.Text += $" {pedido.Cliente.ApeCliente}, {pedido.Cliente.NomCliente}";
            labelRepartidor.Text += $" {pedido.Envio.Repartidor.ApeRepartidor}, {pedido.Envio.Repartidor.NomRepartidor}";
            labelFormaPago.Text += $" {pedido.FormaPago.NomFormaPago}";
            labelFecha.Text += $" {pedido.HoraPedido.ToString("dd/MM/yyyy")}";
            labelHoraPedido.Text += $" {pedido.HoraPedido.ToString("HH:mm:ss")}";
            labelHoraEntrega.Text += $" {pedido.HoraEntrega.ToString("HH:mm:ss")}";
            labelTotal.Text += $" {pedido.Total}";

            dgvDetalle.Rows.Clear();
            foreach (DetallePedido dp in lDetalles)
            {
                decimal subtotal = dp.Cantidad * dp.Precio;
                dgvDetalle.Rows.Add(dp.Producto.NomProducto, dp.Cantidad, dp.Precio, subtotal);
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el detalle?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
