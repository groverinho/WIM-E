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
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;

namespace WIM_E_Flete
{
    public partial class PedidoProductoForm : Form
    {
        public PedidoProductoForm()
        {
            InitializeComponent();
            MostrarFechaPedidos();
        }
        FechaPedido fechaPedido = new FechaPedido();
        double labelCantidad = 0;
        double labelTotal = 0;
        int labelBultos = 0;
        double labelpBruto = 0;
        double labelpNeto = 0;
        int labelUnidades = 0;

        public void MostrarFechaPedidos()
        {
            List<FechaPedido> list = FechaPedido.listarParaCombo();
            cmbFechaPedidos.DataSource = list;
            cmbFechaPedidos.ValueMember = "Id";
            cmbFechaPedidos.DisplayMember = "mes";
        }
        Conexion conex = new Conexion();
        Regex isNumber = new Regex("[^0-9]");
        Regex isDecimal = new Regex(@"^[0-9]+\.?[0-9]*$");
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de generar el pedido, si ya lo hizo antes perderá los cambios?", "Generar Pedido por producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conex.Ejecutar("DELETE  FROM PedidoProductos where idPedido =" + fechaPedido.Id);
                PedidoProductos pedidoProductos = new PedidoProductos();
                HashSet<int> idProductos = new HashSet<int>();

                List<PedidoProductos> listaPedidoProductos = new List<PedidoProductos>();
                Producto prod = new Producto();
                foreach (DataRow item in conex.Seleccionar("select  pro.id, pro.nombre, l.cantidad , l.tipoCantidad, pro.precio from Pedido p , Persona pe , Producto pro, ListaPedidoPersona l,  FechaPedido f where f.Id = p.IdFechaPedido and p.id= l.idListaPedidoPersona and p.idPersona = pe.id and l.idProducto = pro.id and f.Id =" + fechaPedido.Id).Tables[0].Rows)
                {
                    idProductos.Add(Int32.Parse(item["id"].ToString()));
                }
                foreach (int p in idProductos)
                {
                    double cantProductos = 0;
                    foreach (DataRow item in conex.Seleccionar("select  pro.id, pro.nombre, l.cantidad , l.tipoCantidad, pro.precio from Pedido p , Persona pe , Producto pro, ListaPedidoPersona l,  FechaPedido f where f.Id = p.IdFechaPedido and p.id= l.idListaPedidoPersona and p.idPersona = pe.id and l.idProducto = pro.id and f.Id =" + fechaPedido.Id).Tables[0].Rows)
                    {
                        if (p == Int32.Parse(item["id"].ToString()))
                        {
                            if (item["tipoCantidad"].ToString().Equals("docena"))
                                cantProductos += Double.Parse(item["cantidad"].ToString());
                            else
                                cantProductos += Double.Parse(item["cantidad"].ToString()) / 12;
                            pedidoProductos.Precio = Double.Parse(item["precio"].ToString());
                            prod.Nombre = item["nombre"].ToString();
                            prod.Id = p;
                        }
                    }
                    cantProductos = Math.Round(cantProductos, 1);
                    if (cantProductos % 1 != 0)
                    {
                        String aux = cantProductos.ToString();
                        if (Convert.ToInt32(aux[aux.Length - 1].ToString()) >= 6)
                            cantProductos = Math.Ceiling(cantProductos) - 0.5;
                        else
                            cantProductos = Math.Floor(cantProductos);
                    }
                    pedidoProductos.Producto = (Producto)prod;
                    pedidoProductos.CantidadDocena = cantProductos;
                    pedidoProductos.TipoCantidad = "Doc.";
                    pedidoProductos.Total = Math.Round(cantProductos * pedidoProductos.Precio, 2);
                    pedidoProductos.Unidades = Convert.ToInt32(12 * cantProductos);
                    listaPedidoProductos.Add(pedidoProductos);
                    string auxCantidadDocena = pedidoProductos.CantidadDocena.ToString();
                    auxCantidadDocena = auxCantidadDocena.Replace(",", ".");
                    string auxTotal = pedidoProductos.Total.ToString();
                    auxTotal = auxTotal.Replace(",", ".");
                    string auxPrecio = pedidoProductos.Precio.ToString();
                    auxPrecio = auxPrecio.Replace(",", ".");
                    conex.Ejecutar("insert into PedidoProductos (cantidadDocena,tipoCantidad,idProducto,Precio, total, unidades, idPedido) values (" + auxCantidadDocena + ",'" + pedidoProductos.TipoCantidad + "'," + p + "," + auxPrecio + "," + auxTotal + "," + pedidoProductos.Unidades + "," + fechaPedido.Id + ")");
                    pedidoProductos = new PedidoProductos();
                    prod = new Producto();
                }
                limpiar();
                int i = 0;

