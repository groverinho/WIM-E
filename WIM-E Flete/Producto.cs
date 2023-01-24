using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WIM_E_Flete
{
    public class Producto
    {
        int id;        
        string nombre;
        string tipo;
        string genero;
        string material;
        double precio;
        List<Producto> lista;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
      
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public static List<Producto> listar()
        {
            Conexion conex = new Conexion();

            List<Producto> lista = new List<Producto>();
            foreach (DataRow item in conex.Seleccionar("select id, nombre,tipo, genero, material, precio from producto").Tables[0].Rows)
            {
                Producto p = new Producto();
                p.id = Int32.Parse(item["id"].ToString());
                p.nombre = item["nombre"].ToString();
                p.tipo = item["tipo"].ToString();
                p.genero = item["genero"].ToString();
                p.material = item["material"].ToString();
                p.precio = double.Parse( item["precio"].ToString());
                lista.Add(p);
            }
            return lista;

        }
        public static void pruebita() { }

    }
}
