using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class ControllerTela
    {
        Modelos.ModeloTela omt = new Modelos.ModeloTela();
        ArrayList DATA_TELAS;
        Tela tela;

        public DataTable getInventario()
        {
            return omt.getInventario();
        }
        public void setDataTelas()
        {
            DATA_TELAS = new ArrayList();
             
            for (int i=0; i< omt.getDataTelas().Count; i++)
            {
                tela = new Tela();
                ArrayList CARACTERISTICAS_TELAS = (ArrayList)omt.getDataTelas()[i];
                tela.NombreTela = CARACTERISTICAS_TELAS[0].ToString();
                tela.ColorTela = CARACTERISTICAS_TELAS[1].ToString();
                DATA_TELAS.Add(tela);

            }

        }
        public ArrayList getDataTelas()
        {
            setDataTelas();
            return this.DATA_TELAS;
        }

    }
}
