using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WIM_E_Flete
{
    public class ListaPedidoPersona
    {
        int id;
        int cantidad ;
        double precioCantidad; 
        string tipoCantidad; 
        Double nroBulto;
        Producto idProducto = new Producto();
        int idListaPedidoPersona;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdListaPedidoPersona
        {
            get { return idListaPedidoPersona; }
            set { idListaPedidoPersona = value; }
        }      
        public Producto IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        public Double NroBulto
        {
            get { return nroBulto; }
            set { nroBulto = value; }
        }
       public string TipoCantidad
        {
            get { return tipoCantidad; }
            set { tipoCantidad = value; }
        }
        public int Cantidad  
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public double PrecioCantidad
        {
            get { return precioCantidad; }
            set { precioCantidad = value; }
        }
        public static List<ListaPedidoPersona> listaPedidos(int idPersona, int idFechaPedido)
        {
            Conexion conex = new Conexion();
            List<ListaPedidoPersona> lista = new List<ListaPedidoPersona>();
            //select lpp.idListaPedidoPersona, lpp.idProducto, pr.nombre, lpp.numeroBulto, lpp.cantidad, lpp.precioCantidad,lpp.tipoCantidad from ListaPedidoPersona as lpp, Pedido p , Producto pr where lpp.idListaPedidoPersona  = p.idListaPedidoPersona and pr.id = lpp.idProducto and p.idPersona=9
            foreach (DataRow item in conex.Seleccionar("select lpp.id, lpp.idListaPedidoPersona, lpp.idProducto, pr.nombre,pr.precio, lpp.numeroBulto, lpp.cantidad, lpp.precioCantidad,lpp.tipoCantidad from ListaPedidoPersona lpp, Pedido p , Producto pr , FechaPedido f where lpp.idListaPedidoPersona  = p.id and pr.id = lpp.idProducto and f.Id = p.IdFechaPedido and p.idPersona="+idPersona+" and p.IdFechaPedido ="+idFechaPedido).Tables[0].Rows)
            {
                ListaPedidoPersona lpp = new ListaPedidoPersona();
                lpp.TipoCantidad = item["tipoCantidad"].ToString();
                lpp.NroBulto = Double.Parse(item["numeroBulto"].ToString().Replace(".",","));
                lpp.Cantidad = Int32.Parse(item["cantidad"].ToString());
                lpp.PrecioCantidad = Double.Parse(item["precioCantidad"].ToString());
                lpp.IdProducto.Id = Int32.Parse(item["idProducto"].ToString());
                lpp.IdProducto.Nombre = item["nombre"].ToString();
                lpp.IdProducto.Precio = Double.Parse( item["precio"].ToString());
                lpp.IdListaPedidoPersona = Int32.Parse(item["idListaPedidoPersona"].ToString());
                lpp.Id = Int32.Parse(item["id"].ToString());
                lista.Add(lpp);
            }
            return lista;
        }
        public static bool cantidadListaPedido(int idListaPedido) {
            Conexion conex = new Conexion();
            foreach (DataRow cantidad in conex.Seleccionar("select count(*) as c from ListaPedidoPersona where idListaPedidoPersona="+idListaPedido).Tables[0].Rows)
            {
                if (Convert.ToInt32(cantidad["c"]) > 0)
                    return true;
                else
                    return false;
            }
            return false;
           
        }


    }
}
