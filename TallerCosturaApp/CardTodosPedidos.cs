﻿using System;
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
    public partial class CardTodosPedidos : UserControl
    {
        Controladores.Pedido pedido;

        ArrayList ESTATUS;
        public CardTodosPedidos(Controladores.Pedido pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
            ESTATUS = new ArrayList();
            ESTATUS.Add("Iniciar");
            ESTATUS.Add("En construcción");
            ESTATUS.Add("Esperando aprobación");
            ESTATUS.Add("En reconstrucción");
            ESTATUS.Add("Entregado");
            fullStatusCbx(cbxStatus);
            fullDataPedido(pedido);

        }

     
        public void fullStatusCbx(ComboBox cbx)
        {
            for (int i=0; i<this.ESTATUS.Count; i++)
            {
                cbx.Items.Add(ESTATUS[i]);
            }
        }

        public void fullDataPedido(Controladores.Pedido pedido)
        {
            txtDescripcion.Text = pedido.metodosDescripcionPedido;
            txtFecha.Text = pedido.metodosFechaEntrega;
            txtName.Text = pedido.metodosNombreCliente;
            txtPrecio.Text = pedido.metodosPrecioTotal.ToString();
            cbxStatus.Text = pedido.metodosEstatusPedido;

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
    }
}
