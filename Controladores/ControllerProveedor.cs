using System;
using System.Collections;
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
        Proveedor proveedor;

        public ArrayList getGestionProveedores()
        {
            ArrayList LISTA_PROVEEDORES = new ArrayList();

            for (int i=0;i< omp.getNombreProveedores().Count;i++)
            {
                proveedor = new Proveedor();
                proveedor.NombreProv = omp.getNombreProveedores()[i].ToString();
                LISTA_PROVEEDORES.Add(proveedor);

            }
            return LISTA_PROVEEDORES;
        }

        public int getIdProveedorFromNombre(string name)
        {
            return omp.getIdProveedorFromNombre(name);

        }

        public void registrarNuevoProveedor(Proveedor prov)
        {
            omp.registrarNuevoProveedor(
                prov.NombreProv, prov.ApProv, prov.AmProv, prov.RfcProv, prov.DireccionProv, prov.NumTelProv, prov.EmailProv);

                

        }

        public DataTable getProveedores()
        {
            return omp.getProveedores();
        }


    }
}
