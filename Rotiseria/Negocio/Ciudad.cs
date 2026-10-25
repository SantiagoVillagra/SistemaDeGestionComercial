using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class Ciudad
    {
        private int idCiudad;
        private string nombreCiudad;

        public int IdCiudad
        {
            get { return idCiudad; }
            set { idCiudad = value; }
        }

        public string NombreCiudad
        {
            get { return nombreCiudad; }
            set { nombreCiudad = value; }
        }


    }
}
