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
    public partial class CardVentas : UserControl
    {

        Controladores.Venta venta;
        public CardVentas(Controladores.Venta venta)
        {
            InitializeComponent();
            this.venta = venta;
            llenarDatos();
        }

        public void llenarDatos()
        {
            txtNombre.Text = this.venta.nombreCliente;
            txtFecha.Text = this.venta.fechaVenta;
            txtDescripcion.Text = this.venta.descripcionPedido;
            txtMonto.Text = this.venta.precioTotal.ToString();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDeleteVenta_Click(object sender, EventArgs e)
        {
            Controladores.ContollerPedidosPendientes cpp = new Controladores.ContollerPedidosPendientes();
            cpp.deleteVenta(this.venta.idVenta);
            MessageBox.Show("Su eliminacion se reflejará cuando vuelva a entrar a la aplicación", "A V I S O");
        }
    }
}
