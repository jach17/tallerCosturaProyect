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
using Controladores;

namespace TallerCosturaApp
{
    public partial class CardTodosPedidos : UserControl
    {
        Controladores.Pedido pedido;
        Controladores.ContollerPedidosPendientes ocpp;


        ArrayList ESTATUS;
        
        public CardTodosPedidos(Controladores.Pedido pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
            ESTATUS = new ArrayList();
            ESTATUS.Add("Sin iniciar");
            ESTATUS.Add("En construcción");
            ESTATUS.Add("Esperando aprobación");
            ESTATUS.Add("En reconstrucción");
            ESTATUS.Add("Entregado");
            fullStatusCbx(cbxStatus);
            fullDataPedido();
            ocpp = new Controladores.ContollerPedidosPendientes();
        }

        int idUpdate=0;


        public Pedido updatePedido()
        {
            Pedido p = new Pedido();
            p.metodosDescripcionPedido=(txtDescripcion.Text);
            var fechaFormateada = txtFecha.Value;
            string fecha = fechaFormateada.ToString("yyyy-MM-dd");
            p.metodosFechaEntrega=(fecha);
            p.metodosNombreCliente=(txtName.Text);
            p.metodosPrecioTotal=Convert.ToInt32(txtPrecio.Text);
            p.metodosEstatusPedido=(cbxStatus.Text);
            p.metodosTipoPedido=getTipoPedido(txtTipo.Text);
            p.metodosIdPedido = this.idUpdate;

            return p;
        }

        public void fullStatusCbx(ComboBox cbx)
        {
            for (int i=0; i<this.ESTATUS.Count; i++)
            {
                cbx.Items.Add(ESTATUS[i]);
            }
        }

        public string tipo(int t)
        {
            if (t == 2)
            {
                return "Normal";
            }
            else
            {
                return "Express";
            }

        }

        public void fullDataPedido()
        {
            txtDescripcion.Text = pedido.metodosDescripcionPedido;
            txtFecha.Text = pedido.metodosFechaEntrega;
            txtName.Text = pedido.metodosNombreCliente;
            txtPrecio.Text = pedido.metodosPrecioTotal.ToString();
            cbxStatus.Text = pedido.metodosEstatusPedido;
            txtTipo.Text = tipo(Convert.ToInt32(pedido.metodosTipoPedido));
            this.idUpdate = pedido.metodosIdPedido;
        }

        public int getTipoPedido(string tipo)
        {
            if (tipo=="Normal")
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
        
        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Pedido p = updatePedido();
            ocpp.updatePedido(p);
            MessageBox.Show("Pedido actualizado", "A V I S O");
        }


        int idDelete = 0;

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            idDelete = pedido.metodosIdPedido;
            ocpp.deletePedido(idDelete);
            MessageBox.Show("Se eliminará el pedido");
        }
    }
}
