using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class IngXProd
    {
        private int idIngXProd;

        public int IdIngXProd
        {
            get { return idIngXProd; }
            set { idIngXProd = value; }
        }
        private Ingrediente ingrediente;

        public Ingrediente Ingrediente
        {
            get { return ingrediente; }
            set { ingrediente = value; }
        }
        private Producto producto;

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

    }
}
