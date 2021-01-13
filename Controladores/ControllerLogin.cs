using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Controladores
{
    public class ControllerLogin
    {

        Modelos.ModeloLogin oML = new Modelos.ModeloLogin();
        DataTable clientes;
        string[] adminData;

       

        public void setClientes(int id)
        {
            
            this.clientes = oML.getClientes(id);
        }
        public DataTable getClientes(int id)
        {
            setClientes(id);
            return this.clientes;
        }
        
        public void setAdminData()
        {
            this.adminData = oML.getAdminData();
        }
        public string[] getAdminData()
        {
            return this.adminData;
        }
        public Boolean authAdmin(string[] userInput)
        {
            Boolean auth;
            setAdminData();
            if (adminData[0].Equals(userInput[0]) && adminData[1].Equals(userInput[1]))
            {
                auth = true;
            }
            else
            {
                auth = false;
            }
            return auth;
        }


    }
}
