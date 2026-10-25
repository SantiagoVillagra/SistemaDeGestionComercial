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
    public partial class FrmAlumnos : Form
    {
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            dvgAlumnos.Rows.Add("Alvarez", "Daniel", "430111");
            dvgAlumnos.Rows.Add("Maschio - Steffen", "Valentina", "430304");
            dvgAlumnos.Rows.Add("Nicolosi", "Santino", "421279");
            dvgAlumnos.Rows.Add("Ruani", "Camilo", "430125");
            dvgAlumnos.Rows.Add("Villagra", "Santiago", "430087");


        }

        private void FrmAlumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la ventana?", "SALIR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
