using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WIM_E_Flete
{
    public class PedidoProductos
    {
        int id;
        double cantidadDocena;
        string tipoCantidad;
        Producto producto;
        double precio;
        double total;
        int bultos;
        double pesoBruto;
        double pesoNeto;
        int unidades;
        string partidaArancelaria;
        FechaPedido pedido;

        public FechaPedido Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }
        public string PartidaArancelaria
        {
            get { return partidaArancelaria; }
            set { partidaArancelaria = value; }
        }
        public int Unidades
        {
            get { return unidades; }
            set { unidades = value; }
        }
        public double PesoNeto
        {
            get { return pesoNeto; }
            set { pesoNeto = value; }
        }
        public double PesoBruto
        {
            get { return pesoBruto; }
            set { pesoBruto = value; }
        }
        public int Bultos
        {
            get { return bultos; }
            set { bultos = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public Producto Producto
        {
          get { return producto; }
          set { producto = value; }
        }
        public string TipoCantidad
        {
            get { return tipoCantidad; }
            set { tipoCantidad = value; }
        }
        public double CantidadDocena
        {
            get { return cantidadDocena; }
            set { cantidadDocena = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
