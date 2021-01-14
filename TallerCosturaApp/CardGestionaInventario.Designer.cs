namespace TallerCosturaApp
{
    partial class CardGestionaInventario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadExistencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColorTela = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreTela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.cbxProveedor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCantidadExistencia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtColorTela);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombreTela);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 330);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Proveedor:";
            // 
            // txtCantidadExistencia
            // 
            this.txtCantidadExistencia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtCantidadExistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadExistencia.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadExistencia.Location = new System.Drawing.Point(31, 179);
            this.txtCantidadExistencia.Name = "txtCantidadExistencia";
            this.txtCantidadExistencia.Size = new System.Drawing.Size(205, 19);
            this.txtCantidadExistencia.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "RFC:";
            // 
            // txtColorTela
            // 
            this.txtColorTela.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtColorTela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColorTela.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorTela.Location = new System.Drawing.Point(31, 112);
            this.txtColorTela.Name = "txtColorTela";
            this.txtColorTela.Size = new System.Drawing.Size(205, 19);
            this.txtColorTela.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Color de la tela:";
            // 
            // txtNombreTela
            // 
            this.txtNombreTela.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtNombreTela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreTela.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTela.Location = new System.Drawing.Point(31, 50);
            this.txtNombreTela.Name = "txtNombreTela";
            this.txtNombreTela.Size = new System.Drawing.Size(205, 19);
            this.txtNombreTela.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de la tela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad de tela en existencia:";
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.BackColor = System.Drawing.Color.White;
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cbxProveedor.Location = new System.Drawing.Point(31, 240);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(205, 27);
            this.cbxProveedor.TabIndex = 23;
            this.cbxProveedor.SelectedIndexChanged += new System.EventHandler(this.CbxProveedor_SelectedIndexChanged);
            // 
            // CardGestionaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CardGestionaInventario";
            this.Size = new System.Drawing.Size(290, 330);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadExistencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColorTela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreTela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProveedor;
    }
}
