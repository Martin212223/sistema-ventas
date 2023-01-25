using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class admProductos
    {
        public static List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();

            return productos;
        }

        public static List<Producto> Listar(string categoria)
        {
            List<Producto> productos = new List<Producto>();

            return productos;
        }

        public static List<Producto> Listar(string categoria, string subCategoria)
        {
            List<Producto> productos = new List<Producto>();

            return productos;
        }

        public static Producto ListarDetalle(string nombre)
        {
            Producto producto = new Producto();

            return producto;
        }
    }
}
