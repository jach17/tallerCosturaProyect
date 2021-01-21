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

        public DataTable getGestionInventario()
        {
            return omt.getInventario();
        }

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

        public void inserTela(Tela tela)
        {
            omt.insertTela(tela.NombreTela, tela.ColorTela, tela.CantidadExistente, tela.IdProv);

        }
        public void updateTela(Tela tela)
        {
            omt.updateTela(tela.NombreTela, tela.ColorTela, tela.CantidadExistente, tela.IdProv, tela.IdTela);

        }

        public void deleteTela(int id)
        {
            omt.deleteTela(id);
        }

        public ArrayList getDataTelas()
        {
            setDataTelas();
            return this.DATA_TELAS;
        }

    }
}
