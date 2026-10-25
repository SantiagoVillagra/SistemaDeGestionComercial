using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class FormaPago
    {
        private int idFormaPago;

        public int IdFormaPago
        {
            get { return idFormaPago; }
            set { idFormaPago = value; }
        }

        private string nomFormaPago;

        public string NomFormaPago
        {
            get { return nomFormaPago; }
            set { nomFormaPago = value; }
        }

        public override string ToString()
        {
            return nomFormaPago;
        }

    }
}
