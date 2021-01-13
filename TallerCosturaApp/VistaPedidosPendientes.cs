using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerCosturaApp
{
    public partial class VistaPedidosPendientes : Form
    {
        Controladores.ContollerPedidosPendientes oCPP = new Controladores.ContollerPedidosPendientes();
        ArrayList pedidosPendientesExpress;
        ArrayList pedidosPendientesNormal;
        public VistaPedidosPendientes()
        {
            InitializeComponent();
            this.pedidosPendientesExpress = new ArrayList();
            this.pedidosPendientesExpress = oCPP.getPedidosExpress();

            this.pedidosPendientesNormal = new ArrayList();
            this.pedidosPendientesNormal = oCPP.getPedidosNormal();


            createExpressCards();
            createNormalsCards();

        }

        public void createExpressCards()
        {
            for (int i=0;i< pedidosPendientesExpress.Count;i++)
            {
                Controladores.Pedido p; 
                p=(Controladores.Pedido)pedidosPendientesExpress[i]; 
                this.panelContentCardsExpress.Controls.Add
                    (
                    new CardPedidosPendientes
                        (
                            p.metodosNombreCliente,
                            p.metodosFechaEntrega,
                            p.metodosPrecioTotal,
                            p.metodosDescripcionPedido
                        )
                    );
            }
        }


        public void createNormalsCards()
        {
            for (int i = 0; i < pedidosPendientesNormal.Count; i++)
            {
                Controladores.Pedido p;
                p = (Controladores.Pedido)pedidosPendientesNormal[i];
                this.panelContentCardsNormal.Controls.Add
                    (
                    new CardPedidosPendientes
                        (
                            p.metodosNombreCliente,
                            p.metodosFechaEntrega,
                            p.metodosPrecioTotal,
                            p.metodosDescripcionPedido
                        )
                    );
            }
        }


        private void Label1_Click(object sender, EventArgs e)
        {
            
            VistaNuevoPedido vnp = new VistaNuevoPedido();
            vnp.Show();
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            VistaInventario_ vi = new VistaInventario_();
            vi.Show();
            this.Close();

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            VistaGestionaInventario vgi = new VistaGestionaInventario();
            vgi.Show();
            this.Close();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            VistaGestionaPedidos vgp = new VistaGestionaPedidos();
            vgp.Show();
            this.Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            
            VistaLogin vl = new VistaLogin();
            vl.Show();
            this.Close();
        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void GridViewPedidosExpress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
