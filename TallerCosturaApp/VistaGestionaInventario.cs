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
        CardGestionaProveedor cgp;
        CardGestionaInventario cgi;
        public VistaGestionaInventario()
        {
            InitializeComponent();

            cgp = new CardGestionaProveedor();
            cgi = new CardGestionaInventario();

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

        private void PictureBox2_Click(object sender, EventArgs e)
        {

            contentCards.Controls.Clear();
            contentCards.Controls.Add(cgp);

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (this.contentCards.Controls.Contains(cgp))
            {
                string[] DATA_PROVEEDOR = cgp.DATA_PROVEEDOR();
                MessageBox.Show("Nombre del proveedor: " + DATA_PROVEEDOR[0]);
                cgp.clearData();
            }
            if (this.contentCards.Controls.Contains(cgi))
            {
                string[] DATA_INV = cgi.DATA_INVENTARIO();
                MessageBox.Show("Nombre de la tela: " + DATA_INV[0]);
                cgi.clearData();
            }
        }

        private void BtnShowInventario_Click(object sender, EventArgs e)
        {
            contentCards.Controls.Clear();
            contentCards.Controls.Add(cgi);
        }
    }
}
