using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Modelos
{
    public class ModeloPedidosPendientes
    {
        Conexion c;
        SqlConnection conexion;
        

        public ModeloPedidosPendientes()
        {
            this.c = new Conexion();
            this.conexion = c.getConexion();
            //this.pedido = new Pedido();
        }

       public ArrayList getPedidosExpress()
       {
            ArrayList pedidos = new ArrayList();
            this.conexion.Open();
            string query = "SELECT * FROM PEDIDO WHERE tipoPedido=1 ORDER BY fechaEntrega ASC;";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                //Contendrá los datos de un pedido
                ArrayList DATA_PEDIDO = new ArrayList();

                //Metemos a variables los registros obtenidos de la base de datos
                int idPedido =Convert.ToInt32( registro["idPedido"]);
                int precioTotal =Convert.ToInt32( registro["precioTotal"]);
                int tipoPedido =Convert.ToInt32( registro["tipoPedido"]);
                int idProducto =Convert.ToInt32( registro["idProducto"]);
                string descripcionPedido = registro["descripcionPedido"].ToString();
                string nombreCliente =registro["nombreCliente"].ToString();
                string fechaEntrega =registro["fechaEntrega"].ToString();
                string estatusPedido =registro["estatusPedido"].ToString();
                               
                //Llenamos los datos de un pedido
                DATA_PEDIDO.Add(idPedido);
                DATA_PEDIDO.Add(precioTotal);
                DATA_PEDIDO.Add(tipoPedido);
                DATA_PEDIDO.Add(idProducto);
                DATA_PEDIDO.Add(descripcionPedido);
                DATA_PEDIDO.Add(nombreCliente);
                DATA_PEDIDO.Add(fechaEntrega);
                DATA_PEDIDO.Add(estatusPedido);

                //Llenamos con todos los pedidos que ya llenamos
                pedidos.Add(DATA_PEDIDO);
            }
            this.conexion.Close();
            return pedidos;
       }

        public ArrayList getPedidosNormal()
        {
            ArrayList pedidos = new ArrayList();
            this.conexion.Open();
            string query = "SELECT * FROM PEDIDO WHERE tipoPedido=2 ORDER BY fechaEntrega ASC;";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                //Contendrá los datos de un pedido
                ArrayList DATA_PEDIDO = new ArrayList();

                //Metemos a variables los registros obtenidos de la base de datos
                int idPedido = Convert.ToInt32(registro["idPedido"]);
                int precioTotal = Convert.ToInt32(registro["precioTotal"]);
                int tipoPedido = Convert.ToInt32(registro["tipoPedido"]);
                int idProducto = Convert.ToInt32(registro["idProducto"]);
                string descripcionPedido = registro["descripcionPedido"].ToString();
                string nombreCliente = registro["nombreCliente"].ToString();
                string fechaEntrega = registro["fechaEntrega"].ToString();
                string estatusPedido = registro["estatusPedido"].ToString();

                //Llenamos los datos de un pedido
                DATA_PEDIDO.Add(idPedido);
                DATA_PEDIDO.Add(precioTotal);
                DATA_PEDIDO.Add(tipoPedido);
                DATA_PEDIDO.Add(idProducto);
                DATA_PEDIDO.Add(descripcionPedido);
                DATA_PEDIDO.Add(nombreCliente);
                DATA_PEDIDO.Add(fechaEntrega);
                DATA_PEDIDO.Add(estatusPedido);

                //Llenamos con todos los pedidos que ya llenamos
                pedidos.Add(DATA_PEDIDO);
            }
            this.conexion.Close();
            return pedidos;
        }

       



    }
}
