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
    public partial class Consulta2 : Form
    { 
        RotiseriaServicio rotiseriaServicio = new RotiseriaServicio();
        public Consulta2()
        {
            InitializeComponent();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la consulta?",
               "SALIR",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtPedido.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un ID de pedido.",
                    "Faltan datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPedido.Focus();
                return;
            }

            int idPedido;

            if (!int.TryParse(txtPedido.Text, out idPedido))
            {
                MessageBox.Show("El ID debe ser numérico.",
                    "Dato inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPedido.Focus();
                return;
            }

            string consultaSql = @"SELECT
                                    P.nombre_producto AS Producto,
                                    DP.cantidad AS Cantidad,
                                    (DP.cantidad * DP.precio_pedido) AS Subtotal
                                   FROM Detalles_pedidos DP
                                   JOIN Productos P
                                   ON DP.id_producto = P.id_producto
                                   WHERE DP.id_pedido = @idPedido";

            List<Parametro> listaParametros = new List<Parametro>();

            listaParametros.Add(new Parametro("@idPedido", idPedido));

            DataTable tabla = rotiseriaServicio.consultaDemora(consultaSql, listaParametros);

            dgvPedidos.DataSource = tabla;

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("Ese pedido no posee productos.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
