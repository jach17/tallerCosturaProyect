using System;
using System.Collections;
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
        Controladores.ContollerPedidosPendientes ocpp;
        ArrayList PEDIDOS_ALL;
        ArrayList VENTAS;
        public VistaGestionaPedidos()
        {
            InitializeComponent();
            ocpp = new Controladores.ContollerPedidosPendientes();
            PEDIDOS_ALL = new ArrayList();
            PEDIDOS_ALL = ocpp.getTodosPedidos();
            VENTAS = new ArrayList();
            VENTAS = ocpp.getVentas();
            /*
           this.panelContentCardsTodosPedidos.Controls.Add(new CardTodosPedidos("Express"));
           this.panelContentCardsTodosPedidos.Controls.Add(new CardTodosPedidos("Express"));
           this.panelContentCardsTodosPedidos.Controls.Add(new CardTodosPedidos("Normal"));
           this.panelContentCardsTodosPedidos.Controls.Add(new CardTodosPedidos("Normal"));
           
            
            this.panelContentCardsVentas.Controls.Add(new CardVentas("Jony"));
            this.panelContentCardsVentas.Controls.Add(new CardVentas("Jony"));
            this.panelContentCardsVentas.Controls.Add(new CardVentas("Jony"));
            */
            createAllCards();
            createVentasCards();

        }

        public void createVentasCards()
        {
            for (int i=0;i<VENTAS.Count;i++)
            {
                Controladores.Venta v;
                v = (Controladores.Venta)VENTAS[i];
                CardVentas card = new CardVentas(v);
                this.panelContentCardsVentas.Controls.Add(card);
            }
        }

        public void createAllCards()
        {
            
            for (int i = 0; i < PEDIDOS_ALL.Count; i++)
            {
                
                Controladores.Pedido p;
                p = (Controladores.Pedido)PEDIDOS_ALL[i];
                CardTodosPedidos card = new CardTodosPedidos(p);
                this.panelContentCardsTodosPedidos.Controls.Add(card);
                //MessageBox.Show("Vuelta del cliente " + p.metodosNombreCliente);
            }
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

        private void PanelContentCardsTodosPedidos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
