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
    public partial class Consulta3 : Form
    {
        RotiseriaServicio rotiseriaServ = new RotiseriaServicio();
        public Consulta3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaDesde = dtpDesdeC3.Value.Date;
                DateTime fechaHasta = dtpHastaC3.Value.Date.AddDays(1).AddSeconds(-1);


                

                DataTable dt = rotiseriaServ.ObtenerConsulta3Dinamica(fechaDesde, fechaHasta);
                dgvResultados.DataSource = dt;

                dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvResultados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvResultados.RowHeadersVisible = false;
                dgvResultados.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al cargar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
                 "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
