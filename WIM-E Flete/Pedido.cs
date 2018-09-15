using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WIM_E_Flete
{
    public class Pedido
    {
        int id;
        Persona idPersona = new Persona();
        ListaPedidoPersona idListaPedidoPersona = new ListaPedidoPersona();
        double totalPrecio;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }       
        public Persona IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }        
        public ListaPedidoPersona IdListaPedidoPersona
        {
            get { return idListaPedidoPersona; }
            set { idListaPedidoPersona = value; }
        }      
        public double TotalPrecio
        {
            get { return totalPrecio; }
            set { totalPrecio = value; }
        }
        public static List<Pedido> listar(int idFechaPedido)
        {
            Conexion conex = new Conexion();

            List<Pedido> lista = new List<Pedido>();
            foreach (DataRow item in conex.Seleccionar("select Pedido.id , idPersona, Persona.nombre+ ' '+ Persona.apellidos as nombreCompleto,totalPrecio from pedido, persona, FechaPedido where Persona.id = Pedido.idPersona and Pedido.IdFechaPedido = FechaPedido.Id and Pedido.IdFechaPedido="+idFechaPedido).Tables[0].Rows)
            {
                Pedido p = new Pedido();
                p.Id = Int32.Parse(item["id"].ToString());
                p.IdPersona.Id = Int32.Parse(item["idPersona"].ToString());
             
                p.idPersona.Nombre = item["nombreCompleto"].ToString();
                p.TotalPrecio = Double.Parse(item["totalPrecio"].ToString());
                lista.Add(p);
            }
            return lista;

        }
       
    }
}
