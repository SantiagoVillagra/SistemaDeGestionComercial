using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class TipoProducto
    {
        private int idTipoProducto;

        public int IdTipoProducto
        {
            get { return idTipoProducto; }
            set { idTipoProducto = value; }
        }
        private string nomTipoProducto;

        public string NomTipoProducto
        {
            get { return nomTipoProducto; }
            set { nomTipoProducto = value; }
        }
        public override string ToString()
        {
            return NomTipoProducto;
        }
    }
}
