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
    public partial class FechaPedidoForm : Form
    {
        public FechaPedidoForm()
        {
            InitializeComponent();
            mostrarDatos();
        }
        FechaPedido fechaPedido = new FechaPedido();
        Conexion conex = new Conexion();
        int idf = -1;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!numericUpDownPedido.Text.Equals("")  && !cmbMes.Text.Equals("") && !cmbanio.Text.Equals(""))
            {
                fechaPedido.NumeroCamion = Convert.ToInt32(numericUpDownPedido.Text);
                fechaPedido.Mes = cmbMes.Text;
                fechaPedido.Anio = cmbanio.Text;

                string consulta = "insert into FechaPedido (numeroCamion, mes, anio) values ("+fechaPedido.NumeroCamion+", '"+fechaPedido.Mes+"','"+fechaPedido.Anio+"')";
                conex.Ejecutar(consulta);
                mostrarDatos();
                limpiar();
                fechaPedido = new FechaPedido();
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos");
            }

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!numericUpDownPedido.Text.Equals("") && !cmbMes.Text.Equals("") && !cmbanio.Text.Equals(""))
            {
                if (MessageBox.Show("Estas seguro de modificar?", "Modificar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fechaPedido.NumeroCamion = Convert.ToInt32(numericUpDownPedido.Text);
                    fechaPedido.Mes = cmbMes.Text;
                    fechaPedido.Anio = cmbanio.Text;

                    string consulta = "update FechaPedido set numeroCamion = "+fechaPedido.NumeroCamion+", mes = '"+fechaPedido.Mes+"', anio ='"+fechaPedido.Anio+"' where id ="+fechaPedido.Id;
                    conex.Ejecutar(consulta);
                    mostrarDatos();
                    limpiar();
                    fechaPedido = new FechaPedido();
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos");
            }

        }
        public void mostrarDatos()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            foreach (FechaPedido item in FechaPedido.listar())
            {
                dataGridView1.Rows.Add(item.Id, item.NumeroCamion, item.Mes, item.Anio);
                dataGridView1.Rows[i].Tag = item;
                i++;
            }
        }
        public void limpiar()
        {
            numericUpDownPedido.Text = 1+"";
            cmbMes.Text = "";
            cmbanio.Text = "";
            idf = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!numericUpDownPedido.Text.Equals("") && !cmbMes.Text.Equals("") && !cmbanio.Text.Equals(""))
            {
                if (MessageBox.Show("¿Estas seguro de eliminar?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string consulta = "delete from FechaPedido where id=" + fechaPedido.Id;
                    conex.Ejecutar(consulta);
                    limpiar();
                    mostrarDatos();
                    fechaPedido = new FechaPedido(); 
                }
   
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fecha de pedido para eliminar");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                fechaPedido.Id = Int32.Parse(fila.Cells["id"].Value + "");
                fechaPedido.NumeroCamion = Int32.Parse(fila.Cells["nropedido"].Value + "");
                fechaPedido.Mes = fila.Cells["mes"].Value + "";
                fechaPedido.Anio = fila.Cells["anio"].Value + "";
                numericUpDownPedido.Text = fechaPedido.NumeroCamion.ToString();
                cmbMes.Text = fechaPedido.Mes;
                cmbanio.Text = fechaPedido.Anio;
                numericUpDownPedido.Focus();
            }
        }
    }
}
