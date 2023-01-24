using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WIM_E_Flete
{
    public class FechaPedido
    {
        int id;
        int numeroCamion;
        string mes;
        string anio;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int NumeroCamion
        {
            get { return numeroCamion; }
            set { numeroCamion = value; }
        }
        public string Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        
        public string Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        public static List<FechaPedido> listar()
        {
            Conexion conex = new Conexion();

            List<FechaPedido> lista = new List<FechaPedido>();
            foreach (DataRow item in conex.Seleccionar("select  Id, numeroCamion, mes , anio from FechaPedido order by 4 desc").Tables[0].Rows)
            {
                FechaPedido f = new FechaPedido();
                f.id = Int32.Parse(item["Id"].ToString());
                f.numeroCamion = Int32.Parse(item["numeroCamion"].ToString());
                f.mes = item["mes"].ToString();
                f.anio = item["anio"].ToString();
                lista.Add(f);
            }
            return lista;
        }
        public static List<FechaPedido> listarParaCombo()
        {
            Conexion conex = new Conexion();

            List<FechaPedido> lista = new List<FechaPedido>();
            foreach (DataRow item in conex.Seleccionar("select  Id, (Ltrim(str(numeroCamion))+'/'+ mes +'/'+ anio) as fecha from FechaPedido order by 2 desc").Tables[0].Rows)
            {
                FechaPedido f = new FechaPedido();
                f.id = Int32.Parse(item["Id"].ToString());
                f.mes = item["fecha"].ToString();
                lista.Add(f);
            }
            return lista;

        }
    }
}
