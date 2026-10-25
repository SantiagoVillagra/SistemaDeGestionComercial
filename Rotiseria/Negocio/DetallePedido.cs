using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class DetallePedido
    {
        private int idDetalle;

        public int IdDetalle
        {
            get { return idDetalle; }
            set { idDetalle = value; }
        }
        private Producto producto;

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private Pedido pedido;

        public Pedido Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }
        private string aclaraciones;

        public string Aclaraciones
        {
            get { return aclaraciones; }
            set { aclaraciones = value; }
        }

    }
}
