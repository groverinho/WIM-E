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
    public partial class PersonaForm : Form
    {
        public PersonaForm()
        {
            InitializeComponent();
            MostrarPersonas(txtBuscar.Text);
       //     mostrarDatos();
           
        }
        Persona persona = new Persona();
        Conexion conex = new Conexion();
         int id = -1;
         string nombre = "";
         string apellidos = "";
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals("") && !txtApellidos.Text.Equals(""))
            {
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellidos.Text;

                string consulta = "insert into persona (nombre,apellidos) values('" + persona.Nombre + "','" + persona.Apellido + "')";
                conex.Ejecutar(consulta);
                txtBuscar.Text = "";
                MostrarPersonas(txtBuscar.Text);
                //       mostrarDatos();
                limpiar();
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals("") && !txtApellidos.Text.Equals(""))
            {
                if (MessageBox.Show("Estas seguro de modificar?", "Modificar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    persona.Nombre = txtNombre.Text;
                    persona.Apellido = txtApellidos.Text;
                    string consulta = "update persona set nombre = '" + persona.Nombre + "', apellidos= '" + persona.Apellido + "' where id=" + id;
                    conex.Ejecutar(consulta);
                    txtBuscar.Text = "";
                    MostrarPersonas(txtBuscar.Text);
                    //   mostrarDatos();
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una persona para modificar o llene todos los campos");
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
                nombre = fila.Cells["Column2"].Value + "";
                apellidos = fila.Cells["Column3"].Value + "";
                txtNombre.Text = nombre;
                txtApellidos.Text = apellidos;
                txtBuscar.Text = "";
                txtNombre.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!nombre.Equals("") && !apellidos.Equals(""))
            {
                if (MessageBox.Show("Estas seguro de eliminar a " + nombre + " " + apellidos + "?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string consulta = "delete from Persona where id=" + id;
                    conex.Ejecutar(consulta);
                    limpiar();
                    txtBuscar.Text = "";
                    MostrarPersonas(txtBuscar.Text);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una persona para eliminar");
            }
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
     /*   public void mostrarDatos()
        {
            // dataGridView1.Columns(0).Width = 100;
            SqlConnection cn = new SqlConnection(conex.cadena);
            SqlCommand cmd = new SqlCommand("select * from Persona", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cn.Close();
        }*/
        public void limpiar()
        {
            id = -1;
            nombre = "";
            apellidos = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            MostrarPersonas(txtBuscar.Text);
        }
        private void MostrarPersonas(string datos)
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            foreach (Persona item in Persona.listar().FindAll(obj => obj.Nombre.ToUpper().Contains(datos.ToUpper()) || obj.Apellido.ToUpper().Contains(datos.ToUpper())))
            {
                dataGridView1.Rows.Add(item.Id, item.Nombre , item.Apellido);
                dataGridView1.Rows[i].Tag = item;
                i++;
            }
        }
    }
}
