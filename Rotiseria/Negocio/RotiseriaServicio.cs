using Rotiseria.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class RotiseriaServicio
    {
        RotiseriaDao rotiseriaDao = new RotiseriaDao();

        internal  int ModificarCliente(string consultaUpdate, List<Parametro> listaParametros)
        {
            return rotiseriaDao.ModificarUsuario(consultaUpdate, listaParametros);
        }

        internal int borrarCliente(string consultaDelete, List<Parametro> parametros)
        {
            return rotiseriaDao.EliminarCliente(consultaDelete, parametros);
        }

        internal int insertarBarrio(string consultaSql, List<Parametro>  listaParametros)
        {
            return rotiseriaDao.añadirBarrio(consultaSql, listaParametros);
        }

        internal DataTable TraerBarrios(string nombreTabla)
        {
            return rotiseriaDao.RecuperarBarrios(nombreTabla);
        }

        internal List<Cliente> TraerClientes(string filtro)
        {
            return rotiseriaDao.RecuperarClientes(filtro);
        }

        internal List<Pedido> TraerPedidos(string filtro, DateTime? filtroFecha)
        {
            return rotiseriaDao.RecuperarPedidos(filtro, filtroFecha);
        }

        internal int insertarBarrio(string insertSql)
        {
            return rotiseriaDao.InsertarBarrioDao(insertSql);
        }

        public bool ExisteBarrio(string nombreBarrio)
        {
            
            string consulta = "SELECT * FROM barrios WHERE nombre_barrio = @nombre";

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@nombre", nombreBarrio));

            DataTable tabla = rotiseriaDao.ConsultarBarrioDao(consulta, parametros);
                                     
            return tabla.Rows.Count > 0;
        }

        internal DataTable consultaDemora(string consultaSql, List<Parametro> listaParametros)
        {
            return rotiseriaDao.accederPedidosDemoras(consultaSql, listaParametros);
            
        }

        internal DataTable ConsultarRepartidor(string consultaRepartidor)
        {
            return rotiseriaDao.consultarRepartidorDao(consultaRepartidor);
        }
        // hasta aca cliente colo

        internal int BorrarPedido(int idPedidoDelete)
        {
            return rotiseriaDao.EliminarPedido(idPedidoDelete);
        }

        internal void CrearDetalle(DetallePedido detPedido)
        {
            rotiseriaDao.InsertarDetalle(detPedido);
        }

        internal int CrearEnvio(Envio oEnvio)
        {
            return rotiseriaDao.InsertarEnvio(oEnvio);
        }

        internal int CrearPedido(Pedido p)
        {
            return rotiseriaDao.InsertarPedido(p);
        }

        internal int ModificarPedido(Pedido p)
        {
            return rotiseriaDao.CambiarPedido(p);
        }


       

        internal List<DetallePedido> TraerConsulta(int mesAnio, string cantidad, string tipoProd)
        {
            return rotiseriaDao.RecuperarConsulta(mesAnio, cantidad, tipoProd);
        }

        internal List<DetallePedido> TraerDetalles(int idPedido)
        {
            return rotiseriaDao.RecuperarDetalles(idPedido);
        }

        internal List<FormaPago> TraerFormasPago()
        {
            return rotiseriaDao.RecuperarFormasPago();
        }

        internal Pedido TraerPedidoPorId(int idPedidoUpdate)
        {
            return rotiseriaDao.RecuperarPedidoPorId(idPedidoUpdate);
        }

        

        internal List<Producto> TraerProductos()
        {
            return rotiseriaDao.RecuperarProductos();
        }

        internal List<Repartidor> TraerRepartidores()
        {
            return rotiseriaDao.RecuperarRepartidores();
        }

        internal List<DetallePedido> TraerSoloDetalles(int idPedidoUpdate)
        {
            return rotiseriaDao.RecuperarSoloDetalles(idPedidoUpdate);
        }

        internal object TraerTiposProducto()
        {
            return rotiseriaDao.RecuperarTiposProducto();
        }

        internal DataTable ObtenerConsulta3Dinamica(DateTime fechaDesde, DateTime fechaHasta)
        {
            return rotiseriaDao.ObtenerConsulta3DinamicaDao(fechaDesde, fechaHasta);
        }
    }

}
