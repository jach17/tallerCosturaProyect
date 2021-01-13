using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Controladores
{
    public class ContollerPedidosPendientes
    {

        Pedido pedidoPendienteExpress;
        Pedido pedidoPendienteNormal;
        Modelos.ModeloPedidosPendientes omp = new Modelos.ModeloPedidosPendientes();
        ArrayList pedidosPendientesExpress;
        ArrayList pedidosPendientesNormal;


        /*  INICIA PEDIDOS EXPRESS   */

        public void setPedidosExpress()
        {
            pedidosPendientesExpress = new ArrayList();
            for (int i=0;i<omp.getPedidosExpress().Count;i++)
            {
                //Nueva instancia de un pedido para llenarlo
                this.pedidoPendienteExpress = new Pedido();

                //Obtenemos de lista de arraylists que contienen los datos de los pedidos
                //los datos de el pedido que indique el contador
                ArrayList DATA_PEDIDO_EXPRESS = (ArrayList)omp.getPedidosExpress()[i];

                //Llenamos nuestra instancia de pedidos con el data list que obtuvimos
                this.pedidoPendienteExpress.metodosIdPedido = Convert.ToInt32(DATA_PEDIDO_EXPRESS[0]);
                this.pedidoPendienteExpress.metodosPrecioTotal = Convert.ToInt32(DATA_PEDIDO_EXPRESS[1]);
                this.pedidoPendienteExpress.metodosTipoPedido = Convert.ToInt32(DATA_PEDIDO_EXPRESS[2]);
                this.pedidoPendienteExpress.metodosIdProducto = Convert.ToInt32(DATA_PEDIDO_EXPRESS[3]);
                this.pedidoPendienteExpress.metodosDescripcionPedido= (string)DATA_PEDIDO_EXPRESS[4];
                this.pedidoPendienteExpress.metodosNombreCliente = (string)DATA_PEDIDO_EXPRESS[5];
                this.pedidoPendienteExpress.metodosFechaEntrega= (string)DATA_PEDIDO_EXPRESS[6];
                this.pedidoPendienteExpress.metodosEstatusPedido = (string)DATA_PEDIDO_EXPRESS[7];

                //Llenamos una lista con objetos de pedidos ya llenos con los registros
                pedidosPendientesExpress.Add(pedidoPendienteExpress);

            }

        }
        public ArrayList getPedidosExpress()
        {
            setPedidosExpress();
            return this.pedidosPendientesExpress;
        }

        /*  TERMINA PEDIDOS EXPRESS   */


        /*  INICIA PEDIDOS NORMAL   */

        public void setPedidosNormal()
        {
            pedidosPendientesNormal = new ArrayList();
            for (int i = 0; i < omp.getPedidosNormal().Count; i++)
            {
                //Nueva instancia de un pedido para llenarlo
                this.pedidoPendienteNormal = new Pedido();

                //Obtenemos de lista de arraylists que contienen los datos de los pedidos
                //los datos de el pedido que indique el contador
                ArrayList DATA_PEDIDO_NORMAL= (ArrayList)omp.getPedidosNormal()[i];

                //Llenamos nuestra instancia de pedidos con el data list que obtuvimos
                this.pedidoPendienteNormal.metodosIdPedido = Convert.ToInt32(DATA_PEDIDO_NORMAL[0]);
                this.pedidoPendienteNormal.metodosPrecioTotal = Convert.ToInt32(DATA_PEDIDO_NORMAL[1]);
                this.pedidoPendienteNormal.metodosTipoPedido = Convert.ToInt32(DATA_PEDIDO_NORMAL[2]);
                this.pedidoPendienteNormal.metodosIdProducto = Convert.ToInt32(DATA_PEDIDO_NORMAL[3]);
                this.pedidoPendienteNormal.metodosDescripcionPedido = (string)DATA_PEDIDO_NORMAL[4];
                this.pedidoPendienteNormal.metodosNombreCliente = (string)DATA_PEDIDO_NORMAL[5];
                this.pedidoPendienteNormal.metodosFechaEntrega = (string)DATA_PEDIDO_NORMAL[6];
                this.pedidoPendienteNormal.metodosEstatusPedido = (string)DATA_PEDIDO_NORMAL[7];

                //Llenamos una lista con objetos de pedidos ya llenos con los registros
                pedidosPendientesNormal.Add(pedidoPendienteNormal);

            }

        }
        public ArrayList getPedidosNormal()
        {
            setPedidosNormal();
            return this.pedidosPendientesNormal;
        }

        /*  TERMINA PEDIDOS EXPRESS   */



    }
}
