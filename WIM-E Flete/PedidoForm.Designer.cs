namespace WIM_E_Flete
{
    partial class PedidoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoForm));
            this.txtPersona = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idxx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNroBulto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantida = new System.Windows.Forms.TextBox();
            this.radioButtonUnidad = new System.Windows.Forms.RadioButton();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonDocena = new System.Windows.Forms.RadioButton();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.dataGridViewPreLista = new System.Windows.Forms.DataGridView();
            this.Nº = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrobulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFechaPedidos = new System.Windows.Forms.ComboBox();
            this.btnElmPedido = new System.Windows.Forms.Button();
            this.btnModPedido = new System.Windows.Forms.Button();
            this.dataGridViewTotalPedidos = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtPedidoPersona = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreLista)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersona
            // 
            this.txtPersona.Location = new System.Drawing.Point(18, 19);
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(155, 20);
            this.txtPersona.TabIndex = 1;
            this.txtPersona.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPersona_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pedido para:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idxx,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(18, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(155, 571);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idxx
            // 
            this.idxx.HeaderText = "ID";
            this.idxx.Name = "idxx";
            this.idxx.ReadOnly = true;
            this.idxx.Visible = false;
            this.idxx.Width = 24;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 135F;
            this.Column1.HeaderText = "Nombre Completo";
            this.Column1.MinimumWidth = 130;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtPersona);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 700);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtNroBulto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCantida);
            this.groupBox2.Controls.Add(this.radioButtonUnidad);
            this.groupBox2.Controls.Add(this.dataGridViewItems);
            this.groupBox2.Controls.Add(this.radioButtonDocena);
            this.groupBox2.Controls.Add(this.btnAgregarItem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Location = new System.Drawing.Point(217, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 700);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Items";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ir a Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNroBulto
            // 
            this.txtNroBulto.Location = new System.Drawing.Point(400, 105);
            this.txtNroBulto.Name = "txtNroBulto";
            this.txtNroBulto.Size = new System.Drawing.Size(46, 20);
            this.txtNroBulto.TabIndex = 11;
            this.txtNroBulto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroBulto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nro Bulto";
            // 
            // txtCantida
            // 
            this.txtCantida.Location = new System.Drawing.Point(400, 16);
            this.txtCantida.Name = "txtCantida";
            this.txtCantida.Size = new System.Drawing.Size(46, 20);
            this.txtCantida.TabIndex = 9;
            this.txtCantida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantida_KeyPress);
            // 
            // radioButtonUnidad
            // 
            this.radioButtonUnidad.Location = new System.Drawing.Point(349, 73);
            this.radioButtonUnidad.Name = "radioButtonUnidad";
            this.radioButtonUnidad.Size = new System.Drawing.Size(80, 17);
            this.radioButtonUnidad.TabIndex = 10;
            this.radioButtonUnidad.TabStop = true;
            this.radioButtonUnidad.Text = "Unidad";
            this.radioButtonUnidad.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToOrderColumns = true;
            this.dataGridViewItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idx,
            this.pro,
            this.pre});
            this.dataGridViewItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewItems.Location = new System.Drawing.Point(18, 46);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(318, 642);
            this.dataGridViewItems.TabIndex = 2;
            this.dataGridViewItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellClick);
            // 
            // idx
            // 
            this.idx.HeaderText = "ID";
            this.idx.Name = "idx";
            this.idx.ReadOnly = true;
            this.idx.Visible = false;
            // 
            // pro
            // 
            this.pro.FillWeight = 245F;
            this.pro.HeaderText = "Producto";
            this.pro.MinimumWidth = 245;
            this.pro.Name = "pro";
            this.pro.ReadOnly = true;
            this.pro.Width = 245;
            // 
            // pre
            // 
            this.pre.FillWeight = 50F;
            this.pre.HeaderText = "Precio";
            this.pre.MinimumWidth = 50;
            this.pre.Name = "pre";
            this.pre.ReadOnly = true;
            this.pre.Width = 50;
            // 
            // radioButtonDocena
            // 
            this.radioButtonDocena.Location = new System.Drawing.Point(349, 50);
            this.radioButtonDocena.Name = "radioButtonDocena";
            this.radioButtonDocena.Size = new System.Drawing.Size(80, 17);
            this.radioButtonDocena.TabIndex = 10;
            this.radioButtonDocena.TabStop = true;
            this.radioButtonDocena.Text = "Docena";
            this.radioButtonDocena.UseVisualStyleBackColor = true;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(357, 136);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(80, 61);
            this.btnAgregarItem.TabIndex = 12;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(18, 18);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(300, 20);
            this.txtItem.TabIndex = 2;
            this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
            // 
            // dataGridViewPreLista
            // 
            this.dataGridViewPreLista.AllowUserToAddRows = false;
            this.dataGridViewPreLista.AllowUserToDeleteRows = false;
            this.dataGridViewPreLista.AllowUserToOrderColumns = true;
            this.dataGridViewPreLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nº,
            this.nrobulto,
            this.cantidad,
            this.tipoCantidad,
            this.producto1,
            this.precio,
            this.preciocantidad,
            this.idproducto});
            this.dataGridViewPreLista.Location = new System.Drawing.Point(15, 51);
            this.dataGridViewPreLista.Name = "dataGridViewPreLista";
            this.dataGridViewPreLista.ReadOnly = true;
            this.dataGridViewPreLista.RowHeadersVisible = false;
            this.dataGridViewPreLista.Size = new System.Drawing.Size(623, 350);
            this.dataGridViewPreLista.TabIndex = 6;
            this.dataGridViewPreLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPreLista_CellClick);
            // 
            // Nº
            // 
            this.Nº.HeaderText = "Nº";
            this.Nº.Name = "Nº";
            this.Nº.ReadOnly = true;
            this.Nº.Width = 30;
            // 
            // nrobulto
            // 
            this.nrobulto.HeaderText = "Nro Bulto";
            this.nrobulto.Name = "nrobulto";
            this.nrobulto.ReadOnly = true;
            this.nrobulto.Width = 74;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 60;
            // 
            // tipoCantidad
            // 
            this.tipoCantidad.HeaderText = "Tipo";
            this.tipoCantidad.Name = "tipoCantidad";
            this.tipoCantidad.ReadOnly = true;
            this.tipoCantidad.Width = 60;
            // 
            // producto1
            // 
            this.producto1.HeaderText = "Producto";
            this.producto1.MinimumWidth = 245;
            this.producto1.Name = "producto1";
            this.producto1.ReadOnly = true;
            this.producto1.Width = 245;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 60;
            // 
            // preciocantidad
            // 
            this.preciocantidad.HeaderText = "Precio-Cantidad";
            this.preciocantidad.Name = "preciocantidad";
            this.preciocantidad.ReadOnly = true;
            this.preciocantidad.Width = 90;
            // 
            // idproducto
            // 
            this.idproducto.HeaderText = "Column2";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            this.idproducto.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(91, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 18);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "#####";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total.- ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(771, 473);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 22);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(17, 406);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 39);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Crear";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminarPedido);
            this.groupBox3.Controls.Add(this.btnModificarPedido);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnAceptar);
            this.groupBox3.Controls.Add(this.dataGridViewPreLista);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblCliente);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(697, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 453);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crear Pedido";
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Location = new System.Drawing.Point(203, 414);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPedido.TabIndex = 54;
            this.btnEliminarPedido.Text = "Eliminar";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.Location = new System.Drawing.Point(110, 414);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPedido.TabIndex = 11;
            this.btnModificarPedido.Text = "Modificar";
            this.btnModificarPedido.UseVisualStyleBackColor = true;
            this.btnModificarPedido.Click += new System.EventHandler(this.btnModificarPedido_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtPedidoPersona);
            this.groupBox4.Controls.Add(this.btnExportar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmbFechaPedidos);
            this.groupBox4.Controls.Add(this.btnElmPedido);
            this.groupBox4.Controls.Add(this.btnModPedido);
            this.groupBox4.Controls.Add(this.dataGridViewTotalPedidos);
            this.groupBox4.Location = new System.Drawing.Point(697, 491);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(566, 240);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pedidos por Persona";
            // 
            // btnExportar
            // 
            this.btnExportar.Image = global::WIM_E_Flete.Properties.Resources.excel;
            this.btnExportar.Location = new System.Drawing.Point(468, 119);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(44, 37);
            this.btnExportar.TabIndex = 20;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha";
            // 
            // cmbFechaPedidos
            // 
            this.cmbFechaPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFechaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFechaPedidos.Location = new System.Drawing.Point(443, 35);
            this.cmbFechaPedidos.Name = "cmbFechaPedidos";
            this.cmbFechaPedidos.Size = new System.Drawing.Size(117, 21);
            this.cmbFechaPedidos.TabIndex = 13;
            this.cmbFechaPedidos.TabStop = false;
            this.cmbFechaPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbFechaPedidos_SelectedIndexChanged);
            // 
            // btnElmPedido
            // 
            this.btnElmPedido.Location = new System.Drawing.Point(453, 168);
            this.btnElmPedido.Name = "btnElmPedido";
            this.btnElmPedido.Size = new System.Drawing.Size(75, 39);
            this.btnElmPedido.TabIndex = 12;
            this.btnElmPedido.Text = "Eliminar Pedido";
            this.btnElmPedido.UseVisualStyleBackColor = true;
            this.btnElmPedido.Click += new System.EventHandler(this.btnElmPedido_Click);
            // 
            // btnModPedido
            // 
            this.btnModPedido.Location = new System.Drawing.Point(453, 74);
            this.btnModPedido.Name = "btnModPedido";
            this.btnModPedido.Size = new System.Drawing.Size(75, 39);
            this.btnModPedido.TabIndex = 11;
            this.btnModPedido.Text = "Modificar Pedido";
            this.btnModPedido.UseVisualStyleBackColor = true;
            this.btnModPedido.Click += new System.EventHandler(this.btnModPedido_Click);
            // 
            // dataGridViewTotalPedidos
            // 
            this.dataGridViewTotalPedidos.AllowUserToAddRows = false;
            this.dataGridViewTotalPedidos.AllowUserToDeleteRows = false;
            this.dataGridViewTotalPedidos.AllowUserToOrderColumns = true;
            this.dataGridViewTotalPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTotalPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotalPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.NombreCliente,
            this.idPersona});
            this.dataGridViewTotalPedidos.EnableHeadersVisualStyles = false;
            this.dataGridViewTotalPedidos.Location = new System.Drawing.Point(21, 49);
            this.dataGridViewTotalPedidos.Name = "dataGridViewTotalPedidos";
            this.dataGridViewTotalPedidos.ReadOnly = true;
            this.dataGridViewTotalPedidos.RowHeadersVisible = false;
            this.dataGridViewTotalPedidos.Size = new System.Drawing.Size(413, 179);
            this.dataGridViewTotalPedidos.TabIndex = 0;
            this.dataGridViewTotalPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTotalPedidos_CellClick);
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Nº";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            this.Nro.Width = 44;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 96;
            // 
            // idPersona
            // 
            this.idPersona.HeaderText = "id";
            this.idPersona.Name = "idPersona";
            this.idPersona.ReadOnly = true;
            this.idPersona.Visible = false;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(55, 655);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(80, 33);
            this.btnCliente.TabIndex = 14;
            this.btnCliente.Text = "Ir a Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtPedidoPersona
            // 
            this.txtPedidoPersona.Location = new System.Drawing.Point(66, 23);
            this.txtPedidoPersona.Name = "txtPedidoPersona";
            this.txtPedidoPersona.Size = new System.Drawing.Size(111, 20);
            this.txtPedidoPersona.TabIndex = 21;
            this.txtPedidoPersona.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Buscar:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // PedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PedidoForm";
            this.Text = "Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreLista)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonDocena;
        private System.Windows.Forms.RadioButton radioButtonUnidad;
        private System.Windows.Forms.TextBox txtCantida;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtNroBulto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPreLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn pre;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnModificarPedido;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewTotalPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.Button btnModPedido;
        private System.Windows.Forms.Button btnElmPedido;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbFechaPedidos;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nº;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrobulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPedidoPersona;
    }
}