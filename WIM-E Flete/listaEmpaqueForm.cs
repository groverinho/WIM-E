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

namespace WIM_E_Flete
{
    public partial class listaEmpaqueForm : Form
    {
        public listaEmpaqueForm()
        {
            InitializeComponent();
            MostrarFechaPedidos();
        }
        FechaPedido a = new FechaPedido();
        public void MostrarFechaPedidos()
        {
            List<FechaPedido> list = FechaPedido.listarParaCombo();
            cmbFechaPedidos.DataSource = list;
            cmbFechaPedidos.ValueMember = "Id";
            cmbFechaPedidos.DisplayMember = "mes";
        }

        private void cmbFechaPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = (FechaPedido)cmbFechaPedidos.SelectedItem;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            listar(a.Id);
        }

        public static List<object> listar(int idFechaPedido)
        {
           // MessageBox.Show(idFechaPedido+"");
            Conexion conex = new Conexion();
            List<object> lista = new List<object>();
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            Microsoft.Office.Interop.Excel.Range oRange = excel.Columns;
            int i = 2;
            excel.Cells[1, 2] = "NRO. BULTO";
            excel.Cells[1, 2].Borders.Color = Color.Black;
            excel.Cells[1, 2].HorizontalAlignment = Constants.xlCenter;
            excel.Cells[1, 2].EntireRow.Font.Bold = true;
            excel.Cells[1, 5] = "DESCRIPCION";
            excel.Cells[1, 5].Borders.Color = Color.Black;
            excel.Cells[1, 5].HorizontalAlignment = Constants.xlCenter;
            excel.Cells[1, 2].EntireRow.Font.Bold = true;
            string auxNroBult = "#";
            foreach (DataRow item in conex.Seleccionar("select CONVERT(decimal(12,1), REPLACE(lpp.numeroBulto, ',', '.')) AS numeroBulto , lpp.cantidad as cantidad,lpp.tipoCantidad as descripcion, pr.nombre as producto , per.nombre+' '+per.apellidos as cliente from ListaPedidoPersona lpp, Pedido p , Producto pr , FechaPedido f ,Persona per where lpp.idListaPedidoPersona  = p.id and pr.id = lpp.idProducto and f.Id = p.IdFechaPedido and p.idPersona = per.id and p.IdFechaPedido =" + idFechaPedido + " order by  1").Tables[0].Rows)
            {//0 es nro bulto - 1 es cantidad - 2 es descripcion (docena unidad) -  3 es producto - 4 es cliente
            //    string cliente = item[4].ToString();
            /*    if (!item[4].ToString().Equals(excel.Cells[i - 1, 5]))
                {*/
                    excel.Cells[i, 6] = item[4].ToString();
                    excel.Cells[i, 6].Borders.Color = Color.Black;
                    excel.Cells[i, 6].HorizontalAlignment = Constants.xlCenter;
          /*          i++;
                }*/
                    double test = Math.Floor(Double.Parse(item[0].ToString()));
                    if (!(test+"").Equals(auxNroBult))
                    {
                        auxNroBult = test+"";
                         excel.Cells[i, 2] = auxNroBult;
                     } else
                         excel.Cells[i, 2] = "";

                excel.Cells[i, 2].Borders.Color = Color.Black;
                excel.Cells[i, 2].HorizontalAlignment = Constants.xlCenter;

                excel.Cells[i, 3] = Int32.Parse(item[1].ToString());
                excel.Cells[i, 3].Borders.Color = Color.Black;
                excel.Cells[i, 3].HorizontalAlignment = Constants.xlCenter;

                excel.Cells[i, 4] = item[2].ToString();
                excel.Cells[i, 4].Borders.Color = Color.Black;
                excel.Cells[i, 4].HorizontalAlignment = Constants.xlCenter;

                excel.Cells[i, 5] = item[3].ToString();
                excel.Cells[i, 5].Borders.Color = Color.Black;
                excel.Cells[i, 5].HorizontalAlignment = Constants.xlCenter;
                i++;
            }
            oRange.Columns.AutoFit();
            excel.Visible = true;
            return lista;

        }


    }
}
