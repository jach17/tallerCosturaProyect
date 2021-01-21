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
    public class ModeloNuevoPedido
    {
        Conexion c;
        SqlConnection conexion;

        public ModeloNuevoPedido()
        {
            c = new Conexion();
            this.conexion = c.getConexion();
        }

        public void deleteVenta(int id)
        {
            this.conexion.Open();
            string query= " DELETE FROM VENTA WHERE idVenta="+id;
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            cmd.ExecuteNonQuery();

            this.conexion.Close();
        }

        public void fromPendienteToVentas(
            string descripcionPedido,
            string fecgaEntrega,
            string nombreCliente,
            int idPedido,
            int precioTotal
            )
        {
            this.conexion.Open();
            string query = "INSERT INTO VENTA VALUES (" +
                                "'" + descripcionPedido + "'," +
                                "'" + fecgaEntrega + "'," +
                                "'" + nombreCliente + "'," +
                                "'" + idPedido + "'," +
                                "'" + precioTotal + "')";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            cmd.ExecuteNonQuery();
            this.conexion.Close();
        }

        public ArrayList getVentas()
        {
            ArrayList VENTAS= new ArrayList();
            this.conexion.Open();
            string query = "SELECT * FROM VENTA;";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            SqlDataReader registros = cmd.ExecuteReader();
            while (registros.Read())
            {
                ArrayList DATA_VENTAS = new ArrayList();
                DATA_VENTAS.Add(registros["idVenta"]);
                DATA_VENTAS.Add(registros["descripcionPedido"]);
                DATA_VENTAS.Add(registros["fechaVenta"]);
                DATA_VENTAS.Add(registros["nombreCliente"]);
                DATA_VENTAS.Add(registros["idPedido"]);
                DATA_VENTAS.Add(registros["precioTotal"]);

                VENTAS.Add(DATA_VENTAS);
            }
            this.conexion.Close();
            return VENTAS;
        }

        public int getIdTelaForMaquilar(string nombreTela, string colorTela)
        {
            int id = 0;
            this.conexion.Open();
            string query = "SELECT * FROM TELA WHERE nombreTela='"+nombreTela+"' AND colorTela='"+colorTela+"';";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                id = Convert.ToInt32(registro["idTela"]);
            }
            this.conexion.Close();
            return id;
        }

        public int getLastIdProduct()
        {
            int lastId=0;
            this.conexion.Open();
            string query = "SELECT TOP(1) idProducto FROM PRODUCTO ORDER BY idProducto DESC;";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
               lastId  = Convert.ToInt32(registro["idProducto"]);
            }
                this.conexion.Close();
            return lastId;
            
        }

        public void registrarNuevoPedido(
            int idPedido,
            int precioTotal,
            int tipoPedido,
            int idProducto,
            string descripcionPedido,
            string nombreCliente,
            string fechaEntrega,
            string estatusPedido
            )
        {
            this.conexion.Open();
            string query = "INSERT INTO PEDIDO VALUES('" + descripcionPedido +
                                                  "', '" + nombreCliente + 
                                                  "', '" + fechaEntrega + 
                                                  "', " + precioTotal + 
                                                  " , " + tipoPedido + 
                                                  " , '" + estatusPedido + 
                                                  "', " + idProducto +"); ";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            cmd.ExecuteNonQuery();
            this.conexion.Close();
        }


        public void registrarNuevoProducto(
            string nombreProducto, 
            string tallaProducto, 
            string colorProducto,
            string modeloProducto,
            string diseñoProducto, 
            int precioProducto)
            {
                this.conexion.Open();
                string query = "INSERT INTO PRODUCTO VALUES('" + nombreProducto + 
                                                         "', '" + tallaProducto +
                                                         "', '" + colorProducto +
                                                         "', '" + modeloProducto +
                                                         "', '" + diseñoProducto +
                                                         "', " + precioProducto +
                                                         ");";

                SqlCommand cmd = new SqlCommand(query, this.conexion);
                cmd.ExecuteNonQuery();
                this.conexion.Close();
            }

    }
}
