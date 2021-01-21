using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TallerCosturaApp
{
    public partial class CardGestionaProveedor : UserControl
    {
        
        public CardGestionaProveedor()
        {
            InitializeComponent();
        }
        public ArrayList DATA_PROVEEDOR()
        {
            ArrayList DATA_PROOV= new ArrayList();
            DATA_PROOV.Add(txtName.Text);
            DATA_PROOV.Add(txtApPat.Text);
            DATA_PROOV.Add(txtApMat.Text);
            DATA_PROOV.Add(txtRFC.Text);
            DATA_PROOV.Add(txtDireccion.Text);
            DATA_PROOV.Add(txtNumTel.Text);
            DATA_PROOV.Add(txtEmail.Text);
            DATA_PROOV.Add(this.idUpdate);
            return DATA_PROOV;

        }

        public void clearData()
        {
            txtName.Text="";
            txtApPat.Text="";
            txtApMat.Text="";
            txtRFC.Text="";
            txtDireccion.Text="";
            txtNumTel.Text="";
            txtEmail.Text="";

        }

        int idUpdate=0;

        public void setRowSelected(ArrayList DATA_PROVEEDOR)
        {
            idUpdate = Convert.ToInt32(DATA_PROVEEDOR[0]);
            txtName.Text = DATA_PROVEEDOR[1].ToString();
            txtApPat.Text = DATA_PROVEEDOR[2].ToString();
            txtApMat.Text = DATA_PROVEEDOR[3].ToString();
            txtRFC.Text = DATA_PROVEEDOR[4].ToString();
            txtDireccion.Text = DATA_PROVEEDOR[5].ToString();
            txtNumTel.Text = DATA_PROVEEDOR[6].ToString();
            txtEmail.Text = DATA_PROVEEDOR[7].ToString();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
