namespace WIM_E_Flete
{
    partial class listaEmpaqueForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFechaPedidos = new System.Windows.Forms.ComboBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha";
            // 
            // cmbFechaPedidos
            // 
            this.cmbFechaPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFechaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFechaPedidos.Location = new System.Drawing.Point(42, 61);
            this.cmbFechaPedidos.Name = "cmbFechaPedidos";
            this.cmbFechaPedidos.Size = new System.Drawing.Size(117, 21);
            this.cmbFechaPedidos.TabIndex = 21;
            this.cmbFechaPedidos.TabStop = false;
            this.cmbFechaPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbFechaPedidos_SelectedIndexChanged);
            // 
            // btnExportar
            // 
            this.btnExportar.Image = global::WIM_E_Flete.Properties.Resources.excel;
            this.btnExportar.Location = new System.Drawing.Point(200, 45);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(72, 37);
            this.btnExportar.TabIndex = 23;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // listaEmpaqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFechaPedidos);
            this.Name = "listaEmpaqueForm";
            this.Text = "Lista de Empaque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbFechaPedidos;

    }
}