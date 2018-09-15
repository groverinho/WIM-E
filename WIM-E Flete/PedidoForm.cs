using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
  
namespace WIM_E_Flete
{
    public partial class PedidoForm : Form
    {
        public PedidoForm()
        {      
            InitializeComponent();

            MostrarPersonas(txtPersona.Text);
            MostrarItems(txtItem.Text);
            MostrarPrelista();
            btnModPedido.Enabled = false;
            btnElmPedido.Enabled = false;
            MostrarFechaPedidos();
            MostrarPersonasPedido(txtPedidoPersona.Text);
        }
        FechaPedido a = new FechaPedido();
        Conexion conex = new Conexion();
        Producto producto = new Producto();
        ListaPedidoPersona listaPedidoPersona = new ListaPedidoPersona();
        Pedido pedido = new Pedido();
        Persona persona = new Persona();
        List<ListaPedidoPersona> lista = new List<ListaPedidoPersona>();
        List<ListaPedidoPersona> lista2 = new List<ListaPedidoPersona>();
        double totalPrecio = 0;
        string auxBulto;
        public static int auxIdPersona = 0, auxIdPedidoEnListaPedidoPersona=0;
        public static int idFechaPedido;
        public void MostrarFechaPedidos()
        {
            List<FechaPedido> list = FechaPedido.listarParaCombo();
            cmbFechaPedidos.DataSource = list;
            cmbFechaPedidos.ValueMember = "Id";
            cmbFechaPedidos.DisplayMember = "mes";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {      
        }

        private void txtPersona_KeyDown(object sender, KeyEventArgs e)
        {
            MostrarPersonas(txtPersona.Text);
        }
        private void MostrarPersonas(string datos)
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            foreach (Persona item in Persona.listar().FindAll(obj => obj.Nombre.ToUpper().Contains(datos.ToUpper())))
            {
                dataGridView1.Rows.Add( item.Id, item.Nombre + " "+  item.Apellido);
                dataGridView1.Rows[i].Tag = item;
                i++;
            }
        }
        private void MostrarItems(string datos)
        {
            int i = 0;
            dataGridViewItems.Rows.Clear();
            foreach (Producto item in Producto.listar().FindAll(obj => obj.Nombre.ToUpper().Contains(datos.ToUpper())))
            {
                dataGridViewItems.Rows.Add(item.Id, item.Nombre, (double)item.Precio);
                dataGridViewItems.Rows[i].Tag = item;
                i++;
            }
        }
        private void Mostrarpedidos(int idFechaPedido )
        {
            int i = 0;
            dataGridViewTotalPedidos.Rows.Clear();
            foreach (Pedido item in Pedido.listar(idFechaPedido))
            {
                dataGridViewTotalPedidos.Rows.Add(i + 1, item.IdPersona.Nombre + " " + item.IdPersona.Apellido, item.IdPersona.Id);
                dataGridViewTotalPedidos.Rows[i].Tag = item;
                i++;
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
                pedido.IdPersona.Id = Int32.Parse(fila.Cells["idxx"].Value + "");
                persona.Nombre = fila.Cells["Column1"].Value + "";
                lblCliente.Text = persona.Nombre;
                this.txtItem.Focus();
                lista.Clear();

                MostrarPrelista();
                btnAceptar.Enabled = true;
                btnModPedido.Enabled = false;
                btnElmPedido.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   //boton Cancelar
            this.txtPersona.Text="";
            this.txtPersona.Focus();
            lblCliente.Text = "#####";
            pedido.IdPersona.Id =0;
        }

        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            MostrarItems(txtItem.Text);
        }

        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                this.txtCantida.Focus();
                DataGridViewRow fila = dataGridViewItems.Rows[e.RowIndex];
                listaPedidoPersona.IdProducto.Id = Int32.Parse(fila.Cells["idx"].Value + "");
                listaPedidoPersona.IdProducto.Nombre = fila.Cells["pro"].Value + "";
                listaPedidoPersona.IdProducto.Precio = double.Parse(fila.Cells["pre"].Value + "");
                txtItem.Text = fila.Cells["pro"].Value + "";
            }
            

        }
        public void limpiar()
        {
            txtNroBulto.Text = "";
            txtCantida.Text = "";
            radioButtonDocena.Checked = false;
            radioButtonUnidad.Checked = false;
        }

        public static bool nroBultoValido(string nroBulto)
        {
            Regex rgx = new Regex(@"^[0-9]+([.][0-9]+)?$");
            return rgx.IsMatch(nroBulto) ? true : false;
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (!txtNroBulto.Text.Equals("") && !txtCantida.Text.Equals("") && (radioButtonDocena.Checked || radioButtonUnidad.Checked))
            {
                if (listaPedidoPersona.IdProducto.Id != 0 && nroBultoValido(txtNroBulto.Text))
                {
                    if (radioButtonDocena.Checked)
                        listaPedidoPersona.TipoCantidad = "docena";
                    else if (radioButtonUnidad.Checked)
                        listaPedidoPersona.TipoCantidad = "unidad";
                    listaPedidoPersona.NroBulto = txtNroBulto.Text;
                    listaPedidoPersona.Cantidad = Int32.Parse(txtCantida.Text);
                    listaPedidoPersona.PrecioCantidad = (double)listaPedidoPersona.Cantidad * listaPedidoPersona.IdProducto.Precio;
                    lista.Add(listaPedidoPersona);
                    listaPedidoPersona = new ListaPedidoPersona();
                    MostrarPrelista();
                    limpiar();
                }
                else
                {
                    if (!nroBultoValido(txtNroBulto.Text))
                    {
                        MessageBox.Show("El numero de bulto no tiene formato correcto");
                    }    
                    else 
                    {
                        MessageBox.Show("Por favor seleccione un item ");
                    }
                }                         
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos requeridos");
            }
            
            
        }
        private void MostrarPrelista()
        {
            int i = 0;
            dataGridViewPreLista.Rows.Clear();
            totalPrecio = 0;
            foreach (ListaPedidoPersona item in lista)
            {
                dataGridViewPreLista.Rows.Add( i+1,item.NroBulto, item.Cantidad, item.TipoCantidad, item.IdProducto.Nombre, item.IdProducto.Precio, item.PrecioCantidad, item.IdProducto.Id);
                dataGridViewPreLista.Rows[i].Tag = item;
                totalPrecio += item.PrecioCantidad;
                i++;
            }

            lblTotal.Text = totalPrecio.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //agregar idfechapedido
            int aux = pedido.IdPersona.Id;
            if (pedido.IdPersona.Id != 0 && lista.Count>0)
            {

                pedido.TotalPrecio = totalPrecio;
                string aux3 = pedido.TotalPrecio.ToString();
                aux3 = aux3.Replace(",", ".");
                conex.Ejecutar("insert into Pedido values (" + pedido.IdPersona.Id + "," + aux3 + ","+idFechaPedido+")");
                int lastIdPedido = ultimoIdPedido();
                foreach (ListaPedidoPersona item in lista)
                {
                    string aux4 = item.PrecioCantidad.ToString();
                    aux4 = aux4.Replace(",", ".");
                    conex.Ejecutar("insert into ListaPedidoPersona values(" + lastIdPedido + "," + item.IdProducto.Id + ",'" + item.NroBulto + "'," + item.Cantidad + "," + aux4 + ",'" + item.TipoCantidad + "')");
                }

                lista.Clear();
                pedido = new Pedido();
                MostrarPrelista();
                Mostrarpedidos(idFechaPedido);
                lblCliente.Text = "#####";
            }
            else
            {
                MessageBox.Show("Elija un cliente o escoja al menos un producto");
            }
           
        }

        private void dataGridViewPreLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow fila = dataGridViewPreLista.Rows[e.RowIndex];
         //       ListaPedidoPersona listaPedidoPersona = new ListaPedidoPersona();
                auxBulto = fila.Cells["nrobulto"].Value + "";
                txtNroBulto.Text = fila.Cells["nrobulto"].Value + "";
                txtCantida.Text = fila.Cells["cantidad"].Value + "";
                txtItem.Text = fila.Cells["producto1"].Value + "";
                listaPedidoPersona.IdProducto.Id = Int32.Parse(fila.Cells["idproducto"].Value + "");
                listaPedidoPersona.IdProducto.Nombre = fila.Cells["producto1"].Value + "";
                listaPedidoPersona.IdProducto.Precio = Double.Parse(fila.Cells["precio"].Value + "");
                if ((fila.Cells["tipoCantidad"].Value + "").Equals("docena"))
                {
                    radioButtonDocena.Checked = false;
                    radioButtonUnidad.Checked = false;
                    radioButtonDocena.Checked = true;
                }
                else
                {
                    radioButtonUnidad.Checked = false;
                    radioButtonDocena.Checked = false;
                    radioButtonUnidad.Checked = true;
                }
                txtItem.Text = fila.Cells["producto1"].Value + "";
            }
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            lista.RemoveAll(x => x.NroBulto == auxBulto);
            MostrarPrelista();
        }

        private void btnModificarPedido_Click(object sender, EventArgs e)
        {
            if (!txtNroBulto.Text.Equals("") && !txtCantida.Text.Equals("") && (radioButtonDocena.Checked || radioButtonUnidad.Checked))
            {
                if (listaPedidoPersona.IdProducto.Id != 0 && nroBultoValido(txtNroBulto.Text))
                {
                        lista.RemoveAll(x => x.NroBulto == auxBulto);
                        if (radioButtonDocena.Checked)
                            listaPedidoPersona.TipoCantidad = "docena";
                        else if (radioButtonUnidad.Checked)
                            listaPedidoPersona.TipoCantidad = "unidad";
                        listaPedidoPersona.NroBulto = txtNroBulto.Text;
                        listaPedidoPersona.Cantidad = Int32.Parse(txtCantida.Text);
                        listaPedidoPersona.PrecioCantidad = (double)listaPedidoPersona.Cantidad * listaPedidoPersona.IdProducto.Precio;
                        listaPedidoPersona.IdProducto.Nombre = txtItem.Text;
                        lista.Add(listaPedidoPersona);
                        listaPedidoPersona = new ListaPedidoPersona();
                        MostrarPrelista();
                }
                else
                {
                    if (!nroBultoValido(txtNroBulto.Text))
                    {
                        MessageBox.Show("El numero de bulto no tiene formato correcto");
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione un item ");
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos requeridos");
            }
        }


        public int ultimoIdPedido()
        {
            Conexion conex = new Conexion();
            int num = 0;
            foreach (DataRow item in conex.Seleccionar("Select max(id) as id from Pedido").Tables[0].Rows)
            {
                if (item.IsNull(0))
                    num = 1;
                else
                    num = Convert.ToInt32(item["id"]) ;
            }
            return num;
        }
        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnModPedido_Click(object sender, EventArgs e)
        {
            if (lista.Count>0)
            {
                if (MessageBox.Show("¿Estas seguro de modificar el pedido?", "Modificar Pedido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conex.Ejecutar("delete from ListaPedidoPersona where idListaPedidoPersona = " + auxIdPedidoEnListaPedidoPersona);
                    int[] ids = new int[lista2.Count];
                    foreach (ListaPedidoPersona item in lista)
                    {
                        string aux = item.PrecioCantidad.ToString();
                        aux = aux.Replace(",", ".");
                        conex.Ejecutar("insert into ListaPedidoPersona values(" + auxIdPedidoEnListaPedidoPersona + "," + item.IdProducto.Id + ",'" + item.NroBulto + "'," + (double)item.Cantidad + "," + aux + ",'" + item.TipoCantidad + "')");
                    }
                    string aux2 = totalPrecio.ToString();
                    aux2 = aux2.Replace(",", ".");
                    conex.Ejecutar("update pedido set totalPrecio = " + aux2 + " where id = " + auxIdPedidoEnListaPedidoPersona);
                    lista.Clear();
                    pedido = new Pedido();
                    MostrarPrelista();
                    Mostrarpedidos(idFechaPedido);
                    btnAceptar.Enabled = true;
                    btnModPedido.Enabled = false;
                    btnElmPedido.Enabled = false;
                    auxIdPedidoEnListaPedidoPersona = 0;
                    lblCliente.Text = "#####";
                }
            }
            else
            {
                MessageBox.Show("La lista de pedido no puede quedar vacía, agregue mas productos o elimine el pedido");
            }
        }

        private void dataGridViewTotalPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                btnModPedido.Enabled = true;
                btnElmPedido.Enabled = true;
                DataGridViewRow fila = dataGridViewTotalPedidos.Rows[e.RowIndex];
                persona.Id = Int32.Parse(fila.Cells["idPersona"].Value.ToString());
                persona.Nombre = fila.Cells["NombreCliente"].Value + "";
                auxIdPersona = persona.Id;
                lblCliente.Text = persona.Nombre.ToString();
                int i = 0;
                dataGridViewPreLista.Rows.Clear();
                totalPrecio = 0;
                lista = ListaPedidoPersona.listaPedidos(persona.Id,idFechaPedido);
                lista2 = ListaPedidoPersona.listaPedidos(persona.Id,idFechaPedido);
                foreach (ListaPedidoPersona item in lista )
                {
                    dataGridViewPreLista.Rows.Add(i + 1, item.NroBulto, item.Cantidad, item.TipoCantidad, item.IdProducto.Nombre, item.IdProducto.Precio, item.PrecioCantidad, item.IdProducto.Id);
                    dataGridViewPreLista.Rows[i].Tag = item;
                    totalPrecio += item.PrecioCantidad;
                    auxIdPedidoEnListaPedidoPersona = item.IdListaPedidoPersona;
                    i++;
                }
                lblTotal.Text = totalPrecio.ToString();
                btnAceptar.Enabled = false;
                txtPedidoPersona.Text = "";
                MostrarPersonasPedido("");
            }
            
        }

        private void btnElmPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de eliminar el pedido?", "Eliminar Pedido", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conex.Ejecutar("delete from ListaPedidoPersona where idListaPedidoPersona = " + auxIdPedidoEnListaPedidoPersona);
                conex.Ejecutar("delete from pedido where id = " + auxIdPedidoEnListaPedidoPersona);

                lista.Clear();
                MostrarPrelista();
                Mostrarpedidos(idFechaPedido);
                btnModPedido.Enabled = false;
                btnElmPedido.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCantida_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 8)
                e.Handled = false;
            else if (e.KeyChar == 13)
                e.Handled = false;
            else
            {
                MessageBox.Show("Solo se aceptan números", "WIN-E advertencia");
                e.Handled = true;
            }
        }

        private void txtNroBulto_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cmbFechaPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            a =(FechaPedido) cmbFechaPedidos.SelectedItem;
            idFechaPedido = a.Id;
            Mostrarpedidos(idFechaPedido);
            dataGridViewPreLista.Rows.Clear();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridViewPreLista);
        }
        public void exportaraexcel(DataGridView tabla)
        {
            if (tabla.Rows.Count != 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int IndiceColumna = 0;
                Microsoft.Office.Interop.Excel.Range oRange = excel.Columns;
                string []v = trucoMostrarFecha(a.Mes);
                //oRange.Borders work in this and test all!
                excel.Cells[1, 2] = v[0];
                excel.Cells[1, 2].Borders.Color = Color.Black;
                excel.Cells[1, 2].HorizontalAlignment = Constants.xlCenter;
                excel.Cells[1, 3] = v[2];
                excel.Cells[1, 3].Borders.Color = Color.Black;
                excel.Cells[1, 3].HorizontalAlignment = Constants.xlCenter;
                excel.Cells[1, 4] = v[1];
                excel.Cells[1, 4].Borders.Color = Color.Black;
                excel.Cells[1, 4].HorizontalAlignment = Constants.xlCenter;

                excel.Cells[2, 1] = "Bultos";
                excel.Cells[2, 1].Borders.Color = Color.Black;
                excel.Cells[2, 1].HorizontalAlignment = Constants.xlCenter;
                excel.Cells[2, 2] = "No.";
                excel.Cells[2, 2].Borders.Color = Color.Black;
                excel.Cells[2, 2].HorizontalAlignment = Constants.xlCenter;
                excel.Cells[2, 3].Borders.Color = Color.Black;
                excel.Cells[2, 4].Borders.Color = Color.Black;
                excel.Cells[2, 5] = persona.Nombre;
                excel.Cells[2, 5].HorizontalAlignment = Constants.xlCenter;
                excel.Cells[2, 5].Borders.Color = Color.Black;
                excel.Cells[2, 6] = "Precio";
                excel.Cells[2, 6].Borders.Color = Color.Black;
                excel.Cells[2, 6].HorizontalAlignment = Constants.xlCenter;

                excel.Cells[2, 2].EntireRow.Font.Bold = true;
                int indiceFila =1;
                foreach (DataGridViewRow row in tabla.Rows) //Filas
                {
                    indiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn col in tabla.Columns)
                    {
                        if (col.Visible)
                        {
                            IndiceColumna++;
                            excel.Cells[indiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                            excel.Cells[indiceFila + 1, IndiceColumna].Borders.Color = Color.Black;
                            oRange.Columns.AutoFit();
                        }
                    }
                }
                indiceFila++;
                excel.Cells[indiceFila+1, 6] = "TOTAL";
                excel.Cells[indiceFila + 1, 6].Borders.Color = Color.Black;
                excel.Cells[indiceFila + 1, 7] = lblTotal.Text;
                excel.Cells[indiceFila + 1, 7].Borders.Color = Color.Black;
                oRange.Columns.AutoFit();
                excel.Visible = true;
            }
            else {
                MessageBox.Show("La tabla esta vacia");
            }        
        }
        public static string[] trucoMostrarFecha(string fecha)
        {
            string [] v = fecha.Split('/');
            return v;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItemForm it = new ItemForm();
            it.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            PersonaForm p = new PersonaForm();
            p.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MostrarPersonasPedido(txtPedidoPersona.Text);
        }

        private void MostrarPersonasPedido(string datos)
        {
            int i = 0;
            dataGridViewTotalPedidos.Rows.Clear();
            foreach (Pedido item in Pedido.listar(idFechaPedido).FindAll(obj => obj.IdPersona.Nombre.ToUpper().Contains(datos.ToUpper())))
            {
                dataGridViewTotalPedidos.Rows.Add(i + 1, item.IdPersona.Nombre + " " + item.IdPersona.Apellido, item.IdPersona.Id);
                dataGridViewTotalPedidos.Rows[i].Tag = item;
                i++;
            }
        }
    }
}
