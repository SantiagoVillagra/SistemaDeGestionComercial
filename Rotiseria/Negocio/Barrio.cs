using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class Barrio
    {
        private int idBarrio;

        public int IdBarrio
        {
            get { return idBarrio; }
            set { idBarrio = value; }
        }

        private string nombreBarrio;

        public string NombreBarrio
        {
            get { return nombreBarrio; }
            set { nombreBarrio = value; }
        }
        private Ciudad ciudad;

        public Ciudad Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public override string ToString()
        {
            return NombreBarrio;
        }

    }
}
