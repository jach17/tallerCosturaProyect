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
                Controladores.Proveedor prov = new Controladores.Proveedor();
                string[] DATA_PROVEEDOR = cgp.DATA_PROVEEDOR();
                prov.NombreProv = DATA_PROVEEDOR[0];
                prov.ApProv = DATA_PROVEEDOR[1];
                prov.AmProv= DATA_PROVEEDOR[2];
                prov.RfcProv = DATA_PROVEEDOR[3];
                prov.DireccionProv = DATA_PROVEEDOR[4];
                prov.NumTelProv= DATA_PROVEEDOR[5];
                prov.EmailProv = DATA_PROVEEDOR[6];

                cgp.clearData();
            }
            if (this.contentCards.Controls.Contains(cgi))
            {
                ArrayList DATA_INV = cgi.DATA_INVENTARIO();
                tela = new Controladores.Tela();

                tela.NombreTela = DATA_INV[0].ToString();
                tela.ColorTela = DATA_INV[1].ToString();
                tela.CantidadExistente = Convert.ToInt32(DATA_INV[2]);
                tela.IdProv = Convert.ToInt32(DATA_INV[3]);
                oct.inserTela(tela);
                this.dgvGestion.DataSource = oct.getGestionInventario();
                dgvGestion.Refresh();
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
