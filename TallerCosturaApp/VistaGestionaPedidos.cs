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
    public partial class VistaGestionaPedidos : Form
    {
        public VistaGestionaPedidos()
        {
            InitializeComponent();

             /*
            this.panelContentCardsTodosPedidos.Controls.Add(new CardTodosPedidos("Express"));
            this.panelContentCardsTodosPedidos.Controls.Add(new CardTodosPedidos("Express"));
            this.panelContentCardsTodosPedidos.Controls.Add(new CardTodosPedidos("Normal"));
            this.panelContentCardsTodosPedidos.Controls.Add(new CardTodosPedidos("Normal"));
            */
            this.panelContentCardsVentas.Controls.Add(new CardVentas("Jony"));
            this.panelContentCardsVentas.Controls.Add(new CardVentas("Jony"));
            this.panelContentCardsVentas.Controls.Add(new CardVentas("Jony"));


        }

        private void BtnNuevoPedido_Click(object sender, EventArgs e)
        {
            VistaNuevoPedido vnp = new VistaNuevoPedido();
            vnp.Show();
            this.Close();
        }

        private void BtnPedidosPendientes_Click(object sender, EventArgs e)
        {
            VistaPedidosPendientes vpp = new VistaPedidosPendientes();
            vpp.Show();
            this.Close();
        }

        private void BtnVerInventario_Click(object sender, EventArgs e)
        {
            VistaInventario_ vi = new VistaInventario_();
            vi.Show();
            this.Close();
        }

        private void BtnGestionaInventario_Click(object sender, EventArgs e)
        {
            VistaGestionaInventario vgi = new VistaGestionaInventario();
            vgi.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            VistaLogin vl = new VistaLogin();
            vl.Show();
            this.Close();
        }

        private void PanelContentCardsVentas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
