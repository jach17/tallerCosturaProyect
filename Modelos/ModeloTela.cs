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
    public class ModeloTela
    {
        Conexion c;
        SqlConnection conexion;
        //Prueba para el git de Modelos
        public ModeloTela()
        {
            this.c = new Conexion();
            this.conexion = c.getConexion();

        }

        public DataTable getInventario()
        {
            this.conexion.Open();
            string query = "SELECT	idTela AS ID, nombreTela AS NOMBRE, colorTela AS COLOR, cantidadExistente AS EXISTENCIA FROM TELA;";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            this.conexion.Close();
            return tabla;
        }
        public DataTable getGestionInventario()
        {
            this.conexion.Open();
            string query = "SELECT	idTela AS ID, nombreTela AS NOMBRE, colorTela AS COLOR, FROM TELA;";
            SqlCommand cmd = new SqlCommand(query, this.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            this.conexion.Close();
            return tabla;
        }

        /*Obtendra el nombre de la tela y el color*/
        public ArrayList getDataTelas()
        {
            ArrayList DATA_TELAS = new ArrayList();
            this.conexion.Open();
            string query = "SELECT nombreTela, colorTela FROM TELA;";
            SqlCommand cmd= new SqlCommand(query, this.conexion);
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                ArrayList CARACTERISTICAS_TELA = new ArrayList();
                CARACTERISTICAS_TELA.Add(registro["nombreTela"]);
                CARACTERISTICAS_TELA.Add(registro["colorTela"]);
                DATA_TELAS.Add(CARACTERISTICAS_TELA);
            }
            this.conexion.Close();
            return DATA_TELAS;
        }
    }
}
