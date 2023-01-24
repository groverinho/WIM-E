namespace WIM_E_Flete
{
    partial class PedidoProductoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoProductoForm));
            this.cmbFechaPedidos = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBultos = new System.Windows.Forms.Label();
            this.lblpbruto = new System.Windows.Forms.Label();
            this.lblpneto = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lbltotal2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaAran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFechaPedidos
            // 
            this.cmbFechaPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFechaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFechaPedidos.Location = new System.Drawing.Point(12, 147);
            this.cmbFechaPedidos.Name = "cmbFechaPedidos";
            this.cmbFechaPedidos.Size = new System.Drawing.Size(117, 21);
            this.cmbFechaPedidos.TabIndex = 14;
            this.cmbFechaPedidos.TabStop = false;
            this.cmbFechaPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbFechaPedidos_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(34, 86);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 44);
            this.btnGenerar.TabIndex = 15;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.itemm,
            this.cantDoc,
            this.doc,
            this.descripcion,
            this.precioDoc,
            this.total,
            this.bultos,
            this.pBruto,
            this.pNeto,
            this.unids,
            this.tot,
            this.partidaAran});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(144, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(953, 526);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(144, 568);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 33);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Image = global::WIM_E_Flete.Properties.Resources.excel;
            this.btnExportar.Location = new System.Drawing.Point(1053, 568);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(44, 37);
            this.btnExportar.TabIndex = 19;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(190, 10);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(17, 17);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(598, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 17);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "0";
            // 
            // lblBultos
            // 
            this.lblBultos.AutoSize = true;
            this.lblBultos.Location = new System.Drawing.Point(662, 13);
            this.lblBultos.Name = "lblBultos";
            this.lblBultos.Size = new System.Drawing.Size(13, 13);
            this.lblBultos.TabIndex = 22;
            this.lblBultos.Text = "0";
            // 
            // lblpbruto
            // 
            this.lblpbruto.AutoSize = true;
            this.lblpbruto.Location = new System.Drawing.Point(718, 13);
            this.lblpbruto.Name = "lblpbruto";
            this.lblpbruto.Size = new System.Drawing.Size(13, 13);
            this.lblpbruto.TabIndex = 23;
            this.lblpbruto.Text = "0";
            // 
            // lblpneto
            // 
            this.lblpneto.AutoSize = true;
            this.lblpneto.Location = new System.Drawing.Point(780, 13);
            this.lblpneto.Name = "lblpneto";
            this.lblpneto.Size = new System.Drawing.Size(13, 13);
            this.lblpneto.TabIndex = 24;
            this.lblpneto.Text = "0";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(856, 13);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(13, 13);
            this.lblUnidades.TabIndex = 25;
            this.lblUnidades.Text = "0";
            // 
            // lbltotal2
            // 
            this.lbltotal2.AutoSize = true;
            this.lbltotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal2.Location = new System.Drawing.Point(908, 11);
            this.lbltotal2.Name = "lbltotal2";
            this.lbltotal2.Size = new System.Drawing.Size(16, 17);
            this.lbltotal2.TabIndex = 26;
            this.lbltotal2.Text = "0";
            // 
            // id
            // 
            this.id.FillWeight = 60F;
            this.id.Frozen = true;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Visible = false;
            this.id.Width = 60;
            // 
            // itemm
            // 
            this.itemm.FillWeight = 40F;
            this.itemm.HeaderText = "Item";
            this.itemm.Name = "itemm";
            this.itemm.ReadOnly = true;
            this.itemm.Width = 40;
            // 
            // cantDoc
            // 
            this.cantDoc.FillWeight = 60F;
            this.cantDoc.HeaderText = "Cantidad";
            this.cantDoc.Name = "cantDoc";
            this.cantDoc.ReadOnly = true;
            this.cantDoc.Width = 60;
            // 
            // doc
            // 
            this.doc.FillWeight = 40F;
            this.doc.HeaderText = "Doc.";
            this.doc.Name = "doc";
            this.doc.ReadOnly = true;
            this.doc.Width = 40;
            // 
            // descripcion
            // 
            this.descripcion.FillWeight = 245F;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 245;
            // 
            // precioDoc
            // 
            this.precioDoc.FillWeight = 70F;
            this.precioDoc.HeaderText = "precio/Doc.";
            this.precioDoc.Name = "precioDoc";
            this.precioDoc.Width = 70;
            // 
            // total
            // 
            this.total.FillWeight = 60F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 60;
            // 
            // bultos
            // 
            this.bultos.FillWeight = 50F;
            this.bultos.HeaderText = "Bultos";
            this.bultos.Name = "bultos";
            this.bultos.Width = 50;
            // 
            // pBruto
            // 
            this.pBruto.FillWeight = 70F;
            this.pBruto.HeaderText = "P. Bruto";
            this.pBruto.Name = "pBruto";
            this.pBruto.Width = 70;
            // 
            // pNeto
            // 
            this.pNeto.FillWeight = 70F;
            this.pNeto.HeaderText = "P. Neto";
            this.pNeto.Name = "pNeto";
            this.pNeto.Width = 70;
            // 
            // unids
            // 
            this.unids.FillWeight = 60F;
            this.unids.HeaderText = "Unidades";
            this.unids.Name = "unids";
            this.unids.ReadOnly = true;
            this.unids.Width = 60;
            // 
            // tot
            // 
            this.tot.FillWeight = 60F;
            this.tot.HeaderText = "TOTAL";
            this.tot.Name = "tot";
            this.tot.ReadOnly = true;
            this.tot.Width = 60;
            // 
            // partidaAran
            // 
            this.partidaAran.FillWeight = 119F;
            this.partidaAran.HeaderText = "Partida Arancelaria";
            this.partidaAran.Name = "partidaAran";
            this.partidaAran.Width = 119;
            // 
            // PedidoProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 609);
            this.Controls.Add(this.lbltotal2);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.lblpneto);
            this.Controls.Add(this.lblpbruto);
            this.Controls.Add(this.lblBultos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cmbFechaPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PedidoProductoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos por Producto";
            this.Load += new System.EventHandler(this.PedidoProductoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox cmbFechaPedidos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBultos;
        private System.Windows.Forms.Label lblpbruto;
        private System.Windows.Forms.Label lblpneto;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lbltotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn bultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn unids;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidaAran;
    }
}