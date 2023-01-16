using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {

        public Producto() { }

        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, double iVA, string proveedor, string categoria, string subCategoria)
        {
            Nombre = nombre;

            Descripcion = descripcion;

            PrecioCosto = precioCosto;

            Margen = margen;

            IVA = iVA;

            Proveedor = proveedor;

            Categoria = categoria;

            SubCategoria = subCategoria;
        }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal PrecioCosto { get; set; }

        public double Margen { get; set; }

        public double IVA { get; set; }

        public decimal PrecioBruto
        {
            get
            {
                decimal _PrecioBruto = PrecioCosto + (PrecioCosto * Convert.ToDecimal(Margen));
                return _PrecioBruto;
            }
        }

        public decimal PrecioVenta
        {
            get
            {
                decimal _PrecioVenta = PrecioBruto + (PrecioBruto * Convert.ToDecimal(IVA));
                return _PrecioVenta;
            }
        }

        public string Proveedor { get; set; }

        public string Categoria { get; set; }

        public string SubCategoria { get; set; }


    }
}
