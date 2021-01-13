using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    class Producto
    {
        //Prueba git de controladores
        private int idProducto { set; get; }
        private string nombreProducto {set;get;}
        private  string tallaProducto {set;get;}
        private string colorProducto {set;get;}
        private string modeloProducto {set;get;}
        private string diseñoProducto {set;get;}
        private int precioProducto { set; get; }


        public int IdProducto
        {
            get
            {
                return this.idProducto;
            }
            set
            {
                this.idProducto = value;
            }
        }

        public string NombreProducto
        {
            get
            {
                return this.nombreProducto;
            }
            set
            {
                this.nombreProducto = value;
            }
        }
        public string TallaProducto
        {
            get
            {
                return this.tallaProducto;
            }
            set
            {
                this.tallaProducto = value;
            }
        }
        public string ColorProducto
        {
            get
            {
                return this.colorProducto;
            }
            set
            {
                this.colorProducto = value;
            }
        }
        public string ModeloProducto
        {
            get
            {
                return this.modeloProducto;
            }
            set
            {
                this.modeloProducto=value;
            }
        }
        public string DiseñoProducto
        {
            get
            {
                return this.diseñoProducto;
            }
            set
            {
                this.diseñoProducto = value;
            }
        }
        public int PrecioProducto
        {
            get
            {
                return this.precioProducto;
            }
            set
            {
                this.precioProducto = value;
            }
        }

    }
}
