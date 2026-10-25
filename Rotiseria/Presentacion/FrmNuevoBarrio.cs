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
    public partial class FrmNuevoBarrio : Form
    {
        RotiseriaServicio rotiseriaServicio = new RotiseriaServicio();
        public FrmNuevoBarrio()
        {
            InitializeComponent();
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            string nuevoBarrio = nvoBarrioTxt.Text.Trim();

            string insertSql = $"insert into BARRIOS(nombre_barrio,id_ciudad) values('{nvoBarrioTxt.Text.Trim()}', 1)";
            
            

            if (string.IsNullOrEmpty(nvoBarrioTxt.Text))
            {
                MessageBox.Show("Debe agregar el nombre del barrio", "Faltan datos", MessageBoxButtons.OK);
                nvoBarrioTxt.Focus();
                return;
            }
            if (rotiseriaServicio.ExisteBarrio(nuevoBarrio))
            {
                MessageBox.Show("El barrio '" + nuevoBarrio + "' ya se encuentra registrado.", "Barrio duplicado", MessageBoxButtons.OK);
                nvoBarrioTxt.Focus();
                nvoBarrioTxt.SelectAll();
                return; 
            }
            List<Parametro> listaParametros = new List<Parametro>();
            listaParametros.Add(new Parametro("@nombreBarrio", nuevoBarrio));

        
            int filasAfectadas = rotiseriaServicio.insertarBarrio(insertSql, listaParametros);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Barrio cargado con exito", "Exito", MessageBoxButtons.OK);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("No se pudo cargar el barrio", "Fallo", MessageBoxButtons.OK);
            }
           
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el nuevo barrio?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void FrmNuevoBarrio_Load(object sender, EventArgs e)
        {

        }
    }
}
