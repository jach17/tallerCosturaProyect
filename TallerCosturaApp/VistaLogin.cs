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
    public partial class VistaLogin : Form
    {
        public VistaLogin()
        {
            InitializeComponent();
        }
        Controladores.ControllerLogin oCL = new Controladores.ControllerLogin();

  

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //Prueba para el git en vistas
            string[] userInput = new string[2];
            userInput[0] = txtUser.Text.ToString();
            userInput[1] = txtPassword.Text.ToString();
            if (oCL.authAdmin(userInput))
            {
                VistaPedidosPendientes vpp = new VistaPedidosPendientes();
                vpp.Show();
                this.Close();
                //MessageBox.Show("Welcome, admin");

            }
            else
            {
                MessageBox.Show("You are not singed");
            }
        }
    }
}
