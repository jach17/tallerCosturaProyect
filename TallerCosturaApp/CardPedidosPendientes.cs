using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerCosturaApp
{
    public partial class CardPedidosPendientes : UserControl
    {
        public CardPedidosPendientes(String nombre, string fechaEntrega, int precio, string descripcion)
        {
            InitializeComponent();
            this.txtName.Text = nombre;
            this.txtFecha.Text = fechaEntrega;
            this.txtPrecio.Text = precio.ToString();
            this.txtDescripcion.Text = descripcion;
        }
    }
}
