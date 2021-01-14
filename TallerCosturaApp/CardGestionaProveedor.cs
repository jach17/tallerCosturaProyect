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
    public partial class CardGestionaProveedor : UserControl
    {
        
        public CardGestionaProveedor()
        {
            InitializeComponent();
        }
        public string[] DATA_PROVEEDOR()
        {
            string[] DATA_PROOV= new string[7];
            DATA_PROOV[0] = txtName.Text;
            DATA_PROOV[1] = txtApPat.Text;
            DATA_PROOV[2] = txtApMat.Text;
            DATA_PROOV[3] = txtRFC.Text;
            DATA_PROOV[4] = txtDireccion.Text;
            DATA_PROOV[5] = txtNumTel.Text;
            DATA_PROOV[6] = txtEmail.Text;
            return DATA_PROOV;

        }
    }
}
