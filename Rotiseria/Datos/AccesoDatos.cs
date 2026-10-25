using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Datos
{
    internal class AccesoDatos
    {

        private string CadenaConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ElBuenComer;Integrated Security=True"; //Properties.Resources.CadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public AccesoDatos()
        {
            conexion = new SqlConnection(CadenaConexion);
        }
        private void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void Desconectar()
        {
            conexion.Close();
        }
        public DataTable ConsultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            this.Conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            this.Desconectar();
            return tabla;
        }
        public DataTable ConsultarBD(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            this.Conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            this.Desconectar();
            return tabla;
        }
        public int ActualizarBD(string consultaSQL)
        {
            int filasAfectadas = 0;
            this.Conectar();
            comando.CommandText = consultaSQL;
            filasAfectadas = comando.ExecuteNonQuery();
            this.Desconectar();
            return filasAfectadas;
        }
        public int ActualizarBD(string consultaSQL, List<Parametro> lista)
        {
            int filasAfectadas = 0;
            this.Conectar();
            comando.CommandText = consultaSQL;
            foreach (Parametro p in lista)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            filasAfectadas = comando.ExecuteNonQuery();
            this.Desconectar();
            return filasAfectadas;
        }

        public DataTable ConsultarBD(string consultaSQL, List<Parametro> lista)
        {
            DataTable tabla = new DataTable();
            this.Conectar();
            comando.Parameters.Clear();
            comando.CommandText = consultaSQL;
            foreach (Parametro p in lista)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            tabla.Load(comando.ExecuteReader());
            comando.Parameters.Clear();
            this.Desconectar();
            return tabla;
        }

        public int ActualizarBDUpdate(string consultaSQL, List<Parametro> lista)
        {
            int filasAfectadas = 0;
            this.Conectar();
            comando.CommandText = consultaSQL;

            
            comando.Parameters.Clear();

            foreach (Parametro p in lista)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            filasAfectadas = comando.ExecuteNonQuery();
            this.Desconectar();
            return filasAfectadas;
        }

        public int ActualizarBDIdentity(string consultaSQL, List<Parametro> lista)
        {
            int pkInsert = 0;
            consultaSQL += " SELECT SCOPE_IDENTITY();";
            this.Conectar();
            comando.CommandText = consultaSQL;
            foreach (Parametro p in lista)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            pkInsert = Convert.ToInt32(comando.ExecuteScalar());
            this.Desconectar();
            return pkInsert;
        }
    }
}
