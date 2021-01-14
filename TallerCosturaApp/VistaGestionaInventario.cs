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
        Controladores.ControllerProveedor ocp;
        Controladores.ControllerTela oct;
        Controladores.Tela tela;


        public VistaGestionaInventario()
        {
            InitializeComponent();

            cgp = new CardGestionaProveedor();
            cgi = new CardGestionaInventario();
            ocp = new Controladores.ControllerProveedor();
            oct = new Controladores.ControllerTela();
            this.dgvGestion.DataSource = ocp.getProveedores();
            contentCards.Controls.Add(cgp);



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
            this.dgvGestion.DataSource = ocp.getProveedores();
            dgvGestion.Refresh();


        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (this.contentCards.Controls.Contains(cgp))
            {
                string[] DATA_PROVEEDOR = cgp.DATA_PROVEEDOR();
                
                cgp.clearData();
            }
            if (this.contentCards.Controls.Contains(cgi))
            {
                string[] DATA_INV = cgi.DATA_INVENTARIO();
                tela = new Controladores.Tela();

                tela.NombreTela = DATA_INV[0];
                tela.ColorTela = DATA_INV[1];
                tela.CantidadExistente = Convert.ToInt32(DATA_INV[2]);
                tela.IdProv = Convert.ToInt32(DATA_INV[3]);
                oct.inserTela(tela);
                cgi.clearData();
            }
        }

        private void BtnShowInventario_Click(object sender, EventArgs e)
        {
            contentCards.Controls.Clear();
            contentCards.Controls.Add(cgi);
            this.dgvGestion.DataSource = oct.getGestionInventario();
            dgvGestion.Refresh();

        }

        private void DgvGestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
