﻿using System;
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
    public partial class CardVentas : UserControl
    {
        public CardVentas(String name)
        {
            InitializeComponent();
            this.txtName.Text = name;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
