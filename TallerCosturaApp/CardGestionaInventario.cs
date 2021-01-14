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
    public partial class CardGestionaInventario : UserControl
    {

        public CardGestionaInventario()
        {
            InitializeComponent();
        }

        public string[] DATA_INVENTARIO()
        {
            string[] DATA_INV = new string[4];
            DATA_INV[0] = txtNombreTela.Text;
            DATA_INV[1] = txtColorTela.Text;
            DATA_INV[2] = txtCantidadExistencia.Text;
            DATA_INV[3] = cbxProveedor.Text;
            return DATA_INV;
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
    }
}
