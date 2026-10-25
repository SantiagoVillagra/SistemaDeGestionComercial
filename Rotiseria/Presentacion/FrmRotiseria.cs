using Rotiseria.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotiseria
{
    public partial class FrmRotiseria : Form
    {
        public FrmRotiseria()
        {
            InitializeComponent();
        }

        private void tStripSalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cerrar el programa?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }

        }

        private void tStripClientes_Click(object sender, EventArgs e)
        {
            FrmCliente fc = new FrmCliente();
            fc.ShowDialog();
        }

        private void tStripPedidos_Click(object sender, EventArgs e)
        {
            FrmPedido fp = new FrmPedido();
            fp.ShowDialog();
        }

        private void FrmRotiseria_Load(object sender, EventArgs e)
        {

        }

        private void tStripGrupo3_Click(object sender, EventArgs e)
        {
            FrmAlumnos frmAlumnos = new FrmAlumnos();
            frmAlumnos.ShowDialog();
        }

        private void FrmRotiseria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa?", "SALIR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

      

        private void tStripConsulta2_Click(object sender, EventArgs e)
        {
            Consulta2 consulta2 = new Consulta2();
            consulta2.ShowDialog();
        }

        private void tStripConsulta3_Click(object sender, EventArgs e)
        {
            Consulta3 consulta3 = new Consulta3();
            consulta3.ShowDialog();
        }

        private void consutla4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta4 consulta4 = new Consulta4();
            consulta4.ShowDialog();
        }

        private void consutla5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta5 consulta5 = new Consulta5();
            consulta5.ShowDialog();
        }

        private void consulta6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta6 consulta6 = new Consulta6();
            consulta6.ShowDialog();
        }

        private void consulta6Btn_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
