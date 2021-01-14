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
    public partial class VistaNuevoPedido : Form
    {
        Controladores.ControllerNuevoPedido cnp;
        Controladores.ControllerTela ct;
        ArrayList MATERIALES_DISPONIBLES;



        /*para maquilar*/

        int telaUsada;
        int idTelaUsada;
        int idProductoLastMaquilar;
        Controladores.ControllerMaquilar ocm;



        string DescripcionCompleta = "";

        public VistaNuevoPedido()
        {
            InitializeComponent();
            cnp = new Controladores.ControllerNuevoPedido();
            ct = new Controladores.ControllerTela();
            MATERIALES_DISPONIBLES = ct.getDataTelas();
            createMaterialesDisponiblesText(this.cbxTipoMaterial);
            ocm = new Controladores.ControllerMaquilar();


            /*this.cbxTipoMaterial.Items.Add("Elemento 1");
            this.cbxTipoMaterial.Items.Add("Elemento 2");

            */
        }

        public void createMaterialesDisponiblesText(ComboBox cbx)
        {

            for (int i=0;i<this.MATERIALES_DISPONIBLES.Count;i++)
            {
                Controladores.Tela CARACTERISTICAS_TELA = (Controladores.Tela)this.MATERIALES_DISPONIBLES[i];
                string nombreTela = CARACTERISTICAS_TELA.NombreTela;
                string colorTela = CARACTERISTICAS_TELA.ColorTela;
                string caracteristicas = nombreTela + " color " + colorTela;
                cbx.Items.Add(caracteristicas);
            }

        }
        private void BtnPedidosPendientes_Click(object sender, EventArgs e)
        {
      
            VistaPedidosPendientes vpp = new VistaPedidosPendientes();
            vpp.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            VistaLogin vl = new VistaLogin();
            vl.Show();
            this.Close();
        }

        private void BtnVerInventario_Click(object sender, EventArgs e)
        {
            VistaInventario_ vi = new VistaInventario_();
            vi.Show();
            this.Close();
        }

        private void BtnGestionaInventario_Click(object sender, EventArgs e)
        {
            VistaGestionaInventario vgi = new VistaGestionaInventario();
            vgi.Show();
            this.Close();
        }

        private void BtnGestionaPedidos_Click(object sender, EventArgs e)
        {
            VistaGestionaPedidos vgp = new VistaGestionaPedidos();
            vgp.Show();
            this.Close();
        }
        Boolean addProducto = true;


        
        public string[] getDataTelaFromCadena(string cadena)
        {
            string[] datos = cadena.Split(' ');
            return datos; 
        }

        public int calculaTelaUsada(string talla)
        {
            if (talla=="S")
            {
                return 2;
            }
            else if(talla=="M")
            {
                return 4;
            }
            else if (talla=="L")
            {
                return 8;
            }
            else if (talla == "XL")
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }


        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (addProducto)
            {
                ArrayList DATA_NUEVO_PRODUCTO = new ArrayList();
                if (Controladores.FunctionsTools.ValidateTextBox(txtNombreProducto))
                {
                    DATA_NUEVO_PRODUCTO.Add(txtNombreProducto.Text);
                    DescripcionCompleta += txtNombreProducto.Text;
                }

                if (cbxTallaProducto.Text != "")
                {
                    DATA_NUEVO_PRODUCTO.Add(cbxTallaProducto.Text);
                    DescripcionCompleta += " talla " + cbxTallaProducto.Text;
                    telaUsada = calculaTelaUsada(cbxTallaProducto.Text);
                }


                if (cbxTipoMaterial.Text!="")
                {
                    string nombreTela = getDataTelaFromCadena(cbxTipoMaterial.Text)[0];
                    string colorTela = getDataTelaFromCadena(cbxTipoMaterial.Text)[2];
                    DescripcionCompleta += " de " + nombreTela + " color " + colorTela;
                    DATA_NUEVO_PRODUCTO.Add(colorTela);

                    idTelaUsada = cnp.getIdTelaForMaquilar(nombreTela, colorTela);

                }

                if (Controladores.FunctionsTools.ValidateTextBox(txtModeloProducto))
                {
                    DATA_NUEVO_PRODUCTO.Add(txtModeloProducto.Text);
                }
                if (Controladores.FunctionsTools.ValidateTextBox(txtDiseñoProducto))
                {
                    DATA_NUEVO_PRODUCTO.Add(txtDiseñoProducto.Text);
                }
                if (Controladores.FunctionsTools.ValidateTextBox(txtPrecioProducto))
                {
                    DATA_NUEVO_PRODUCTO.Add(txtPrecioProducto.Text);
                    txtPrecioPedido.Text = txtPrecioProducto.Text;
                }
                
                cnp.setProducto(DATA_NUEVO_PRODUCTO);
                MessageBox.Show("Producto agregado con éxito!", "A V I S O");
                idProductoLastMaquilar = cnp.lastId();


                ocm.setMaquilar(idTelaUsada, telaUsada, idProductoLastMaquilar);


                txtDescripcion.Text = DescripcionCompleta;
                Controladores.FunctionsTools.ClearTextBox(txtNombreProducto);
                //Controladores.FunctionsTools.ClearTextBox(txtTallaProducto);
                //Controladores.FunctionsTools.ClearTextBox(txtMaterialProducto);
                Controladores.FunctionsTools.ClearTextBox(txtModeloProducto);
                Controladores.FunctionsTools.ClearTextBox(txtDiseñoProducto);
                Controladores.FunctionsTools.ClearTextBox(txtPrecioProducto);
                txtNombreProducto.Enabled = false;
                //txtTallaProducto.Enabled = false;
                //txtMaterialProducto.Enabled = false;
                txtModeloProducto.Enabled = false;
                txtDiseñoProducto.Enabled = false;
                txtPrecioProducto.Enabled = false;
                txtNombreCliente.Focus();
               // MessageBox.Show("El ultimo id en productos es: " + cnp.lastId().ToString());
                addProducto = false;
                hacerPedido = true;
            }
            else
            {
                MessageBox.Show("Usted no puede registrar otro producto hasta que registre el pedido", "A D V E R T E N C I A");
            }
        }
        Boolean hacerPedido = false;
        private void BtnHacerPedido_Click(object sender, EventArgs e)
        {
            
            if (hacerPedido)
            {
                ArrayList DATA_NUEVO_PEDIDO = new ArrayList();
                if (Controladores.FunctionsTools.ValidateTextBox(txtNombreCliente))
                {
                    DATA_NUEVO_PEDIDO.Add(txtNombreCliente.Text);

                    var fechaFormateada = dataTimeFechaEntrega.Value;
                    DATA_NUEVO_PEDIDO.Add(fechaFormateada.ToString("yyyy-MM-dd"));

                    int tipoP = 0;
                    if (cbxTipoPedido.Text == "Normal")
                    {
                        tipoP = 2;
                    }
                    else
                    {
                        if (cbxTipoPedido.Text == "Express")
                        {
                            tipoP = 1;
                        }
                        else
                        {
                            tipoP = 0;
                        }
                    }
                    
                    DATA_NUEVO_PEDIDO.Add(tipoP);
                }
                if (Controladores.FunctionsTools.ValidateTextBox(txtDescripcion))
                {
                    DATA_NUEVO_PEDIDO.Add(txtDescripcion.Text);
                }
                if (Controladores.FunctionsTools.ValidateTextBox(txtPrecioPedido))
                {
                    DATA_NUEVO_PEDIDO.Add(txtPrecioPedido.Text); 
                }
                DATA_NUEVO_PEDIDO.Add(cnp.lastId());
                
                string status = "En construcción";
                DATA_NUEVO_PEDIDO.Add(status);
                
                cnp.setPedido(DATA_NUEVO_PEDIDO);
                Controladores.FunctionsTools.ClearTextBox(txtNombreCliente);
                Controladores.FunctionsTools.ClearTextBox(txtDescripcion);
                Controladores.FunctionsTools.ClearTextBox(txtPrecioPedido);
                addProducto = true;

                MessageBox.Show("Pedido agendado correctamente, puede revisar sus pedidos en la sección de pedidos pendientes", "A V I S O");

            }
        }
    }
}
