using System;
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
    }
}
