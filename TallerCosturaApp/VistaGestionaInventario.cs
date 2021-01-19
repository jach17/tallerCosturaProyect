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
        Controladores.Proveedor proveedor;


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
                ArrayList DATA_PROVEEDOR = cgp.DATA_PROVEEDOR();
                prov.NombreProv = DATA_PROVEEDOR[0].ToString();
                prov.ApProv = DATA_PROVEEDOR[1].ToString();
                prov.AmProv= DATA_PROVEEDOR[2].ToString();
                prov.RfcProv = DATA_PROVEEDOR[3].ToString();
                prov.DireccionProv = DATA_PROVEEDOR[4].ToString();
                prov.NumTelProv= DATA_PROVEEDOR[5].ToString();
                prov.EmailProv = DATA_PROVEEDOR[6].ToString();
                ocp.registrarNuevoProveedor(prov); 
                this.dgvGestion.DataSource = ocp.getProveedores();
                dgvGestion.Refresh();
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

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (this.contentCards.Controls.Contains(cgi))
            {
                ArrayList DATA_INV = cgi.DATA_INVENTARIO();
                tela = new Controladores.Tela();

                tela.NombreTela = DATA_INV[0].ToString();
                tela.ColorTela = DATA_INV[1].ToString();
                tela.CantidadExistente = Convert.ToInt32(DATA_INV[2]);
                tela.IdProv = Convert.ToInt32(DATA_INV[3]);
                tela.IdTela = Convert.ToInt32(DATA_INV[4]);
                oct.updateTela(tela);
                this.dgvGestion.DataSource = oct.getGestionInventario();
                dgvGestion.Refresh();
                cgi.clearData();
            }
            if (this.contentCards.Controls.Contains(cgp))
            {
                ArrayList DATA_PROVEEDOR = cgp.DATA_PROVEEDOR(); 
                proveedor= new Controladores.Proveedor();
                proveedor.NombreProv = DATA_PROVEEDOR[0].ToString();
                proveedor.ApProv = DATA_PROVEEDOR[1].ToString();
                proveedor.AmProv = DATA_PROVEEDOR[2].ToString();
                proveedor.RfcProv = DATA_PROVEEDOR[3].ToString();
                proveedor.DireccionProv = DATA_PROVEEDOR[4].ToString();
                proveedor.NumTelProv = DATA_PROVEEDOR[5].ToString();
                proveedor.EmailProv = DATA_PROVEEDOR[6].ToString();
                proveedor.IdProv = Convert.ToInt32(DATA_PROVEEDOR[7]);
                ocp.updateProveedor(proveedor);
                this.dgvGestion.DataSource = ocp.getProveedores();
                dgvGestion.Refresh();
                cgp.clearData();
            }
        }

        private void DgvGestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = dgvGestion.CurrentCell.RowIndex;
            if (contentCards.Controls.Contains(cgi))
            {
                ArrayList DATA_ROW_FROM_GRID = new ArrayList();
                for (int i = 0; i < dgvGestion.Columns.Count; i++)
                {
                    DATA_ROW_FROM_GRID.Add(dgvGestion.Rows[rowSelected].Cells[i].Value);
                }

                cgi.setRowSelected(DATA_ROW_FROM_GRID);
            }
            if (contentCards.Controls.Contains(cgp))
            {
                ArrayList DATA_ROW_FROM_GRID = new ArrayList();
                for (int i = 0; i < dgvGestion.Columns.Count; i++)
                {
                    DATA_ROW_FROM_GRID.Add(dgvGestion.Rows[rowSelected].Cells[i].Value);
                }

                cgp.setRowSelected(DATA_ROW_FROM_GRID);
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            int rowSelected = dgvGestion.CurrentCell.RowIndex;
            if (contentCards.Controls.Contains(cgi))
            {
                int ID_DELETE=0;
                ID_DELETE= Convert.ToInt32(dgvGestion.Rows[rowSelected].Cells[0].Value);

                oct.deleteTela(ID_DELETE);
                this.dgvGestion.DataSource = oct.getGestionInventario();
                dgvGestion.Refresh();
                cgi.clearData();

            }
            if (contentCards.Controls.Contains(cgp))
            {
                int ID_DELETE = 0;
                ID_DELETE = Convert.ToInt32(dgvGestion.Rows[rowSelected].Cells[0].Value);

                ocp.deleteProveedor(ID_DELETE);
                this.dgvGestion.DataSource = ocp.getProveedores();
                dgvGestion.Refresh();
                cgp.clearData();

            }
        }
    }
}
