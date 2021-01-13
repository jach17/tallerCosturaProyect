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
    public partial class CardTodosPedidos : UserControl
    {
        public CardTodosPedidos(String tipo)
        {
            InitializeComponent();
            this.txtTipo.Text = tipo;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
