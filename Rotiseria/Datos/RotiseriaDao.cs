using Rotiseria.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotiseria.Datos
{
    internal class RotiseriaDao
    {
        AccesoDatos accesoDatos = new AccesoDatos();

        internal  int ModificarUsuario(string consultaUpdate, List<Parametro> listaParametros)
        {
            int filasAfectadas = accesoDatos.ActualizarBDUpdate(consultaUpdate, listaParametros);
            return filasAfectadas;
        }

        internal int añadirBarrio(string consultaSql, List<Parametro> listaParametros)
        {
            int filasAfectadas = accesoDatos.ActualizarBD(consultaSql, listaParametros);
            return filasAfectadas;
        }

        internal int EliminarCliente(string consultaDelete, List<Parametro> parametros)
        {
            int filasAfectadas = accesoDatos.ActualizarBD( consultaDelete, parametros);
            return filasAfectadas;
        }

        internal DataTable RecuperarBarrios(string nombreTabla)
        {

            string Barrios = "Barrios";
            DataTable tablaBarrios = accesoDatos.ConsultarTabla(Barrios);
            return tablaBarrios;

        }

        internal List<Cliente> RecuperarClientes(string filtro)
        {
            List<Cliente> ClientesLista = new List<Cliente> ();

            string consultaSql = "SELECT * FROM CLIENTES C join BARRIOS B ON C.id_barrio = B.id_barrio ";

            if (!string.IsNullOrEmpty(filtro))
            {
                consultaSql += $" WHERE C.telefono = '{filtro}' ";
            }
            DataTable tablaClientes = accesoDatos.ConsultarBD(consultaSql);
            foreach (DataRow filas in tablaClientes.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.IdCliente = (int)filas[0];
                cliente.NomCliente =  filas[1].ToString();
                cliente.ApeCliente = filas[2].ToString();
                cliente.TelCliente = (int)filas[3];
                cliente.DirCliente = filas[4].ToString();
                cliente.BarCliente = new Barrio();
                cliente.BarCliente.IdBarrio = (int)filas[5];

                cliente.BarCliente.NombreBarrio = filas["nombre_barrio"].ToString();

                ClientesLista.Add(cliente);
            }
            return ClientesLista;
        }

        public List<Pedido> RecuperarPedidos(string filtro, DateTime? filtroFecha)
        {
            List<string> filtros = new List<string>();
            List<Parametro> parametros = new List<Parametro>();
            List<Pedido> lPedidos = new List<Pedido>();
            string consultaSql = "SELECT p.*, c.nombre, c.apellido, r.nombre, r.apellido" +
                                    " FROM Pedidos p JOIN Clientes c" +
                                    " ON p.id_cliente = c.id_cliente JOIN" +
                                    " Envios e ON p.id_envio = e.id_envio JOIN" +
                                    " Repartidores r ON e.id_repartidor = r.id_repartidor";

            if (filtro != null)
            {
                if (int.TryParse(filtro, out int nroPedido))
                {
                    filtros.Add("p.id_pedido = @nroPedido");
                    parametros.Add(new Parametro("@nroPedido", nroPedido));
                }
                else
                {
                    filtros.Add("(c.nombre like @filtro OR c.apellido like @filtro)");
                    parametros.Add(new Parametro("@filtro", $"%{filtro}%"));
                }
            }

            if (filtroFecha != null)
            {
                DateTime fecha = filtroFecha.Value.Date;
                filtros.Add($"p.hora_pedido >= @fecha AND p.hora_pedido < @fecha2");
                parametros.Add(new Parametro("@fecha", fecha));
                parametros.Add(new Parametro("@fecha2", fecha.AddDays(1)));
            }
            

            DataTable dt;
            if (filtros.Count > 0)
            {
                consultaSql += " WHERE " + string.Join(" AND ", filtros);
                consultaSql += " order by hora_pedido desc";
                dt = accesoDatos.ConsultarBD(consultaSql, parametros);
            }
            else
            {
                consultaSql += " order by hora_pedido desc";
                dt = accesoDatos.ConsultarBD(consultaSql);
            }

            foreach (DataRow dr in dt.Rows)
            {
                Pedido p = new Pedido();
                p.IdPedido = (int)dr[0];
                Cliente c = new Cliente();
                p.Cliente = c;
                p.Cliente.IdCliente = (int)dr[1];
                p.Cliente.NomCliente = (string)dr[7];
                p.Cliente.ApeCliente = (string)dr[8];
                p.HoraPedido = (DateTime)dr[2];
                p.HoraEntrega = (DateTime)dr[3];
                Repartidor r = new Repartidor();
                Envio e = new Envio();
                e.Repartidor = r;
                p.Envio = e;
                p.Envio.IdEnvio = (int)dr[4];
                p.Envio.Repartidor.NomRepartidor = (string)dr[9];
                p.Envio.Repartidor.ApeRepartidor = (string)dr[10];
                FormaPago fp = new FormaPago();
                p.FormaPago = fp;
                p.FormaPago.IdFormaPago = (int)dr[5];
                p.Total = (decimal)dr[6];

                lPedidos.Add(p);
            }

            return lPedidos;
        }

        internal int InsertarBarrioDao(string insertSql)
        {
            
            int filasAfectadas = accesoDatos.ActualizarBD(insertSql);

            return filasAfectadas;
        }

        internal DataTable ConsultarBarrioDao(string consultaSql, List<Parametro> lista)
        {
            
            DataTable tabla = accesoDatos.ConsultarBD(consultaSql, lista);

            return tabla;
        }

        internal DataTable accederPedidosDemoras(string consultaSql, List<Parametro> listaParametros)
        {
            DataTable tabla = accesoDatos.ConsultarBD(consultaSql, listaParametros);
            return tabla;
        }

        internal DataTable consultarRepartidorDao(string consultaRepartidor)
        {
            DataTable datatableR = accesoDatos.ConsultarBD(consultaRepartidor);
            return datatableR;
        }
        // hasta aca cliente colo
       

        internal int CambiarPedido(Pedido p)
        {
            string updateEnvio = "UPDATE Envios SET id_repartidor = @id_repartidor" +
                                    " WHERE id_envio = @id_envio";
            List<Parametro> paramEnvio = new List<Parametro>();
            paramEnvio.Add(new Parametro("@id_repartidor", p.Envio.Repartidor.IdRepartidor));
            paramEnvio.Add(new Parametro("@id_envio", p.Envio.IdEnvio));

            accesoDatos.ActualizarBD(updateEnvio, paramEnvio);

            string updatePedido = "UPDATE Pedidos " +
                                    "SET id_cliente = @id_cliente," +
                                    " hora_pedido = @hora_pedido," +
                                    " hora_entrega = @hora_entrega," +
                                    " id_forma_pago = @id_forma_pago" +
                                    " WHERE id_pedido = @id_pedido";
            List<Parametro> paramPedido = new List<Parametro>();
            paramPedido.Add(new Parametro("@id_cliente", p.Cliente.IdCliente));
            paramPedido.Add(new Parametro("@hora_pedido", p.HoraPedido));
            paramPedido.Add(new Parametro("@hora_entrega", p.HoraEntrega));
            paramPedido.Add(new Parametro("@id_forma_pago", p.FormaPago.IdFormaPago));
            paramPedido.Add(new Parametro("@id_pedido", p.IdPedido));

            return accesoDatos.ActualizarBD(updatePedido, paramPedido);
        }

        internal int EliminarPedido(int idPedidoDelete)
        {
            string deleteDetalles = "DELETE Detalles_pedidos WHERE id_pedido = @id_pedido";
            string deletePedido = "DELETE Pedidos WHERE id_pedido = @id_pedido";

            List<Parametro> lDetalle = new List<Parametro>();
            lDetalle.Add(new Parametro("@id_pedido", idPedidoDelete));

            List<Parametro> lPedido = new List<Parametro>();
            lPedido.Add(new Parametro("@id_pedido", idPedidoDelete));

            if (accesoDatos.ActualizarBD(deleteDetalles, lDetalle) > 0)
            {
                return accesoDatos.ActualizarBD(deletePedido, lPedido);
            }
            return 0;
        }

        internal void InsertarDetalle(DetallePedido detPedido)
        {
            string insertSQL = "INSERT INTO Detalles_pedidos" +
                                " (id_producto, cantidad, precio_pedido, id_pedido)" +
                                " VALUES" +
                                " (@id_producto, @cantidad, @precio_pedido, @id_pedido)";

            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Add(new Parametro("@id_producto", detPedido.Producto.IdProducto));
            lParametros.Add(new Parametro("@cantidad", detPedido.Cantidad));
            lParametros.Add(new Parametro("@precio_pedido", detPedido.Precio));
            lParametros.Add(new Parametro("@id_pedido", detPedido.Pedido.IdPedido));

            accesoDatos.ActualizarBD(insertSQL, lParametros);

        }

        internal int InsertarEnvio(Envio oEnvio)
        {
            int idEnvio;
            List<Parametro> parametros = new List<Parametro>();

            string insertSQL = "INSERT INTO Envios" +
                                " (id_repartidor, hora_salida)" +
                                " VALUES (@id_repartidor, @hora_salida);";

            parametros.Add(new Parametro("@id_repartidor", oEnvio.Repartidor.IdRepartidor));
            parametros.Add(new Parametro("@hora_salida", oEnvio.HoraSalida));

            idEnvio = accesoDatos.ActualizarBDIdentity(insertSQL, parametros);

            return idEnvio;
        }

        internal int InsertarPedido(Pedido p)
        {
            int idPedido;
            List<Parametro> parametros = new List<Parametro>();

            string insertSQL = "INSERT INTO Pedidos" +
                                " (id_cliente, hora_pedido, hora_entrega, id_envio, id_forma_pago, total)" +
                                " VALUES (@id_cliente, @hora_pedido, @hora_entrega, @id_envio, @id_forma_pago, @total);";

            parametros.Add(new Parametro("@id_cliente", p.Cliente.IdCliente));
            parametros.Add(new Parametro("@hora_pedido", p.HoraPedido));
            parametros.Add(new Parametro("@hora_entrega", p.HoraEntrega));
            parametros.Add(new Parametro("@id_envio", p.Envio.IdEnvio));
            parametros.Add(new Parametro("@id_forma_pago", p.FormaPago.IdFormaPago));
            parametros.Add(new Parametro("@total", p.Total));

            idPedido = accesoDatos.ActualizarBDIdentity(insertSQL, parametros);

            return idPedido;
        }

        internal List<DetallePedido> RecuperarConsulta(int mesAnio, string cantidad, string tipoProd)
        {
            string filtroMeasAnio = "";
            if (mesAnio == 0)
            {
                filtroMeasAnio = "MONTH";
            }
            if (mesAnio == 1)
            {
                filtroMeasAnio = "YEAR";
            }
            string consultaSQL = "SELECT pe.id_pedido, CONVERT(varchar, hora_pedido, 103), dp.precio_pedido" +
                                    " FROM pedidos pe JOIN detalles_pedidos dp" +
                                    " ON pe.id_pedido = dp.id_pedido" +
                                    " JOIN productos pr" +
                                    " ON pr.id_producto = dp.id_producto" +
                                    " JOIN tipos_producto tp" +
                                    " ON tp.id_tipo_producto = pr.id_tipo_producto" +
                                    $" WHERE  tp.nombre_producto like '%{tipoProd}%' " +
                                    $" AND DATEDIFF({filtroMeasAnio}, hora_pedido, GETDATE()) = {cantidad}" +
                                    " order by hora_pedido";

            List<DetallePedido> lDetalles = new List<DetallePedido>();
            DataTable dt = accesoDatos.ConsultarBD(consultaSQL);

            foreach (DataRow dr in dt.Rows)
            {
                DetallePedido dp = new DetallePedido();
                dp.Pedido = new Pedido();
                dp.Pedido.IdPedido = (int)dr[0];

                dp.Pedido.HoraPedido = Convert.ToDateTime(dr[1]);
                dp.Precio = (decimal)dr[2];

                lDetalles.Add(dp);
            }
            return lDetalles;
        }

        internal List<DetallePedido> RecuperarDetalles(int idPedido)
        {
            List<DetallePedido> lDetalles = new List<DetallePedido>();
            string consultaPedido = "SELECT p.*, c.nombre, c.apellido," +
                                    " r.nombre, r.apellido, fp.nombre_forma_pago" +
                                    " FROM Pedidos p" +
                                    " JOIN Clientes c ON p.id_cliente = c.id_cliente" +
                                    " JOIN Envios e ON p.id_envio = e.id_envio" +
                                    " JOIN Repartidores r ON e.id_repartidor = r.id_repartidor" +
                                    " JOIN Formas_pago fp ON p.id_forma_pago = fp.id_forma_pago" +
                                    $" WHERE p.id_pedido = {idPedido}";

            DataTable dtPedido = accesoDatos.ConsultarBD(consultaPedido);
            DataRow drPedido = dtPedido.Rows[0];
            Pedido p = new Pedido();
            p.IdPedido = (int)drPedido[0];
            Cliente c = new Cliente();
            p.Cliente = c;
            p.Cliente.IdCliente = (int)drPedido[1];
            p.Cliente.NomCliente = (string)drPedido[7];
            p.Cliente.ApeCliente = (string)drPedido[8];
            p.HoraPedido = (DateTime)drPedido[2];
            p.HoraEntrega = (DateTime)drPedido[3];
            Repartidor r = new Repartidor();
            Envio e = new Envio();
            e.Repartidor = r;
            p.Envio = e;
            p.Envio.IdEnvio = (int)drPedido[4];
            p.Envio.Repartidor.NomRepartidor = (string)drPedido[9];
            p.Envio.Repartidor.ApeRepartidor = (string)drPedido[10];
            FormaPago fp = new FormaPago();
            p.FormaPago = fp;
            p.FormaPago.IdFormaPago = (int)drPedido[5];
            p.FormaPago.NomFormaPago = (string)drPedido[11];
            p.Total = (decimal)drPedido[6];


            string consultaDetalle = "SELECT dp.*, pr.nombre_producto" +
                                    " FROM Detalles_pedidos dp" +
                                    " JOIN Productos pr ON dp.id_producto = pr.id_producto" +
                                    $" WHERE dp.id_pedido = {idPedido}";

            DataTable dt = accesoDatos.ConsultarBD(consultaDetalle);
            foreach (DataRow dr in dt.Rows)
            {
                DetallePedido dp = new DetallePedido();
                dp.IdDetalle = (int)dr[0];
                dp.Producto = new Producto();
                dp.Producto.IdProducto = (int)dr[1];
                dp.Producto.NomProducto = (string)dr[6];
                dp.Cantidad = (int)dr[2];
                dp.Precio = (decimal)dr[3];
                dp.Pedido = p;

                lDetalles.Add(dp);
            }

            return lDetalles;
        }

        internal List<FormaPago> RecuperarFormasPago()
        {
            List<FormaPago> lFormasPago = new List<FormaPago>();

            DataTable dt = accesoDatos.ConsultarTabla("Formas_pago");

            foreach (DataRow dr in dt.Rows)
            {
                FormaPago fp = new FormaPago();
                fp.IdFormaPago = (int)dr[0];
                fp.NomFormaPago = (string)dr[1];

                lFormasPago.Add(fp);
            }

            return lFormasPago;
        }

        internal Pedido RecuperarPedidoPorId(int idPedidoUpdate)
        {
            string consultaSQL = "SELECT p.*, c.nombre, c.apellido, c.telefono," +
                                    " c.direccion, e.id_repartidor" +
                                    " FROM Pedidos p" +
                                    " JOIN Clientes c ON p.id_cliente = c.id_cliente" +
                                    " JOIN Envios e ON p.id_envio = e.id_envio" +
                                    $" WHERE p.id_pedido = {idPedidoUpdate}";

            DataTable dt = accesoDatos.ConsultarBD(consultaSQL);
            DataRow dr = dt.Rows[0];
            Pedido p = new Pedido();
            p.IdPedido = (int)dr[0];
            p.Cliente = new Cliente();
            p.Cliente.IdCliente = (int)dr[1];
            p.Cliente.NomCliente = (string)dr[7];
            p.Cliente.ApeCliente = (string)dr[8];
            p.Cliente.TelCliente = (int)dr[9];
            p.Cliente.DirCliente = (string)dr[10];
            p.HoraPedido = (DateTime)dr[2];
            p.HoraEntrega = (DateTime)dr[3];
            p.Envio = new Envio();
            p.Envio.IdEnvio = (int)dr[4];
            p.Envio.Repartidor = new Repartidor();
            p.Envio.Repartidor.IdRepartidor = (int)dr[11];
            p.FormaPago = new FormaPago();
            p.FormaPago.IdFormaPago = (int)dr[5];
            p.Total = (decimal)dr[6];

            return p;
        }

        internal List<Producto> RecuperarProductos()
        {
            List<Producto> lProductos = new List<Producto>();
            DataTable dt = accesoDatos.ConsultarTabla("Productos");
            foreach (DataRow dr in dt.Rows)
            {
                Producto p = new Producto();
                p.IdProducto = (int)dr[0];
                p.NomProducto = (string)dr[1];
                p.TipoProducto = new TipoProducto();
                p.TipoProducto.IdTipoProducto = (int)dr[2];
                p.Precio = (decimal)dr[3];
                p.Detalle = (string)dr[4];

                lProductos.Add(p);
            }

            return lProductos;
        }

        internal List<Repartidor> RecuperarRepartidores()
        {
            List<Repartidor> lRepartidores = new List<Repartidor>();

            DataTable dt = accesoDatos.ConsultarTabla("Repartidores");

            foreach (DataRow dr in dt.Rows)
            {
                Repartidor r = new Repartidor();
                r.IdRepartidor = (int)dr[0];
                r.NomRepartidor = (string)dr[1];
                r.ApeRepartidor = (string)dr[2];
                r.TelRepartidor = (int)dr[3];

                lRepartidores.Add(r);
            }

            return lRepartidores;
        }

        internal List<DetallePedido> RecuperarSoloDetalles(int idPedidoUpdate)
        {
            List<DetallePedido> lDetalles = new List<DetallePedido>();

            string consultaDetalle = "SELECT dp.*, pr.nombre_producto" +
                                    " FROM Detalles_pedidos dp" +
                                    " JOIN Productos pr ON dp.id_producto = pr.id_producto" +
                                    $" WHERE dp.id_pedido = {idPedidoUpdate}";

            DataTable dt = accesoDatos.ConsultarBD(consultaDetalle);
            foreach (DataRow dr in dt.Rows)
            {
                DetallePedido dp = new DetallePedido();
                dp.IdDetalle = (int)dr[0];
                dp.Producto = new Producto();
                dp.Producto.IdProducto = (int)dr[1];
                dp.Producto.NomProducto = (string)dr[6];
                dp.Cantidad = (int)dr[2];
                dp.Precio = (decimal)dr[3];

                lDetalles.Add(dp);
            }

            return lDetalles;
        }

        internal object RecuperarTiposProducto()
        {
            List<TipoProducto> lTiposProducto = new List<TipoProducto>();

            DataTable dt = accesoDatos.ConsultarTabla("Tipos_producto");

            foreach (DataRow dr in dt.Rows)
            {
                TipoProducto tp = new TipoProducto();
                tp.IdTipoProducto = (int)dr[0];
                tp.NomTipoProducto = (string)dr[1];

                lTiposProducto.Add(tp);
            }

            return lTiposProducto;
        }

        internal DataTable ObtenerConsulta3DinamicaDao(DateTime fechaDesde, DateTime fechaHasta)
        {


            string consultaSQL = @"
            SELECT 
            c.nombre AS [Nombre Cliente], 
            c.apellido AS [Apellido], 
            c.telefono AS [Teléfono],              
            c.direccion AS [Dirección],            
            COUNT(p.id_pedido) AS [Cant. Pedidos], 
            SUM(p.total) AS [Monto Total Compra]
            FROM clientes c 
            JOIN pedidos p ON c.id_cliente = p.id_cliente
            WHERE p.hora_pedido >= @desde 
            AND p.hora_pedido <= @hasta 
            AND c.nombre BETWEEN 'A' AND 'Mzzzz'
            GROUP BY c.id_cliente, c.nombre, c.apellido, c.telefono, c.direccion;";


            List<Parametro> listaParametros = new List<Parametro>();


            listaParametros.Add(new Parametro("@desde", fechaDesde));
            listaParametros.Add(new Parametro("@hasta", fechaHasta));


            DataTable tablaResultado = accesoDatos.ConsultarBD(consultaSQL, listaParametros);

            return tablaResultado;

        }
    }
}
