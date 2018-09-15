using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WIM_E_Flete
{
    public  class Persona
    {
        int id;
        string nombre;
        string apellido;
        List<Persona> lista;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set {
                if (value != "")
                {
                    apellido = value;
                }
                else
                {
                    throw new ArgumentException("El apellido no puede estar Vacio");
                }
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value != "")
                {
                    nombre = value;
                }
                else
                {
                    throw new ArgumentException("El nombre no puede estar Vacio");
                }
            }
        }
        public static List<Persona> listar()
        {
            Conexion conex = new Conexion();
          
            List<Persona> lista = new List<Persona>();
            foreach (DataRow item in conex.Seleccionar("select id, nombre, apellidos from Persona order by 1").Tables[0].Rows)
            {  Persona p = new Persona();
            p.Id = Int32.Parse(item["id"].ToString());
                p.Nombre = item["nombre"].ToString();
                p.Apellido = item["apellidos"].ToString();
                lista.Add(p);
            }
            return lista;

        }
    }
        
}
