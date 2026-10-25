using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Negocio
{
    internal class Pedido
    {
        private int idPedido;

        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }
        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        private DateTime horaPedido;

        public DateTime HoraPedido
        {
            get { return horaPedido; }
            set { horaPedido = value; }
        }
        private DateTime horaEntrega;

        public DateTime HoraEntrega
        {
            get { return horaEntrega; }
            set { horaEntrega = value; }
        }
        private Envio envio;

        public Envio Envio
        {
            get { return envio; }
            set { envio = value; }
        }
        private FormaPago formaPago;

        public FormaPago FormaPago
        {
            get { return formaPago; }
            set { formaPago = value; }
        }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

    }
}
