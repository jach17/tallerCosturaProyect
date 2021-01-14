using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloMaquilar
    {
        //kjxhfjhgjhg
        Conexion c ;
        SqlConnection conexion;
        public ModeloMaquilar()
        {
            c = new Conexion();
            conexion = c.getConexion();
        }
        public void setMaquilar(int idTela, int cantidadTela, int idProducto)
        {
            this.conexion.Open();
            string query = "INSERT INTO MAQUILAR VALUES (" + idTela + ", " + cantidadTela + ", " + idProducto + ");";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            cmd.ExecuteNonQuery();
            this.conexion.Close();

        }

    }
}
