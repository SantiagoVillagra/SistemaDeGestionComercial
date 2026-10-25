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
    public partial class Consulta4 : Form
    {
        RotiseriaServicio rotisertiaServicio = new RotiseriaServicio();
        public Consulta4()
        {
            InitializeComponent();
            dtpHasta.Value = DateTime.Today;
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la consulta?",
               "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void consulta6Btn_Click(object sender, EventArgs e)
        {
           
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;



            if (string.IsNullOrEmpty(minutosTxt.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar los minutos de demora", "Faltan datos", MessageBoxButtons.OK);
                return;
            }



            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'", "Rango inválido", MessageBoxButtons.OK);
                dtpDesde.Focus();
                return;
            }

            if (hasta > DateTime.Today)
            {
                MessageBox.Show("La fecha 'Hasta' no puede ser mayor a la fecha de hoy.", "Rango inválido", MessageBoxButtons.OK);
                dtpHasta.Focus();
                return;
            }

            if (string.IsNullOrEmpty(minutosTxt.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar los minutos de demora para el pedido.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                minutosTxt.Focus();
                return;
            }
            if (!int.TryParse(minutosTxt.Text.Trim(), out int minutosDemora) || minutosDemora < 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad de minutos válida (número entero mayor o igual a 0).", "Dato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                minutosTxt.Focus();
                minutosTxt.SelectAll();
                return;
            }

            hasta = hasta.AddDays(1).AddSeconds(-1);

            string consultaSql = @"SELECT p.id_pedido AS [idPedido], 
                                 c.nombre AS [nomCliente], 
                                 c.apellido AS [apeCliente], 
                                 p.hora_pedido AS [horaPedido], 
                                 p.hora_entrega AS [horaEntrega], 
                                 DATEDIFF(minute, p.hora_pedido, p.hora_entrega) AS [tiempoEntrega]
                                 FROM clientes c 
                                 JOIN pedidos p ON c.id_cliente = p.id_cliente
                                 WHERE DATEDIFF(minute, p.hora_pedido, p.hora_entrega) > @minutos
                                 AND p.hora_pedido BETWEEN @fechaDesde AND @fechaHasta";

            List<Parametro> listaParametros = new List<Parametro>();
            listaParametros.Add(new Parametro("@minutos", minutosDemora));
            listaParametros.Add(new Parametro("@fechaDesde", desde));
            listaParametros.Add(new Parametro("@fechaHasta", hasta));

            DataTable tablaPedidosDemora = rotisertiaServicio.consultaDemora(consultaSql, listaParametros);

            dgvDemoras.DataSource = tablaPedidosDemora;

            if (tablaPedidosDemora.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron pedidos con demoras en el rango seleccionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void minutosTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            minutosTxt.Clear();
            dgvDemoras.DataSource = null;
        }
    }
}
