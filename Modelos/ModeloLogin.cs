using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    

    public class ModeloLogin
    {

        private string nameAdmin = "admin";
        private string passAdmin = "admin";

        Conexion c;
        SqlConnection conexion;

        public ModeloLogin()
        {
            c = new Conexion();
            SqlConnection conexion = c.getConexion();
        }

        public string[] getAdminData()
        {
            string[] adminData = { this.nameAdmin, this.passAdmin};
            return adminData;
        }

        public DataTable getClientes(int id)
        {
            this.conexion.Open();
            string query = "SELECT * FROM Clientes WHERE dni=" + id;
            SqlDataAdapter adaptador = new SqlDataAdapter(query, this.conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            this.conexion.Close();
            return dt;
        }

       
    }
}
