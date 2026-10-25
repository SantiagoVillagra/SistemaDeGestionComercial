using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class Producto
    {
        private int idProducto;

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        private string nomProducto;

        public string NomProducto
        {
            get { return nomProducto; }
            set { nomProducto = value; }
        }

        private TipoProducto tipoProducto;

        public TipoProducto TipoProducto
        {
            get { return tipoProducto; }
            set { tipoProducto = value; }
        }

        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string detalle;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

    }
}
