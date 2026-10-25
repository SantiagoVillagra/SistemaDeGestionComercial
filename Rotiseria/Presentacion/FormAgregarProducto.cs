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
    public partial class FormAgregarProducto : Form
    {
        RotiseriaServicio rotiseriaServ;
        public string productoSelec;
        public int cantidad;
        public decimal precio;
        public int idProdSelect;

        public FormAgregarProducto()
        {
            InitializeComponent();
            rotiseriaServ = new RotiseriaServicio();
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {

            List<Producto> lProductos = rotiseriaServ.TraerProductos();

            dgvAgrProducto.Rows.Clear();
            foreach (Producto p in lProductos)
            {
                dgvAgrProducto.Rows.Add(p.IdProducto, p.NomProducto, p.Precio, p.Detalle);
            }
            dgvAgrProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgrProducto.MultiSelect = false;
        }

        private void DgvAgrProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (validar())
            {
                idProdSelect = (int)dgvAgrProducto.Rows[e.RowIndex].Cells[0].Value;
                productoSelec = (string)dgvAgrProducto.Rows[e.RowIndex].Cells[1].Value;
                cantidad = Convert.ToInt32(textBoxCantidad.Text);
                precio = Convert.ToDecimal(dgvAgrProducto.Rows[e.RowIndex].Cells[2].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                dgvAgrProducto.ClearSelection();
            }
        }

        private bool validar()
        {
            if (string.IsNullOrEmpty(textBoxCantidad.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad", "ERROR CANTIDAD",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCantidad.Focus();
                return false;
            }
            if (!int.TryParse(textBoxCantidad.Text, out int cant))
            {
                MessageBox.Show("Debe ingresar un número", "ERROR CANTIDAD",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCantidad.Focus();
                return false;
            }
            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                idProdSelect = (int)dgvAgrProducto.CurrentRow.Cells[0].Value;
                productoSelec = (string)dgvAgrProducto.CurrentRow.Cells[1].Value;
                cantidad = Convert.ToInt32(textBoxCantidad.Text);
                precio = Convert.ToDecimal(dgvAgrProducto.CurrentRow.Cells[2].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                dgvAgrProducto.ClearSelection();
            }
        }
    }
}
