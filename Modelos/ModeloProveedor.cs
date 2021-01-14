using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloProveedor
    {
        Conexion c;
        SqlConnection conexion;
        public ModeloProveedor()
        {
            this.c = new Conexion();
            this.conexion = c.getConexion();

        }

        public int getIdProveedorFromNombre(string nombreProveedor)
        {
            int id = 0;
            this.conexion.Open();
            string query = "SELECT idProv FROM PROVEEDOR WHERE nombreProv='"+nombreProveedor+"';";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                id = Convert.ToInt32(registro["idProv"]);
            }
            this.conexion.Close();
            return id;

        }

        public DataTable getProveedores()
        {
            this.conexion.Open();
            string query = "SELECT	idProv AS Id, nombreProv AS Nombre, apProv AS Apellido, rfcProv AS RFC, direccionProv AS Direccion, numTelProv AS Celular, emailProv AS Email FROM PROVEEDOR;";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            this.conexion.Close();
            return tabla;
        }
        public ArrayList getNombreProveedores()
        {
            ArrayList LISTA_PROVEEDORES = new ArrayList() ;
            this.conexion.Open();
            string query = "SELECT nombreProv FROM PROVEEDOR;";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                LISTA_PROVEEDORES.Add(registro["nombreProv"]);
            }
            this.conexion.Close();
            return LISTA_PROVEEDORES;
        }
    }
}
