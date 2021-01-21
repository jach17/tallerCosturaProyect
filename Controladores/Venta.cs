using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class Venta
    {
        public int idVenta { get; set; }
        public string descripcionPedido {get;set;}
        public string fechaVenta {get;set;}
        public string nombreCliente {get;set;}
        public int precioTotal {get;set;}
        public int idPedido {get;set;}
    }
}
