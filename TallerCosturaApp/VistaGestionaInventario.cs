using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerCosturaApp
{
    public partial class VistaGestionaInventario : Form
    {
        public VistaGestionaInventario()
        {
            InitializeComponent();
        }

        private void BtnVerInventario_Click(object sender, EventArgs e)
        {
            VistaInventario_ vi = new VistaInventario_();
            vi.Show();
            this.Close();
        }

        private void BtnPedidosPendientes_Click(object sender, EventArgs e)
        {
            VistaPedidosPendientes vpp = new VistaPedidosPendientes();
            vpp.Show();
            this.Close();
        }

        private void BtnNuevoPedido_Click(object sender, EventArgs e)
        {
            VistaNuevoPedido vnp = new VistaNuevoPedido();
            vnp.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            VistaLogin vl = new VistaLogin();
            vl.Show();
            this.Close();

        }

        private void BtnGestionaPedidos_Click(object sender, EventArgs e)
        {
            VistaGestionaPedidos vgp = new VistaGestionaPedidos();
            vgp.Show();
            this.Close();
        }
    }
}
