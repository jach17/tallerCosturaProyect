namespace TallerCosturaApp
{
    partial class VistaInventario_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolBarApp = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Label();
            this.btnGestionaPedidos = new System.Windows.Forms.Label();
            this.btnGestionaInventario = new System.Windows.Forms.Label();
            this.btnVerInventario = new System.Windows.Forms.Label();
            this.btnPedidosPendientes = new System.Windows.Forms.Label();
            this.btnNuevoPedido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolBarApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.125F));
            this.tableLayoutPanel1.Controls.Add(this.toolBarApp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 490);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolBarApp
            // 
            this.toolBarApp.ColumnCount = 1;
            this.toolBarApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolBarApp.Controls.Add(this.btnSalir, 0, 5);
            this.toolBarApp.Controls.Add(this.btnGestionaPedidos, 0, 4);
            this.toolBarApp.Controls.Add(this.btnGestionaInventario, 0, 3);
            this.toolBarApp.Controls.Add(this.btnVerInventario, 0, 2);
            this.toolBarApp.Controls.Add(this.btnPedidosPendientes, 0, 1);
            this.toolBarApp.Controls.Add(this.btnNuevoPedido, 0, 0);
            this.toolBarApp.Location = new System.Drawing.Point(3, 139);
            this.toolBarApp.Name = "toolBarApp";
            this.toolBarApp.RowCount = 6;
            this.toolBarApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.toolBarApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.toolBarApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.toolBarApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.toolBarApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.toolBarApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.toolBarApp.Size = new System.Drawing.Size(161, 348);
            this.toolBarApp.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(3, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(155, 63);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnGestionaPedidos
            // 
            this.btnGestionaPedidos.AutoSize = true;
            this.btnGestionaPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionaPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGestionaPedidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionaPedidos.Location = new System.Drawing.Point(3, 228);
            this.btnGestionaPedidos.Name = "btnGestionaPedidos";
            this.btnGestionaPedidos.Size = new System.Drawing.Size(155, 57);
            this.btnGestionaPedidos.TabIndex = 4;
            this.btnGestionaPedidos.Text = "GESTIONA PEDIDOS";
            this.btnGestionaPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGestionaPedidos.Click += new System.EventHandler(this.BtnGestionaPedidos_Click);
            // 
            // btnGestionaInventario
            // 
            this.btnGestionaInventario.AutoSize = true;
            this.btnGestionaInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionaInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGestionaInventario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionaInventario.Location = new System.Drawing.Point(3, 171);
            this.btnGestionaInventario.Name = "btnGestionaInventario";
            this.btnGestionaInventario.Size = new System.Drawing.Size(155, 57);
            this.btnGestionaInventario.TabIndex = 3;
            this.btnGestionaInventario.Text = "GESTIONA INVENTARIO";
            this.btnGestionaInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGestionaInventario.Click += new System.EventHandler(this.BtnGestionaInventario_Click);
            // 
            // btnVerInventario
            // 
            this.btnVerInventario.AutoSize = true;
            this.btnVerInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnVerInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerInventario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInventario.Location = new System.Drawing.Point(3, 114);
            this.btnVerInventario.Name = "btnVerInventario";
            this.btnVerInventario.Size = new System.Drawing.Size(155, 57);
            this.btnVerInventario.TabIndex = 2;
            this.btnVerInventario.Text = "VER INVENTARIO";
            this.btnVerInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPedidosPendientes
            // 
            this.btnPedidosPendientes.AutoSize = true;
            this.btnPedidosPendientes.BackColor = System.Drawing.Color.White;
            this.btnPedidosPendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidosPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPedidosPendientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidosPendientes.Location = new System.Drawing.Point(3, 57);
            this.btnPedidosPendientes.Name = "btnPedidosPendientes";
            this.btnPedidosPendientes.Size = new System.Drawing.Size(155, 57);
            this.btnPedidosPendientes.TabIndex = 1;
            this.btnPedidosPendientes.Text = "PEDIDOS PENDIENTES";
            this.btnPedidosPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPedidosPendientes.Click += new System.EventHandler(this.BtnPedidosPendientes_Click);
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.AutoSize = true;
            this.btnNuevoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevoPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.Location = new System.Drawing.Point(3, 0);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(155, 57);
            this.btnNuevoPedido.TabIndex = 0;
            this.btnNuevoPedido.Text = "NUEVO PEDIDO";
            this.btnNuevoPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoPedido.Click += new System.EventHandler(this.BtnNuevoPedido_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TallerCosturaApp.Properties.Resources.Logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 136);
            this.label1.TabIndex = 4;
            this.label1.Text = "VER INVENTARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(170, 139);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(627, 348);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvInventario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 342);
            this.panel1.TabIndex = 0;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.ColumnHeadersHeight = 35;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.Location = new System.Drawing.Point(4, 3);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventario.Size = new System.Drawing.Size(611, 333);
            this.dgvInventario.TabIndex = 0;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // VistaInventario_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaInventario_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaInventario_";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolBarApp.ResumeLayout(false);
            this.toolBarApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel toolBarApp;
        private System.Windows.Forms.Label btnSalir;
        private System.Windows.Forms.Label btnGestionaPedidos;
        private System.Windows.Forms.Label btnGestionaInventario;
        private System.Windows.Forms.Label btnVerInventario;
        private System.Windows.Forms.Label btnPedidosPendientes;
        private System.Windows.Forms.Label btnNuevoPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInventario;
    }
}