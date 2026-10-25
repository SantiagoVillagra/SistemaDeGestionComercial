using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class Repartidor
    {
        private int idRepartidor;

        public int IdRepartidor
        {
            get { return idRepartidor; }
            set { idRepartidor = value; }
        }
        private string nomRepartidor;

        public string NomRepartidor
        {
            get { return nomRepartidor; }
            set { nomRepartidor = value; }
        }
        private string apeRepartidor;

        public string ApeRepartidor
        {
            get { return apeRepartidor; }
            set { apeRepartidor = value; }
        }
        private int telRepartidor;

        public int TelRepartidor
        {
            get { return telRepartidor; }
            set { telRepartidor = value; }
        }
        public override string ToString()
        {
            return ApeRepartidor + ", " + NomRepartidor;
        }
    }
}
