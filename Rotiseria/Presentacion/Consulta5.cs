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
    public partial class Consulta5 : Form
    {
        RotiseriaServicio rotisertiaServicio = new RotiseriaServicio();
        public Consulta5()
        {
            InitializeComponent();
        }

        private void Consulta5_Load(object sender, EventArgs e)
        {
            string consultaRepartidor = "SELECT id_repartidor, nombre FROM Repartidores ORDER BY nombre";
            //DataTable datatableR = accesoDatos.ConsultarBD(consultaRepartidor);
            DataTable datatableR = rotisertiaServicio.ConsultarRepartidor(consultaRepartidor);

            cboRepartidor.DataSource = datatableR;
            cboRepartidor.DisplayMember = "nombre";
            cboRepartidor.ValueMember = "id_repartidor";
            cboRepartidor.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT r.nombre + ' ' + r.apellido REPARTIDOR, p.id_pedido 'ID DEL PEDIDO', p.total TOTAL " +
                              "FROM Pedidos p JOIN Envios e ON p.id_envio = e.id_envio JOIN Repartidores r ON e.id_repartidor = r.id_repartidor ";

            if (cboPeriodo.SelectedIndex == 0)
            {
                consulta += "WHERE CAST(p.hora_entrega AS DATE) = CAST(GETDATE() AS DATE) "; //este es medio raro, convierte la fecha a fecha sin horas minutos y segundos
            }
            else if (cboPeriodo.SelectedIndex == 1)
            {
                consulta += "WHERE DATEDIFF(MONTH, p.hora_entrega, GETDATE()) = 1 ";
            }
            else if (cboPeriodo.SelectedIndex == 2)
            {
                consulta += "WHERE DATEDIFF(MONTH, p.hora_entrega, GETDATE()) <= 3 ";
            }
            else if (cboPeriodo.SelectedIndex == 3)
            {
                consulta += "WHERE DATEDIFF(MONTH, p.hora_entrega, GETDATE()) <= 6 ";
            }

            if (cboRepartidor.SelectedIndex != -1 && cboPeriodo.SelectedIndex != -1)
            {
                consulta += "AND r.id_repartidor = " + cboRepartidor.SelectedValue;
            }
            else if (cboRepartidor.SelectedIndex != -1)
            {
                consulta += "WHERE r.id_repartidor = " + cboRepartidor.SelectedValue;
            }
            consulta += "ORDER BY r.id_repartidor";
            DataTable dataTable = rotisertiaServicio.ConsultarRepartidor(consulta);
            dgvRepartidor.DataSource = dataTable;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea salir?", "CONFIRMAR",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Exclamation,
                                                    MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboRepartidor.SelectedIndex = -1;
            cboPeriodo.SelectedIndex = -1;
            dgvRepartidor.DataSource = null;

        }
    }
}
