using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using System.Collections;

namespace TallerCosturaApp
{
    public partial class CardGestionaInventario : UserControl
    {
        ControllerProveedor ocp;
        public CardGestionaInventario()
        {
            InitializeComponent();
            ocp = new ControllerProveedor();
            setProveedores(cbxProveedor);
            
        }

        public void setProveedores(ComboBox cbx)
        {
            for (int i=0; i< ocp.getGestionProveedores().Count;i++)
            {
                Proveedor p = (Proveedor)ocp.getGestionProveedores()[i];
                cbx.Items.Add(p.NombreProv);

            }
        }

        public ArrayList DATA_INVENTARIO()
        {
            ArrayList DATA_INV = new ArrayList(); ;
            DATA_INV.Add(txtNombreTela.Text);
            DATA_INV.Add(txtColorTela.Text);
            DATA_INV.Add(txtCantidadExistencia.Text);
            DATA_INV.Add(getIdProveedorFromName());
            DATA_INV.Add(idTelaUpdate);
            return DATA_INV;
        }
        public int getIdProveedorFromName()
        {
            
            return ocp.getIdProveedorFromNombre(cbxProveedor.Text);
        }

        public void clearData()
        {
            txtNombreTela.Text = "";
            txtColorTela.Text ="";
            txtCantidadExistencia.Text ="";

        }

        private void CbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int idTelaUpdate = 0;
        public void setRowSelected(ArrayList DATA_ROW_SELECTED)
        {
            idTelaUpdate = Convert.ToInt32(DATA_ROW_SELECTED[0]);
            txtNombreTela.Text = DATA_ROW_SELECTED[1].ToString();
            txtColorTela.Text = DATA_ROW_SELECTED[2].ToString();
            txtCantidadExistencia.Text = DATA_ROW_SELECTED[3].ToString();
            cbxProveedor.Text = DATA_ROW_SELECTED[4].ToString();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
