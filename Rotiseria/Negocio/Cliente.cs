using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class Cliente
    {
        private int idCliente;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        private string nomCliente;

        public string NomCliente
        {
            get { return nomCliente; }
            set { nomCliente = value; }
        }
        private string apeCliente;

        public string ApeCliente
        {
            get { return apeCliente; }
            set { apeCliente = value; }
        }
        private int telCliente;

        public int TelCliente
        {
            get { return telCliente; }
            set { telCliente = value; }
        }
        private string dirCliente;

        public string DirCliente
        {
            get { return dirCliente; }
            set { dirCliente = value; }
        }
        private Barrio barCliente;

        public Barrio BarCliente
        {
            get { return barCliente; }
            set { barCliente = value; }
        }


    }
}
