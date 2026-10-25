using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class Envio
    {
        private int idEnvio;

        public int IdEnvio
        {
            get { return idEnvio; }
            set { idEnvio = value; }
        }
        private Repartidor repartidor;

        public Repartidor Repartidor
        {
            get { return repartidor; }
            set { repartidor = value; }
        }
        private DateTime horaSalida;

        public DateTime HoraSalida
        {
            get { return horaSalida; }
            set { horaSalida = value; }
        }

    }
}
