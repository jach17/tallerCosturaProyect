using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelos
{
    class Conexion
    {

        SqlConnection conexion;
        public SqlConnection getConexion()
        {
            this.conexion = new SqlConnection();
            this.conexion.ConnectionString = @"Data Source = HP\JONATHANALDANA; database = taller_costura; Integrated Security = true";
            return this.conexion;
        }
    }
}
