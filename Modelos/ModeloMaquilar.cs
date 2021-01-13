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
            SqlConnection conexion = c.getConexion();
        }
        public void getMaquilar()
        {
            this.conexion.Open();
            
        }

    }
}
