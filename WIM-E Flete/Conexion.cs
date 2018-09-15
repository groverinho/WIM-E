using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WIM_E_Flete
{
    public class Conexion
    {
        private SqlConnection Conex;
        private SqlDataAdapter Adaptador;
        private SqlCommand Comando;
        public  static string cadena = @"Data Source=EDUARDOIRUSTA ;Initial Catalog=FleteCamion;Integrated Security=True";
        public Conexion()
        {
            Conex = new SqlConnection(cadena);
        }

        public DataSet Seleccionar(string consulta)
        {
            Adaptador = new SqlDataAdapter(consulta, Conex);
            DataSet ds = new DataSet();
            Adaptador.Fill(ds);
            return ds;
        }
        DataTable dt = new DataTable();
        public DataTable Seleccionar2(string consulta)
        {
            Adaptador = new SqlDataAdapter(consulta, Conex);
            
            Adaptador.Fill(dt);
            return dt;
        }
        public DataTable update(string consulta)
        {
            Adaptador = new SqlDataAdapter(consulta, Conex);
            SqlCommandBuilder scb = new SqlCommandBuilder(Adaptador);
            Adaptador.Update(dt);
            return dt;
        }

        public void Ejecutar(string consulta)
        {
            Comando = new SqlCommand();
            Comando.Connection = Conex;
            //Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = consulta;
            Conex.Open();
            Comando.ExecuteNonQuery();
            Conex.Close();
        }
       

    }
}
