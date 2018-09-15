using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIM_E_Flete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonaForm pf = new PersonaForm();
            pf.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm it = new ItemForm();
            it.ShowDialog();
        }

        private void crearFleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoForm p = new PedidoForm();
            p.ShowDialog();
        }

        private void fechaDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FechaPedidoForm f = new FechaPedidoForm();
            f.ShowDialog();
        }

        private void pedidoPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoProductoForm p = new PedidoProductoForm();
            p.ShowDialog();
        }

        private void listaDeEmpaqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaEmpaqueForm l = new listaEmpaqueForm();
            l.ShowDialog();
        }
    }
}
