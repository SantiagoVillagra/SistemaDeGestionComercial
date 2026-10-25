using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class Ingrediente
    {
        private int idIngrediente;

        public int IdIngrediente
        {
            get { return idIngrediente; }
            set { idIngrediente = value; }
        }
        private string nomIngrediente;

        public string NomIngrediente
        {
            get { return nomIngrediente; }
            set { nomIngrediente = value; }
        }
        private double stock;

        public double Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        private double stockMin;

        public double StockMin
        {
            get { return stockMin; }
            set { stockMin = value; }
        }

    }
}
