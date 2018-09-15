namespace WIM_E_Flete
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearFleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoPorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEmpaqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.fechaDePedidosToolStripMenuItem,
            this.crearFleteToolStripMenuItem,
            this.pedidoPorProductoToolStripMenuItem,
            this.listaDeEmpaqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.personaToolStripMenuItem.Text = "Persona";
            this.personaToolStripMenuItem.Click += new System.EventHandler(this.personaToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // fechaDePedidosToolStripMenuItem
            // 
            this.fechaDePedidosToolStripMenuItem.Name = "fechaDePedidosToolStripMenuItem";
            this.fechaDePedidosToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.fechaDePedidosToolStripMenuItem.Text = "Fecha de Pedidos";
            this.fechaDePedidosToolStripMenuItem.Click += new System.EventHandler(this.fechaDePedidosToolStripMenuItem_Click);
            // 
            // crearFleteToolStripMenuItem
            // 
            this.crearFleteToolStripMenuItem.Name = "crearFleteToolStripMenuItem";
            this.crearFleteToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.crearFleteToolStripMenuItem.Text = "Crear Pedido";
            this.crearFleteToolStripMenuItem.Click += new System.EventHandler(this.crearFleteToolStripMenuItem_Click);
            // 
            // pedidoPorProductoToolStripMenuItem
            // 
            this.pedidoPorProductoToolStripMenuItem.Name = "pedidoPorProductoToolStripMenuItem";
            this.pedidoPorProductoToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.pedidoPorProductoToolStripMenuItem.Text = "Pedido por Producto";
            this.pedidoPorProductoToolStripMenuItem.Click += new System.EventHandler(this.pedidoPorProductoToolStripMenuItem_Click);
            // 
            // listaDeEmpaqueToolStripMenuItem
            // 
            this.listaDeEmpaqueToolStripMenuItem.Name = "listaDeEmpaqueToolStripMenuItem";
            this.listaDeEmpaqueToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.listaDeEmpaqueToolStripMenuItem.Text = "Lista de empaque";
            this.listaDeEmpaqueToolStripMenuItem.Click += new System.EventHandler(this.listaDeEmpaqueToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 344);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearFleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoPorProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpaqueToolStripMenuItem;
    }
}

