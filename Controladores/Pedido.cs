using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class Pedido
    {
        private int idPedido { get; set; }
        private int precioTotal { get; set; }
        private int tipoPedido { get; set; }
        private int idProducto { get; set; }
        private string descripcionPedido { get; set; }
        private string nombreCliente { get; set; }
        private string fechaEntrega { get; set; }
        private string estatusPedido { get; set; }

        public int metodosIdPedido
        {
            get
            {
                return idPedido;
            }
            set
            {
                idPedido = value;
            }
        }
        public int metodosPrecioTotal
        {
            get
            {
                return precioTotal;
            }
            set
            {
                precioTotal = value;
            }
        }
        public int metodosTipoPedido
        {
            get
            {
                return tipoPedido;
            }
            set
            {
                tipoPedido = value;
            }
        }
        public int metodosIdProducto
        {
            get
            {
                return idProducto;
            }
            set
            {
                idProducto = value;
            }
        }
        public string metodosDescripcionPedido
        {
            get
            {
                return descripcionPedido;
            }
            set
            {
                descripcionPedido= value;
            }
        }
        public string metodosNombreCliente
        {
            get
            {
                return nombreCliente;
            }
            set
            {
                nombreCliente= value;
            }
        }
        public string metodosFechaEntrega
        {
            get
            {
                return fechaEntrega;
            }
            set
            {
                fechaEntrega= value;
            }
        }
        public string metodosEstatusPedido
        {
            get
            {
                return estatusPedido;
            }
            set
            {
                estatusPedido = value;
            }
        }





    }
}
