using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    
    public class ControllerNuevoPedido
    {
        Producto producto;
        Pedido pedido;
        Modelos.ModeloNuevoPedido mnp = new Modelos.ModeloNuevoPedido();
        public void setProducto(ArrayList DATA_NUEVO_PRODUCTO)
        {

            this.producto = new Producto();
            this.producto.NombreProducto = DATA_NUEVO_PRODUCTO[0].ToString();
            this.producto.TallaProducto= DATA_NUEVO_PRODUCTO[1].ToString();
            this.producto.ColorProducto = DATA_NUEVO_PRODUCTO[2].ToString();
            this.producto.ModeloProducto = DATA_NUEVO_PRODUCTO[3].ToString();
            this.producto.DiseñoProducto = DATA_NUEVO_PRODUCTO[4].ToString();
            this.producto.PrecioProducto = Convert.ToInt32(DATA_NUEVO_PRODUCTO[5]);

            registrarNuevoProducto();
        }

        public void registrarNuevoProducto()
        {
            mnp.registrarNuevoProducto(
                producto.NombreProducto ,
                producto.TallaProducto,
                producto.ColorProducto,
                producto.ModeloProducto,
                producto.DiseñoProducto,
                producto.PrecioProducto 
                );
        }


        public void setPedido(ArrayList DATA_NUEVO_PEDIDO)
        {
            this.pedido = new Pedido();
            this.pedido.metodosNombreCliente = DATA_NUEVO_PEDIDO[0].ToString();
            this.pedido.metodosFechaEntrega = DATA_NUEVO_PEDIDO[1].ToString();
            this.pedido.metodosTipoPedido = Convert.ToInt32(DATA_NUEVO_PEDIDO[2]);
            this.pedido.metodosDescripcionPedido = DATA_NUEVO_PEDIDO[3].ToString();
            this.pedido.metodosPrecioTotal = Convert.ToInt32(DATA_NUEVO_PEDIDO[4]);
            this.pedido.metodosIdProducto = Convert.ToInt32(DATA_NUEVO_PEDIDO[5].ToString());
            this.pedido.metodosEstatusPedido = DATA_NUEVO_PEDIDO[6].ToString();
            registrarNuevoPedido();

        }
        public void registrarNuevoPedido()
        {
            mnp.registrarNuevoPedido(
                pedido.metodosIdPedido,
                pedido.metodosPrecioTotal,
                pedido.metodosTipoPedido,
                pedido.metodosIdProducto,
                pedido.metodosDescripcionPedido,
                pedido.metodosNombreCliente,
                pedido.metodosFechaEntrega,
                pedido.metodosEstatusPedido
            );
        }


        public int lastId()
        {
            return mnp.getLastIdProduct();
        }
        public int getIdTelaForMaquilar(string nombreTela, string colorTela)
        {
            return mnp.getIdTelaForMaquilar(nombreTela, colorTela);
        }

    }
}
