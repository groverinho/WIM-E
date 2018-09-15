using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WIM_E_Flete
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
            MostrarPersonas(txtBuscar.Text);
            btnEliminar.Enabled = false;
            //mostrarDatos();
        }
        Conexion conex = new Conexion();
        Producto producto = new Producto();
        int id = -1;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!txtTipo.Text.Equals("") && !txtGenero.Text.Equals("") && !txtMaterial.Text.Equals("") && !txtPrecio.Text.Equals(""))
            {
                if (verificaPrecio(txtPrecio.Text))
                {
                    MessageBox.Show("El campo PRECIO no cumple el formato, posiblemente hay dos puntos decimales");
                    txtPrecio.Focus();
                }
                else
                {
                    String auxTipo = txtTipo.Text[0].ToString();
                    auxTipo = auxTipo.ToUpper();
                    producto.Tipo = auxTipo + txtTipo.Text.Substring(1, txtTipo.Text.Length - 1);
                    producto.Genero = txtGenero.Text;
                    producto.Material = txtMaterial.Text;
                    producto.Nombre = producto.Tipo + " para " + producto.Genero + " de " + producto.Material;
                    producto.Precio = double.Parse(txtPrecio.Text);
                    string aux = txtPrecio.Text;
                    aux = aux.Replace(",", ".");
                    string consulta = "insert into producto(nombre, tipo,genero,material,precio) values('" + producto.Nombre + "','" + producto.Tipo + "','" + producto.Genero + "','" + producto.Material + "'," + aux + ")";
                    conex.Ejecutar(consulta);
                    //mostrarDatos();
                    MostrarPersonas(txtBuscar.Text);
                    limpiar();
                    producto = new Producto();
                    btnEliminar.Enabled = false;
                }
                
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos");
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
                id = Int32.Parse(fila.Cells["Column1"].Value + "");
                producto.Nombre = fila.Cells["nombre"].Value + "";
                producto.Tipo = fila.Cells["tipo"].Value + "";
                producto.Genero = fila.Cells["genero"].Value + "";
                producto.Material = fila.Cells["material"].Value + "";
                producto.Precio = double.Parse(fila.Cells["precio"].Value + "");

                txtTipo.Text = producto.Tipo;
                txtGenero.Text = producto.Genero;
                txtMaterial.Text = producto.Material;
                txtPrecio.Text = producto.Precio + "";
                txtBuscar.Text = "";
                txtTipo.Focus();
                btnEliminar.Enabled = true;
            }
        } 

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!txtTipo.Text.Equals("") && !txtGenero.Text.Equals("") && !txtMaterial.Text.Equals("") && !txtPrecio.Text.Equals(""))
            {
                if (verificaPrecio(txtPrecio.Text))
                {
                    MessageBox.Show("El campo PRECIO no cumple el formato, posiblemente hay dos puntos decimales");
                    txtPrecio.Focus();
                }
                else
                {
                    if (MessageBox.Show("Estas seguro de modificar el Item?", "Modificar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        String auxTipo = txtTipo.Text[0].ToString();
                        auxTipo = auxTipo.ToUpper();
                        producto.Tipo = auxTipo + txtTipo.Text.Substring(1, txtTipo.Text.Length - 1);
                        producto.Genero = txtGenero.Text;
                        producto.Material = txtMaterial.Text;
                        producto.Nombre = producto.Tipo + " para " + producto.Genero + " de " + producto.Material;
                        producto.Precio = double.Parse(txtPrecio.Text);
                        string aux = txtPrecio.Text;
                        aux = aux.Replace(",", ".");
                        string consulta = "update Producto set nombre = '" + producto.Nombre + "', tipo= '" + producto.Tipo + "', genero= '" + producto.Genero + "', material= '" + producto.Material + "',precio= " + aux + " where id =" + id;
                        conex.Ejecutar(consulta);
                        //mostrarDatos();
                        MostrarPersonas(txtBuscar.Text);
                        limpiar();
                        producto = new Producto();
                        btnEliminar.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un item para modificar o llene todos los campos");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar " + producto.Nombre +"?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string consulta = "delete from producto where id=" + id;
                conex.Ejecutar(consulta);
                limpiar();
                //mostrarDatos();
                MostrarPersonas(txtBuscar.Text);
                btnEliminar.Enabled = false;
            }
        }
     /*   public void mostrarDatos()
        {
            // dataGridView1.Columns(0).Width = 100;
            SqlConnection cn = new SqlConnection(conex.cadena);
            SqlCommand cmd = new SqlCommand("select * from Producto", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cn.Close();
        }*/

        public void limpiar()
        {
            id = -1;
            txtTipo.Text = "";
            txtGenero.Text = "";
            txtMaterial.Text ="";
            txtPrecio.Text = "";
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            MostrarPersonas(txtBuscar.Text);
        }
        private void MostrarPersonas(string datos)
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            foreach (Producto item in Producto.listar().FindAll(obj => obj.Nombre.ToUpper().Contains(datos.ToUpper()) || obj.Precio.ToString().Contains(datos.ToUpper())))
            {
                dataGridView1.Rows.Add(item.Id, item.Nombre, item.Tipo, item.Genero, item.Material, item.Precio);
                dataGridView1.Rows[i].Tag = item;
                i++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int auxPunto = 0;
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46 && auxPunto < 1)
            {
                e.Handled = false;
                auxPunto++;
            }
            else if (e.KeyChar == 8)
            {

                e.Handled = false;

            }

            else if (e.KeyChar == 13)
            {

                e.Handled = false;

            }
            else if (auxPunto == 1)
            {
                MessageBox.Show("No puede ingresar mas de dos puntos en el campo Precio", "WIN-E advertencia");
                e.Handled = true;
                auxPunto = 0;
            }
            else
            {

                MessageBox.Show("Solo se aceptan números o . para los decimales", "WIN-E advertencia");

                e.Handled = true;

            }
        }
        public bool verificaPrecio(string precio)
        {
            int cont = 0;
            for (int i = 0; i < precio.Length; i++)
            {
                if (precio[i]=='.')
                {
                    cont++;
                }
                if (cont>1)
                {
                    return true; ;
                }
            }
            return false;
        }

        private void txtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
                txtMaterial.Focus();
        }
       
    }
}
