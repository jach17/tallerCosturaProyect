using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class Tela
    {
        private int idTela {get; set;}
        private string nombreTela {get; set;}
        private string colorTela {get; set;}
        private int cantidadExistente {get; set;}
        private int idProv { get; set; }

        public int IdTela
        {
            get
            {
                return this.idTela;
            }
            set
            {
                this.idTela = value;
            }
        }
        public string NombreTela
        {
            get
            {
                return this.nombreTela;
            }
            set
            {
                this.nombreTela = value;
            }
        }

        public string ColorTela
        {
            get
            {
                return this.colorTela;
            }
            set
            {
                this.colorTela = value;
            }
        }

        public int CantidadExistente
        {
            get
            {
                return this.cantidadExistente;
            }
            set
            {
                this.cantidadExistente = value;
            }
        }
        public int IdProv
        {
            get
            {
                return this.idProv;
            }
            set
            {
                this.idProv = value;
            }
        }

    }
}
