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
    public partial class Consulta6 : Form
    {
        RotiseriaServicio rotiseriaServ;
        public Consulta6()
        {
            InitializeComponent();
            rotiseriaServ = new RotiseriaServicio();
        }

        private void Consulta6_Load(object sender, EventArgs e)
        {
            CargarCombo();
            comboBoxMesAño.SelectedIndex = 0;
            comboBoxTipoProducto.SelectedIndex = 1;
            textBoxCantidad.Text = "1";
            dgvConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsulta.MultiSelect = false;
        }

        private void CargarCombo()
        {
            comboBoxTipoProducto.DataSource = rotiseriaServ.TraerTiposProducto();
            comboBoxTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoProducto.SelectedIndex = -1;
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                int mesAnio = comboBoxMesAño.SelectedIndex;
                string cantidad = textBoxCantidad.Text;
                string tipoProd = comboBoxTipoProducto.SelectedValue.ToString();

                List<DetallePedido> lDetalles = rotiseriaServ.TraerConsulta(mesAnio, cantidad, tipoProd);

                dgvConsulta.Rows.Clear();
                foreach (DetallePedido dp in lDetalles)
                {
                    dgvConsulta.Rows.Add(dp.Pedido.IdPedido, dp.Pedido.HoraPedido.ToString("dd/MM/yyyy"), dp.Precio);
                }
            }
        }

        private bool validar()
        {
            if (string.IsNullOrEmpty(textBoxCantidad.Text))
            {
                MessageBox.Show("Debe seleccionar la cantidad de meses/años", "ERROR CANTIDAD",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCantidad.Focus();
                return false;
            }
            if (!int.TryParse(textBoxCantidad.Text, out int cant))
            {
                MessageBox.Show("Debe ingresar un número!", "ERROR CANTIDAD",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCantidad.Focus();
                return false;
            }
            if (comboBoxMesAño.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar filtro por mes o año", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxMesAño.Focus();
                return false;
            }
            if (comboBoxTipoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de producto", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxTipoProducto.Focus();
                return false;
            }
            return true;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la consulta?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

    }
}