                foreach (DataRow item in conex.Seleccionar("select pp.Id, pp.cantidadDocena, pp.tipoCantidad, p.nombre, pp.Precio, pp.total, pp.bultos, pp.pesoBruto, pp.pesoNeto , pp.unidades, pp.total , pp.partidaArancelaria  from PedidoProductos pp,  Producto p ,  FechaPedido f where pp.idPedido = f.id and p.id = pp.idProducto and f.Id = " + fechaPedido.Id).Tables[0].Rows)
                {
                    dataGridView1.Rows.Add(Convert.ToInt32(item["id"]), (i + 1), Convert.ToDouble(item["cantidadDocena"]), item["tipoCantidad"], item["nombre"], Convert.ToDouble(item["Precio"]), Convert.ToDouble(item["total"]), item["bultos"], item["pesoBruto"], item["pesoNeto"], Convert.ToInt32(item["unidades"]), Convert.ToDouble(item["total"]), item["partidaArancelaria"]);
                    labelCantidad += Convert.ToDouble(item["cantidadDocena"]);
                    labelTotal += Convert.ToDouble(item["total"]);
                    labelUnidades += Convert.ToInt32(item["unidades"]);
                    dataGridView1.Rows[i].Tag = item;
                    i++;
                }
                lblCantidad.Text = labelCantidad.ToString();
                lblTotal.Text = labelTotal.ToString();
                lblBultos.Text = labelBultos.ToString();
                lblpbruto.Text = labelpBruto.ToString();
                lblpneto.Text = labelpNeto.ToString();
                lblUnidades.Text = labelUnidades.ToString();
                lbltotal2.Text = labelTotal.ToString();
                pintar();
            }
        }
        public void ver()
        {
            limpiar();
            int i = 0;
            foreach (DataRow item in conex.Seleccionar("select pp.Id, pp.cantidadDocena, pp.tipoCantidad, p.nombre, pp.Precio, pp.total, pp.bultos, pp.pesoBruto, pp.pesoNeto , pp.unidades, pp.total , pp.partidaArancelaria  from PedidoProductos pp,  Producto p ,  FechaPedido f where pp.idPedido = f.id and p.id = pp.idProducto and f.Id = " + fechaPedido.Id).Tables[0].Rows)
            {
                dataGridView1.Rows.Add(Convert.ToInt32(item["id"]), (i + 1), Convert.ToDouble(item["cantidadDocena"]), item["tipoCantidad"], item["nombre"], Convert.ToDouble(item["Precio"]), Convert.ToDouble(item["total"]), item["bultos"], item["pesoBruto"], item["pesoNeto"], Convert.ToInt32(item["unidades"]), Convert.ToDouble(item["total"]), item["partidaArancelaria"]);
                dataGridView1.Rows[i].Tag = item;
                labelCantidad += Convert.ToDouble(item["cantidadDocena"]);
                labelTotal += Convert.ToDouble(item["total"]);
                labelBultos += (item["bultos"].ToString().Length == 0 ? 0 : Convert.ToInt32(item["bultos"]));
                labelpBruto += (item["pesoBruto"].ToString().Length == 0 ? 0.0 : Convert.ToDouble(item["pesoBruto"]));
                labelpNeto += (item["pesoNeto"].ToString().Length == 0 ? 0.0 : Convert.ToDouble(item["pesoNeto"]));
                labelUnidades += Convert.ToInt32(item["unidades"]);
                i++;
            }
            lblCantidad.Text = labelCantidad.ToString();
            lblTotal.Text = labelTotal.ToString();
            lblBultos.Text = labelBultos.ToString();
            lblpbruto.Text = labelpBruto.ToString();
            lblpneto.Text = labelpNeto.ToString();
            lblUnidades.Text = labelUnidades.ToString();
            lbltotal2.Text = labelTotal.ToString();
            pintar();
        }
        private void button1_Click(object sender, EventArgs e) //boton ver
        {
            ver();
        }
        private void cmbFechaPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            fechaPedido = (FechaPedido)cmbFechaPedidos.SelectedItem;
            int idFechaPedido = fechaPedido.Id;
        }
        public bool soloNumeros(string num)//ToDo
        {
            int cantComas = 0;
            int cantNums = 0;
            foreach (char c in num)
            {
                if ((int)c == 44)
                    cantComas++;
                if (cantComas > 1)
                    return false;
                if ((int)c >= 48 && (int)c <= 57)
                    cantNums++;
                if ((int)c >= 48 && (int)c <= 57 || (int)c == 44)//44 is comma // 46 is period
                    continue;
                else
                    return false;
            }
            if (cantNums == 0)
                return false;
            return true;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            int tamanoGrid = this.dataGridView1.Rows.Count;
            for (int i = 0; i < tamanoGrid; i++)
            {
                int id = 0, bultos = 0;
                double pesoBruto = 0, pesoNeto = 0, cantidad = 0, precio = 0, total = 0;
                string partidaArancelaria = "";
                cantidad = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[2].Value.ToString());
                string prec = this.dataGridView1.Rows[i].Cells[5].Value != null ? this.dataGridView1.Rows[i].Cells[5].Value.ToString() : "";
                if (!soloNumeros(prec))
                {
                    bandera = true;
                    MessageBox.Show("Hay un error en la fila " + (i + 1) + " en el campo Precio, revise por favor", "WIN-E Error");
                    break;
                }
                string bult = this.dataGridView1.Rows[i].Cells[7].Value.ToString();
                string pBrut = this.dataGridView1.Rows[i].Cells[8].Value.ToString();
                string pNeto = this.dataGridView1.Rows[i].Cells[9].Value.ToString();
                string parAr = this.dataGridView1.Rows[i].Cells[12].Value != null ? this.dataGridView1.Rows[i].Cells[12].Value.ToString() : "";
                id = Convert.ToInt32(this.dataGridView1.Rows[i].Cells[0].Value);
                bultos = (!bult.Equals("")) ? Convert.ToInt32(bult) : 0;
                pesoBruto = (!pBrut.Equals("")) ? Convert.ToDouble(pBrut) : 0;
                pesoNeto = (!pNeto.Equals("")) ? Convert.ToDouble(pNeto) : 0;
                partidaArancelaria = parAr;
                precio = (!prec.Equals("")) ? Convert.ToDouble(prec) : 0;
                total = precio * cantidad;
                string auxTotal = total.ToString();
                auxTotal = auxTotal.Replace(",", ".");
                string auxPrecio = precio.ToString();
                auxPrecio = auxPrecio.Replace(",", ".");
                string auxCantidad = cantidad.ToString();
                auxCantidad = auxCantidad.Replace(",", ".");

                conex.Seleccionar("update PedidoProductos set bultos = " + bultos + ", pesoBruto = " + pesoBruto + ", pesoNeto=" + pesoNeto + ", partidaArancelaria='" + partidaArancelaria + "' , cantidadDocena=" + auxCantidad + ", Precio=" + auxPrecio + ", total= " + auxTotal + " where id=" + id);
            }
            pintar();
            ver();
            if (!bandera)
            {
                MessageBox.Show("Actualizado Correctamente");
            }

        }
        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string valor = "";
            if (e.ColumnIndex == 7)//bultos
            {
                if (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                }
                else
                {
                    valor = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                }

                if (isNumber.IsMatch(valor))
                {
                    MessageBox.Show("Debe ingresar un numero entero");
                    this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                }
                else
                {
                    if (!valor.Equals(""))
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                    else if (valor.Equals(""))
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                    else
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                }
            }
            else if (e.ColumnIndex == 8 || e.ColumnIndex == 9)//peso bruto y neto
            {
                if (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                }
                else
                {
                    valor = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                }
                if (!isDecimal.IsMatch(valor) || valor[valor.Length - 1] == '.')
                {
                    //  MessageBox.Show("Debe ingresar un numero entero o decimal");
                    this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                }
                else
                {
                    if (!valor.Equals(""))
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                    else if (valor.Equals(""))
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                    else
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                }
            }
            else if (e.ColumnIndex == 12) //partida arancelaria
            {
                if (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                }
                else
                {
                    valor = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                }
                if (!valor.Equals(""))
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                else if (valor.Equals(""))
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
                else
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Tomato;
            }
        }

        public void limpiar()
        {
            dataGridView1.Rows.Clear();
            lblCantidad.Text = "";
            lblTotal.Text = "";
            lblBultos.Text = "";
            lblpbruto.Text = "";
            lblpneto.Text = "";
            lblUnidades.Text = "";
            lbltotal2.Text = "";
            labelCantidad = 0;
            labelTotal = 0;
            labelBultos = 0;
            labelpBruto = 0;
            labelpNeto = 0;
            labelUnidades = 0;
            labelTotal = 0;
        }
        public void pintar()
        {
            int tamanoGrid = this.dataGridView1.Rows.Count;
            for (int i = 0; i < tamanoGrid; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[7].Value == null || this.dataGridView1.Rows[i].Cells[7].Value.ToString().Equals(""))
                    dataGridView1.Rows[i].Cells[7].Style.BackColor = Color.Tomato;
                if (this.dataGridView1.Rows[i].Cells[8].Value == null || this.dataGridView1.Rows[i].Cells[8].Value.ToString().Equals(""))
                    dataGridView1.Rows[i].Cells[8].Style.BackColor = Color.Tomato;
                if (this.dataGridView1.Rows[i].Cells[9].Value == null || this.dataGridView1.Rows[i].Cells[9].Value.ToString().Equals(""))
                    dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.Tomato;
                if (this.dataGridView1.Rows[i].Cells[12].Value == null || this.dataGridView1.Rows[i].Cells[12].Value.ToString().Equals(""))
                    dataGridView1.Rows[i].Cells[12].Style.BackColor = Color.Tomato;
            }
        }
        public static string trucoMostrarFecha(string fecha)
        {
            bool flag = false; string nuevaFecha = "";
            for (int i = 0; i < fecha.Length; i++)
            {
                if (flag)
                    nuevaFecha += fecha[i];
                if (fecha[i] == '/')
                    flag = true;
            }
            nuevaFecha = nuevaFecha.Replace('/', ' ');
            return nuevaFecha;
        }
        public void exportaraexcel(DataGridView tabla)
        {
            if (tabla.Rows.Count != 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int IndiceColumna = 0;
                Microsoft.Office.Interop.Excel.Range oRange = excel.Columns;
                excel.Cells[1, 4] = trucoMostrarFecha(fechaPedido.Mes);
                excel.Cells[1, 4].Borders.Color = Color.Black;
                foreach (DataGridViewColumn col in tabla.Columns) //Columnas
                {
                    if (col.Visible)
                    {
                        IndiceColumna++;
                        excel.Cells[2, IndiceColumna] = col.HeaderText;
                        excel.Cells[2, IndiceColumna].Borders.Color = Color.Black;
                        excel.Cells[2, IndiceColumna].HorizontalAlignment = Constants.xlCenter;
                        excel.Cells[2, 2].EntireRow.Font.Bold = true;
                    }
                }

                int indiceFila = 1;
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
                excel.Cells[indiceFila + 1, 2] = labelCantidad;
                excel.Cells[indiceFila + 1, 2].Borders.Color = Color.Black;
                excel.Cells[indiceFila + 1, 6] = labelTotal;
                excel.Cells[indiceFila + 1, 6].Borders.Color = Color.Black;
                excel.Cells[indiceFila + 1, 7] = labelBultos;
                excel.Cells[indiceFila + 1, 7].Borders.Color = Color.Black;
                excel.Cells[indiceFila + 1, 8] = labelpBruto;
                excel.Cells[indiceFila + 1, 8].Borders.Color = Color.Black;
                excel.Cells[indiceFila + 1, 9] = labelpNeto;
                excel.Cells[indiceFila + 1, 9].Borders.Color = Color.Black;
                excel.Cells[indiceFila + 1, 10] = labelUnidades;
                excel.Cells[indiceFila + 1, 10].Borders.Color = Color.Black;
                excel.Cells[indiceFila + 1, 11] = labelTotal;
                excel.Cells[indiceFila + 1, 11].Borders.Color = Color.Black;
                excel.Visible = true;
            }
            else
            {
                MessageBox.Show("La tabla esta vacia");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridView1);
        }

        private void PedidoProductoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
