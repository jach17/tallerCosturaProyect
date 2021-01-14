using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class ControllerProveedor
    {
        Modelos.ModeloProveedor omp = new Modelos.ModeloProveedor();
        public DataTable getProveedores()
        {
            return omp.getProveedores();
        }


    }
}
