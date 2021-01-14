using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class ControllerMaquilar
    {
        Modelos.ModeloMaquilar omm = new Modelos.ModeloMaquilar();
        public void setMaquilar(int idTela, int cantidadTela, int idProducto)
        {
            omm.setMaquilar(idTela, cantidadTela, idProducto);
        }

    }
}
